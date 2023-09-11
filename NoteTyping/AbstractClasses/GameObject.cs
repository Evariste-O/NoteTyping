using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping.AbstractClasses
{
    public abstract class GameObject
    {
        abstract public void Draw();
        abstract public void Update();
    }
}
