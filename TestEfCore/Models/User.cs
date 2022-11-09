﻿using System;

namespace TestEfCore.Models
{
    public class User
    {
        public User()
        {

        }
        public User( int id, string fullname)
        { 
             Id = id;
            FullName = fullname;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }

      
    }
}
