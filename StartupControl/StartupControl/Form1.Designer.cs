namespace StartupControl
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cancel = new System.Windows.Forms.Button();
			this.start = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cpuUsage = new System.Windows.Forms.ProgressBar();
			this.target = new System.Windows.Forms.TrackBar();
			this.loadPath = new System.Windows.Forms.LinkLabel();
			this.selectFile = new System.Windows.Forms.Button();
			this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
			this.SuspendLayout();
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(12, 188);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(260, 77);
			this.cancel.TabIndex = 0;
			this.cancel.Text = "Cancel (Esc)";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// start
			// 
			this.start.Location = new System.Drawing.Point(214, 128);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(58, 54);
			this.start.TabIndex = 1;
			this.start.Text = "Start";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 128);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(196, 54);
			this.progressBar.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cpuUsage);
			this.groupBox1.Controls.Add(this.target);
			this.groupBox1.Location = new System.Drawing.Point(12, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 77);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CPU usage";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Target";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Current";
			// 
			// cpuUsage
			// 
			this.cpuUsage.BackColor = System.Drawing.SystemColors.Control;
			this.cpuUsage.Location = new System.Drawing.Point(59, 51);
			this.cpuUsage.Name = "cpuUsage";
			this.cpuUsage.Size = new System.Drawing.Size(184, 13);
			this.cpuUsage.Step = 1;
			this.cpuUsage.TabIndex = 7;
			this.cpuUsage.Value = 50;
			// 
			// target
			// 
			this.target.BackColor = System.Drawing.SystemColors.Control;
			this.target.LargeChange = 20;
			this.target.Location = new System.Drawing.Point(50, 19);
			this.target.Maximum = 100;
			this.target.Name = "target";
			this.target.Size = new System.Drawing.Size(204, 45);
			this.target.SmallChange = 5;
			this.target.TabIndex = 9;
			this.target.TickFrequency = 5;
			this.target.Scroll += new System.EventHandler(this.target_Scroll);
			// 
			// loadPath
			// 
			this.loadPath.AutoEllipsis = true;
			this.loadPath.Location = new System.Drawing.Point(12, 8);
			this.loadPath.Name = "loadPath";
			this.loadPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.loadPath.Size = new System.Drawing.Size(218, 29);
			this.loadPath.TabIndex = 12;
			this.loadPath.TabStop = true;
			this.loadPath.Text = "So what happens when we have a really long url?";
			this.loadPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loadPath_LinkClicked);
			// 
			// selectFile
			// 
			this.selectFile.Location = new System.Drawing.Point(214, 8);
			this.selectFile.Name = "selectFile";
			this.selectFile.Size = new System.Drawing.Size(56, 31);
			this.selectFile.TabIndex = 13;
			this.selectFile.Text = "Select";
			this.selectFile.UseVisualStyleBackColor = true;
			this.selectFile.Click += new System.EventHandler(this.button1_Click);
			// 
			// selectFileDialog
			// 
			this.selectFileDialog.InitialDirectory = "c:\\";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 271);
			this.Controls.Add(this.selectFile);
			this.Controls.Add(this.loadPath);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.start);
			this.Controls.Add(this.cancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Starting in";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar cpuUsage;
		private System.Windows.Forms.TrackBar target;
		private System.Windows.Forms.LinkLabel loadPath;
		private System.Windows.Forms.Button selectFile;
		private System.Windows.Forms.OpenFileDialog selectFileDialog;
	}
}