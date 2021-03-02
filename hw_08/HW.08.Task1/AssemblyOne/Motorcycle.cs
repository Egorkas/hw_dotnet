using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{

    //Класс с типом internal недоступен из других сборок. Единственная лазейка -InternalsVisibleToAttribute Class
    //(Specifies that types that are ordinarily visible only within the current assembly are visible to a specified assembly.)
    class MotorcycleInternal
    {
        // Consts
        private const int constPrivate = 0;
        private protected const int constPrivateProtected = 1;
        protected const int constProtected = 2;
        internal const int constInternal = 3;
        protected internal const int constProtectedInternal = 4;
        public const int constPublic = 5;

        // Fields
        private int fieldPrivate = 1;
        private protected int FieldPrivateProtected = 2;
        protected int fieldProtected = 3;
        internal int fieldInternal = 4;
        protected internal int fieldProtectedInternal = 5;
        public int fieldPublic = 6;

        // Properties
        private int propertiesPrivate { get => fieldPrivate; set => fieldPrivate = value; }
        private protected int propertiesPrivateProtected { get; set; }
        protected int propertiesProtected { get => fieldProtected; set => fieldProtected = value; }
        internal int propertiesInternal { get => fieldInternal; set => fieldInternal = value; }
        protected internal int propertiesProtectedInternal { get => fieldProtectedInternal; set => fieldProtectedInternal = value; }
        public int propertiesPublic { get => fieldPublic; set => fieldPublic = value; }

        // Methods
        private void MethodPrivate() { System.Console.WriteLine("MethodPrivate"); }
        private protected void MethodPrivateProtected() { System.Console.WriteLine("MethodPrivateProtected"); }
        protected void MethodProtected() { System.Console.WriteLine("MethodProtected"); }
        internal void MethodInternal() { System.Console.WriteLine("MethodInternal"); }
        protected internal void MethodProtectedInternal() { System.Console.WriteLine("MethodProtectedInternal"); }
        public void MethodPublic() { System.Console.WriteLine("MethodPublic"); }
    }

    public class MotorcyclePublic
    {
        // Consts
        private const int constPrivate = 1;
        private protected const int constPrivateProtected = 2;
        protected const int constProtected = 3;
        internal const int constInternal = 4;
        protected internal const int constProtectedInternal = 5;
        public const int constPublic = 6;

        // Fields
        private int fieldPrivate = 1;
        private protected int FieldPrivateProtected = 2;
        protected int fieldProtected = 3;
        internal int fieldInternal = 4;
        protected internal int fieldProtectedInternal = 5;
        public int fieldPublic = 6;

        // Properties
        private int propertiesPrivate { get => fieldPrivate; set => fieldPrivate = value; }
        private protected int propertiesPrivateProtected { get; set; }
        protected int propertiesProtected { get => fieldProtected; set => fieldProtected = value; }
        internal int propertiesInternal { get => fieldInternal; set => fieldInternal = value; }
        protected internal int propertiesProtectedInternal { get => fieldProtectedInternal; set => fieldProtectedInternal = value; }
        public int propertiesPublic { get => fieldPublic; set => fieldPublic = value; }

        // Methods
        private void MethodPrivate() { System.Console.WriteLine("MethodPrivate"); }
        private protected void MethodPrivateProtected() { System.Console.WriteLine("MethodPrivateProtected"); }
        protected void MethodProtected() { System.Console.WriteLine("MethodProtected"); }
        internal void MethodInternal() { System.Console.WriteLine("MethodInternal"); }
        protected internal void MethodProtectedInternal() { System.Console.WriteLine("MethodProtectedInternal"); }
        public void MethodPublic() { System.Console.WriteLine("MethodPublic"); }
    }

}
