using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocketLeagueMutatorUtility.Properties;

namespace RocketLeagueMutatorUtility.Logic
{
    public class AppSettings
    {
        Settings settings;
        public AppSettings()
        {
            settings = Properties.Settings.Default;
        }

        public string FileLocation
        {
            get
            {
                return settings.RLExeLocation;
            }
            set
            {
                settings.RLExeLocation = value;
                settings.Save();
            }
        }
        public int Map
        {
            get
            {
                return settings.Map;
            }
            set
            {
                settings.Map = value;
                settings.Save();
            }
        }
        public int Game
        {
            get
            {
                return settings.Game;
            }
            set
            {
                settings.Game = value;
                settings.Save();
            }
        }
        public int GameMode
        {
            get
            {
                return settings.GameMode;
            }
            set
            {
                settings.GameMode = value;
                settings.Save();
            }
        }
        public int Difficulty
        {
            get
            {
                return settings.Difficulty;
            }
            set
            {
                settings.Difficulty = value;
                settings.Save();
            }
        }
        public bool Debug
        {
            get
            {
                return settings.Debug;
            }
            set
            {
                settings.Debug = value;
                settings.Save();
            }
        }
        public bool Log
        {
            get
            {
                return settings.Log;
            }
            set
            {
                settings.Log = value;
                settings.Save();
            }
        }
        public int NumberBots
        {
            get
            {
                return settings.NumberBots;
            }
            set
            {
                settings.NumberBots = value;
                settings.Save();
            }
        }
        public decimal BotDifficulty
        {
            get
            {
                return settings.BotDifficulty;
            }
            set
            {
                settings.BotDifficulty = value;
                settings.Save();
            }
        }
        public int Mutator
        {
            get
            {
                return settings.Mutator;
            }
            set
            {
                settings.Mutator = value;
                settings.Save();
            }
        }
        public bool DebugMutator
        {
            get
            {
                return settings.DebugMutator;
            }
            set
            {
                settings.DebugMutator = value;
                settings.Save();
            }
        }
    }
}
