﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MysMusic.Core.Models
{
    public class UserArtiste
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public bool isAdmin { get; set; }
    }
}
