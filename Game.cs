using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Hutton_Riley
{
    class Game
    {
        //Assigns the string variables
        public string title, genre;

        //Assigns the variables to the parameters
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }

    }
}
