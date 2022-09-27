﻿using System;
using System.Collections.Generic;

namespace Model
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            Collections = new HashSet<Collection>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string UserName { get; set; } = null!;
        public string? Password { get; set; }
        public string EmailAddress { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public byte[]? CoverPicture { get; set; }
        public string? AboutUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ThemeId { get; set; }

        public virtual Theme? Theme { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
        public virtual ICollection<Post> Posts { get; set; }


        public static string GetAll(){
            return "teste";
        }
    }
}