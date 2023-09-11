using Android.Views.ContentCaptures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using NoteTyping.AbstractClasses;
using NoteTyping.Classes;
using NoteTyping.Enums;
using NoteTyping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping
{
    public class Subscriber : GameObject
    {
        public ContentManager Content { get; private set; }
        public KeyValue KeyValue { get; set; }

        public Subscriber(ContentManager content) 
        {
            Content = content;
        }

        public void Subscribe(Piano piano) 
        {
            piano.KeyPressed += HandleKeyPress;
        }

        private void HandleKeyPress(object sender, KeyPressedEvenArgs e)
        {
            KeyValue = e.keyValue;
        }

        public override void Draw()
        {
            DrawService.DrawString(Content.Load<SpriteFont>("Font"), KeyValue.ToString(), new Vector2(100, 100), Color.Black);
        }

        public override void Update()
        {
            
        }
    }
}
