using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserInfoDALRepository : IUserInfoDALRepository<UserInfo>
    {
        public bool DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool SaveUser(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUser(UserInfo userInfo)
        {
            try
            {
                using (NordicEMSEntities dbContext=new NordicEMSEntities())
                {
                    var result = dbContext.UserInfoes.Where(x=>x.Email==userInfo.Email && x.Password==userInfo.Password).FirstOrDefault();
                    if (result != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
