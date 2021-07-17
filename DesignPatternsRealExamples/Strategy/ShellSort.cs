﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
           Console.WriteLine("ShellSorted list ");
        }
    }
}
