namespace Azuremyst.Models.Acore.Characters;

public partial class LogMoney
{
    public uint SenderAcc { get; set; }

    public uint SenderGuid { get; set; }

    public string SenderName { get; set; } = null!;

    public string SenderIp { get; set; } = null!;

    public uint ReceiverAcc { get; set; }

    public string ReceiverName { get; set; } = null!;

    public ulong Money { get; set; }

    public string Topic { get; set; } = null!;

    public DateTime Date { get; set; }

    /// <summary>
    /// 1=COD,2=AH,3=GB DEPOSIT,4=GB WITHDRAW,5=MAIL,6=TRADE
    /// </summary>
    public sbyte Type { get; set; }
}
