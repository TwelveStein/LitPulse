using Core.Entities.ValueObjects;
using Core.Enums;
using Core.Settings;

namespace LitPulse.Forms
{
    public partial class SettingsForm : Form
    {

        public StartupSettings StartupSettings = new();

        public SettingsForm()
        {
            InitializeComponent();

            LoadSettings();
        }

        public SettingsForm(StartupSettings startupSettings)
        {
            InitializeComponent();

            StartupSettings = startupSettings;

            LoadSettings();
        }

        private string[] ProfileDescription = {
            "Минимум пауз, почти без возвратов. Подходит для ознакомительного чтения или поиска ключевых моментов. Как человек, который «пробегает глазами».",
            "Читает медленно, часто возвращается к предыдущим абзацам, делает длинные паузы. Имитирует внимательного, сосредоточенного читателя — как при изучении сложного текста.",
            "Начинает бодро, но постепенно замедляется, дольше думает, чаще «теряет концентрацию» (доп. паузы в середине и ближе к концу). Реалистично для вечернего чтения." };


        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxReadProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxProfile.Text = ProfileDescription[comboBoxReadProfiles.SelectedIndex];

            if (StartupSettings.ReadProfileSettings.ContainsKey((ReadProfile)comboBoxReadProfiles.SelectedIndex))
            {
                ProfileSettings profileSettings = StartupSettings.ReadProfileSettings[(ReadProfile)comboBoxReadProfiles.SelectedIndex];

                numericUpDownChanceOfRegression.Value = profileSettings.ChanceOfRegression;
                numericUpDownMinMaxPauseAfterScrolling.Value = profileSettings.MinMaxPauseAfterScrolling;
                numericUpDownMinMaxScrollDuration.Value = profileSettings.MinMaxScrollDuration;
                numericUpDownMinMaxScrollStep.Value = profileSettings.MinMaxScrollStep;
            }


        }
        private void numericUpDownProfileSetttings_Leave(object sender, EventArgs e)
        {
            ChangeProfileSettings();
        }

        private void LoadSettings()
        {
            checkBoxReadBook.Checked = StartupSettings.ReadBook.Enabled;

            checkBoxAddToLibrary.Checked = StartupSettings.AddToLibrary.Enabled;

            checkBoxLikeTheBook.Checked = StartupSettings.LikeTheBook.Enabled;

            checkBoxSubscribeToTheAuthor.Checked = StartupSettings.SubscribeToTheAuthor.Enabled;

            checkBoxPostComment.Checked = StartupSettings.PostComment;

            checkBoxMakeADonationToTheAuthor.Checked = StartupSettings.MakeADonationToTheAuthor;

            checkBoxBuyABook.Checked = StartupSettings.BuyABook;

            numericUpDownConstantDelay.Value = StartupSettings.ConstantDelay;

            numericUpDownFloatingIncrementalDelay.Value = StartupSettings.FloatingIncrementalDelay;

            comboBoxReadProfiles.SelectedIndex = (int)StartupSettings.ReadProfile;
        }

        private void SaveSettings()
        {
            StartupSettings.ReadBook = new SettingState(checkBoxReadBook.Checked, 1);

            StartupSettings.AddToLibrary = new SettingState(checkBoxAddToLibrary.Checked, 2);

            StartupSettings.LikeTheBook = new SettingState(checkBoxLikeTheBook.Checked, 3);

            StartupSettings.SubscribeToTheAuthor = new SettingState(checkBoxSubscribeToTheAuthor.Checked, 4);

            StartupSettings.PostComment = checkBoxPostComment.Checked;

            StartupSettings.MakeADonationToTheAuthor = checkBoxMakeADonationToTheAuthor.Checked;

            StartupSettings.BuyABook = checkBoxBuyABook.Checked;

            StartupSettings.ConstantDelay = (int)numericUpDownConstantDelay.Value;

            StartupSettings.FloatingIncrementalDelay = (int)numericUpDownFloatingIncrementalDelay.Value;

            // Сохранение настроек профилей
            for (int i = 0; i < comboBoxReadProfiles.Items.Count; i++)
            {
                ReadProfile readReadProfile = (ReadProfile)i;

                if (!StartupSettings.ReadProfileSettings.ContainsKey(readReadProfile))
                {
                    // Ключа нет - добавляем новую пару
                    StartupSettings.ReadProfileSettings.Add(readReadProfile, SettingsManager.CreateDefaultReadProfileSettings(readReadProfile));

                }

            }
        }

        private void ChangeProfileSettings()
        {
            ProfileSettings profileSettings = StartupSettings.ReadProfileSettings[(ReadProfile)comboBoxReadProfiles.SelectedIndex];

            profileSettings.ChanceOfRegression = Convert.ToUInt32(numericUpDownChanceOfRegression.Value);
            profileSettings.MinMaxPauseAfterScrolling = Convert.ToUInt32(numericUpDownMinMaxPauseAfterScrolling.Value);
            profileSettings.MinMaxScrollDuration = Convert.ToUInt32(numericUpDownMinMaxScrollDuration.Value);
            profileSettings.MinMaxScrollStep = Convert.ToUInt32(numericUpDownMinMaxScrollStep.Value);
        }

        private void checkBoxAddToLibrary_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
