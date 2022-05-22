using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {

            User person1 = new User
            {
                Name = "Konul",
                Password = "Ko3",
                SurName = "Huseynli",
                FatherName = "Ruslan",
                gmail = "hk03@gmail.com",
               // num=new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 },
            };
            Console.WriteLine(person1.IsPasswordValid());
        }
    }
    class User
    {
        public string Name;
        public string Password;
        public string SurName;
        public string FatherName;
        public string gmail;
       

        public bool IsPasswordValid()
        {
           
            //bool success = Int32.TryParse(Password, out int x);
            if (Password.Length < 6 &&  && Password.Contains(Name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
