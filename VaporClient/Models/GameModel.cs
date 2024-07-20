using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VaporClient.Models
{
    public class GameModel
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string UUID { get; set; }
        public Bitmap TitleImage { get; set; }
    }
}
