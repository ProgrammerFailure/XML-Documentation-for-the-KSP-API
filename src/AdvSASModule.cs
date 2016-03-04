#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public class AdvSASModule : Part
{
    public float Damping;
    public float Kd;
    public float Ki;
    public float Kp;
    public float maxTorque;

    public AdvSASModule();

    protected override void onDisconnect();
    protected override void onFlightStart();
    protected override void onPartDestroy();
    protected override void onPartExplode();
    protected override void onPartFixedUpdate();
    protected override void onPartStart();
}
