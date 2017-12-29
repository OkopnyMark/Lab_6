using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Reflect
    {

        public static string MethodReflectInfo<T>(T element) where T : class
        {
            Type t = typeof(T);
            List<string> constructors = new List<string>();
            foreach (var x in t.GetConstructors())
            { constructors.Add(x.ToString()); }

            List<string> metody = new List<string>();
            foreach (var x in t.GetMethods())
            { metody.Add(x.ToString()); }


            List<string> polya = new List<string>();
            foreach (var x in t.GetFields())
            { polya.Add(x.ToString()); }

            List<string> svva = new List<string>();
            foreach (var x in t.GetProperties())
            { svva.Add(x.ToString()); }

            string retstring = "Конструкторы: \n";
            foreach (string c in constructors)
            { retstring += c + Environment.NewLine; }


            retstring += "Методы: \n";
            foreach (string c in metody)
            { retstring += c + Environment.NewLine; }
            retstring += "Поля: \n";
            foreach (string c in polya)
            { retstring += c + Environment.NewLine; }
            retstring += "Свойства: \n";
            foreach (string c in svva)
            { retstring += c + Environment.NewLine; }

            return retstring;

        }







    }
}

