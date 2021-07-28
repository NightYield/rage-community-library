using System;
using Rage;
using static Rage.Native.NativeFunction;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Determine if the given <paramref name="ped1"/> can see the <paramref name="ped2"/>
        /// </summary>
        public static bool CanPedSeeHatedPed(Ped ped1, Ped ped2)
        {
            return Natives.CAN_PED_SEE_HATED_PED<bool>(ped1, ped2);
        }

        /// <summary>
        /// Gets the given <paramref name="ped"/> HeadBlendData. Used for online freemdoe character
        /// </summary>
        public static bool GetPedHeadBlendData(Ped ped, out Peds.Freemode.HeadBlendData headBlend)
        {
            bool success = Natives.x2746BD9D88C5C5D0<bool>(ped, out Peds.Freemode.HeadBlendData headBlendData);
            headBlend = headBlendData;
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
            Natives.SetPedHeadBlendData(ped, shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix, isParent);
        }
        /// <summary>
        /// See: <see cref="SetPedHeadBlendData(Ped, int, int, int, int, int, int, float, float, float, bool)"/>
        /// </summary>
        public static void UpdatePedHeadBlendData(Ped ped, float shapeMix, float skinMix, float thirdMix)
        {
            Natives.UpdatePedHeadBlendData(ped, shapeMix, skinMix, thirdMix);
        }
        /// <summary>
        /// Indicates whether the given <paramref name="ped"/> head blend is finished to load
        /// </summary>
        public static bool HasPedHeadBlendFinished(Ped ped)
        {
            return Natives.HasPedHeadBlendFinished<bool>(ped);
        }

        /// <summary>
        /// Finalize the headblend
        /// </summary>
        public static void FinalizeHeadBlend(Ped ped)
        {
            Natives.FinalizeHeadBlend(ped);
        }
        /// <summary>
        /// Determines whether all the streaming request from the given <paramref name="ped"/> is completed 
        /// </summary>
        public static bool HaveAllStreamingRequestsCompleted(Ped ped)
        {
            return Natives.HaveAllStreamingRequestsCompleted<bool>(ped);
        }

        /// <summary>
        /// This native is used to set component variation on a ped. Components, drawables and textures IDs are related to the ped model.
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="componentID">The component that you want to set.</param>
        /// <param name="drawableID">The drawable id that is going to be set.</param>
        /// <param name="textureID">The texture id of the drawable.</param>
        /// <param name="palleteID"><c>0</c> to <c>3</c>, in most cases is 0</param>
        public static void SetPedComponentVariation(Ped ped, int componentID, int drawableID, int textureID, int palleteID)
        {
            Natives.SetPedComponentVariation(ped, componentID, drawableID, textureID, palleteID);
        }
        /// <summary>
        /// This native is used to set prop variation on a ped. Components, drawables and textures IDs are related to the ped model.
        /// </summary>
        /// <param name="ped">The target ped</param>
        /// <param name="propComponentId">The component that you want to set</param>
        /// <param name="drawable">The drawable id that is going to be set</param>
        /// <param name="texture">The texture of the <paramref name="drawable"/></param>
        /// <param name="attach">Attached or not</param>
        public static void SetPedPropIndex(Ped ped, int propComponentId, int drawable, int texture, bool attach)
        {
            Natives.SetPedPropIndex(ped, propComponentId, drawable, texture, attach);
        }

        /// <summary>
        /// Sets the given <paramref name="ped"/> eye color, only affect on freemode character
        /// </summary>
        /// <param name="ped">The <see cref="Ped"/> to sets the eye color</param>
        /// <param name="colorIndex">See: <see cref="Peds.EyeColor"/></param>
        /// <seealso cref="GetPedEyeColor(Ped)"/>
        public static void SetPedEyeColor(Ped ped, int colorIndex)
        {
            Natives.x50B56988B170AFDF(ped, colorIndex);
        }

        /// <summary>
        /// Gets the index of ped eye color, used for online freemode character
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <returns>ped's eye colour index, or -1 if fails to get</returns>
        /// <remarks>A getter for <see cref="SetPedEyeColor(Ped, int)"/></remarks>
        public static int GetPedEyeColor(Ped ped)
        {
            return Natives.x76BBA2CEE66D47E9<int>(ped);
        }

        /// <summary>
        /// Sets the given <paramref name="ped"/> hair color
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="colorID">The hair color index, valid values are from 0 to 63</param>
        /// <param name="highlightColorId"></param>
        /// <remarks>See: <a href="https://wiki.gtanet.work/index.php?title=Hair_Colors">GTA Network</a></remarks>
        public static void SetPedHairColor(Ped ped, int colorID, int highlightColorId)
        {
            Natives.x4CFFC65454C93A49(ped, colorID, highlightColorId);
        }

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
            Natives.SET_PED_HEAD_OVERLAY(ped, overlayID, index, opacity);
        }
        /// <summary>
        /// Used for freemode (online) characters. 
        /// </summary>
        /// <param name="colorType">ColorType is 1 for eyebrows, beards, and chest hair; 2 for blush and lipstick; and 0 otherwise</param>
        public static void SetPedHeadOverlayColor(Ped ped, int overlayID, int colorType, int colorID, int secondColorID)
        {
            Natives.x497BF74A7B9CB952(ped, overlayID, colorType, colorID, secondColorID);
        }
        /// <summary>
        /// Gets the maximum index number for the specified <paramref name="overlayId"/> .Used with freemode (online) characters.
        /// </summary>
        /// <param name="overlayId">The overlayID</param>
        /// <returns>The maximum index number for the specified <paramref name="overlayId"/></returns>
        public static int GetPedHeadOverlayNum(int overlayId)
        {
            return Natives.GetPedHeadOverlayNum<int>(overlayId);
        }
        /// <summary>
        /// Sets the various freemode face features, e.g. nose length, chin shape
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <param name="faceFeature">The FaceFeature index (0 - 19)</param>
        /// <param name="scale">Scale ranges from -1.0 to 1.0</param>
        public static void SetPedFaceFeature(Ped ped, int faceFeature, float scale)
        {
            Natives.x71A5C1DBA060049E(ped, faceFeature, scale);
        }
        /// <summary>
        /// Gets te maximum number of the <paramref name="ped"/> drawable variation
        /// </summary>
        public static int GetNumberOfPedDrawableVariations(Ped ped, int componentID)
        {
            return Natives.GetNumberOfPedDrawableVariations<int>(ped, componentID);
        }
        /// <summary>
        /// Gets the maximum number of the <paramref name="drawableID"/> texture variation
        /// </summary>

        public static int GetNumberOfPedTextureVariations(Ped ped, int componentID, int drawableID)
        {
            return Natives.GetNumberOfPedTextureVariations<int>(ped, componentID, drawableID);
        }
        /// <summary>
        /// Gets the drawable variation count of the specified <paramref name="ped"/>
        /// </summary>
        public static int GetNumberOfPedPropDrawableVariations(Ped ped, int pedPropID)
        {
            return Natives.GET_NUMBER_OF_PED_PROP_DRAWABLE_VARIATIONS<int>(ped, pedPropID);
        }
        /// <summary>
        /// Gets the texture variation count of the specified <paramref name="drawable"/>
        /// </summary>
        public static int GetNumberOfPedPropTextureVariations(Ped ped, int pedPropID, int drawable)
        {
            return Natives.GET_NUMBER_OF_PED_PROP_TEXTURE_VARIATIONS<int>(ped, pedPropID, drawable);
        }
        /// <summary>
        /// Gets the drawable of the specified ped component
        /// </summary>
        /// <param name="ped">The ped</param>
        /// <param name="componentId">The component id</param>
        public static int GetPedDrawableVariation(Ped ped, int componentId)
        {
            return Natives.GetPedDrawableVariation<int>(ped, componentId);
        }
        /// <summary>
        /// Gets the texture of the specified ped component
        /// </summary>
        /// <param name="ped">The ped</param>
        /// <param name="componentId">The component id</param>
        public static int GetPedTextureVariation(Ped ped, int componentId)
        {
            return Natives.GetPedTextureVariation<int>(ped, componentId);
        }
        /// <summary>
        /// Gets the palette index of the specified ped component
        /// </summary>
        /// <param name="ped">The ped</param>
        /// <param name="componentId">The component id</param>
        public static int GetPedPaletteVariation(Ped ped, int componentId)
        {
            return Natives.GetPedPaletteVariation<int>(ped, componentId);
        }
        /// <summary>
        /// Gets the index of the specified ped prop
        /// </summary>
        public static int GetPedPropIndex(Ped ped, int componentId)
        {
            return Natives.GetPedPropIndex<int>(ped, componentId);
        }
        /// <summary>
        /// Gets the texture index of the specified ped prop
        /// </summary>
        public static int GetPedPropTextureIndex(Ped ped, int componentId)
        {
            return Natives.GetPedPropTextureIndex<int>(ped, componentId);
        }
        /// <summary>
        /// Creates a new synchronized scene
        /// </summary>
        /// <param name="p6">Always 2</param>
        /// <returns>The synchronized scene handle</returns>
        public static uint CreateSynchronizedScene(Vector3 position, float roll, float pitch, float yaw, int p6)
        {
            return Natives.CreateSynchronizedScene<uint>(position, roll, pitch, yaw, p6);
        }
        /// <summary>
        /// Detach this synchonized scene from any attached <see cref="Entity"/>
        /// </summary>
        /// <param name="sceneID">The handle</param>
        public static void DetachSynchronizedScene(uint sceneID)
        {
            Natives.DetachSynchronizedScene(sceneID);
        }
        /// <summary>
        /// Dismiss this synchronized scene
        /// </summary>
        /// <param name="sceneID">The handle</param>
        public static void DisposeSynchronizedScene(uint sceneID)
        {
            Natives.xCD9CC7E200A52A6F(sceneID);
        }
        /// <summary>
        /// Gets this synchronized scene phase
        /// </summary>
        /// <param name="sceneID">The synchronized scene handle</param>
        /// <returns>The synchronized scene phase</returns>
        public static float GetSynchronizedScenePhase(uint sceneID)
        {
            return Natives.GetSynchronizedScenePhase<float>(sceneID);
        }
        /// <summary>
        /// Gets this synchronized scene rate
        /// </summary>
        /// <param name="sceneID">The synchronized scene handle</param>
        /// <returns>The synchronized scene rate</returns>
        public static float GetSynchronizedSceneRate(uint sceneID)
        {
            return Natives.GetSynchronizedSceneRate<float>(sceneID);
        }
        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates this synchronized scene is holding last frame
        /// </summary>
        /// <param name="sceneID">The synchronized scene handle</param>
        public static bool IsSynchronizedSceneHoldLastFrame(uint sceneID)
        {
            return Natives.IsSynchronizedSceneHoldLastFrame<bool>(sceneID);
        }
        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates this synchronized scene is looped
        /// </summary>
        /// <param name="sceneID">The synchronized scene handle</param>
        public static bool IsSynchronizedSceneLooped(uint sceneID)
        {
            return Natives.IsSynchronizedSceneLooped<bool>(sceneID);
        }
        /// <summary>
        /// Gets a <see cref="bool"/> value that indicates this synchronized scene is running
        /// </summary>
        /// <param name="sceneID">The synchronized scene handle</param>
        public static bool IsSynchronizedSceneRunning(uint sceneID)
        {
            return Natives.IsSynchronizedSceneRunning<bool>(sceneID);
        }
        /// <summary>
        /// A <c>setter</c> for <see cref="IsSynchronizedSceneHoldLastFrame(uint)"/>
        /// </summary>
        public static void SetSynchronizedSceneHoldLastFrame(uint sceneID, bool toggle)
        {
            Natives.SetSynchronizedSceneHoldLastFrame(sceneID, toggle);
        }
        /// <summary>
        /// A <c>setter</c> for <see cref="IsSynchronizedSceneLooped(uint)"/>
        /// </summary>
        public static void SetSynchronizedSceneLooped(uint sceneID, bool toggle)
        {
            Natives.SetSynchronizedSceneLooped(sceneID, toggle);
        }
        /// <summary>
        /// A <c>setter</c> for <see cref="GetSynchronizedScenePhase(uint)"/>
        /// </summary>
        public static void SetSynchronizedScenePhase(uint sceneID, float phase)
        {
            Natives.SetSynchronizedScenePhase(sceneID, phase);
        }
        /// <summary>
        /// A <c>setter</c> for <see cref="GetSynchronizedSceneRate(uint)"/>
        /// </summary>
        /// <param name="sceneID"></param>
        /// <param name="rate"></param>
        public static void SetSynchronizedSceneRate(uint sceneID, float rate)
        {
            Natives.SetSynchronizedSceneRate(sceneID, rate);
        }
        /// <summary>
        /// Attach this synchronized scene to the given <paramref name="entity"/>
        /// </summary>
        public static void AttachSynchronizedSceneToEntity(uint sceneID, Entity entity, int entityBoneIndex)
        {
            Natives.AttachSynchronizedSceneToEntity(sceneID, entity, entityBoneIndex);
        }
        /// <summary>
        /// Determines whether the given <paramref name="ped"/> is playing the given <paramref name="scenario"/>
        /// </summary>
        public static bool IsPedUsingScenario(Ped ped, string scenario)
        {
            return Natives.IS_PED_USING_SCENARIO<bool>(ped, scenario);
        }
    }
}
