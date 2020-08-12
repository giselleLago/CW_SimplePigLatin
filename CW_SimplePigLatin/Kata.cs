using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_SimplePigLatin
{
    public class Kata
    {
        public string PigIt(string str)
        {
            var list = str.Split(" ").ToList();
            var newlist = new List<string>();
            foreach (var item in list)
            {
                var x = item.ToCharArray();
                var firstLetter = x[0];
                var newItem = new char[0].ToList();
                for (int i = 1; i < x.Length; i++)
                {
                    newItem.Add(x[i]);
                }
                newItem.Add(firstLetter);
                newItem.Add('a');
                newItem.Add('y');
                newlist.Add(string.Join("" , newItem));
            }
            return string.Join(" ", newlist);
        }
    }
}
