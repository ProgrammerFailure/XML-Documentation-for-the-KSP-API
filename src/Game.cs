#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP1.0.5\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

public class Game
{
    public const int lastCompatibleMajor = 0;
    public const int lastCompatibleMinor = 21;
    public const int lastCompatibleRev = 0;

    public ConfigNode additionalSystems;
    public bool compatible;
    public ConfigNode config;
    public KerbalRoster CrewRoster;
    public string Description;
    public EditorFacility editorFacility;
    public int file_version_major;
    public int file_version_minor;
    public int file_version_revision;
    public string flagURL;
    public FlightState flightState;
    public uint launchID;
    public string linkCaption;
    public string linkURL;
    public Game.Modes Mode;
    public GameParameters Parameters;
    /// <summary>
    /// A list of all scenario templates in the currently loaded game.
    /// </summary>
    /// 
    /// <remarks>Since most ProtoScenarioModules contain a reference to the Scenario that represents 
    /// them, this member is the easiest way to locate a specific Scenario in most cases. It is 
    /// recommended that ProtoScenarioModules be searched by <c>ProtoScenarioModule.moduleName</c>, 
    /// not by <c>ProtoScenarioModule.moduleRef</c>, as the latter may be null.</remarks>
    public List<ProtoScenarioModule> scenarios;
    public GameScenes startScene;
    public Game.GameStatus Status;
    public string Title;

    public Game();
    public Game(ConfigNode root);

    public double UniversalTime { get; }

    /// <summary>
    /// Creates a new scenario of the specified type. Once created, the scenario will persist 
    /// automatically.
    /// </summary>
    /// <returns>A ProtoScenarioModule corresponding to the newly installed scenario.</returns>
    /// <param name="typeOfScnModule">The scenario module to create. The object represented by 
    /// this type must be a subclass of ScenarioModule.</param>
    /// <param name="scenes">The scenes in which the scenario should automatically load itself.</param>
    public ProtoScenarioModule AddProtoScenarioModule(Type typeOfScnModule, params GameScenes[] scenes);
    public ProtoVessel AddVessel(ConfigNode protoVesselNode);
    public bool DestroyVessel(Vessel v);
    public static Game GetCloneOf(Game g);
    public bool IsResumable();
    public void Load();
    /// <summary>
    /// Unregisters a ProtoScenarioModule from the game. It will not persist until the scenario 
    /// is re-added.</summary>
    /// <remarks>IMPORTANT: calling this method DOES NOT remove the Scenario object itself, which will 
    /// continue to run until the next scene change.</remarks>
    /// <returns><c>true</c>, if the ProtoScenarioModule was removed, <c>false</c> if it could not 
    /// be found.</returns>
    /// <param name="typeOfScnModule">The scenario module to de-persist. The object represented by 
    /// this type must be a subclass of ScenarioModule.</param>
    public bool RemoveProtoScenarioModule(Type typeOfScnModule);
    public void Save(ConfigNode rootNode);
    public void Start();
    public override string ToString();
    public Game Updated();

    public enum GameStatus
    {
        UNSTARTED = 0,
        ONGOING = 1,
        FAILED_OR_ABORTED = 2,
        COMPLETED = 3,
    }

    public enum Modes
    {
        SANDBOX = 0,
        CAREER = 1,
        SCENARIO = 2,
        SCENARIO_NON_RESUMABLE = 3,
        SCIENCE_SANDBOX = 4,
    }
}
