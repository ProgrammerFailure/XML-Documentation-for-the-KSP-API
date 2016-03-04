#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP1.0.5\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

public class ResearchAndDevelopment : ScenarioModule
{
    public static ResearchAndDevelopment Instance;

    public ResearchAndDevelopment();

    public float Science { get; }

    public static void AddExperimentalPart(AvailablePart ap);
    public void AddScience(float value, TransactionReasons reason);
    public static bool CanAfford(float amount);
    public void CheatAddScience(float sci);
    public void CheatTechnology();
    public static string CheckForMissingParts();
    public static string CountUniversalScience();
    public static List<string> GetBiomeTags(CelestialBody cb);
    public static ScienceExperiment GetExperiment(string experimentID);
    public static List<string> GetExperimentIDs();
    public static ScienceSubject GetExperimentSubject(ScienceExperiment experiment, ExperimentSituations situation, CelestialBody body, string biome);
    public static ScienceSubject GetExperimentSubject(ScienceExperiment experiment, ExperimentSituations situation, string sourceUId, string sourceTitle, CelestialBody body, string biome);
    public static float GetNextScienceValue(float dataAmount, ScienceSubject subject, float xmitScalar = 1f);
    public static float GetReferenceDataValue(float dataAmount, ScienceSubject subject);
    public static string GetResults(string subjectID);
    public static float GetScienceValue(float dataAmount, ScienceSubject subject, float xmitScalar = 1f);
    public static List<string> GetSituationTags();
    public static ScienceSubject GetSubjectByID(string subjectID);
    public static List<ScienceSubject> GetSubjects();
    public static float GetSubjectValue(float subjectScience, ScienceSubject subject);
    public static RDTech.State GetTechnologyState(string techID);
    public ProtoTechNode GetTechState(string techID);
    public static bool IsExperimentalPart(AvailablePart ap);
    public override void OnAwake();
    public void OnDestroy();
    public override void OnLoad(ConfigNode node);
    public override void OnSave(ConfigNode node);
    public static string PartAssignmentSummary();
    public static bool PartModelPurchased(AvailablePart ap);
    public static bool PartTechAvailable(AvailablePart ap);
    public static void RemoveExperimentalPart(AvailablePart ap);
    public static string ScienceTransmissionRewardString(float amount, TransactionReasons reason = TransactionReasons.ScienceTransmission);
    public void SetTechState(string techID, ProtoTechNode techNode);
    public void Start();
    public float SubmitScienceData(float dataAmount, ScienceSubject subject, float xmitScalar = 1f, ProtoVessel source = null, bool reverseEngineered = false);
}
