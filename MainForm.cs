using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_2_Main_
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			historyBox.Items.AddRange(File.ReadAllLines("History"));
			zakladki.Items.AddRange(File.ReadAllLines("Zakladki"));
		}
		private int kolPages = 0;//для наследования

		private void AddVkladka_Click(object sender, EventArgs e)
		{
			WebBrowser browser = new WebBrowser();
			browser.Visible = true;
			browser.ScriptErrorsSuppressed = true;
			browser.Dock = DockStyle.Fill;
			browser.DocumentCompleted += browser_DocumentComplited;

			Page.TabPages.Add("новая");
			Page.SelectTab(kolPages);
			Page.SelectedTab.Controls.Add(browser);
			kolPages++;

		}
		void browser_DocumentComplited(object sender,WebBrowserDocumentCompletedEventArgs e)
		{
			Page.SelectedTab.Text = ((WebBrowser)Page.SelectedTab.Controls[0]).DocumentTitle;
		}

		private void Go_Click(object sender, EventArgs e)
		{
			if(!String.IsNullOrEmpty(PoiskovayaStroka.Text))
			{
				((WebBrowser)Page.SelectedTab.Controls[0]).Navigate(PoiskovayaStroka.Text);
				File.AppendAllText("History", "https://" + PoiskovayaStroka.Text + "\n");
				historyBox.Items.Add( PoiskovayaStroka.Text + "\n");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			WebBrowser browser = new WebBrowser();
			browser.Visible = true;
			browser.ScriptErrorsSuppressed = true;
			browser.Dock = DockStyle.Fill;
			browser.DocumentCompleted += browser_DocumentComplited;

			Page.TabPages.Add("новая");
			Page.SelectTab(kolPages);
			Page.SelectedTab.Controls.Add(browser);
			kolPages++;
		}

		private void Undo_Click(object sender, EventArgs e)
		{
			((WebBrowser)Page.SelectedTab.Controls[0]).GoBack();
		}

		private void Next_Click(object sender, EventArgs e)
		{
			((WebBrowser)Page.SelectedTab.Controls[0]).GoForward();
		}

		private void Reload_Click(object sender, EventArgs e)
		{
			((WebBrowser)Page.SelectedTab.Controls[0]).Refresh();
		}

		private void PoiskovayaStroka_Click(object sender, EventArgs e)
		{

		}

		private void DeleteVkladka_Click(object sender, EventArgs e)
		{
			if (Page.TabPages.Count>1)
			{
				Page.TabPages.RemoveAt(Page.SelectedIndex);
				Page.SelectTab(Page.TabPages.Count - 1);
				kolPages -= 1;
			} else this.Close();
		}

		private void PoiskovayaStroka_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				((WebBrowser)Page.SelectedTab.Controls[0]).Navigate(PoiskovayaStroka.Text);
				File.AppendAllText("History",   PoiskovayaStroka.Text + "\n");
				historyBox.Items.Add( PoiskovayaStroka.Text + "\n");

			}
		}

		private void Stop_Click(object sender, EventArgs e)
		{
			((WebBrowser)Page.SelectedTab.Controls[0]).Stop();
		}

		private void Home_Click(object sender, EventArgs e)
		{
			((WebBrowser)Page.SelectedTab.Controls[0]).GoHome() ;
		}

		ListBox zakladki = new ListBox();
		private void AddBookmark_Click(object sender, EventArgs e)
		{
			File.AppendAllText("Zakladki", Page.SelectedTab.Text + "\n");
			zakladki.Items.Add(Page.SelectedTab.Text + "\n");
		}

		private void закладкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Page.TabPages.Add("Закладки");
			Page.SelectTab(kolPages);
			Page.SelectedTab.Controls.Add(zakladki);
			zakladki.Dock = DockStyle.Fill;
			kolPages++;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			((WebBrowser)Page.SelectedTab.Controls[0]).ShowSaveAsDialog();
		}
		ListBox historyBox = new ListBox();
		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<string> fileContent = new List<string>();
			if (Page.SelectedTab.Text=="Закладки")
			{
				fileContent.AddRange(File.ReadAllLines("Zakladki"));
				fileContent.RemoveAt(zakladki.SelectedIndex);
				File.WriteAllLines("Zakladki", fileContent);
				zakladki.Items.RemoveAt(zakladki.SelectedIndex);
			} else
				{
				fileContent.AddRange(File.ReadAllLines("History"));
				fileContent.RemoveAt(historyBox.SelectedIndex);
				File.WriteAllLines("History", fileContent);
				historyBox.Items.RemoveAt(historyBox.SelectedIndex );
				}
			
		}
		private void историяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Page.TabPages.Add("История");
			Page.SelectTab(kolPages);
			Page.SelectedTab.Controls.Add(historyBox);
			historyBox.Dock = DockStyle.Fill;
			kolPages++;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			
			
		}

		private void сохранитьСтраницуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}
		private void historyBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			PoiskovayaStroka.Text = historyBox.SelectedItem.ToString();
			((WebBrowser)Page.SelectedTab.Controls[0]).Navigate(PoiskovayaStroka.Text);
			File.AppendAllText("History", "https://" + PoiskovayaStroka.Text + "\n");
			historyBox.Items.Add(PoiskovayaStroka.Text + "\n");
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			string s = historyBox.SelectedItem.ToString();
			((WebBrowser)Page.SelectedTab.Controls[0]).Navigate(s);
		}
	}
}
