using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    internal interface ISprite
    {
        public void Draw(SpriteBatch spriteBatch, Texture2D textureAtlas, Vector2 linkPosition, GameTime gameTime);
    }
}
