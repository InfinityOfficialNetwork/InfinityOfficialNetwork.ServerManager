using System.Diagnostics;

namespace InfinityOfficialNetwork.ServerManager.Web.Shared.Server.Events
{
    public class OnStartEventArgs : EventArgs
    {
        public Process Process { get; private init; }

        public OnStartEventArgs(Process process)
        {
            Process = process;
        }
    }
}
