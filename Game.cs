using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Jackson_Lydia
{

    /// <summary>
    /// creates an abstract class and puts get and set to title and Esrb and Title
    /// </summary>
    abstract class Game
    {

        public string Esrb { get; set; }

        public string Title { get; set; }

        // creates a public string for esrbParam and titleParam
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }


        /// <summary>
        /// prints the title and says it is starting
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting.");
        }

        public abstract string Describe();

    }
}
