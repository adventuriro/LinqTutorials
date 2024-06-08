using LinqTutorials.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorials
{

    public static class LinqTasks
    {
        public static IEnumerable<Emp> Emps { get; set; }
        public static IEnumerable<Dept> Depts { get; set; }

        static LinqTasks()
        {
            var empsCol = new List<Emp>();
            var deptsCol = new List<Dept>();

            #region Load depts

            var d1 = new Dept
            {
                Deptno = 1,
                Dname = "Research",
                Loc = "Warsaw"
            };

            var d2 = new Dept
            {
                Deptno = 2,
                Dname = "Human Resources",
                Loc = "New York"
            };

            var d3 = new Dept
            {
                Deptno = 3,
                Dname = "IT",
                Loc = "Los Angeles"
            };

            deptsCol.Add(d1);
            deptsCol.Add(d2);
            deptsCol.Add(d3);
            Depts = deptsCol;

            #endregion

            #region Load emps

            var e1 = new Emp
            {
                Deptno = 1,
                Empno = 1,
                Ename = "Jan Kowalski",
                HireDate = DateTime.Now.AddMonths(-5),
                Job = "Backend programmer",
                Mgr = null,
                Salary = 2000
            };

            var e2 = new Emp
            {
                Deptno = 1,
                Empno = 20,
                Ename = "Anna Malewska",
                HireDate = DateTime.Now.AddMonths(-7),
                Job = "Frontend programmer",
                Mgr = e1,
                Salary = 4000
            };

            var e3 = new Emp
            {
                Deptno = 1,
                Empno = 2,
                Ename = "Marcin Korewski",
                HireDate = DateTime.Now.AddMonths(-3),
                Job = "Frontend programmer",
                Mgr = null,
                Salary = 5000
            };

            var e4 = new Emp
            {
                Deptno = 2,
                Empno = 3,
                Ename = "Paweł Latowski",
                HireDate = DateTime.Now.AddMonths(-2),
                Job = "Frontend programmer",
                Mgr = e2,
                Salary = 5500
            };

            var e5 = new Emp
            {
                Deptno = 2,
                Empno = 4,
                Ename = "Michał Kowalski",
                HireDate = DateTime.Now.AddMonths(-2),
                Job = "Backend programmer",
                Mgr = e2,
                Salary = 5500
            };

            var e6 = new Emp
            {
                Deptno = 2,
                Empno = 5,
                Ename = "Katarzyna Malewska",
                HireDate = DateTime.Now.AddMonths(-3),
                Job = "Manager",
                Mgr = null,
                Salary = 8000
            };

            var e7 = new Emp
            {
                Deptno = null,
                Empno = 6,
                Ename = "Andrzej Kwiatkowski",
                HireDate = DateTime.Now.AddMonths(-3),
                Job = "System administrator",
                Mgr = null,
                Salary = 7500
            };

            var e8 = new Emp
            {
                Deptno = 2,
                Empno = 7,
                Ename = "Marcin Polewski",
                HireDate = DateTime.Now.AddMonths(-3),
                Job = "Mobile developer",
                Mgr = null,
                Salary = 4000
            };

            var e9 = new Emp
            {
                Deptno = 2,
                Empno = 8,
                Ename = "Władysław Torzewski",
                HireDate = DateTime.Now.AddMonths(-9),
                Job = "CTO",
                Mgr = null,
                Salary = 12000
            };

            var e10 = new Emp
            {
                Deptno = 2,
                Empno = 9,
                Ename = "Andrzej Dalewski",
                HireDate = DateTime.Now.AddMonths(-4),
                Job = "Database administrator",
                Mgr = null,
                Salary = 9000
            };

            empsCol.Add(e1);
            empsCol.Add(e2);
            empsCol.Add(e3);
            empsCol.Add(e4);
            empsCol.Add(e5);
            empsCol.Add(e6);
            empsCol.Add(e7);
            empsCol.Add(e8);
            empsCol.Add(e9);
            empsCol.Add(e10);
            Emps = empsCol;

            #endregion
        }

      
        public static IEnumerable<Emp> Task1()
        {
            IEnumerable<Emp> result = Emps
                .Where(e => e.Job == "Backend programmer");
            return result;
        }

       
        public static IEnumerable<Emp> Task2()
        {
            IEnumerable<Emp> result = Emps
                .Where(e => e.Job == "Frontend programmer" && e.Salary > 1000)
                .OrderByDescending(e => e.Ename);
            return result;
        }


        public static int Task3()
        {
            int result = Emps
                .Max(e => e.Salary);
            return result;
        }

        
        public static IEnumerable<Emp> Task4()
        {
            IEnumerable<Emp> result = Emps
                .GroupBy(e => e.Salary)
                .OrderByDescending(e => e.Key)
                .First();
            return result;
        }

        
        public static IEnumerable<object> Task5()
        {
            IEnumerable<object> result = from e in Emps
                                         select new
                                         { Nazwisko = e.Ename, Praca = e.Job }
           ;
            return result;
        }

      
        public static IEnumerable<object> Task6()
        {
            IEnumerable<object> result = Emps
                .Join(Depts,
                e => e.Deptno,
                d => d.Deptno,
                (e, d) => new
                {
                    Ename = e.Ename,
                    Job = e.Job,
                    Dname = d.Dname,
                });
            return result;
        }

        
        public static IEnumerable<object> Task7()
        {
            IEnumerable<object> result = Emps
                .GroupBy(e => e.Job)
                .Select(e => new
                {
                    Praca = e.Key,
                    LiczbaPracownikow = e.Count()
                })
                ;
            return result;
        }

       
        public static bool Task8()
        {
            bool result = Emps
                .Any(e => e.Job == "Backend programmer");
            return result;
        }

     
        public static Emp Task9()
        {
            Emp result = Emps
                .Where(e => e.Job == "Frontend programmer")
                .OrderByDescending(e => e.HireDate)
                .First();
            return result;
        }

     
        public static IEnumerable<object> Task10()
        {
            var toUnion = new List<Object>()
            {
                new {
                    Ename = "Brak wartości", Job = (string)null, HireDate = (string)null
                }
            };

            var e = Emps.Select(e => new
            {
                Ename = e.Ename,
                Job = e.Job,
                HireDate = e.HireDate,
            });

            IEnumerable<object> result = e
                       .Union(toUnion);
            return result;
        }

       
        public static IEnumerable<object> Task11()
        {
            IEnumerable<object> result = Depts

                .GroupJoin(Emps,
                d => d.Deptno,
                e => e.Deptno,
                (d, e) => new
                {
                    Name = d.Dname,
                    numOfEmployees = e.Count()
                })
                .Where(g => g.numOfEmployees > 1)
                ;

            return result;
        }

        public static IEnumerable<Emp> Task12()
        {

            IEnumerable<Emp> result = CustomExtensionMethods.GetEmps(Emps);
            return result;
        }

     
        public static int Task13(int[] arr)
        {
            int result = 0;
            result = arr
                .GroupBy(n => n)
                .Where(g => g.Count() % 2 == 1)
                .First()
                .Select(g => g)
                .Single();
            return result;
        }

        public static IEnumerable<Dept> Task14()
        {
            IEnumerable<Dept> result = Depts
                .Where(d => Emps.Count(e => e.Deptno == d.Deptno) == 0 || Emps.Count(e => e.Deptno == d.Deptno) == 5)
                        .OrderBy(d => d.Dname);
            return result;
        }
    }

    public static class CustomExtensionMethods
    {
        public static IEnumerable<Emp> GetEmps(this IEnumerable<Emp> emps)
        {
            var result = emps.Where(e => emps.Any(emp => emp.Mgr != null && emp.Mgr.Empno == e.Empno))
                      .OrderBy(e => e.Ename)
                      .ThenByDescending(e => e.Salary);
            return result;
        }
        public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
        {
            var result = emps.Where(e => emps.Any(e2 => e2.Mgr == e.Mgr)).OrderBy(e => e.Ename).ThenByDescending(e => e.Salary);
            return result;
        }

    }
}
