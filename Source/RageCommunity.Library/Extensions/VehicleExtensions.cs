using System;
using Rage;
using RageCommunity.Library.Vehicles;
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
        /// Sets the state of this vehicle's lights
        /// </summary>
        public static void SetLights(this Vehicle vehicle, VehicleLightsState vehicleLightsState) => NativeWrappers.SetVehicleLights(vehicle, vehicleLightsState);

        /// <summary>
        /// Toggle's this vehicle's brake lights on or off
        /// </summary>
        public static void SetBrakeLights(this Vehicle vehicle, bool enabled) => NativeWrappers.SetVehicleBrakeLights(vehicle, enabled);

        /// <summary>
        /// Applies an amount of <paramref name="damage"/> across a specified <paramref name="radius"/> to a <paramref name="position"/> relative to the vehicle's model.
        /// </summary>
        /// <remarks>
        /// When <paramref name="focusOnModel"/> is set to `true`, the damage sphere will travel towards the vehicle from the given <paramref name="position"/>, thus guaranteeing an impact.
        /// </remarks>
        public static void SetVehicleDamage(this Vehicle vehicle, Vector3 position, float damage, float radius, bool focusOnModel) => NativeWrappers.SetVehicleDamage(vehicle, position, damage, radius, focusOnModel);

        /// <summary>
        /// Fixes the specified window of this vehicle.
        /// </summary>
        public static void FixWindow(Vehicle vehicle, Vehicles.VehicleWindow vehicleWindow) => NativeWrappers.FixVehicleWindow(vehicle, vehicleWindow);

        /// <summary>
        /// Fixes all windows of this vehicle.
        /// </summary>
        public static void FixAllWindows(Vehicle vehicle, Vehicles.VehicleWindow vehicleWindow)
        {
            foreach(Vehicles.VehicleWindow window in Enum.GetValues(typeof(Vehicles.VehicleWindow)))
            {
                NativeWrappers.FixVehicleWindow(vehicle, window);
            }
        }

        /// <summary>
        /// Returns true if this vehicle is damaged.
        /// </summary>
        public static bool IsDamaged(this Vehicle vehicle) => NativeWrappers.IsVehicleDamaged(vehicle);

        /// <summary>
        /// Copies the damage from this vehicle to <paramref name="targetVehicle"/>
        /// </summary>
        /// <remarks>
        /// Unlike SetVehicleDamage, there is no audio when the damage is applied.
        /// </remarks>
        public static void CopyVehicleDamages(this Vehicle vehicle, Vehicle targetVehicle) => NativeWrappers.CopyVehicleDamages(vehicle, targetVehicle);
    }
}
