namespace RageCommunity.Library.Peds
{
    /// <summary>
    /// Represent the <see cref="Rage.Ped"/> wearable component
    /// </summary>
    public class WearableComponent
    {
        /// <summary>
        /// The DrawableID
        /// </summary>
        public int Drawable { get; private set; }
        /// <summary>
        /// The TextureID
        /// </summary>
        public int Texture { get; private set; }
        /// <summary>
        /// The PaletteID (usually 0)
        /// </summary>
        public int Palette { get; private set; } = 0;
        /// <summary>
        /// Initializes a new instance of <see cref="WearableComponent"/> class
        /// </summary>
        public WearableComponent(int drawable, int texture, int palette = 0)
        {
            Drawable = drawable;
            Texture = texture;
            Palette = palette;
        }
    }
}
