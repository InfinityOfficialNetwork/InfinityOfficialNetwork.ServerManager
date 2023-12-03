using System.Diagnostics;

namespace InfinityOfficialNetwork.ServerManager.Web.Shared.Server.Events
{
    public class OnForceKillEventArgs : EventArgs
    {
        public Process Process { get; private init; }

        public OnForceKillEventArgs(Process process)
        {
            Process = process;
        }
    }
}
