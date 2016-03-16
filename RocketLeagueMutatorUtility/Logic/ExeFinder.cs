using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RocketLeagueMutatorUtility.Logic
{
    public class ExeFinder
    {
        public static string FileLocation
        {
            get
            {
                return Properties.Settings.Default.RLExeLocation;
            }
            set
            {
                Properties.Settings.Default.RLExeLocation = value;
                Properties.Settings.Default.Save();
            }
        }
        public static void FindRocketLeagueExe()
        {
            string fileLocation = @":\Program Files (x86)\Steam\steamapps\common\rocketleague\Binaries\Win32\RocketLeague.exe";
            string otherFileLocation = @":\Program Files\Steam\steamapps\common\rocketleague\Binaries\Win32\RocketLeague.exe";
            char[] drives = new char[]
            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 
                'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            for(int i = 0; i < drives.Length; i++)
            {
                string testLocation = drives[i] + fileLocation;
                if(ExeFinder.ExeLocatedHere(testLocation))
                {
                    FileLocation = testLocation;
                    return;
                }

                testLocation = drives[i] + otherFileLocation;
                if(ExeFinder.ExeLocatedHere(testLocation))
                {
                    FileLocation = testLocation;
                    return;
                }
            }
            throw new FileNotFoundException("Could not find RocketLeague.exe");
        }
        public static bool ExeLocatedHere(string fileLocation)
        {
            const string fileName = "RocketLeague.exe";
            return File.Exists(fileLocation) && Path.GetFileName(fileLocation) == fileName;
        }
    }

}
