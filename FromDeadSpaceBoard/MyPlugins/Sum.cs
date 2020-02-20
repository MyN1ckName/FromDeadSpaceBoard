using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl.MyPlugins
{
	class Sum : IPlugin
	{
		public string PluginName { get { return "Sum"; } }
		public string Version { get { return "0.0.1"; } }

		public System.Drawing.Image Image
		{ get { return System.Drawing.Image.FromFile("MyPlugins/img/sum.png"); } }

		public string Description
		{
			get { return "Метод Run плагина Sum возвращает сумму двух целых чисел"; }
		}

		public int Run(int input1, int input2)
		{
			int c = input1 + input2;
			return c;
		}
	}
}