using System;
using Rage;
using RageCommunity.Library.Pathfinding;
using RageCommunity.Library.Wrappers;
using RageCommunity.Library.Zone;

namespace RageCommunity.Library.Extensions
{
    public static class VectorExtensions
    {
        /// <summary>
        /// Gets the vehicle node closest to this position and creates a new VehicleNode object.
        /// </summary>
        public static VehicleNode GetClosestVehicleNode(this Vector3 position)
        {
            bool nodePropertiesAreValid = NativeWrappers.GetVehicleNodeProperties(position, out uint density, out int flags);
            bool nodeIsValid = NativeWrappers.GetClosestVehicleNodeWithHeading(position, out Vector3 nodePosition, out float nodeHeading);
            bool roadSidePoint = NativeWrappers.GetRoadsidePointWithHeading(nodePosition, nodeHeading, out Vector3 roadSidePosition);

            return new VehicleNode(nodePosition, nodeHeading, density, flags, roadSidePosition);
        }

        /// <summary>
        /// Gets the height to the ground from this position.
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
        /// Gets the fullname for the zone on this position.
        /// </summary>
        public static String GetZoneName(this Vector3 position)
        {
            var shortName = NativeWrappers.GetNameOfZone(position);
            Game.LogTrivial(shortName); 
            return ZoneNameProvider.GetFullname(shortName);
        }

        /// <summary>
        /// Gets an offset position from this position in the given <paramref name="heading"/> direction by a given <paramref name="offset"/> amount.
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
        /// <summary>
        /// get a heading between two position
        /// </summary>
        /// <returns>return the heading</returns>
        /// <remarks>
        /// Source: <a href="http://answers.unity.com/answers/697834/view.html"></a>
        /// </remarks>
        public static float GetHeadingBetweenTwoVector(this Vector3 from, Vector3 to)
        {
            var direction = from - to;
            return MathHelper.ConvertDirectionToHeading(direction.ToNormalized());
        }
    }
}
