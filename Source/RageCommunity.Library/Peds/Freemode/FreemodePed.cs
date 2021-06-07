using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Peds.Freemode
{
    public class FreemodePed : Ped
    {
        public HeadBlendData HeadBlend
        {
            get
            {
                NativeWrappers.GetPedHeadBlendData(this, out var data);
                return data;
            }
            set
            {
                NativeWrappers.SetPedHeadBlendData(this,
                                                   value.shapeFirstID,
                                                   value.shapeSecondID,
                                                   value.shapeThirdID,
                                                   value.skinFirstID,
                                                   value.skinSecondID,
                                                   value.skinThirdID,
                                                   value.shapeMix,
                                                   value.skinMix,
                                                   value.thirdMix,
                                                   value.isParent);
            }
        }
        /// <summary>
        /// Gets or Sets this <see cref="FreemodePed"/> <see cref="Freemode.EyeColor"/>
        /// </summary>
        public EyeColor EyeColor
        {
            get => (EyeColor)NativeWrappers.GetPedEyeColor(this);
            set => NativeWrappers.SetPedEyeColor(this, (int)value);
        }
        /// <summary>
        /// Gets a value that indicates whether this <see cref="FreemodePed"/> is male
        /// </summary>
        public new bool IsMale => Model.Hash == 0x705E61F2;
        /// <summary>
        /// Gets a value that indicates whether this <see cref="FreemodePed"/> <see cref="HeadBlendData"/> is finished
        /// </summary>
        public bool HasHeadBlendFinished => NativeWrappers.HasPedHeadBlendFinished(this);
        public FreemodePed(bool isMale, Vector3 position, float heading) : base(isMale ? 0x705E61F2 : 0x9C9EFFD8, position, heading)
        {
        }
        public FreemodePed(bool isMale, Vector3 position) : base(isMale ? 0x705E61F2 : 0x9C9EFFD8, position, 0f)
        {
        }
        /// <summary>
        /// Sets this ped component variation
        /// </summary>
        public void SetComponentVariation(ComponentID componentID, int drawableID, int textureID)
        {
            drawableID = MathHelper.Clamp(drawableID, 0, GetDrawableVariationCount((int)componentID));
            textureID = MathHelper.Clamp(textureID, 0, GetTextureVariationCount((int)componentID, drawableID));
            NativeWrappers.SetPedComponentVariation(this, (int)componentID, drawableID, textureID, 0);
        }
        /// <summary>
        /// Sets this ped head overlay
        /// </summary>
        /// <param name="overlayID">The overlay ID</param>
        /// <param name="index">the index value for the given <paramref name="overlayID"/>. Value outside valid ranges are clamped</param>
        /// <param name="opacity">a value between 0 and 1 to indicates how transparent the overlay is, a value outside the valid ranges are clamped</param>
        /// <remarks>See: <a href="https://docs.fivem.net/natives/?_0x48F44967FA05CC1E">FiveM</a></remarks>
        public void SetHeadOverlay(OverlayID overlayID, int index, float opacity)
        {
            //overlayID      Part                  Index,   to disable
            //0               Blemishes             0 - 23, 255
            //1               Facial Hair           0 - 28, 255
            //2               Eyebrows              0 - 33, 255
            //3               Ageing                0 - 14, 255
            //4               Makeup                0 - 74, 255
            //5               Blush                 0 - 6, 255
            //6               Complexion            0 - 11, 255
            //7               Sun Damage            0 - 10, 255
            //8               Lipstick              0 - 9, 255
            //9               Moles / Freckles      0 - 17, 255
            //10              Chest Hair            0 - 16, 255
            //11              Body Blemishes        0 - 11, 255
            //12              Add Body Blemishes    0 - 1, 255
            index = MathHelper.Clamp(index, 0, NativeWrappers.GetPedHeadOverlayNum((int)overlayID));
            opacity = MathHelper.Clamp(opacity, 0.0f, 1.0f);
            NativeWrappers.SetPedHeadOverlay(this, (int)overlayID, index, opacity);
        }
        /// <summary>
        /// Sets this <see cref="FreemodePed"/> hair color
        /// </summary>
        /// <param name="hairColorIndex">The index from 0 to 63, outside this are clamped</param>
        /// <remarks>See: <a href="https://wiki.gtanet.work/index.php?title=Hair_Colors">GTA Network</a></remarks>
        public void SetHairColor(int hairColorIndex)
        {
            hairColorIndex = MathHelper.Clamp(hairColorIndex, 0, 63);
            NativeWrappers.SetPedHairColor(this, hairColorIndex);
        }
        /// <summary>
        /// Sets the various freemode face features, e.g. nose length, chin shape. Scale ranges from -1.0 to 1.0.
        /// </summary>
        /// <param name="faceFeature">The <see cref="FaceFeature"/></param>
        /// <param name="scale">The <paramref name="faceFeature"/> scale, ranges from -1.0 to 1.0, values outside ranges are clamped</param>
        public void SetFaceFeature(FaceFeature faceFeature, float scale)
        {
            scale = MathHelper.Clamp(scale, -1.0f, 1.0f);
            NativeWrappers.SetPedFaceFeature(this, (int)faceFeature, scale);
        }

        public void RandomizeAppearance()
        {
            //TODO
        }
    }
}
