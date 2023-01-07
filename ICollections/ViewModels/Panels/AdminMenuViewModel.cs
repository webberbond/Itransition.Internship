using System.Collections.Generic;
using ICollections.Models;

namespace ICollections.ViewModels
{
    public class AdminMenuViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}