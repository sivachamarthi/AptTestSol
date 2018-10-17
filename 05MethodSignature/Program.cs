using System;
using System.Threading.Tasks;

namespace _05MethodSignature
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var (averageSalary, numberOfEmployee) = await SomeCalulationAsync(0L, 10L, 0L == 10L);

            Console.WriteLine($"Average Salary : {averageSalary}, number of employees {numberOfEmployee}");
        }


        /// <summary>
        /// Calculation to return average salary and employee count 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static async Task<(double avgSalary, int employeeCount)> SomeCalulationAsync(long a, long b, bool c)
        {
            //Some Calculation Async
            await Task.Run(() => Console.WriteLine());

            return (40.5, 20);
        }
    }
}
