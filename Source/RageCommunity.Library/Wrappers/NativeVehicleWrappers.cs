using Rage;
using Rage.Native;
using RageCommunity.Library.Vehicles;

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
        /// Sets the state of the given vehicle's lights
        /// </summary>
        public static void SetVehicleLights(Vehicle vehicle, VehicleLightsState vehicleLightsState) => NativeFunction.Natives.SET_VEHICLE_LIGHTS(vehicle, (int)vehicleLightsState);

        /// <summary>
        /// Toggle's the given vehicle's brake lights on or off
        /// </summary>
        public static void SetVehicleBrakeLights(Vehicle vehicle, bool enabled) => NativeFunction.Natives.SET_VEHICLE_BRAKE_LIGHTS(vehicle, enabled);

        /// <summary>
        /// Applies an amount of <paramref name="damage"/> across a specified <paramref name="radius"/> to a <paramref name="position"/> relative to the vehicle's model.
        /// </summary>
        /// <remarks>
        /// When <paramref name="focusOnModel"/> is set to `true`, the damage sphere will travel towards the vehicle from the given <paramref name="position"/>, thus guaranteeing an impact.
        /// </remarks>
        public static void SetVehicleDamage(Vehicle vehicle, Vector3 position, float damage, float radius, bool focusOnModel) => NativeFunction.Natives.SET_VEHICLE_DAMAGE(vehicle, position, damage, radius, focusOnModel);

        /// <summary>
        /// Fixes the specified window of a given vehicle.
        /// </summary>
        public static void FixVehicleWindow(Vehicle vehicle, Vehicles.VehicleWindow vehicleWindow) => NativeFunction.Natives.FIX_VEHICLE_WINDOW(vehicle, (int)vehicleWindow);

        /// <summary>
        /// Returns true if the given vehicle is damaged.
        /// </summary>
        public static bool IsVehicleDamaged(Vehicle vehicle) => NativeFunction.Natives.xBCDC5017D3CE1E9E<bool>(vehicle);

        /// <summary>
        /// Copies the damage from <paramref name="vehicle"/> to <paramref name="targetVehicle"/>
        /// </summary>
        /// <remarks>
        /// Unlike SetVehicleDamage, there is no audio when the damage is applied.
        /// </remarks>
        public static void CopyVehicleDamages(Vehicle vehicle, Vehicle targetVehicle) => NativeFunction.Natives.xE44A982368A4AF23(vehicle, targetVehicle);
      
       /// <summary>
        /// Get the label of model's display name label
        /// use <see cref="GetLabelText(string)"/> to get the localized name
        /// </summary>
        /// <param name="modelHash">the hash of the model (must be a vehicle model)</param>
        /// <returns>
        /// Returns model name of vehicle in all caps. Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.
        /// </returns>
        public static string GetDisplayNameFromVehicleModel(uint modelHash)
        {
            return NativeFunction.Natives.GET_DISPLAY_NAME_FROM_VEHICLE_MODEL<string>(modelHash);
        }

        /// <summary>
        /// Get the vehicle's manufacturer display label.
        /// use <see cref="GetLabelText(string)"/> to get the localized name
        /// </summary>
        /// <param name="modelHash">The hash of the model (must be a vehicle model)</param>
        /// <returns>
        /// Will return a vehicle's manufacturer display label.
        /// Returns "CARNOTFOUND" if the hash doesn't match a vehicle hash.
        /// </returns>
        public static string GetMakeNameFromVehicleModel(uint modelHash)
        {
            return NativeFunction.Natives.xF7AF4F159FF99F97<string>(modelHash);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="modKit"></param>
        /// <returns></returns>
        public static int GetNumVehicleMods(Vehicle vehicle, int modKit)
        {
            return NativeFunction.Natives.GET_NUM_VEHICLE_MODS<int>(vehicle, modKit);
        }
        /// <summary>
        /// Sets the given <paramref name="vehicle"/> mod
        /// </summary>
        public static void SetVehicleMod(Vehicle vehicle, int modType, int modIndex, bool customTires) => NativeFunction.Natives.SET_VEHICLE_MOD(vehicle, modType, modIndex, customTires);
    }
}
