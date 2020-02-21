namespace ds.test.impl.MyPlugins
{
	abstract class PluginVersion
	{
		public string Version
		{
			get { return System.Reflection.Assembly.GetExecutingAssembly()
					.GetName().Version.ToString();}
		}
	}
}