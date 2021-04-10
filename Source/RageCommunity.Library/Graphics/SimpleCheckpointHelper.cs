using System;
using Rage;
using Rage.Native;
using RageCommunity.Library.Wrappers;

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
            var id = NativeWrappers.CreateCheckpoint(47, position, position, radius, red, green, blue, alpha, height);
            NativeWrappers.SetCheckpointCylinderHeight(id, height, height, radius);
            return id;
        }

        public static void Delete(Int32 id)
        {
            NativeWrappers.DeleteCheckpoint(id); 
        }
    }
}