namespace ds.test.impl.MyPlugins
{
	class Division : PluginVersion, IPlugin
	{
		public string PluginName { get { return "Division"; } }

		public System.Drawing.Image Image
		{ get { return System.Drawing.Image.FromFile("MyPlugins/img/sum.png"); } }

		public string Description
		{
			get
			{
				return
				  "Метод Run плагина Division возвращает частное двух целых чисел";
			}
		}

		public int Run(int input1, int input2)
		{
			if(input2 != 0)
			{
				int c = input1 / input2;
				return c;
			}
			else { throw new  System.DivideByZeroException("На 0 делить нельзя"); }			
		}
	}
}