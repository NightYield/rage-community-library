using System;
using System.Collections;
using Rage;

namespace RageCommunity.Library.Pathfinding
{
    public class VehicleNode
    {
        public VehicleNode(Vector3 position, float heading, uint density, int nodeFlagsNativeValue, Vector3 roadSidePosition)
        {
            Position = position;
            Density = density;
            Heading = heading;
            
            NodeFlagsNativeValue = nodeFlagsNativeValue;
            NodeFlags = (VehicleNodeFlags)NodeFlagsNativeValue;

            RoadSidePosition = roadSidePosition;
        }

        /// <summary>
        /// A value from 0 to 15, indicating how much traffic goes over this node.
        /// </summary>
        public UInt32 Density { get; set; }

        /// <summary>
        /// The properties of this node.
        /// </summary>
        public VehicleNodeFlags NodeFlags { get; set; }

        /// <summary>
        /// Heading of this node. Because a node belongs to a road, but not to a lane, this value may deviate by 180 degrees from the expected direction.
        /// </summary>
        public Single Heading { get; set; }

        /// <summary>
        /// An Int32 representing a bit array. The flags of this array represent the properties of this vehicle node.
        /// </summary>
        public Int32 NodeFlagsNativeValue { get; set; }

        /// <summary>
        /// Position of the this node.
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// The roadside position of the this node.
        /// </summary>
        public Vector3 RoadSidePosition { get; set; }

        /// <summary>
        /// Returns a boolean indicating if the node flag for the given index is true. 
        /// </summary>
        /// <param name="flagValue">A flag index like 0, 1, 2, 4, 8, 16, 32, 64 ...</param>
        public Boolean IsFlagIndexTrue(Int32 flagValue)
        {
            var bitArray = new BitArray(new[] { NodeFlagsNativeValue });
            if (flagValue < 2)
            {
                return bitArray[flagValue];
            }

            var flagIndexValue = Math.Log(flagValue) / Math.Log(2);
            var flagIndex = Convert.ToInt32(flagIndexValue);
            return bitArray[flagIndex];
        }
    }
}