using System;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class VehicleExtensions
    {
        /// <summary>
        /// Makes this vehicle honk it's horn for the given <paramref name="duration"/> (in ms).
        /// </summary>
        public static void HonkHorn(this Vehicle vehicle, int duration, bool heldDown = false, bool forever = false) => NativeWrappers.StartVehicleHorn(vehicle, duration, heldDown, forever);
        /// <summary>
        /// get the vehicle display name
        /// </summary>
        public static string GetDisplayName(this Vehicle vehicle)
        {
            string labelName = NativeWrappers.GetDisplayNameFromVehicleModel(vehicle.Model.Hash);
            return NativeWrappers.GetLabelText(labelName);
        }
        /// <summary>
        /// get the vehicle manufacturer name
        /// </summary>
        public static string GetMakeName(this Vehicle vehicle)
        {
            string labelName = NativeWrappers.GetMakeNameFromVehicleModel(vehicle.Model.Hash);
            return NativeWrappers.GetLabelText(labelName);
        }
    }
}
