using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    internal interface ISprite
    {
        public void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch, Texture2D textureAtlas, Vector2 linkPosition);
    }
}
