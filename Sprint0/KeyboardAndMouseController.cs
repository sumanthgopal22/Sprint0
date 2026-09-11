using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Sprint0
{
    public class KeyboardAndMouseController : IController
    {
        //Depending on what is pressed it returns a vector of what distance and direction is covered
        public Vector2 GetMovementDirection()
        {
            Vector2 direction = Vector2.Zero;
            KeyboardState keyboardState = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            if (keyboardState.IsKeyDown(Keys.W) || mouseState.ScrollWheelValue > 1)
            {
                direction.Y -= 1;
            }
            else if (keyboardState.IsKeyDown(Keys.S) || mouseState.ScrollWheelValue < -1)
            {
                direction.Y += 1;
            }
            else if (keyboardState.IsKeyDown(Keys.A) || mouseState.LeftButton == ButtonState.Pressed)
            {
                direction.X -= 1;
            }
            else if (keyboardState.IsKeyDown(Keys.D) || mouseState.RightButton == ButtonState.Pressed)
            {
                direction.X += 1;
            }


            return direction;
        }


    }
    
    
}
