using NoteTyping.AbstractClasses;
using NoteTyping.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping.Classes
{
    public class TypingGame : GameObject
    {
        public Piano Piano { get; set; }
        public NoteWindow window { get; set; }

        public override void Draw()
        {
            Piano.Draw();
        }

        public override void Update()
        {
            
        }
    }
}
