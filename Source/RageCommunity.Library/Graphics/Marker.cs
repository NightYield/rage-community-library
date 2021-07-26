using Rage;
using RageCommunity.Library.Wrappers;
using System;
using System.Drawing;

namespace RageCommunity.Library.Graphics
{
    /// <summary>
    /// This class represents a 3D world marker within GTA V (for example, colored cylinders you walk into during missions).
    /// </summary>
    /// <remarks>
    /// Originally created by Rich. 
    /// </remarks>
    public class Marker : ISpatial
    {
        public MarkerType MarkerType { get; set; }
        /// <inheritdoc/>
        public Vector3 Position { get; set; }
        public Vector3 Direction { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }
        public Color MarkerColor { get; set; }
        public bool BobUpAndDown { get; set; }
        public bool FaceCamera { get; set; }
        public bool Rotate { get; set; }
        public bool DrawOnEntities { get; set; }

        public Marker(MarkerType markerType, 
                    Vector3 position, 
                    Vector3 direction,
                    Vector3 rotation,
                    Vector3 scale,
                    Color color,
                    bool bobUpAndDown, 
                    bool faceCamera, 
                    bool rotate, 
                    bool drawOnEntities)
        {
            MarkerType = markerType;
            Position = position;
            Direction = direction;
            Rotation = rotation;
            Scale = scale;
            MarkerColor = color;
            BobUpAndDown = bobUpAndDown;
            FaceCamera = faceCamera;
            Rotate = rotate;
            DrawOnEntities = drawOnEntities;
        }

        public void Draw()
        {
            NativeWrappers.DrawMarker(MarkerType, Position, Direction, Rotation, Scale, MarkerColor, BobUpAndDown, FaceCamera, Rotate, DrawOnEntities);
        }
        /// <inheritdoc/>
        public float DistanceTo(ISpatial target)
        {
            return Position.DistanceTo(target);
        }
        /// <inheritdoc/>
        public float DistanceTo(Vector3 target)
        {
            return Position.DistanceTo(target);
        }
        /// <inheritdoc/>
        public float DistanceTo2D(Vector3 target)
        {
            return Position.DistanceTo2D(target);
        }
        /// <inheritdoc/>
        public float DistanceTo2D(ISpatial target)
        {
            return Position.DistanceTo2D(target);
        }
        /// <inheritdoc/>
        public float TravelDistanceTo(Vector3 target)
        {
            return Position.TravelDistanceTo(target);
        }
        /// <inheritdoc/>
        public float TravelDistanceTo(ISpatial target)
        {
            return Position.TravelDistanceTo(target);
        }
    }
}
