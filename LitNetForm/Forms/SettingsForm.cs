using LitNetForm.Settings;
using LitPulse.Bots;

namespace LitNetForm.Forms
{
    public partial class SettingsForm : Form
    {

        public Settings.Settings Settings = new Settings.Settings();

        public SettingsForm()
        {
            InitializeComponent();

            LoadSettings();
        }

        public SettingsForm(Settings.Settings settings)
        {
            InitializeComponent();

            Settings = settings;

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

            if (Settings.ReadProfileSettings.ContainsKey((Scroll_model.Profile)comboBoxReadProfiles.SelectedIndex))
            {
                ProfileSettings profileSettings = Settings.ReadProfileSettings[(Scroll_model.Profile)comboBoxReadProfiles.SelectedIndex];

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
            checkBoxReadBook.Checked = Settings.ReadBook;

            checkBoxAddToLibrary.Checked = Settings.AddToLibrary;

            checkBoxLikeTheBook.Checked = Settings.LikeTheBook;

            checkBoxSubscribeToTheAuthor.Checked = Settings.SubscribeToTheAuthor;

            checkBoxPostComment.Checked = Settings.PostComment;

            checkBoxMakeADonationToTheAuthor.Checked = Settings.MakeADonationToTheAuthor;

            checkBoxBuyABook.Checked = Settings.BuyABook;

            numericUpDownConstantDelay.Value = Settings.ConstantDelay;

            numericUpDownFloatingIncrementalDelay.Value = Settings.FloatingIncrementalDelay;

            comboBoxReadProfiles.SelectedIndex = (int)Settings.ReadProfile;
        }

        private void SaveSettings()
        {
            Settings.ReadBook = checkBoxReadBook.Checked;

            Settings.AddToLibrary = checkBoxAddToLibrary.Checked;

            Settings.LikeTheBook = checkBoxLikeTheBook.Checked;

            Settings.SubscribeToTheAuthor = checkBoxSubscribeToTheAuthor.Checked;

            Settings.PostComment = checkBoxPostComment.Checked;

            Settings.MakeADonationToTheAuthor = checkBoxMakeADonationToTheAuthor.Checked;

            Settings.BuyABook = checkBoxBuyABook.Checked;

            Settings.ConstantDelay = (int)numericUpDownConstantDelay.Value;

            Settings.FloatingIncrementalDelay = (int)numericUpDownFloatingIncrementalDelay.Value;

            // Сохранение настроек профилей
            for (int i = 0; i < comboBoxReadProfiles.Items.Count; i++)
            {
                Scroll_model.Profile readProfile = (Scroll_model.Profile)i;

                if (!Settings.ReadProfileSettings.ContainsKey(readProfile))
                {
                    // Ключа нет - добавляем новую пару
                    Settings.ReadProfileSettings.Add(readProfile, SettingsManager.CreateDefaultReadProfileSettings(readProfile));

                }

            }
        }

        private void ChangeProfileSettings()
        {
            ProfileSettings profileSettings = Settings.ReadProfileSettings[(Scroll_model.Profile)comboBoxReadProfiles.SelectedIndex];

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
