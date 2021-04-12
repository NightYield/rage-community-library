using Rage;
using RageCommunity.Library.Wrappers;
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
        public MarkerTypes MarkerType { get; set; }
        public Vector3 Position { get; set; }
        public Vector3 Direction { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }
        public Color MarkerColor { get; set; }
        public bool BobUpAndDown { get; set; }
        public bool FaceCamera { get; set; }
        public bool Rotate { get; set; }
        public string TextureDictionary { get; set; }
        public string TextureName { get; set; }
        public bool DrawOnEntities { get; set; }

        public Marker(MarkerTypes type, 
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
            MarkerType = type;
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

        public Marker(MarkerTypes type,
                    Vector3 position,
                    Vector3 direction,
                    Vector3 rotation,
                    Vector3 scale,
                    Color color,
                    bool bobUpAndDown,
                    bool faceCamera,
                    bool rotate,
                    string textureDictionary,
                    string textureName,
                    bool drawOnEntities)
        {
            MarkerType = type;
            Position = position;
            Direction = direction;
            Rotation = rotation;
            Scale = scale;
            MarkerColor = color;
            BobUpAndDown = bobUpAndDown;
            FaceCamera = faceCamera;
            Rotate = rotate;
            TextureDictionary = textureDictionary;
            TextureName = textureName;
            DrawOnEntities = drawOnEntities;
        }

        public void Draw()
        {
            if(!string.IsNullOrWhiteSpace(TextureName) && !string.IsNullOrWhiteSpace(TextureDictionary))
            {
                try
                {
                    NativeWrappers.DrawMarker(MarkerType, Position, Direction, Rotation, Scale, MarkerColor, BobUpAndDown, FaceCamera, Rotate, TextureDictionary, TextureName, DrawOnEntities);
                }
                catch (Exception ex)
                {
                    Game.LogTrivialDebug("Exception trying to draw marker: " + ex.Message);
                    Game.LogTrivialDebug(ex.StackTrace);
                }
            }
            else
            {
                NativeWrappers.DrawMarker(MarkerType, Position, Direction, Rotation, Scale, MarkerColor, BobUpAndDown, FaceCamera, Rotate, DrawOnEntities);
            }
        }

        public float DistanceTo(ISpatial target)
        {
            return Position.DistanceTo(target);
        }

        public float DistanceTo(Vector3 target)
        {
            return Position.DistanceTo(target);
        }

        public float DistanceTo2D(Vector3 target)
        {
            return Position.DistanceTo2D(target);
        }

        public float DistanceTo2D(ISpatial target)
        {
            return Position.DistanceTo2D(target);
        }

        public float TravelDistanceTo(Vector3 target)
        {
            return Position.TravelDistanceTo(target);
        }

        public float TravelDistanceTo(ISpatial target)
        {
            return Position.TravelDistanceTo(target);
        }
    }
}
