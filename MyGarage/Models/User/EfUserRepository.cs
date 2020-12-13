using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MyGarage.Models
{
   public class EfUserRepository : IUserRepository
   {
      //   F i e l d s   &   P r o p e r t i e s

      private AppDbContext _context;
      private ISession _session;

      //   C o n s t r u c t o r s

      public EfUserRepository(AppDbContext context, IHttpContextAccessor httpContextAccessor)
      {
         _context = context;
         _session = httpContextAccessor.HttpContext.Session;
      }

      //   M e t h o d s

      //   C r e a t e - - - - - - - - - - - - - - - - - - - - - - - 
      public User AddUser(User u)
      {
         try
         {  
            u.Password = encrypt(u.Password);
            _context.Users.Add(u);
            _context.SaveChanges();
            _session.SetInt32("userId", u.Id);
            _session.SetString("userEmail", u.Email);
         }
         catch (Exception e)
         {
            u.Id = -1;
         }
         u.Password = "";
         return u;
      }

      //   R e a d - - - - - - - - - - - - - - - - - - - - - - - - -
      public IQueryable<User> GetAllUsers()
      {
         return _context.Users;
      }//End GetAllUsers()

      public int GetUserId(User u)
      {
         int? userId = u.Id;

         if (userId == null)
         {
            return -1;
         }
         else
         {
            return userId.Value;
         }
      }

      public int GetLoggedInUserId()
      {
         int? userId = _session.GetInt32("userId");
         if (userId == null)
         {
            return -1;
         }
         else
         {
            return userId.Value;
         }
      }//End GetLoggedInUserId()

      public User GetUserByEmail(string userEmail)
      {
         User u = _context.Users.FirstOrDefault(u => u.Email == userEmail);
         return u;
      }//End GetByUserEmail()

      public User GetUserById(int userId)
      {
         return _context.Users
                        .Find(userId);
      }//End GetUserById()

      public bool IsUserLoggedIn()
      {
         throw new System.NotImplementedException();
      }//End IsUserLoggedIn()

      public bool Login(User u) // email    password
      {
         User dbUser = GetUserByEmail(u.Email);

         if (dbUser == null)
         {
            return false;
         }

         u.Password = encrypt(u.Password);

         if (dbUser.Password == u.Password)
         {
            _session.SetInt32("userId", dbUser.Id);
            _session.SetString("userEmail", dbUser.Email);
            if (dbUser.IsAdmin == true)
            {
               _session.SetInt32("userAdmin", 1);
            }
            else
            {
               _session.SetInt32("userAdmin", 0);
            }
            return true;
         }

         return false;
      }//End Login()

      public string GetloggedInUserByEmail()
      {
         return _session.GetString("userEmail");
      }//End GetLoggedInUserEmail()

      public bool IsUserAdmin()
      {
         if (_session.GetInt32("userAdmin") == 1)
         {
            return true;
         }
         return false;
      }//End IsUserAdmin()

      public void Logout()
      {
         _session.Remove("userEmail");
         _session.Remove("userId");
         _session.Remove("userAdmin");
      }//End Logout()

      //   U p d a t e - - - - - - - - - - - - - - - - - - - - - -
      public User UpdateUser(User user)
      {
         User userToUpdate = _context.Users
                                     .SingleOrDefault(u => u.Id == user.Id);
         if(userToUpdate != null)
         {
            userToUpdate.Id = user.Id;
            userToUpdate.Email = user.Email;
            userToUpdate.IsAdmin = user.IsAdmin;
            userToUpdate.Vehicles = user.Vehicles;
            userToUpdate.Password = user.Password;
            _context.SaveChanges();
         }
         return userToUpdate;
      }//End UpdateUser()

      public User UpdateUserPassword(User user)
      {
         User userToUpdate = _context.Users
                                     .SingleOrDefault(u => u.Id == user.Id);

         user.Password = encrypt(user.Password);

         if (userToUpdate != null)
         {
            userToUpdate.Email = user.Email;
            userToUpdate.IsAdmin = user.IsAdmin;
            userToUpdate.Vehicles = user.Vehicles;
            userToUpdate.Password = user.Password;
            _context.SaveChanges();
         }
         return userToUpdate;
      }//End UpdateUserPassword()

      //   D e l e t e - - - - - - - - - - - - - - - - - - - - - -
      public bool DeleteUser(int id)
      {
         User userToDelete = _context.Users.Find(id);
         if (userToDelete == null)
         {
            return false;
         }
         _context.Users.Remove(userToDelete);
         _context.SaveChanges();
         return true;
      }//End DeleteUser(id)

      public string DeleteUser(string email)
      {
         throw new System.NotImplementedException();
      }//End DeleteUser(email)

      public bool DeleteUser(User user)
      {
         throw new System.NotImplementedException();
      }//End DeleteUser(User)

      private string encrypt(string password)
      {
         SHA256 myHashingVar = SHA256.Create();
         byte[] passwordByteArray = Encoding.ASCII.GetBytes(password);
         passwordByteArray[0] += 1;
         passwordByteArray[1] += 2;
         passwordByteArray[2] += 3;
         passwordByteArray[3] += 4;
         byte[] hashedPasswordByteArray = myHashingVar.ComputeHash(passwordByteArray);
         string hashedPassword = "";
         foreach (byte b in hashedPasswordByteArray)
         {
            hashedPassword += b.ToString("x2");
         }
         return hashedPassword;
      }//End encrypt()
   }
}
