using NoteTyping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping
{
    public class KeyPressedEvenArgs : EventArgs
    {
        public KeyValue keyValue { get; set;  }
    }
}
