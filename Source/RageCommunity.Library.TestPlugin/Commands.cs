using Rage;
using Rage.Attributes;
using Rage.ConsoleCommands.AutoCompleters;
using RageCommunity.Library.Extensions;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Vehicles;
using RageCommunity.Library.Peds.Freemode;
using System.Collections.Generic;
using System;

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
        [ConsoleCommand("Rage Community Library GetVehicleColor Test")]
        public static void Command_GetVehicleColor([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterVehicleAliveOnly))] Vehicle vehicle)
        {
            if (vehicle)
            {
                VehicleColor vehicleColor = vehicle.GetColor();
                List<string> log = new List<string>()
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
        [ConsoleCommand("Rage Community Library SetVehicleColor Test")]
        public static void Command_SetVehicleColor([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterVehicleAliveOnly))] Vehicle vehicle,
                                                  [ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] VehiclePaint primary,
                                                  [ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] VehiclePaint secondary)
        {
            if (vehicle)
            {
                VehicleColor vehicleColor = new VehicleColor(primary, secondary);
                vehicle.SetColor(vehicleColor);
                List<string> log = new List<string>()
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
        [ConsoleCommand("Rage Community Library GetAllVehicleColors test")]
        public static void Command_GetAllVehicleColor()
        {
             GameFiber.StartNew(() =>
            {
                var vehicles = World.GetAllVehicles();
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle)
                    {
                        VehicleColor vehicleColor = vehicle.GetColor();
                        List<string> log = new List<string>()
                        {
                            $"Vehicle: {vehicle.GetMakeName()} - {vehicle.GetDisplayName()}",
                            $"Primary: {vehicleColor.PrimaryColorName}",
                            $"Secondary: {vehicleColor.SecondaryColorName}",
                        };
                        Game.LogTrivial(string.Join(", ", log));
                        if (vehicleColor.PrimaryColor == VehiclePaint.Unknown || vehicleColor.SecondaryColor == VehiclePaint.Unknown) 
                        {
                             Game.LogTrivial("================UNKNOWN COLOR===============");
                        }
                    }
                }
            }, "GetAllVehicleColors Command Fiber");
        }

        [ConsoleCommand("Rage Community Library Delete Entity")]
        public static void Command_DeleteEntity([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterEntity))] Entity entity)
        {
            if (entity)
            {
                entity.Delete();
            }
        }

        [ConsoleCommand("Rage Community Library Delete Vehicle")]
        public static void Command_DeleteVehicle([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterVehicle))] Vehicle vehicle)
        {
            if (vehicle)
            {
                vehicle.Delete();
            }
        }

        [ConsoleCommand("Rage Community Library Delete Ped")]
        public static void Command_DeletePed([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterPed))] Ped ped)
        {
            if(ped)
            {
                ped.Delete();
            }
        }

        [ConsoleCommand("Rage Community Library spawn AmbientFemale model")]
        public static void Command_SpawnAmbientFemaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.AmbientFemale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn AmbientMale model")]
        public static void Command_SpawnAmbientMaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.AmbientMale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn Animal model")]
        public static void Command_SpawnAnimalModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.Animal model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn Cutscene model")]
        public static void Command_SpawnCutsceneModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.Cutscene model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn GangFemale model")]
        public static void Command_SpawnGangFemaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.GangFemale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn GangMale model")]
        public static void Command_SpawnGangMaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.GangMale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn Multiplayer model")]
        public static void Command_SpawnMultiplayerModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.Multiplayer model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn ScenarioFemale model")]
        public static void Command_SpawnScenarioFemaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.ScenarioFemale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn ScenarioMale model")]
        public static void Command_SpawnScenarioMaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.ScenarioMale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn Story model")]
        public static void Command_SpawnStoryModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.Story model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn StoryScenarioFemale model")]
        public static void Command_SpawnStoryScenarioFemaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.StoryScenarioFemale model)
        {
            SpawnPedModel(model);
        }

        [ConsoleCommand("Rage Community Library spawn StoryScenarioMale model")]
        public static void Command_SpawnStoryScenarioMaleModel([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandParameterAutoCompleterEnum))] Peds.Models.StoryScenarioMale model)
        {
            SpawnPedModel(model);
        }

        private static void SpawnPedModel<T>(T model)
        {
            Type type = model.GetType();
            if (!type.IsEnum)
            {
                Game.LogTrivial($"Type is not an enum.");
                return;
            }

            try
            {
                Game.LogTrivial($"Spawning {model}");
                new Ped(model.ToString(), Game.LocalPlayer.Character.GetOffsetPositionFront(5), Game.LocalPlayer.Character.Heading);
            }
            catch
            {
                Game.LogTrivial($"Error spawning {model}");
            }
        }
        [ConsoleCommand("Rage Community Library spawn freemode ped and randomize his appearance")]
        public static void Command_SpawnFreemodePed(bool isMale)
        {
            GameFiber.StartNew(() =>
            {
                try
                {
                    Vector3 pos = Game.LocalPlayer.Character.Position + Game.LocalPlayer.Character.ForwardVector * 5f;
                    float heading = Game.LocalPlayer.Character.Heading + 180f;
                    FreemodePed freemodePed = new FreemodePed(isMale, pos, heading);
                    freemodePed.Dismiss();
                }
                catch (Exception e)
                {
                    Game.LogTrivial(e.ToString());
                }
            });
        }
    }
}
