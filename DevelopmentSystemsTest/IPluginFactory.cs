using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentSystemsTest
{
    interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);

    }
}
