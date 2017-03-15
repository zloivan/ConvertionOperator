using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertion_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(15.5,20.3);

            Console.WriteLine(a.ToFloat()+" "+(Double)a);
            a = 20;
            int temp = (int)a;

            Console.WriteLine(a+" "+temp);
        }
    }
    class A
    {
        double x, y;
        #region Contructors
        //Default
        public A() { x = 0; y = 0; }
        //with int parametr
        public A(int a)
            : this()
        {
            x = a; y = a;
        }
        //with double parametr
        public A(double a)
            : this()
        {
            x = a; y = a;
        }
        //with both int parametrs
        public A(int a, int b)
            : this()
        {
            x = a; y = b;
        }
        //with both double parametrs
        public A(double a, double b)
            : this()
        {
            x = a; y = b;
        } 
        #endregion
 
        public int ToInt32()
        {
            return (int)x + (int)y;
        }
        public double ToFloat()
        {
            return x + y;
        }
        public static implicit operator A(int a)
        {
            return new A(a);
        }
        public static implicit operator A(double a)
        {
            return new A(a);
        }
        public static explicit operator int(A a)
        {
            if (a.x > a.y) return (int)a.x;
            else
                if (a.x < a.y) return (int)a.y;
                else  return (int)a.x;
        }
        public static explicit operator double(A a)
        {
            if (a.x > a.y) return a.x;
            else
                if (a.x < a.y) return a.y;
                else return a.x;
        }
        public override string ToString()
        {
            return String.Format("({0},{1})",x,y);
        }

    }
    
}
