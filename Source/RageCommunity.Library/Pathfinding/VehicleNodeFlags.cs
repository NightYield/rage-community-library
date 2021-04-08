using System;

namespace RageCommunity.Library.Pathfinding
{
    [Flags]
    public enum VehicleNodeFlags
    {
        None = 0,
        /// <summary>
        /// Indicates whether this road node is disabled.
        /// </summary>
        IsDisabled = 1,
        UnknownBit2 = 2,
        /// <summary>
        /// Slow normal roads, for example in the Vinewood hills or in front of the airport building. 
        /// </summary>
        SlowNormalRoad = 4,
        /// <summary>
        /// Minor roads can be found in the desert, quarry, back alleys or in front of gas stations.
        /// </summary>
        MinorRoad = 8,
        /// <summary>
        /// Tunnels for cars or underground parking garages. Subway tunnels and short underpasses are excluded.
        /// </summary>
        TunnelOrUndergroundParking = 16,
        /// <summary>
        /// This flag can be observed on some parking lots and very small side roads in Los Santos, but the exact meaning is unknown. 
        /// </summary>
        UnknownBit32 = 32,
        /// <summary>
        /// Freeways with multiple lanes for one direction.
        /// </summary>
        Freeway = 64,
        /// <summary>
        /// Indicates a junction, regardless of the size or road type.
        /// </summary>
        Junction = 128,
        /// <summary>
        /// A normal stop node, for example on intersections.
        /// </summary>
        StopNode = 256,
        /// <summary>
        /// A stop node before T junction and with no traffic lights. 
        /// </summary>
        SpecialStopNode = 512
    }
}