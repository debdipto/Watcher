using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashenvale
{
    public partial class frm_Main : Form
    {
        ProcessStartInfo proc = null;
        Process serverProcess = null;
        ParallelListener parallel;
        Thread parallelThread = null;
        ProcessLifeMonitor processLifeMonitor = null;
        Thread processLifeMonitorThread = null;

        public frm_Main()
        {
            InitializeComponent();
            initialize();
        }

        private void initialize()
        {
            if(Ashenvale.Properties.Settings.Default.selectedServerpath != String.Empty)
            {
                lbl_ServerLink.Text = Ashenvale.Properties.Settings.Default.selectedServerpath;
            }
            else
            {
                lbl_ServerLink.Text = "N/A";
            }

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                switch (args[1])
                {
                    case "-AutoOn":
                        {
                            if (lbl_ServerLink.Text != "N/A")
                            {
                                displayLine("Turning Server ON");
                                firstDeploy();
                            }
                        }
                        break;
                    default:
                        {
                            displayLine("[Exception] Invalid input parameter, please consult documentation...");
                        }
                        break;
                }
            }

            startListening();
        }

        private void startListening()
        {
            parallel = new ParallelListener(this);
            parallelThread = new Thread(new ThreadStart(parallel.listen));
            parallelThread.Start();
        }
        public void displayLine(String message,bool addDate=true)
        {
            DateTime dt = DateTime.Now;
            String timestamp = String.Empty;
            if (addDate)
                timestamp = Environment.NewLine + "[" + dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + " " + dt.TimeOfDay + "] ";
            txtb_Display.AppendText(timestamp+" " + message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            openFileDialog1.Filter = ".exe|*.exe|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_ServerLink.Text = openFileDialog1.FileName;
                Ashenvale.Properties.Settings.Default.selectedServerpath = openFileDialog1.FileName;
                Ashenvale.Properties.Settings.Default.Save();
            }
        }

        public Process deployServer()
        {
            proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.FileName = lbl_ServerLink.Text;
            proc.Arguments = " -AutoOn";
            proc.Verb = "";

            try
            {
                displayLine("Deploying server located at :" + lbl_ServerLink.Text);
                serverProcess = Process.Start(proc);
                displayLine("Successfully deployed server");
                return serverProcess;
            }
            catch
            {
                MessageBox.Show("Application failed to start..");
            }
            return null;
        }

        private void btn_Deploy_Click(object sender, EventArgs e)
        {
            firstDeploy();
        }

        private void firstDeploy()
        {
            proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.FileName = lbl_ServerLink.Text;
            proc.Arguments = " -AutoOn";
            proc.Verb = "";

            try
            {
                displayLine("Deploying server located at :" + lbl_ServerLink.Text);
                serverProcess = Process.Start(proc);
                displayLine("Successfully deployed server");

                //Deploy server process monitor
                processLifeMonitor = new ProcessLifeMonitor(this, serverProcess);
                processLifeMonitorThread = new Thread(new ThreadStart(processLifeMonitor.monitorProcessLife));
                processLifeMonitorThread.Start();

                //Deploy server heartbeat monitor

                //Deploy watcher neighbour monitors
            }
            catch
            {
                MessageBox.Show("Application failed to start..");
            }
        }

        private void btn_TestHeartbeat_Click(object sender, EventArgs e)
        {

        }

        public void resetWatcher()
        {
            //clean up server process monitor thread
            if(processLifeMonitorThread!=null && processLifeMonitorThread.IsAlive)
            {
                try
                {
                    processLifeMonitorThread.Abort();
                    displayLine("[Aborting process monitor thread] Process Life Monitor Thread killed");
                    processLifeMonitorThread = null;                    
                }
                catch(Exception e)
                {
                    displayLine("[Aborting process monitor thread] " + e.StackTrace);
                }
            }


            //clean up server process
            if(serverProcess!=null)
            {
                try
                {
                    serverProcess.Kill();
                    serverProcess = null;
                    displayLine("[Aborting Server Process] Server process killed");
                }
                catch (Exception e)
                {
                    displayLine("[Aborting Server Process] " + e.StackTrace);
                }
            }

            if (parallelThread != null && parallelThread.IsAlive)
            {
                try
                {
                    parallel.serverSocket.Stop();
                    if (parallel.clientSocket != null)
                        parallel.clientSocket.Close();

                    parallelThread.Abort();
                    displayLine("[Aborting Parallel Listener thread] Parallel Listener Thread killed");
                    parallelThread = null;
                }
                catch (Exception e)
                {
                    displayLine("[Aborting Parallel Listener thread] " + e.StackTrace);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetWatcher();
            Dispose();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetWatcher();
        }

        private void watcherPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
