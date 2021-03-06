﻿using System.Collections.Generic;

namespace SnakeDefender.GameEngine.GameObject
{
    public class Snake
    {
        #region Public Property
        /*
         * Review GY: не рекомендую віддавати властивість Body назовні, краще зробити методи на отримання координат певної частинки змійки та на її прирощення.
         * В даному випадку, це є порушення принципу інкапсуляції.
         */
        public List<Point> Body { get; set; }
        #endregion

        #region Constructors

        public Snake()
        {
            // Init snake's body
            this.Body = new List<Point>();
            /*
             * Review GY: довжина змійки має бути константою або зчитуватись з конфігураційного файлу.
             */
            for (var i = 0; i < 5; i++)
            {
                this.Body.Add(new Point(5, i + 1));
            }
        }
      
        #endregion
    }
}
