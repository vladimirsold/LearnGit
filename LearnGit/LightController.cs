using System;
using System.Collections.Generic;
using System.Text;

namespace LearnGit
{
    class LightController : ISwitchable
    {
        private readonly Light light;

        public LightController(Light light)
        {
            this.light = light;
        }
        public void Switch()
        {
            //oetuoheasun
            throw new NotImplementedException();
        }
    }
}
