﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceControlTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string MasterVariable = "Added";

            Console.WriteLine("Added By Master");

            Console.WriteLine("Updated By Master");

            Console.WriteLine("Updated By kashifahmeds");

            Console.WriteLine("branch develop updated");

            Helper.ToChangeCase("kashif", Helper.CharCase.title);

            Console.WriteLine("Testing rebase... changed by master");

            Console.WriteLine("testing rebase: changes by develop branch.");
        }
    }
}
