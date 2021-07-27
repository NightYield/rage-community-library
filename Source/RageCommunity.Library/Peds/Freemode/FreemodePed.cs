using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Rage;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Extensions;

namespace RageCommunity.Library.Peds.Freemode
{
    /// <summary>
    /// Represent a freemode character in the game world
    /// </summary>
    public class FreemodePed : Ped
    {
        /// <summary>
        /// Gets or sets this <see cref="FreemodePed"/> <see cref="HeadBlendData"/>
        /// </summary>     
        private PedFeatures _features;
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
        public new bool IsMale => Model == 0x705E61F2;
        /// <summary>
        /// Gets a value that indicates whether this <see cref="FreemodePed"/> is female
        /// </summary>
        /// <value><c>true</c> if this <see cref="FreemodePed"/> is female, otherwise <c>false</c></value>
        public new bool IsFemale => Model == 0x9C9EFFD8;
        /// <summary>
        /// Gets a value that indicates whether this <see cref="FreemodePed"/> <see cref="HeadBlendData"/> is finished
        /// </summary>
        public bool HasHeadBlendFinished => NativeWrappers.HasPedHeadBlendFinished(this);
        /// <summary>
        /// Gets an instance of <see cref="PedFeatures"/> that can be used to modify this <see cref="FreemodePed"/> face features
        /// </summary>
        public PedFeatures Features => _features ??= new PedFeatures(this);
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
        public FreemodePed(bool isMale, Vector3 position) : this(isMale, position, 0f)
        {
        }
        private FreemodePed(PoolHandle handle) : base(handle)
        {
        }
        /// <summary>
        /// Sets this <see cref="FreemodePed"/> component variation
        /// </summary>
        /// <param name="pedComponent">The ped component</param>
        /// <param name="drawable">The drawable of the <paramref name="pedComponent"/></param>
        /// <param name="texture">The texture of the specified <paramref name="drawable"/></param>
        /// <remarks>
        /// <para><c>Useful natives:</c></para>
        /// <para><see cref="NativeWrappers.GetNumberOfPedDrawableVariations(Ped, int)"/></para>
        /// <para><see cref="NativeWrappers.GetNumberOfPedTextureVariations(Ped, int, int)"/></para>
        /// </remarks>
        public void SetComponentVariation(PedComponent pedComponent, int drawable, int texture)
        {
            NativeWrappers.SetPedComponentVariation(this, (int)pedComponent, drawable, texture, 0);
        }
        /// <summary>
        /// Sets this <see cref="FreemodePed"/> property variation
        /// </summary>
        /// <param name="property">The ped property</param>
        /// <param name="drawable">The drawable of the <paramref name="property"/></param>
        /// <param name="texture">The texture of the specified <paramref name="drawable"/></param>
        /// <param name="attach">Attached or not</param>
        public void SetPropertyVariation(PedProperty property, int drawable, int texture, bool attach)
        {
            NativeWrappers.SetPedPropIndex(this, (int)property, drawable, texture, attach);
        }
        /// <summary>
        /// Sets this ped head overlay
        /// </summary>
        /// <param name="headOverlay">The overlay ID</param>
        /// <param name="index">the index value for the given <paramref name="headOverlay"/>. to disable the overlay, use <c>255</c></param>
        /// <param name="opacity">a floating-point between 0.0 and 1.0 to indicates how transparent the overlay is, values outside the valid ranges are clamped</param>
        /// <remarks>See <a href="https://docs.fivem.net/natives/?_0x48F44967FA05CC1E">this</a> for <paramref name="index"/> references, or use <see cref="NativeWrappers.GetPedHeadOverlayNum(int)"/></remarks>
        public void SetHeadOverlay(HeadOverlay headOverlay, int index, float opacity)
        {           
            opacity = MathHelper.Clamp(opacity, 0.0f, 1.0f);
            NativeWrappers.SetPedHeadOverlay(this, (int)headOverlay, index, opacity);
        }
        /// <summary>
        /// Sets this <see cref="FreemodePed"/> head overlay color
        /// </summary>
        /// <param name="headOverlay">The head overlay</param>
        /// <param name="colorType">1 for eyebrows, beards, and chest hair; 2 for blush and lipstick, otherwise 0</param>
        /// <param name="colorID">The colorID</param>
        /// <param name="secondColorID">The secondary color</param>
        /// <remarks>
        /// <para>See <a href="https://wiki.rage.mp/index.php?title=Hair_Colors">this</a> for hair-related color references</para>
        /// <para>See <a href="https://wiki.rage.mp/index.php?title=Makeup_Colors">this</a> for lipstick, blush and makeup color references</para>
        /// </remarks>
        public void SetHeadOverlayColor(HeadOverlay headOverlay, int colorType, int colorID, int secondColorID = 0)
        {
            NativeWrappers.SetPedHeadOverlayColor(this, (int)headOverlay, colorType, colorID, secondColorID);
        }
        /// <summary>
        /// Sets this <see cref="FreemodePed"/> hair color
        /// </summary>
        /// <param name="hairColorIndex">The index from 0 to 63, values outside valid ranges are clamped</param>
        /// <param name="highlightColorIndex">The index is same with <paramref name="hairColorIndex"/></param>
        /// <remarks>See: <a href="https://wiki.gtanet.work/index.php?title=Hair_Colors">GTA Network</a> for hair color references</remarks>
        public void SetHairColor(int hairColorIndex, int highlightColorIndex)
        {
            hairColorIndex = MathHelper.Clamp(hairColorIndex, 0, 63);
            highlightColorIndex = MathHelper.Clamp(highlightColorIndex, 0, 63);
            NativeWrappers.SetPedHairColor(this, hairColorIndex, highlightColorIndex);
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
            int[] maleHairModel = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 24, 30, 31, 32, 33, 
                35, 36, 37, 38, 39, 40, 41, 42, 43, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 65, 66, 67, 68, 70, 71, 73 };
            int[] femaleHairModel = { 1, 2, 3, 4, 5, 7, 9, 10, 11, 14, 15, 17, 18, 20, 21, 22, 38, 39, 40, 41, 45, 47, 48, 49, 52, 53, 
                54, 55, 56, 58, 59, 60, 65, 74, 75, 76 };
            int[] normalHairColor = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 28, 29, 55, 56, 57, 58, 59, 60, 61, 62, 63 };
            int[] hairHighlightColor = { 0, 1, 2, 11, 12, 20, 21, 22, 33, 34, 29, 36, 35, 40, 41, 53, 52, 51, 47, 45, 62, 63 };
            int firstID = mothers.GetRandomElement();
            int secondID = fathers.GetRandomElement();
            int thirdID = random.Next(10) == 0 ? IsMale ? fathers.GetRandomElement() : mothers.GetRandomElement() : 0;
            float thirdMix = (float)(thirdID == 0 ? 0.0f : random.NextDouble());
            float resemblance = (float)(IsFemale ? random.NextDouble() * 2 * 0.077 : random.NextDouble() * 2 * 0.785);
            resemblance = MathHelper.Clamp(resemblance, 0.0f, 1.0f);
            float skinTone = (float)random.NextDouble();
            int hairColor = normalHairColor.GetRandomElement();
            HeadOverlay[] headOverlays = Enum.GetValues(typeof(HeadOverlay)).Cast<HeadOverlay>().ToArray();
            HeadOverlay[] selectedHeadOverlays = headOverlays.OrderBy(x => random.Next(25)).Take(random.Next(3, headOverlays.Length)).ToArray();
            HeadOverlay[] forbiddenForFemale = { HeadOverlay.FacialHair, HeadOverlay.ChestHair, HeadOverlay.SunDamage, HeadOverlay.Ageing, HeadOverlay.Freckles };
            HeadOverlay[] forbiddenForMale = { HeadOverlay.Lipstick, HeadOverlay.Makeup, HeadOverlay.Blush, };
            FaceFeature[] faceFeatures = Enum.GetValues(typeof(FaceFeature)).Cast<FaceFeature>().ToArray();
            FaceFeature[] selectedFaceFeatures = faceFeatures.OrderBy(x => random.Next(25)).Take(random.Next(5, headOverlays.Length)).ToArray();
            EyeColor[] normalEyeColors = Enumerable.Range(0, 8).Cast<EyeColor>().ToArray();
            //https://s.id/Bx6sU
            Dictionary<HeadOverlay, float> opacityMultiplier = new()
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
            GameFiber.Yield();
            HeadBlend = new HeadBlendData(firstID, secondID, thirdID, firstID, secondID, thirdID, (float)Math.Round(resemblance, 5), (float)Math.Round(skinTone, 5), (float)Math.Round(thirdMix, 5), false);
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                GameFiber.Yield();
                if (NativeWrappers.HasPedHeadBlendFinished(this))
                {
                    break;
                }
                if (stopwatch.ElapsedMilliseconds > 1000)
                {
                    break;
                }
            }
            EyeColor = normalEyeColors.GetRandomElement();
            SetHairColor(hairColor, random.Next(10) == 0 ? hairHighlightColor.GetRandomElement() : hairColor);
            NativeWrappers.FinalizeHeadBlend(this);
            foreach (FaceFeature faceFeature in selectedFaceFeatures)
            {
                float scale = (float)Math.Round(random.Next(2) == 1 ? random.NextDouble() : random.NextDouble() * -1, 3, MidpointRounding.ToEven);
                SetFaceFeature(faceFeature, scale);
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
                        _ when opacityMultiplier.ContainsKey(headOverlay) => (float)(random.NextDouble() * 2 * opacityMultiplier[headOverlay]),
                        _ => (float)Math.Round(random.NextDouble(), 5, MidpointRounding.ToEven),
                    };
                    SetHeadOverlay(headOverlay, index, opacity);
                    switch (headOverlay)
                    {
                        case HeadOverlay.FacialHair:
                        case HeadOverlay.ChestHair:
                        case HeadOverlay.Eyebrows:
                            NativeWrappers.SetPedHeadOverlayColor(this, (int)headOverlay, 1, hairColor, 0);
                            break;
                        default: break;
                    }
                }
            }
            else if (IsFemale)
            {
                SetComponentVariation(PedComponent.HairStyle, femaleHairModel.GetRandomElement(), 0);
                foreach (HeadOverlay headOverlay in selectedHeadOverlays)
                {
                    int index = headOverlay switch
                    {
                        HeadOverlay.Blush => random.Next(10) == 0 ? random.Next(1, 6) : 255,
                        HeadOverlay.Makeup => random.Next(4) == 1 ? random.Next(1, 16) : 255,
                        _ when forbiddenForFemale.Contains(headOverlay) => 255,
                        _ => random.Next(NativeWrappers.GetPedHeadOverlayNum((int)headOverlay)),
                    };
                    float opacity = headOverlay switch
                    {
                        _ when forbiddenForFemale.Contains(headOverlay) => 0.0f,
                        _ when opacityMultiplier.ContainsKey(headOverlay) => (float)(random.NextDouble() * 2 * opacityMultiplier[headOverlay]),
                        _ => (float)Math.Round(random.NextDouble(), 5, MidpointRounding.ToEven),
                    };
                    SetHeadOverlay(headOverlay, index, opacity);
                    switch (headOverlay)
                    {
                        case HeadOverlay.Eyebrows:
                            NativeWrappers.SetPedHeadOverlayColor(this, (int)headOverlay, 1, hairColor, 0);
                            break;
                        case HeadOverlay.Blush:
                        case HeadOverlay.Lipstick:
                            NativeWrappers.SetPedHeadOverlayColor(this, (int)headOverlay, 2, random.Next(26), 0);
                            break;
                        default: break;
                    }
                }
            }            
        }
        /// <summary>
        /// Gets a <see cref="FreemodePed"/> from the specified <paramref name="ped"/>
        /// </summary>
        /// <param name="ped">The target <see cref="Ped"/></param>
        /// <returns>If successful, returns the resulting <see cref="FreemodePed"/>; otherwise return <c>null</c></returns>
        /// <remarks>
        /// <para>This method will considered success if the given <paramref name="ped"/> <see cref="Model"/> is <c>mp_f_freemode_01</c> or <c>mp_m_freemode_01</c></para>
        /// <para>Please note that this <see cref="FreemodePed"/> will not be randomized, but you can still use <see cref="RandomizeAppearance"/> method</para>
        /// </remarks>
        public static FreemodePed FromRegularPed(Ped ped)
        {
            if (ped.Model == 0x9C9EFFD8 || ped.Model == 0x9C9EFFD8)
            {
                return new FreemodePed(ped.Handle);
            }
            else return null;
        }
    }
}
