using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesStudent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorPagesStudent.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesStudentContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        Name = "Bikendra Thapaliya",
                        Gender = "Male",
                        Class = 17,
                        DOB = DateTime.Parse("1997-10-13"),
                        Email = "thapaliyabikendra@gmail.com",
                        Address = "Syuchatar, Kathmandu"
                    },
                    new Student
                    {
                        Name = "Sudip Adhikari",
                        Gender = "Male",
                        Class = 17,
                        DOB = DateTime.Parse("1997-08-18"),
                        Email = "sudipadhikari@gmail.com",
                        Address = "Kalanki, Kathmandu"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
