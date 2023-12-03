using System.Diagnostics;

namespace InfinityOfficialNetwork.ServerManager.Web.Shared.Server.ExecutedProcess
{
    public static class Details
    {
        public static Process Process { get; private set; }
        public static bool IsRunning { get; private set; }

        private static StreamWriter StandardInput;
        private static StreamReader StandardOutput;
        private static StreamReader StandardError;


        static Details()
        {
            Process = new Process();
            IsRunning = false;
        }

        private static void ConfigureProcess()
        {
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardError = true;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.RedirectStandardOutput = true;

        }

        private static void StartProcess()
        {
            Process.Start();
            IsRunning = true;
            StandardInput = Process.StandardInput;
            StandardOutput = Process.StandardOutput;
            StandardError = Process.StandardError;
        }

        private static void KillProcess()
        {
            Process.Kill();
            // Send Ctrl+C to process

            IsRunning = false;
        }

        private static void ForceKilledProcess()
        {
            Process.Kill();
            IsRunning = false;
        }

        public static void Start()
        {
            if (!IsRunning)
            {
                Process.Start();
                OnStart?.Invoke(null, EventArgs.Empty);
                Process.WaitForExit();
            }
            else
            {
                throw new Exception("Process already running");
            }
        }

        public static void Kill()
        {
            if (IsRunning)
            {
                Process.Kill();
                OnKill?.Invoke(null, EventArgs.Empty);
            }
            else
            {
                throw new Exception("Process not running");
            }
        }

        public static void FocreKill()
        {
            if (IsRunning)
            {
                Process.Kill();
                OnForceKill?.Invoke(null, EventArgs.Empty);
                OnKill?.Invoke(null, EventArgs.Empty);
            }
            else
            {
                throw new Exception("Process not running");
            }
        }

        public static event EventHandler<EventArgs> OnStart;
        public static event EventHandler<EventArgs> OnKill;
        public static event EventHandler<EventArgs> OnForceKill;

        private static void SendStandardInput(string input)
        {
            StandardInput.WriteLine(input);
        }
    }
}
