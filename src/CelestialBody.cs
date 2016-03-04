#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP1.0.5\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using KSPAchievements;
using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The Sun, the planets, and the moons are all CelestialBodies.
/// </summary>
public class CelestialBody : MonoBehaviour, ITargetable, IDiscoverable
{
    public AtmosphereFromGround afg;
    public double albedo;
    /// <summary>
    /// The magnitude of the angular velocity of the body's rotation, in radians per second.
    /// </summary>
    public double angularV;
    /// <summary>
    /// The body's angular velocity vector, in rotations per second. This points along the axis of
    /// rotation and its magnitude is the rotation rate in radians per second.
    /// </summary>
    public Vector3d angularVelocity;
    public double atmDensityASL;
    /// <summary>
    /// Whether this body has an atmosphere
    /// </summary>
    public bool atmosphere;
    public double atmosphereAdiabaticIndex;
    /// <summary>
    /// Presumably, whether jet engines will work in this body's atmosphere
    /// </summary>
    public bool atmosphereContainsOxygen;
    public double atmosphereDepth;
    public double atmosphereGasMassLapseRate;
    public double atmosphereMolarMass;
    public FloatCurve atmospherePressureCurve;
    public bool atmospherePressureCurveIsNormalized;
    public double atmospherePressureSeaLevel;
    public FloatCurve atmosphereTemperatureCurve;
    public bool atmosphereTemperatureCurveIsNormalized;
    public double atmosphereTemperatureLapseRate;
    public double atmosphereTemperatureSeaLevel;
    public FloatCurve atmosphereTemperatureSunMultCurve;
    public bool atmosphereUsePressureCurve;
    public bool atmosphereUseTemperatureCurve;
    public Color atmosphericAmbientColor;
    public FloatCurve axialTemperatureSunMultCurve;
    public CBAttributeMapSO BiomeMap;
    public string bodyDescription;
    /// <summary>
    /// The name of the body, as a string.
    /// </summary>
    public string bodyName;
    public Transform bodyTransform;
    public CelestialBodyType bodyType;
    public double convectionMultiplier;
    public double coreTemperatureOffset;
    public double Density;
    public double directRotAngle;
    public FloatCurve eccentricityTemperatureSunMultCurve;
    public double emissivity;
    /// <summary>
    /// The gravitational acceleration of the body at sea level, in units of gees (1 gee = 9.81 m/s^2)
    /// </summary>
    public double GeeASL;
    /// <summary>
    /// The gravitational acceleration (in m/s^2) at a radius r (in m) from the body's center is gMagnitudeAtCenter / r^2
    /// </summary>
    public double gMagnitudeAtCenter;
    /// <summary>
    /// The gravitational parameter GM is the universal gravitational constant G times the mass M of the body. 
    /// In KSP the gravitational constant G is exactly 6.673 m^3 / (kg s^2), and the body mass is measured in
    /// kilograms.
    /// </summary>
    public double gravParameter;
    /// <summary>
    /// Unused?
    /// </summary>
    public double hillSphere;
    public double initialRotation;
    public bool inverseRotation;
    public float inverseRotThresholdAltitude;
    public bool isHomeWorld;
    public FloatCurve latitudeTemperatureBiasCurve;
    public FloatCurve latitudeTemperatureSunMultCurve;
    /// <summary>
    /// The mass of the body in kilograms. Computed 
    /// </summary>
    public double Mass;
    public double navballSwitchRadiusMult;
    /// <summary>
    /// Whether this planet has an ocean at "sea level"
    /// </summary>
    public bool ocean;
    /// <summary>
    public float oceanAFGAltMult;
    public float oceanAFGBase;
    public bool oceanAFGLerp;
    public float oceanAFGMin;
    public double oceanDensity;
    public float oceanFogColorAltMult;
    public Color oceanFogColorEnd;
    public Color oceanFogColorStart;
    public float oceanFogDensityAltScalar;
    public float oceanFogDensityEnd;
    public float oceanFogDensityExponent;
    public float oceanFogDensityPQSMult;
    public float oceanFogDensityStart;
    public float oceanSkyColorMult;
    public float oceanSkyColorOpacityAltMult;
    public float oceanSkyColorOpacityBase;
    public float oceanSunAltMult;
    public float oceanSunBase;
    public float oceanSunMin;
    public bool oceanUseFog;
    /// this is what gives the celestial body its orbit and makes it go along the orbit as well
    /// </summary>
    public OrbitDriver orbitDriver;
    /// <summary>
    /// A list of this body's moons (or, in the case of the Sun, a list of the planets).
    /// </summary>
    public List<CelestialBody> orbitingBodies;
    /// <summary>
    /// The pqsController computes the terrain of the planet. Note that for the Sun, pqsController = null.
    /// </summary>
    public PQS pqsController;
    public CelestialBodySubtree progressTree;
    /// <summary>
    /// The radius of the planet in meters. Note that this is only the radius of "sea level"; the actual terrain may be higher.
    /// </summary>
    public double Radius;
    public double radiusAtmoFactor;
    public bool rotates;
    public QuaternionD rotation;
    public double rotationAngle;
    /// <summary>
    /// The time, in seconds, for the body to complete one rotation around its axis
    /// </summary>
    public double rotationPeriod;
    public GameObject scaledBody;
    public CelestialBodyScienceParams scienceValues;
    public double shockTemperatureMultiplier;
    public double solarDayLength;
    public bool solarRotationPeriod;
    /// <summary>
    /// The radius of this body's sphere of influence (measured from the center of the body), in meters.
    /// </summary>
    public double sphereOfInfluence;
    public double SurfaceArea;
    /// <summary>
    /// Presumably, whether this body is tidally locked to the body around with it orbits.
    /// </summary>
    public bool tidallyLocked;
    /// <summary>
    /// Presumably, this gives the minimum altitude you must have in order to be allowed to use each
    /// warp rate when in this body's sphere of influence.
    /// </summary>
    public float[] timeWarpAltitudeLimits;
    public bool use_The_InName;
    public Vector3d zUpAngularVelocity;

    public extern CelestialBody();

    /// <summary>Describes to what extent this body has been explored</summary>
    public extern DiscoveryInfo DiscoveryInfo { get; }
    public extern int flightGlobalsIndex { get; set; }
    public extern string name { get; }
    /// <summary>
    /// Describes the orbit of this body around its primary.
    /// </summary>
    public extern Orbit orbit { get; }
    /// <summary>
    /// The position of the center of the body, in world coordinates.
    /// </summary>
    public extern Vector3d position { get; set; }
    /// <summary>
    /// Presumably, the body this body orbits around
    /// </summary>
    public extern CelestialBody referenceBody { get; }
    public extern Texture2D ResourceMap { get; }
    public extern PResource Resources { get; }
    public extern Vector3d RotationAxis { get; }
    public extern string theName { get; }

    public extern void CBUpdate();
    [ContextMenu("Debug Time Warp Limits")]
    public extern void debugTimeWarpLimits();
    public extern void DisplaySurfaceResource(int resourceID);
    /// <summary>
    /// Gets the height of a given position above this body's sea level, in meters.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Altitude in meters</returns>
    public extern double GetAltitude(Vector3d worldPos);
    public extern Bounds getBounds();
    public extern double GetDensity(double pressure, double temperature);
    /// <summary>
    /// The velocity of the CelestialBody, {AliceWorld, Sun}. (See Orbit.cs for
    /// the reference frame definitions).
    /// </summary>
    public extern Vector3d GetFrameVel();
    public extern Vector3d GetFrameVelAtUT(double UT);
    public extern Vector3 GetFwdVector();
    /// <summary>
    /// Gets the latitude of a given position, in degrees.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Latitude in degrees</returns>
    public extern double GetLatitude(Vector3d worldPos);
    /// <summary>
    /// Gets the longitude of a given position, in degrees. Note that you CANNOT count on this value being in any particular range.
    /// This function may for example return 420, meaning 60 degrees east. You would be well advised to coerce it into a standard
    /// range like -180 to 180 before using it.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Longitude in degrees</returns>
    public extern double GetLongitude(Vector3d worldPos);
    public extern string GetName();
    public extern Vector3 GetObtVelocity();
    public extern Orbit GetOrbit();
    public extern OrbitDriver GetOrbitDriver();
    public extern Vector3d getPositionAtUT(double UT);
    public extern double GetPressure(double altitude);
    public extern Vector3d GetRelSurfaceNVector(double lat, double lon);
    public extern Vector3d GetRelSurfacePosition(Vector3d worldPosition);
    /// <summary>
    /// Returns a vector pointing from the center of the body to the given latitude, longitude, and altitude.
    /// </summary>
    /// <param name="lat">Latitude in degrees</param>
    /// <param name="lon">Longitude in degrees</param>
    /// <param name="alt">Altitude above sea level in meters</param>
    /// <returns>A position vector relative to the center of the body</returns>
    public extern Vector3d GetRelSurfacePosition(double lat, double lon, double alt);
    /// <summary>
    /// Returns the velocity at a given position of the frame of reference that rotates with the planet.
    /// This velocity is the difference between the "orbit" and "surface" velocities.
    /// </summary>
    /// <param name="worldPos">A position in world coordinates</param>
    /// <returns>Velocity of the rotating reference frame</returns>
    public extern Vector3d getRFrmVel(Vector3d worldPos);
    public extern double GetSolarPowerFactor(double density);
    public extern double GetSpeedOfSound(double pressure, double density);
    public extern Vector3 GetSrfVelocity();
    /// <summary>
    /// Returns a unit vector perpendicular to the surface of the body at the given latitude and
    /// longitude (pretending for the moment that the body is a perfect sphere).
    /// </summary>
    /// <param name="lat">Latitude in degrees</param>
    /// <param name="lon">Longitude in degrees</param>
    /// <returns>A unit normal vector to the surface</returns>
    public extern Vector3d GetSurfaceNVector(double lat, double lon);
    public extern VesselTargetModes GetTargetingMode();
    public extern double GetTemperature(double altitude);
    public extern Transform GetTransform();
    public extern Vector3d getTruePositionAtUT(double UT);
    public extern Vessel GetVessel();
    /// <summary>
    /// Returns the position, in world coordinates, of a given latitude, longitude, and altitude
    /// </summary>
    /// <param name="lat">Latitude in degrees</param>
    /// <param name="lon">Longitude in degrees</param>
    /// <param name="alt">Altitude above sea level in meters</param>
    /// <returns>Position in world coordinates</returns>
    public extern Vector3d GetWorldSurfacePosition(double lat, double lon, double alt);
    public extern bool HasChild(CelestialBody body);
    public extern bool HasParent(CelestialBody body);
    public extern void HideSurfaceResource();
    [ContextMenu("Reset Time Warp Limits")]
    public extern void resetTimeWarpLimits();
    /// <summary>Returns the body's altitude above the reference sphere of its primary</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern double RevealAltitude();
    /// <summary>Returns the body's mass, in kg</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern float RevealMass();
    /// <summary>Returns the body's tracking station name</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealName();
    /// <summary>Describes the state of the body</summary>
    ///
    /// <returns>A string containing the sphere of influence and trajectory of the object</returns>
    /// 
    /// <example>"Orbiting the Sun"</example>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealSituationString();
    /// <summary>Returns the body's speed</summary>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern double RevealSpeed();
    /// <summary>Returns the type of the body</summary>
    ///
    /// <returns>One of "Sun", "Planet", or "Moon"</returns>
    /// 
    /// <remarks>Implements IDiscoverable</remarks>
    ///
    public extern string RevealType();
    public extern void SetResourceMap(Texture2D map);
    public extern void SetupConstants();
}
