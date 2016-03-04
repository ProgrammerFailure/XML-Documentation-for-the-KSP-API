#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

[Flags]
public enum TransactionReasons
{
    Any = -1,
    None = 0,
    ContractAdvance = 2,
    ContractReward = 4,
    ContractPenalty = 8,
    Contracts = 14,
    VesselRollout = 16,
    VesselRecovery = 32,
    VesselLoss = 64,
    Vessels = 112,
    StrategyInput = 128,
    StrategyOutput = 256,
    StrategySetup = 512,
    Strategies = 896,
    ScienceTransmission = 1024,
    StructureRepair = 2048,
    StructureCollapse = 4096,
    StructureConstruction = 8192,
    Structures = 14336,
    RnDTechResearch = 16384,
    RnDPartPurchase = 32768,
    RnDs = 49152,
    Cheating = 65536,
    CrewRecruited = 131072,
}
