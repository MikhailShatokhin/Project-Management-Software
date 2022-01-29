using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class UserInterface
    {
        //instance variable / class varaible
        public List<Department> departments = new List<Department>();

        public List<Employee> employees = new List<Employee>();

        public Dictionary<string, Project> projects = new Dictionary<string, Project>();

        public void Run()
        {
            // create some departments
            CreateDepartments();
            
            // print each department by name
            PrintDepartments();
            
            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private void CreateDepartments()
        {
            int[] departmentId = { 1, 2, 3 };
            string[] name = { "Marketing", "Sales", "Engineering" };

            for (int i = 0; i < departmentId.Length; i++)
            {
                Department department = new Department(departmentId[i], name[i]);
                departments.Add(department);
            }
        }

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            for (int i=0; i<departments.Count; i++)
            {
                Console.WriteLine(departments[i].Name);
            }
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Dean";
            employee1.LastName = "Johnson";
            employee1.Email = "djohnson@teams.com";
            employee1.Salary = 60000;
            employee1.Department = departments[2];
            employee1.HireDate = "08/21/2020";
            Employee employee2 = new Employee(2, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020");
            Employee employee3 = new Employee(3, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020");
            employee2.RaiseSalary(10);
            
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);

        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            for (int people = 0; people < employees.Count; people++)
            {
                Console.WriteLine(employees[people].FullName + " (" + employees[people].Salary +") " + employees[people].Department.Name);
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {
            Project project1 = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");
            //project1.TeamMembers = employees;
            projects[project1.Name] = project1;
            foreach (Employee n in employees)
            {
                if (n.Department.Name == "Engineering")
                {
                    
                    project1.TeamMembers.Add(n);
                    return;
                }
            }
        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {
            Project project2 = new Project("Marketing Landing Page", "Lead Capture Landing Page For Marketing", "10/10/2020", "10/17/2020");
           //project2.TeamMembers = employees;
           projects[project2.Name] = project2;
            foreach (Employee n in employees)
            {
                if (n.Department.Name == "Marketing")
                {
                    project2.TeamMembers.Add(n);
                    return;
                }
            }
        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");
            foreach(Project p in projects.Values)
            { 
                Console.WriteLine($"{p.Name}: {p.TeamMembers.Count}");
            }
        }
    } 
}
