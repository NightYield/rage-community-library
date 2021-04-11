using System;
using Rage;
using RageCommunity.Library.Pathfinding;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class VectorExtensions
    {
        /// <summary>
        /// Gets the vehicle node closest to a given position and creates a new VehicleNode object.
        /// </summary>
        public static VehicleNode GetClosestVehicleNode(this Vector3 position)
        {
            bool nodePropertiesAreValid = NativeWrappers.GetVehicleNodeProperties(position, out uint density, out int flags);
            bool nodeIsValid = NativeWrappers.GetClosestVehicleNodeWithHeading(position, out Vector3 nodePosition, out float nodeHeading);
            bool roadSidePoint = NativeWrappers.GetRoadsidePointWithHeading(nodePosition, nodeHeading, out Vector3 roadSidePosition);

            return new VehicleNode(nodePosition, nodeHeading, density, flags, roadSidePosition);
        }

        /// <summary>
        /// Gets the height to the ground from a given position.
        /// </summary>
        public static Vector3 HeightToGround(this Vector3 position)
        {
            var groundValue = World.GetGroundZ(position, false, false);
            if (groundValue.HasValue)
            {
                return new Vector3(position.X, position.Y, groundValue.Value);
            }

            return position;
        }

        /// <summary>
        /// Gets an offset position from the current position in the given heading direction by a given offset amount.
        /// </summary>
        /// <remarks>
        /// Written by alexguirre. 
        /// </remarks>
        public static Vector3 GetOffset(this Vector3 from, float heading, Vector3 offset)
        {
            float radians = MathHelper.ConvertDegreesToRadians(heading);

            float cos = (float)Math.Cos(radians);
            float sin = (float)Math.Sin(radians);

            float resultX = offset.X * cos - offset.Y * sin;
            float resultY = offset.X * sin + offset.Y * cos;

            return new Vector3(from.X + resultX, from.Y + resultY, from.Z + offset.Z);
        }
    }
}
