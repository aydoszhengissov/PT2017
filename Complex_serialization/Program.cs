using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Complex_serialization
{
    public class Complex
    {
        public double A;
        public double B;
        public static Complex operator +(Complex l, Complex r)
        {
            Complex res = new Complex();
            res.A = l.A + r.A;
            res.B = l.B + r.B;
            return res;
        }
        public override string ToString()
        {
            return string.Format("{0} + {1}i", A, B);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F2();
        }

        private static void F2()
        {
            Complex c = new Complex();
            c.A = 6;
            c.B = 8;

            JsonSerializer js = new JsonSerializer();
            string res = JsonConvert.SerializeObject(c);

            FileStream fs = new FileStream("complex.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(res);

            sw.Close();
            fs.Close();

        }

        private static void F1()
        {
            FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Complex c = new Complex();
            c.A = 5;
            c.B = 9;
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, c);
            fs.Close();
        }
    }
}