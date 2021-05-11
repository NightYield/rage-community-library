using Rage;
using Rage.Attributes;
using Rage.ConsoleCommands.AutoCompleters;
using RageCommunity.Library.Extensions;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Vehicles;

namespace RageCommunity.Library.TestPlugin
{
    public static class Commands
    {
        [ConsoleCommand("Rage Community Library vehicle horn test")]
        public static void Command_RageLibraryHornTest()
        {
            if (!Game.LocalPlayer.Character.CurrentVehicle)
            {
                var hornConfig = NativeWrappers.GetVehicleDefaultHorn(Game.LocalPlayer.Character.CurrentVehicle);
                Game.LogTrivial($"The default horn for your current vehicle is: {hornConfig}");
            }
        }

        [ConsoleCommand("Rage Community Library zone name test")]
        public static void Command_GetZoneNameForCurrentLocation()
        {
            Game.LogTrivial($"The name of the current zone is: {Game.LocalPlayer.Character.Position.GetZoneName()}");
        }
        [ConsoleCommand("Rage Community Library Vehicle Color Test")]
        public static void Command_GetVehicleColor([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterVehicleAliveOnly))] Vehicle vehicle)
        {
            if (vehicle)
            {
                VehicleColor vehicleColor = vehicle.GetColor();
                System.Collections.Generic.List<string> log = new System.Collections.Generic.List<string>()
                {
                    $"Vehicle: {vehicle.GetDisplayName()}",
                    $"Manufacturer: {vehicle.GetMakeName()}",
                    $"Primary Color:",
                    $"     Name: {vehicleColor.PrimaryColorName}",
                    $"     RGBA: {vehicleColor.PrimaryColorRGBA}",
                    $"Secondary Color:",
                    $"     Name: {vehicleColor.SecondaryColorName}",
                    $"     RGBA: {vehicleColor.SecondaryColorRGBA}",
                };
                log.ForEach(Game.LogTrivial);
                Game.DisplaySubtitle($"Primary: <font color=\"{System.Drawing.ColorTranslator.ToHtml(vehicleColor.PrimaryColorRGBA)}\">{vehicleColor.PrimaryColorName}</font>," +
                    $" Secondary: <font color=\"{System.Drawing.ColorTranslator.ToHtml(vehicleColor.SecondaryColorRGBA)}\">{vehicleColor.SecondaryColorName}</font>");
            }
            else Game.LogTrivial("Vehicle doesn't exist");
        }
        [ConsoleCommand("Rage Community Library Vehicle Color Test")]
        public static void Command_SetVehicleColor([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterVehicleAliveOnly))] Vehicle vehicle,
                                                  [ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] VehiclePaint primary,
                                                  [ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] VehiclePaint secondary)
        {
            if (vehicle)
            {
                VehicleColor vehicleColor = new VehicleColor(primary, secondary);
                vehicle.SetColor(vehicleColor);
                System.Collections.Generic.List<string> log = new System.Collections.Generic.List<string>()
                {
                    $"Vehicle: {vehicle.GetDisplayName()}",
                    $"Manufacturer: {vehicle.GetMakeName()}",
                    $"Primary Color:",
                    $"     Name: {vehicleColor.PrimaryColorName}",
                    $"     RGBA: {vehicleColor.PrimaryColorRGBA}",
                    $"Secondary Color:",
                    $"     Name: {vehicleColor.SecondaryColorName}",
                    $"     RGBA: {vehicleColor.SecondaryColorRGBA}",
                };
                log.ForEach(Game.LogTrivial);
            }
            else Game.LogTrivial("Vehicle doesn't exist");
        }
        [ConsoleCommand("Rage Community Library vehicle color test")]
        public static void Command_GetAllVehicleColor()
        {
            GameFiber fiber=  new GameFiber(() =>
            {
                GameFiber.Wait(20);
                var vehicles = World.GetAllVehicles();
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle)
                    {
                        VehicleColor vehicleColor = vehicle.GetColor();
                        System.Collections.Generic.List<string> log = new System.Collections.Generic.List<string>()
                        {
                            $"Vehicle: {vehicle.GetMakeName()} - {vehicle.GetDisplayName()}",
                            $"Primary: {vehicleColor.PrimaryColorName}",
                            $"Secondary: {vehicleColor.SecondaryColorName}",
                        };
                        Game.LogTrivial(string.Join(", ", log));
                        if (vehicleColor.PrimaryColor == VehiclePaint.Unknown || vehicleColor.SecondaryColor == VehiclePaint.Unknown) Game.LogTrivial("================UNKNOWN COLOR===============");
                    }
                }
            });
            fiber.Start();
        }
    }
}
