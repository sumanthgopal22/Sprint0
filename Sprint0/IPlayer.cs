using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    internal interface IPlayer
    {
        void Move(Vector2 direction);

        public void Update(GameTime gameTime);

        public void Draw(SpriteBatch spriteBatch);

    }
}
