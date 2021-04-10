using System;
using System.Drawing;
using Rage;
using Rage.Native;
using RageCommunity.Library.Extensions;

namespace RageCommunity.Library.Graphics
{
    /// <summary>
    /// This class represents a checkpoint within GTA V.
    /// </summary>
    /// <remarks>
    /// Originally created by PNWParksFan. 
    /// </remarks>
    public class Checkpoint : IDeletable, ISpatial
    {
        private readonly Boolean setToGround;
        private Color color;
        private Single height;
        private Vector3 nextPosition;
        private Vector3 position;

        public Checkpoint(Vector3 position,
                          Color color,
                          Single radius = 1f,
                          Single height = 1f,
                          Int32 checkpointType = 47,
                          Int32 reserved = 0,
                          Boolean setZtoGround = true) : this(position, position, color, radius, height, checkpointType, reserved, setZtoGround)
        {
        }

        public Checkpoint(Vector3 position,
                          Vector3 nextPosition,
                          Color color,
                          Single radius,
                          Single height,
                          Int32 checkpointType = 0,
                          Int32 reserved = 0,
                          Boolean setZtoGround = true)
        {
            CheckpointType = checkpointType;
            this.position = position;
            this.nextPosition = nextPosition;
            Radius = radius;
            this.color = color;
            Reserved = reserved;
            this.setToGround = setZtoGround;
            this.height = height;

            CreateCheckpoint();
        }

        /// <summary>
        /// The checkpoint types represents how the checkpoints looks in the game. 
        /// </summary>
        /// <remarks>
        /// Checkpoint type 47 for example is a simple cylinder with no arrow or number.
        /// Visit the Grand Theft Auto V Native DB for a list of all checkpoint types. 
        /// </remarks>
        public Int32 CheckpointType { get; }

        public Color Color
        {
            get => this.color;
            set
            {
                this.color = value;
                UpdateColor(value);
            }
        }

        /// <summary>
        /// The ID of this checkpoint.
        /// </summary>
        public Int32 Handle { get; private set; }

        public Single Height
        {
            get => this.height;
            set
            {
                this.height = value;
                SetHeight(this.height, this.height, Radius);
            }
        }

        public Boolean IsValid { get; private set; }

        /// <summary>
        /// The position of the checkpoint after this one. 
        /// </summary>
        public Vector3 NextPosition
        {
            get => this.nextPosition;
            set
            {
                this.nextPosition = value;
                ReCreateCheckpoint();
            }
        }

        public Vector3 Position
        {
            get => this.position;
            set
            {
                this.position = value;
                ReCreateCheckpoint();
            }
        }

        public Single Radius { get; }

        /// <summary>
        /// Some <see cref="CheckpointType"/>s can display an icon or number. The number or icon can be set via this Reserved property. 
        /// </summary>
        public Int32 Reserved { get; }

        public static implicit operator Boolean(Checkpoint checkpoint)
        {
            return checkpoint != null && checkpoint.IsValid;
        }

        public void Delete()
        {
            if (IsValid)
            {
                NativeFunction.CallByName<UInt32>("DELETE_CHECKPOINT", Handle);
            }

            IsValid = false;
        }

        public Single DistanceTo(ISpatial target)
        {
            return Position.DistanceTo(target);
        }

        public Single DistanceTo(Vector3 target)
        {
            return Position.DistanceTo(target);
        }

        public Single DistanceTo2D(Vector3 target)
        {
            return Position.DistanceTo2D(target);
        }

        public Single DistanceTo2D(ISpatial target)
        {
            return Position.DistanceTo2D(target);
        }

        public Single TravelDistanceTo(Vector3 target)
        {
            return Position.TravelDistanceTo(target);
        }

        public Single TravelDistanceTo(ISpatial target)
        {
            return Position.TravelDistanceTo(target);
        }

        private void CreateCheckpoint()
        {
            var checkpointPosition = Position;
            if (this.setToGround)
            {
                checkpointPosition = Position.HeightToGround();
            }

            try
            {
                Handle = NativeFunction.CallByName<Int32>("CREATE_CHECKPOINT",
                                                          CheckpointType,
                                                          checkpointPosition.X,
                                                          checkpointPosition.Y,
                                                          checkpointPosition.Z,
                                                          NextPosition.X,
                                                          NextPosition.Y,
                                                          NextPosition.Z,
                                                          Radius,
                                                          this.color.R,
                                                          this.color.G,
                                                          this.color.B,
                                                          this.color.A,
                                                          Reserved);
                IsValid = true;
                SetHeight(Height, Height, Radius);
                Game.LogTrivialDebug("Created checkpoint, handle = " + Handle);
            }
            catch (Exception e)
            {
                Game.LogTrivialDebug("Exception trying to create checkpoint: " + e.Message);
                Game.LogTrivialDebug(e.StackTrace);
                IsValid = false;
            }
        }

        private void ReCreateCheckpoint()
        {
            Delete();
            CreateCheckpoint();
        }

        private void SetHeight(Single near, Single far, Single radius)
        {
            if (IsValid)
            {
                NativeFunction.CallByName<UInt32>("SET_CHECKPOINT_CYLINDER_HEIGHT", Handle, near, far, radius);
            }
        }

        private void UpdateColor(Color newColor)
        {
            if (IsValid)
            {
                NativeFunction.CallByName<UInt32>("SET_CHECKPOINT_RGBA", newColor.R, newColor.G, newColor.B, newColor.A);
            }
        }
    }
}