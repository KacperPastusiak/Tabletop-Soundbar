using Tabletop_Soundbar.Services;

namespace Tabletop_Soundbar
{
    public partial class MainForm : Form
    {
        private AudioService service;

        public MainForm()
        {
            InitializeComponent();
            service = new AudioService();
        }

        private void SetSongPathBtn_Click(object sender, EventArgs e)
        {
            service.SetSong(SongPathTextBox.Text);
            CurrentSongLbl.Text = $"Current song: {service.GetSongName()}";
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            service.Play();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            service.Pause();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                service.Pause();
                service.Dispose();
            }
            catch { } // nothing to do rn
        }
    }
}
