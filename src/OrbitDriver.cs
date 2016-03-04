#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP1.0.5\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

public class OrbitDriver : MonoBehaviour
{
    public CelestialBody celestialBody;
    public Vector3 CoMoffset;
    public bool drawOrbit;
    public Transform driverTransform;
    public bool frameShift;
    public Vector3 localCoM;
    public float lowerCamVsSmaRatio;
    public OrbitDriver.CelestialBodyDelegate OnReferenceBodyChange;
    public Orbit orbit;
    public Color orbitColor;
    public Vector3d pos;
    public bool QueuedUpdate;
    public OrbitRenderer Renderer;
    public bool reverse;
    public Vector3 startVel;
    public OrbitDriver.UpdateMode updateMode;
    public float upperCamVsSmaRatio;
    public Vector3d vel;
    public Vessel vessel;

    public OrbitDriver();

    public CelestialBody referenceBody { get; set; }

    public void OnRailsSOITransition(Orbit ownOrbit, CelestialBody to);
    public void RecalculateOrbit(CelestialBody newReferenceBody);
    public void SetOrbitMode(OrbitDriver.UpdateMode mode);
    public void UpdateOrbit();

    public enum UpdateMode
    {
        TRACK_Phys = 0,
        UPDATE = 1,
        IDLE = 2,
    }

    public delegate void CelestialBodyDelegate(CelestialBody body);
}
