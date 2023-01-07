using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ICollections.Models
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }
        public bool AdminRoot { get; set; }
        public bool IsWhiteTheme { get; set; }
        public virtual ICollection<UserCollection> UserCollections { get; set; }
        public virtual ICollection<ItemLike> UserItemLikes { get; set; }
    }
}