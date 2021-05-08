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
        /// get heading toward a position
        /// </summary>
        /// <param name="from"></param>
        /// <param name="otherVector">the <see cref="Vector3"/> to face to</param>
        /// <returns>the heading toward a position</returns>
        /// <remarks>
        /// Source: <a href="http://answers.unity.com/answers/697834/view.html"></a>
        /// </remarks>
        public static float GetHeadingTowardsVector(this Vector3 from, Vector3 otherVector)
        {
            var direction = from - otherVector;
            return MathHelper.ConvertDirectionToHeading(direction.ToNormalized());
        }

        /// <summary>
        /// get heading towards an entity
        /// </summary>
        /// <param name="from"></param>
        /// <param name="entity">the <see cref="Entity"/> to face to</param>
        /// <returns>the heading towards the given <paramref name="entity"/></returns>
        public static float GetHeadingTowardsEntity(this Vector3 from, Entity entity) => GetHeadingTowardsVector(from, entity.Position);

        /// <summary>
        /// Determine whether the given <paramref name="position"/> is occupied 
        /// </summary>
        /// <param name="position">The position to checks</param>
        /// <param name="range">The range</param>
        /// <returns><c>true</c> if there is any <see cref="Entity"/> in this <paramref name="position"/></returns>
        public static bool IsOccupied(this Vector3 position, float range) => IsOccupied(position, range, true, true, null);

        /// <summary>
        /// Determine whether the given <paramref name="position"/> is occupied
        /// </summary>
        /// <param name="position">The position to checks</param>
        /// <param name="range">The range</param>
        /// <param name="checkVehicles">Check for any <see cref="Vehicle"/> in that area.</param>
        /// <param name="checkPeds">Check for any <see cref="Ped"/> in that area.</param>
        /// <param name="ignoredEntity">This <see cref="Entity"/> will be ignored if it's in the area. Set to <c>null</c> if you don't want to exclude any <see cref="Entity"/>.</param>
        /// <returns><c>true</c> if there is anything in that location matching the provided parameters.</returns>
        public static bool IsOccupied(this Vector3 position, float range, bool checkVehicles, bool checkPeds, Entity ignoredEntity)
        {
            return NativeWrappers.IsPositionOccupied(position, range, false, checkVehicles, checkPeds, false, false, ignoredEntity, false);
        }

        /// <summary>
        /// Determine whether this <paramref name="position"/> is on screen, or visible by a rendering <see cref="Camera"/>
        /// </summary>
        /// <param name="position"></param>
        /// <returns><c>true</c> if this <paramref name="position"/> is on screen, or visible by a rendering <see cref="Camera"/></returns>
        public static bool IsOnScreen(this Vector3 position)
        {
            return NativeWrappers.GetHudScreenPositionFromWorldPosition(position, out float _, out float _);
        }
    }
}
