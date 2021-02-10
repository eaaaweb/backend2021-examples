using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson02.Models
{
    public class Avatar
    {
        public int Lives { get; private set; }

        public void AddLives(int lives)
        {
            Lives += lives;
        }
    }

}
