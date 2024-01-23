using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;
using System.Linq;

namespace gg.ggFaqs.UI.ViewModels
{
    public class GameDetailsViewModel : BaseViewModel
    {
        public List<Game> Games { get; set; }
        public List<BL.Models.Thread> Threads { get; set; }

        public GameDetailsViewModel(Game game) 
        {
            Threads = new List<BL.Models.Thread>();
            string[] systemIcons = new string[] { "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/xbox_logo.jpg"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/Xbox_360_logo.webp"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/xbox_one_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/xbox_xs_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/playstation_symbol.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/playstation2_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/playstation3_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/playstation_4_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/playstation5_logo.jpg"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/NES_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/Super_NES_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/N64_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/nintendo_gamecube_logo.webp"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/wii_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/wii_u_logo.jpg"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/nintendo_switch_logo.png"
                                                    , "https://ggfaqstorage.blob.core.windows.net/ggfaqsmainstorage/windows_logo.png"};
            Games = GameManager.LoadByTitle(game.Title);
            foreach(Game g in Games)
            {
                g.SystemImageIcon = systemIcons[g.SystemId - 1];
                Threads.AddRange(ThreadManager.LoadByGameId(g.Id));
            }
        }
    }
}
