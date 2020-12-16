using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace MyGarage.Models
{
   public class EfVehicleRepository : IVehicleRepository
   {
      //   F i e l d s   &   P r o p e r t i e s

      private AppDbContext _context;
      private readonly IWebHostEnvironment environment;

      //   C o n s t r u c t o r s
      public EfVehicleRepository(AppDbContext context, IWebHostEnvironment env)
      {
         _context = context;
         environment = env;
      }

      //   M e t h o d s

      //   C r e a t e - - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Vehicle CreateVehicle(Vehicle vehicle)
      {
         if (vehicle == null)
         {
            return null;
         }
         _context.Vehicles.Add(vehicle);
         _context.SaveChanges();
         return vehicle;

      }//End CreateVehicle()

      //   R e a d - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
      public IQueryable<Vehicle> GetUserVehicles(int userId)
      {
         return _context.Vehicles.Where(v => v.UserId == userId);
      }//End GetUserVehicles()

      public IQueryable<Vehicle> GetAllVehicles()
      {
         return _context.Vehicles;
      }//End GetAllVehicles()

      public Vehicle GetVehicleById(int vehicleId)
      {
         return _context.Vehicles.Include(v => v.User)
                                 .FirstOrDefault(v => v.Id == vehicleId);

         //return _context.Vehicles.Find(vehicleId);
         //.Where(v => v.VehicleId == vehicleId)
         //.FirstOrDefault();

         //return _context.Vehicles.Include(v => v.Repairs).FirstOrDefault(v => v.VehicleId == vehicleId);
      }//End GetVehiclesById()

      public IQueryable<Vehicle> GetVehiclesByMakeKeyword(string keyword)
      {
         return _context.Vehicles
                       .Where(v => v.Make.Contains(keyword));

      }//End GetVehiclesByMakeKeyword()

      //   U p d a t e - - - - - - - - - - - - - - - - - - - - - - - - - -
      public Vehicle UpdateVehicle(Vehicle vehicle)
      {
         Vehicle vehicleToUpdate = _context.Vehicles
                                 .SingleOrDefault(v => v.Id == vehicle.Id);

         if (vehicleToUpdate != null)
         {
            vehicleToUpdate.Year = vehicle.Year;
            vehicleToUpdate.Make = vehicle.Make;
            vehicleToUpdate.Model = vehicle.Model;
            vehicleToUpdate.LicensePlate = vehicle.LicensePlate;
            vehicleToUpdate.NickName = vehicle.NickName;
            vehicleToUpdate.Mileage = vehicle.Mileage;
            vehicleToUpdate.VehicleVIN = vehicle.VehicleVIN;
            vehicleToUpdate.Photo = vehicle.Photo;
            vehicleToUpdate.PurchasePrice = vehicle.PurchasePrice;
            vehicleToUpdate.Repairs = vehicle.Repairs;
            vehicleToUpdate.Upgrades = vehicle.Upgrades;
            _context.SaveChanges();
         }
         return vehicleToUpdate;
      }//End UpdateVehicle()

      //   D e l e t e - - - - - - - - - - - - - - - - - - - - - - - - - -
      public bool DeleteVehicle(int vehicleId)
      {
         Vehicle vehicleToDelete = _context.Vehicles.Find(vehicleId);

         if (vehicleToDelete == null)
         {
            return false;
         }

         _context.Vehicles.Remove(vehicleToDelete);
         _context.SaveChanges();
         return true;
      }//End DeleteVehicle()
   }
}
