/*
 * Created by SharpDevelop.
 * User: Roque.Possamai
 * Date: 02/08/2019
 */
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyNotesFree.component
{
	/// <summary>
	/// Biblioteca genérica para facilitar a manipulação da API do Windows
	/// </summary>
	public static class WinNoteApi
	{
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr WindowHandle);
		[DllImport("user32.dll", ExactSpelling = true)]
		public static extern bool BringWindowToTop(IntPtr hwnd);
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool LockSetForegroundWindow(uint uLockCode);
		[DllImport("user32.dll")]
		public static extern bool AllowSetForegroundWindow(int dwProcessId);
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsIconic(IntPtr hWnd);
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		[DllImport("user32.dll")]
		public static extern IntPtr SetFocus(IntPtr hWnd);
		[DllImport("user32.dll")]
		public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);
		[DllImport("user32.dll", SetLastError = true)]
		public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
		[DllImport("kernel32.dll")]
		public static extern uint GetCurrentThreadId();
		[DllImport("kernel32.dll", EntryPoint = "LoadLibraryW", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadLibraryW(string s_File);
    	
		const int LSFW_UNLOCK = 2;
		const int ASFW_ANY = -1;

		public enum KeyModifier
		{
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
			WinKey = 8
		}
		
		public enum ShowWindowFlags
		{
			Hide = 0,
			ShowNormal = 1,
			Normal = 1,
			ShowMinimized = 2,
			ShowMaximized = 3,
			Maximize = 3,
			ShowNoActivate = 4,
			Show = 5,
			Minimize = 6,
			ShowMinNoActive = 7,
			ShowNA = 8,
			Restore = 9,
			ShowDefault = 10,
			ForceMinimize = 11,
			Max = 11,
		}
		        
		public static void ForceForegroundWindow(IntPtr hWnd)
		{
			uint a;
			LockSetForegroundWindow(LSFW_UNLOCK);
			AllowSetForegroundWindow(ASFW_ANY);
 
			IntPtr hWndForeground = GetForegroundWindow();
			SendKeys.SendWait("{UP}");
			if (hWndForeground.ToInt32() != 0) {
				if (hWndForeground != hWnd) {
					uint thread1 = GetWindowThreadProcessId(hWndForeground, out a);
					uint thread2 = GetCurrentThreadId();
 
 
					if (thread1 != thread2) {
						AttachThreadInput(thread1, thread2, true);
						LockSetForegroundWindow(LSFW_UNLOCK);
						AllowSetForegroundWindow(ASFW_ANY);
						BringWindowToTop(hWnd);
						if (IsIconic(hWnd)) {
							ShowWindow(hWnd, (int)ShowWindowFlags.ShowNormal);
						} else {
							ShowWindow(hWnd, (int)ShowWindowFlags.Show);
						}
						SetFocus(hWnd);
						AttachThreadInput(thread1, thread2, false);
					} else {
						AttachThreadInput(thread1, thread2, true);
						LockSetForegroundWindow(LSFW_UNLOCK);
						AllowSetForegroundWindow(ASFW_ANY);
						BringWindowToTop(hWnd);
						SetForegroundWindow(hWnd);
						SetFocus(hWnd);
						AttachThreadInput(thread1, thread2, false);
 
					}
					if (IsIconic(hWnd)) {
						AttachThreadInput(thread1, thread2, true);
						LockSetForegroundWindow(LSFW_UNLOCK);
						AllowSetForegroundWindow(ASFW_ANY);
						BringWindowToTop(hWnd);
						ShowWindow(hWnd, (int)ShowWindowFlags.ShowNormal);
						SetFocus(hWnd);
						AttachThreadInput(thread1, thread2, false);
					} else {
						BringWindowToTop(hWnd);
						ShowWindow(hWnd, (int)ShowWindowFlags.Show);
					}
				}
				SetForegroundWindow(hWnd);
				SetFocus(hWnd);
			} else {
				uint thread1 = GetWindowThreadProcessId(hWndForeground, out a);
				uint thread2 = GetCurrentThreadId();
				try {
					AttachThreadInput(thread1, thread2, true);
				} catch {
//                  uint failure = 1;
				}
				LockSetForegroundWindow(LSFW_UNLOCK);
				AllowSetForegroundWindow(ASFW_ANY);
				BringWindowToTop(hWnd);
				SetForegroundWindow(hWnd);
 
				ShowWindow(hWnd, (int)ShowWindowFlags.Show);
				SetFocus(hWnd);
				AttachThreadInput(thread1, thread2, false);
			}
		}
	
		public static IntPtr LoadLibrary(string s_File)
		{
			IntPtr h_Module = LoadLibraryW(s_File);
			if (h_Module != IntPtr.Zero)
				return h_Module;

			int s32_Error = Marshal.GetLastWin32Error();
			throw new Win32Exception(s32_Error);
		}
	}
}
