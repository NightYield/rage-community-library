using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Returns a boolean indicating if a cutscene is active.
        /// </summary>
        public static Boolean IsCutsceneActive()
        {
            return NativeFunction.Natives.x991251AFC3981F84<Boolean>();
        }

        /// <summary>
        /// Returns a boolean indicating if a cutscene is currently playing.
        /// </summary>
        public static Boolean IsCutscenePlaying()
        {
            return NativeFunction.Natives.xD3C2E180A40F031E<Boolean>();
        }
    }
}
