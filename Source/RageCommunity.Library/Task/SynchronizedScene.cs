using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Task
{
    public sealed class SynchronizedScene : IHandleable, IDeletable, ISpatial
    {
        public PoolHandle Handle { get; private set; }
        private uint HandleValue => Handle;
        public float Phase
        {
            get => NativeWrappers.GetSynchronizedScenePhase(HandleValue);
            set => NativeWrappers.SetSynchronizedScenePhase(HandleValue, value);
        }
        public float Rate
        {
            get => NativeWrappers.GetSynchronizedSceneRate(HandleValue);
            set => NativeWrappers.SetSynchronizedSceneRate(HandleValue, value);
        }
        public bool Looped
        {
            get => this is not null && NativeWrappers.IsSynchronizedSceneLooped(HandleValue);
            set => NativeWrappers.SetSynchronizedSceneLooped(HandleValue, value);
        }
        public bool HoldLastFrame
        {
            get => this is not null && NativeWrappers.IsSynchronizedSceneHoldLastFrame(HandleValue);
            set => NativeWrappers.SetSynchronizedSceneHoldLastFrame(HandleValue, value);
        }
        public bool IsRunning => this is not null && NativeWrappers.IsSynchronizedSceneRunning(HandleValue);
        public bool IsAttached { get; private set; } = false;

        public Vector3 Position { get; set; }
        public Rotator Rotation { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="SynchronizedScene"/> class
        /// </summary>
        /// <param name="position">The position <see cref="Vector3"/></param>
        /// <param name="rotator">The rotator</param>
        public SynchronizedScene(Vector3 position, Rotator rotator)
        {
            Position = position;
            Rotation = rotator;
            uint _handle = NativeWrappers.CreateSynchronizedScene(Position, Rotation.Roll, Rotation.Pitch, Rotation.Yaw, 2);
            Handle = new PoolHandle(_handle);
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SynchronizedScene"/> class
        /// </summary>
        public SynchronizedScene(float x, float y, float z, float roll, float pitch, float yaw)
        {
            Position = new Vector3(x, y, z);
            Rotation = new Rotator(pitch, roll, yaw);
            uint _handle = NativeWrappers.CreateSynchronizedScene(Position, Rotation.Roll, Rotation.Pitch, Rotation.Yaw, 2);
            Handle = new PoolHandle(_handle);
        }

        public void AttachToEntity(Entity entity, int entityBoneIndex)
        {
            NativeWrappers.AttachSynchronizedSceneToEntity(HandleValue, entity, entityBoneIndex);
            IsAttached = true;
        }
        public void Detach()
        {
            if (!IsAttached) return;
            NativeWrappers.DetachSynchronizedScene(HandleValue);
            IsAttached = false;
        }

        public void Delete()
        {
            if (IsValid())
            {
                NativeWrappers.DisposeSynchronizedScene(HandleValue);
            }
            else throw new Rage.Exceptions.InvalidHandleableException(this);
        }
        public Rage.Task TaskToPed(Ped ped,
            AnimationDictionary dictionary,
            string animName,
            int duration,
            float speed = 4f,
            float multiplier = -1.5f,
            int flag = 16,
            float playbackRate = 1.5f)
        {
            dictionary.LoadAndWait();
            NativeWrappers.TaskSynchronizedScene(ped, HandleValue, dictionary.Name, animName, speed, multiplier, duration, flag, playbackRate, 0);
            return Rage.Task.GetTask(ped, "TASK_SYNCHRONIZED_SCENE");
        }

        public float DistanceTo(Vector3 position) => Vector3.Distance(Position, position);

        public float DistanceTo(ISpatial spatialObject) => Vector3.Distance(Position, spatialObject.Position);

        public float DistanceTo2D(Vector3 position) => Vector3.Distance2D(Position, position);

        public float DistanceTo2D(ISpatial spatialObject) => Vector3.Distance2D(Position, spatialObject.Position);

        public bool Equals(IHandleable other)
        {
            return other is not null && other is SynchronizedScene && other.Handle == Handle;
        }

        public bool IsValid()
        {
            return this is not null && !Handle.IsZero;
        }

        public float TravelDistanceTo(Vector3 position) => NativeWrappers.CalculateTravelDistanceBetweenPoints(Position, position);

        public float TravelDistanceTo(ISpatial spatialObject)
        {
            return NativeWrappers.CalculateTravelDistanceBetweenPoints(Position, spatialObject.Position);
        }
    }
}
