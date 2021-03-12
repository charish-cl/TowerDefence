using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Constant helper variables 经常使用的变量，重要的可修改的数据
    /// </summary>
    public static class Constants
    {
        public static readonly Color RedColor = new Color(1f, 0f, 0f, 0f);
        public static readonly Color BlackColor = new Color(0f, 0f, 0f, 0f);
        //兔子花费
        public static readonly int BunnyCost = 50;
        //萝卜价值
        public static readonly int CarrotAward = 10;
        //初始敌人血量
        public static readonly int InitialEnemyHealth = 50;
        //箭的伤害
        public static readonly int ArrowDamage = 50;
        //箭的射程
        public static readonly float MinDistanceForBunnyToShoot = 3f;
        
    }
}
