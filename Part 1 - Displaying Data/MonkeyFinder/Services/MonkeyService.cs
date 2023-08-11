using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient httpClient;
    public MonkeyService()
    {
        httpClient = new HttpClient();
    }


    List<Monkey> monkeyList = new ();

    public async Task<List<Monkey>> GetMonkeys()
    {
        if(monkeyList?.Count > 0)
            return monkeyList;

        var url = "https://montemagno.com/monkeys.json";

        var response = await httpClient.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            // ReadFromJsonAsync is something in .Net that reformats a JSON file into
            // in this case a List<Monkey>
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        return monkeyList;
    }
}
