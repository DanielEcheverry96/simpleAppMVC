using System;
using System.Collections.Generic;

namespace Sample_MVCApp.Models
{
    public class Users
    {
        

        public List<UserModels> _userList = new List<UserModels>();
        public Users()
        {
            _userList.Add(new UserModels
            {
                FirstName = "Santiago",
                LastName = "Arias",
                Address = "Indore MP",
                Email = "santi@test.com",
                DOB = Convert.ToDateTime("22/6/1976"),
                Salary = 40000
            });
            _userList.Add(new UserModels
            {
                FirstName = "Sarah",
                LastName = "Sanchez",
                Address = "Indore MP",
                Email = "sarah@test.com",
                DOB = Convert.ToDateTime("7/11/2001"),
                Salary = 7000
            });
            _userList.Add(new UserModels
            {
                FirstName = "Alix",
                LastName = "Monsalve",
                Address = "Indore MP",
                Email = "alix@test.com",
                DOB = Convert.ToDateTime("3/12/2010"),
                Salary = 5000
            });
        }

        public void CreateUser(UserModels userModel)
        {
            _userList.Add(userModel);
        }

        public void UpdateUser(UserModels userModel)
        {
            foreach(UserModels usrlst in _userList)
            {
                if (usrlst.Email == userModel.Email)
                {
                    _userList.Remove(usrlst);
                    _userList.Add(userModel);
                    break;
                }
            }
        }
        
    }
}