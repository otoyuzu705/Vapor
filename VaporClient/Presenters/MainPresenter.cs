using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporClient.Views;
using VaporClient.Services;
using VaporClient.Models;

namespace VaporClient.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;
        private GameService _gameService;

        public MainPresenter(IMainView view, GameService gameService)
        {
            _view = view;
            _gameService = gameService;
            _view.SetPresenter(this);
            LoadGames();
        }

        public async void LoadGames()
        {
            try
            {
                var gameList = await _gameService.GetGameListAsync();
                _view.DisplayGames(gameList);
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage(ex.Message);
            }
        }

        public void RunGame()
        {

        }
    }
}
