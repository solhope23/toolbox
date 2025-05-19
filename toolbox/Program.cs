using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tool[] TooList = { new hammer(), new screwdriver() };
            foreach (tool Tool in TooList)
            {
                Tool.Describe();
                Tool.Use();
            }


        }
    }
}

