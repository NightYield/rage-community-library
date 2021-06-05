using System;
using Rage;
using Rage.Native;

namespace RageCommunity.Library.Wrappers
{
    public static partial class NativeWrappers
    {
        /// <summary>
        /// Gets the roadside position of a given road node.
        /// </summary>
        public static bool GetRoadsidePointWithHeading(Vector3 position, float heading, out Vector3 roadSidePosition)
        {
            bool getRoadSidePointWithHeading = NativeFunction.Natives.xA0F8A7517A273C05<bool>(position, heading, out Vector3 roadSidePointWithHeading);
            roadSidePosition = roadSidePointWithHeading;
            return getRoadSidePointWithHeading;
        }

        /// <summary>
        /// Gets the vehicle node properties of a given road node.
        /// </summary>
        public static bool GetVehicleNodeProperties(Vector3 position, out uint density, out int flags)
        {
            bool getVehicleNodeProperties = NativeFunction.Natives.x0568566ACBB5DEDC<bool>(position, out uint outDensity, out int outFlags);
            density = outDensity;
            flags = outFlags;
            return getVehicleNodeProperties;
        }

        /// <summary>
        /// Gets the closest vehicle node with a heading.
        /// </summary>
        public static bool GetClosestVehicleNodeWithHeading(Vector3 position, out Vector3 nodePosition, out float nodeHeading)
        {
            bool getClosestPointOnRoadWithHeading = NativeFunction.Natives.xFF071FB798B803B0<bool>(position, out Vector3 closestNodePosition, out float closestNodeHeading, 1, 3f, 0f);
            nodePosition = closestNodePosition;
            nodeHeading = closestNodeHeading;
            return getClosestPointOnRoadWithHeading;
        }

        /// <summary>
        /// Gets the nth closest vehicle node with a heading.
        /// </summary>
        public static bool GetNthClosestVehicleNodeFavorDirection(Vector3 position, Vector3 desiredPosition, int nthClosest, out Vector3 nthClosestPointOnRoad, out float nthClosestPointHeading)
        {
            bool getNthClosestPoint = NativeFunction.Natives.x45905BE8654AE067<bool>(position, desiredPosition, nthClosest, out Vector3 outPosition, out float outHeading, 1, 3f, 0);
            nthClosestPointOnRoad = outPosition;
            nthClosestPointHeading = outHeading;
            return getNthClosestPoint;
        }
        public static bool GetSafeCoordForPed(Vector3 position, bool onGround, out Vector3 safeCoord, int flags)
        {
            bool success = NativeFunction.Natives.GET_SAFE_COORD_FOR_PED<bool>(position, onGround, out Vector3 outPosition, flags);
            safeCoord = outPosition;
            return success;
        }
    }
}
