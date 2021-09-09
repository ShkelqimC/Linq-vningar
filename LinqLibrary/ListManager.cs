using System;
using System.Collections.Generic;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Fighter> SampleList()
        {
            List<Fighter> output = new List<Fighter>();

            output.Add(new Fighter { firstName = "Bob", lastName = "Sapp", gender = "Male", age = 42 });
            output.Add(new Fighter { firstName = "Conor", lastName = "McGregor", gender = "Male", age = 30 });
            output.Add(new Fighter { firstName = "Khabib", lastName = "Nurmagomedov", gender = "Male", age = 32 });
            output.Add(new Fighter { firstName = "Amanda", lastName = "Nunes", gender = "Female", age = 28 });
            output.Add(new Fighter { firstName = "Chris", lastName = "Cyborg", gender = "Female", age = 34 });
            output.Add(new Fighter { firstName = "Rose", lastName = "Namajunes", gender = "Female", age = 30 });
            output.Add(new Fighter { firstName = "Joanna", lastName = "Jedrezjyec", gender = "Female", age = 28 });
            output.Add(new Fighter { firstName = "Sean", lastName = "O'malley", gender = "Male", age = 25 });
            output.Add(new Fighter { firstName = "Eddie", lastName = "Alvarez", gender = "Male", age = 34 });
            output.Add(new Fighter { firstName = "Ilir", lastName = "Latifi", gender = "Male", age = 36 });
            output.Add(new Fighter { firstName = "Alexander", lastName = "Gustavsson", gender = "Male", age = 36 });
            output.Add(new Fighter { firstName = "Israel", lastName = "Adesanya", gender = "Male", age = 31 });
            output.Add(new Fighter { firstName = "Jon", lastName = "Jones", gender = "Male", age = 35 });


            return output;
        }

    }
}
