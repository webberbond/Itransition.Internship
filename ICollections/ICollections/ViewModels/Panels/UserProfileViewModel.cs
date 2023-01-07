using System.Collections.Generic;
using ICollections.Models;

namespace ICollections.ViewModels
{
    public class UserProfileViewModel
    {
        public User User;
        public List<UserCollection> UserCollections;
        public ExtendedField ExtendedFields;
    }
}