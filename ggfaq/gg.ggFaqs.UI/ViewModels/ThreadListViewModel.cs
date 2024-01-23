using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;

namespace gg.ggFaqs.UI.ViewModels
{
    public class ThreadListViewModel : BaseViewModel
    {
        public List<ThreadViewModel> Threads { get; set; }

        public ThreadListViewModel()
        {
            List<BL.Models.Thread> AllThreads = ThreadManager.Load();
            Threads = new List<ThreadViewModel>();

            foreach (BL.Models.Thread thread in AllThreads)
            {
                Threads.Add(new ThreadViewModel(thread.Id));
            }
        }

        public ThreadListViewModel(int gameId)
        {
            List<BL.Models.Thread> GameThreads = ThreadManager.LoadByGameId(gameId);
            Threads = new List<ThreadViewModel>();

            foreach (BL.Models.Thread thread in GameThreads)
            {
                Threads.Add(new ThreadViewModel(thread.Id));
            }
        }

    }
}
