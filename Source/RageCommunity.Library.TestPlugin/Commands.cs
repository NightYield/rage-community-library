using Rage;
using Rage.Attributes;
using Rage.ConsoleCommands.AutoCompleters;
using RageCommunity.Library.Extensions;
using RageCommunity.Library.Wrappers;
using System;
using System.Linq;
using System.Reflection;

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
    }
}
