using System.Collections.Generic;
using ICollections.Models;

namespace ICollections.ViewModels
{
    public class CollectionItemsViewModel
    {
        public User User;
        public UserCollection UserCollection;
        public List<Item> Items;
        public List<ExtendedField> ExtendedFields;
        public List<DataField> DataFields;
        public Item TempItem;
    }
}