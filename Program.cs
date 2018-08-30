using System;
using System.Collections.Generic;


namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> serverside = new List<Student>() {
                new Natasha(),
                new William(),
                new Seth()
            };

            List<Student> clientSide = new List<Student>(){
                new Leah(),
                new Vik(),
                new Elliot()
            };

            foreach (Student student in serverside)
            {
                Console.WriteLine(student.Work());
            }

            foreach (Student student in clientSide)
            {
                Console.WriteLine(student.Work());

            }


        }
    }
}
