#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using Experience;
using System;

[Serializable]
public class ProtoCrewMember
{
    public FlightLog careerLog;
    public float courage;
    public float experience;
    public int experienceLevel;
    public ExperienceTrait experienceTrait;
    public FlightLog flightLog;
    public bool hasToured;
    public bool isBadass;
    public Kerbal KerbalRef;
    public string name;
    public InternalSeat seat;
    public int seatIdx;
    public float stupidity;
    public double UTaR;

    public ProtoCrewMember(ProtoCrewMember.KerbalType type);
    public ProtoCrewMember(Game.Modes mode, ProtoCrewMember copyOf);
    public ProtoCrewMember(Game.Modes mode, ConfigNode node, ProtoCrewMember.KerbalType crewType = ProtoCrewMember.KerbalType.Crew);

    public float ExperienceLevelDelta { get; }
    public ProtoCrewMember.Gender gender { get; set; }
    public ProtoCrewMember.RosterStatus rosterStatus { get; set; }
    public ProtoCrewMember.KerbalType type { get; set; }

    public void ArchiveFlightLog();
    public void CheckRespawnTimer(double UT, GameParameters gameParameters);
    public void Die();
    public void RegisterExperienceTraits(Part part);
    public void Save(ConfigNode node);
    public void SetTimeForRespawn(double UTforRespawn);
    public Kerbal Spawn();
    public void StartRespawnPeriod(double timeToRespawn = 7200);
    public void UnregisterExperienceTraits(Part part);

    public enum Gender
    {
        Male = 0,
        Female = 1,
    }

    public enum KerbalType
    {
        Crew = 0,
        Applicant = 1,
        Unowned = 2,
        Tourist = 3,
    }

    public enum RosterStatus
    {
        Available = 0,
        Assigned = 1,
        Dead = 2,
        Missing = 3,
    }
}
