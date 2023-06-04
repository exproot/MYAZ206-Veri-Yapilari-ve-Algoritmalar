using SortAlgorithms;
using SortingAlgorithmsApp.DAL.Entities;
using System;

namespace SortingAlgorithmsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Secim yap:");
        Console.WriteLine("1. Bubble sort (Salary)");
        Console.WriteLine("2. Insertion Sort (FirstName)");
        Console.WriteLine("3. Merge Sort (LastName)");
        Console.WriteLine("4. Quick Sort (Salary)");
        string secim = Console.ReadLine();

        var employeeList = new List<Employee>();
        using(var db = new EmployeeContext()) {
            employeeList = db.Employees.ToList();
        }

        switch (secim) {
            case "1":
                var salaryList = new List<string>();

                foreach (var employee in employeeList) {
                    salaryList.Add(employee.Salary);
                }

                var array1 = salaryList.ToArray();
                BubbleSort.Sort(array1);

                foreach (var salary in array1) {
                    Console.WriteLine(salary);
                }
                break;
            case "2":
                var firstnameList = new List<string>();

                foreach (var employee in employeeList) {
                    firstnameList.Add(employee.FirstName);
                }

                var array2 = firstnameList.ToArray();
                InsertionSort.Sort(array2);

                foreach (var firstname in array2) {
                    Console.WriteLine(firstname);
                }
                break;
            case "3":
                var lastnameList = new List<string>();

                foreach (var employee in employeeList) {
                    lastnameList.Add(employee.LastName);
                }

                var array3 = lastnameList.ToArray();
                MergeSort.Sort(array3);

                foreach (var lastname in array3) {
                    Console.WriteLine(lastname);
                }
                break;
            case "4":
                var salaryList2 = new List<string>();

                foreach (var employee in employeeList) {
                    salaryList2.Add(employee.Salary);
                }

                var array4 = salaryList2.ToArray();
                Quicksort.Sort(array4);

                foreach (var salary in array4) {
                    Console.WriteLine(salary);
                }
                break;

            default:
                break;
        }

    }
}