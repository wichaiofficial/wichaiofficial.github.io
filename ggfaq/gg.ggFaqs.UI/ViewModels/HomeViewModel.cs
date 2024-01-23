using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;
using System.Collections.Generic;

namespace gg.ggFaqs.UI.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }
        public Game Game { get; set; }
        public List<Game> Games { get; set; }
        public Post Post { get; set; }
        public List<Post> Posts { get; set; }
        public EventThread EventThread { get; set; }
        public List<EventThread> EventThreads { get; set;}
        public gg.ggFaqs.BL.Models.Thread Thread { get; set; }
        public List<gg.ggFaqs.BL.Models.Thread> Threads { get; set; }
        public string RandomGameFact { get; set; }

        public List<string> GameTitles { get; set; }
        public List<string> GameImage { get; set; }

        public async Task<HomeViewModel> HomeViewModelLoad()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.Games = GameManager.Load();
            vm.Posts = PostManager.Load();
            vm.EventThreads = EventThreadManager.Load();
            vm.Threads = ThreadManager.Load();

            if(vm.Games.Count > 5)
            {
                vm.Games.RemoveRange(5, vm.Games.Count - 5);
            }
            if (vm.Posts.Count > 5)
            {
                vm.Posts.RemoveRange(5, vm.Posts.Count - 5);
            }
            if (vm.EventThreads.Count > 5)
            {
                vm.EventThreads.RemoveRange(5, vm.EventThreads.Count - 5);
            }
            if (vm.Threads.Count > 5)
            {
                vm.Threads.RemoveRange(5, vm.Threads.Count - 5);
            }
            //Get a random video game facts 
            //Random random = new Random();
            //int year = random.Next(2005, DateTime.Now.Year);
            //string prompt = "Please give me a random video game fact from the year " + year + ". The game can be any game, or any genre. Try to make the facts as unique as possible.";
            //vm.RandomGameFact = await GameManager.GetPromptFromChatGPT(prompt);
            return vm;
        }


    }
}
