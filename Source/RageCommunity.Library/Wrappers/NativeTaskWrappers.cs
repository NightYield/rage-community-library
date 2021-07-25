using System;
using Rage;
using Rage.Native;
using RageCommunity.Library.Task;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Causes the given ped to start playing the specified scenario.
        /// </summary>
        /// <remarks>
        /// A list of scenarios can be found <a href="https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json">here</a>.
        /// </remarks>
        public static void TaskStartScenarioInPlace(Ped ped, Scenario scenario, int unkDelay = 0, bool playEnterAnimation = true)
        {
            NativeFunction.Natives.TASK_START_SCENARIO_IN_PLACE(ped, scenario.ToString(), unkDelay, playEnterAnimation);
        }
        /// <summary>
        /// Causes the given <paramref name="ped"/> to play the given <paramref name="scenario"/> at the given <paramref name="position"/>
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="scenario">The scenario to be played</param>
        /// <param name="position">The position that the scenario will be playing at</param>
        /// <param name="heading">The heading</param>
        /// <param name="duration">in miliseconds, if <c>-1</c> the task will never timeout</param>
        /// <param name="sittingScenario"><c>true</c> if the given <paramref name="scenario"/> is a sitting scenario, otherwise <c>false</c></param>
        /// <param name="teleport">if set to <c>true</c> the <paramref name="ped"/> will be teleported at the given <paramref name="position"/></param>
        public static void TaskStartScenarioAtPosition(Ped ped, string scenario, Vector3 position, float heading, int duration, bool sittingScenario, bool teleport)
        {
            NativeFunction.Natives.TASK_START_SCENARIO_AT_POSITION(ped, scenario, position, heading, duration, sittingScenario, teleport);
        }

        /// <summary>
        /// Causes the given ped to face the specified entity for a duration (in ms).
        /// </summary>
        /// <param name="duration">In miliseconds (-1 is infinite)</param>
        public static void TaskTurnPedToFaceEntity(Ped ped, Entity entity, int duration)
        {
            NativeFunction.Natives.TASK_TURN_PED_TO_FACE_ENTITY(ped, entity, duration);
        }

        /// <summary>
        /// Causes this ped to shoot from a vehicle at the specified <paramref name="target"/> ped. (e.g. drive-bys)
        /// </summary>
        /// <param name="unknown">Unknown parameter, default 0</param>
        public static void TaskVehicleShootAtPed(Ped ped, Ped target, float unknown = 0)
        {
            NativeFunction.Natives.x10AB107B887214D8(ped, target, unknown);
        }
        /// <summary>
        /// Causes the given <paramref name="ped"/> to perform the given <paramref name="sceneID"/> synchronized scene
        /// </summary>
        /// <param name="ped">The target ped</param>
        /// <param name="sceneID">The synchronized scene handle</param>
        /// <param name="duration">in second</param>
        /// <param name="flag">can be 0 or 16</param>
        /// <param name="unk">Always 0</param>
        public static void TaskSynchronizedScene(Ped ped, uint sceneID, string animDict, string animName, float speed, float speedMultiplier, int duration, int flag, float playbackRate, int unk)
        {
            NativeFunction.Natives.TaskSynchronizedScene(ped, sceneID, animDict, animName, speed, speedMultiplier, duration, flag, playbackRate, unk);
        }
        /// <summary>
        /// Returns true if the specified task is active for the given ped.
        /// </summary>
        /// <remarks>
        /// A list of task indexes can be found <a href="https://alloc8or.re/gta5/doc/enums/eTaskTypeIndex.txt">here</a>.
        /// </remarks>
        public static bool GetIsTaskActive(Ped ped, int taskIndex)
        {
            return NativeFunction.Natives.GET_IS_TASK_ACTIVE<bool>(ped, taskIndex);
        }
    }
}
