using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Causes the given vehicle to honk it's horn for a specified duration in seconds.
        /// </summary>
        /// /// <param name="mode">"NORMAL" or "HELDDOWN"</param>
        public static void StartVehicleHorn(Vehicle vehicle, int duration, string mode, bool forever)
        {
            NativeFunction.Natives.START_VEHICLE_HORN(vehicle, duration, mode, forever);
        }
    }
}
