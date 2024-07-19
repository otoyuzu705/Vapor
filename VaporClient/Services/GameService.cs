using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using VaporClient.Models;
using VaporClient.Constants;

namespace VaporClient.Services
{
    public class GameService
    {
        private string _serverAddress;
        private string _gamesPath;
        private HttpClient _httpClient;

        public GameService(string serverAddress, string gamesPath)
        {
            this._serverAddress = serverAddress + "/vapor/api/";
            this._gamesPath = gamesPath;
            _httpClient = new HttpClient();
        }


        public async Task<GameCollectionModel> GetGameListAsync()
        {
            string getAPI = _serverAddress + "/Get";
            try
            {
                var response = await _httpClient.GetStringAsync(getAPI);
                return JsonConvert.DeserializeObject<GameCollectionModel>(response);
            }
            catch (Exception ex)
            {
                throw new Exception(ErrorMessages.FailedToLoadGames);
            }
        }

        public void RunGame(GameModel game)
        {
            string gamePath = $"{_gamesPath}/{game.Title}/{game.Title}.exe";
            if (File.Exists(gamePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = gamePath,
                    UseShellExecute = true,
                });
            }
            else
            {
                throw new FileNotFoundException(ErrorMessages.GameNotFound);
            }
        }
    }
}
