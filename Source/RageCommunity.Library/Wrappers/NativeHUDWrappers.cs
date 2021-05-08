using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Controls the display of the HUD
        /// </summary>
        /// <param name="toggle">Using true will enable the HUD.</param>
        public static void DisplayHud(bool toggle)
        {
            NativeFunction.Natives.xA6294919E56FF02A(toggle);
        }
        /// <summary>
        /// Gets a string literal from a label name.
        /// </summary>
        public static string GetLabelText(string labelName)
        {
            return NativeFunction.Natives.x7B5280EBA9840C72<string>(labelName);
        }
        /// <summary>
        /// World to relative screen coords 
        /// this world to screen will keep the text on screen. it will keep it in the screen pos
        /// </summary>
        /// <returns>a boolean; whether or not the operation was successful. It will return false if the coordinates given are not visible to the rendering camera.</returns>
        public static bool GetHudScreenPositionFromWorldPosition(Vector3 worldPosition, out float screenX, out float screenY)
        {
            bool success =  NativeFunction.Natives.GET_HUD_SCREEN_POSITION_FROM_WORLD_POSITION<bool>(worldPosition, out float screenPositionX, out float screenPositionY);
            screenX = screenPositionX;
            screenY = screenPositionY;
            return success;
        }
    }
}
