using System;
using System.Collections.Generic;
using LinqTutorials;
using LinqTutorials.Models;

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Task 1: Backend programmers");
        var task1Result = LinqTasks.Task1();
        foreach (var emp in task1Result)
        {
            Console.WriteLine($"{emp.Ename} - {emp.Job}");
        }

        // Task 2
        Console.WriteLine("\nTask 2: Frontend programmers with salary > 1000, ordered by name descending");
        var task2Result = LinqTasks.Task2();
        foreach (var emp in task2Result)
        {
            Console.WriteLine($"{emp.Ename} - {emp.Job} - {emp.Salary}");
        }

        // Task 3
        Console.WriteLine("\nTask 3: Max salary");
        var task3Result = LinqTasks.Task3();
        Console.WriteLine(task3Result);

        // Task 4
        Console.WriteLine("\nTask 4: Employees with max salary");
        var task4Result = LinqTasks.Task4();
        foreach (var emp in task4Result)
        {
            Console.WriteLine($"{emp.Ename} - {emp.Job} - {emp.Salary}");
        }

        // Task 5
        Console.WriteLine("\nTask 5: Employee names and jobs");
        var task5Result = LinqTasks.Task5();
        foreach (var emp in task5Result)
        {
            Console.WriteLine($"{emp}");
        }

        // Task 6
        Console.WriteLine("\nTask 6: Employees and their department names");
        var task6Result = LinqTasks.Task6();
        foreach (var item in task6Result)
        {
            Console.WriteLine($"{item}");
        }

        // Task 7
        Console.WriteLine("\nTask 7: Job count");
        var task7Result = LinqTasks.Task7();
        foreach (var item in task7Result)
        {
            Console.WriteLine($"{item}");
        }

        // Task 8
        Console.WriteLine("\nTask 8: Is there any backend programmer?");
        var task8Result = LinqTasks.Task8();
        Console.WriteLine(task8Result);

        // Task 9
        Console.WriteLine("\nTask 9: Latest hired frontend programmer");
        var task9Result = LinqTasks.Task9();
        Console.WriteLine($"{task9Result.Ename} - {task9Result.HireDate}");

        // Task 10
        Console.WriteLine("\nTask 10: Employee names and jobs with 'Brak wartości'");
        var task10Result = LinqTasks.Task10();
        foreach (var item in task10Result)
        {
            Console.WriteLine($"{item}");
        }

        // Task 11
        Console.WriteLine("\nTask 11: Departments with more than 1 employee");
        var task11Result = LinqTasks.Task11();
        foreach (var item in task11Result)
        {
            Console.WriteLine($"{item}");
        }

        // Task 12
        Console.WriteLine("\nTask 12: Employees with subordinates");
        var task12Result = LinqTasks.Task12();
        foreach (var emp in task12Result)
        {
            Console.WriteLine($"{emp.Ename} - {emp.Salary}");
        }

        // Task 13
        Console.WriteLine("\nTask 13: Odd occurrence");
        int[] arr = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
        var task13Result = LinqTasks.Task13(arr);
        Console.WriteLine(task13Result);

        // Task 14
        Console.WriteLine("\nTask 14: Departments with 5 or 0 employees, ordered by name");
        var task14Result = LinqTasks.Task14();
        foreach (var dept in task14Result)
        {
            Console.WriteLine($"{dept.Dname}");
        }
    }
}
