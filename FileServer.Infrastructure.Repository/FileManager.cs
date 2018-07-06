using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FileServer.Infrastructure.Repository
{
	public class FileManager
	{
		public bool FileCreate(string path)
		{
			try
			{
				if (!File.Exists(path))
				{
					FileStream fs = File.Create(path);
					fs.Close();
				}
				return true;
			}
			catch (IOException e)
			{
				System.ArgumentException argEx = 
					new System.ArgumentException("Error creando el archivo: ", e);
				throw argEx;
			}
		}

		public bool FileWrite(string path, string serializedObject)
		{
			try
			{
				if (File.Exists(path))
				{
					StreamWriter sw = new StreamWriter(path, true);
					sw.WriteLine(serializedObject);
					sw.Close();
				}
				return true;
			}
			catch (IOException e)
			{
				System.ArgumentException argEx =
					new System.ArgumentException("Error escribiendo el archivo: ", e);
				throw argEx;
			}
		}

		public static bool IsParseable(string s)
		{
			int valid;
			return int.TryParse(s,out valid);
		}

		public string JsonSerialize(Object o)
		{
			string json = JsonConvert.SerializeObject(o);
			return json;
		}
	}
}
