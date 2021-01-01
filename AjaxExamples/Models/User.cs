using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AjaxExamples.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDateTime { get; set; }
    }

    public static class UserProcess
    {

        private static List<User> listusers = new List<User>
        {
            new User{Id=1,Name="Berk",Surname="Arat",BirthDateTime=DateTime.Now.ToString("28/09/1993 00:00:00")},
            new User{Id=2,Name="Bora",Surname="Arat",BirthDateTime=DateTime.Now.ToString("28/09/1993 00:00:00")},
            new User{Id=3,Name="Bobo",Surname="Arat",BirthDateTime=DateTime.Now.ToString("28/09/1993 00:00:00")}
        };
        public static User GetUserById(int id)
        {
            return listusers.FirstOrDefault(I => I.Id == id);
        }

        public static List<User>  GetAllUser()
        {

            Thread.Sleep(5000);
            return listusers;
        }

        public static void AddUser(User user)
        {

            listusers.Add(user);
        }
    }

}
