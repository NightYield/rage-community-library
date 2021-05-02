using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Determine if the given <paramref name="ped1"/> can see the <paramref name="ped2"/>
        /// </summary>
        public static bool CanPedSeeHatedPed(Ped ped1, Ped ped2) => NativeFunction.Natives.CAN_PED_SEE_HATED_PED<bool>(ped1, ped2);
    }
}
