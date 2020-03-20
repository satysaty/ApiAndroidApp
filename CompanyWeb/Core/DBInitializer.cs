using CompanyWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompanyWeb.Core
{
    //City
    //0 - донецк, 1 - мариуполь, 2 - киев, 3 - одесса

    //MainCategory 
    // 1 - сантехника, 2 - Электрика, 3 - отопление, 4 - канализация

    public class DBInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            SeedSantehnika(db);
            SeedElektrika(db);
            SeedKanalizatia(db);
            SeedOtoplenie(db);
            SeedMasters(db);
            SeedWorkOptions(db);
        }

        public void SeedSantehnika(DataContext db)
        {
            //Работы унитаз
            var work1 = new List<Work>
                {
                   
                };

            //Работы раковина
            var work2 = new List<Work>
                {
                   
                };

            //Работы фильтр
            var work3 = new List<Work>
                {
                    
                };

            //Работы Ванны
            var work4 = new List<Work>
                {
                   
                };

            //Работы Душевая кабина
            var work5 = new List<Work>
                {
                };

            //Работы коммуникации
            var work6 = new List<Work>
            {
            };
            
            //Работы подключение новой сантехники
            var work7 = new List<Work>
            {
            };

            // Сантехника--------------------------
            var categories = new List<Category>
            { 
                /////Сантехника 1
                };

            db.Categories.AddRange(categories);
            db.SaveChanges();
        }

        public void SeedElektrika(DataContext db)
        {
            //Работы электрика по мелочи
            var work1 = new List<Work>
                {
                    };

            //Работы черновые работы
            var work2 = new List<Work>
                {
                     };

            //Работы чистовые работы
            var work3 = new List<Work>
                {
                      };

            // Электрика--------------------------
            var categories = new List<Category>
            { 
                 };

            db.Categories.AddRange(categories);
            db.SaveChanges();
        }

        public void SeedOtoplenie(DataContext db)
        {
            //Работы бойлер
            var work1 = new List<Work>
                {
                    };

            //Работы радиаторы
            var work2 = new List<Work>
                {
                   };


            // Отопление--------------------------
            var categories = new List<Category>
            {
               };

            db.Categories.AddRange(categories);
            db.SaveChanges();
        }

        public void SeedKanalizatia(DataContext db)
        {
            //Работы механическая чистка канализации
            var work1 = new List<Work>
                {
                     };

            //Работы механическая чистка канализации
            var work2 = new List<Work>
                {
                  };

            // Канализация--------------------------
            var categories = new List<Category>
            {
                };

            db.Categories.AddRange(categories);
            db.SaveChanges();
        }
        
        public void SeedMasters(DataContext db)
        {
            var masters = new List<Master>
            {
                  };

            foreach (var work in db.Works)
            {
                work.Masters = masters;
            }

            db.Masters.AddRange(masters);
            db.SaveChanges();
        }

        public void SeedWorkOptions(DataContext db)
        {
            var workOptions = new List<WorkOption>
            {

            };
            db.WorkOptions.AddRange(workOptions);
            db.SaveChanges();

            var options = new List<Option>
            {
               
            };

            db.Options.AddRange(options);
            db.SaveChanges();
        }
    }
}