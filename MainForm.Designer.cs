namespace Lab_2_Main_
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Undo = new System.Windows.Forms.ToolStripButton();
			this.Next = new System.Windows.Forms.ToolStripButton();
			this.Reload = new System.Windows.Forms.ToolStripButton();
			this.Stop = new System.Windows.Forms.ToolStripButton();
			this.Home = new System.Windows.Forms.ToolStripButton();
			this.PoiskovayaStroka = new System.Windows.Forms.ToolStripTextBox();
			this.Go = new System.Windows.Forms.ToolStripButton();
			this.AddVkladka = new System.Windows.Forms.ToolStripButton();
			this.DeleteVkladka = new System.Windows.Forms.ToolStripButton();
			this.AddBookmark = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.закладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Page = new System.Windows.Forms.TabControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Undo,
            this.Next,
            this.Reload,
            this.Stop,
            this.Home,
            this.PoiskovayaStroka,
            this.Go,
            this.AddVkladka,
            this.DeleteVkladka,
            this.AddBookmark,
            this.toolStripButton1,
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1069, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Undo
			// 
			this.Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Undo.Image = ((System.Drawing.Image)(resources.GetObject("Undo.Image")));
			this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Undo.Name = "Undo";
			this.Undo.Size = new System.Drawing.Size(29, 24);
			this.Undo.Text = "toolStripButton1";
			this.Undo.Click += new System.EventHandler(this.Undo_Click);
			// 
			// Next
			// 
			this.Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
			this.Next.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(29, 24);
			this.Next.Text = "toolStripButton2";
			this.Next.Click += new System.EventHandler(this.Next_Click);
			// 
			// Reload
			// 
			this.Reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Reload.Image = ((System.Drawing.Image)(resources.GetObject("Reload.Image")));
			this.Reload.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Reload.Name = "Reload";
			this.Reload.Size = new System.Drawing.Size(29, 24);
			this.Reload.Text = "toolStripButton3";
			this.Reload.Click += new System.EventHandler(this.Reload_Click);
			// 
			// Stop
			// 
			this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
			this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(29, 24);
			this.Stop.Text = "X";
			this.Stop.Click += new System.EventHandler(this.Stop_Click);
			// 
			// Home
			// 
			this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
			this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Home.Name = "Home";
			this.Home.Size = new System.Drawing.Size(29, 24);
			this.Home.Text = "toolStripButton3";
			this.Home.Click += new System.EventHandler(this.Home_Click);
			// 
			// PoiskovayaStroka
			// 
			this.PoiskovayaStroka.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.PoiskovayaStroka.Name = "PoiskovayaStroka";
			this.PoiskovayaStroka.Size = new System.Drawing.Size(600, 27);
			this.PoiskovayaStroka.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PoiskovayaStroka_KeyUp);
			this.PoiskovayaStroka.Click += new System.EventHandler(this.PoiskovayaStroka_Click);
			// 
			// Go
			// 
			this.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Go.Image = ((System.Drawing.Image)(resources.GetObject("Go.Image")));
			this.Go.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Go.Name = "Go";
			this.Go.Size = new System.Drawing.Size(32, 24);
			this.Go.Text = "Go";
			this.Go.Click += new System.EventHandler(this.Go_Click);
			// 
			// AddVkladka
			// 
			this.AddVkladka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.AddVkladka.Image = ((System.Drawing.Image)(resources.GetObject("AddVkladka.Image")));
			this.AddVkladka.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddVkladka.Name = "AddVkladka";
			this.AddVkladka.Size = new System.Drawing.Size(29, 24);
			this.AddVkladka.Text = "+";
			this.AddVkladka.Click += new System.EventHandler(this.AddVkladka_Click);
			// 
			// DeleteVkladka
			// 
			this.DeleteVkladka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.DeleteVkladka.Image = ((System.Drawing.Image)(resources.GetObject("DeleteVkladka.Image")));
			this.DeleteVkladka.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteVkladka.Name = "DeleteVkladka";
			this.DeleteVkladka.Size = new System.Drawing.Size(29, 24);
			this.DeleteVkladka.Text = "-";
			this.DeleteVkladka.Click += new System.EventHandler(this.DeleteVkladka_Click);
			// 
			// AddBookmark
			// 
			this.AddBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddBookmark.Image = ((System.Drawing.Image)(resources.GetObject("AddBookmark.Image")));
			this.AddBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddBookmark.Name = "AddBookmark";
			this.AddBookmark.Size = new System.Drawing.Size(29, 24);
			this.AddBookmark.Text = "toolStripButton1";
			this.AddBookmark.Click += new System.EventHandler(this.AddBookmark_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton1.Text = "D";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закладкиToolStripMenuItem,
            this.историяToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// закладкиToolStripMenuItem
			// 
			this.закладкиToolStripMenuItem.Name = "закладкиToolStripMenuItem";
			this.закладкиToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
			this.закладкиToolStripMenuItem.Text = "Закладки";
			this.закладкиToolStripMenuItem.Click += new System.EventHandler(this.закладкиToolStripMenuItem_Click);
			// 
			// историяToolStripMenuItem
			// 
			this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
			this.историяToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
			this.историяToolStripMenuItem.Text = "История";
			this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
			// 
			// Page
			// 
			this.Page.ContextMenuStrip = this.contextMenuStrip1;
			this.Page.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Page.Location = new System.Drawing.Point(0, 27);
			this.Page.Name = "Page";
			this.Page.SelectedIndex = 0;
			this.Page.Size = new System.Drawing.Size(1069, 423);
			this.Page.TabIndex = 1;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 450);
			this.Controls.Add(this.Page);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "From Russia with Love";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton Undo;
		private System.Windows.Forms.ToolStripButton Next;
		private System.Windows.Forms.ToolStripButton Reload;
		private System.Windows.Forms.ToolStripTextBox PoiskovayaStroka;
		private System.Windows.Forms.ToolStripButton Go;
		private System.Windows.Forms.ToolStripButton AddVkladka;
		private System.Windows.Forms.TabControl Page;
		private System.Windows.Forms.ToolStripButton DeleteVkladka;
		private System.Windows.Forms.ToolStripButton Stop;
		private System.Windows.Forms.ToolStripButton Home;
		private System.Windows.Forms.ToolStripButton AddBookmark;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem закладкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
	}
}

