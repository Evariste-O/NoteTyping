using NoteTyping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTyping.Services
{
    public static class StateManager
    {
        public static GameState GameState { get; set; }

        public static void Initialize() 
        {
            GameState = GameState.Menu;
        }
    }
}
