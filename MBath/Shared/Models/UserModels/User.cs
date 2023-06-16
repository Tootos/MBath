﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBath.Shared.Models.UserModels
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }=string.Empty;

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}