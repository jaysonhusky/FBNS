using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace FBNS.My
{
	sealed partial class MyProject
	{
		[ThreadStatic] static MyApplication application;
		
		public static MyApplication Application {
			[DebuggerStepThrough]
			get {
				if (application == null)
					application = new MyApplication();
				return application;
			}
		}
		
		[ThreadStatic] static MyComputer computer;
		
		public static MyComputer Computer {
			[DebuggerStepThrough]
			get {
				if (computer == null)
					computer = new MyComputer();
				return computer;
			}
		}
		
		[ThreadStatic] static User user;
		
		public static User User {
			[DebuggerStepThrough]
			get {
				if (user == null)
					user = new User();
				return user;
			}
		}
		
		[ThreadStatic] static MyForms forms;
		
		public static MyForms Forms {
			[DebuggerStepThrough]
			get {
				if (forms == null)
					forms = new MyForms();
				return forms;
			}
		}
		
		internal sealed class MyForms
		{
			global::FBNS.Additional Additional_instance;
			bool Additional_isCreating;
			public global::FBNS.Additional Additional {
				[DebuggerStepThrough] get { return GetForm(ref Additional_instance, ref Additional_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Additional_instance, value); }
			}
			
			global::FBNS.Form1 Form1_instance;
			bool Form1_isCreating;
			public global::FBNS.Form1 Form1 {
				[DebuggerStepThrough] get { return GetForm(ref Form1_instance, ref Form1_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Form1_instance, value); }
			}
			
			global::FBNS.SettingsPanel SettingsPanel_instance;
			bool SettingsPanel_isCreating;
			public global::FBNS.SettingsPanel SettingsPanel {
				[DebuggerStepThrough] get { return GetForm(ref SettingsPanel_instance, ref SettingsPanel_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref SettingsPanel_instance, value); }
			}
			
			global::FBNS.Loader Loader_instance;
			bool Loader_isCreating;
			public global::FBNS.Loader Loader {
				[DebuggerStepThrough] get { return GetForm(ref Loader_instance, ref Loader_isCreating); }
				[DebuggerStepThrough] set { SetForm(ref Loader_instance, value); }
			}
			
			[DebuggerStepThrough]
			static T GetForm<T>(ref T instance, ref bool isCreating) where T : Form, new()
			{
				if (instance == null || instance.IsDisposed) {
					if (isCreating) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					isCreating = true;
					try {
						instance = new T();
					} catch (System.Reflection.TargetInvocationException ex) {
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message }), ex.InnerException);
					} finally {
						isCreating = false;
					}
				}
				return instance;
			}
			
			[DebuggerStepThrough]
			static void SetForm<T>(ref T instance, T value) where T : Form
			{
				if (instance != value) {
					if (value == null) {
						instance.Dispose();
						instance = null;
					} else {
						throw new ArgumentException("Property can only be set to null");
					}
				}
			}
		}
	}
	
	partial class MyApplication : WindowsFormsApplicationBase
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
			MyProject.Application.Run(args);
		}
	}
	
	partial class MyComputer : Computer
	{
	}
}
