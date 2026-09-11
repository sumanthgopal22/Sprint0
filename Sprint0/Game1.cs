using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D linkAtlas;
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
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        //Pull in assets
        //Loads things in advance
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            linkAtlas = Content.Load<Texture2D>("Link/LinkAtlas");

            link = new Link(new Vector2(400,300), linkAtlas);

            keyboardAndMouseController = new KeyboardAndMouseController();


        }

        //Check current state of game, update player (Movement)
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Vector2 movementDirection = keyboardAndMouseController.GetMovementDirection();
            link.Move(movementDirection);

            base.Update(gameTime);
        }

        //Publishing to the graphics card based on update
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Draws link into the SpriteBatch within begin/end block

            link.Draw(spriteBatch, gameTime);


            base.Draw(gameTime);
        }
    }
}
