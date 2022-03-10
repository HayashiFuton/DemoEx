using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForDemoSchool
{
    public class GetStudNumbers
    {
        public string StudNumber(string fio, int year, int group)
        {
            string text = fio;
            text = text.Trim();
            string[] words = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);



            return text;
        }
    }
}
