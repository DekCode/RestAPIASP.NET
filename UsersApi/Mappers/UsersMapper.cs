using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.Common;
using UsersApi.Models;

namespace UsersApi.Mappers
{
    public static class UsersMapper
    {
        public static UserItem MapToCommon(UserObject obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new UserItem
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }

        public static UserObject MapToDto(UserItem obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new UserObject
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }
    }
}
