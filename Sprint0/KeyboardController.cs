using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;


namespace Sprint0
{
    public class KeyboardController : IController
    {
        public Vector2 GetMovementDirection()
        {
            Vector2 direction = Vector2.Zero;
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.W))
            {
                direction.Y -= 1;
            }
            else if (keyboardState.IsKeyDown(Keys.S))
            {
                direction.Y += 1;
            }
            else if (keyboardState.IsKeyDown(Keys.A))
            {
                direction.X -= 1;
            }
            else if (keyboardState.IsKeyDown(Keys.D))
            {
                direction.X += 1;
            }


            return direction;
        }


    }
    
    
}
