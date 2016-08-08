﻿using GroupProject.Data;
using GroupProject.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Services
{
    public class UserService
    {
        private UserRepository _uRepo;
        public UserService(UserRepository ur) {

            _uRepo = ur;
        }

        public IList<UserDTO> GetUserNames() {
            return (from u in _uRepo.GetAllUserNames()
                    select new UserDTO()
                    {
                        UserName = u.UserName,
                        MetropolitanArea = u.MetropolitanArea
                    }).ToList();








        }
    }
}
