using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ashenvale
{
    public class ProcessLifeMonitor
    {
        private frm_Main frm_Main;
        private volatile Process serverProcess;

        public ProcessLifeMonitor(frm_Main frm_Main, Process serverProcess)
        {
            this.frm_Main = frm_Main;
            this.serverProcess = serverProcess;
        }

        public void monitorProcessLife()
        {
            while (true)
            {
                serverProcess.WaitForExit();
                displayLine("Server process terminated...");

                displayLine("Redeploying fresh server instance...");
                serverProcess= deployServer();
            }
        }

        private Process deployServer()
        {
            try
            {
                if (frm_Main.InvokeRequired)
                {
                    Process reply = null;
                    frm_Main.Invoke((MethodInvoker)delegate
                    {
                        reply= frm_Main.deployServer();
                    });
                    return reply;
                }
                else
                {
                    return frm_Main.deployServer();
                }
            }
            catch (Exception)
            { }
            return null;
        }

        private void displayLine(string message)
        {
            try
            {
                if (frm_Main.InvokeRequired)
                {
                    frm_Main.Invoke((MethodInvoker)delegate
                    {
                        frm_Main.displayLine(message);
                    });
                }
                else
                {
                    frm_Main.displayLine(message);
                }
            }
            catch (Exception)
            { }
        }
    }
}