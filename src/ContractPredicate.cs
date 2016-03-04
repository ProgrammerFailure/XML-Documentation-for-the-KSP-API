#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using UnityEngine;

namespace Contracts
{
    [Serializable]
    public class ContractPredicate
    {
        public ContractPredicate(IContractParameterHost parent);

        public bool AllowMultiple { get; }
        public string Description { get; }
        [HideInInspector]
        public IContractParameterHost Parent { get; }
        [HideInInspector]
        public Contract Root { get; }

        protected virtual bool GetAllowMultiple();
        protected virtual string GetDescription();
        public void Load(ConfigNode node);
        protected virtual void OnLoad(ConfigNode node);
        protected virtual void OnSave(ConfigNode node);
        protected virtual void OnUpdate();
        public void Save(ConfigNode node);
        public virtual bool Test(ProtoVessel vessel);
        public virtual bool Test(Vessel vessel);
        public void Update();
    }
}
