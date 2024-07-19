using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporClient.Constants
{
    public static class ErrorMessages
    {
        public const string GameNotFound = "The specified game could not be found.";
        public const string InvalidGamePath = "The specified game path is invalid.";
        public const string FailedToLoadGames = "Failed to load games from the directory.";
        public const string FailedToSaveSettings = "Failed to save user settings.";
    }
}
