using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Graphics
{
    public static class SimpleCheckpointHelper
    {
        /// <summary>
        /// Creates a simple, circular checkpoint.
        /// </summary>
        /// <returns>Returns the ID for the created checkpoint. The ID can be used to delete the checkpoint later on.</returns>
        public static Int32 Create(Vector3 position, Single radius = 1f, Single height = 1f)
        {
            return Create(position, radius, 255, 255, 0, 255, height);
        }

        /// <summary>
        /// Creates a simple, circular checkpoint.
        /// </summary>
        /// <returns>Returns the ID for the created checkpoint. The ID can be used to delete the checkpoint later on.</returns>
        public static Int32 Create(Vector3 position, Single radius, Byte red, Byte green, Byte blue, Byte alpha, Single height)
        {
            var id = NativeFunction.Natives.CREATE_CHECKPOINT<Int32>(47, position.X, position.Y, position.Z, position.X, position.Y, position.Z, radius, red, green, blue, alpha, 0);
            NativeFunction.Natives.SET_CHECKPOINT_CYLINDER_HEIGHT(id, height, height, radius);
            return id;
        }

        public static void Delete(Int32 id)
        {
            NativeFunction.Natives.DELETE_CHECKPOINT(id);
        }
    }
}