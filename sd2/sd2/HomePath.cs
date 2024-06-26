﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd2
{
    internal static class HomePath
    {
        public static string HP { get; set; }
        static HomePath()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            string dir = Path.GetDirectoryName(path);
            var parent = Directory.GetParent(dir);
            var p = parent.Parent.Parent.Parent.Parent;
            HP = p.ToString() + @"\Resources\Images\";
        }
    }
}
