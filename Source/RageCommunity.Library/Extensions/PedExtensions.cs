using System;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class PedExtensions
    {
        /// <summary>
        /// Causes the given ped to face the specified entity for a duration (in ms).
        /// </summary>
        /// <param name="duration">In miliseconds (-1 is infinite)</param>
        public static void FaceEntity(this Ped ped, Entity entity, int duration) => NativeWrappers.TaskTurnPedToFaceEntity(ped, entity, duration);

        /// <summary>
        /// Causes the given ped to shoot at the specified target ped.
        /// </summary>
        /// <param name="unknown">Unknown parameter, default 0</param>
        public static void ShootFromVehicle(this Ped ped, Ped target, float unknown = 0) => NativeWrappers.TaskVehicleShootAtPed(ped, target, unknown);

        /// <summary>
        /// Causes the given ped to start playing the specified scenario.  A list of scenarios can be found <a href="https://github.com/DurtyFree/gta-v-data-dumps/blob/master/scenariosCompact.json">here</a>.
        /// </summary>
        public static void StartScenarioInPlace(this Ped ped, string scenarioName, int unkDelay = 0, bool playEnterAnimation = true) => NativeWrappers.TaskStartScenarioInPlace(ped, scenarioName, unkDelay, playEnterAnimation);
    }
}
