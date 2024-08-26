using Assignment.Context;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext dbContext = new ITIDbContext();
            Student Student01 = new Student() { FName = "Amr", LName = "khaled" ,Age = 15 ,Address="123"};
            Student Student02 = new Student() { FName = "Ali", LName = "Mohamed", Age = 15, Address = "123" };
            Student Student03 = new Student() { FName = "Waael", LName = "Ahmed", Age = 15, Address = "123" };

            #region Create

            //dbContext.Students.Add(Student01);
            //dbContext.Students.Add(Student02);
            //dbContext.Students.Add(Student03);

            //dbContext.SaveChanges();
            #endregion

            #region Retreive

            //var StudentWithLNameMohamed = (from  student in dbContext.Students
            //              where student.LName == "Mohamed"
            //              select student).FirstOrDefault();
            //Console.WriteLine($"{StudentWithLNameMohamed.Id} - {StudentWithLNameMohamed.FName} {StudentWithLNameMohamed.LName}\n");

            #endregion

            #region Update

            //var StudentWithId6 = (from student in dbContext.Students
            //               where student.Id == 6
            //               select student).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(StudentWithId6).State);
            //StudentWithId5.Address = "456";
            //Console.WriteLine(dbContext.Entry(StudentWithId6).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(StudentWithId6).State);

            #endregion

            #region Delete

            //var StudentWithId5 = (from student in dbContext.Students
            //                      where student.Id == 5
            //                      select student).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(StudentWithId5).State);
            //dbContext.Students.Remove(StudentWithId5);
            //Console.WriteLine(dbContext.Entry(StudentWithId5).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(StudentWithId5).State);

            #endregion
        }
    }
}
