using gg.ggFaqs.BL.Models;
using gg.ggFaqs.BL;

namespace gg.ggFaqs.UI.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public Customer Customer { get; set; }

        public PostViewModel(Post post, int customerId)
        {
            Post = post;
            Customer = CustomerManager.LoadById(customerId);
        }

        public PostViewModel(int threadId)
        {
            Post = new Post();
            Post.ThreadID = threadId;
        }
    }
}
