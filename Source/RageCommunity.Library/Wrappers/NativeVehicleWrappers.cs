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
        /// <param name="heldDown">Whether the horn will be held down or honked normally</param>
        public static void StartVehicleHorn(Vehicle vehicle, int duration, bool heldDown, bool forever)
        {
            string mode = !heldDown ? "NORMAL" : "HELDDOWN";
            NativeFunction.Natives.START_VEHICLE_HORN(vehicle, duration, heldDown, forever);
        }
    }
}
