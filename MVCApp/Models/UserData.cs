using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class UserData
    {
        public static List<UserInfo> GetUsers()
        {
            List<UserInfo> userInfos = new List<UserInfo>();
            for (int i=0;i<10; i++)
            {
                userInfos.Add(new UserInfo()
                {
                    Id = i,
                    UserName = "t" + i.ToString(),
                    Password = "p" + i.ToString()
                });
            }
            return userInfos;
        }
    }
}