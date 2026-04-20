using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    class SimpleTaskDialog
    {
        [DllImport("comctl32.dll", CharSet = CharSet.Unicode, EntryPoint = "TaskDialog")]
        static extern int _TaskDialog(IntPtr hWndParent, IntPtr hInstance, String pszWindowTitle, String pszMainInstruction, String pszContent, int dwCommonButtons, IntPtr pszIcon, out int pnButton);

        [Flags]
        public enum TaskDialogButtons
        {
            OK = 0x0001,
            Cancel = 0x0008,
            Yes = 0x0002,
            No = 0x0004,
            Retry = 0x0010,
            Close = 0x0020
        }

        public enum TaskDialogIcon
        {
            Information = UInt16.MaxValue - 2,
            Warning = UInt16.MaxValue,
            Stop = UInt16.MaxValue - 1,
            Question = 0,
            SecurityWarning = UInt16.MaxValue - 5,
            SecurityError = UInt16.MaxValue - 6,
            SecuritySuccess = UInt16.MaxValue - 7,
            SecurityShield = UInt16.MaxValue - 3,
            SecurityShieldBlue = UInt16.MaxValue - 4,
            SecurityShieldGray = UInt16.MaxValue - 8
        }

        public enum TaskDialogResult
        {
            None,
            OK,
            Cancel,
            Yes,
            No,
            Retry,
            Close
        }

        private static TaskDialogResult ShowInternal(IntPtr owner, string text, string instruction, string caption, TaskDialogButtons buttons, TaskDialogIcon icon)
        {
            int p;
            if (_TaskDialog(owner, IntPtr.Zero, caption, instruction, text, (int)buttons, new IntPtr((int)icon), out p) != 0)
                throw new InvalidOperationException("Something weird has happened.");

            switch (p)
            {
                case 1: return TaskDialogResult.OK;
                case 2: return TaskDialogResult.Cancel;
                case 4: return TaskDialogResult.Retry;
                case 6: return TaskDialogResult.Yes;
                case 7: return TaskDialogResult.No;
                case 8: return TaskDialogResult.Close;
                default: return TaskDialogResult.None;
            }
        }

        public static TaskDialogResult Show(IWin32Window owner, string text)
        {
            return Show(owner, text, null, null, TaskDialogButtons.OK);
        }

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction)
        {
            return Show(owner, text, instruction, null, TaskDialogButtons.OK, 0);
        }

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction, string caption)
        {
            return Show(owner, text, instruction, caption, TaskDialogButtons.OK, 0);
        }

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction, string caption, TaskDialogButtons buttons)
        {
            return Show(owner, text, instruction, caption, buttons, 0);
        }

        public static TaskDialogResult Show(IWin32Window owner, string text, string instruction, string caption, TaskDialogButtons buttons, TaskDialogIcon icon)
        {
            return ShowInternal(owner.Handle, text, instruction, caption, buttons, icon);
        }

        public static TaskDialogResult Show(string text)
        {
            return Show(text, null, null, TaskDialogButtons.OK);
        }

        public static TaskDialogResult Show(string text, string instruction)
        {
            return Show(text, instruction, null, TaskDialogButtons.OK, 0);
        }

        public static TaskDialogResult Show(string text, string instruction, string caption)
        {
            return Show(text, instruction, caption, TaskDialogButtons.OK, 0);
        }

        public static TaskDialogResult Show(string text, string instruction, string caption, TaskDialogButtons buttons)
        {
            return Show(text, instruction, caption, buttons, 0);
        }

        public static TaskDialogResult Show(string text, string instruction, string caption, TaskDialogButtons buttons, TaskDialogIcon icon)
        {
            return ShowInternal(IntPtr.Zero, text, instruction, caption, buttons, icon);
        }
    }

    class OSVersion
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct OSVERSIONINFO
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
        }

        // --------------------------------------
        //     OS                   Major.Minor
        // --------------------------------------
        // Windows Server 2008      6.0 
        // Windows Vista            6.0
        // Windows Server 2003 R2   5.2
        // Windows Server 2003      5.2
        // Windows XP               5.1
        // Windows 2000             5.0 
        // --------------------------------------

        [DllImport("kernel32.Dll")]
        public static extern short GetVersionEx(ref OSVERSIONINFO o);

        static public string GetOSVersionInfo()
        {
            OSVERSIONINFO os = new OSVERSIONINFO();
            os.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
            GetVersionEx(ref os);

            return os.dwMajorVersion.ToString() + "." + os.dwMinorVersion.ToString();
        }

        static public int GetMajorVersion()
        {
            OSVERSIONINFO os = new OSVERSIONINFO();
            os.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
            GetVersionEx(ref os);

            return os.dwMajorVersion;
        }

        static public int GetMinorVersion()
        {
            OSVERSIONINFO os = new OSVERSIONINFO();
            os.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
            GetVersionEx(ref os);

            return os.dwMinorVersion;
        }
    }

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OSVersion.GetMajorVersion() == 6)
                SimpleTaskDialog.Show(this, "В программах, работающих в Windows Vista, " +
            "для ввывода сообщений можно использовать TaskDialog",
                    "На вашем компьютере установлена операционная система Windows Vista", "TaskDialog Demo",
                    SimpleTaskDialog.TaskDialogButtons.Yes, // | TaskDialog.TaskDialogButtons.No | TaskDialog.TaskDialogButtons.Cancel,
                    SimpleTaskDialog.TaskDialogIcon.Information);
            else
                MessageBox.Show("TaskDialog можно использовать только в программах," +
                    "работающих в Windows Vista", "TaskDialog Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}