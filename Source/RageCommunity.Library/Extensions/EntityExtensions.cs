using System;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// Sets the max <paramref name="speed"/> of this entity.
        /// </summary>
        /// <remarks>
        /// Animations may become out of sync if speed is adjusted too much (e.g., running)
        /// </remarks>
        public static void SetMaxSpeed(this Entity entity, float speed)
        {
            NativeWrappers.SetEntityMaxSpeed(entity, speed);
        }
        /// <summary>
        /// Checks whether this <see cref="Entity"/> is a <see cref="Ped"/>
        /// </summary>
        /// <param name="entity">The <see cref="Entity"/> to check</param>
        /// <returns><c>true</c> if this <see cref="Entity"/> is a <see cref="Ped"/>, otherwise <c>false</c></returns>
        public static bool IsPed(this Entity entity)
        {
            return NativeWrappers.IsEntityAPed(entity);
        }
        /// <summary>
        /// Checks whether this <see cref="Entity"/> is a <see cref="Vehicle"/>
        /// </summary>
        /// <param name="entity">The <see cref="Entity"/> to check</param>
        /// <returns><c>true</c> if this <see cref="Entity"/> is a <see cref="Vehicle"/>, otherwise <c>false</c></returns>
        public static bool IsVehicle(this Entity entity)
        {
            return NativeWrappers.IsEntityAVehicle(entity);
        }
        /// <summary>
        /// Checks whether this <see cref="Entity"/> is an <see cref="Rage.Object"/>
        /// </summary>
        /// <param name="entity">The <see cref="Entity"/> to check</param>
        /// <returns><c>true</c> if this <see cref="Entity"/> is an <see cref="Rage.Object"/>, otherwise <c>false</c></returns>
        public static bool IsObject(this Entity entity)
        {
            return NativeWrappers.IsEntityAnObject(entity);
        }
    }
}
