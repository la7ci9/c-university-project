using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WebApi_Common.Models;

namespace WebApi_Server.Repositories
{
    public static class CardataRepository
    {
        public static IList<Cardata> GetCars()
        {
            using (var database = new CardataContext())
            {
                var cars = database.Cars.ToList();

                return cars;
            }
        }

        public static Cardata GetCardata(long id)
        {
            using (var database = new CardataContext())
            {
                var cardata = database.Cars.Where(cardata => cardata.Id == id).FirstOrDefault();

                return cardata;
            }
        }

        public static void AddCar(Cardata cardata)
        {
            using (var database = new CardataContext())
            {
                database.Cars.Add(cardata);

                database.SaveChanges();

            }
        }

        public  static void UpdateCar(Cardata cardata)
        {
            using (var database = new CardataContext())
            {
                 database.Cars.Update(cardata);

                 database.SaveChanges();

            }
        }

        public static void DeleteCar(Cardata cardata)
        {
            using (var database = new CardataContext())
            {
                database.Cars.Remove(cardata);

                database.SaveChanges();

            }
        }



    }
}
