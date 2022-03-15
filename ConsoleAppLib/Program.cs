using ClassLibraryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppLib
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryReader.ReadLibrary(@"G:\My Drive\Uni\4th\Ood\HOME\lab1\library.xml");
		}
	}
}
