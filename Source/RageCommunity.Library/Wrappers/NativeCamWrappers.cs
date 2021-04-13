using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Resets the vehicle idle camera timer. Calling this in a loop every 10 seconds is enough to disable the idle camera in vehicles.
        /// </summary>
        public static void InvalidateVehicleIdleCam()
        {
            NativeFunction.Natives.x9E4CFFF989258472();
        }

        /// <summary>
        /// Resets the idle camera timer. Calling this in a loop every 10 seconds is enough to disable the idle camera.
        /// </summary>
        public static void InvalidateIdleCam()
        {
            NativeFunction.Natives.xF4F2C0D4EE209E20();
        }
    }
}
