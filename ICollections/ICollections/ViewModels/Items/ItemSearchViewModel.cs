using System.Collections.Generic;
using ICollections.Models;

namespace ICollections.ViewModels
{
    public class ItemSearchViewModel
    {
        private readonly Item CurrentItem;
        private readonly ICollection<ItemComment> itemComments;
        private readonly ICollection<User> users;
    }
}