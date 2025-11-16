using PsCoreDemo.Models;

namespace PsCoreDemo.ViewModels
{
    /// <summary>
    /// ViewModel to encapsulate data for the Card List view
    /// </summary>
    public class CardListViewModel
    {
        /// <summary>
        /// Collection of cards to be displayed
        /// </summary>
        public IEnumerable<Card> Cards { get; set; }

        /// <summary>
        /// Current category being viewed
        /// </summary>
        public string CurrentCategory { get; set; }
    }
}