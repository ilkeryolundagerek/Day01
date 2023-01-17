using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabirimler
{
    //Interface (arabirim): Genel olarak class yapılarını da gruplamak ve/veya kullanmasını zorunlu kıldığımız mülkleri tanımlamak için kullanırız. Hiçbir mülke erişim belirleyici tanımlanmaz, metotların gövdesi (body) yazılmaz.
    //Bu yapılar abstrac olarak tanımlanmıştır, yani soyut yapılardır, new operatörü ile örneklenemez.
    //Bir sınıfa istediğimiz kara arabirim bağlayabiliriz.
    public interface IShape
    {
        /// <summary>
        /// Çevre hesaplanır.
        /// </summary>
        /// <returns></returns>
        double CalculatePerimeter();
    }

    public class Rectangle : IShape
    {
        private double a;
        private double b;
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculatePerimeter()
        {
            return 2 * (a + b);
        }
    }
    public class Square : IShape
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }

        public double CalculatePerimeter()
        {
            return 41 * a;
        }
    }
    public class Circle : IShape
    {
        private double r;
        private double pi;

        //Parametre yapısında o parametrenin girilmesinin zorunlu olmadığı, girilmediğinde de temel bir değerin otomatik tanımlanmasını sağlama yöntemi aşağıdaki gibidir.
        //double pi = Math.PI
        public Circle(double r, double pi = Math.PI)
        {
            this.r = r;
            this.pi = pi;
        }

        public double CalculatePerimeter()
        {
            return 2 * r * pi;
        }
    }
}
