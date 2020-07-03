﻿using Examen2;
using Examen2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2.Model
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ExamenDbContext(serviceProvider.GetRequiredService<DbContextOptions<ExamenDbContext>>()))
            {
                // Look for any movies.
                if (context.Persons.Any())
                {
                    return;   // DB has been seeded
                }

                context.Persons.AddRange(
                    new Person
                    {
                        Name = "Szabi",
                        Surname = "Iamandi",
                        PhoneNumber = "0748105660",
                        Email = "szabiadam@yahoo.com",
                    },

                    new Person
                    {
                        Name = "Karina",
                        Surname = "Iamandi",
                        PhoneNumber = "0747036039",
                        Email = "karina@yahoo.com",
                    },

                    new Person
                    {
                        Name = "Stefi",
                        Surname = "Iamandi",
                        PhoneNumber = "0740159322",
                        Email = "stefi@yahoo.com",
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
