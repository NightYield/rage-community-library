using Rage;
using Rage.Attributes;
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

        [ConsoleCommand("Rage Community Library spawn enum models")]
        public static void Command_SpawnEnumModels()
        {
            foreach (Peds.Models.StoryScenarioMale model in (Peds.Models.StoryScenarioMale[])Enum.GetValues(typeof(Peds.Models.StoryScenarioMale)))
            {
                Game.LogTrivial($"Model: {model} | Hash: {(uint)model}");
                try
                {
                    var ped = new Ped(model.ToString(), Game.LocalPlayer.Character.GetOffsetPositionFront(5), Game.LocalPlayer.Character.Heading);
                    Game.LogTrivial($"Ped hash: {ped.Model.Hash}");
                    ped.Delete();
                }
                catch
                {
                    Game.LogTrivial($"==================== MODEL NAME ERROR FOR ABOVE MODEL ====================");
                }
                

                try
                {
                    var ped = new Ped((uint)model, Game.LocalPlayer.Character.GetOffsetPositionFront(5), Game.LocalPlayer.Character.Heading);
                    ped.Delete();
                }
                catch
                {
                    Game.LogTrivial($"==================== HASH ERROR FOR ABOVE MODEL ====================");
                }

            }
        }
    }
}
