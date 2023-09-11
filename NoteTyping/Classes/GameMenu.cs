using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using NoteTyping.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping.Classes
{
    public class GameMenu : GameObject
    {
        public List<Button> buttons {  get; set; }  

        public GameMenu(ContentManager content) 
        {
            buttons = new List<Button>
            {
                new Button(new Rectangle(100,200,100,50), content),
            };
        }

        public override void Draw()
        {
            foreach (var button in buttons) 
            {
                button.Draw();
            }
        }

        public override void Update()
        {
            foreach (var button in buttons)
            {
                button.Update();
            }
        }
    }
}
