using PIC_DATABASE.Database;
using PIC_DATABASE.Models;
using PIC_DATABASE.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PIC_DATABASE.Repository
{
    public class UserRepository : IUserRepository
    {
        DatabaseContext AccessDatabase { get; set; }

        public UserRepository()
        {
            AccessDatabase = new DatabaseContext();
        }
        public void Add(Users User)
        {
            AccessDatabase.Users.Add(User);
            AccessDatabase.SaveChanges();
        }


        public Users Get(string user, string password)
        {
            return AccessDatabase.Users.FirstOrDefault(x => x.Username == user && x.Password == password);
        }

        public void Edit(Users UserViewModel)
        {
            Users UserDB = AccessDatabase.Users.FirstOrDefault(x => x.Id == UserViewModel.Id);

            UserDB.Active = UserViewModel.Active;
            UserDB.Departament = UserViewModel.Departament;
            UserDB.Email = UserViewModel.Email;
            UserDB.IP = UserViewModel.IP;
            UserDB.Job = UserViewModel.Job;
            UserDB.Name = UserViewModel.Name;
            UserDB.Password = UserViewModel.Password;
            UserDB.Username = UserViewModel.Username;
            UserDB.UserType = UserViewModel.UserType;

            AccessDatabase.SaveChanges();
        }

        public void Remove(int id)
        {
            Users UserDB = AccessDatabase.Users.FirstOrDefault(x => x.Id == id);

            UserDB.Active = false;

            AccessDatabase.SaveChanges();
        }

        public IEnumerable<Users> GetAll()
        {
            return AccessDatabase.Users.ToList();
        }

    }
}
