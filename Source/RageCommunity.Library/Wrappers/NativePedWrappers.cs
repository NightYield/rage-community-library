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
        /// <summary>
        /// Gets the given <paramref name="ped"/> HeadBlendData. Used for online freemdoe character
        /// </summary>
        public static bool GetPedHeadBlendData(Ped ped, out Peds.Freemode.HeadBlendData headBlend)
        {
            bool success = NativeFunction.Natives.GetPedHeadBlendData<bool>(ped, out headBlend);
            return success;
        }
        /// <summary>
        /// The "shape" parameters control the shape of the ped's face. The "skin" parameters control the skin tone.
        /// ShapeMix and skinMix control how much the first and second IDs contribute,(typically mother and father.) ThirdMix overrides the others in favor of the third IDs. 
        /// IsParent is set for "children" of the player character's grandparents during old-gen character creation. It has unknown effect otherwise.  
        /// The IDs start at zero and go Male Non-DLC, Female Non-DLC, Male DLC, and Female DLC.
        /// </summary>
        public static void SetPedHeadBlendData(Ped ped, int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)
        {
            NativeFunction.Natives.SetPedHeadBlendData(ped, shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix, isParent);
        }
        /// <summary>
        /// See: <see cref="SetPedHeadBlendData(Ped, int, int, int, int, int, int, float, float, float, bool)"/>
        /// </summary>
        public static void UpdatePedHeadBlendData(Ped ped, float shapeMix, float skinMix, float thirdMix)
        {
            NativeFunction.Natives.UpdatePedHeadBlendData(ped, shapeMix, skinMix, thirdMix);
        }
        /// <summary>
        /// Indicates whether the given <paramref name="ped"/> head blend is finished to load
        /// </summary>
        public static bool HasPedHeadBlendFinished(Ped ped) => NativeFunction.Natives.HasPedHeadBlendFinished<bool>(ped);
        /// <summary>
        /// Finalize the headblend
        /// </summary>
        public static void FinalizeHeadBlend(Ped ped) => NativeFunction.Natives.FinalizeHeadBlend(ped);
        public static bool HaveAllStreamingRequestsCompleted(Ped ped) => NativeFunction.Natives.HaveAllStreamingRequestsCompleted<bool>(ped);
        /// <summary>
        /// This native is used to set component variation on a ped. Components, drawables and textures IDs are related to the ped model.
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="componentID">The component that you want to set.</param>
        /// <param name="drawableID">The drawable id that is going to be set.</param>
        /// <param name="textureID">The texture id of the drawable.</param>
        /// <param name="palleteID"><c>0</c> to <c>3</c></param>
        public static void SetPedComponentVariation(Ped ped, int componentID, int drawableID, int textureID, int palleteID)
            => NativeFunction.Natives.SetPedComponentVariation(ped, componentID, drawableID, textureID, palleteID);
        /// <summary>
        /// Sets the given <paramref name="ped"/> eye color, only affect on freemode character
        /// </summary>
        /// <param name="ped">The <see cref="Ped"/> to sets the eye color</param>
        /// <param name="colorIndex">See: <see cref="Peds.EyeColor"/></param>
        /// <seealso cref="GetPedEyeColor(Ped)"/>
        public static void SetPedEyeColor(Ped ped, int colorIndex) => NativeFunction.Natives.x50B56988B170AFDF(ped, colorIndex);
        /// <summary>
        /// Gets the index of ped eye color, used for online freemode character
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <returns>ped's eye colour index, or -1 if fails to get</returns>
        /// <remarks>A getter for <see cref="SetPedEyeColor(Ped, int)"/></remarks>
        public static int GetPedEyeColor(Ped ped) => NativeFunction.Natives.x76BBA2CEE66D47E9<int>(ped);
        /// <summary>
        /// Sets the given <paramref name="ped"/> hair color
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="hairColorIndex">The hair color index, valid values are from 0 to 63</param>
        /// <remarks>See: <a href="https://wiki.gtanet.work/index.php?title=Hair_Colors">GTA Network</a></remarks>
        public static void SetPedHairColor(Ped ped, int hairColorIndex) => NativeFunction.Natives.x4CFFC65454C93A49(ped, hairColorIndex);
        /// <summary>
        /// Sets the given <paramref name="ped"/> head overlay
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="overlayID">ranges from 0 to 12</param>
        /// <param name="index">index from <c>0</c> to <see cref="GetPedHeadOverlayNum(int)"/></param>
        /// <param name="opacity">a float value from <c>0.0f</c> to <c>1.0f</c></param>
        /// <remarks>See: <a href="https://docs.fivem.net/natives/?_0x48F44967FA05CC1E">FiveM</a></remarks>
        public static void SetPedHeadOverlay(Ped ped, int overlayID, int index, float opacity)
        {
            NativeFunction.Natives.SET_PED_HEAD_OVERLAY(ped, overlayID, index, opacity);
        }
        /// <summary>
        /// Gets the maximum index number for the specified <paramref name="overlayId"/> .Used with freemode (online) characters.
        /// </summary>
        /// <param name="overlayId">The overlayID</param>
        /// <returns>The maximum index number for the specified <paramref name="overlayId"/></returns>
        public static int GetPedHeadOverlayNum(int overlayId)
        {
            return NativeFunction.Natives.GetPedHeadOverlayNum<int>(overlayId);
        }
        /// <summary>
        /// Sets the various freemode face features, e.g. nose length, chin shape
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="faceFeature">The FaceFeature index (0 - 19)</param>
        /// <param name="scale">Scale ranges from -1.0 to 1.0</param>
        public static void SetPedFaceFeature(Ped ped, int faceFeature, float scale) => NativeFunction.Natives.x71A5C1DBA060049E(ped, faceFeature, scale);
    }
}
