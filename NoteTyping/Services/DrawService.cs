
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NoteTyping.Services;

public static class DrawService
{
    public static SpriteBatch SpriteBatch { get; private set; }
    public static int ScreenWidth { get; private set; }
    public static int ScreenHeight { get; private set; }

    public static void Initialize(SpriteBatch spritebatch, int width, int height)
    {
        SpriteBatch = spritebatch;
        ScreenWidth = width; 
        ScreenHeight = height;
    }

    public static void Begin()
    {
        SpriteBatch.Begin();
    }

    public static void Draw(Texture2D sprite, Vector2 position, Color white, Rectangle? frameSize = null)
    {
        SpriteBatch.Draw(sprite, position, frameSize, white);
    }

    public static void Draw(Texture2D sprite, Rectangle rectangle, Color white)
    {
        SpriteBatch.Draw(sprite, rectangle, white);
    }

    public static void DrawBox(Rectangle box, Color color)
    {
        Texture2D _texture;
        _texture = new Texture2D(SpriteBatch.GraphicsDevice, 1, 1);
        _texture.SetData(new Color[] { color });
        SpriteBatch.Draw(_texture, box, Color.White * 0.8f);
    }
    
    public static void DrawString(SpriteFont font, string v, Vector2 position, Color black)
    {
        SpriteBatch.DrawString(font, v, position, black);
    }

    public static void DrawString(SpriteFont font, string v, Vector2 position, Color black, Vector2 scale)
    {
        SpriteBatch.DrawString(font, v, position, black, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
    }

    public static void End()
    {
        SpriteBatch.End();
    }
}
