using Microsoft.AspNetCore.Components.Forms;
using PersonalProject.Client.Models;
using Syncfusion.Blazor.Charts.Chart.Internal;
using System.Net.Http.Json;

namespace PersonalProject.Client.Client
{
    public class StandData(HttpClient httpClient)
    {

        public async Task AddStandAsync(StandDataTable stand) =>
            await httpClient.PostAsJsonAsync("stands", stand);


        public async Task<StandDataTable[]> GetStandsAsync() => 
          await httpClient.GetFromJsonAsync<StandDataTable[]>("stands") ??[];


        public async Task<StandDataTable> StandDataRetrieveAsync(int ID) =>
            await httpClient.GetFromJsonAsync<StandDataTable>($"stands/{ID}")??throw new Exception("Could not find stand");


        public async Task UpdateStandAsync(StandDataTable UpdatedStand) =>
            await httpClient.PutAsJsonAsync($"stands/{UpdatedStand.ID}", UpdatedStand);


        public async Task DeleteStandAsync(int ID) =>
            await httpClient.DeleteAsync($"stands/{ID}");



    }
}

