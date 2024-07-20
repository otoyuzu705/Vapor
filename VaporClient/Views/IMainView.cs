using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporClient.Presenters;
using VaporClient.Models;

namespace VaporClient.Views
{
    public interface IMainView
    {
        void SetPresenter(MainPresenter presenter);
        void DisplayGames(GameCollectionModel games);
        void ShowErrorMessage(string message);
    }
}
