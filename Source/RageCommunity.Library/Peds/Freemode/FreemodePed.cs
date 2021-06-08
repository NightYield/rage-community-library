using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Extensions;

namespace RageCommunity.Library.Peds.Freemode
{
    /// <summary>
    /// Represent a freemode character in game world
    /// </summary>
    public class FreemodePed : Ped
    {
        /// <summary>
        /// Gets or sets this <see cref="FreemodePed"/> <see cref="HeadBlendData"/>
        /// </summary>
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
        /// Gets or sets this <see cref="FreemodePed"/> <see cref="Freemode.EyeColor"/>
        /// </summary>
        /// <value>The eye color of this <see cref="FreemodePed"/></value>
        public EyeColor EyeColor
        {
            get => (EyeColor)NativeWrappers.GetPedEyeColor(this);
            set => NativeWrappers.SetPedEyeColor(this, (int)value);
        }
        /// <summary>
        /// Gets a value that indicates whether this <see cref="FreemodePed"/> is male
        /// </summary>
        /// <value><c>true</c> if this <see cref="FreemodePed"/> is male, otherwise <c>false</c></value>
        public new bool IsMale => Model.Hash == 0x705E61F2;
        /// <summary>
        /// Gets a value that indicates whether this <see cref="FreemodePed"/> <see cref="HeadBlendData"/> is finished
        /// </summary>
        public bool HasHeadBlendFinished => NativeWrappers.HasPedHeadBlendFinished(this);
        /// <summary>
        /// Initializes a new instances of the <see cref="FreemodePed"/> class
        /// </summary>
        public FreemodePed(bool isMale, Vector3 position, float heading) : base(isMale ? 0x705E61F2 : 0x9C9EFFD8, position, heading)
        {
            RandomizeAppearance();
        }
        /// <summary>
        /// Initializes a new instances of the <see cref="FreemodePed"/> class
        /// </summary>
        public FreemodePed(bool isMale, Vector3 position) : base(isMale ? 0x705E61F2 : 0x9C9EFFD8, position, 0f)
        {
            RandomizeAppearance();
        }
        /// <summary>
        /// Sets this ped component variation
        /// </summary>
        public void SetComponentVariation(PedComponent pedComponent, int drawableID, int textureID)
        {
            drawableID = MathHelper.Clamp(drawableID, 0, GetDrawableVariationCount((int)pedComponent));
            textureID = MathHelper.Clamp(textureID, 0, GetTextureVariationCount((int)pedComponent, drawableID));
            NativeWrappers.SetPedComponentVariation(this, (int)pedComponent, drawableID, textureID, 0);
        }
        /// <summary>
        /// Sets this ped head overlay
        /// </summary>
        /// <param name="headOverlay">The overlay ID</param>
        /// <param name="index">the index value for the given <paramref name="headOverlay"/>. Value outside valid ranges are clamped, to disable use <c>255</c></param>
        /// <param name="opacity">a floating-point between 0.0 and 1.0 to indicates how transparent the overlay is, a value outside the valid ranges are clamped</param>
        /// <remarks>See: <a href="https://docs.fivem.net/natives/?_0x48F44967FA05CC1E">FiveM</a></remarks>
        public void SetHeadOverlay(HeadOverlay headOverlay, int index, float opacity)
        {
            //overlayID      Part                  Index,     to disable
            //0               Blemishes             0 - 23,     255
            //1               Facial Hair           0 - 28,     255
            //2               Eyebrows              0 - 33,     255
            //3               Ageing                0 - 14,     255
            //4               Makeup                0 - 74,     255
            //5               Blush                 0 - 6,      255
            //6               Complexion            0 - 11,     255
            //7               Sun Damage            0 - 10,     255
            //8               Lipstick              0 - 9,      255
            //9               Moles / Freckles      0 - 17,     255
            //10              Chest Hair            0 - 16,     255
            //11              Body Blemishes        0 - 11,     255
            //12              Add Body Blemishes    0 - 1,      255
            index = MathHelper.Clamp(index, 0, NativeWrappers.GetPedHeadOverlayNum((int)headOverlay));
            opacity = MathHelper.Clamp(opacity, 0.0f, 1.0f);
            NativeWrappers.SetPedHeadOverlay(this, (int)headOverlay, index, opacity);
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
        /// <summary>
        /// Randomize this <see cref="FreemodePed"/> appearance
        /// </summary>
        public void RandomizeAppearance()
        {
            Random random = new((int)Game.GetHashKey(DateTime.UtcNow.ToString("O")));
            //https://s.id/BkZuh
            #region local variable
            int[] mothers = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 45 };
            int[] fathers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 42, 43, 44 };
            int[] maleHairModel = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 24, 30, 31, 
                35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 65, 66, 68, 70, 71, 72, 73, 74 };
            int[] femaleHairModel = { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 28, 30, 31, 
                32, 36, 37, 38, 39, 40, 41, 42, 45, 46, 47, 48, 49, 50, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 65, 73, 78, 74, 77, 76 };
            int[] normalHairColor = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 28, 29, 55, 56, 57, 58, 59, 60, 61, 62, 63 };
            int[] blushes = { 9, 11, 12, 13, 14, 15, 16 };
            int mother = mothers.GetRandomElement();
            int father = fathers.GetRandomElement();
            SetHairColor(normalHairColor.GetRandomElement());
            HeadOverlay[] headOverlays = Enum.GetValues(typeof(HeadOverlay)).Cast<HeadOverlay>().ToArray();
            HeadOverlay[] selectedHeadOverlays = headOverlays.OrderBy(x => random.Next()).Take(random.Next(3, headOverlays.Length)).ToArray();
            HeadOverlay[] forbiddenForFemale = { HeadOverlay.FacialHair, HeadOverlay.ChestHair, HeadOverlay.SunDamage, HeadOverlay.Ageing, HeadOverlay.Freckles };
            HeadOverlay[] forbiddenForMale = { HeadOverlay.Lipstick, HeadOverlay.Makeup, HeadOverlay.Blush, HeadOverlay.AddBodyBlemishes };
            FaceFeature[] faceFeatures = Enum.GetValues(typeof(FaceFeature)).Cast<FaceFeature>().ToArray();
            FaceFeature[] selectedFaceFeatures = faceFeatures.OrderBy(x => random.Next()).Take(random.Next(5, headOverlays.Length)).ToArray();
            EyeColor[] normalEyeColors = Enumerable.Range(0, 11).Cast<EyeColor>().ToArray();
            Dictionary<HeadOverlay, float> opacityMultiplier = new Dictionary<HeadOverlay, float>()
            {
                {HeadOverlay.Blemishes, 0.1f },
                {HeadOverlay.FacialHair, 1f },
                {HeadOverlay.Eyebrows, 1f },
                {HeadOverlay.Ageing, 0.5f },
                {HeadOverlay.Makeup, 1f },
                {HeadOverlay.Blush, 0.6f },
                {HeadOverlay.Complexion, 0.6f },
                {HeadOverlay.SunDamage, 0.4f },
                {HeadOverlay.Lipstick, 1f },
                {HeadOverlay.Freckles, 1f },
                {HeadOverlay.ChestHair, 1f },
            };
            #endregion
            HeadBlend = new HeadBlendData(mother, father, 0, mother, father, 0, (float)Math.Round(random.NextDouble(), 5), (float)Math.Round(random.NextDouble(), 5), 0.0f, false);
            System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
            while (true)
            {
                GameFiber.Yield();
                if (NativeWrappers.HasPedHeadBlendFinished(this))
                {
                    Game.LogTrivial($"Time elapsed: {stopwatch.ElapsedMilliseconds}");
                    break;
                }
                if (stopwatch.ElapsedMilliseconds > 1000)
                {
                    Game.LogTrivial("Abort wait, Timeout");
                    break;
                }
            }
            EyeColor = normalEyeColors.GetRandomElement();
            NativeWrappers.FinalizeHeadBlend(this);
            foreach (FaceFeature faceFeature in selectedFaceFeatures)
            {
                SetFaceFeature(faceFeature, (float)Math.Round(random.Next(2) == 1 ? random.NextDouble() : random.NextDouble() * -1, 3));
            }
            if (IsMale)
            {
                SetComponentVariation(PedComponent.HairStyle, maleHairModel.GetRandomElement(), 0);              
                foreach (HeadOverlay headOverlay in selectedHeadOverlays)
                {
                    int index = headOverlay switch
                    {
                        _ when forbiddenForMale.Contains(headOverlay) => 255,
                        _ => random.Next(NativeWrappers.GetPedHeadOverlayNum((int)headOverlay))
                    };
                    float opacity = headOverlay switch
                    {
                        _ when forbiddenForMale.Contains(headOverlay) => 0.0f,
                        _ when opacityMultiplier.ContainsKey(headOverlay) => (float)((random.NextDouble() * 2 * opacityMultiplier[headOverlay]) - 1f),
                        _ => 0.0f,
                    };
                    Game.LogTrivial($"Overlay: {headOverlay}, Index: {index}, Opacity: {opacity}");
                    SetHeadOverlay(headOverlay, index, opacity);
                }
            }
            else
            {
                SetComponentVariation(PedComponent.HairStyle, femaleHairModel.GetRandomElement(), 0);
                foreach (HeadOverlay headOverlay in selectedHeadOverlays)
                {
                    int index = headOverlay switch
                    {
                        HeadOverlay.Blush => blushes.GetRandomElement(),
                        HeadOverlay.Makeup => random.Next(4) == 1 ? random.Next(17) : 255,
                        _ when forbiddenForFemale.Contains(headOverlay) => 255,
                        _ => random.Next(NativeWrappers.GetPedHeadOverlayNum((int)headOverlay)),
                    };
                    float opacity = headOverlay switch
                    {
                        _ when forbiddenForFemale.Contains(headOverlay) => 0.0f,
                        _ when opacityMultiplier.ContainsKey(headOverlay) => (float)((random.NextDouble() * 2 * opacityMultiplier[headOverlay]) -1f),
                        _ => 0.0f,
                    };
                    Game.LogTrivial($"Overlay: {headOverlay}, Index: {index}, Opacity: {opacity}");
                    SetHeadOverlay(headOverlay, index, opacity);
                }
            }
        }
    }
}
