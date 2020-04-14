using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace EssayValidator
{

    public static class GoogleSearchApi
    {
        //API Key
        private const string API_KEY = "AIzaSyCoIux7NrGGW3Tu-Z3DwdJdFlH5AxS3Aws";
        //The custom search engine identifier
        private const string CX = "000745160561992395381:r5jadappqpz";

        private static readonly CustomsearchService SERVICE = new CustomsearchService(
            new BaseClientService.Initializer
            {
                ApplicationName = "EssayValidator",
                ApiKey = API_KEY,
            });

        
        public static IList<Result> Search(string query, out string total)
        {
            CseResource.ListRequest listRequest = SERVICE.Cse.List();
            listRequest.Cx = CX;
            listRequest.Q = query;

            Search search = listRequest.Execute();
            total = search.SearchInformation.TotalResults;
            return search.Items;
        }

    }
}
