using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    // Zadanie 3
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAdress { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate,
            string emailAdress)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EmailAdress = emailAdress;

        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public bool IsAdult()
        {
            if (DateTime.Now.Year - BirthDate.Year >= 18)
            {
                if (DateTime.Now.Month < BirthDate.Month)
                {
                    return true;
                }
                else if (DateTime.Now.Month == BirthDate.Month)
                {
                    if (DateTime.Now.Day <= BirthDate.Day)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }


            }
            else { return false; }
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
