using System;
//using System.Collections;
using System.Collections.Generic;
//using System.IO;
//using StudentMinMax;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student studentNameAndScores = new Student();
            students = studentNameAndScores.GetStudentScoresFromFileStudentData();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }
            Console.ReadLine();

        }

        //// get data from file
        //private List<Student> GetStudentScoresFromFileStudentData()
        //{
        //    //Declaring a List that will contain each student detail stored line by line
        //    List<Student> students = new List<Student>();
        //    Student student = new Student();
        //    //Reading the text file line by line
        //    //Storing each student detail in Student type student
        //    foreach (string line in File.ReadLines(@"Solution Items\studentdata.txt"))
        //    {
        //        string[] eachStudentDetail = line.Split(" ");

        //        for(int i = 0; i < eachStudentDetail.Length; i++)
        //        {
        //            if (i == 0)
        //                student.Name = eachStudentDetail[0];
        //            //else (i > 0)
        //            //{
        //            //    ArrayList tempScore = new ArrayList();
        //            //    tempScore.Add[i];

        //            //    student.Scores = 
        //            //}
                        

        //        }
                
        //       // string[] tempScoreStringArray = eachStudentDetail[1; eachStudentDetail.Length];
        //        Console.WriteLine(student);
        //    }
        //    students.Add(student);
        //    Console.WriteLine(students);
        //    Console.ReadLine();


        //    return students;
        
    }
}