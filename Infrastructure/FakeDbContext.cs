﻿using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebAPI5.Models;

namespace WebAPI5.Infrastructure
{
    public class FakeDbContext
    {
        public FakeDbContext() {

            Users = new List<User>();
            Heroes = new List<Hero>();
            Positions = new List<Position>();
        
        }

        public List<User> Users { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Position> Positions { get; set; } 

        public List<T> GetTable<T> ()
        {
            return GetType()
                .GetProperties()
                .FirstOrDefault(p => p.GetValue(this, null) is List<T>)
                ?.GetValue(this, null) as List<T>;
        }


    }
}
