using Learn2012.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace Learn2012
{
    public partial class App : Application
    {
        public static LearningWPF2012Entities DB = new LearningWPF2012Entities();
    }
}
