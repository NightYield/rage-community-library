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
            if (string.IsNullOrWhiteSpace(labelName)) return string.Empty;
            return NativeWrappers.GetLabelText(labelName);
        }
        /// <summary>
        /// Gets this <see cref="Vehicle"/> display name or the <see cref="Game"/> name
        /// </summary>
        /// <exception cref="Rage.Exceptions.InvalidHandleableException"></exception>
        public static string GetDisplayName(this Vehicle vehicle) => GetDisplayName(vehicle.Model);
        /// <summary>
        /// Gets this <see cref="Vehicle"/> manufacturer name
        /// </summary>
        /// <exception cref="Rage.Exceptions.InvalidHandleableException"></exception>
        public static string GetMakeName(this Vehicle vehicle) => GetMakeName(vehicle.Model);
        /// <summary>
        /// Randomise this <see cref="Vehicle"/> license plate
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
                                       Convert.ToChar(MathHelper.GetRandomInteger(65, 90)) +
                                       Convert.ToChar(MathHelper.GetRandomInteger(65, 90)) +
                                       Convert.ToChar(MathHelper.GetRandomInteger(65, 90)) +
                                       MathHelper.GetRandomInteger(9).ToString() +
                                       MathHelper.GetRandomInteger(9).ToString() +
                                       MathHelper.GetRandomInteger(9).ToString();
            }
        }
        /// <summary>
        /// Checks whether this <see cref="Vehicle"/> is stuck on roof
        /// </summary>
        /// <param name="vehicle">The <see cref="Vehicle"/> to check</param>
        /// <returns><c>true</c> if this <see cref="Vehicle"/> is stuck on roof</returns>
        public static bool IsStuckOnRoof(this Vehicle vehicle)
        {
            return NativeWrappers.IsVehicleStuckOnRoof(vehicle);
        }
        /// <summary>
        /// Gets the <see cref="VehicleColor"/> of this <see cref="Vehicle"/>
        /// </summary>
        public static VehicleColor GetColor(this Vehicle vehicle)
        {
            NativeWrappers.GetVehicleColours(vehicle, out int primary, out int secondary);
            VehiclePaint primaryColor = primary >= 0 && primary <= 160 ? (VehiclePaint)primary : VehiclePaint.Unknown;
            VehiclePaint secondaryColor = secondary >= 0 && secondary <= 160 ? (VehiclePaint)secondary : VehiclePaint.Unknown;
            return new VehicleColor(primaryColor, secondaryColor);
        }
        /// <summary>
        /// Sets this <see cref="Vehicle"/> colors
        /// </summary>
        public static void SetColor(this Vehicle vehicle, VehicleColor vehicleColor)
        {
            if (vehicleColor.PrimaryColor == VehiclePaint.Unknown || vehicleColor.SecondaryColor == VehiclePaint.Unknown) throw new NotSupportedException();
            NativeWrappers.SetVehicleColours(vehicle, (int)vehicleColor.PrimaryColor, (int)vehicleColor.SecondaryColor);
        }
        /// <summary>
        /// Sets this <see cref="Vehicle"/> primary and secondary colors
        /// </summary>
        /// <param name="primaryColor">The primary color to be sets</param>
        /// <param name="secondaryColor">The secondary color to be sets</param>
        public static void SetColor(this Vehicle vehicle, VehiclePaint primaryColor, VehiclePaint secondaryColor) => vehicle.SetColor(new VehicleColor(primaryColor, secondaryColor));
        /// <summary>
        /// Sets this <see cref="Vehicle"/> primary color only
        /// </summary>
        /// <param name="primaryColor">The primary color to be sets</param>
        public static void SetColor(this Vehicle vehicle, VehiclePaint primaryColor) => vehicle.SetColor(new VehicleColor(primaryColor, vehicle.GetColor().SecondaryColor));
        /// <summary>
        /// Sets this <see cref="Vehicle"/> forward speed
        /// </summary>
        /// <param name="forwardSpeed">The forward speed in m/s.</param>
        /// <remarks>
        /// <para>Setting the speed to 30 would result in a speed of roughly 60mph, according to speedometer.</para>
        /// <para>To convert m/s to mph use <see cref="MathHelper.ConvertMetersPerSecondToMilesPerHour(float)"/></para>
        /// </remarks>
        public static void SetForwardSpeed(this Vehicle vehicle, float forwardSpeed) => NativeWrappers.SetVehicleForwardSpeed(vehicle, forwardSpeed);
    }
}
