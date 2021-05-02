using System;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class VehicleExtensions
    {
        /// <summary>
        /// Makes this <see cref="Vehicle"/> honk it's horn for the given <paramref name="duration"/> (in ms).
        /// </summary>
        public static void HonkHorn(this Vehicle vehicle, int duration, bool heldDown = false, bool forever = false) => NativeWrappers.StartVehicleHorn(vehicle, duration, heldDown, forever);
        /// <summary>
        /// get the <see cref="Vehicle"/> display name or the <see cref="Game"/> name
        /// </summary>
        public static string GetDisplayName(this Model vehicleModel)
        {
            string labelName = NativeWrappers.GetDisplayNameFromVehicleModel(vehicleModel.Hash);
            return NativeWrappers.GetLabelText(labelName);
        }
        /// <summary>
        /// get the <see cref="Vehicle"/> manufacturer name
        /// </summary>
        public static string GetMakeName(this Model vehicleModel)
        {
            string labelName = NativeWrappers.GetMakeNameFromVehicleModel(vehicleModel.Hash);
            return NativeWrappers.GetLabelText(labelName);
        }
        /// <summary>
        /// get the <see cref="Vehicle"/> display name or the <see cref="Game"/> name
        /// </summary>
        public static string GetDisplayName(this Vehicle vehicle) => GetDisplayName(vehicle.Model);
        /// <summary>
        /// get the <see cref="Vehicle"/> manufacturer name
        /// </summary>
        public static string GetMakeName(this Vehicle vehicle) => GetMakeName(vehicle.Model);
    }
}
