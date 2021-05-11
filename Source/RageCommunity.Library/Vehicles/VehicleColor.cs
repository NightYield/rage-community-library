using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RageCommunity.Library.Vehicles
{
    public class VehicleColor
    {
        /// <summary>
        /// The primary color paint index
        /// </summary>
        public VehiclePaint PrimaryColor { get; set; }
        /// <summary>
        /// The secondary color paint index
        /// </summary>
        public VehiclePaint SecondaryColor { get; set; }
        /// <summary>
        /// The primary color using RGBA <see cref="Color"/>
        /// </summary>
        public Color PrimaryColorRGBA { get; set; }
        /// <summary>
        /// The secondary color using RGBA <see cref="Color"/>
        /// </summary>
        public Color SecondaryColorRGBA { get; set; }
        /// <summary>
        /// Gets the primary color name
        /// </summary>
        public string PrimaryColorName { get; set; }
        /// <summary>
        /// Gets the secondary color name
        /// </summary>
        public string SecondaryColorName { get; set; }
        public VehicleColor(VehiclePaint primary, VehiclePaint secondary)
        {
            PrimaryColor = primary;
            SecondaryColor = secondary;
            PrimaryColorRGBA = GetColor(primary);
            SecondaryColorRGBA = GetColor(secondary);
        }
        public static Color GetColor(VehiclePaint vehiclePaint) => vehiclePaint switch
        {
            VehiclePaint.MetallicBlack => Color.FromArgb(13, 17, 22),
            VehiclePaint.MetallicGraphiteBlack => Color.FromArgb(28, 29, 33),
            VehiclePaint.MetallicBlackSteal => Color.FromArgb(50, 56, 61),
            VehiclePaint.MetallicDarkSilver => Color.FromArgb(69, 75, 79),
            VehiclePaint.MetallicSilver => Color.FromArgb(153, 157, 160),
            VehiclePaint.MetallicBlueSilver => Color.FromArgb(194, 196, 198),
            VehiclePaint.MetallicSteelGray => Color.FromArgb(151, 154, 151),
            VehiclePaint.MetallicShadowSilver => Color.FromArgb(99, 115, 128),
            VehiclePaint.MetallicStoneSilver => Color.FromArgb(99, 98, 92),
            VehiclePaint.MetallicMidnightSilver => Color.FromArgb(60, 63, 71),
            VehiclePaint.MetallicGunMetal => Color.FromArgb(68, 78, 84),
            VehiclePaint.MetallicAnthraciteGrey => Color.FromArgb(29, 33, 41),
            VehiclePaint.MatteBlack => Color.FromArgb(19, 24, 31),
            VehiclePaint.MatteGray => Color.FromArgb(38, 40, 42),
            VehiclePaint.MatteLightGrey => Color.FromArgb(81, 85, 84),
            VehiclePaint.UtilBlack => Color.FromArgb(21, 25, 33),
            VehiclePaint.UtilBlackPoly => Color.FromArgb(30, 36, 41),
            VehiclePaint.UtilDarksilver => Color.FromArgb(51, 58, 60),
            VehiclePaint.UtilSilver => Color.FromArgb(140, 144, 149),
            VehiclePaint.UtilGunMetal => Color.FromArgb(57, 67, 77),
            VehiclePaint.UtilShadowSilver => Color.FromArgb(80, 98, 114),
            VehiclePaint.WornBlack => Color.FromArgb(30, 35, 47),
            VehiclePaint.WornGraphite => Color.FromArgb(54, 58, 63),
            VehiclePaint.WornSilverGrey => Color.FromArgb(160, 161, 153),
            VehiclePaint.WornSilver => Color.FromArgb(211, 211, 211),
            VehiclePaint.WornBlueSilver => Color.FromArgb(183, 191, 202),
            VehiclePaint.WornShadowSilver => Color.FromArgb(119, 135, 148),
            VehiclePaint.MetallicRed => Color.FromArgb(192, 14, 26),
            VehiclePaint.MetallicTorinoRed => Color.FromArgb(218, 25, 24),
            VehiclePaint.MetallicFormulaRed => Color.FromArgb(182, 17, 27),
            VehiclePaint.MetallicBlazeRed => Color.FromArgb(165, 30, 35),
            VehiclePaint.MetallicGracefulRed => Color.FromArgb(123, 26, 34),
            VehiclePaint.MetallicGarnetRed => Color.FromArgb(142, 27, 31),
            VehiclePaint.MetallicDesertRed => Color.FromArgb(111, 24, 24),
            VehiclePaint.MetallicCabernetRed => Color.FromArgb(73, 17, 29),
            VehiclePaint.MetallicCandyRed => Color.FromArgb(182, 15, 37),
            VehiclePaint.MetallicSunriseOrange => Color.FromArgb(212, 74, 23),
            VehiclePaint.MetallicClassicGold => Color.FromArgb(194, 148, 79),
            VehiclePaint.MetallicOrange => Color.FromArgb(247, 134, 22),
            VehiclePaint.MatteRed => Color.FromArgb(207, 31, 33),
            VehiclePaint.MatteDarkRed => Color.FromArgb(115, 32, 33),
            VehiclePaint.MatteOrange => Color.FromArgb(242, 125, 32),
            VehiclePaint.MatteYellow => Color.FromArgb(255, 201, 31),
            VehiclePaint.UtilRed => Color.FromArgb(156, 16, 22),
            VehiclePaint.UtilBrightRed => Color.FromArgb(222, 15, 24),
            VehiclePaint.UtilGarnetRed => Color.FromArgb(143, 30, 23),
            VehiclePaint.WornRed => Color.FromArgb(169, 71, 68),
            VehiclePaint.WornGoldenRed => Color.FromArgb(177, 108, 81),
            VehiclePaint.WornDarkRed => Color.FromArgb(55, 28, 37),
            VehiclePaint.MetallicDarkGreen => Color.FromArgb(19, 36, 40),
            VehiclePaint.MetallicRacingGreen => Color.FromArgb(18, 46, 43),
            VehiclePaint.MetallicSeaGreen => Color.FromArgb(18, 56, 60),
            VehiclePaint.MetallicOliveGreen => Color.FromArgb(49, 66, 63),
            VehiclePaint.MetallicGreen => Color.FromArgb(21, 92, 45),
            VehiclePaint.MetallicGasolineBlueGreen => Color.FromArgb(27, 103, 112),
            VehiclePaint.MatteLimeGreen => Color.FromArgb(102, 184, 31),
            VehiclePaint.UtilDarkGreen => Color.FromArgb(34, 56, 62),
            VehiclePaint.UtilGreen => Color.FromArgb(29, 90, 63),
            VehiclePaint.WornDarkGreen => Color.FromArgb(45, 66, 63),
            VehiclePaint.WornGreen => Color.FromArgb(69, 89, 75),
            VehiclePaint.WornSeaWash => Color.FromArgb(101, 134, 127),
            VehiclePaint.MetallicMidnightBlue => Color.FromArgb(34, 46, 70),
            VehiclePaint.MetallicDarkBlue => Color.FromArgb(35, 49, 85),
            VehiclePaint.MetallicSaxonyBlue => Color.FromArgb(48, 76, 126),
            VehiclePaint.MetallicBlue => Color.FromArgb(71, 87, 143),
            VehiclePaint.MetallicMarinerBlue => Color.FromArgb(99, 123, 167),
            VehiclePaint.MetallicHarborBlue => Color.FromArgb(57, 71, 98),
            VehiclePaint.MetallicDiamondBlue => Color.FromArgb(214, 231, 241),
            VehiclePaint.MetallicSurfBlue => Color.FromArgb(118, 175, 190),
            VehiclePaint.MetallicNauticalBlue => Color.FromArgb(52, 94, 114),
            VehiclePaint.MetallicBrightBlue2 => Color.FromArgb(11, 156, 241),
            VehiclePaint.MetallicPurpleBlue => Color.FromArgb(47, 45, 82),
            VehiclePaint.MetallicSpinnakerBlue => Color.FromArgb(40, 44, 77),
            VehiclePaint.MetallicUltraBlue => Color.FromArgb(35, 84, 161),
            VehiclePaint.MetallicBrightBlue => Color.FromArgb(110, 163, 198),
            VehiclePaint.UtilDarkBlue => Color.FromArgb(17, 37, 82),
            VehiclePaint.UtilMidnightBlue => Color.FromArgb(27, 32, 62),
            VehiclePaint.UtilBlue => Color.FromArgb(39, 81, 144),
            VehiclePaint.UtilSeaFoamBlue => Color.FromArgb(96, 133, 146),
            VehiclePaint.UtilLightningblue => Color.FromArgb(36, 70, 168),
            VehiclePaint.UtilMauiBluePoly => Color.FromArgb(66, 113, 225),
            VehiclePaint.UtilBrightBlue => Color.FromArgb(59, 57, 224),
            VehiclePaint.MatteDarkBlue => Color.FromArgb(31, 40, 82),
            VehiclePaint.MatteBlue => Color.FromArgb(37, 58, 167),
            VehiclePaint.MatteMidnightBlue => Color.FromArgb(28, 53, 81),
            VehiclePaint.WornDarkblue => Color.FromArgb(76, 95, 129),
            VehiclePaint.WornBlue => Color.FromArgb(88, 104, 142),
            VehiclePaint.WornLightblue => Color.FromArgb(116, 181, 216),
            VehiclePaint.MetallicTaxiYellow => Color.FromArgb(255, 207, 32),
            VehiclePaint.MetallicRaceYellow => Color.FromArgb(251, 226, 18),
            VehiclePaint.MetallicBronze => Color.FromArgb(145, 101, 50),
            VehiclePaint.MetallicYellowBird => Color.FromArgb(224, 225, 61),
            VehiclePaint.MetallicLime => Color.FromArgb(152, 210, 35),
            VehiclePaint.MetallicChampagne => Color.FromArgb(155, 140, 120),
            VehiclePaint.MetallicPuebloBeige => Color.FromArgb(80, 50, 24),
            VehiclePaint.MetallicDarkIvory => Color.FromArgb(71, 63, 43),
            VehiclePaint.MetallicChocoBrown => Color.FromArgb(34, 27, 25),
            VehiclePaint.MetallicGoldenBrown => Color.FromArgb(101, 63, 35),
            VehiclePaint.MetallicLightBrown => Color.FromArgb(119, 92, 62),
            VehiclePaint.MetallicStrawBeige => Color.FromArgb(172, 153, 117),
            VehiclePaint.MetallicMossBrown => Color.FromArgb(108, 107, 75),
            VehiclePaint.MetallicBistonBrown => Color.FromArgb(64, 46, 43),
            VehiclePaint.MetallicBeechwood => Color.FromArgb(164, 150, 95),
            VehiclePaint.MetallicDarkBeechwood => Color.FromArgb(70, 35, 26),
            VehiclePaint.MetallicChocoOrange => Color.FromArgb(117, 43, 25),
            VehiclePaint.MetallicBeachSand => Color.FromArgb(191, 174, 123),
            VehiclePaint.MetallicSunBleechedSand => Color.FromArgb(223, 213, 178),
            VehiclePaint.MetallicCream => Color.FromArgb(247, 237, 213),
            VehiclePaint.UtilBrown => Color.FromArgb(58, 42, 27),
            VehiclePaint.UtilMediumBrown => Color.FromArgb(120, 95, 51),
            VehiclePaint.UtilLightBrown => Color.FromArgb(181, 160, 121),
            VehiclePaint.MetallicWhite => Color.FromArgb(255, 255, 246),
            VehiclePaint.MetallicFrostWhite => Color.FromArgb(234, 234, 234),
            VehiclePaint.WornHoneyBeige => Color.FromArgb(176, 171, 148),
            VehiclePaint.WornBrown => Color.FromArgb(69, 56, 49),
            VehiclePaint.WornDarkBrown => Color.FromArgb(42, 40, 43),
            VehiclePaint.Wornstrawbeige => Color.FromArgb(114, 108, 87),
            VehiclePaint.BrushedSteel => Color.FromArgb(106, 116, 124),
            VehiclePaint.BrushedBlacksteel => Color.FromArgb(53, 65, 88),
            VehiclePaint.BrushedAluminium => Color.FromArgb(155, 160, 168),
            VehiclePaint.Chrome => Color.FromArgb(88, 112, 161),
            VehiclePaint.WornOffWhite => Color.FromArgb(234, 230, 222),
            VehiclePaint.UtilOffWhite => Color.FromArgb(223, 221, 208),
            VehiclePaint.WornOrange => Color.FromArgb(242, 173, 46),
            VehiclePaint.WornLightOrange => Color.FromArgb(249, 164, 88),
            VehiclePaint.MetallicSecuricorGreen => Color.FromArgb(131, 197, 102),
            VehiclePaint.WornTaxiYellow => Color.FromArgb(241, 204, 64),
            VehiclePaint.policecarblue => Color.FromArgb(76, 195, 218),
            VehiclePaint.MatteGreen => Color.FromArgb(78, 100, 67),
            VehiclePaint.MatteBrown => Color.FromArgb(188, 172, 143),
            VehiclePaint.WornOrange2 => Color.FromArgb(248, 182, 88),
            VehiclePaint.MatteWhite => Color.FromArgb(252, 249, 241),
            VehiclePaint.WornWhite => Color.FromArgb(255, 255, 251),
            VehiclePaint.WornOliveArmyGreen => Color.FromArgb(129, 132, 76),
            VehiclePaint.PureWhite => Color.FromArgb(255, 255, 255),
            VehiclePaint.HotPink => Color.FromArgb(242, 31, 153),
            VehiclePaint.Salmonpink => Color.FromArgb(253, 214, 205),
            VehiclePaint.MetallicVermillionPink => Color.FromArgb(223, 88, 145),
            VehiclePaint.Orange => Color.FromArgb(246, 174, 32),
            VehiclePaint.Green => Color.FromArgb(176, 238, 110),
            VehiclePaint.Blue => Color.FromArgb(8, 233, 250),
            VehiclePaint.MettalicBlackBlue => Color.FromArgb(10, 12, 23),
            VehiclePaint.MetallicBlackPurple => Color.FromArgb(12, 13, 24),
            VehiclePaint.MetallicBlackRed => Color.FromArgb(14, 13, 20),
            VehiclePaint.huntergreen => Color.FromArgb(159, 158, 138),
            VehiclePaint.MetallicPurple => Color.FromArgb(98, 18, 118),
            VehiclePaint.MetaillicVDarkBlue => Color.FromArgb(11, 20, 33),
            VehiclePaint.MODSHOPBLACK1 => Color.FromArgb(17, 20, 26),
            VehiclePaint.MattePurple => Color.FromArgb(107, 31, 123),
            VehiclePaint.MatteDarkPurple => Color.FromArgb(30, 29, 34),
            VehiclePaint.MetallicLavaRed => Color.FromArgb(188, 25, 23),
            VehiclePaint.MatteForestGreen => Color.FromArgb(45, 54, 42),
            VehiclePaint.MatteOliveDrab => Color.FromArgb(105, 103, 72),
            VehiclePaint.MatteDesertBrown => Color.FromArgb(122, 108, 85),
            VehiclePaint.MatteDesertTan => Color.FromArgb(195, 180, 146),
            VehiclePaint.MatteFoilageGreen => Color.FromArgb(90, 99, 82),
            VehiclePaint.DEFAULTALLOYCOLOR => Color.FromArgb(129, 130, 127),
            VehiclePaint.EpsilonBlue => Color.FromArgb(175, 214, 228),
            VehiclePaint.PureGold => Color.FromArgb(122, 100, 64),
            VehiclePaint.BrushedGold => Color.FromArgb(127, 106, 72),
            _ => throw new ArgumentOutOfRangeException(nameof(vehiclePaint), vehiclePaint, $"Invalid {nameof(VehiclePaint)}"),
        };
    }
}
