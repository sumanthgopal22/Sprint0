using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class Link : IPlayer
    {
        private Texture2D textureAtlas;

        //get (public) means links position can be read anywhere,
        //while private set only allows for the code within the link class to change his position
        public Vector2 LinkPosition { get; private set; }

        public SpriteAnimation SpriteAnimation;

        public Link(Vector2 startPosition, Texture2D texture)
        {
            LinkPosition = startPosition;
            textureAtlas = texture;
            SpriteAnimation = new SpriteAnimation();

        }

        public void Move(Vector2 direction)
        {
            float moveAmount = 1f;

            LinkPosition = LinkPosition + (direction * moveAmount);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            SpriteAnimation.Draw(spriteBatch, textureAtlas, LinkPosition, gameTime);
        }
    }
}
