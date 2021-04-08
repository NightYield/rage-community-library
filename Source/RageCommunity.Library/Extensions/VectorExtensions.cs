using System;
using Rage;
using Rage.Native;
using RageCommunity.Library.Pathfinding;

namespace RageCommunity.Library.Extensions
{
    public static class VectorExtensions
    {
        public static VehicleNode GetClosestVehicleNode(this Vector3 position)
        {
            Boolean nodePropertiesAreValid = NativeFunction.Natives.GET_VEHICLE_NODE_PROPERTIES<Boolean>(position.X, position.Y, position.Z, out UInt32 density, out Int32 flags);
            Boolean nodeIsValid = NativeFunction.Natives.GetClosestVehicleNodeWithHeading<Boolean>(position.X, position.Y, position.Z, out Vector3 nodePosition, out Single outHeading, 1, 3, 0);
            return new VehicleNode(nodePosition, outHeading, density, flags);
        }
    }
}
