using Rage;
using Rage.Attributes;
using RageCommunity.Library.Extensions;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.TestPlugin
{
    public static class Commands
    {
        [ConsoleCommand("Test the native wrappers for vehicle horns.")]
        public static void Command_RageLibraryHornTest()
        {
            if (!Game.LocalPlayer.Character.CurrentVehicle)
            {
                var hornConfig = NativeWrappers.GetVehicleDefaultHorn(Game.LocalPlayer.Character.CurrentVehicle);
                Game.LogTrivial($"The default horn for your current vehicle is: {hornConfig}");
            }
        }

        [ConsoleCommand("Test the native wrappers for vehicle horns.")]
        public static void Command_GetZoneNameForCurrentLocation()
        {
            if (!Game.LocalPlayer.Character)
            {
                Game.LogTrivial($"The name of the current zone is: {Game.LocalPlayer.Character.Position.GetZoneName()}");
            }
        }
    }
}
