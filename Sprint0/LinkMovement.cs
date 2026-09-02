using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Net.Mime;

namespace Sprint0
{
    public class LinkMovement : IPlayer
    {
        public bool MoveUp()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool MoveDown()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MoveLeft()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool MoveRight()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
