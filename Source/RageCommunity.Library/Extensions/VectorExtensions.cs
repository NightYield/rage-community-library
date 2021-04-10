using Rage;
using RageCommunity.Library.Pathfinding;
using RageCommunity.Library.Wrappers;

namespace RageCommunity.Library.Extensions
{
    public static class VectorExtensions
    {
        public static VehicleNode GetClosestVehicleNode(this Vector3 position)
        {
            bool nodePropertiesAreValid = NativeWrappers.GetVehicleNodeProperties(position, out uint density, out int flags);
            bool nodeIsValid = NativeWrappers.GetClosestVehicleNodeWithHeading(position, out Vector3 nodePosition, out float nodeHeading);
            bool roadSidePoint = NativeWrappers.GetRoadsidePointWithHeading(nodePosition, nodeHeading, out Vector3 roadSidePosition);

            return new VehicleNode(nodePosition, nodeHeading, density, flags, roadSidePosition);
        }

        public static Vector3 HeightToGround(this Vector3 position)
        {
            var groundValue = World.GetGroundZ(position, false, false);
            if (groundValue.HasValue)
            {
                return new Vector3(position.X, position.Y, groundValue.Value);
            }

            return position;
        }
    }
}
