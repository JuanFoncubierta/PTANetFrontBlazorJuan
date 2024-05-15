using Newtonsoft.Json;
using PTAJuan.Config;
using PTAJuan.Model;

namespace PTAJuan.ApiCalls;

public class BalanceResponsiblePartiesCall
{
    public BalanceResponsiblePartiesCall() { }
    public async Task<List<BalanceResponsibleParty>> getParties()
    {
        List <BalanceResponsibleParty>? result = new();
        HttpClient client = new HttpClient();
        using (var httpClient = new HttpClient())
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, ConfigData.Instance.urlApi);
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = response.Content.ReadAsStringAsync().Result;
                    result = JsonConvert.DeserializeObject<List<BalanceResponsibleParty>>(responseData);
                    if (result == null) return new();
                    Console.WriteLine(responseData);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        return result;
    }

}

