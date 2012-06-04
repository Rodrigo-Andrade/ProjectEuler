using System;
using System.Linq;
using ProjectEuler.EulerProblems;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Type the Euler Problem number: ");
                var input = Console.ReadLine();

                if (input == null)
                    continue;

                if (input.ToLower() == "exit")
                    return;

                int problemNumber;

                if (!int.TryParse(input, out problemNumber))
                {
                    Console.WriteLine("Invalid Number");
                    continue;
                }

                var problem = GetEulerResolution(problemNumber);

                if (problem == null)
                {
                    Console.WriteLine("Problem not found");
                    continue;
                }

                Console.WriteLine(string.Format("The resolution to problem number {0} is : {1}", problemNumber, problem.Solution));
            }
        }

        private static IEulerProblem GetEulerResolution(int problemNumber)
        {
            var problemType = (from type in typeof (IEulerProblem).Assembly.GetTypes()
                               where type.Name == "EulerProblem" + problemNumber
                               select type).SingleOrDefault();

            return problemType != null ? (IEulerProblem)Activator.CreateInstance(problemType) : null;
        }
    }
}
