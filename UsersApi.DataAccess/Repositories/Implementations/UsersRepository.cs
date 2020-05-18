using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UsersApi.Common;
using UsersApi.DataAccess.Repositories.Interfaces;

namespace UsersApi.DataAccess.Repositories.Implementations
{
    public class UsersRepository : IUsersRespository
    {
        private static readonly List<UserItem> _users = new List<UserItem>();

        public UserItem CreateUser(UserItem obj)
        {
            obj.Id = Guid.NewGuid().ToString();
            _users.Add(obj);
            return obj;
        }

        public void Delete(string id)
        {
            _users.RemoveAll(item => item.Id == id);
        }

        public List<UserItem> GetUsers()
        {
            return _users;
        }

        public UserItem UpdateUser(UserItem obj)
        {
            var user = _users.FirstOrDefault(item => item.Id == obj.Id);

            if (obj == null)
            {
                return null;
            }

            user.Name = obj.Name;

            return user;
        }
    }
}
