using System;
using System.Collections.Generic;
using System.Text;

namespace LearnGit
{
    class Light : ISwitchable
    {
        private bool state;
        public void Switch()
        {
            state = !state;
        }
    }
}