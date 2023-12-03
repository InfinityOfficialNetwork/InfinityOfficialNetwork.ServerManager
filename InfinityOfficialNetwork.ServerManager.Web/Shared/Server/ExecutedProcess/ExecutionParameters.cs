using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace InfinityOfficialNetwork.ServerManager.Web.Shared.Server.ExecutedProcess
{
    public static class ExecutionParameters
    {
        public static string FileName { get; private set; }
        public static Collection<string> Arguments { get; private set; }
        public static string WorkingDirectory { get; private set; }
        public static bool RedirectStandardOutput { get; private set; }
        public static bool RedirectStandardInput { get; private set; }
        public static bool CreateNoWindow { get; private set; }
        public static bool UseShellExecute { get; private set; }

        static ExecutionParameters()
        {

        }
    }
}
