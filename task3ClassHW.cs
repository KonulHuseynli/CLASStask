using System;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {

            Student person = new Student
            {
                HomeworkGrades = new int[] { 100, 100, 95,80,67 },
                ProjectGrades = new int[] { 96, 100, 95 ,75,90},
                FinalGrade = 69,
                Devamiyyet = new bool[] { true, false, true, true, false},
            };
            person.YourPassed();
        }
    }
    class Student
    {
        public int[] HomeworkGrades;
        public int[] ProjectGrades;
        public int FinalGrade;
        public bool[] Devamiyyet;
        public void YourPassed()
        {
            int SumHomeWork = 0;
            int counterHomeWork=0;
            int AvgHomeWork = 0;
            for (int i = 0; i < HomeworkGrades.Length; i++)
            {
                SumHomeWork += HomeworkGrades[i];
                counterHomeWork++;
                AvgHomeWork = SumHomeWork / counterHomeWork;
            }
            int SumProjectGrades = 0;
            int counterProjectGrades = 0;
            int AvgProjectGrades = 0;
            for (int j = 0; j < ProjectGrades.Length; j++)
            {
                SumProjectGrades += ProjectGrades[j];
                counterProjectGrades++;
                AvgProjectGrades = SumProjectGrades / counterProjectGrades;
            }
            int SumDTrue = 3;

            int AvgD = 0;
            for (int k = 0; k < Devamiyyet.Length; k++)
            {
                AvgD = (SumDTrue / Devamiyyet.Length) * 100;

            }
            int endresult = (AvgHomeWork * 25 + AvgProjectGrades * 25 + AvgD * 10 + FinalGrade * 40) / 100;
            if (endresult > 90)
            {
                Console.WriteLine("HighHonour");
            }
            else if (endresult > 80)
            {
                Console.WriteLine("Honour");
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }
    }
}
