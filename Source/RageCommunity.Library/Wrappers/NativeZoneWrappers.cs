using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Returns the name of the zone for a given position.
        /// </summary>
        /// <remarks>
        /// The name of this native is a little confusing. It returns the short name, not the fullname. For example: AIRP instead of Los Santos International Airport. 
        /// </remarks>
        public static String GetNameOfZone(Vector3 position)
        {
            return NativeFunction.Natives.xCD90657D4C30E1CA<String>(position);
        }
    }
}
