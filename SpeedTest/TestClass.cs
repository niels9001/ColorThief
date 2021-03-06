﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace SpeedTest
{
    public class TestClass
    {
        [Benchmark]
        public void Image1()
        {
            var colorThief = new ColorThief.ColorThief();
            var bitmap = (Bitmap)Image.FromFile("test1.jpg");
            var rezule = colorThief.GetColor(bitmap);
        }

        [Benchmark]
        public void Image2()
        {
            var colorThief = new ColorThief.ColorThief();
            var bitmap = (Bitmap)Image.FromFile("test2.jpg");
            var rezule = colorThief.GetColor(bitmap);
        }

    }
}
