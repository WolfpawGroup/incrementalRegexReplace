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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Regex = new System.Windows.Forms.TextBox();
			this.cms_Regex = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_cms_regex_History = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_AddReplace = new System.Windows.Forms.Button();
			this.tc_Tabs = new System.Windows.Forms.TabControl();
			this.tp_Original = new System.Windows.Forms.TabPage();
			this.rtb_Original = new System.Windows.Forms.RichTextBox();
			this.tp_Replaced = new System.Windows.Forms.TabPage();
			this.tb_Replaced = new System.Windows.Forms.RichTextBox();
			this.tp_Help = new System.Windows.Forms.TabPage();
			this.wb_Help = new System.Windows.Forms.WebBrowser();
			this.panel2 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Quit = new System.Windows.Forms.Button();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.btn_Save = new System.Windows.Forms.Button();
			this.p_LightDark = new System.Windows.Forms.Panel();
			this.p_Help = new System.Windows.Forms.Panel();
			this.btn_X = new System.Windows.Forms.Button();
			this.p_BtnHolder = new System.Windows.Forms.Panel();
			this.btn_CheckRegexMatches = new System.Windows.Forms.Button();
			this.cms_Regex.SuspendLayout();
			this.tc_Tabs.SuspendLayout();
			this.tp_Original.SuspendLayout();
			this.tp_Replaced.SuspendLayout();
			this.tp_Help.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.p_BtnHolder.SuspendLayout();
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
			this.tb_Regex.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tb_Regex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_Regex.ContextMenuStrip = this.cms_Regex;
			this.tb_Regex.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tb_Regex.Location = new System.Drawing.Point(127, 4);
			this.tb_Regex.Name = "tb_Regex";
			this.tb_Regex.Size = new System.Drawing.Size(547, 26);
			this.tb_Regex.TabIndex = 1;
			this.tb_Regex.TextChanged += new System.EventHandler(this.tb_Regex_TextChanged);
			// 
			// cms_Regex
			// 
			this.cms_Regex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cms_regex_History});
			this.cms_Regex.Name = "cms_Regex";
			this.cms_Regex.Size = new System.Drawing.Size(113, 26);
			this.cms_Regex.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Regex_Opening);
			// 
			// btn_cms_regex_History
			// 
			this.btn_cms_regex_History.Name = "btn_cms_regex_History";
			this.btn_cms_regex_History.Size = new System.Drawing.Size(112, 22);
			this.btn_cms_regex_History.Text = "History";
			// 
			// btn_AddReplace
			// 
			this.btn_AddReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddReplace.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_AddReplace.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_AddReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_AddReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_AddReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddReplace.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_AddReplace.Location = new System.Drawing.Point(672, 4);
			this.btn_AddReplace.Margin = new System.Windows.Forms.Padding(0);
			this.btn_AddReplace.Name = "btn_AddReplace";
			this.btn_AddReplace.Size = new System.Drawing.Size(86, 26);
			this.btn_AddReplace.TabIndex = 2;
			this.btn_AddReplace.Text = "${SET}";
			this.btn_AddReplace.UseVisualStyleBackColor = true;
			this.btn_AddReplace.Click += new System.EventHandler(this.btn_AddReplace_Click);
			// 
			// tc_Tabs
			// 
			this.tc_Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tc_Tabs.Controls.Add(this.tp_Original);
			this.tc_Tabs.Controls.Add(this.tp_Replaced);
			this.tc_Tabs.Controls.Add(this.tp_Help);
			this.tc_Tabs.Location = new System.Drawing.Point(15, 86);
			this.tc_Tabs.Name = "tc_Tabs";
			this.tc_Tabs.SelectedIndex = 0;
			this.tc_Tabs.Size = new System.Drawing.Size(777, 383);
			this.tc_Tabs.TabIndex = 4;
			this.tc_Tabs.SelectedIndexChanged += new System.EventHandler(this.tc_Tabs_SelectedIndexChanged);
			// 
			// tp_Original
			// 
			this.tp_Original.Controls.Add(this.rtb_Original);
			this.tp_Original.Location = new System.Drawing.Point(4, 22);
			this.tp_Original.Name = "tp_Original";
			this.tp_Original.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Original.Size = new System.Drawing.Size(769, 357);
			this.tp_Original.TabIndex = 0;
			this.tp_Original.Text = "Original Text (Input)";
			this.tp_Original.UseVisualStyleBackColor = true;
			// 
			// rtb_Original
			// 
			this.rtb_Original.BackColor = System.Drawing.Color.WhiteSmoke;
			this.rtb_Original.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_Original.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtb_Original.Location = new System.Drawing.Point(3, 3);
			this.rtb_Original.Name = "rtb_Original";
			this.rtb_Original.Size = new System.Drawing.Size(763, 351);
			this.rtb_Original.TabIndex = 0;
			this.rtb_Original.Text = "";
			// 
			// tp_Replaced
			// 
			this.tp_Replaced.Controls.Add(this.tb_Replaced);
			this.tp_Replaced.Location = new System.Drawing.Point(4, 22);
			this.tp_Replaced.Name = "tp_Replaced";
			this.tp_Replaced.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Replaced.Size = new System.Drawing.Size(769, 357);
			this.tp_Replaced.TabIndex = 1;
			this.tp_Replaced.Text = "Replaced Text (Output)";
			this.tp_Replaced.UseVisualStyleBackColor = true;
			// 
			// tb_Replaced
			// 
			this.tb_Replaced.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tb_Replaced.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Replaced.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
			this.tb_Replaced.Location = new System.Drawing.Point(3, 3);
			this.tb_Replaced.Name = "tb_Replaced";
			this.tb_Replaced.Size = new System.Drawing.Size(763, 351);
			this.tb_Replaced.TabIndex = 1;
			this.tb_Replaced.Text = "";
			// 
			// tp_Help
			// 
			this.tp_Help.Controls.Add(this.wb_Help);
			this.tp_Help.Controls.Add(this.panel2);
			this.tp_Help.Controls.Add(this.statusStrip1);
			this.tp_Help.Location = new System.Drawing.Point(4, 22);
			this.tp_Help.Name = "tp_Help";
			this.tp_Help.Padding = new System.Windows.Forms.Padding(3);
			this.tp_Help.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tp_Help.Size = new System.Drawing.Size(769, 357);
			this.tp_Help.TabIndex = 2;
			this.tp_Help.Text = "Help";
			this.tp_Help.UseVisualStyleBackColor = true;
			// 
			// wb_Help
			// 
			this.wb_Help.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wb_Help.Location = new System.Drawing.Point(3, 23);
			this.wb_Help.MinimumSize = new System.Drawing.Size(20, 20);
			this.wb_Help.Name = "wb_Help";
			this.wb_Help.Size = new System.Drawing.Size(763, 309);
			this.wb_Help.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(763, 20);
			this.panel2.TabIndex = 2;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(3, 332);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(763, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Location = new System.Drawing.Point(-1, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(806, 2);
			this.panel1.TabIndex = 5;
			// 
			// btn_Start
			// 
			this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Start.Enabled = false;
			this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Start.Location = new System.Drawing.Point(15, 475);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 6;
			this.btn_Start.Text = "Run Regex";
			this.btn_Start.UseVisualStyleBackColor = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// btn_Quit
			// 
			this.btn_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Quit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_Quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Quit.Location = new System.Drawing.Point(717, 475);
			this.btn_Quit.Name = "btn_Quit";
			this.btn_Quit.Size = new System.Drawing.Size(75, 23);
			this.btn_Quit.TabIndex = 7;
			this.btn_Quit.Text = "Exit";
			this.btn_Quit.UseVisualStyleBackColor = true;
			// 
			// btn_Copy
			// 
			this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Copy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_Copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_Copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Copy.Location = new System.Drawing.Point(234, 475);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.Size = new System.Drawing.Size(75, 23);
			this.btn_Copy.TabIndex = 8;
			this.btn_Copy.Text = "Copy";
			this.btn_Copy.UseVisualStyleBackColor = true;
			// 
			// btn_Clear
			// 
			this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Clear.Location = new System.Drawing.Point(442, 475);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(75, 23);
			this.btn_Clear.TabIndex = 9;
			this.btn_Clear.Text = "Clear";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Starting number: ";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(317, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Increment by: ";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(561, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Pad to # with leading zeros:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDown1.Location = new System.Drawing.Point(105, 41);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(156, 26);
			this.numericUpDown1.TabIndex = 13;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numericUpDown2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDown2.Location = new System.Drawing.Point(397, 41);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(108, 26);
			this.numericUpDown2.TabIndex = 14;
			this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numericUpDown3.Location = new System.Drawing.Point(705, 41);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(53, 26);
			this.numericUpDown3.TabIndex = 15;
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Save.Location = new System.Drawing.Point(311, 475);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 16;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// p_LightDark
			// 
			this.p_LightDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.p_LightDark.BackgroundImage = global::incrementalRegexReplace.Properties.Resources.night_code;
			this.p_LightDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_LightDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p_LightDark.Cursor = System.Windows.Forms.Cursors.Hand;
			this.p_LightDark.Location = new System.Drawing.Point(770, 6);
			this.p_LightDark.Name = "p_LightDark";
			this.p_LightDark.Size = new System.Drawing.Size(22, 22);
			this.p_LightDark.TabIndex = 4;
			this.p_LightDark.Click += new System.EventHandler(this.p_LightDark_Click);
			// 
			// p_Help
			// 
			this.p_Help.BackgroundImage = global::incrementalRegexReplace.Properties.Resources.question_24;
			this.p_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_Help.Cursor = System.Windows.Forms.Cursors.Help;
			this.p_Help.Location = new System.Drawing.Point(105, 6);
			this.p_Help.Name = "p_Help";
			this.p_Help.Size = new System.Drawing.Size(22, 22);
			this.p_Help.TabIndex = 3;
			this.p_Help.Click += new System.EventHandler(this.p_Help_Click);
			// 
			// btn_X
			// 
			this.btn_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn_X.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_X.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
			this.btn_X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_X.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_X.ForeColor = System.Drawing.Color.White;
			this.btn_X.Location = new System.Drawing.Point(4, 3);
			this.btn_X.Name = "btn_X";
			this.btn_X.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
			this.btn_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_X.Size = new System.Drawing.Size(22, 22);
			this.btn_X.TabIndex = 17;
			this.btn_X.Tag = "x";
			this.btn_X.Text = "×";
			this.btn_X.UseCompatibleTextRendering = true;
			this.btn_X.UseVisualStyleBackColor = false;
			this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
			// 
			// p_BtnHolder
			// 
			this.p_BtnHolder.BackColor = System.Drawing.Color.WhiteSmoke;
			this.p_BtnHolder.BackgroundImage = global::incrementalRegexReplace.Properties.Resources.p;
			this.p_BtnHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.p_BtnHolder.Controls.Add(this.btn_X);
			this.p_BtnHolder.Location = new System.Drawing.Point(742, 81);
			this.p_BtnHolder.Name = "p_BtnHolder";
			this.p_BtnHolder.Size = new System.Drawing.Size(30, 30);
			this.p_BtnHolder.TabIndex = 18;
			this.p_BtnHolder.Tag = "x";
			this.p_BtnHolder.Visible = false;
			// 
			// btn_CheckRegexMatches
			// 
			this.btn_CheckRegexMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_CheckRegexMatches.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_CheckRegexMatches.Enabled = false;
			this.btn_CheckRegexMatches.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_CheckRegexMatches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btn_CheckRegexMatches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_CheckRegexMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_CheckRegexMatches.Location = new System.Drawing.Point(96, 475);
			this.btn_CheckRegexMatches.Name = "btn_CheckRegexMatches";
			this.btn_CheckRegexMatches.Size = new System.Drawing.Size(98, 23);
			this.btn_CheckRegexMatches.TabIndex = 19;
			this.btn_CheckRegexMatches.Text = "Check Matches";
			this.btn_CheckRegexMatches.UseVisualStyleBackColor = true;
			this.btn_CheckRegexMatches.Click += new System.EventHandler(this.btn_CheckRegexMatches_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.ClientSize = new System.Drawing.Size(804, 510);
			this.Controls.Add(this.btn_CheckRegexMatches);
			this.Controls.Add(this.p_BtnHolder);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
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
			this.MinimumSize = new System.Drawing.Size(720, 240);
			this.Name = "Form1";
			this.Text = "IncrementalRegexReplace ";
			this.cms_Regex.ResumeLayout(false);
			this.tc_Tabs.ResumeLayout(false);
			this.tp_Original.ResumeLayout(false);
			this.tp_Replaced.ResumeLayout(false);
			this.tp_Help.ResumeLayout(false);
			this.tp_Help.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.p_BtnHolder.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Regex;
		private System.Windows.Forms.Button btn_AddReplace;
		private System.Windows.Forms.Panel p_Help;
		private System.Windows.Forms.TabControl tc_Tabs;
		private System.Windows.Forms.TabPage tp_Original;
		private System.Windows.Forms.TabPage tp_Replaced;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Quit;
		private System.Windows.Forms.Button btn_Copy;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.Panel p_LightDark;
		private System.Windows.Forms.RichTextBox rtb_Original;
		private System.Windows.Forms.RichTextBox tb_Replaced;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.TabPage tp_Help;
		private System.Windows.Forms.ContextMenuStrip cms_Regex;
		private System.Windows.Forms.ToolStripMenuItem btn_cms_regex_History;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.WebBrowser wb_Help;
		private System.Windows.Forms.Button btn_X;
		private System.Windows.Forms.Panel p_BtnHolder;
		private System.Windows.Forms.Button btn_CheckRegexMatches;
	}
}

