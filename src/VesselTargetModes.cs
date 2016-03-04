#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP1.0.5\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

public enum VesselTargetModes
{
    /// <summary>
    /// None. How is this useful?
    /// </summary>
    None,
    /// <summary>
    /// Only the direction of the taget. Used by <see cref="CelestialBody"/>.
    /// </summary>
    Direction,
    /// <summary>
    /// Direction and velocity. Used by <see cref="Vessel"/>.
    /// </summary>
    DirectionAndVelocity,
    /// <summary>
    /// Direction, velocity, and orientation. Used by <see cref="ModuleDockingNode"/>.
    /// </summary>
    DirectionVelocityAndOrientation,
}
