using System;

namespace ComplexAlgebra
{
    class Program
    {
        /// <summary>
        /// Test method for the Complex class
        /// </summary>
        /// 
        /// TODO: uncomment the commented code, if any
        static void Main(string[] args)
        {
            var zero = new Complex(0, 0);
            var one = new Complex(1, 0);
            var i = new Complex(0, 1);
            var oneSumI = one.Sum(i);
            var iSumOne = i.Sum(one);
            var oneMinI = one.Sum(i).Complement();
            var MinI = oneMinI.Min(one);
            
            Console.WriteLine(zero.RealPart); // 0
            Console.WriteLine(zero.ImPart); // 0
            Console.WriteLine(zero.GetModule); // 0
            Console.WriteLine(zero.GetPhase); // 0
            Console.WriteLine(zero.ToString()); // 0
            
            Console.WriteLine("---");
            
            Console.WriteLine(one.RealPart); // 1
            Console.WriteLine(one.ImPart); // 0
            Console.WriteLine(one.GetModule); // 1
            Console.WriteLine(one.GetPhase); // 0
            Console.WriteLine(one.ToString()); // 1
            
            Console.WriteLine("---");
            
            Console.WriteLine(i.RealPart); // 0
            Console.WriteLine(i.ImPart); // 1
            Console.WriteLine(i.GetModule); // 1
            Console.WriteLine(i.GetPhase); // 1,5707963267948966 (Math.PI / 2)
            Console.WriteLine(i.ToString()); // i
            
            Console.WriteLine("---");
            
            Console.WriteLine(oneSumI.RealPart); // 1
            Console.WriteLine(oneSumI.ImPart); // 1
            Console.WriteLine(oneSumI.GetModule); // 1,4142135623730951 (Math.Sqrt(2))
            Console.WriteLine(oneSumI.GetPhase); // 0,7853981633974483 (Math.PI / 4)
            Console.WriteLine(oneSumI.ToString()); // 1 + i
            Console.WriteLine(oneSumI.Equals(iSumOne)); // true
            
            Console.WriteLine("---");
            
            Console.WriteLine(iSumOne.RealPart); // 1
            Console.WriteLine(iSumOne.ImPart); // 1
            Console.WriteLine(iSumOne.GetModule); // 1,4142135623730951 (Math.Sqrt(2))
            Console.WriteLine(iSumOne.GetPhase); // 0,7853981633974483 (Math.PI / 4)
            Console.WriteLine(iSumOne.ToString()); // 1 + i
            Console.WriteLine(iSumOne.Equals(oneSumI)); // true
            
            Console.WriteLine("---");
            
            Console.WriteLine(oneMinI.RealPart);  // 1
            Console.WriteLine(oneMinI.ImPart);  // -1
            Console.WriteLine(oneMinI.GetModule);  // 1,4142135623730951 (Math.Sqrt(2))
            Console.WriteLine(oneMinI.GetPhase);  // -0,7853981633974483 (-Math.PI / 4)
            Console.WriteLine(oneMinI.ToString());  // 1 - i
            
            Console.WriteLine("---");
            
            Console.WriteLine(MinI.RealPart);  // 0
            Console.WriteLine(MinI.ImPart);  // -1
            Console.WriteLine(MinI.GetModule);  // 1
            Console.WriteLine(MinI.GetPhase);  // -1,5707963267948966 (Math.PI / 2)
            Console.WriteLine(MinI.ToString());  // -i
        }
    }
}