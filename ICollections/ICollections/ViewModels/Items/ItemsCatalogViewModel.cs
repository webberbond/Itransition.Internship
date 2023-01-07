using System.Collections.Generic;
using System.Linq;
using ICollections.Models;

namespace ICollections.ViewModels
{
    public class ItemsCatalogViewModel
    {
        public IQueryable<Item> Items;
        public List<ItemLike> ItemLikes;
        public List<UserCollection> TopFiveCollections;
        public List<UserCollection> UserCollections;
        public User User;
        public IEnumerable<string> TagCloude;
    }
}