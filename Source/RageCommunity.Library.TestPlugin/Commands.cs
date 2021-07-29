using Rage;
using Rage.Attributes;
using Rage.Native;
using Rage.ConsoleCommands.AutoCompleters;
using Rage.ConsoleCommands;
using RageCommunity.Library.Extensions;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Vehicles;
using RageCommunity.Library.Peds.Freemode;
using RageCommunity.Library.Task;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
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
            else
            {
                Game.LogTrivial("Vehicle doesn't exist");
            }
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
            else
            {
                Game.LogTrivial("Vehicle doesn't exist");
            }
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
            if (ped)
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
        private static List<Entity> SpawnedEntities = new List<Entity>();
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
                Ped ped = new Ped(model.ToString(), Game.LocalPlayer.Character.GetOffsetPositionFront(5), Game.LocalPlayer.Character.Heading);
                SpawnedEntities.Add(ped);
            }
            catch
            {
                Game.LogTrivial($"Error spawning {model}");
            }
        }
        [ConsoleCommand("Rage Community Library spawn freemode ped and randomize the appearance")]
        public static void Command_SpawnFreemodePed([ConsoleCommandParameter(Description = "if true, will spawn a male ped, otherwise will spawn a female ped")] bool isMale)
        {
            GameFiber.StartNew(() =>
            {
                try
                {
                    Vector3 pos = Game.LocalPlayer.Character.Position + Game.LocalPlayer.Character.ForwardVector * 5f;
                    float heading = Game.LocalPlayer.Character.Heading + 180f;
                    FreemodePed freemodePed = new FreemodePed(isMale, pos, heading);
                    SpawnedEntities.Add(freemodePed);
                }
                catch (Exception e)
                {
                    Game.LogTrivial(e.ToString());
                }
            });
        }
        [ConsoleCommand(Description = "Rage Community Library dispose all spawned entities")]
        public static void Command_DisposeAllSpawnedEntities([ConsoleCommandParameter(Description = "if true, the entities will be deleted, otherwise will be dismissed ")] bool delete)
        {
            foreach (Entity entity in SpawnedEntities)
            {
                if (entity)
                {
                    if (delete)
                    {
                        entity.Delete();
                    }
                    else
                    {
                        entity.Dismiss();
                    }
                }
            }
            SpawnedEntities = new List<Entity>();
        }
        [ConsoleCommand(Description = "Rage Community Library get ped active tasks")]
        public static void Command_GetPedActiveTasks([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterPedAliveOnly))] Ped ped)
        {
            if (ped)
            {
                var tasks = ped.GetAllActiveTasks();
                if (tasks.Any())
                {
                    tasks.ForEach(x => Game.LogTrivial(x.ToString()));
                }
                else
                {
                    Game.LogTrivial("No active task");
                }
            }
        }
        [ConsoleCommand(Description = "Rage Community Library get ped active scenarios")]
        public static void Command_GetPedActiveScenarios([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterPedAliveOnly))] Ped ped)
        {
            if (ped)
            {
                var scenarios = ped.GetActiveScenarios();
                if (scenarios.Any())
                {
                    scenarios.ForEach(x => Game.LogTrivial(x.ToString()));
                }
                else
                {
                    Game.LogTrivial("No active scenario");
                }
            }
        }
        private static List<SynchronizedScene> synchronizedScenes = new List<SynchronizedScene>();
        private static bool BenchThreadActivated = false;
        [ConsoleCommand(Description = "Rage Community Library synchronized scene test")]
        public static void Command_SynchronizedSceneTest()
        {
            if (BenchThreadActivated)
            {
                return;
            }
            GameFiber.StartNew(delegate
            {
                BenchThreadActivated = true;
                SynchronizedScene syncScene = null;
                List<uint> benchHash = new List<uint>()
                {
                    0x6ba514ac, //prop_bench_01a
                    0x7977b051, //prop_bench_01b
                    0xb78a2c75, //prop_bench_01c
                    0xda867f80, //prop_bench_02
                    0xc0a6cbcd, //prop_bench_03
                    0xd2786f70, //prop_bench_04
                    0x9ec80810, //prop_bench_05
                    0xb17ead7d, //prop_bench_06
                    0xfbbe41fb, //prop_bench_07
                    0xe7ed1a59, //prop_bench_08
                    0xfa11bea2, //prop_bench_09
                    0x1a117fd1, //prop_bench_10
                    0x4cece57b, //prop_bench_11
                    0xfbca504f, //prop_fib_3b_bench
                    0x723e2ae0, //prop_ld_bench01
                    0x0ff3a92b, //prop_wait_bench_01
                    0x5515a05a, //v_res_fh_benchlong
                    0x883cb2e8, //v_res_fh_benchshort                   
                    0xbac3f7a8, //v_ind_rc_bench
                    0x90aa8a87, //hei_heist_stn_benchshort
                };
                Rage.Object bench = null;
                int benchStatus = 0;
                Vector3 benchInitialPos = Vector3.Zero;
                Vector3 sitPos = Vector3.Zero;
                Rage.Task closeTask = null;
                string sitStr = Game.GetLocalizedString("MPTV_WALK"); //Press ~INPUT_CONTEXT~ to sit down.
                string standUpStr = Game.GetLocalizedString("MPOFSEAT_PCEXIT");
                string[] benchIdles = { "idle_a", "idle_b", "idle_c" };
                AnimationDictionary seating = Game.LocalPlayer.Character.IsMale ? "anim@amb@office@seating@male@var_a@base@" : "anim@amb@office@seating@female@var_d@base@";
                seating.LoadAndWait();
                while (true)
                {
                    GameFiber.Yield();
                    if (Game.LocalPlayer.Character.IsInAnyVehicle(false) || Game.LocalPlayer.Character.IsDead || Game.IsPaused || Game.Console.IsOpen || Game.IsScreenFadingOut)
                    {
                        continue;
                    }
                    switch (benchStatus)
                    {
                        case 0:
                            Entity[] objs = World.GetEntities(Game.LocalPlayer.Character.Position, 2f, GetEntitiesFlags.ConsiderAllObjects).ToArray();
                            bench = (Rage.Object)objs.Where(x => x && benchHash.Contains(x.Model.Hash)).OrderBy(x => Vector3.DistanceSquared(x.Position, Game.LocalPlayer.Character)).FirstOrDefault();
                            if (!bench)
                            {
                                break;
                            }
                            Game.DisplayHelp(sitStr, 100);
                            if (Game.IsControlPressed(2, GameControl.Context))
                            {
                                benchStatus = 1;
                            }
                            break;
                        case 1:
                            sitPos = bench.Position + bench.RightVector * 0.85f;
                            benchInitialPos = sitPos + bench.ForwardVector * -1;
                            closeTask = Game.LocalPlayer.Character.Tasks.FollowNavigationMeshToPosition(benchInitialPos, bench.Heading - 180, 1f, 10000);
                            benchStatus = 2;
                            break;
                        case 2:
                            if (closeTask.Status == TaskStatus.InProgress)
                            {
                                break;
                            }
                            syncScene = new SynchronizedScene(sitPos, bench.Rotation);
                            synchronizedScenes.Add(syncScene);
                            syncScene.TaskToPed(Game.LocalPlayer.Character, seating, "enter", 13);
                            benchStatus = 3;
                            break;
                        case 3:
                            if (syncScene.Phase != 1f)
                            {
                                break;
                            }
                            syncScene = new SynchronizedScene(sitPos, bench.Rotation);
                            synchronizedScenes.Add(syncScene);
                            syncScene.TaskToPed(Game.LocalPlayer.Character, seating, "base", 13, playbackRate: 1148846080);
                            benchStatus = 4;
                            break;
                        case 4:
                            Game.DisplayHelp(standUpStr, 100);
                            if (Game.IsControlPressed(2, GameControl.ScriptRRight))
                            {
                                benchStatus = 5;
                            }
                            if (syncScene.Phase != 1f)
                            {
                                break;
                            }
                            syncScene = new SynchronizedScene(sitPos, bench.Rotation);
                            synchronizedScenes.Add(syncScene);
                            syncScene.TaskToPed(Game.LocalPlayer.Character, seating, benchIdles.GetRandomElement(), 13, playbackRate: 1148846080);
                            benchStatus = 3;
                            break;
                        case 5:
                            syncScene = new SynchronizedScene(sitPos, bench.Rotation);
                            synchronizedScenes.Add(syncScene);
                            syncScene.TaskToPed(Game.LocalPlayer.Character, seating, "exit", 13, playbackRate: 1000f);
                            benchStatus = 6;
                            break;
                        case 6:
                            if (syncScene.Phase != 1f)
                            {
                                break;
                            }
                            Game.LocalPlayer.Character.Tasks.Clear();
                            synchronizedScenes.ForEach(x =>
                            {
                                if (x.IsValid())
                                {
                                    x.Delete();
                                }
                            });
                            synchronizedScenes = new List<SynchronizedScene>();
                            benchStatus = 0;
                            break;
                    }
                }
            });
        }
        [ConsoleCommand("Rage Community Library - Install random mods on specified vehicle")]
        public static void InstallRandomModsOnVehicle([ConsoleCommandParameter(AutoCompleterType = typeof(ConsoleCommandAutoCompleterVehicleAliveOnly))] string vehicleHandle)
        {
            Game.LogTrivial(vehicleHandle);
            bool success = uint.TryParse(vehicleHandle, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint handle);
            if (!success) return;
            Vehicle vehicle = World.GetEntityByHandle<Vehicle>(new PoolHandle(handle));
            if (vehicle)
            {
                vehicle.Mods.InstallModKit();
                Random random = new Random(Environment.TickCount);
                for (int i = 0; i <= 100; i++)
                {
                    try
                    {
                        int randomIndex = random.Next(NativeFunction.Natives.GET_NUM_VEHICLE_MODS<int>(vehicle, i));
                        NativeFunction.Natives.SET_VEHICLE_MOD(vehicle, i, randomIndex, false);
                        string modLabel = NativeFunction.Natives.GET_​MOD_​TEXT_​LABEL<string>(vehicle, i, randomIndex);
                        string modSlotName = NativeFunction.Natives.GET_​MOD_​SLOT_​NAME<string>(vehicle, i);
                        modLabel = string.IsNullOrWhiteSpace(modLabel) ? "NULL" : NativeWrappers.GetLabelText(modLabel);
                        modSlotName = string.IsNullOrWhiteSpace(modSlotName) ? "NULL" : modSlotName;
                        Game.LogTrivial($"Installing {modLabel} as its {modSlotName} - ({i}, {randomIndex})");
                    }
                    catch (Exception e)
                    {
                        Game.LogTrivialDebug(e.ToString());
                        continue;
                    }
                }
                vehicle.Mods.HasTurbo = random.Next(2) == 1;
                vehicle.Mods.HasXenonHeadlights = random.Next(2) == 1;
                VehiclePaint[] blackList =
                    {
                        VehiclePaint.DEFAULT_ALLOY_COLOR, VehiclePaint.Unknown, VehiclePaint.Police_Car_Blue, VehiclePaint.Metallic_Taxi_Yellow, VehiclePaint.MP100_GOLD, VehiclePaint.MP100_GOLD_SATIN,
                        VehiclePaint.MP100_GOLD_SPEC, VehiclePaint.MODSHOP_BLACK1,
                    };
                VehiclePaint selected = Enum.GetValues(typeof(VehiclePaint)).Cast<VehiclePaint>().Except(blackList).GetRandomElement();
                vehicle.SetColor(new VehicleColor(selected, selected));
                NativeFunction.Natives.xf40dd601a65f7f19(vehicle, (int)Enum.GetValues(typeof(VehiclePaint)).Cast<VehiclePaint>().Except(blackList).GetRandomElement());//_SET_VEHICLE_INTERIOR_COLOUR
                NativeFunction.Natives.x6089cdf6a57f326c(vehicle, (int)Enum.GetValues(typeof(VehiclePaint)).Cast<VehiclePaint>().Except(blackList).GetRandomElement());//_SET_VEHICLE_DASHBOARD_COLOUR
                for (int i = 0; i < 4; i++)
                {
                    NativeFunction.Natives.x2aa720e4287bf269(vehicle, i, random.Next() % 2 == 0);
                }
                NativeFunction.Natives.x8e0a582209a62695(vehicle, MathHelper.GetRandomInteger(1, 255), MathHelper.GetRandomInteger(1, 255), MathHelper.GetRandomInteger(1, 255));
                int liveryCount = NativeFunction.Natives.GET_​VEHICLE_​LIVERY_​COUNT<int>(vehicle);
                if (liveryCount > 0)
                {
                    int randomLivery = random.Next(liveryCount);
                    NativeFunction.Natives.SET_​VEHICLE_​LIVERY(vehicle, liveryCount);
                    Game.LogTrivial($"Set livery: {NativeWrappers.GetLabelText(NativeFunction.Natives.GET_​LIVERY_​NAME<string>(vehicle, randomLivery))}");
                }
            }
            else Game.LogTrivial("vehicle does not exist");
        }
        private class VehicleAutoCompleterAliveOnly : ConsoleCommandAutoCompleterEntity
        {
            public VehicleAutoCompleterAliveOnly(Type type) : base(type)
            {
            }
            public override void UpdateOptions()
            {
                Options.Clear();
                foreach (Vehicle vehicle in World.GetAllVehicles().Where(x => x && x.IsAlive).OrderBy(x => Vector3.DistanceSquared(x.Position, Game.LocalPlayer.Character)))
                {
                    AutoCompleteOption option = new AutoCompleteOption(vehicle.Handle.Value.ToString("x"), vehicle.Handle.Value.ToString("x"),
                        $"{vehicle.GetMakeName()} {vehicle.GetDisplayName()}. Distance to player: {vehicle.DistanceTo(Game.LocalPlayer.Character)}");
                    Options.Add(option);
                }
            }
        }
    }
}
