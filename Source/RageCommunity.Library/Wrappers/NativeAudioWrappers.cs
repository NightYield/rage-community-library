using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Varies the horn sound for a vehicle.
        /// </summary>
        public static void SetVehicleHornVariation(Vehicle vehicle, int variation)
        {
            NativeFunction.Natives.x0350E7E17BA767D0(vehicle, variation);
        }
    }
}
