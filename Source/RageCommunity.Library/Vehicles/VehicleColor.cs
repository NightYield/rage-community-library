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
    }
}
