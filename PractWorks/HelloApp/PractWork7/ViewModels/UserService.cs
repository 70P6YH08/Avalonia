using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PractWork7.ViewModels
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
        }

        public void SaveUser()
        {
            _context.SaveChanges();
        }
    }
}
