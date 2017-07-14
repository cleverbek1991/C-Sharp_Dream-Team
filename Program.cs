using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDreamTeam> serverSide = new List<IDreamTeam>();
            Dilshod dilshod = new Dilshod();
            Eliza elize = new Eliza();
            Jason jason = new Jason();
            serverSide.Add(dilshod);
            serverSide.Add(elize);
            serverSide.Add(jason);
            
            List<IDreamTeam> clientSide = new List<IDreamTeam>();
            Azim azim = new Azim();
            Ollie ollie = new Ollie();
            Jordan jordan = new Jordan();
            clientSide.Add(azim);
            clientSide.Add(ollie);
            clientSide.Add(jordan);
            
            foreach (var item in serverSide)
            {
                item.Work();    
            }
            foreach (var item in clientSide)
            {
                item.Work();    
            }
        }

    }

    public interface IDreamTeam
    {
        string Speciality { get; set; }
        string FirstName {get; set; }
        string LastName {get; set; }
        string FullName {get;}

        void Work();
    }
    public class Dilshod: IDreamTeam
    {
        public string Speciality { get; set; } = "Server Side Developer";
        public string FirstName { get; set; } = "Dilshod";
        public string LastName { get; set; } = "Nur";
        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Lorem ipsum dolor sit amet.");
        }
    }

    public class Azim: IDreamTeam
    {
        public string Speciality { get; set; } = "Client Side Developer";
        public string FirstName { get; set; } = "Azim";
        public string LastName { get; set; } = "Sodikov";
        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Consectetur adipiscing elit");
        }
    }

    public class Eliza: IDreamTeam
    {
        public string Speciality { get; set; } = "Server Side Developer";
        public string FirstName { get; set; } = "Eliza";
        public string LastName { get; set; } = "Meeks";
        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        }
    }

    public class Jason: IDreamTeam
    {
        public string Speciality { get; set; } = "Programmer";
        public string FirstName { get; set; } = "Jason";
        public string LastName { get; set; } = "Smith";
        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Ut enim ad minim veniam.");
        }
    }

    public class Ollie: IDreamTeam
    {
        public string Speciality { get; set; } = "Web Developer";
        public string FirstName { get; set; } = "Ollie";
        public string LastName { get; set; } = "Osinusi";
        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
        }
    }

    public class Jordan: IDreamTeam
    {
        public string Speciality { get; set; } = "Web Designer";
        public string FirstName { get; set; } = "Jordan";
        public string LastName { get; set; } = "Haenens";
        public string FullName => $"{this.FirstName} {this.LastName}";
        public void Work()
        {
            Console.WriteLine("Excepteur sint occaecat cupidatat non proident.");
        }
    }
}
