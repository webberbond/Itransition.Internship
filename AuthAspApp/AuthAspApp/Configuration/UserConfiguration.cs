using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AuthAspApp.Constants;
using AuthAspApp.Entities;

namespace AuthAspApp.Configuration
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder) => builder.HasData(GetUsers());

        private static IEnumerable<User> GetUsers() => new List<User>()
            {
                new User()
                {
                    UserName = "Grisha",
                    Email = "g.chubey13@gmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Blocked,
                },

                new User()
                {
                    UserName = "Helen",
                    Email = "helenfox@yahoo.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },

                new User()
                {
                    UserName = "Azamat",
                    Email = "19karimov82@hotmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },

                new User()
                {
                    UserName = "Claudette",
                    Email = "cla_udette6@gmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },

                new User()
                {
                    UserName = "Persi",
                    Email = "persi.j@gmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },

                new User()
                {
                    UserName = "Mikhail",
                    Email = "mikh_1994_ail@hotmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },

                new User()
                {
                    UserName = "Sergey",
                    Email = "sergey.zrch@gmail.com@gmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },

                new User()
                {
                    UserName = "Dayana",
                    Email = "daya_18_flo@hotmail.com",
                    LastSignInDate = DateTime.Now,
                    SignUpDate = DateTime.Now,
                    Status = UserStatuses.Active,
                },
            };
    }
}
