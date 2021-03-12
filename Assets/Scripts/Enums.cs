using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    //兔子的状态机
    public enum BunnyState
    {
        Inactive,
        Searching,
        Targeting
    }
    //游戏的状态机
    public enum GameState
    {
        Start,
        Playing,
        Won,
        Lost
    }
}
