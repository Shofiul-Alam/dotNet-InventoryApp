using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.API.Models;

namespace Inventory.API.Data
{
    public interface IUserRepository
    {
         void Add<T> (T entity) where T: class;
         void Delete<T> (T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
         Task<Photo> getMainPhotoForUser(int userId);
    }
}