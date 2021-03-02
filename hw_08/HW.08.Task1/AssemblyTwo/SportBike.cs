using System;
using System.Collections.Generic;
using System.Text;
using AssemblyOne;

namespace AssemblyTwo
{
    class SportBike : MotorcyclePublic
    {
        //Доступность поля protected из класса потомка. 
        public int FieldProtected { get => fieldProtected; set => fieldProtected = value; }
        //Доступностьполя protected internal из класса потомка. 
        public int FieldProtectedInternal { get => fieldProtectedInternal; set => fieldProtectedInternal = value; }
        //Доступностьполя private protected из класса потомка. 
        public int FieldPrivateProtected { get => FieldPrivateProtected; set => FieldPrivateProtected = value; }
    }
    class Chopper //: MotorcycleInternal
    {

    }

}
