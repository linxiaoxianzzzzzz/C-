using System;

namespace HW3_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    internal class CPersonData {
        public string name { get; set; }
        public string degree { get; set; }
        private string p_id  { get; set; }

        private int salary { get; set; }
      public  CPersonData() { 
        salary = 0;
            name = "~~~~~~";
            degree = "~~~~~~";
            p_id = "~~~~~~";
        }
        public CPersonData(string name, string degree, string p_id, int salary)
        {
            this.name = name;
            this.degree = degree;
            this.p_id = p_id;
            this.salary = salary;
        }
        public int getsalary() { return salary; }
    }

    class CPersonAccount {
        private CPersonData[] personArr=new CPersonData[5] ;

        internal void inputdata() {
            string salaryString= Console.ReadLine();
            string degree= Console.ReadLine();
            string p_id= Console.ReadLine();
           var salary = int.Parse(salaryString);
            CPersonData pwe=new  CPersonData(salaryString, degree, p_id, salary);  
                     
        }
    }
}
