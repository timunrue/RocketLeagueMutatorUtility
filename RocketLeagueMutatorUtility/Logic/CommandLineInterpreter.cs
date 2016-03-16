using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLeagueMutatorUtility.Logic
{
    public class CommandLineInterpreter
    {
        public static string[] Mutators{
            get{
                return new string[]{
                    "None",
                    "3Rounds",
                    "5Rounds",
                    "7Rounds",
                    "Max1",
                    "Max3",
                    "Max5",
                    "NoBooster",
                    "UnlimitedBooster",
                    "SlowRecharge",
                    "RapidRecharge",
                    "BoosterSap",
                    "ExplodeOnTouch",
                    "ExplodeIfFull",
                    "ExplodeIfEmpty",
                    "ExplodeDrain",
                    "ExplodeOpposing",
                    "ExplodeWinning",
                    "Launchpad",
                    "Teleporter",
                    "BoostMultiplier1_5x",
                    "BoostMultiplier2x",
                    "BoostMultiplier10x",
                    "10Minutes",
                    "20Minutes",
                    "UnlimitedTime",
                    "NoDemolish",
                    "DemolishAll",
                    "AlwaysDemolish",
                    "AlwaysDemolishOpposing",
                    "SuperBounciness",
                    "HighBounciness",
                    "LowBounciness",
                    "SmallBall",
                    "BigBall",
                    "GiantBall",
                    "TwoBalls",
                    "FourBalls",
                    "SixBalls",
                    "Ball_CubeBall",
                    "Ball_ClassicStadium_Tech",
                    "Ball_RubberBouncyBall",
                    "Ball_Puck",
                    "SloMoGameSpeed",
                    "SlomoDistanceBall",
                    "SlomoSpeedBall",
                    "Hardcore",
                    "TwoSecondsRespawn",
                    "OneSecondsRespawn",
                    "DoubleJump2x",
                    "DodgeImpulse2x",
                    "InverseGravity",
                    "AlmostZeroGravity",
                    "LowGravity",
                    "HighGravity",
                    "SuperGravity",
                    "BeginnerMode",
                    "IceConditions",
                    "RainConditions",
                    "LightBall",
                    "HeavyBall",
                    "SuperLightBall",
                    "SlowBall",
                    "FastBall",
                    "SuperFastBall",
                    "LowGravityBall",
                    "HighGravityBall",
                    "BallDemolish",
                    "OnlyBallDemolish",
                    "DodgeImpulse4x",
                    "SloMoDistanceBallLowCD",
                    "AutoBalance",
                    "MonsterTruck",
                    "MicroMachine",
                    "SacredGround",
                    "GoalTending",
                    "TurnBased",
                    "RedGreenBall",
                    "PitchBasketball",
                    "Mode500",
                    "TreasureHunt"

                };
            }
        }
        public static string InterpretSettings(AppSettings settings)
        {
            string command = "";
            if(settings.Log)
            {
                command += "-log ";
            }
            if(settings.Debug)
            {
                command += "-autodebug ";
            }

            command += InterpretMap(settings.Map);
            command += InterpretGame(settings.Game);
            command += InterpretMutator(settings);
            command += InterpretGameMode(settings);
            command += InterpretBots(settings);

            return command;
        }
        private static string InterpretMutator(AppSettings settings)
        {
            int mutator = settings.Mutator;
            if(mutator <= 0)
            {
                return "";
            }

            string command = "GameTags=" + Mutators[mutator] + "?";
            if(settings.DebugMutator)
            {
                command += "Debug?";
            }
            return command;
        }
        private static string InterpretGameMode(AppSettings settings)
        {
            var modes = new string[]
            {
                "Aerial",
                "FreePlay",
                "Goalie",
                "None",
                "Striker"
            };
            if(settings.GameMode >= 0 && settings.GameMode <= modes.Length)
            {
                if(settings.GameMode == 3)
                { return ""; }

                var modeString = modes[settings.GameMode] + "?";
                if(settings.GameMode == 1)
                { return modeString; }
                else
                {
                    var difficulties = new string[]
                    {
                        "Hard",
                        "Medium",
                        "Easy"

                    };
                    return modeString + difficulties[settings.Difficulty] + "?";
                }
            }
            return "";
        }
        private static string InterpretBots(AppSettings settings)
        {
            string command = "";
            if(settings.NumberBots <= 0 || settings.NumberBots > 99)
            {
                return command;
            }

            command = "NumBots=" + settings.NumberBots.ToString() + "?";
            if(settings.BotDifficulty <= 0.00M)
            { command += "BotSkill=0.00?"; }
            else if(settings.BotDifficulty >= 10.00M)
            { command += "BotSkill=9.99?"; }
            else
            { command += "BotSkill=" + settings.BotDifficulty.ToString() + "?"; }
            return command;
        }
        private static string InterpretGame(int game)
        {
            var games = new string[]
            {
                "TAGame.GameInfo_Soccar_TA",
                "TAGame.GameInfo_Tutorial_TA"
            };
            if (game >= 0 && game <= games.Length)
            {
                return "Game=" + games[game] + "?";
            }
            return "";
        }
        private static string InterpretMap(int map)
        {
            var maps = new string[]
            {
                "Park_P",
                "Park_Night_P",
                "Park_Rainy_P",
                "Stadium_P",
                "Stadium_Winter_P",
                "Labs_DoubleGoal_P",
                "EuroStadium_P",
                "EuroStadium_Rainy_P",
                "TutorialTest",
                "Labs_Underpass_P",
                "TrainStation_P",
                "TrainStation_Night_P",
                "UtopiaStadium_P",
                "UtopiaStadium_Dusk_P",
                "Labs_Utopia_P",
                "Wasteland_P",
                "Wasteland_Art_P"
            };
            if(map >= 0 && map <= maps.Length)
            {
                return "DEFAULTMAP=" + maps[map] + "?";
            }
            return "";
        }
    }
}
