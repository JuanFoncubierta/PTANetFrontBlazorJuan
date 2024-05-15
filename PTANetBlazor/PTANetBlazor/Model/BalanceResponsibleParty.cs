using System.ComponentModel.DataAnnotations;

namespace PTANetBlazor;

public class BalanceResponsibleParty
{
    [Key]
    public string brpCode { get; set; }
    public string brpName { get; set; }
    public string country { get; set; }
    public string businessId { get; set; }
    public string codingScheme { get; set; }
    public DateTime validityStart { get; set; }
    public DateTime validityEnd { get; set; }

    public BalanceResponsibleParty()
    {

    }
}

