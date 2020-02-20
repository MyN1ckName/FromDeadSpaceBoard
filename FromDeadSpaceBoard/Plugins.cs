using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
	public static class Plugins //: PluginFactory
	{
		static List<IPlugin> plugins = new List<IPlugin>();
		static Plugins()
		{
			plugins.Add(new MyPlugins.Sum());
		}

		public static int PluginsCount { get { return plugins.Count; } }

		static string[] getPluginNames;
		public static string[] GetPluginNames
		{
			get
			{
				for (int i = 0; i < plugins.Count - 1; i++)
				{
					getPluginNames[i] = plugins[i].PluginName;
				}
				return getPluginNames;
			}
		}

		public static IPlugin GetPlugin(string pluginName)
		{
			var plugin =
				from item in plugins
				where item.PluginName.Equals(pluginName)
				select item;

			return plugin.First();
		}
	}
}