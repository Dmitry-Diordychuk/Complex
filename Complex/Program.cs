using System;
using static System.Console;

namespace Complex
{
    class Program
    {
        static void Main( string[] args )
        {
            WriteLine( "***********Комплексные числа Тестирование**************" );
            
            WriteLine( $"Создание экземпляра класса ComplexNumber:" );
            //+
            ComplexNumber testInstancePlus = new ComplexNumber( "1+2i" );
            WriteLine( $"{testInstancePlus}" );
            //-
            ComplexNumber testInstanceMinus = new ComplexNumber( "1-2i" );
            WriteLine( $"{testInstanceMinus}" );
            ComplexNumber testInstanceMinus2 = new ComplexNumber( "-1-2i" );
            WriteLine( $"{testInstanceMinus2}" );
            ComplexNumber testInstanceMinus3 = new ComplexNumber( "-1+2i" );
            WriteLine( $"{testInstanceMinus3}" );

            WriteLine( $"Сложение двух комплексных чисел и вычитание:" );
            ComplexNumber sum = new ComplexNumber( "1+2i" ) + new ComplexNumber( "3+4i" );
            WriteLine( $"{sum}" );
            //Вычитание двух комплексных чисел
            ComplexNumber dif = new ComplexNumber( "1+2i" ) - new ComplexNumber( "3+4i" );
            WriteLine( $"{dif}" );
            WriteLine( $"Умножение и деление:" );
            ComplexNumber mul = new ComplexNumber( "1+2i" ) * new ComplexNumber( "3+4i" );
            WriteLine( $"{mul}" );
            ComplexNumber div = new ComplexNumber( "1+2i" ) / new ComplexNumber( "3+4i" );
            WriteLine( $"{div}" );
            WriteLine( $"Модуль комплексного числа:" );
            double abs = ComplexNumber.Abs( new ComplexNumber( "1+2i" ) );
            WriteLine( $"{abs}" );
            WriteLine( $"Возведение в степень 2:" );
            ComplexNumber pow = ComplexNumber.Pow( new ComplexNumber( "2+3i" ));
            WriteLine( $"{pow}" );
            WriteLine( $"Корень из числа:" );
            ComplexNumber sqrt = ComplexNumber.Sqrt( new ComplexNumber( "1+2i" ) );
            WriteLine( $"{sqrt}" );
        }
    }
}
