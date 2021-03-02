using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBike bike = new SportBike();

            //Call consts- 1/6
            Console.WriteLine(SportBike.constPublic);

            //Call field- 2/6
            bike.fieldPublic = 5000;
            bike.FieldPrivateProtected = 123;

            //Call method - 3/6
            bike.MethodPublic();

            //Call properties - 1/6
            bike.propertiesPublic = 5000;
            Console.WriteLine(bike.propertiesPublic);

        }
    }
}
