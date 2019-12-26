using System;
using System.Windows.Forms;

using OsuStreamHealthMeter.Utility;
using OsuStreamHealthMeter.Classes;
using System.Collections.Generic;

namespace OsuStreamHealthMeter.Forms
{
    public partial class FormSettings : Form
    {
        public ApplicationSettings Settings { get; set; }
        
        public FormSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            Settings = AppDataManager.LoadSettings();
            nudWindowWidth.Value = Settings.WindowWidth;
            nudWindowHeight.Value = Settings.WindowHeight;
            nudFrameRate.Value = Settings.FrameRate;

            UpdateUI();
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            Settings.WindowWidth = (int)nudWindowWidth.Value;
            Settings.WindowHeight = (int)nudWindowHeight.Value;
            Settings.FrameRate = (int)nudFrameRate.Value;
            Settings.SelectedProfile = (Profile)cbProfiles.SelectedItem;
            Settings.SelectedProfile.Load();

            AppDataManager.SaveSettings(Settings);

            DialogResult = DialogResult.OK;
        }

        private void AddProfile(object sender, EventArgs e)
        {
            Profile newProfile = new Profile
            {
                Name = "New Profile",
                Created = DateTime.UtcNow,
                Levels = new List<Level>
                {
                    new Level(){ Name = "Level 1", Minimum = 0, Maximum = 100, ImagePath = "" }
                }
            };

            Settings.Profiles.Add(newProfile);

            UpdateUI();


            cbProfiles.SelectedItem = newProfile;
        }

        private void SaveProfile(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedItem == null)
                return;

            Profile _selectedProfile = (Profile)cbProfiles.SelectedItem;
            _selectedProfile.Name = tbProfileName.Text;

            UpdateUI();
            cbProfiles.SelectedItem = _selectedProfile;
        }

        private void cbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile _selectedProfile = (Profile)cbProfiles.SelectedItem;

            if (_selectedProfile != null)
                tbProfileName.Text = _selectedProfile.Name;
            else
                tbProfileName.Text = string.Empty;

            if (_selectedProfile != null)
                dgwProfileLevels.DataSource = _selectedProfile.Levels;
        }

        private void UpdateUI()
        {
            cbProfiles.DataSource = null;
            cbProfiles.DataSource = Settings.Profiles;
            cbProfiles.DisplayMember = "Name";
        }

        private void btAddLevel_Click(object sender, EventArgs e)
        {
            if (cbProfiles.SelectedItem == null)
                return;

            Profile _selectedProfile = (Profile)cbProfiles.SelectedItem;
            _selectedProfile.Levels.Add(new Level { Name = "New Level" });

            UpdateUI();
            cbProfiles.SelectedItem = _selectedProfile;

            if (_selectedProfile != null)
            {
                dgwProfileLevels.DataSource = null;
                dgwProfileLevels.DataSource = _selectedProfile.Levels;
            }
                
        }
    }
}
