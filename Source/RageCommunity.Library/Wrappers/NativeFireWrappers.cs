using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Gets the position of the closes fire based on the given search position.
        /// </summary>
        /// <returns>
        /// Returns true when a fire was found, otherwise false.
        /// </returns>
        public static Boolean GetClosestFirePosition(out Vector3 foundFirePosition, Vector3 searchPosition)
        {
            return NativeFunction.Natives.x352A9F6BCF90081F<Boolean>(out foundFirePosition, searchPosition.X, searchPosition.Y, searchPosition.Z); 
        }
    }
}
