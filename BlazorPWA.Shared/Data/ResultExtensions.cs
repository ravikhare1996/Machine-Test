using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XpertStudio.Common.Data;

namespace BlazorPWA.Shared.Data
{
    internal static class ResultExtensions
    {
        internal static async Task<IResult<T>> ToResult<T>(this HttpResponseMessage response)
        {
            var responseAsString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<Result<T>>(responseAsString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return responseObject;
        }

        internal static async Task<IResult> ToResult(this HttpResponseMessage response)
        {
            var responseAsString = await response.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<Result>(responseAsString, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return responseObject;
        }

        internal static async Task<PaginatedResult<T>> ToPaginatedResult<T>(this HttpResponseMessage response)
        {


            try
            {
                var responseAsString = await response.Content.ReadAsStreamAsync();
                //JsonSerializer.des
                //PaginatedResult<T> responseObject =  JsonSerializer.Deserialize<PaginatedResult<T>>(responseAsString, new JsonSerializerOptions
                //{
                //    PropertyNameCaseInsensitive = true
                //});

                PaginatedResult<T> responseObject = JsonSerializer.Deserialize<PaginatedResult<T>>(responseAsString);
                return responseObject;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}