using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartupControl
{
	public partial class Form1 : Form
	{
		PerformanceCounter cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
		Timer timer = new Timer();

		const float FInterval = 0.05f;
		const string FSettingsFilename = "StartupControl.save";
		float FTotalTime = 2.0f;
		float FProgress = 0;

		public Form1()
		{
			InitializeComponent();
			timer.Start();
			timer.Interval = (int)(1000.0f * FInterval);
			timer.Tick +=new EventHandler(timer_Tick);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadSettings();
			if (Path == "" || !File.Exists(Path))
				SelectFile();
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		string Path
		{
			get
			{
				return loadPath.Text;
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
				Close();
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void Start()
		{
			timer.Stop();
			if (loadPath.Text != "")
			{
				Process.Start(loadPath.Text);
				Close();
			}
		}
		
		private void Close()
		{
			Application.Exit();
		}

		private void start_Click(object sender, EventArgs e)
		{
			Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			int usage = (int)cpu.NextValue();
			if (usage < target.Value)
				Progress(timer.Interval);
			else
				Progress(-timer.Interval);

			cpuUsage.Value = usage;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Progress(int millis)
		{
			FProgress += (float)millis / 1000.0f;
			if (FProgress < 0)
				FProgress = 0.0f;
			else if (FProgress > FTotalTime)
			{
				FProgress = FTotalTime;
				Start();
			}
			float progress = FProgress / FTotalTime;
			progressBar.Value = (int)(100.0f * progress);

			if (millis > 0)
				this.Text = "Starting in " + ((int)Math.Ceiling(FTotalTime - FProgress)).ToString() + "s";
			else
				this.Text = "Waiting for CPU load to drop below " + target.Value + "%";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SelectFile();
		}

		void SelectFile()
		{
			selectFileDialog.ShowDialog();
			loadPath.Text = selectFileDialog.FileName;
			SaveSettings();
		}

		void SaveSettings()
		{
			try
			{
				StreamWriter OutFile = new StreamWriter(FSettingsFilename);
				OutFile.WriteLine(loadPath.Text);
				OutFile.WriteLine(target.Value);
				OutFile.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "Cannot save!");
			}
		}

		void LoadSettings()
		{
			try
			{
				StreamReader InFile = new StreamReader(FSettingsFilename);
				loadPath.Text = InFile.ReadLine();
				target.Value = System.Convert.ToInt32(InFile.ReadLine());
				InFile.Close();
			}
			catch
			{
				target.Value = 20;
				loadPath.Text = "";
			}

			if (target.Value < 0)
				target.Value = 0;
			else if (target.Value > 100)
				target.Value = 100;
		}

		private void target_Scroll(object sender, EventArgs e)
		{
			SaveSettings();
		}

		private void loadPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (Path != "")
				Process.Start("explorer.exe", "/select," + loadPath.Text);
		}
	}
}
