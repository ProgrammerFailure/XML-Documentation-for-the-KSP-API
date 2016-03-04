#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using Contracts.Agents;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Contracts
{
    [Serializable]
    public class Contract : IContractParameterHost
    {
        [SerializeField]
        protected Agent agent;
        public bool AutoAccept;
        [SerializeField]
        protected double dateAccepted;
        [SerializeField]
        protected double dateDeadline;
        [SerializeField]
        protected double dateExpire;
        [SerializeField]
        protected double dateFinished;
        [SerializeField]
        protected Contract.DeadlineType deadlineType;
        [SerializeField]
        protected Contract.DeadlineType expiryType;
        public double FundsAdvance;
        public double FundsCompletion;
        public double FundsFailure;
        public EventData<Contract.State> OnStateChange;
        [SerializeField]
        protected Contract.ContractPrestige prestige;
        public float ReputationCompletion;
        public float ReputationFailure;
        public float ScienceCompletion;
        public double TimeDeadline;
        public double TimeExpiry;

        public Contract();

        public Agent Agent { get; }
        public IEnumerable<ContractParameter> AllParameters { get; }
        public Guid ContractGuid { get; }
        public long ContractID { get; }
        public static int contractsInExistance { get; }
        public Contract.State ContractState { get; }
        public double DateAccepted { get; }
        public double DateDeadline { get; }
        public double DateExpire { get; }
        public double DateFinished { get; }
        public string Description { get; }
        protected static double GameTime { get; }
        public List<string> Keywords { get; }
        public List<string> KeywordsRequired { get; }
        public int MissionSeed { get; }
        public string Notes { get; }
        public int ParameterCount { get; }
        public IContractParameterHost Parent { get; }
        public Contract.ContractPrestige Prestige { get; }
        public Contract Root { get; }
        public string Synopsys { get; }
        public string Title { get; }

        public ContractParameter this[int index] { get; }
        public ContractParameter this[string id] { get; }
        public ContractParameter this[Type type] { get; }

        public bool Accept();
        protected bool AddKeywords(params string[] keywords);
        protected bool AddKeywordsRequired(params string[] keywords);
        public ContractParameter AddParameter(ContractParameter parameter, string id = null);
        protected virtual void AwardAdvance();
        protected virtual void AwardCompletion();
        public virtual bool CanBeCancelled();
        public virtual bool CanBeDeclined();
        public bool Cancel();
        public bool Complete();
        protected static int CountBodies_Complete(bool includeKerbin, bool includeSun, string nodeComplete);
        protected static int CountBodies_Reached(bool includeKerbin, bool includeSun);
        public bool Decline();
        public bool Fail();
        protected virtual bool Generate();
        public static Contract Generate(Type contractType, Contract.ContractPrestige difficulty, int seed, Contract.State state);
        public void GenerateFailed();
        protected static List<CelestialBody> GetBodies(bool includeKerbin, bool includeSun);
        protected static List<CelestialBody> GetBodies(Contract.ProgressState bodyState, Func<CelestialBody, bool> where = null);
        protected static List<CelestialBody> GetBodies(string nodeName, Contract.ProgressState nodeState, Func<CelestialBody, bool> where = null);
        protected static List<CelestialBody> GetBodies(Contract.ProgressState bodyState, string nodeName, Contract.ProgressState nodeState, Func<CelestialBody, bool> where = null);
        protected static List<CelestialBody> GetBodies_Complete(bool includeKerbin, bool includeSun, string complete);
        protected static List<CelestialBody> GetBodies_InComplete(bool includeKerbin, bool includeSun, string notComplete);
        protected static List<CelestialBody> GetBodies_NextUnreached(int depth, Func<CelestialBody, bool> where = null);
        protected static List<CelestialBody> GetBodies_NotReached(bool includeKerbin, bool includeSun);
        protected static List<CelestialBody> GetBodies_Reached(bool includeKerbin, bool includeSun);
        protected virtual string GetDescription();
        protected float GetDestinationWeight(CelestialBody body);
        protected virtual string GetHashString();
        protected virtual string GetNotes();
        public T GetParameter<T>(string id = null) where T : ContractParameter;
        public ContractParameter GetParameter(int index);
        public ContractParameter GetParameter(string id);
        public ContractParameter GetParameter(Type type);
        protected virtual string GetSynopsys();
        protected virtual string GetTitle();
        public bool IsFinished();
        public void Kill();
        public static Contract Load(Contract contract, ConfigNode node);
        public virtual bool MeetRequirements();
        protected virtual string MessageAccepted();
        protected virtual string MessageAdvances();
        protected virtual string MessageCancellationPenalties(double fundsPenalty, float repPenalty);
        protected virtual string MessageCancelled();
        protected virtual string MessageCompleted();
        protected virtual string MessageDeadlineExpired();
        protected virtual string MessageFailed();
        protected virtual string MessageFailurePenalties();
        protected virtual string MessageOffered();
        protected virtual string MessageOfferExpired();
        protected virtual string MessageRewards();
        public virtual string MissionControlTextRich();
        protected string MissionNotes();
        protected string MissionParameter(ContractParameter parameter, int indent);
        public bool Offer();
        protected virtual void OnAccepted();
        protected virtual void OnCancelled();
        protected virtual void OnCompleted();
        protected virtual void OnDeadlineExpired();
        protected virtual void OnDeclined();
        protected virtual void OnFailed();
        protected virtual void OnFinished();
        protected virtual void OnGenerateFailed();
        protected virtual void OnLoad(ConfigNode node);
        protected virtual void OnOffered();
        protected virtual void OnOfferExpired();
        protected virtual void OnParameterStateChange(ContractParameter p);
        protected virtual void OnRegister();
        protected virtual void OnSave(ConfigNode node);
        protected virtual void OnUnregister();
        protected virtual void OnUpdate();
        protected virtual void OnWithdrawn();
        public void ParameterStateUpdate(ContractParameter p);
        protected virtual void PenalizeCancellation();
        protected virtual void PenalizeFailure();
        public void Register();
        public void RemoveParameter(ContractParameter parameter);
        public void RemoveParameter(int index);
        public void RemoveParameter(string id);
        public void RemoveParameter(Type type);
        public void Save(ConfigNode node);
        protected void SendStateMessage(string title, string message, MessageSystemButton.MessageButtonColor color, MessageSystemButton.ButtonIcons icon);
        protected void SetDeadlineDays(float days, CelestialBody body = null);
        protected void SetDeadlineYears(float years, CelestialBody body = null);
        protected void SetExpiry();
        protected void SetExpiry(float minDays, float maxDays);
        protected void SetExpiry(int minDays, int maxDays);
        protected void SetFunds(float advance, float completion, CelestialBody body = null);
        protected void SetFunds(float advance, float completion, float failure, CelestialBody body = null);
        protected void SetReputation(float completion, CelestialBody body = null);
        protected void SetReputation(float completion, float failure, CelestialBody body = null);
        protected void SetScience(float completion, CelestialBody body = null);
        protected void SetState(Contract.State newState);
        public void Unregister();
        public void Update();
        public void Withdraw();

        public enum ContractPrestige
        {
            Trivial = 0,
            Significant = 1,
            Exceptional = 2,
        }

        public enum DeadlineType
        {
            Fixed = 0,
            Floating = 1,
            None = 2,
        }

        protected enum ProgressState
        {
            Unreached = 0,
            Reached = 1,
            Complete = 2,
        }

        public enum State
        {
            Generated = 0,
            Offered = 1,
            OfferExpired = 2,
            Declined = 3,
            Cancelled = 4,
            Active = 5,
            Completed = 6,
            DeadlineExpired = 7,
            Failed = 8,
            Withdrawn = 9,
        }
    }
}
