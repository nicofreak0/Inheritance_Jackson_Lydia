﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Jackson_Lydia
{
    internal class FPS : Game
    {
        /// <summary>
        /// sets the titleparam and esrbparam names to the title and Esrb rating
        /// </summary>
        /// <param name="esrbParam"></param>
        /// <param name="titleParam"></param>
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam) 
        { 
            Title = titleParam;
            Esrb = esrbParam;
            
        }

        public override string Describe()
        {
            return $"{Title} is a FPS game rated {Esrb}.";
        }

    }
}
