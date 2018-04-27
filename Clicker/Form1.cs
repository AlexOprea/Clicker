using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool execute = false;

        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        Timer timer = new Timer();
        private InputSimulator inputSimulator = new InputSimulator();
        private Process[] processes = null;
        private IntPtr process;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(int hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Get a handle to an application window.
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);


        private void checkBoxLC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (processes == null)
            {
                processes = Process.GetProcessesByName("Conquer");
            }
            if (processes != null && processes.Length > 0)
            {
                process = processes[0].MainWindowHandle;
                SetForegroundWindow(process);
                debugLog.AppendText("Found \n");
            }
            float freValue = (float)freqValue.Value;
            int valueToSleep = (int)(1000 * freValue);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = valueToSleep;
            timer.Enabled = true;
            timer.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (checkBoxLC.Checked )
            {
                
                // inputSimulator.Mouse.LeftButtonDown();
                // inputSimulator.Mouse.LeftButtonUp();
                //PostMessage(process, MOUSEEVENTF_LEFTDOWN| MOUSEEVENTF_LEFTUP, 0, 1);
                SendMessage(process, MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (IntPtr)0, (IntPtr)0);
                // PostMessage(process, MOUSEEVENTF_LEFTUP| MOUSEEVENTF_ABSOLUTE, 0, 1);

            }
            if (checkBoxRC.Checked)
            {
                //inputSimulator.Mouse.RightButtonDown();
                //inputSimulator.Mouse.RightButtonUp();
                //PostMessage(process, MOUSEEVENTF_RIGHTDOWN| MOUSEEVENTF_RIGHTUP, 0, 1);
                // PostMessage(process, MOUSEEVENTF_RIGHTUP| MOUSEEVENTF_ABSOLUTE, 0, 1);
                SendMessage(process, MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (IntPtr)0, (IntPtr)0);
            }
        }

    }
}
