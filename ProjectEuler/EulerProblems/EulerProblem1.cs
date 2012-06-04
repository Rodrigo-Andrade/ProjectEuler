using System.Linq;

namespace ProjectEuler.EulerProblems
{
    public class EulerProblem1 : IEulerProblem
    {
        private readonly int _result;

        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public EulerProblem1()
        {
            _result = Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }

        public string Solution
        {
            get { return _result.ToString(); }
        }
    }
}