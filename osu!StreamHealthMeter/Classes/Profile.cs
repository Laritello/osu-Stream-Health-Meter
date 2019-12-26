using System;
using System.Collections.Generic;

namespace OsuStreamHealthMeter.Classes
{
    public class Profile
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public IList<Level> Levels { get; set; }

        public Profile()
        {
            Levels = new List<Level>();
        }

        public void Load()
        {
            foreach (Level level in Levels)
                level.Load();
        }
    }
}
