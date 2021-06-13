using System;
using Rage;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Peds;
using System.Linq;
using System.Collections.Generic;
using RageCommunity.Library.Task;

namespace RageCommunity.Library.Extensions
{
    public static class PedExtensions
    {
        /// <summary>
        /// Causes this ped to face the specified <paramref name="entity"/> for some <paramref name="duration"/> (in ms).
        /// </summary>
        /// <param name="duration">In miliseconds (-1 is infinite)</param>
        public static void FaceEntity(this Ped ped, Entity entity, int duration) => NativeWrappers.TaskTurnPedToFaceEntity(ped, entity, duration);

        /// <summary>
        /// Causes this ped to shoot from a vehicle at the specified <paramref name="target"/> ped. (e.g. drive-bys)
        /// </summary>
        /// <param name="unknown">Unknown parameter, default 0</param>
        public static void ShootFromVehicle(this Ped ped, Ped target, float unknown = 0) => NativeWrappers.TaskVehicleShootAtPed(ped, target, unknown);

        /// <summary>
        /// Causes this ped to start playing the specified scenario in place.
        /// </summary>
        public static void StartScenario(this Ped ped, Scenario scenario, int unkDelay = 0, bool playEnterAnimation = true)
        {
            NativeWrappers.TaskStartScenarioInPlace(ped, scenario.ToString(), unkDelay, playEnterAnimation);
        }
        /// <summary>
        /// Causes this ped to start playing the specified scenario at the given <paramref name="position"/>
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="scenario">The scenario to be played</param>
        /// <param name="position">The position that the scenario will be playing at</param>
        /// <param name="heading">The heading</param>
        /// <param name="duration">in miliseconds, if <c>-1</c> the task will never timeout</param>
        /// <param name="sittingScenario"><c>true</c> if the given <paramref name="scenario"/> is a sitting scenario, otherwise <c>false</c></param>
        /// <param name="teleport">if set to <c>true</c> the <paramref name="ped"/> will be teleported at the given <paramref name="position"/></param>
        public static void StartScenario(this Ped ped, Scenario scenario, Vector3 position, float heading, int duration, bool sittingScenario, bool teleport)
        {
            NativeWrappers.TaskStartScenarioAtPosition(ped, scenario.ToString(), position, heading, duration, sittingScenario, teleport);
        }
        /// <summary>
        /// Causes this ped to start performing the specified <see cref="SynchronizedScene"/>
        /// </summary>
        /// <param name="ped">The target ped</param>
        /// <param name="duration">in second</param>
        /// <param name="flag">can be 0 or 16</param>
        /// <returns></returns>
        public static Rage.Task StartSynchronizedScene(this Ped ped, SynchronizedScene synchronizedScene, AnimationDictionary animDictionary, string animationName, float speed, float speedMultiplier, int duration, int flag, float playbackRate)
        {
            animDictionary.LoadAndWait();
            uint handle = synchronizedScene.Handle;
            NativeWrappers.TaskSynchronizedScene(ped, handle, animDictionary, animationName, speed, speedMultiplier, duration, flag, playbackRate, 0);
            return Rage.Task.GetTask(ped, "TASK_SYNCHRONIZED_SCENE");
        }
        /// <summary>
        /// Returns true if the specified task is active for this ped.
        /// </summary>
        public static bool IsTaskActive(this Ped ped, PedTask task) => NativeWrappers.GetIsTaskActive(ped, (int)task);
        /// <summary>
        /// Checks whether this ped is playing the specified scenario
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="scenario">The scenario that want to be check</param>
        /// <returns><c>true</c> if this ped is playing the given <paramref name="scenario"/>, otherwise <c>false</c></returns>
        public static bool IsUsingScenario(this Ped ped, Scenario scenario) => NativeWrappers.IsPedUsingScenario(ped, scenario.ToString());

        /// <summary>
        /// Gets a list of all active tasks for this ped.
        /// </summary>
        public static List<PedTask> GetAllActiveTasks(this Ped ped)
        {
            var tasks = (PedTask[])Enum.GetValues(typeof(PedTask));
            return tasks.Where(t => ped.IsTaskActive(t)).ToList();
        }
        /// <summary>
        /// Gets a list of scenarios that currently active in this ped
        /// </summary>
        /// <param name="ped"></param>
        /// <returns></returns>
        public static List<Scenario> GetActiveScenarios(this Ped ped)
        {
            var scenarios = Enum.GetValues(typeof(Scenario)).Cast<Scenario>();
            return scenarios.Where(x => NativeWrappers.IsPedUsingScenario(ped, x.ToString())).ToList();
        }
        /// <summary>
        /// indicates whether this <paramref name="ped"/> can see the <paramref name="target"/> <see cref="Ped"/>
        /// </summary>
        public static bool CanSeePed(this Ped ped, Ped target)
        {
            return NativeWrappers.CanPedSeeHatedPed(ped, target);
        }
    }
}
