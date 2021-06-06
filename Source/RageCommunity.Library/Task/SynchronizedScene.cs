using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rage;
using static Rage.Native.NativeFunction;

namespace RageCommunity.Library.Task
{
    public sealed class SynchronizedScene : IHandleable, IDeletable, ISpatial
    {
        public PoolHandle Handle { get; private set; }
        private uint HandleValue => Handle;
        public float Phase
        {
            get => Natives.GET_SYNCHRONIZED_SCENE_PHASE<float>(HandleValue);
            set => Natives.SET_SYNCHRONIZED_SCENE_PHASE(HandleValue, value);
        }
        public float Rate
        {
            get => Natives.GET_SYNCHRONIZED_SCENE_RATE<float>(HandleValue);
            set => Natives.SET_SYNCHRONIZED_SCENE_RATE(HandleValue, value);
        }
        public bool Looped
        {
            get => this is not null && Natives.IS_SYNCHRONIZED_SCENE_LOOPED<bool>(HandleValue);
            set => Natives.SET_SYNCHRONIZED_SCENE_LOOPED(HandleValue, value);
        }
        public bool HoldLastFrame
        {
            get => this is not null && Natives.IS_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME<bool>(HandleValue);
            set => Natives.SET_SYNCHRONIZED_SCENE_HOLD_LAST_FRAME(HandleValue, value);
        }
        public bool IsRunning => this is not null && Natives.IS_SYNCHRONIZED_SCENE_RUNNING<bool>(HandleValue);
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
            uint _handle = Natives.CREATE_SYNCHRONIZED_SCENE<uint>(Position.X, Position.Y, Position.Z, Rotation.Roll, Rotation.Pitch, Rotation.Yaw, 2);
            Handle = new PoolHandle(_handle);
            InternalList.Add(this);
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SynchronizedScene"/> class
        /// </summary>
        public SynchronizedScene(float x, float y, float z, float roll, float pitch, float yaw)
        {
            Position = new Vector3(x, y, z);
            Rotation = new Rotator(pitch, roll, yaw);
            uint _handle = Natives.CREATE_SYNCHRONIZED_SCENE<uint>(Position.X, Position.Y, Position.Z, Rotation.Roll, Rotation.Pitch, Rotation.Yaw, 2);
            Handle = new PoolHandle(_handle);
            InternalList.Add(this);
        }

        public void AttachToEntity(Entity entity, int entityBoneIndex)
        {
            Natives.ATTACH_SYNCHRONIZED_SCENE_TO_ENTITY(HandleValue, entity, entityBoneIndex);
            IsAttached = true;
        }
        public void Detach()
        {
            if (!IsAttached) return;
            Natives.DETACH_SYNCHRONIZED_SCENE(HandleValue);
            IsAttached = false;
        }

        public void Delete()
        {
            if (IsValid())
            {
                Natives.xCD9CC7E200A52A6F(HandleValue);
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
            Natives.TASK_SYNCHRONIZED_SCENE(ped, HandleValue, dictionary.Name, animName, speed, multiplier, duration, flag, playbackRate, 0);
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

        public float TravelDistanceTo(Vector3 position) => Natives.CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS<float>(Position.X, Position.Y, Position.Z, position.X, position.Y, position.Z);

        public float TravelDistanceTo(ISpatial spatialObject)
            => Natives.CALCULATE_TRAVEL_DISTANCE_BETWEEN_POINTS<float>(Position.X, Position.Y, Position.Z, spatialObject.Position.X, spatialObject.Position.Y, spatialObject.Position.Z);
        internal static List<SynchronizedScene> InternalList = new List<SynchronizedScene>();
        public static Vector3 GetAnimationInitialOffsettPosition(AnimationDictionary dictionary, string animName, Vector3 pos, Rotator rotator)
        {
            dictionary.LoadAndWait();
            Vector3 rotation = rotator.ToVector();
            Vector3 ret = Natives.GET_ANIM_INITIAL_OFFSET_POSITION<Vector3>(dictionary.Name, animName, pos.X, pos.Y, pos.Z, rotation.X, rotation.Y, rotation.Z, 0, 2);
            return ret;
        }
        public static Rotator GetAnimationInitialOffsettRotation(AnimationDictionary dictionary, string animName, Vector3 pos, Rotator rotator)
        {
            dictionary.LoadAndWait();
            Vector3 rotation = rotator.ToVector();
            Vector3 ret = Natives.GET_ANIM_INITIAL_OFFSET_ROTATION<Vector3>(dictionary.Name, animName, pos.X, pos.Y, pos.Z, rotation.X, rotation.Y, rotation.Z, 0, 2);
            return ret.ToRotator();
        }
        internal static void DeleteAllSynchronizedScene()
        {
            if (!System.Linq.Enumerable.Any(InternalList)) return;
            foreach (SynchronizedScene scene in InternalList)
            {
                if (scene is not null && scene.IsValid())
                {
                    scene.Delete();
                }
            }
        }
    }
}
