﻿namespace Azuremyst.Models.Acore.World;

public partial class QuestTemplateLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Title { get; set; }

    public string? Details { get; set; }

    public string? Objectives { get; set; }

    public string? EndText { get; set; }

    public string? CompletedText { get; set; }

    public string? ObjectiveText1 { get; set; }

    public string? ObjectiveText2 { get; set; }

    public string? ObjectiveText3 { get; set; }

    public string? ObjectiveText4 { get; set; }

    public int? VerifiedBuild { get; set; }
}