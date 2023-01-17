using DocumentLib.Attributes;
using DocumentLib.Domain;
using DocumentLib.UI;

namespace Documementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DocumentAttribute.GetDocs(typeof(SamplePerson));


            Implementation.GetDocs(typeof(BezaoTrainee));

            //Implementation.GetDocs(typeof(Bezao));
            BezaoTrainee trainee = new BezaoTrainee();
            Console.WriteLine(trainee.StudentsAction("Ada"));
            
        }
    }
}