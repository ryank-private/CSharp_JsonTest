using System;
using System.Text.Json;

namespace CSharp_JsonTestDeserialize
{
	class Program
	{
		static void Main(string[] args)
		{
			string jsonTest = "{\"StrData\": \"test\"}";


			var jsonObj_SystemTextJson = JsonSerializer.Deserialize<JsonStrData>(jsonTest);
			var jsonObj_SystemTextJson_NoDefault = JsonSerializer.Deserialize<JsonStrDataWithDefault>(jsonTest);

			

			var jsonObj_NewtonsoftJson = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonStrData>(jsonTest);
			var jsonObj_NewtonsoftJson_NoDefault = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonStrDataWithDefault>(jsonTest);

			Console.WriteLine("System.Text.Json Results (get set, default string)");
			Console.WriteLine("jsonObj_SystemTextJson.StrData: " + jsonObj_SystemTextJson.StrData);
			Console.WriteLine("jsonObj_SystemTextJson_WithDefault.StrData: " + jsonObj_SystemTextJson_NoDefault.StrData);

			Console.WriteLine();
			Console.WriteLine("jsonObj_NewtonsoftJson.StrData: " + jsonObj_NewtonsoftJson.StrData);
			Console.WriteLine("jsonObj_NewtonsoftJson_WithDefault.StrData: " + jsonObj_NewtonsoftJson_NoDefault.StrData);

		}
	}

	public class JsonStrData
	{
		public string StrData { get; set; }
	}

	public class JsonStrDataWithDefault
	{
		public string StrData = null;
	}

}
