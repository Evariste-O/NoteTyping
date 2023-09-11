using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using NoteTyping.Enums;
using NoteTyping.Services;
using System;

namespace NoteTyping.Classes
{
    public class Piano
    {
        public Key[] Keys { get; set; }
        public Texture2D BlackKeyTexture { get; set; }
        public Texture2D WhiteKeyTexture { get; set; }

        public event KeyPressedHandler KeyPressed;

        public Piano()
        {
            Keys = new Key[12];
            Keys[0] = new Key(0, KeyValue.cis);
            Keys[1] = new Key(1, KeyValue.dis);
            Keys[2] = new Key(2, KeyValue.fis);
            Keys[3] = new Key(3, KeyValue.gis);
            Keys[4] = new Key(4, KeyValue.ais);
            Keys[5] = new Key(5, KeyValue.c);
            Keys[6] = new Key(6, KeyValue.d);
            Keys[7] = new Key(7, KeyValue.e);
            Keys[8] = new Key(8, KeyValue.f);
            Keys[9] = new Key(9, KeyValue.g);
            Keys[10] = new Key(10, KeyValue.a);
            Keys[11] = new Key(11, KeyValue.h);

        }


        public void Update() 
        {
            var touchState = TouchPanel.GetState();
            foreach (var touch in touchState)
            {
                if (touch.State == TouchLocationState.Pressed)
                {
                    var x = touch.Position.X;
                    var y = touch.Position.Y;
                    foreach (Key key in Keys)
                    {
                        if (key.KeyArea.Contains(x, y))
                        {
                            KeyPressed?.Invoke(this, new KeyPressedEvenArgs { keyValue = key.KeyValue });
                            break;
                        }
                    }
                }
            }
        }

        public void Draw()
        {

            int whiteKeyCounter = 0;

            int keyX;
            int keyY = DrawService.ScreenHeight / 3 * 2;

            int whiteKeyWidth = DrawService.ScreenWidth / 7;
            int whiteKeyHeight = DrawService.ScreenHeight / 3;

            int blackKeyWidth = whiteKeyWidth / 2;
            int blackKeyHeight = whiteKeyHeight / 3 * 2;

            for (int i = 5; i < 12; i++)
            {
                keyX = whiteKeyWidth * whiteKeyCounter;
                Keys[i].Draw(WhiteKeyTexture, new Rectangle(keyX, keyY, whiteKeyWidth, whiteKeyHeight));
                whiteKeyCounter++;
            }

            keyX = whiteKeyWidth - blackKeyWidth / 2;

            for (int i = 0; i < 5; i++)
            {
                Keys[i].Draw(BlackKeyTexture, new Rectangle(keyX, keyY, blackKeyWidth, blackKeyHeight));
                keyX += i == 1 ? whiteKeyWidth * 2 : whiteKeyWidth;
            }
        }
    }
}
