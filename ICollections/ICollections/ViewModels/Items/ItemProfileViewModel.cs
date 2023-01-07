using System.Linq;
using ICollections.Models;

namespace ICollections.ViewModels
{
    public class ItemProfileViewModel
    {
        public Item Item;
        public IQueryable<ItemLike> ItemLikes;
        public IQueryable<ItemComment> ItemComments;
    }
}