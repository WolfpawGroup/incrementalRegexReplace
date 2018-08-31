namespace incrementalRegexReplace
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Regex = new System.Windows.Forms.TextBox();
			this.btn_AddReplace = new System.Windows.Forms.Button();
			this.p_Help = new System.Windows.Forms.Panel();
			this.tc_Tabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Quit = new System.Windows.Forms.Button();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.p_LightDark = new System.Windows.Forms.Panel();
			this.tb_Original = new System.Windows.Forms.RichTextBox();
			this.tb_Replaced = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tc_Tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Regex: ";
			// 
			// tb_Regex
			// 
			this.tb_Regex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Regex.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tb_Regex.Location = new System.Drawing.Point(83, 4);
			this.tb_Regex.Name = "tb_Regex";
			this.tb_Regex.Size = new System.Drawing.Size(456, 26);
			this.tb_Regex.TabIndex = 1;
			// 
			// btn_AddReplace
			// 
			this.btn_AddReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddReplace.Enabled = false;
			this.btn_AddReplace.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
			this.btn_AddReplace.Location = new System.Drawing.Point(538, 3);
			this.btn_AddReplace.Name = "btn_AddReplace";
			this.btn_AddReplace.Size = new System.Drawing.Size(70, 28);
			this.btn_AddReplace.TabIndex = 2;
			this.btn_AddReplace.Text = "Csere";
			this.btn_AddReplace.UseVisualStyleBackColor = true;
			// 
			// p_Help
			// 
			this.p_Help.BackgroundImage = global::incrementalRegexReplace.Properties.Resources.question_24;
			this.p_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_Help.Location = new System.Drawing.Point(57, 4);
			this.p_Help.Name = "p_Help";
			this.p_Help.Size = new System.Drawing.Size(26, 26);
			this.p_Help.TabIndex = 3;
			// 
			// tc_Tabs
			// 
			this.tc_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tc_Tabs.Controls.Add(this.tabPage1);
			this.tc_Tabs.Controls.Add(this.tabPage2);
			this.tc_Tabs.Location = new System.Drawing.Point(15, 86);
			this.tc_Tabs.Name = "tc_Tabs";
			this.tc_Tabs.SelectedIndex = 0;
			this.tc_Tabs.Size = new System.Drawing.Size(738, 400);
			this.tc_Tabs.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tb_Original);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(730, 374);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tp_Original";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tb_Replaced);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(730, 416);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tp_Replaced";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Location = new System.Drawing.Point(-1, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(767, 2);
			this.panel1.TabIndex = 5;
			// 
			// btn_Start
			// 
			this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Start.Enabled = false;
			this.btn_Start.Location = new System.Drawing.Point(15, 492);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 6;
			this.btn_Start.Text = "Futtatás";
			this.btn_Start.UseVisualStyleBackColor = true;
			// 
			// btn_Quit
			// 
			this.btn_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Quit.Location = new System.Drawing.Point(674, 492);
			this.btn_Quit.Name = "btn_Quit";
			this.btn_Quit.Size = new System.Drawing.Size(75, 23);
			this.btn_Quit.TabIndex = 7;
			this.btn_Quit.Text = "Kilépés";
			this.btn_Quit.UseVisualStyleBackColor = true;
			// 
			// btn_Copy
			// 
			this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Copy.Location = new System.Drawing.Point(258, 492);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.Size = new System.Drawing.Size(75, 23);
			this.btn_Copy.TabIndex = 8;
			this.btn_Copy.Text = "Másolás";
			this.btn_Copy.UseVisualStyleBackColor = true;
			// 
			// btn_Clear
			// 
			this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Clear.Location = new System.Drawing.Point(183, 492);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(75, 23);
			this.btn_Clear.TabIndex = 9;
			this.btn_Clear.Text = "Törlés";
			this.btn_Clear.UseVisualStyleBackColor = true;
			// 
			// p_LightDark
			// 
			this.p_LightDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.p_LightDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_LightDark.Location = new System.Drawing.Point(727, 4);
			this.p_LightDark.Name = "p_LightDark";
			this.p_LightDark.Size = new System.Drawing.Size(26, 26);
			this.p_LightDark.TabIndex = 4;
			// 
			// tb_Original
			// 
			this.tb_Original.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Original.Location = new System.Drawing.Point(3, 3);
			this.tb_Original.Name = "tb_Original";
			this.tb_Original.Size = new System.Drawing.Size(724, 368);
			this.tb_Original.TabIndex = 0;
			this.tb_Original.Text = "";
			// 
			// tb_Replaced
			// 
			this.tb_Replaced.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Replaced.Location = new System.Drawing.Point(3, 3);
			this.tb_Replaced.Name = "tb_Replaced";
			this.tb_Replaced.Size = new System.Drawing.Size(724, 410);
			this.tb_Replaced.TabIndex = 1;
			this.tb_Replaced.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 527);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.p_LightDark);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Copy);
			this.Controls.Add(this.btn_Quit);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tc_Tabs);
			this.Controls.Add(this.p_Help);
			this.Controls.Add(this.btn_AddReplace);
			this.Controls.Add(this.tb_Regex);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "IncrementalRegexReplace";
			this.tc_Tabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Regex;
		private System.Windows.Forms.Button btn_AddReplace;
		private System.Windows.Forms.Panel p_Help;
		private System.Windows.Forms.TabControl tc_Tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Quit;
		private System.Windows.Forms.Button btn_Copy;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.Panel p_LightDark;
		private System.Windows.Forms.RichTextBox tb_Original;
		private System.Windows.Forms.RichTextBox tb_Replaced;
		private System.Windows.Forms.Label label2;
	}
}

