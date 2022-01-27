using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
  public  class UserInfoBLL
    {
        UserInfoDALRepository userInfoDAL = new UserInfoDALRepository();

        public bool ValidateUser(UserInfo userInfo)
        {
            return userInfoDAL.ValidateUser(userInfo);
        }
    }
}
