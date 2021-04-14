using System;
using System.Security.Policy;
using Rage;
using Rage.Native;
using RageCommunity.Library.Attributes;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Varies the horn sound for a vehicle.
        /// </summary>
        [DefectNative("Rich", "A System.ArgumentException 'address can not be zero' is being thrown on call.")]
        public static void SetVehicleHornVariation(Vehicle vehicle, int variation)
        {
            NativeFunction.Natives.x0350E7E17BA767D0(vehicle, variation);
        }

        /// <summary>
        /// Gets the vehicles default horn.
        /// </summary>
        [DefectNative("NightYield", "A System.MissingMethodException is being thrown on call.")]
        public static Hash GetVehicleDefaultHorn(Vehicle vehicle)
        {
            return NativeFunction.Natives.x02165D55000219AC<Hash>(vehicle);
        }

        /// <summary>
        /// Gets the vehicles default horn variation.
        /// </summary>
        [DefectNative("NightYield", "A System.ArgumentException 'address can not be zero' is being thrown on call.")]
        public static int GetVehicleDefaultHornVariation(Vehicle vehicle)
        {
            return NativeFunction.Natives.xD53F3A29BCE2580E<int>(vehicle);
        }
    }
}
