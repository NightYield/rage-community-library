using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Check if the given <paramref name="position"/> is occupied
        /// </summary>
        /// <param name="position">the position to check</param>
        /// <param name="range">The range, seems to not be very accurate during testing.</param>
        /// <param name="p4">Unknown, when set to <c>true</c> it seems to always return <c>true</c> no matter what I try.</param>
        /// <param name="checkVehicles">Check for any <see cref="Vehicle"/> in that area.</param>
        /// <param name="checkPeds">Check for any <see cref="Ped"/> in that area.</param>
        /// <param name="p7">unknown</param>
        /// <param name="p8">unknown</param>
        /// <param name="ignoreEntity">This <see cref="Entity"/> will be ignored if it's in the area. Set to <c>0</c> if you don't want to exclude any <see cref="Entity"/>.</param>
        /// <param name="p10">unknown</param>
        /// <returns><c>true</c> if the <paramref name="position"/> given is empty, otherwise <c>false</c></returns>
        public static bool IsPositionOccupied(Vector3 position, float range, bool p4, bool checkVehicles, bool checkPeds, bool p7, bool p8, Entity ignoreEntity, bool p10)
        {
            return ignoreEntity == null ? 
                NativeFunction.Natives.IS_POSITION_OCCUPIED<bool>(position, range, p4, checkVehicles, checkPeds, p7, p8, 0, p10) : 
                NativeFunction.Natives.IS_POSITION_OCCUPIED<bool>(position, range, p4, checkVehicles, checkPeds, p7, p8, ignoreEntity, p10);
        }
    }
}
