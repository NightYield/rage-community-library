using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Determines if the given entity is playing the specified animation.
        /// </summary>
        public static bool IsEntityPlayingAnimation(Entity entity, string animationDictionary, string animationName)
        {
            return NativeFunction.Natives.IS_ENTITY_PLAYING_ANIM<bool>(entity, animationDictionary, animationName, 3);
        }

        /// <summary>
        /// Sets the max speed of the given entity.
        /// </summary>
        /// <remarks>
        /// Animations may become out of sync if speed is adjusted too much (e.g., running)
        /// </remarks>
        public static void SetEntityMaxSpeed(Entity entity, float speed)
        {
            NativeFunction.Natives.SET_ENTITY_MAX_SPEED(entity, speed);
        }
    }
}
