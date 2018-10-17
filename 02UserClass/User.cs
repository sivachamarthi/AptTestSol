using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UserClass
{
    public class User
    {
        /// <summary>
        /// Static usernames list (shared by all instances of User)
        /// </summary>
        public static List<string> ListUserName = new List<string>();

        public User()
        {

        }

        /// <summary>
        /// Add username to list
        /// </summary>
        /// <param name="userName"></param>
        public void Add(string userName)
        {
            ListUserName.Add(userName);
        }

        /// <summary>
        /// Get count of usernames list
        /// </summary>
        /// <returns></returns>
        public int GetUsersCount()
        {
            return ListUserName.Count();
        }
    }
}
