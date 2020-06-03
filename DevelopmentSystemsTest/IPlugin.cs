﻿using System;
using System.Drawing;
namespace DevelopmentSystemsTest
{
    interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        Image Image { get; }
        string Description { get; }
        int Run(int input1, int input2);
    }
}
