#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioModule : MonoBehaviour, IConfigNode
{
    public ScenarioRunner runner;
    public ProtoScenarioModule snapshot;
    public List<GameScenes> targetScenes;

    public ScenarioModule();

    public int ClassID { get; }
    public string ClassName { get; }
    public BaseEventList Events { get; }
    public BaseFieldList Fields { get; }

    public void Load(ConfigNode node);
    public virtual void OnAwake();
    public virtual void OnLoad(ConfigNode node);
    public virtual void OnSave(ConfigNode node);
    public void Save(ConfigNode node);
}
