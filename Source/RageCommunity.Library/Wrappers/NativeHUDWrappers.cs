using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Controls the display of the HUD
        /// </summary>
        /// <param name="toggle">Using true will enable the HUD.</param>
        public static void DisplayHud(bool toggle)
        {
            NativeFunction.Natives.xA6294919E56FF02A(toggle);
        }
    }
}
