using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaporClient.Presenters;
using VaporClient.Models;

namespace VaporClient.Views
{
    public partial class MainForm : Form, IMainView
    {

        public MainForm()
        {
            InitializeComponent();

            PlayButton.MouseEnter += PlayButton_MouseEnter;
            PlayButton.MouseLeave += PlayButton_MouseLeave;
        }

        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            
        }

        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            PlayButton.Image = Properties.Resources.PLAY_light;
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.Image = Properties.Resources.PLAY;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PowerButton_Click(object sender, EventArgs e)
        {

        }

        private void RerollButton_Click(object sender, EventArgs e)
        {

        }

        private void SettingButton_Click(object sender, EventArgs e)
        {

        }

        public void SetPresenter(MainPresenter presenter)
        {

        }
        public void DisplayGames(GameCollectionModel games)
        {

        }
        public void ShowErrorMessage(string message)
        {

        }
    }
}
