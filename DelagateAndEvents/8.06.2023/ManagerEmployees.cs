using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._8._06._2023
{
    public class Employeer
    {
        public string login { get; set; }
        public string password { get; set; }
        public Employeer(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Employeer() : this("/","/")
        {
        }
        public void changeData()
        {
            Console.WriteLine("Enter login and password --->");

            login = Console.ReadLine();
            password = Console.ReadLine();
        }

        public override int GetHashCode()
        {
            return login.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Employeer other)
            {
                return login.Equals(other.login);
            }

            return false;
        }
    }
    public class ManagerEmployees
    {
        Dictionary<Employeer,int> employers;
        int countEmployeers;

        public void AddEmployeer(Employeer emp)
        {
            // if employer is exist already, then data about it will be change
            if (employers.TryAdd(emp, ++countEmployeers))
            {
                return;
            }

            employers.Remove(emp);
            emp.changeData();
            employers.Add(emp, countEmployeers);

        }

        public void RemoveEmployeer(Employeer emp)
        {
            employers.Remove(emp);
        }


        public string getPassword(string login)
        {
            Employeer res = new Employeer();
            for(int i = 0; i< employers.Count; i++)
            {
                if(employers.ElementAt(i).Key.login == login)
                {
                    return employers.ElementAt(i).Key.password;
                }
            }
            return "/";
        }
        

        
       






        }
    }
