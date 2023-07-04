using Apanvi.API.Models;
using System.Collections.Concurrent;

namespace Apanvi.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ConcurrentBag<User> _usersDb = new ConcurrentBag<User>();

        public UserRepository()
        {
            _usersDb.Add(new User("Daiana", "SuperAdmin")); 
            _usersDb.Add(new User("Renata", "Admin"));
        }
        public List<User> GetAll()
        {
            var users = _usersDb.ToList();
            return users;
        }

        
    }

    
}


