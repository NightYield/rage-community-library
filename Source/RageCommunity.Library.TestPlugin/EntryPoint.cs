using Rage;

[assembly: Rage.Attributes.Plugin("Rage Community Library Test", Description = "A plugin to test the contents of the Rage Community Library.", Author = "NightYield and Contributors", PrefersSingleInstance = true)]
namespace RageCommunity.Library.TestPlugin
{
    public class EntryPoint
    {
        /// <summary>
        /// This is the EntryPoint for the RagePluginHook. The plugin has to be kept alive, otherwise console commands will not work.
        /// </summary>
        public static void Main()
        {
            while (true)
            {
                GameFiber.Yield();
            }
        }
    }
}
