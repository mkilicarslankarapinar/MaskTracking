
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)

        {
            Person person1 = new Person();
            person1.FirstName = "Muhammet Kılıçarslan";
            person1.LastName = "Karapınar";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 12345678910;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



        }
    }
}