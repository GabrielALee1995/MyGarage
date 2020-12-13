using System.Linq;

namespace MyGarage.Models
{
   public interface IUserRepository
   {
      //   C r e a t e
      public User AddUser(User user);

      //   R e a d
      public IQueryable<User> GetAllUsers();
      public int GetUserId(User u);
      public User GetUserByEmail(string email);
      public User GetUserById(int id);
      public bool Login(User u);
      public bool IsUserLoggedIn();
      public string GetloggedInUserByEmail();
      public int GetLoggedInUserId();
      public bool IsUserAdmin();
      public void Logout();

      //   U p d a t e
      public User UpdateUser(User user);
      public User UpdateUserPassword(User user);

      //   D e l e t e
      public bool DeleteUser(int id);
      public string DeleteUser(string email);
      public bool DeleteUser(User user);
   }
}
