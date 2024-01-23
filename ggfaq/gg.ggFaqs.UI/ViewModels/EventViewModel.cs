using gg.ggFaqs.BL;
using gg.ggFaqs.BL.Models;

namespace gg.ggFaqs.UI.ViewModels
{
    public class EventViewModel : BaseViewModel
    {
        public EventThread EventThread { get; set; }
        public List<EventThread> EventThreads { get; set; }


        public EventViewModel() 
        { 
            EventThreads = EventThreadManager.Load();
        }
        
    }
}
