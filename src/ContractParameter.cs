#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Contracts
{
    [Serializable]
    public class ContractParameter : IContractParameterHost
    {
        [SerializeField]
        protected bool disableOnStateChange;
        protected bool enabled;
        public double FundsCompletion;
        public double FundsFailure;
        [SerializeField]
        protected string id;
        public EventData<ContractParameter, ParameterState> OnStateChange;
        [SerializeField]
        protected bool optional;
        public float ReputationCompletion;
        public float ReputationFailure;
        public float ScienceCompletion;
        [SerializeField]
        protected ParameterState state;

        public ContractParameter();

        public IEnumerable<ContractParameter> AllParameters { get; }
        public bool DisableOnStateChange { get; set; }
        public bool Enabled { get; set; }
        public string HashString { get; }
        public string ID { get; set; }
        public string MessageComplete { get; }
        public string MessageFailed { get; }
        public string MessageIncomplete { get; }
        public string Notes { get; }
        public bool Optional { get; set; }
        public int ParameterCount { get; }
        public IContractParameterHost Parent { get; }
        public Contract Root { get; }
        public ParameterState State { get; }
        public string Title { get; }

        public ContractParameter this[int index] { get; }
        public ContractParameter this[string id] { get; }
        public ContractParameter this[Type type] { get; }

        public ContractParameter AddParameter(ContractParameter parameter, string id = null);
        public bool AllChildParametersComplete();
        public bool AnyChildParametersFailed();
        protected virtual void AwardCompletion();
        public long CreateID();
        public void Disable();
        public void Enable();
        protected virtual string GetHashString();
        protected virtual string GetMessageComplete();
        protected virtual string GetMessageFailed();
        protected virtual string GetMessageIncomplete();
        protected virtual string GetNotes();
        public T GetParameter<T>(string id = null) where T : ContractParameter;
        public ContractParameter GetParameter(int index);
        public ContractParameter GetParameter(string id);
        public ContractParameter GetParameter(Type type);
        protected virtual string GetTitle();
        public void Load(ConfigNode node);
        public void NestToParent(IContractParameterHost parent);
        protected virtual void OnLoad(ConfigNode node);
        protected virtual void OnParameterStateChange(ContractParameter p);
        protected virtual void OnRegister();
        protected virtual void OnSave(ConfigNode node);
        protected virtual void OnUnregister();
        protected virtual void OnUpdate();
        public void ParameterStateUpdate(ContractParameter p);
        protected virtual void PenalizeFailure();
        public void Register();
        public void RemoveParameter(ContractParameter parameter);
        public void RemoveParameter(int index);
        public void RemoveParameter(string id);
        public void RemoveParameter(Type type);
        public void Save(ConfigNode node);
        protected void SendStateMessage(string title, string message, MessageSystemButton.MessageButtonColor color, MessageSystemButton.ButtonIcons icon);
        protected void SetComplete();
        protected void SetFailed();
        public void SetFunds(float completion, CelestialBody body = null);
        public void SetFunds(float completion, float failure, CelestialBody body = null);
        protected void SetIncomplete();
        public void SetReputation(float completion, CelestialBody body = null);
        public void SetReputation(float completion, float failure, CelestialBody body = null);
        public void SetScience(float completion, CelestialBody body = null);
        public void Unregister();
        public void Update();
    }
}
