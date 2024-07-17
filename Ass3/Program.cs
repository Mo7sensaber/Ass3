using Ass3.binding;
using  Ass3.Polimerphism;

namespace Ass3
{
    
    internal class Program
    {
        public static void processEmployee(Employee employee)
        {
            if (employee != null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
        //public static void processEmployee(PartTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}
        #region overloading
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //} 

        //public static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        //public static double Sum(double x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sum(int x, int y,int z) {
        //return x + y + z;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region polimorphism(overloading)
            //int result = Sum(1, 2);
            //Console.WriteLine($"result = {result}");
            //result = Sum(1, 2,3);
            //Console.WriteLine($"result = {result}");
            //double result2 = Sum(1.2, 2.7);
            //Console.WriteLine($"result = {result2}");
            // result2 = Sum(1.2, 2);
            //Console.WriteLine($"result = {result2}");
            #endregion

            #region Override
            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.Func01();
            //typeA.Func02();
            //Console.WriteLine("=====================================");
            //TypeB typeB = new TypeB(1, 2);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.Func01();
            //typeB.Func02(); 
            #endregion

            #region binding
            //TypeA RefBase;
            //RefBase = new TypeB(1, 2);
            //RefBase.A = 10;
            //RefBase.Func01();
            //RefBase.Func02(); 
            #endregion

            #region binding
            ////FullTimeEmployee fullTimeEmployee= new FullTimeEmployee(10 ,"mohsen",21,2000);
            //PartTimeEmployee part = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Test",
            //    Age = 1,
            //    CountOFHour = 1,
            //    HourRate = 1,
            //};
            //processEmployee(part); 
            #endregion

            #region binding

            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.Func01();
            //typeA.Func02(); 
            #endregion
        }
    }
}