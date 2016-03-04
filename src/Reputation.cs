#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public class Reputation : ScenarioModule
{
    public static Reputation Instance;
    public static float RepRange;

    public Reputation();

    public static float CurrentRep { get; }
    public float reputation { get; }
    public static float UnitRep { get; }

    public float AddReputation(float r, TransactionReasons reason);
    public void addReputation_discrete(float reputation, TransactionReasons reason);
    public override void OnAwake();
    public override void OnLoad(ConfigNode node);
    public override void OnSave(ConfigNode node);
}
