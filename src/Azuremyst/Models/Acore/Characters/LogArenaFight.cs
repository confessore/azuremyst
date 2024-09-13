namespace Azuremyst.Models.Acore.Characters;

public partial class LogArenaFight
{
    public uint FightId { get; set; }

    public DateTime Time { get; set; }

    public byte Type { get; set; }

    public uint Duration { get; set; }

    public uint Winner { get; set; }

    public uint Loser { get; set; }

    public ushort WinnerTr { get; set; }

    public ushort WinnerMmr { get; set; }

    public short WinnerTrChange { get; set; }

    public ushort LoserTr { get; set; }

    public ushort LoserMmr { get; set; }

    public short LoserTrChange { get; set; }

    public uint CurrOnline { get; set; }
}
