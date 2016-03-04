#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

public class GameParameters : IConfigNode
{
    public GameParameters.CareerParams Career;
    public GameParameters.DifficultyParams Difficulty;
    public GameParameters.EditorParams Editor;
    public GameParameters.FlightParams Flight;
    public GameParameters.Preset preset;
    public GameParameters.SpaceCenterParams SpaceCenter;
    public GameParameters.TrackingStationParams TrackingStation;

    public GameParameters();
    public GameParameters(ConfigNode node);

    public static GameParameters GetDefaultParameters(Game.Modes mode, GameParameters.Preset p);
    public static Color GetPresetColor(GameParameters.Preset p);
    public static string GetPresetColorHex(GameParameters.Preset p);
    public void Load(ConfigNode node);
    public void Save(ConfigNode node);

    public enum Preset
    {
        Easy = 0,
        Normal = 1,
        Moderate = 2,
        Hard = 3,
        Custom = 4,
    }

    public class CareerParams : GameParameters.ParameterNode
    {
        public float FundsGainMultiplier;
        public float FundsLossMultiplier;
        public float RepGainMultiplier;
        public float RepLossMultiplier;
        public float ScienceGainMultiplier;
        public float StartingFunds;
        public float StartingReputation;
        public float StartingScience;
        public string TechTreeUrl;

        public CareerParams();
    }

    public class DifficultyParams : GameParameters.ParameterNode
    {
        public bool AllowStockVessels;
        public bool AutoHireCrews;
        public bool BypassEntryPurchaseAfterResearch;
        public bool IndestructibleFacilities;
        public bool MissingCrewsRespawn;
        public float ReentryHeatScale;
        public float ResourceAbundance;

        public DifficultyParams();
    }

    public class EditorParams : GameParameters.ParameterNode
    {
        public bool CanLaunch;
        public bool CanLeaveToMainMenu;
        public bool CanLeaveToSpaceCenter;
        public bool CanLoad;
        public bool CanSave;
        public bool CanStartNew;
        public string craftFileToLoad;
        public int startUpMode;

        public EditorParams();
    }

    public class FlightParams : GameParameters.ParameterNode
    {
        public bool CanAutoSave;
        public bool CanBoard;
        public bool CanEVA;
        public bool CanIVA;
        public bool CanLeaveToEditor;
        public bool CanLeaveToMainMenu;
        public bool CanLeaveToSpaceCenter;
        public bool CanLeaveToTrackingStation;
        public bool CanQuickLoad;
        public bool CanQuickSave;
        public bool CanRestart;
        public bool CanSwitchVesselsFar;
        public bool CanSwitchVesselsNear;
        public bool CanTimeWarpHigh;
        public bool CanTimeWarpLow;
        public bool CanUseMap;

        public FlightParams();
    }

    public class ParameterNode : IConfigNode
    {
        public ParameterNode();

        public void Load(ConfigNode node);
        public void Save(ConfigNode node);
    }

    public class SpaceCenterParams : GameParameters.ParameterNode
    {
        public bool CanGoInSPH;
        public bool CanGoInTrackingStation;
        public bool CanGoInVAB;
        public bool CanLaunchAtPad;
        public bool CanLaunchAtRunway;
        public bool CanLeaveToMainMenu;

        public SpaceCenterParams();
    }

    public class TrackingStationParams : GameParameters.ParameterNode
    {
        public bool CanAbortVessel;
        public bool CanFlyVessel;
        public bool CanLeaveToMainMenu;
        public bool CanLeaveToSpaceCenter;

        public TrackingStationParams();
    }
}
