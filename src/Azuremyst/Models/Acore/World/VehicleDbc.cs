﻿namespace Azuremyst.Models.Acore.World;

public partial class VehicleDbc
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public float TurnSpeed { get; set; }

    public float PitchSpeed { get; set; }

    public float PitchMin { get; set; }

    public float PitchMax { get; set; }

    public int SeatId1 { get; set; }

    public int SeatId2 { get; set; }

    public int SeatId3 { get; set; }

    public int SeatId4 { get; set; }

    public int SeatId5 { get; set; }

    public int SeatId6 { get; set; }

    public int SeatId7 { get; set; }

    public int SeatId8 { get; set; }

    public float MouseLookOffsetPitch { get; set; }

    public float CameraFadeDistScalarMin { get; set; }

    public float CameraFadeDistScalarMax { get; set; }

    public float CameraPitchOffset { get; set; }

    public float FacingLimitRight { get; set; }

    public float FacingLimitLeft { get; set; }

    public float MsslTrgtTurnLingering { get; set; }

    public float MsslTrgtPitchLingering { get; set; }

    public float MsslTrgtMouseLingering { get; set; }

    public float MsslTrgtEndOpacity { get; set; }

    public float MsslTrgtArcSpeed { get; set; }

    public float MsslTrgtArcRepeat { get; set; }

    public float MsslTrgtArcWidth { get; set; }

    public float MsslTrgtImpactRadius1 { get; set; }

    public float MsslTrgtImpactRadius2 { get; set; }

    public string? MsslTrgtArcTexture { get; set; }

    public string? MsslTrgtImpactTexture { get; set; }

    public string? MsslTrgtImpactModel1 { get; set; }

    public string? MsslTrgtImpactModel2 { get; set; }

    public float CameraYawOffset { get; set; }

    public int UilocomotionType { get; set; }

    public float MsslTrgtImpactTexRadius { get; set; }

    public int VehicleUiindicatorId { get; set; }

    public int PowerDisplayId1 { get; set; }

    public int PowerDisplayId2 { get; set; }

    public int PowerDisplayId3 { get; set; }
}
