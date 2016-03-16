using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RocketLeagueMutatorUtility.Logic;
using System.IO;
using System.Threading;
using System.Diagnostics;
using RocketLeagueMutatorUtility.Properties;

namespace RocketLeagueMutatorUtility
{
    public partial class MainForm : Form
    {
        AppSettings settings;
        Process rocketLeagueProcess;
        public MainForm()
        {
            InitializeComponent();
            settings = new AppSettings();
            AddComboBoxItems();
            LoadSettings();   
        }
        public void CheckRLRunning()
        {
            while(true)
            {
                var proc = Process.GetProcessesByName("RocketLeague");
                if(proc.Length > 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        buttonKill.Enabled = true;
                    });
                    this.Invoke((MethodInvoker)delegate
                    {
                        labelRLRunning.Text = "Rocket League Running";
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        buttonKill.Enabled = false;
                    });
                    this.Invoke((MethodInvoker)delegate
                    {
                        labelRLRunning.Text = "Rocket League Not Running";
                    });
                }
                Thread.Sleep(500);
            }
        }

        private void AddComboBoxItems()
        {
            var maps = new string[]
            {
                "Beckwith Park",
                "Beckwith Park (Midnight)",
                "Beckwith Park (Stormy)",
                "DFH Stadium",
                "DFH Stadium (Snowy)",
                "Double Goal (Rocket Labs)",
                "Mannfield",
                "Mannfield (Stormy)",
                "Tutorial",
                "Underpass (Rocket Labs)",
                "Urban Central",
                "Urban Central (Night)",
                "Utopia Coliseum",
                "Utopia Coliseum (Dusk)",
                "Utopia Retro (Rocket Labs)",
                "Wasteland",
                "Wasteland Art"
            };
            comboBoxMap.DataSource = maps;

            var games = new string[]
            {
                "TAGame.GameInfo_Soccar_TA",
                "TAGame.GameInfo_Tutorial_TA"
            };
            comboBoxGame.DataSource = games;

            var gameModes = new string[]
            {
                "Aerial",
                "FreePlay",
                "Goalie",
                "Bot Match",
                "Striker"
            };
            comboBoxGameMode.DataSource = gameModes;

            var difficulties = new string[]
            {
                "All-Star",
                "Pro",
                "Rookie"
            };
            comboBoxDifficulty.DataSource = difficulties;

            comboBoxMutator.DataSource = CommandLineInterpreter.Mutators;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabelRedditPost.Text = "Credit to reddit user whynotsteven for the writeup here";
            linkLabelRedditPost.Links.Add(51, 4, "https://www.reddit.com/r/RocketLeague/comments/4agemx/how_to_play_the_hidden_mutators_and_other_mods/");

            var checker = new Thread(new ThreadStart(CheckRLRunning));
            checker.IsBackground = true;
            checker.Start();
        }
        private void LoadSettings()
        {
            textBoxRLExeLocation.Text = ExeFinder.FileLocation;
            
            comboBoxDifficulty.SelectedIndex    = settings.Difficulty;
            comboBoxGame.SelectedIndex          = settings.Game;
            comboBoxGameMode.SelectedIndex      = settings.GameMode;
            comboBoxMap.SelectedIndex           = settings.Map;
            comboBoxMutator.SelectedIndex       = settings.Mutator;

            checkBoxDebuggerAllowed.Checked = settings.Debug;
            checkBoxLog.Checked   = settings.Log;
            checkBoxMutatorDebug.Checked = settings.DebugMutator;

            maskedTextBoxNumberBots.Text = settings.NumberBots.ToString();
            maskedTextBoxBotDifficulty.Text = settings.BotDifficulty.ToString();

        }
        private bool ValidRLLocation(string location)
        {
            return !String.IsNullOrWhiteSpace(location) && ExeFinder.ExeLocatedHere(location);
        }

        private void FindRLExe()
        {
            try
            {
                ExeFinder.FindRocketLeagueExe();
                textBoxRLExeLocation.Text = ExeFinder.FileLocation;
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Could not find RocketLeage.exe \nPlease manually locate the file.");
            }

        }

        private void buttonManuallyLocate_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileLocation = openFileDialog1.FileName;
            if(ValidRLLocation(fileLocation))
            {
                ExeFinder.FileLocation = fileLocation;
                textBoxRLExeLocation.Text = fileLocation;
            }
            else
            {
                MessageBox.Show("Invalid file. File must be named \"RocketLeague.exe\" ");
            }
        }

        private void buttonAutoLocate_Click(object sender, EventArgs e)
        {
            FindRLExe();
        }

        private void linkLabelRedditPost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            if(!ValidRLLocation(ExeFinder.FileLocation))
            {
                MessageBox.Show("Invalid RocketLeague.exe file location.");
                return;
            }
            var arguments = CommandLineInterpreter.InterpretSettings(settings);

            Process.Start("\"" + settings.FileLocation + "\"", arguments);
        }

        private void textBoxRLExeLocation_TextChanged(object sender, EventArgs e)
        {
            ExeFinder.FileLocation = textBoxRLExeLocation.Text;
        }

        private void comboBoxGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboBoxGameMode.SelectedIndex;
            if(selected == -1 || selected == 1 || selected == 3)
            {
                comboBoxDifficulty.Enabled = false;
            }
            else
            {
                comboBoxDifficulty.Enabled = true;
            }
        }

        private void checkBoxLog_CheckedChanged(object sender, EventArgs e)
        {
            settings.Log = checkBoxLog.Checked;
        }
        private void checkBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            settings.Debug = checkBoxDebuggerAllowed.Checked;
        }
        private void comboBoxMap_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.Map = comboBoxMap.SelectedIndex;
        }

        private void comboBoxGame_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.Game = comboBoxGame.SelectedIndex;
        }

        private void comboBoxDifficulty_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.Difficulty = comboBoxDifficulty.SelectedIndex;
        }

        private void comboBoxGameMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.GameMode = comboBoxGameMode.SelectedIndex;
        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("RocketLeague");
            if(proc.Length > 0)
            {
                try
                {
                    proc[0].Kill();
                }
                catch
                {
                    MessageBox.Show("Unable to end Rocket League process.");
                }
            }
        }

        private void maskedTextBoxNumberBots_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int numBots = Int32.Parse(maskedTextBoxNumberBots.Text);
                settings.NumberBots = numBots;
            }
            catch
            {
                settings.NumberBots = 0;
            }
        }

        private void maskedTextBoxBotDifficulty_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                decimal botDifficulty = Decimal.Parse(maskedTextBoxBotDifficulty.Text);
                settings.BotDifficulty = botDifficulty;
            }
            catch
            {
                settings.BotDifficulty = 0.00M;
            }
        }

        private void comboBoxMutator_SelectionChangeCommitted(object sender, EventArgs e)
        {
            settings.Mutator = comboBoxMutator.SelectedIndex;
        }

        private void checkBoxMutatorDebug_CheckedChanged(object sender, EventArgs e)
        {
            settings.DebugMutator = checkBoxMutatorDebug.Checked;
        }


    }
}
