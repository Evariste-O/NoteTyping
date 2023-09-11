using Android.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NoteTyping.Classes;
using NoteTyping.Enums;
using NoteTyping.Services;

namespace NoteTyping
{
    public class NoteTyping : Game
    {
        public GraphicsDeviceManager Graphics;
        
        public GameMenu Menu;
        public TypingGame Game;

        Texture2D whiteRectangle;
        Texture2D BlackRectangle;

        public NoteTyping()
        {
            Graphics = new GraphicsDeviceManager(this);
            Graphics.IsFullScreen = true;
            Graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            Graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            Graphics.ApplyChanges();
            DrawService.Initialize(new SpriteBatch(GraphicsDevice), Graphics.PreferredBackBufferWidth, Graphics.PreferredBackBufferHeight);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                StateManager.GameState = GameState.TypingGame;

            switch (StateManager.GameState) 
            {
                case GameState.Menu:
                    { Menu.Update(); }
                    break;
                case GameState.TypingGame:
                    { Game.Update(); }
                    break;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            DrawService.Begin();

            switch (StateManager.GameState)
            {
                case GameState.Menu:
                    { Menu.Draw(); }
                    break;
                case GameState.TypingGame:
                    { Game.Draw(); }
                    break;
            }

            DrawService.End();
            base.Draw(gameTime);
        }
    }
}