using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Task
{
    /// <summary>
    /// Represent a synchronized scene in the game world
    /// </summary>
    /// <remarks>Source: <a href="https://gist.github.com/NoNameSet/02d3ed3b78379f8d71141118bb4fdc2d">Github Gist</a></remarks>
    public sealed class SynchronizedScene : IHandleable, IDeletable, ISpatial
    {
        /// <inheritdoc/>
        public PoolHandle Handle { get; private set; }
        private uint HandleValue => Handle;
        /// <summary>
        /// Gets or sets this <see cref="SynchronizedScene"/> phase
        /// </summary>
        public float Phase
        {
            get => NativeWrappers.GetSynchronizedScenePhase(HandleValue);
            set => NativeWrappers.SetSynchronizedScenePhase(HandleValue, value);
        }
        /// <summary>
        /// Gets or sets this <see cref="SynchronizedScene"/> rate
        /// </summary>
        public float Rate
        {
            get => NativeWrappers.GetSynchronizedSceneRate(HandleValue);
            set => NativeWrappers.SetSynchronizedSceneRate(HandleValue, value);
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SynchronizedScene"/> looped
        /// </summary>
        public bool Looped
        {
            get => this is not null && NativeWrappers.IsSynchronizedSceneLooped(HandleValue);
            set => NativeWrappers.SetSynchronizedSceneLooped(HandleValue, value);
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SynchronizedScene"/> holds the last frame
        /// </summary>
        public bool HoldLastFrame
        {
            get => this is not null && NativeWrappers.IsSynchronizedSceneHoldLastFrame(HandleValue);
            set => NativeWrappers.SetSynchronizedSceneHoldLastFrame(HandleValue, value);
        }
        /// <summary>
        /// Gets a value indicating whether this <see cref="SynchronizedScene"/> is running
        /// </summary>
        /// <value>
        /// <c>true</c> if this <see cref="SynchronizedScene"/> is running, otherwise <c>false</c>
        /// </value>
        public bool IsRunning => this is not null && NativeWrappers.IsSynchronizedSceneRunning(HandleValue);
        /// <summary>
        /// Gets a value indicating whether this <see cref="SynchronizedScene"/> is attached to any <see cref="Entity"/>
        /// </summary>
        /// <value>
        /// <c>true</c> if this <see cref="SynchronizedScene"/> is attached to any <see cref="Entity"/>, otherwise <c>false</c>
        /// </value>
        public bool IsAttached { get; private set; } = false;
        private Vector3 _position;
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Vector3 Position
        {
            get => _position;
            set
            {
                _position = value;
                NativeWrappers.SetSynchronizedSceneOrigin(HandleValue, _position, _rotation.Roll, _rotation.Pitch, _rotation.Yaw);
            }
        }
        private Rotator _rotation;
        /// <summary>
        /// Gets or sets the rotation of this <see cref="SynchronizedScene"/>
        /// </summary>
        public Rotator Rotation
        {
            get => _rotation;
            set
            {
                _rotation = value;
                NativeWrappers.SetSynchronizedSceneOrigin(HandleValue, _position, _rotation.Roll, _rotation.Pitch, _rotation.Yaw);
            }
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SynchronizedScene"/> class
        /// </summary>
        /// <param name="position">The position <see cref="Vector3"/></param>
        /// <param name="rotator">The rotator</param>
        public SynchronizedScene(Vector3 position, Rotator rotator)
        {
            _position = position;
            _rotation = rotator;
            uint _handle = NativeWrappers.CreateSynchronizedScene(Position, Rotation.Roll, Rotation.Pitch, Rotation.Yaw, 2);
            Handle = new PoolHandle(_handle);
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SynchronizedScene"/> class
        /// </summary>
        public SynchronizedScene(float x, float y, float z, float roll, float pitch, float yaw) : this(new Vector3(x, y, z), new Rotator(pitch, roll, yaw))
        {
        }
        /// <summary>
        /// Attach this <see cref="SynchronizedScene"/> to the given <paramref name="entity"/>
        /// </summary>
        public void AttachToEntity(Entity entity, int entityBoneIndex)
        {
            NativeWrappers.AttachSynchronizedSceneToEntity(HandleValue, entity, entityBoneIndex);
            IsAttached = true;
        }
        /// <summary>
        /// Detach this <see cref="SynchronizedScene"/> from any attached <see cref="Entity"/>
        /// </summary>
        public void Detach()
        {
            if (!IsAttached) return;
            NativeWrappers.DetachSynchronizedScene(HandleValue);
            IsAttached = false;
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void Delete()
        {
            if (IsValid())
            {
                NativeWrappers.DisposeSynchronizedScene(HandleValue);
            }
            else throw new Rage.Exceptions.InvalidHandleableException(this);
        }
        /// <summary>
        /// Makes the given <paramref name="ped"/> to perform this <see cref="SynchronizedScene"/>
        /// </summary>        
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
        /// <inheritdoc/>
        public float DistanceTo(Vector3 position) => Vector3.Distance(Position, position);
        /// <inheritdoc/>
        public float DistanceTo(ISpatial spatialObject) => Vector3.Distance(Position, spatialObject.Position);
        /// <inheritdoc/>
        public float DistanceTo2D(Vector3 position) => Vector3.Distance2D(Position, position);
        /// <inheritdoc/>
        public float DistanceTo2D(ISpatial spatialObject) => Vector3.Distance2D(Position, spatialObject.Position);
        /// <inheritdoc/>
        public bool Equals(IHandleable other)
        {
            return other is not null && other is SynchronizedScene && other.Handle == Handle;
        }
        /// <inheritdoc/>
        public bool IsValid()
        {
            return this is not null && !Handle.IsZero;
        }
        /// <inheritdoc/>
        public float TravelDistanceTo(Vector3 position) => NativeWrappers.CalculateTravelDistanceBetweenPoints(Position, position);
        /// <inheritdoc/>
        public float TravelDistanceTo(ISpatial spatialObject)
        {
            return NativeWrappers.CalculateTravelDistanceBetweenPoints(Position, spatialObject.Position);
        }
    }
}
