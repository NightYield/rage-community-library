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
    }
}
