using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D linkAtlas;
        private SpriteFont spriteFont;
        private Vector2 fontPosition;
        private IPlayer link;
        private IController keyboardAndMouseController;

        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.IsFullScreen = false;
        }

        
        //Gets enviornment ready
        protected override void Initialize()
        {
            base.Initialize();

        }

        //Pull in assets
        //Loads things in advance
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            linkAtlas = Content.Load<Texture2D>("Link/LinkAtlas");
            spriteFont = Content.Load<SpriteFont>("MyMenuFont");
            Viewport viewPort = graphics.GraphicsDevice.Viewport;

            link = new Link(new Vector2(400,300), linkAtlas);
            fontPosition = new Vector2(400, 400);


            keyboardAndMouseController = new KeyboardAndMouseController();


        }

        //Check current state of game, update player (Movement)
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Vector2 movementDirection = keyboardAndMouseController.GetMovementDirection();
            link.Move(movementDirection);

            link.Update(gameTime);
            base.Update(gameTime);
        }

        //Publishing to the graphics card based on update
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            string output = "Credits \n Program Made By: Sumanth Gopal \n Sprites from: https://www.spriters-resource.com/nes/legendofzelda/asset/8366/";

            spriteBatch.Begin();

            //Draws link into the SpriteBatch
            link.Draw(spriteBatch);

            // Find the center of the string
            Vector2 FontOrigin = spriteFont.MeasureString(output) / 2;
            // Draw the string
            spriteBatch.DrawString(spriteFont, output, fontPosition, Color.Black,
                0, FontOrigin, 1.0f, SpriteEffects.None, 0.5f);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
