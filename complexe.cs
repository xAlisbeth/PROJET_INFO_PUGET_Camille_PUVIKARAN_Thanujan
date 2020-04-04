using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFO_PUGET_Camille_PUVIKARAN_Thanujan
{
    class Complexe
    {
        double pr;//partie reelle
        double pi;//partie imaginaire

        public Complexe(double pr,double pi)
        {
            this.pr = pr;
            this.pi = pi;
        }

        public double Pr
        {
            get => pr;
            set
            {
                this.pr = value;
            }
        }
        public double Pi
        {
            get => this.pi;
            set => this.pi = value;
        }
        
        // methods
        
        /// <summary>
        /// Calculates the modulus of the complex number
        /// </summary>
        /// <returns>the modulus of the complex number</returns>
        public double Module()
        {
            return (float)(Math.Sqrt((Math.Pow(this.pr, 2)) + (Math.Pow(this.pi, 2))));
        }
        
        /// <summary>
        /// Calculates the argument of the complex number
        /// </summary>
        /// <returns>the argument of the complex number</returns>
        public double Argument()
        {
            double norme = Module();
            double cos = pr / norme;
            double arcos = (double)Math.Acos(cos);
            return arcos;
        }
        
        /// <summary>
        /// Calculates the sum of two complex numbers
        /// </summary>
        /// <param name="z">the second complex number used in the addition</param>
        /// <returns>the sum</returns>
        public Complexe Somme(Complexe z)
        {
            Complexe a = new Complexe(this.pr +z.pr,this.pi+z.pi);
            return a;
        }        
        
        /// <summary>
        /// WAHT
        /// </summary>
        /// <param name="k">WHAT</param>
        /// <returns>WHAT</returns>
        public Complexe Somme_reel(float k)
        {
            Complexe a = new Complexe(k + this.pr, this.pi);
            return a;
        }
        
        /// <summary>
        /// WAHT
        /// </summary>
        /// <param name="k">WHAT</param>
        /// <returns>WHAT</returns>
        public Complexe Somme_Imaginaire(float k)
        {
            Complexe a = new Complexe(this.pr, k + this.Pi);
            return a;
        }
        
        /// <summary>
        /// Calculates the multiplication of two complex numbers
        /// </summary>
        /// <param name="z">the second complex number used in the multiplication</param>
        /// <returns>the multiplication (a complex number)</returns>
        public Complexe Multiplication(Complexe z)
        {
            Complexe a = new Complexe(this.pr * z.pr - this.pi * z.pi,this.pr*z.pi+this.pi*z.pr);
            return a;
        }
        
        /// <summary>
        /// Calculates the square complex number.
        /// </summary>
        /// <returns>the result</returns>
        public Complexe Carre()
        {
            Complexe a = new Complexe(this.pr * this.pr - this.pi * this.pi, 2*this.pi * this.pr);
            return a;
        }
        
        /// <summary>
        /// Calculates the complex number cubed.
        /// </summary>
        /// <returns>the result</returns>
        public Complexe Cube()
        {
            Complexe a = new Complexe(Math.Pow(this.Pr,3) - 3*this.Pr*Math.Pow(this.pi,2), 3 * this.Pi * Math.Pow(this.pr, 2)- Math.Pow(this.Pi, 3));
            return a;
        }
        
        /// <summary>
        /// Calculates the sum of two complex numbers (static version)
        /// </summary>
        /// <param name="a">the first complex number used in the addition</param>
        /// <param name="b">the second complex number used in the addition</param>
        /// <returns>a complex number of their addition</returns>
        public static Complexe somme(Complexe a ,Complexe b)
        {
            Complexe h = new Complexe(a.pr+b.pr,a.pi+b.pi);
            return h;
        }
        
        /// <summary>
        /// WAHT
        /// </summary>
        /// <param name="k">WHAT</param>
        /// <returns>WHAT</returns>
        public Complexe multiplication_constante(float k)
        {
            Complexe a = new Complexe(k*this.Pr,k*this.Pi);
            return a;
        }
        
        /// <summary>
        /// Calculates the division of one complex number
        /// </summary>
        /// <param name="a">WHAT</param>
        /// <returns>WHAT</returns>
        public Complexe division(Complexe a)
        {
            Complexe b = new Complexe((this.pr*a.pr-this.pi*a.pi)/(Math.Pow(a.Module(),2)),(this.pr*a.pi+this.pi*a.pr)/(Math.Pow(a.Module(), 2)));
            return b;
        }
        
        /// <summary>
        /// WAHT
        /// </summary>
        /// <param name="a">WHAT</param>
        /// <param name="b">WHAT</param>
        /// <returns>WHAT</returns>
        public static Complexe Division(Complexe a,Complexe b)
        {
            Complexe az = new Complexe((a.pr * b.pr - a.pi * b.pi) / (Math.Pow(b.Module(), 2)), (a.pr * b.pi + a.pi * b.pr) / (Math.Pow(b.Module(), 2)));
            return az;
        }
    }
}
