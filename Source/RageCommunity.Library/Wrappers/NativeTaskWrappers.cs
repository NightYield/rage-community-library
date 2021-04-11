using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Causes the given ped to start playing the specified scenario.  A list of scenarios can be found <a href="https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json">here</a>.
        /// </summary>
        public static void TaskStartScenarioInPlace(Ped ped, string scenarioName, int unkDelay = 0, bool playEnterAnimation = true)
        {
            NativeFunction.Natives.TASK_START_SCENARIO_IN_PLACE(ped, scenarioName, unkDelay, playEnterAnimation);
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
