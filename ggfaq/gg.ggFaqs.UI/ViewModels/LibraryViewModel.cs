using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;

namespace gg.ggFaqs.UI.ViewModels
{
    public class LibraryViewModel : BaseViewModel
    {
        public Library Library { get; set; }
        public List<LibraryGame> LibraryGames { get; set; }
        public Customer Customer { get; set; }
        public GameListViewModel GameListViewModel { get; set; }

        public LibraryViewModel(int CustomerId)
        {
            GameListViewModel = new GameListViewModel();
            Library = LibraryManager.LoadByCustomerId(CustomerId);
            LibraryGames = LibraryGameManager.LoadByLibraryId(Library.Id);
            Customer = CustomerManager.LoadById(CustomerId);
            List<Game> lbList = LibraryGameManager.GamesByLibraryId(Library.Id);
            GameListViewModel.Games = lbList;
        }
    }
}
