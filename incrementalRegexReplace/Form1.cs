using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incrementalRegexReplace
{
	public partial class Form1 : Form
	{
		public bool nightmode = false;
		public Color cText = Color.Black;
		public Color cBackground = Color.WhiteSmoke;
		public Color cInput = Color.White;
		public Color cLabel = Color.Black;
		public Color cError = Color.LightPink;

		public Timer Tim = new Timer() { Interval = 100 };
		public int checkCounter = 0;

		int tabId = 0;

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
			Tim.Tick += Tim_Tick;
		}

		private void Tim_Tick(object sender, EventArgs e)
		{
			if (checkCounter == 10)
			{
				checkRegex();
				Tim.Stop();
				return;
			}
			checkCounter++;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadColors();
		}

		public void getColors()
		{
			if (nightmode)
			{
				cText = Color.FromArgb(255, 221, 189, 130);
				cBackground = Color.FromArgb(255, 090, 090, 090);
				cInput = Color.FromArgb(255, 120, 120, 120);
				cLabel = Color.FromArgb(255, 255, 255, 255);
				cError = Color.Red;

				p_LightDark.BackgroundImage = Properties.Resources.day_code;
			}
			else
			{
				cText = Color.FromArgb(255, 000, 000, 000);
				cBackground = Color.FromArgb(255, 235, 235, 235);
				cInput = Color.FromArgb(255, 255, 255, 255);
				cLabel = Color.FromArgb(255, 000, 000, 000);
				cError = Color.LightPink;

				p_LightDark.BackgroundImage = Properties.Resources.night_code;
			}
		}

		public void loadColors()
		{
			getColors();

			List<object> myobjs = new List<object>() {
				this
			};
			myobjs.AddRange(tc_Tabs.TabPages.Cast<TabPage>().ToArray());
			List<Control> cCont = new List<Control>() { this, tc_Tabs };


			foreach (var v in myobjs)
			{
				foreach (Control c in ((Control)v).Controls)
				{
					cCont.Add(c);
				}
			}

			foreach (Control c in cCont)
			{
				if (c.Tag != null) { continue; }
				if (c is Button)
				{
					Button b = c as Button;
					if (b.FlatStyle == FlatStyle.Flat)
					{
						b.FlatAppearance.MouseOverBackColor = cBackground;
						b.FlatAppearance.MouseDownBackColor = cInput;
						b.ForeColor = cText;
					}
				}
				else if (c is Label)
				{
					c.ForeColor = cLabel;
				}
				else if (c is NumericUpDown)
				{
					c.ForeColor = cText;
					c.BackColor = cBackground;
				}
				else if (c is RichTextBox || c is TextBox)
				{
					c.ForeColor = cText;
					c.BackColor = cInput;
				}
				else if (c is Form || c is TabControl)
				{
					c.BackColor = cBackground;
				}
			}
		}

		private void p_LightDark_Click(object sender, EventArgs e)
		{
			nightmode = !nightmode;

			loadColors();
		}

		public void checkRegex()
		{
			if (!myRegex.checkValidRegex(tb_Regex.Text))
			{
				tb_Regex.BackColor = cError;
				btn_Start.Enabled = false;
			}
			else
			{
				tb_Regex.BackColor = cInput;
				if (tb_Regex.Text != "")
				{
					btn_Start.Enabled = true;

				}
			}
		}

		private void tb_Regex_TextChanged(object sender, EventArgs e)
		{
			if (myRegex.hasToken(tb_Regex.Text)) { btn_AddReplace.Text = "${UNSET}"; }
			else { btn_AddReplace.Text = "${SET}"; }

			if (tb_Regex.Text == "")
			{
				if (Tim.Enabled)
				{
					Tim.Start();
				}

				checkRegex();
				btn_Start.Enabled = false;
			}
			else
			{
				if (!Tim.Enabled)
				{
					Tim.Start();
				}

				checkCounter = 0;
			}

		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.s_RegexHistory.Contains(tb_Regex.Text))
			{
				Properties.Settings.Default.s_RegexHistory.Remove(tb_Regex.Text);
			}
			Properties.Settings.Default.s_RegexHistory.Insert(0, tb_Regex.Text);
			Properties.Settings.Default.s_RecentHistory.Clear();
			Properties.Settings.Default.s_RecentHistory.AddRange(Properties.Settings.Default.s_RegexHistory.Cast<string>().TakeWhile(x => Properties.Settings.Default.s_RegexHistory.IndexOf(x) < 10).ToArray());
			Properties.Settings.Default.Save();

			string str = rtb_Original.Text;



			RichTextBox tb = FromHandle(createNewTab(++tabId)) as RichTextBox;
			if (tb != null)
			{
				tb.Text = myRegex.replaceRegex(str, tb_Regex.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
				tc_Tabs.SelectedTab = tb.Parent as TabPage;
			}
		}

		private void cms_Regex_Opening(object sender, CancelEventArgs e)
		{
			btn_cms_regex_History.DropDown.Items.Clear();

			foreach (string s in Properties.Settings.Default.s_RecentHistory)
			{
				btn_cms_regex_History.DropDown.Items.Add(s);
			}
		}

		private void btn_AddReplace_Click(object sender, EventArgs e)
		{
			int strt = tb_Regex.SelectionStart;
			int len = tb_Regex.SelectionLength;
			int findstrt = 0;
			int findend = 0;
			bool done = false;

			if (myRegex.hasToken(tb_Regex.Text))
			{
				var sel = myRegex.giveTokenLocation(tb_Regex.Text);
				try
				{
					string s1 = tb_Regex.Text.Substring(0, sel[0]);
					string s2 = tb_Regex.Text.Substring(sel[0], sel[2] + 2);
					string s3 = tb_Regex.Text.Substring(sel[1] + 2);

					if (tb_Regex.SelectionLength == 0)
					{
						tb_Regex.Text = s1 + (s2.Substring(0, s2.Length - 1).Replace("(?<i_0>", "")) + s3;
						return;
					}
					else
					{

						if (sel.Sum() > 0)
						{
							findstrt = sel[0];
							findend = sel[1];


							if (strt == sel[0] && len == sel[2] + 2)
							{
								strt = sel[0];
								len = (sel[0] + sel[2] + 2) - (8 + strt);
								done = true;
							}
							else if (strt >= sel[0] && strt + len <= sel[0] + sel[2] + 2)
							{
								if (strt >= sel[0] + 7) { strt -= 7; }
								else { strt -= strt - sel[0]; }

								if (len == sel[2] + 2) { len -= 1; }
								done = true;
							}

							tb_Regex.Text = s1 + (s2.Substring(0, s2.Length - 1).Replace("(?<i_0>", "")) + s3;
						}
					}

					if (!done)
					{
						int tmp = strt + len;

						if (tmp <= findstrt || strt > findend + 1) { }
						else
						{
							if (strt < findstrt)
							{
								if (tmp < findend + 2)
								{
									if (tmp > findstrt + 7)
									{
										len -= 7;
									}
									else
									{
										len = tmp - findstrt;
									}
								}
								else
								{
									len -= 8;
								}
							}
							else if (strt < findend + 2)
							{
								if (strt == findend + 1) { strt++; }
								if (tmp > findend)
								{
									len -= 1;
								}
							}
						}

						strt = strt > findend ? strt - 8 : (strt > findstrt ? strt - 7 : strt);

						tb_Regex.Focus();
						tb_Regex.Select();

						if (tb_Regex.Text.Length < len)
						{
							tb_Regex.SelectAll();
						}
						else if ((strt + len) > tb_Regex.Text.Length)
						{
							strt = findstrt;
							len = findend - findstrt + 1;
						}
					}
				}
				catch
				{ return; }
			}


			tb_Regex.Select(strt, len);

			string[] rx = new string[3];
			rx[0] = tb_Regex.Text.Substring(0, tb_Regex.SelectionStart);
			rx[1] = tb_Regex.Text.Substring(tb_Regex.SelectionStart, tb_Regex.SelectionLength);
			rx[2] = tb_Regex.Text.Substring(tb_Regex.SelectionStart + tb_Regex.SelectionLength);

			tb_Regex.Text = rx[0] + Properties.Resources._s_CaptureToken.Replace("{{STRING}}", rx[1]) + rx[2];



		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{

		}

		public IntPtr createNewTab(int id)
		{
			RichTextBox tb_newReplaced = new RichTextBox
			{
				Name = "tb_newReplaced_" + id,
				BackColor = Color.WhiteSmoke,
				Dock = DockStyle.Fill,
				Font = new Font("Times New Roman", 14.25F, FontStyle.Bold),
				Location = new Point(3, 3),
				Size = new Size(763, 351),
				TabIndex = 1,
				Text = ""
			};

			TabPage tp_newReplaced = new TabPage();
			tp_newReplaced.SuspendLayout();
			tp_newReplaced.Location = new Point(4, 22);
			tp_newReplaced.Name = "tp_newReplaced_" + id;
			tp_newReplaced.Padding = new Padding(3);
			tp_newReplaced.Size = new Size(769, 357);
			tp_newReplaced.TabIndex = 1;
			tp_newReplaced.Text = "Replaced Text " + id;
			tp_newReplaced.UseVisualStyleBackColor = true;
			tc_Tabs.SelectedIndex = 1;
			tc_Tabs.Controls.Add(tp_newReplaced);
			tp_newReplaced.Controls.Add(tb_newReplaced);

			return tb_newReplaced.Handle;
		}

		private void tc_Tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tc_Tabs.SelectedIndex != 0)
			{
				p_BtnHolder.Show();
			}
			else
			{
				p_BtnHolder.Hide();
			}
		}

		private void p_Help_Click(object sender, EventArgs e)
		{

		}

		private void btn_X_Click(object sender, EventArgs e)
		{
			if (tc_Tabs.SelectedIndex != 0)
			{
				int i = tc_Tabs.SelectedIndex;

				tc_Tabs.SelectedTab.Dispose();

				if (tc_Tabs.TabCount > i) { tc_Tabs.SelectedIndex = i; }
				else
				{
					try { tc_Tabs.SelectedIndex = i - 1; }
					catch { }
				}
			}
		}

		private void btn_CheckRegexMatches_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.s_RegexHistory.Contains(tb_Regex.Text))
			{
				Properties.Settings.Default.s_RegexHistory.Remove(tb_Regex.Text);
			}
			Properties.Settings.Default.s_RegexHistory.Insert(0, tb_Regex.Text);
			Properties.Settings.Default.s_RecentHistory.Clear();
			Properties.Settings.Default.s_RecentHistory.AddRange(Properties.Settings.Default.s_RegexHistory.Cast<string>().TakeWhile(x => Properties.Settings.Default.s_RegexHistory.IndexOf(x) < 10).ToArray());
			Properties.Settings.Default.Save();

			string str = rtb_Original.Text;
			
			RichTextBox tb = FromHandle(createNewTab(++tabId)) as RichTextBox;
			if (tb != null)
			{
				tb.Text = myRegex.replaceRegex(str, tb_Regex.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
				tc_Tabs.SelectedTab = tb.Parent as TabPage;
			}
		}
	}
}
