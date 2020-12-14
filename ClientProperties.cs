using System;

namespace Vatsim.Fsd.Connector
{
	public class ClientProperties
	{
		public string Name { get; set; }
		public Version Version { get; set; }

		public ClientProperties(string name, Version ver)
		{
			Name = name;
			Version = ver;
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", Name, Version);
		}
	}
}
