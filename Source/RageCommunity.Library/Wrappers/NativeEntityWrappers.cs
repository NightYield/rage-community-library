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
    }
}
