using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Business.Managers.Interfaces;
using UsersApi.Common;
using UsersApi.DataAccess.DataAccess.Interfaces;

namespace UsersApi.Business.Managers.Implementations
{
    public class UsersManager : IUsersManager
    {
        private IUsersDataAccess _UsersDataAccess;

        public UsersManager(IUsersDataAccess usersDataAccess)
        {
            _UsersDataAccess = usersDataAccess;
        }

        public UserItem CreateUser(UserItem obj)
        {
            return _UsersDataAccess.CreateUser(obj);
        }

        public void Delete(string id)
        {
            _UsersDataAccess.Delete(id);
        }

        public List<UserItem> GetUsers()
        {
            return _UsersDataAccess.GetUsers();
        }

        public UserItem UpdateUser(string id, UserItem obj)
        {
            obj.Id = id;

            return _UsersDataAccess.UpdateUser(obj);
        }
    }
}
