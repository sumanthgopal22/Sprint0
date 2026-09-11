using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint0
{
    public class SpriteAnimation : ISprite
    {

        private Rectangle linkForward1;
        private Rectangle linkForward2;
        private Rectangle linkBack1;
        private Rectangle linkBack2;
        private Rectangle linkSide1;
        private Rectangle linkSide2;
        private double timer;
        private int currentFrame;
        private double frameDuration = 0.2;
        private Rectangle lastFrame = new Rectangle(69, 11, 16, 16);
        private SpriteEffects lastFrameFlip = SpriteEffects.None;

        //Initializes the SpriteAnimation class
        public SpriteAnimation()
        {
            linkBack1 = new Rectangle(1, 11, 16,16);
            linkBack2 = new Rectangle(18, 11, 16, 16);
            linkSide1 = new Rectangle(35, 11, 16, 16);
            linkSide2 = new Rectangle(52, 11, 16, 16);
            linkForward1 = new Rectangle(69, 11, 16, 16);
            linkForward2 = new Rectangle(86, 11, 16, 16);

        }

        //Cacluates the currentFrame Link should be in using the game time
        public void Update(GameTime gameTime)
        {
            // Calculates the currentFrame using the game time
            timer = timer + gameTime.ElapsedGameTime.TotalSeconds;
            if (timer >= frameDuration)
            {
                timer = 0;
                currentFrame = (currentFrame + 1) % 2;
            }
        }

        //Decides what frame to draw based on keyboard or mouse input
        public void Draw(SpriteBatch spriteBatch, Texture2D textureAtlas, Vector2 linkPosition)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            MouseState mouseState = Mouse.GetState();

            Rectangle source;
            SpriteEffects flip = SpriteEffects.None;

            if (keyboardState.IsKeyDown(Keys.W) || mouseState.ScrollWheelValue > 1)
            {
                if (currentFrame == 0)
                {
                    source = linkForward1;
                }
                else
                {
                    source = linkForward2;
                }

                lastFrame = linkForward1;
                lastFrameFlip = SpriteEffects.None;
            }

            else if (keyboardState.IsKeyDown(Keys.S) || mouseState.ScrollWheelValue < -1)
            {
                if (currentFrame == 0)
                {
                    source = linkBack1;
                }
                else
                {
                    source = linkBack2;
                }

                lastFrame = linkBack1;
                lastFrameFlip = SpriteEffects.None;
            }

            else if (keyboardState.IsKeyDown(Keys.A) || mouseState.LeftButton == ButtonState.Pressed) //Left side
            {
                if (currentFrame == 0)
                {
                    source = linkSide1;
                }
                else
                {
                    source = linkSide2;
                }

                flip = SpriteEffects.FlipHorizontally;
                lastFrame = linkSide1;
                lastFrameFlip = SpriteEffects.FlipHorizontally;
            }
            else if (keyboardState.IsKeyDown(Keys.D) || mouseState.RightButton == ButtonState.Pressed) //Right side
            {
                if (currentFrame == 0)
                {
                    source = linkSide1;
                }
                else
                {
                    source = linkSide2;
                }

                flip = SpriteEffects.None;
                lastFrame = linkSide1;
                lastFrameFlip = SpriteEffects.None;
            }
            else
            {
                source = lastFrame;
                flip = lastFrameFlip;
            }
            
            spriteBatch.Begin();
            spriteBatch.Draw(textureAtlas, linkPosition, source, Color.White, 0f, Vector2.Zero, 1f, flip, 0f);
            spriteBatch.End();
        }
    }


}
