using System;
using System.Collections.Generic;
using System.Text;
using UsersApi.Common;

namespace UsersApi.DataAccess.Repositories.Interfaces
{
    public interface IUsersRespository
    {
        List<UserItem> GetUsers();

        UserItem CreateUser(UserItem obj);

        UserItem UpdateUser(UserItem obj);

        void Delete(string id);
    }
}
