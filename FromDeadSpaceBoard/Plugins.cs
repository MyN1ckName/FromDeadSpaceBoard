using System;
using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
	public static class Plugins //: PluginFactory
	// Статические классы не могут быть наследниками / реализовывать интерфейсы
	{
		static List<IPlugin> plugins = new List<IPlugin>();
		static IPlugin sum = new MyPlugins.Sum();
		static IPlugin sub = new MyPlugins.Subtraction();
		static IPlugin div = new MyPlugins.Division();

		static Plugins()
		{
			plugins.Add(sum);
			plugins.Add(sub);
			plugins.Add(div);
		}

		/// <summary>
		/// Перевызов меода Run из класса Sum
		/// </summary>
		/// <param name="input1">Первый операнд</param>
		/// <param name="input2">Второй операнд</param>
		/// <returns></returns>
		public static int Sum(int input1, int input2)
		{
			return sum.Run(input1, input2);
		}

		/// <summary>
		/// Перевызов меода Run из класса Subtraction
		/// </summary>
		/// <param name="input1">Первый операнд</param>
		/// <param name="input2">Второй операнд</param>
		/// <returns></returns>
		public static int Subtraction(int input1, int input2)
		{
			return sub.Run(input1, input2);
		}

		/// <summary>
		/// Перевызов меода Run из класса Division
		/// </summary>
		/// <param name="input1">Первый операнд</param>
		/// <param name="input2">Второй операнд</param>
		/// <returns></returns>
		public static int Division(int input1, int input2)
		{
			return div.Run(input1, input2);
		}

		/// <summary>
		/// Свойство возвращает количество плагинов
		/// </summary>
		public static int PluginsCount { get { return plugins.Count; } }
		
		/// <summary>
		/// Свойство возвращает список плагинов
		/// </summary>
		public static string[] GetPluginNames
		{
			get
			{
				string[] getPluginNames = new string[plugins.Count];
				for (int i = 0; i < plugins.Count; i++)
				{
					getPluginNames[i] = plugins[i].PluginName;
				}
				return getPluginNames;
			}
		}

		/// <summary>
		/// Метод возвращает объект типа IPlugin по заданному имени
		/// </summary>
		/// <param name="pluginName">Имя плагина</param>
		/// <returns></returns>
		public static IPlugin GetPlugin(string pluginName)
		{
			var plugin =
				from item in plugins
				where item.PluginName.Equals(pluginName)
				select item;

			if (plugin.Count() > 0)
				return plugin.First();
			else { throw new NullReferenceException("Такой плагин не найден"); }
		}
	}
}