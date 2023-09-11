using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using NoteTyping.AbstractClasses;
using NoteTyping.Enums;
using NoteTyping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping.Classes
{
    public class Button : GameObject
    {
        public ContentManager Content { get; private set; }
        public Rectangle ActionArea { get; set; }
        public Texture2D Texture { get; set; }

        private static readonly Random random = new Random();

        public Button(Rectangle rectangle, ContentManager content) 
        {
            ActionArea = rectangle;
            Content = content;
        }

        public event KeyPressedHandler ButtonPressed;

        public override void Draw()
        {
            DrawService.DrawBox(ActionArea, Color.Red);
        }

        public override void Update()
        {
            var touchState = TouchPanel.GetState();
            foreach (var touch in touchState)
            {
                if (touch.State == TouchLocationState.Pressed)
                {
                    var x = touch.Position.X;
                    var y = touch.Position.Y;
                    if (ActionArea.Contains(x,y)) 
                    {
                        //ButtonPressed?.Invoke(this, buttonPressedEvenArgs);
                    }
                }
            }
        }
    }
}
