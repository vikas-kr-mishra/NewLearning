using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); //Cant intialise abstract class shape!!
            var circle = new Circle();

            circle.Draw();

            var rectangle = new Rectangle();

            rectangle.Draw();
        }
    }
}
