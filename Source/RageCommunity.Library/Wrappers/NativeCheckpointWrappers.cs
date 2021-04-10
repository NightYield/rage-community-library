using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        public static void SetCheckpointColor(int handle, Color color)
        {
            NativeFunction.Natives.x7167371E8AD747F7<uint>(handle, color.R, color.G, color.B, color.A);
        }

        public static void SetCheckpointIconColor(int handle, Color color)
        {
            NativeFunction.Natives.xB9EA40907C680580<uint>(handle, color.R, color.G, color.B, color.A);
        }

        public static void SetCheckpointCylinderHeight(int handle, float nearHeight, float farHeight, float radius)
        {
            NativeFunction.Natives.xB9EA40907C680580<uint>(handle, nearHeight, farHeight, radius); 
        }

        public static int CreateCheckpoint(Int32 checkpointType, Vector3 position, Vector3 nextPosition, Single radius, Color color, Int32 reserved)
        {
            return NativeFunction.Natives.CREATE_CHECKPOINT<Int32>(checkpointType, position.X, position.Y, position.Z, nextPosition.X, nextPosition.Y, nextPosition.Z, radius, color.R, color.G, color.B, color.A, reserved);
        }

        public static void DeleteCheckpoint(Int32 handle)
        {
            NativeFunction.Natives.DELETE_CHECKPOINT(handle);
        }
    }
}
