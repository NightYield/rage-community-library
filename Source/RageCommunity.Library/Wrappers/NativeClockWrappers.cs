using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Sets the clock time.
        /// </summary>
        public static void SetClockTime(int hour, int minute, int second)
        {
            NativeFunction.Natives.x47C3B5848C3E45D8(hour, minute, second);
        }
    }
}
