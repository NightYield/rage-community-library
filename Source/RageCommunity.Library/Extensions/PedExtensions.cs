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
    }
}
