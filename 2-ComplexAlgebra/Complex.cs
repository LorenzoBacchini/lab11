using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
        public double RealPart { get; }
        public double ImPart { get; }

        public Complex(double realPart, double imPart)
        {
            RealPart = realPart;
            ImPart = imPart;
        }

        public double GetModule => Math.Sqrt(RealPart*RealPart + ImPart*ImPart);

        public double GetPhase => Math.Atan2(ImPart, RealPart);

        public Complex Complement() => new Complex(RealPart, -ImPart);

        public Complex Sum(Complex other) => new Complex(RealPart + other.RealPart, ImPart + other.ImPart);

        public Complex Min(Complex other) => new Complex(RealPart - other.RealPart, ImPart - other.ImPart);

        public override string ToString()
        {
            if (ImPart == 0.0) return RealPart.ToString();
            var imAbs = Math.Abs(ImPart);
            var imValue = imAbs == 1.0 ? "" : imAbs.ToString();
            string sign;
            if (RealPart == 0d)
            {
                sign = ImPart > 0 ? "" : "-";
                return sign + "i" + imValue;
            }

            sign = ImPart > 0 ? "+" : "-";
            return $"{RealPart} {sign} i{imValue}";
        }

        public override int GetHashCode() => HashCode.Combine(RealPart, ImPart);

        public override bool Equals(Object other)
        {
            if(other.GetType().Name.Equals("Complex"))
            {
                return Equals((Complex) other);
            }
            else
            {
                return false;
            }
        }

        private bool Equals(Complex other)
        {
            return RealPart == other.RealPart && ImPart == other.ImPart;
        }
    }
}