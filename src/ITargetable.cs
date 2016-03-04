#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP1.0.5\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

/// <summary>
/// Represents something that can be set as target while controlling
/// a vessel. This is implemented by <see cref="Vessel"/>, <see cref="CelestialBody"/>,
/// and <see cref="ModuleDockingNode"/>.
/// </summary>
public interface ITargetable
{
    Vector3 GetFwdVector();
    /// <summary>
    /// The name of this target.
    /// </summary>
    string GetName();
    Vector3 GetObtVelocity();
    Orbit GetOrbit();
    OrbitDriver GetOrbitDriver();
    Vector3 GetSrfVelocity();
    VesselTargetModes GetTargetingMode();
    Transform GetTransform();
    Vessel GetVessel();
}
