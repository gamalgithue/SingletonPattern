using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp17
{


    class Visitor
    {
        private static Visitor _instance;
        public static int countvisitor;
        private Visitor()
        {
            countvisitor = 0;
        }
        public static Visitor getInstance()
        {
            if (_instance == null)
            {
                _instance = new Visitor();

            }
            countvisitor++;

            return _instance;

        }
        public void IncrementVisitor()
        {
            countvisitor++;
            Console.WriteLine("Visitor count increased to: " + countvisitor);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Visitor s1 = Visitor.getInstance();
            Visitor s2 = Visitor.getInstance();
            Visitor s3 = Visitor.getInstance();


            Console.WriteLine("current counter is: " + Visitor.countvisitor);




        }
    }
}