#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public class Funding : ScenarioModule
{
    public static Funding Instance;

    public Funding();

    public double Funds { get; }

    public void AddFunds(double value, TransactionReasons reason);
    public static bool CanAfford(float cost);
    public override void OnAwake();
    public void OnDestroy();
    public override void OnLoad(ConfigNode node);
    public override void OnSave(ConfigNode node);
}
