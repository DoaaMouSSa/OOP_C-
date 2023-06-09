using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_op_overloading
{
   public class Rectangle
    {
        double height;
        double width;
        public Rectangle()
        {

        }
        public Rectangle(int h,int w)
        {
            this.height = h;
            this.width = w;
        }
       public void printDimensions()
        {
            Console.WriteLine("height = " + this.height + " , width = " + this.width);
        }
        public static void isEqual(Rectangle r1,Rectangle r2)
        {
            if (r1 == r2) Console.WriteLine("equality");
            else if(r1 != r2) Console.WriteLine("NOT equality");
            else Console.WriteLine("Error");
        }
        public static void whatsGreater(Rectangle r1, Rectangle r2)
        {
            if (r1 >= r2) Console.WriteLine("r1 is Greater");
            else if (r1 <= r2) Console.WriteLine("r2 is Grater");
            else Console.WriteLine("Error");
        }
        /*****************arithmetc operation*************/
        public static Rectangle operator +(Rectangle r1,Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.height = r1.height + r2.height;
            r.width = r1.width + r2.width;
            return r;
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.height = r1.height - r2.height;
            r.width = r1.width - r2.width;
            return r;
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.height = r1.height * r2.height;
            r.width = r1.width * r2.width;
            return r;
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.height = r1.height / r2.height;
            r.width = r1.width / r2.width;
            return r;
        }
        public static Rectangle operator %(Rectangle r1, Rectangle r2)
        {
            Rectangle r = new Rectangle();
            r.height = r1.height % r2.height;
            r.width = r1.width % r2.width;
            return r;
        }

        /*****************unary increment*************/

        public static Rectangle operator ++(Rectangle r)
        {
            r.height++;
            r.width++;
            return r;
        }

        /*****************unary decrement*************/

        public static Rectangle operator --(Rectangle r)
        {
            r.height--;
            r.width--;
            return r;
        }

        /*****************relational operations*************/
        public static bool operator ==(Rectangle r1,Rectangle r2)
        {
            bool isEqual = false;
            if(r1.height==r2.height && r1.width == r2.width)
            {
                isEqual = true;
            }
            return isEqual;
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            bool isEqual = false;
            if (r1.height != r2.height || r1.width != r2.width)
            {
                isEqual = true;
            }
            return isEqual;
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            bool isGreater = false;
            if (r1.height >= r2.height && r1.width >= r2.width)
            {
                isGreater = true;
            }
            return isGreater;
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            bool isSmaller = false;
            if (r1.height <= r2.height && r1.width <= r2.width)
            {
                isSmaller = true;
            }
            return isSmaller;
        }
        /*****************implicit cast*************/

        public static implicit operator Rectangle(int[] x)
        {
            Rectangle r = new Rectangle();
            r.height = x[0];
            r.width = x[1];
            return r;
        }
        /*****************explicit cast*************/

        public static explicit operator double[](Rectangle r)
        {
            double[] x=new double[2]; 
             x[0]= r.height;
            x[1]= r.width;
            return x;
        }
    }
}
