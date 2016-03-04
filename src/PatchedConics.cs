#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

public class PatchedConics
{
    public PatchedConics();

    public static bool CalculatePatch(Orbit p, Orbit nextPatch, double startEpoch, PatchedConics.SolverParameters pars, CelestialBody targetBody);
    public static bool ScreenCast(Vector3 screenPos, List<PatchRendering> patchRenders, out PatchedConics.PatchCastHit hitInfo, float orbitPixelWidth = 10f, double maxUT = -1, bool clampToPatches = false);
    public static bool ScreenCast(Vector3 screenPos, PatchRendering pr, out PatchedConics.PatchCastHit hitInfo, float orbitPixelWidth = 10f, double maxUT = -1, bool clampToPatch = false);
    public static bool TAIsWithinPatchBounds(double tA, Orbit patch);

    public class SolverParameters
    {
        public bool debug_disableEscapeCheck;
        public bool FollowManeuvers;
        public int GeoSolverIterations;
        public int maxGeometrySolverIterations;
        public int maxTimeSolverIterations;
        public double outerReaches;
        public int TimeSolverIterations1;
        public int TimeSolverIterations2;

        public SolverParameters();
    }

    public struct PatchCastHit
    {
        public Vector3 hitPoint;
        public double mouseTA;
        public Vector3 orbitOrigin;
        public Vector3 orbitPoint;
        public Vector3 orbitScreenPoint;
        public PatchRendering pr;
        public double radiusAtTA;
        public double UTatTA;

        public Vector3 GetUpdatedOrbitPoint();
        public Vector3 GetUpdatedOrigin();
        public Vector3 GetUpdatedScreenPoint();
    }
}
