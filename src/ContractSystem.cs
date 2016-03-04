#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;
using System.Collections.Generic;

namespace Contracts
{
    public class ContractSystem : ScenarioModule
    {
        public static List<Type> ContractTypes;
        public static List<Type> ParameterTypes;
        public static List<Type> PredicateTypes;

        public ContractSystem();

        public List<Contract> Contracts { get; }
        public List<Contract> ContractsFinished { get; }
        public static ContractSystem Instance { get; }

        public void ClearContractsCurrent();
        public void ClearContractsFinished();
        public Contract GenerateContract(int seed, Contract.ContractPrestige difficulty, Type contractType = null);
        public int GetActiveContractCount();
        public T[] GetCompletedContracts<T>() where T : Contract;
        public static void GetContractCounts(float rep, int avgContracts, out int tier1, out int tier2, out int tier3);
        public static Type GetContractType(string typeName);
        public T[] GetCurrentActiveContracts<T>() where T : Contract;
        public T[] GetCurrentContracts<T>() where T : Contract;
        public static Type GetParameterType(string typeName);
        public static Type GetPredicateType(string typeName);
        public bool HasCompletedContract(Type type);
        public override void OnAwake();
        public override void OnLoad(ConfigNode gameNode);
        public override void OnSave(ConfigNode gameNode);
        public void RebuildContracts();
    }
}
