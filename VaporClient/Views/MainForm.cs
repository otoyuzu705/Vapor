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
using VaporClient.Services;

namespace VaporClient.Views
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter _presenter;


        public MainForm()
        {
            InitializeComponent();
            InitializePresenter();

            PlayButton.MouseEnter += PlayButton_MouseEnter;
            PlayButton.MouseLeave += PlayButton_MouseLeave;
        }

        private void InitializePresenter()
        {
            var serverAddress = "";
            var gamePath = "";

            var gameService = new GameService(serverAddress, gamePath);
            new MainPresenter(this, gameService);
        }

        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGame = (GameModel)GameList.SelectedItems[0].Tag;
            if (selectedGame != null) return;
            UpdateGameView(selectedGame);
        }

        private void UpdateGameView(GameModel game)
        {
            TitleText.Text = game.Title;
            CreatorText.Text = "制作者:" + game.Author;
            ExplanationText.Text = game.Description;
            pictureBox1.Image = game.TitleImage;
            VersionText.Text = "Ver." + game.Version;
        }

        private void splitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            _presenter.RunGame();
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
            _presenter = presenter;
        }

        public void DisplayGames(GameCollectionModel games)
        {
            GameList.Items.Clear();
            foreach(GameModel game in games.Games)
            {
                var item = new ListViewItem(new[] { game.Title });
                item.Tag = game;
                GameList.Items.Add(item);
            }
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
