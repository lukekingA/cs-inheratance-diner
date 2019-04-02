using System;
using System.Collections.Generic;
using inheratanceDiner.Models;

namespace inheratance_diner {
    class Program {
        static void Main (string[] args) {
            Server Ted = new Server ("Ted", "3456.Serv");
            Supervisor Porter = new Supervisor ("Porter", "1234.Super");
            Manager Mark = new Manager ("Mark", "4356.Man", 1234);

            List<Employee> Employees = new List<Employee> () {
                Ted,
                Porter,
                Mark
            };

            Employees.ForEach (e => {
                System.Console.Write ($"{e.Name}: ");
                e.Discount ();

                if (e is Manager) {
                    System.Console.Write ("Manager ");
                    Manager m = (Manager) e;
                    m.Delegate ();
                }
            });
        }
    }
}