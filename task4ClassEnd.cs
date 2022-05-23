using System;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {

            User person1 = new User
            {
                Name = "Konul",
                Password = "Ko03#",
                SurName = "Huseynli",
                FatherName = "Ruslan",
                gmail = "hk03@gmail.com",
                num = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },

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
        public int[] num;
        public bool IsPasswordValid()
        {
            if (Password.Length < 6)
            {
                return false;
                bool success = false;
                foreach (var item in Password)

                {
                    foreach (var item2 in Name)
                    {
                        if (item == item2)
                        {
                            return false;
                            if (int.TryParse(item.ToString(), out int x))
                            {
                                success = true;
                                //if (success == false)
                                   

                            }

                        }


                    }
                 

                }

            }
            return false;
        }
    }
}


