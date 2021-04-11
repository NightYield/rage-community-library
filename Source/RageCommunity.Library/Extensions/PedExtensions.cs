using System;
using Rage;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Peds;
using System.Linq;
using System.Collections.Generic;

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
        /// Causes this ped to shoot at the specified <paramref name="target"/> ped.
        /// </summary>
        /// <param name="unknown">Unknown parameter, default 0</param>
        public static void ShootFromVehicle(this Ped ped, Ped target, float unknown = 0) => NativeWrappers.TaskVehicleShootAtPed(ped, target, unknown);

        /// <summary>
        /// Causes this ped to start playing the specified scenario.
        /// </summary>
        /// <remarks>
        /// A list of scenarios can be found <a href="https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json">here</a>.
        /// </remarks>
        public static void StartScenarioInPlace(this Ped ped, string scenarioName, int unkDelay = 0, bool playEnterAnimation = true) => NativeWrappers.TaskStartScenarioInPlace(ped, scenarioName, unkDelay, playEnterAnimation);

        /// <summary>
        /// Returns true if the specified task is active for this ped.
        /// </summary>
        /// <remarks>
        /// A list of task indexes can be found <a href="https://alloc8or.re/gta5/doc/enums/eTaskTypeIndex.txt">here</a>.
        /// </remarks>
        public static bool IsTaskActive(this Ped ped, PedTask task) => NativeWrappers.GetIsTaskActive(ped, (int)task);

        /// <summary>
        /// Gets a list of all active tasks for this ped.
        /// </summary>
        public static List<PedTask> GetAllActiveTasks(this Ped ped)
        {
            var tasks = (PedTask[])Enum.GetValues(typeof(PedTask));
            return tasks.Where(t => ped.IsTaskActive(t)).ToList();
        }
    }
}
