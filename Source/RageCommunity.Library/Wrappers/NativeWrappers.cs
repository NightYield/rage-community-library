using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageCommunity.Library.Wrappers
{
    class NativeWrappers
    {
        public static bool GetRoadsidePointWithHeading(Vector3 position, float heading, out Vector3 roadSidePosition)
        {
            bool getRoadSidePointWithHeading = Rage.Native.NativeFunction.Natives.xA0F8A7517A273C05<bool>(position, heading, out Vector3 roadSidePointWithHeading);
            roadSidePosition = roadSidePointWithHeading;
            return getRoadSidePointWithHeading;
        }
    }
}
