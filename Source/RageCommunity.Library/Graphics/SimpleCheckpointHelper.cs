using System;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Graphics
{
    public static class SimpleCheckpointHelper
    {
        /// <summary>
        /// Creates a simple, circular checkpoint.
        /// </summary>
        /// <returns>Returns the ID for the created checkpoint. The ID can be used to delete the checkpoint later on.</returns>
        public static int Create(Vector3 position, float radius = 1f, float height = 1f)
        {
            return Create(position, radius, 255, 255, 0, 255, height);
        }

        /// <summary>
        /// Creates a simple, circular checkpoint.
        /// </summary>
        /// <returns>Returns the ID for the created checkpoint. The ID can be used to delete the checkpoint later on.</returns>
        public static int Create(Vector3 position, float radius, byte red, byte green, byte blue, byte alpha, float height)
        {
            var id = NativeWrappers.CreateCheckpoint(47, position, position, radius, red, green, blue, alpha, 0);
            NativeWrappers.SetCheckpointCylinderHeight(id, height, height, radius);
            return id;
        }

        public static void Delete(int id)
        {
            NativeWrappers.DeleteCheckpoint(id); 
        }
    }
}