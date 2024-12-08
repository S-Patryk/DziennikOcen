﻿using System.Security.Cryptography.Xml;
using System;

namespace DziennikOcen.Server.Models
{
    public class User
    {
    
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Pin { get; set; }
        public int RoleID { get; set; }
        public DateTime Create_at { get; set; }
        public DateTime Update_at { get; set; }
    }
}
