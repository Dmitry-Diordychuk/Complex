using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Complex
{
    struct ComplexNumber
    {
        double A { get; set; }
        double B { get; set; }
        const double i2 = -1;

        public ComplexNumber( string str )
        {
            try
            {
                if( Double.TryParse( Regex.Match( str, @"-?\d+" ).Value, out double resultA ) )
                {
                    A = resultA;
                }
                else
                {
                    Console.WriteLine( "*Wrong input A*" );
                    A = 0;
                }

                if( Double.TryParse( Regex.Match( str, @"-?\d+" ).NextMatch().Value, out double resultB ) )
                {
                    B = resultB;
                }
                else
                {
                    Console.WriteLine( "*Wrong input B*" );
                    B = 0;
                }
            }
            catch (Exception ex)
            {
                A = 0;
                B = 0;
                Console.WriteLine( $"{ex.Message}" );
            }
        }
        
        ComplexNumber(int a, int b )
        {
            A = a;
            B = b;
        }

        public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2 )
        {
            ComplexNumber result = new ComplexNumber();
            result.A = cn1.A + cn2.A;
            result.B = cn1.B + cn2.B;
            return result;
        }

        public static ComplexNumber operator -( ComplexNumber cn1, ComplexNumber cn2 )
        {
            ComplexNumber result = new ComplexNumber();
            result.A = cn1.A - cn2.A;
            result.B = cn1.B - cn2.B;
            return result;
        }

        public static ComplexNumber operator *( ComplexNumber cn1, ComplexNumber cn2 )
        {
            ComplexNumber result = new ComplexNumber();
            result.A = cn1.A * cn2.A - cn1.B * cn2.B;
            result.B = cn1.B * cn2.A + cn1.A * cn2.B;
            return result;
        }

        public static ComplexNumber operator /( ComplexNumber cn1, ComplexNumber cn2 )
        {
            ComplexNumber result = new ComplexNumber();
            result.A = ( cn1.A * cn2.A + cn1.B * cn2.B ) / ( Math.Pow( cn2.A, 2 ) + Math.Pow( cn2.B, 2 ) );
            result.B = ( cn2.A * cn1.B - cn1.A * cn2.B ) / ( Math.Pow( cn2.A, 2 ) + Math.Pow( cn2.B, 2 ) );
            return result;
        }

        public static double Arg(ComplexNumber cn )
        {
            return Math.Atan( cn.B / cn.A );
        }

        public static double Abs(ComplexNumber cn )
        {
            return Math.Sqrt( Math.Pow( cn.A, 2 ) + Math.Pow( cn.B, 2 ) );
        }

        public static ComplexNumber Pow(ComplexNumber cn)
        {
            ComplexNumber result = new ComplexNumber();
            result.A = Math.Pow( cn.A, 2 ) - Math.Pow( cn.B, 2 );
            result.B = 2 * cn.A * cn.B;
            return result;
        }

        public static ComplexNumber Sqrt(ComplexNumber cn)
        {
            ComplexNumber result = new ComplexNumber();
            result.A = Math.Sqrt( ( ComplexNumber.Abs( cn ) + cn.A ) / 2 );
            result.B = Math.Sqrt( ( ComplexNumber.Abs( cn ) - cn.A ) / 2 );
            return result;
        }

        public override string ToString()
        {
            if(B > 0)
                return $"{A}+{B}i";
            else
                return $"{A}-{-B}i";
        }
    }
}
