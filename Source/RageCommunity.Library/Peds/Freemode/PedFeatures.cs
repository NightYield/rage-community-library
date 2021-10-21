using Rage;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Peds.Freemode
{
    /// <summary>
    /// Represent the <see cref="FreemodePed"/> face features
    /// <para>This class cannot be inherited</para>
    /// </summary>
    public sealed class PedFeatures
    {
        private readonly Ped _owner;
        internal PedFeatures(Ped owner)
        {
            _owner = owner;
        }
        /// <summary>
        /// Make changes the nose width of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NoseWidth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NoseWidth, scale);
            }
        }
        /// <summary>
        /// Make changes the nose bottom height of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NoseBottomHeight
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NoseBottomHeight, scale);
            }
        }
        /// <summary>
        /// Make changes the nose tip length of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NoseTipLength
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NoseTipLength, scale);
            }
        }
        /// <summary>
        /// Make changes the nose bridge depth of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NoseBridgeDepth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NoseBridgeDepth, scale);
            }
        }
        /// <summary>
        /// Make changes the nose tip height of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NoseTipHeight
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NoseTipHeight, scale);
            }
        }
        /// <summary>
        /// Make changes the nose broken of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NoseBroken
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NoseBroken, scale);
            }
        }
        /// <summary>
        /// Make changes the brow height of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float BrowHeight
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.BrowHeight, scale);
            }
        }
        /// <summary>
        /// Make changes the brow depth of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float BrowDepth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.BrowDepth, scale);
            }
        }
        /// <summary>
        /// Make changes the cheekbone height of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float CheekboneHeight
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.CheekboneHeight, scale);
            }
        }
        /// <summary>
        /// Make changes the cheekbone width of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float CheekboneWidth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.CheekboneWidth, scale);
            }
        }
        /// <summary>
        /// Make changes the cheek depth of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float CheekDepth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.CheekDepth, scale);
            }
        }
        /// <summary>
        /// Make changes the eye size of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float EyeSize
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.EyeSize, scale);
            }
        }
        /// <summary>
        /// Make changes the lip thickness of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float LipThickness
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.LipThickness, scale);
            }
        }
        /// <summary>
        /// Make changes the jaw width of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float JawWidth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.JawWidth, scale);
            }
        }
        /// <summary>
        /// Make changes the jaw shape of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float JawShape
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.JawShape, scale);
            }
        }
        /// <summary>
        /// Make changes the chin height of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float ChinHeight
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.ChinHeight, scale);
            }
        }
        /// <summary>
        /// Make changes the chin depth of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float ChinDepth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.ChinDepth, scale);
            }
        }
        /// <summary>
        /// Make changes the chin width of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float ChinWidth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.ChinWidth, scale);
            }
        }
        /// <summary>
        /// Make changes the chin indent of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float ChinIndent
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.ChinIndent, scale);
            }
        }
        /// <summary>
        /// Make changes the neck width of your freemode character.
        /// </summary>
        /// <value>Ranges from -1.0 to 1.0, values outside the valid ranges will be clamped</value>
        public float NeckWidth
        {
            set
            {
                float scale = MathHelper.Clamp(value, -1.0f, 1.0f);
                NativeWrappers.SetPedFaceFeature(_owner, (int)FaceFeature.NeckWidth, scale);
            }
        }
    }
}
