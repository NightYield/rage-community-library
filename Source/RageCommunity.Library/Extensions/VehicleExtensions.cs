using System;
using Rage;
using RageCommunity.Library.Vehicles;
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

        /// <summary>
        /// get the vehicle <see cref="Model"/> display name or the <see cref="Game"/> name
        /// </summary>
        /// <param name="vehicleModel">the <see cref="Model"/>. (must be a vehicle model)</param>
        public static string GetDisplayName(this Model vehicleModel)
        {
            string labelName = NativeWrappers.GetDisplayNameFromVehicleModel(vehicleModel.Hash);
            return NativeWrappers.GetLabelText(labelName);
        }
        /// <summary>
        /// get the vehicle <see cref="Model"/> manufacturer name
        /// </summary>
        /// <param name="vehicleModel">the <see cref="Model"/>. (must be a vehicle model)</param>
        public static string GetMakeName(this Model vehicleModel)
        {
            string labelName = NativeWrappers.GetMakeNameFromVehicleModel(vehicleModel.Hash);
            return NativeWrappers.GetLabelText(labelName);
        }
        /// <summary>
        /// get the <see cref="Vehicle"/> display name or the <see cref="Game"/> name
        /// </summary>
        /// <exception cref="Rage.Exceptions.InvalidHandleableException"></exception>
        public static string GetDisplayName(this Vehicle vehicle) => GetDisplayName(vehicle.Model);
        /// <summary>
        /// get the <see cref="Vehicle"/> manufacturer name
        /// </summary>
        /// <exception cref="Rage.Exceptions.InvalidHandleableException"></exception>
        public static string GetMakeName(this Vehicle vehicle) => GetMakeName(vehicle.Model);
        /// <summary>
        /// randomise the given <paramref name="vehicle"/> license plate
        /// </summary>
        /// <remarks>
        /// Source: <a href="https://github.com/Albo1125/Albo1125-Common/blob/master/Albo1125.Common/CommonLibrary/ExtensionMethods.cs#L454"></a>
        /// </remarks>
        public static void RandomiseLicensePlate(this Vehicle vehicle)
        {
            if (vehicle)
            {
                vehicle.LicensePlate = MathHelper.GetRandomInteger(9).ToString() +
                                       MathHelper.GetRandomInteger(9).ToString() +
                                       Convert.ToChar(MathHelper.GetRandomInteger(0, 25) + 65) +
                                       Convert.ToChar(MathHelper.GetRandomInteger(0, 25) + 65) +
                                       Convert.ToChar(MathHelper.GetRandomInteger(0, 25) + 65) +
                                       MathHelper.GetRandomInteger(9).ToString() +
                                       MathHelper.GetRandomInteger(9).ToString() +
                                       MathHelper.GetRandomInteger(9).ToString();
            }
        }
    }
}
