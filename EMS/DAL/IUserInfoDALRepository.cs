using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface IUserInfoDALRepository<UserInfo>
    {
        bool SaveUser(UserInfo userInfo);

        bool DeleteUser(string email);

        bool UpdateUser(UserInfo userInfo);

        ICollection<UserInfo> GetAll();

        bool ValidateUser(UserInfo userInfo);
    }
}
