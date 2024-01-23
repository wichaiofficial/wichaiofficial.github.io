using gg.ggFaqs.BL.Models;
using gg.ggFaqs.BL;

namespace gg.ggFaqs.UI.ViewModels
{
    public class ThreadViewModel : BaseViewModel
    {
        public BL.Models.Thread Thread { get; set; }
        public Game Game { get; set; }
        public Customer Customer { get; set; }
        public List<Game> Games { get; set; }
        public List<PostViewModel> Posts {get; set;}

        public ThreadViewModel(int threadId)
        {
            Thread = ThreadManager.LoadById(threadId);
            Game = GameManager.LoadByThreadId(Thread.GameId);
            Customer = CustomerManager.LoadByThreadId(Thread.CustomerId);
            List<Post> posts = PostManager.LoadByThreadId(threadId);
            Posts = new List<PostViewModel>();
            foreach(Post p in posts)
            {
                Posts.Add(new PostViewModel(p, p.CustomerId));
            }
            
        }
        public ThreadViewModel()
        {
            Thread = new BL.Models.Thread();
            Games = GameManager.Load();
        }
    }
}
