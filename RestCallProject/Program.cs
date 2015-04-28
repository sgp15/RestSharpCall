using System;
using System.Net;
using RestSharp;


namespace RestCallProject
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			var client = new RestClient("https://www.quandl.com/api/v1/datasets/ODA/USA_NGDP.json");
			var request = new RestRequest(Method.GET);
			request.AddHeader("auth_token","UYA5shpxWr8m-GsVbdeU");
			//request.RequestFormat = DataFormat.Json;
			IRestResponse response = client.Execute (request);
			Console.WriteLine("Response from the Website");
			Console.WriteLine(response.Content);
		}
	}
}



			