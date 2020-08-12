using System;
using System.Collections.Generic;
using Section10_Exercicio1.Entities;

namespace Section10_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n   Éoq of Section10 Employees list");

            Console.Write("\n   Enter the number of employees of the company: ");
            int EmployeesNumber = int.Parse(Console.ReadLine());

            List<Employee> EmployeesList = new List<Employee>();

            for (int i = 1; i <= EmployeesNumber; i++)
            {
                Console.Write("\n\n   Is this employee outsourced or not? Type Y to YES or N to NO ");
                char Answer = char.Parse(Console.ReadLine());

                while (Answer != 'y' && Answer != 'Y' && Answer != 'n' && Answer != 'N')
                {
                    Console.Write("\n   You've entered a invalid answer, please, try it again! ");
                    Console.Write("\n   Is this employee outsourced or not? Type Y to YES or N to NO ");
                    Answer = char.Parse(Console.ReadLine());
                }

                if (Answer == 'y' || Answer == 'Y')
                {
                    Console.Write($"\n   Type the {i} employee's name: ");
                    string EName = Console.ReadLine();

                    Console.Write($"\n   Type the {i} employee's contract hours of work: ");
                    int EHours = int.Parse(Console.ReadLine());

                    Console.Write($"\n   Type the {i} employee's contract value per hour of work: ");
                    double EValue = double.Parse(Console.ReadLine());

                    Console.Write($"\n   Type the {i} outsourced employee's additional charge ");
                    double EAddCharge = double.Parse(Console.ReadLine());

                    EmployeesList.Add(new OutsourceEmployee(EName, EHours, EValue, EAddCharge));
                }
                else if (Answer == 'n' || Answer == 'N')
                {
                    Console.Write($"\n   Type the {i} employee's name: ");
                    string EName = Console.ReadLine();

                    Console.Write($"\n   Type the {i} employee's contract hours of work: ");
                    int EHours = int.Parse(Console.ReadLine());

                    Console.Write($"\n   Type the {i} employee's contract value per hour of work: ");
                    double EValue = double.Parse(Console.ReadLine());

                    EmployeesList.Add(new Employee(EName, EHours, EValue));
                }
            }

            List<string> stringContainer = new List<string>();
            foreach (Employee employee in EmployeesList)
            {                
                Console.Write(employee);
                stringContainer.Add(employee.ToString());                
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"G:\CS TXT Files\Section10\\First\Relatory " + (EmployeesList.Count) + ".txt"))
                foreach (string line in stringContainer)
                {
                    file.WriteLine(line);
                }

            // FIRST QUESTION BELLOW

            Console.Write("\n\n   Do you wish to enter another group of employees? Type Y to YES or N to NO ");
            char Answer2 = char.Parse(Console.ReadLine());

            while (Answer2 != 'y' && Answer2 != 'Y' && Answer2 != 'n' && Answer2 != 'N')
            {
                Console.Write("\n   You've entered a invalid answer, please, try it again! ");
                Console.Write("\n   Do you wish to enter another group of employees? Type Y to YES or N to NO ");
                Answer2 = char.Parse(Console.ReadLine());
            }

            if (Answer2 == 'y' || Answer2 == 'Y')
            {
                Operations(EmployeesList);
            }
            else if (Answer2 == 'n' || Answer2 == 'N')
            {
                Console.WriteLine("\n   The end ");
            }
            
            // Operations Method bellow 

            static void Operations(List<Employee> thatEmployeeList)
            {
                int ContinueIt = 1;

                while(ContinueIt == 1)
                {
                    Console.Write("\n   Enter the number of employees of the company: ");
                    int EmployeesNumber = int.Parse(Console.ReadLine());                     

                    for (int i = 1; i <= EmployeesNumber; i++)
                    {
                        Console.Write("\n\n   Is this employee outsourced or not? Type Y to YES or N to NO ");
                        char Answer = char.Parse(Console.ReadLine());

                        while (Answer != 'y' && Answer != 'Y' && Answer != 'n' && Answer != 'N')
                        {
                            Console.Write("\n   You've entered a invalid answer, please, try it again! ");
                            Console.Write("\n   Is this employee outsourced or not? Type Y to YES or N to NO ");
                            Answer = char.Parse(Console.ReadLine());
                        }

                        if (Answer == 'y' || Answer == 'Y')
                        {
                            Console.Write($"\n   Type the {i} employee's name: ");
                            string EName = Console.ReadLine();

                            Console.Write($"\n   Type the {i} employee's contract hours of work: ");
                            int EHours = int.Parse(Console.ReadLine());

                            Console.Write($"\n   Type the {i} employee's contract value per hour of work: ");
                            double EValue = double.Parse(Console.ReadLine());

                            Console.Write($"\n   Type the {i} outsourced employee's additional charge ");
                            double EAddCharge = double.Parse(Console.ReadLine());

                            thatEmployeeList.Add(new OutsourceEmployee(EName, EHours, EValue, EAddCharge));
                        }
                        else if (Answer == 'n' || Answer == 'N')
                        {
                            Console.Write($"\n   Type the {i} employee's name: ");
                            string EName = Console.ReadLine();

                            Console.Write($"\n   Type the {i} employee's contract hours of work: ");
                            int EHours = int.Parse(Console.ReadLine());

                            Console.Write($"\n   Type the {i} employee's contract value per hour of work: ");
                            double EValue = double.Parse(Console.ReadLine());

                            thatEmployeeList.Add(new Employee(EName, EHours, EValue));
                        }
                    }
                                        
                    List<string> stringContainer = new List<string>();
                    foreach (Employee employee in thatEmployeeList)
                    {                        
                        stringContainer.Add(employee.ToString());
                        Console.Write(employee);                                                                   
                    }

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"G:\CS TXT Files\Section10\Relatory " + (thatEmployeeList.Count) + ".txt"))
                    foreach (string line in stringContainer)
                    {
                        file.WriteLine(line);
                    }
                   
                    // LOOP QUESTION

                    Console.Write("\n\n   Do you wish to enter another group of employees? Type Y to YES or N to NO ");
                    char Answer2 = char.Parse(Console.ReadLine());

                    while (Answer2 != 'y' && Answer2 != 'Y' && Answer2 != 'n' && Answer2 != 'N')
                    {
                        Console.Write("\n   You've entered a invalid answer, please, try it again! ");
                        Console.Write("\n   Do you wish to enter another group of employees? Type Y to YES or N to NO ");
                        Answer2 = char.Parse(Console.ReadLine());
                    }

                    if(Answer2 == 'y' || Answer2 == 'Y')
                    {
                    }
                    else if(Answer2 == 'n' || Answer2 == 'N')
                    {
                        ContinueIt = 0;
                    }                    
                }

                Console.WriteLine();
            }
        }
    }
}
