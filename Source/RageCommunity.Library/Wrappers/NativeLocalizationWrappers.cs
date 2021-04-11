using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Get the current game language.
        /// </summary>
        /// <returns>A number from 0-12, representing a language. 0 = american. For more languages see <a href="https://alloc8or.re/gta5/nativedb/?n=0x2BDD44CC428A7EAE">Grant Theft Auto V native DB</a>.</returns>
        public static int GetGameLanguage()
        {
            return NativeFunction.Natives.x2BDD44CC428A7EAE<int>();
        }
    }
}
