using System;
using System.Collections;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AptBatchInstaller
{
	static class MainClass
	{
		public static void Install(string package)
		{
			string sudo=@"/usr/bin/sudo";
			string arg=String.Format("/bin/bash -c \"apt-get install -y {0}\"",package);
			Console.WriteLine("{0} {1}", sudo, arg);
			Process p=new Process();
			p.StartInfo=new ProcessStartInfo(sudo, arg);
			p.StartInfo.UseShellExecute = true;
			p.Start();
			p.WaitForExit();
		}
		public static void Main(string[] args)
		{
			foreach(string package in args)
			{
			Install(package);
			}
		}
	}
}
