using System.Drawing;
using Rage;
using Rage.Native;
using RageCommunity.Library.Graphics;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Sets the color of a given checkpoint.
        /// </summary>
        public static void SetCheckpointColor(int handle, Color color)
        {
            NativeFunction.Natives.x7167371E8AD747F7<uint>(handle, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// Sets the icon color of a given checkpoint.
        /// </summary>
        public static void SetCheckpointIconColor(int handle, Color color)
        {
            NativeFunction.Natives.xB9EA40907C680580<uint>(handle, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// Sets the cylinder height of a given checkpoint.
        /// </summary>
        public static void SetCheckpointCylinderHeight(int handle, float nearHeight, float farHeight, float radius)
        {
            NativeFunction.Natives.x2707AAE9D9297D89<uint>(handle, nearHeight, farHeight, radius); 
        }

        /// <summary>
        /// Creates a checkpoint at the given position with the specified values.
        /// </summary>
        public static int CreateCheckpoint(int checkpointType, Vector3 position, Vector3 nextPosition, float radius, Color color, int reserved)
        {
            return CreateCheckpoint(checkpointType, position, nextPosition, radius, color.R, color.G, color.B, color.A, reserved); 
        }

        /// <summary>
        /// Creates a checkpoint at the given position with the specified values.
        /// </summary>
        public static int CreateCheckpoint(int checkpointType, Vector3 position, Vector3 nextPosition, float radius, byte red, byte green, byte blue, byte alpha, int reserved)
        {
            return NativeFunction.Natives.CREATE_CHECKPOINT<int>(checkpointType, position.X, position.Y, position.Z, nextPosition.X, nextPosition.Y, nextPosition.Z, radius, red, green, blue, alpha, reserved);
        }

        /// <summary>
        /// Deletes a checkpoint with the given handle.
        /// </summary>
        public static void DeleteCheckpoint(int handle)
        {
            NativeFunction.Natives.DELETE_CHECKPOINT(handle);
        }

        /// <summary>
        /// When called in a loop, draws a marker with a given marker type with the specified parameters.
        /// </summary>
        public static void DrawMarker(MarkerType type, Vector3 position, Vector3 direction, Vector3 rotation, Vector3 scale, Color color, bool bobUpAndDown, bool faceCamera, bool rotate, bool drawOnEntities)
        {
            NativeFunction.Natives.DRAW_MARKER((int)type, position, direction, rotation, scale, color.R, color.G, color.B, color.A, bobUpAndDown, faceCamera, 2, rotate, 0, 0, drawOnEntities);
        }
    }
}
