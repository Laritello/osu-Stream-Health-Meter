using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsuStreamHealthMeter.Classes;

namespace OsuStreamHealthMeter.Classes
{
    public class ApplicationSettings
    {
        public int WindowWidth { get; set; }

        public int WindowHeight { get; set; }

        public int FrameRate { get; set; }

        public IList<Profile> Profiles { get; set; }

        public Profile SelectedProfile { get; set; }

        public ApplicationSettings()
        {
            WindowWidth = 600;
            WindowHeight = 600;
            FrameRate = 30;
            Profiles = new List<Profile>();
        }
    }
}
