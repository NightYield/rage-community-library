using System;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// Sets the max <paramref name="speed"/> of this entity.
        /// </summary>
        /// <remarks>
        /// Animations may become out of sync if speed is adjusted too much (e.g., running)
        /// </remarks>
        public static void SetMaxSpeed(this Entity entity, float speed)
        {
            NativeWrappers.SetEntityMaxSpeed(entity, speed);
        }
    }
}
