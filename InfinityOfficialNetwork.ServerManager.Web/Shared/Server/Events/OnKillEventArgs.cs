using System.Diagnostics;

namespace InfinityOfficialNetwork.ServerManager.Web.Shared.Server.Events
{
    public class OnKillEventArgs : EventArgs
    {
        public Process Process { get; private init; }

        public OnKillEventArgs(Process process)
        {
            Process = process;
        }
    }
}
