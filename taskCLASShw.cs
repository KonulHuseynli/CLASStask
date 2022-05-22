using System;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taskClass = { 2, 9, 4, 3, 5, 1, 7 };
            ArraySort(taskClass);
            foreach (var elem in taskClass)
            {
                Console.WriteLine(elem);
            }
            static void ArraySort(int [] taskClass)
            {
                int sort = 0;

                for (int i = 0; i <= taskClass.Length - 1; i++)
                {
                    for (int j = i + 1; j < taskClass.Length; j++)
                    {
                        if (taskClass[i] > taskClass[j])
                        {
                            sort = taskClass[i];
                            taskClass[i] = taskClass[j];
                            taskClass[j] = sort;
                        }
                    }
                }



            }
        }

    }
}
    
