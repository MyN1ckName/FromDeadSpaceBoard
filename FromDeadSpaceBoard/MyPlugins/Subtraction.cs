namespace ds.test.impl.MyPlugins
{
	class Subtraction : PluginVersion, IPlugin
	{
		public string PluginName { get { return "Subtraction"; } }

		public System.Drawing.Image Image
		{ get { return System.Drawing.Image.FromFile("MyPlugins/img/sum.png"); } }

		public string Description
		{
			get { return
					"Метод Run плагина Subtraction возвращает разность двух целых чисел"; }
		}

		public int Run(int input1, int input2)
		{
			int c = input1 - input2;
			return c;
		}
	}
}