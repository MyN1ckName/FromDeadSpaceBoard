namespace ds.test.impl.MyPlugins
{
	class Sum : PluginVersion, IPlugin
	{
		public string PluginName { get { return "Sum"; } }

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