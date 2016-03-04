#region Assembly Assembly-CSharp.dll, v1.0.0.0
// H:\KSP_win\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using Contracts.Agents;
using System;

namespace Contracts
{
    public static class TextGen
    {
        public static AgentList Agencies;

        public static string GenerateBackStories(string agency, string mindset, string topic, string subject, string motivation, int seed);
        public static ConfigNode GetMergedConfigNodes(string nodename);
        public static void Setup();

        public class TextSet
        {
            public TextSet(string id);
            public TextSet(string id, ConfigNode node);

            public int Count { get; }
            public string id { get; }

            public string getText(string contextKey, string fallback);
            public void Load(ConfigNode node);
        }
    }
}
