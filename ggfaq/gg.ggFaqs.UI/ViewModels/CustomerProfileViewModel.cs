using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;

namespace gg.ggFaqs.UI.ViewModels
{
    public class CustomerProfileViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }
        public List<ThreadViewModel> Threads { get; set; }
        public List<ThreadViewModel> ThreadsForPosts { get; set; }
        public List<Post> Posts { get; set; }   
        public List<Game> Games { get; set; }

        public CustomerProfileViewModel(Customer customer)
        {
            Customer = customer;
            Games = LibraryGameManager.GamesByLibraryId(LibraryManager.LoadByCustomerId(customer.Id).Id);

            //Create a list of the VM threads
            List<BL.Models.Thread> GameThreads = ThreadManager.LoadByCustomerId(customer.Id);
            Threads = new List<ThreadViewModel>();
            foreach (BL.Models.Thread thread in GameThreads)
            {
                Threads.Add(new ThreadViewModel(thread.Id));
            }

            //Load all the threads
            List<BL.Models.Thread> PostThreads = new List<BL.Models.Thread>();
            Posts = PostManager.LoadByPlayerId(customer.Id);
            foreach (Post post in Posts)
            {
                PostThreads.Add(ThreadManager.LoadById(post.ThreadID));
            }

            //Create a list of the VM threads from their posts
            ThreadsForPosts = new List<ThreadViewModel>();
            foreach (BL.Models.Thread thread in PostThreads)
            {
                ThreadsForPosts.Add(new ThreadViewModel(thread.Id));
            }
        }
    }
}
