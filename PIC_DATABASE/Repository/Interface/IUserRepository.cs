using PIC_DATABASE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC_DATABASE.Repository.Interface
{
    interface IUserRepository
    {
        void Add(Users User);
        
        Users Get(string user, string password);

        IEnumerable<Users> GetAll();
        
        void Edit(Users UserViewModel);

        void Remove(int id);


    }
}
