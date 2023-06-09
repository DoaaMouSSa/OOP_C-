using System;

namespace oop_op_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10,11);
            Rectangle r2 = new Rectangle(6, 6);
            Rectangle r3 = new Rectangle();
            Rectangle r4 = new Rectangle(100,101);
            r3 = r1 + r2;   //(16,17)
            r3.printDimensions();

            r3 = r1 - r2;   //(4,5)
            r3.printDimensions();

            r3 = r1 * r2;   //(60,66)
            r3.printDimensions();

            r3 = r1 / r2;   //(1,1)
            r3.printDimensions();

            r3 = r1 % r2;   //(4,5)
            r3.printDimensions();

            r4++;             //(101,102)
            r4.printDimensions();

            r4--;
            r4--;          //(99,100)
            r4.printDimensions();
            Rectangle.isEqual(r1, r2);
            Rectangle.whatsGreater(r1, r2);

            /*****************implicit cast*************/
            int[] y = { 200,300 };
            Rectangle r_imp = new Rectangle();
            r_imp = y;
            r_imp.printDimensions();

            /*****************explicit cast*************/
            double[] z =new double[2] ;
            Rectangle r_exp = new Rectangle(500,600);
            z = (double[])r_exp;
            Console.WriteLine(z[0]+ ",,,"+ z[1])
;
        }
    }
}
