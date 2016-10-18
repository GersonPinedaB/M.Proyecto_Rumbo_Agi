using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public class Validation
    {
        private Regex rgx;
        private Match m;

        public bool validarNombre(string input)
        {
            bool ver = true;
            char[] vec = input.ToCharArray();
            for (int i = 0; i < vec.Length; i++)
            {
                if (!Char.IsLetter(vec[i]) && vec[i] != ' ')
                {
                    ver = false;
                    break;
                }
            }
            return ver;
        }
    }
}