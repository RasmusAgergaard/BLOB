using Microsoft.Xna.Framework;

namespace Blob.BL
{
    public class Blob
    {
        public lifeStage Stage { get; set; }
        public jobTypes Job { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int MovementSpeed { get; set; }
        public Vector2 Position { get; set; }
    }
}
