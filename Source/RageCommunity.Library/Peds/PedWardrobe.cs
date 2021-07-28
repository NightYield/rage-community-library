using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RageCommunity.Library.Wrappers;
using Rage;

namespace RageCommunity.Library.Peds
{
    public class PedWardrobe
    {
        private readonly Ped _owner;
        internal PedWardrobe(Ped owner)
        {
            _owner = owner;
        }
        #region Component
        public WearableComponent Mask
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 1);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 1);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 1);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 1, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent HairStyle
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 2);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 2);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 2);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 2, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Torso
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 3);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 3);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 3);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 3, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Leg
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 4);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 4);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 4);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 4, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Parachute
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 5);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 5);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 5);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 5, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Shoes
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 6);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 6);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 6);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 6, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Accessories
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 7);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 7);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 7);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 7, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent UnderShirt
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 8);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 8);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 8);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 8, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent BodyArmor
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 9);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 9);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 9);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 9, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Decal
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 10);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 10);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 10);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 10, value.Drawable, value.Texture, value.Palette);
            }
        }
        public WearableComponent Tops
        {
            get
            {
                int drawable = NativeWrappers.GetPedDrawableVariation(_owner, 11);
                int texture = NativeWrappers.GetPedTextureVariation(_owner, 11);
                int palette = NativeWrappers.GetPedPaletteVariation(_owner, 11);
                return new(drawable, texture, palette);
            }
            set
            {
                NativeWrappers.SetPedComponentVariation(_owner, 11, value.Drawable, value.Texture, value.Palette);
            }
        }
        #endregion
        #region Props
        public WearableComponent Hat
        {
            get
            {
                int drawable = NativeWrappers.GetPedPropIndex(_owner, 1);
                int texture = NativeWrappers.GetPedPropTextureIndex(_owner, 1);
                return new(drawable, texture);
            }
            set => NativeWrappers.SetPedPropIndex(_owner, 1, value.Drawable, value.Texture, true);
        }
        public WearableComponent Glass
        {
            get
            {
                int drawable = NativeWrappers.GetPedPropIndex(_owner, 2);
                int texture = NativeWrappers.GetPedPropTextureIndex(_owner, 2);
                return new(drawable, texture);
            }
            set => NativeWrappers.SetPedPropIndex(_owner, 2, value.Drawable, value.Texture, true);
        }
        public WearableComponent Ear
        {
            get
            {
                int drawable = NativeWrappers.GetPedPropIndex(_owner, 2);
                int texture = NativeWrappers.GetPedPropTextureIndex(_owner, 2);
                return new(drawable, texture);
            }
            set => NativeWrappers.SetPedPropIndex(_owner, 2, value.Drawable, value.Texture, true);
        }
        public WearableComponent Watch
        {
            get
            {
                int drawable = NativeWrappers.GetPedPropIndex(_owner, 6);
                int texture = NativeWrappers.GetPedPropTextureIndex(_owner, 6);
                return new(drawable, texture);
            }
            set => NativeWrappers.SetPedPropIndex(_owner, 6, value.Drawable, value.Texture, true);
        }
        public WearableComponent Bracelet
        {
            get
            {
                int drawable = NativeWrappers.GetPedPropIndex(_owner, 7);
                int texture = NativeWrappers.GetPedPropTextureIndex(_owner, 7);
                return new(drawable, texture);
            }
            set => NativeWrappers.SetPedPropIndex(_owner, 7, value.Drawable, value.Texture, true);
        }
        #endregion
    }
}
