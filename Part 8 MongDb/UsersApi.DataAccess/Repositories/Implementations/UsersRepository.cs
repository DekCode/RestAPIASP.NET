using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsersApi.Common;
using UsersApi.DataAccess.DatabaseContexts;
using UsersApi.DataAccess.Repositories.Interfaces;

namespace UsersApi.DataAccess.Repositories.Implementations
{
    public class UsersRepository : IUsersRespository
    {
        private List<User> _users = new List<User>();

        public User CreateUser(User obj)
        {
            obj.Id = Guid.NewGuid().ToString();
            obj.CreationDate = DateTime.Now;

            _users.Add(obj);
            return obj;
        }

        public void Delete(string id)
        {
            _users.RemoveAll(user => user.Id == id);
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public User UpdateUser(User obj)
        {
            var items = _users.Where(item => item.Id == obj.Id);

            if (items.FirstOrDefault() == null)
            {
                return null;
            }

            var user = items.FirstOrDefault();
            user.Name = obj.Name;

            return user;
        }
    }
}
