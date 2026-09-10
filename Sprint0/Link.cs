using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Sprint0
{
    public class Link : IPlayer
    {
        private Texture2D LinkTexture;

        public Vector2 LinkPosition { get; private set; }
        public float Speed { get; set; } = 200f; // Pixels per second

        public Link(Vector2 startPosition, Texture2D texture)
        {
            LinkPosition = startPosition;
            LinkTexture = texture;

        }

        public void Move(Vector2 direction)
        {
            float moveAmount = 2f;

            LinkPosition = LinkPosition + (direction * moveAmount);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(LinkTexture, LinkPosition, Color.White);
        }
    }
}
