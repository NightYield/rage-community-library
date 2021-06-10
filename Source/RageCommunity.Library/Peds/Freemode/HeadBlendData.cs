namespace RageCommunity.Library.Peds.Freemode
{
    using System.Runtime.InteropServices;
    using System.Text;
    /// <summary>
    /// Source: <a href="https://gist.github.com/NoNameSet/20b7d1d75763b0678564eaedd4bed404">NoNameSet Github Gist</a>
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct HeadBlendData
    {
        [FieldOffset(0)]
        public int shapeFirstID;
        [FieldOffset(8)]
        public int shapeSecondID;
        [FieldOffset(16)]
        public int shapeThirdID;
        [FieldOffset(24)]
        public int skinFirstID;
        [FieldOffset(32)]
        public int skinSecondID;
        [FieldOffset(40)]
        public int skinThirdID;
        [FieldOffset(48)]
        public float shapeMix;
        [FieldOffset(56)]
        public float skinMix;
        [FieldOffset(64)]
        public float thirdMix;
        [FieldOffset(75)]
        public bool isParent;

        /// <summary>
        /// Initializes a new instances of the <see cref="HeadBlendData"/> class
        /// </summary>
        public HeadBlendData(int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)
        {
            this.shapeFirstID = shapeFirstID;
            this.shapeSecondID = shapeSecondID;
            this.shapeThirdID = shapeThirdID;
            this.skinFirstID = skinFirstID;
            this.skinSecondID = skinSecondID;
            this.skinThirdID = skinThirdID;
            this.shapeMix = shapeMix;
            this.skinMix = skinMix;
            this.thirdMix = thirdMix;
            this.isParent = isParent;
        }
        /// <inheritdoc/>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Shape: (");
            sb.Append(shapeFirstID);
            sb.Append(',');
            sb.Append(' ');
            sb.Append(shapeSecondID);
            sb.Append(',');
            sb.Append(' ');
            sb.Append(shapeThirdID);
            sb.Append("). Skin: (");
            sb.Append(skinFirstID);
            sb.Append(',');
            sb.Append(' ');
            sb.Append(skinSecondID);
            sb.Append(',');
            sb.Append(' ');
            sb.Append(skinThirdID);
            sb.Append("). Mix: (Shape: ");
            sb.Append(shapeMix);
            sb.Append(", Skin: ");
            sb.Append(skinMix);
            sb.Append(", Third: ");
            sb.Append(thirdMix);
            sb.Append(") Parent: ");
            sb.Append(isParent);
            return sb.ToString();
        }
    }
}
