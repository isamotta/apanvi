using Apanvi.API.Models;

namespace Apanvi.API.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
