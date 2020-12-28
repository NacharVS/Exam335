using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here...");
      


        private string _name;
        private string _surname;
        private int _paymant;
        private int _age;

        
        public string Regist(string newName, string newSurname, int year, int mouth, int day)
        {
            string akk = _surname + " " + _name + " " + _age + " ";
            if (_age >= 18)
            {
                newName = newName.Trim();
                var FL = newName[0];
                var OL = newName.Remove(0, 1);
                _name = FL.ToString().ToUpper() + OL.ToLower();
                newSurname = newSurname.Trim();
                var fl = newSurname[0];
                var ol = newSurname.Remove(0, 1);
                _surname = fl.ToString().ToUpper() + ol.ToLower();


                int now = DateTime.Now.Year;
                DateTime d = new DateTime(year, mouth, day);
                _age = now - d.Year;
             
                return akk;
            }
            else { Console.WriteLine("Вам нет 18    "); }
            return akk;


        }


        
        
        
    }
   

 
}
