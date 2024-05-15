namespace PTANetBlazor;

public class ConfigData
{
    public static ConfigData Instance = new("");


    public string urlApi = "https://api.opendata.esett.com/EXP01/BalanceResponsibleParties";

    public ConfigData(string _urlApi) { 
        urlApi = _urlApi;
    }
}

