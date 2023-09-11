using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NoteTyping.Enums;
using NoteTyping.Services;

namespace NoteTyping.Classes
{
    public class Key
    {
        public int Id { get; set; }
        public KeyValue KeyValue { get; set; }
        public Rectangle KeyArea { get; set; }
        public Color Mask { get; set; } = Color.White;

        public Key(int id, KeyValue value)
        {
            Id = id;
            KeyValue = value;
        }

        public void Draw(Texture2D keyTexture, Rectangle keyArea)
        {
            KeyArea = keyArea;
            DrawService.Draw(keyTexture, KeyArea, Mask);
        }
    }
}
