using System;
using System.Collections.Generic;
using System.Text;

public class ClassroomManager
{
    public const int k_MaxStudent = 5;
    public static int totalClassroomNumber;

    public readonly string classroomName;
    
    private string[] studentsName;
    private int currentStudent;

    public ClassroomManager(string classroomName)
    {
        this.classroomName = classroomName;
        currentStudent = 0;
        studentsName = new string[k_MaxStudent];

        totalClassroomNumber++;
    }

    public void AddStudent(string name)
    {
        if (currentStudent >= 5)
        {
            Console.WriteLine("오류: 정원 초과");
            return;
        }

        studentsName[currentStudent] = name;
        currentStudent++;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"===  {classroomName} 학생 목록 ({currentStudent}/{k_MaxStudent}) ===");

        for (int i = 0; i < currentStudent; i++)
        {
            Console.WriteLine($"{i}. {studentsName[i]}");
        }
    }

    static public void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {totalClassroomNumber}");
    }
}