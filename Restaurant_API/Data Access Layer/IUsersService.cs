﻿using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API.Data_Access_Layer
{
    interface IUsersService
    {
        public User Create(User user);
        public User Get(string login, string password);
        public List<User> Get();
        public User Get(int id);
        public void Update(int id, User userEd);
        public void Remove(User userEd);
        public void Remove(int id);
    }
}