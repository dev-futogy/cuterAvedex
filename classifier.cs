using System.Collections.Generic;

namespace cuterAvedex
{
	class classifier
	{
		public string PathClassFile
		{
			get;
			set;
		}
		public List<string> GetList
		{ 
			get; 
			set; 
		}
		public string Name
		{
			get;
			set;
		}

		public classifier(string path,string name)
		{
			PathClassFile = path;
			Name = name;
		}

	}
}
