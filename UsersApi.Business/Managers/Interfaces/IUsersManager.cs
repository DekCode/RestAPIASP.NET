using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Common;

namespace UsersApi.Business.Managers.Interfaces
{
    public interface IUsersManager
    {
        List<UserItem> GetUsers();

        UserItem CreateUser(UserItem obj);

        UserItem UpdateUser(string id, UserItem obj);

        void Delete(string id);
    }
}
