namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class GmSubsurvey
{
    public uint SurveyId { get; set; }

    public uint QuestionId { get; set; }

    public uint Answer { get; set; }

    public string AnswerComment { get; set; } = null!;
}
