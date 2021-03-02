using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            MotorcyclePublic motorcycle = new MotorcyclePublic();

        //public: публичный, общедоступный класс или член класса.Такой член класса доступен из любого места в коде, а также из других программ и сборок.

        //private: закрытый класс или член класса.Представляет полную противоположность модификатору public. Такой закрытый класс или член класса доступен только из кода в том же классе или контексте.

        //protected: такой член класса доступен из любого места в текущем классе или в производных классах.При этом производные классы могут располагаться в других сборках.

        //internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке, однако он недоступен для других программ и сборок(как в случае с модификатором public).

        //protected internal: совмещает функционал двух модификаторов.Классы и члены класса с таким модификатором доступны из текущей сборки и из производных классов.

        //private protected: такой член класса доступен из любого места в текущем классе или в производных классах, которые определены в той же сборке.

            //Call Const - 3/6
            //Console.WriteLine(MotorcyclePublic.constProtected);
            //Console.WriteLine(MotorcyclePublic.constPrivate);
            //Console.WriteLine(MotorcyclePublic.constPrivateProtected);
            Console.WriteLine(MotorcyclePublic.constInternal);
            Console.WriteLine(MotorcyclePublic.constProtectedInternal);
            Console.WriteLine(MotorcyclePublic.constPublic);

            //Call field - 3/6
            Console.WriteLine(motorcycle.fieldInternal);
            Console.WriteLine(motorcycle.fieldProtectedInternal);
            Console.WriteLine(motorcycle.fieldPublic);

            //Call methods - 3/6
            motorcycle.MethodInternal();
            motorcycle.MethodProtectedInternal();
            motorcycle.MethodPublic();

            //Call properties - 3/6
            Console.WriteLine(string.Format("BEFORE CHANGES | Val 1 = {0}, val2 = {1}, val3 = {2}", motorcycle.propertiesInternal, motorcycle.propertiesProtectedInternal, motorcycle.propertiesPublic));
            motorcycle.propertiesInternal = 100;
            motorcycle.propertiesProtectedInternal = 100;
            motorcycle.propertiesPublic = 100;
            Console.WriteLine(string.Format("AFTER CHANGES | Val 1 = {0}, val2 = {1}, val3 = {2}", motorcycle.propertiesInternal, motorcycle.propertiesProtectedInternal, motorcycle.propertiesPublic));
            #endregion           

        }
    }
}
