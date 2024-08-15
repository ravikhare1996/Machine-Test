using BlazorPWA.Shared.Data;
using Newtonsoft.Json;

//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XpertStudio.Common.Data;
using XpertStudio.Common.Managers;

namespace BlazorPWA.Shared.Managers
{
    public class CommonManager : IManager
    {
        private HttpClient _httpClient;
        public CommonManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> ExecuteNonQuery(string Query)
        {
            return await _httpClient.GetFromJsonAsync<bool>(Routes.CommonDBEndPoints.ExecuteNonQuery(Query));
        }
        public async Task<DataTable?> GetDataTable(string Query)
        {
            try
            {
                // Get the JSON string from the endpoint
                string json = await _httpClient.GetStringAsync(Routes.CommonDBEndPoints.GetDataTable(Query));

                // Parse the JSON string into a JsonDocument
                using (JsonDocument document = JsonDocument.Parse(json))
                {
                    // Check if the root element is an array
                    if (document.RootElement.ValueKind == JsonValueKind.Array)
                    {
                        // Initialize DataTable
                        DataTable dataTable = new DataTable();

                        // If the JSON array is empty, return an empty DataTable
                        if (!document.RootElement.EnumerateArray().Any())
                        {
                            return dataTable;
                        }

                        // Iterate through the array to find all possible properties and create columns
                        foreach (JsonElement element in document.RootElement.EnumerateArray())
                        {
                            foreach (JsonProperty property in element.EnumerateObject())
                            {
                                if (!dataTable.Columns.Contains(property.Name))
                                {
                                    dataTable.Columns.Add(property.Name);
                                }
                            }
                        }

                        // Iterate through the array and populate the DataTable
                        foreach (JsonElement element in document.RootElement.EnumerateArray())
                        {
                            DataRow row = dataTable.NewRow();
                            foreach (JsonProperty property in element.EnumerateObject())
                            {
                                row[property.Name] = property.Value.ToString(); // Convert value to string
                            }
                            dataTable.Rows.Add(row);
                        }

                        return dataTable;
                    }
                    else
                    {
                        throw new System.Text.Json.JsonException("Root element is not an array.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public async Task<DataTable?> GetDataTablePaginated(string Query, PagedRequest request)
        {
            try
            {
                // Get the JSON string from the endpoint
                string json = await _httpClient.GetStringAsync(Routes.CommonDBEndPoints.GetDataTablePaginated(Query, request.PageNumber, request.PageSize, request.SearchString, request.Orderby));

                // Parse the JSON string into a JsonDocument
                using (JsonDocument document = JsonDocument.Parse(json))
                {
                    // Check if the root element is an array
                    if (document.RootElement.ValueKind == JsonValueKind.Array)
                    {
                        // Initialize DataTable
                        DataTable dataTable = new DataTable();

                        // If the JSON array is empty, return an empty DataTable
                        if (!document.RootElement.EnumerateArray().Any())
                        {
                            return dataTable;
                        }

                        // Iterate through the array to find all possible properties and create columns
                        foreach (JsonElement element in document.RootElement.EnumerateArray())
                        {
                            foreach (JsonProperty property in element.EnumerateObject())
                            {
                                if (!dataTable.Columns.Contains(property.Name))
                                {
                                    dataTable.Columns.Add(property.Name);
                                }
                            }
                        }

                        // Iterate through the array and populate the DataTable
                        foreach (JsonElement element in document.RootElement.EnumerateArray())
                        {
                            DataRow row = dataTable.NewRow();
                            foreach (JsonProperty property in element.EnumerateObject())
                            {
                                row[property.Name] = property.Value.ToString(); // Convert value to string
                            }
                            dataTable.Rows.Add(row);
                        }

                        return dataTable;
                    }
                    else
                    {
                        throw new System.Text.Json.JsonException("Root element is not an array.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<object?> getSingleValue(string query)
        {
            try
            {
                var value = await _httpClient.GetStringAsync(Routes.CommonDBEndPoints.getSingleValue(query));

                // Return the string value directly
                return value;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public async Task<T?> getSingleValue<T>(string query)
        {
            try
            {
                var value = await _httpClient.GetStringAsync(Routes.CommonDBEndPoints.getSingleValue(query));
                // Check and replace single quotes with double quotes to make it valid JSON
                
                return JsonConvert.DeserializeObject<T?>(value);
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
        public async Task<bool> UpdateImage(string strColName, byte[] LogoImg, string strTableName, string strWhrCls)
        {
            return await _httpClient.GetFromJsonAsync<bool>(Routes.CommonDBEndPoints.UpdateImage(strColName, LogoImg, strTableName, strWhrCls));
        }
        public async Task<DateTime> GetServerDate()
        {
            var value = await _httpClient.GetFromJsonAsync<DateTime>(Routes.CommonDBEndPoints.GetServerDate());

            // Return the date value directly
            return value;
        }

    }
}
