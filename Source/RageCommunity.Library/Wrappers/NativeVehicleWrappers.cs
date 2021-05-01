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
            NativeFunction.Natives.START_VEHICLE_HORN(vehicle, duration, mode, forever);
        }
        /// <summary>
        /// get the label of model's display name label
        /// use <see cref="GetLabelText(string)"/> to get the localized name
        /// </summary>
        /// <param name="modelHash"></param>
        /// <returns>
        /// Returns model name of vehicle in all caps. Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.
        /// </returns>
        public static string GetDisplayNameFromVehicleModel(uint modelHash) => NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(modelHash);
        /// <summary>
        /// get the vehicle's manufacturer display label.
        /// use <see cref="GetLabelText(string)"/> to get the localized name
        /// </summary>
        /// <param name="modelHash"></param>
        /// <returns>
        /// Will return a vehicle's manufacturer display label.
        /// Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.
        /// </returns>
        public static string GetMakeNameFromVehicleModel(uint modelHash) => NativeFunction.Natives.xF7AF4F159FF99F97<string>(modelHash);
    }
}
