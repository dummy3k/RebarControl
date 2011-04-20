using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using RebarDotNet;

namespace RebarTestApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mnuMain;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem23;
		private RebarDotNet.BandWrapper bndFile;
		private RebarDotNet.BandWrapper bndEdit;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuFileNew;
		private System.Windows.Forms.MenuItem mnuFileOpen;
		private System.Windows.Forms.MenuItem mnuFileSave;
		private System.Windows.Forms.MenuItem mnuFileExit;
		private System.Windows.Forms.MenuItem mnuView;
		private System.Windows.Forms.MenuItem mnuViewToolbars;
		private System.Windows.Forms.MenuItem mnuEdit;
		private System.Windows.Forms.MenuItem mnuEditUndo;
		private System.Windows.Forms.MenuItem mnuEditRedo;
		private System.Windows.Forms.MenuItem mnuEditCut;
		private System.Windows.Forms.MenuItem mnuEditCopy;
		private System.Windows.Forms.MenuItem mnuEditPaste;
		private System.Windows.Forms.MenuItem mnuEditDelete;
		private System.Windows.Forms.MenuItem mnuViewToolbarsEdit;
		private System.Windows.Forms.MenuItem mnuViewToolbarsFile;
		private System.Windows.Forms.MenuItem mnuViewCaptions;
		private System.Windows.Forms.MenuItem mnuViewIcons;
		private System.Windows.Forms.MenuItem mnuViewBackground;
		private System.Windows.Forms.ImageList imlMain;
		private System.Windows.Forms.RichTextBox txtMain;
		private System.Windows.Forms.ToolBar tbFile;
		private System.Windows.Forms.ToolBarButton btnNew;
		private System.Windows.Forms.ToolBarButton btnSep1;
		private System.Windows.Forms.ToolBarButton btnOpen;
		private System.Windows.Forms.ToolBarButton btnSave;
		private System.Windows.Forms.ToolBarButton btnSep2;
		private System.Windows.Forms.ToolBarButton btnPrint;
		private RebarDotNet.BandWrapper bndCombo;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ToolBar tbEdit;
		private System.Windows.Forms.ToolBarButton btnUndo;
		private System.Windows.Forms.ToolBarButton btnRedo;
		private System.Windows.Forms.ToolBarButton btnSep3;
		private System.Windows.Forms.ToolBarButton btnCut;
		private System.Windows.Forms.ToolBarButton btnCopy;
		private System.Windows.Forms.ToolBarButton btnPaste;
		private System.Windows.Forms.ToolBarButton btnDelete;
		private System.Windows.Forms.MenuItem mnuViewToolbarsCombo;
		private RebarDotNet.RebarWrapper rbMain;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.rbMain = new RebarDotNet.RebarWrapper();
			this.bndFile = new RebarDotNet.BandWrapper();
			this.tbFile = new System.Windows.Forms.ToolBar();
			this.btnNew = new System.Windows.Forms.ToolBarButton();
			this.btnSep1 = new System.Windows.Forms.ToolBarButton();
			this.btnOpen = new System.Windows.Forms.ToolBarButton();
			this.btnSave = new System.Windows.Forms.ToolBarButton();
			this.btnSep2 = new System.Windows.Forms.ToolBarButton();
			this.btnPrint = new System.Windows.Forms.ToolBarButton();
			this.imlMain = new System.Windows.Forms.ImageList(this.components);
			this.bndEdit = new RebarDotNet.BandWrapper();
			this.tbEdit = new System.Windows.Forms.ToolBar();
			this.btnUndo = new System.Windows.Forms.ToolBarButton();
			this.btnRedo = new System.Windows.Forms.ToolBarButton();
			this.btnSep3 = new System.Windows.Forms.ToolBarButton();
			this.btnCut = new System.Windows.Forms.ToolBarButton();
			this.btnCopy = new System.Windows.Forms.ToolBarButton();
			this.btnPaste = new System.Windows.Forms.ToolBarButton();
			this.btnDelete = new System.Windows.Forms.ToolBarButton();
			this.bndCombo = new RebarDotNet.BandWrapper();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuFileNew = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.mnuFileOpen = new System.Windows.Forms.MenuItem();
			this.mnuFileSave = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.mnuEdit = new System.Windows.Forms.MenuItem();
			this.mnuEditUndo = new System.Windows.Forms.MenuItem();
			this.mnuEditRedo = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.mnuEditCut = new System.Windows.Forms.MenuItem();
			this.mnuEditCopy = new System.Windows.Forms.MenuItem();
			this.mnuEditPaste = new System.Windows.Forms.MenuItem();
			this.mnuEditDelete = new System.Windows.Forms.MenuItem();
			this.mnuView = new System.Windows.Forms.MenuItem();
			this.mnuViewToolbars = new System.Windows.Forms.MenuItem();
			this.mnuViewToolbarsEdit = new System.Windows.Forms.MenuItem();
			this.mnuViewToolbarsFile = new System.Windows.Forms.MenuItem();
			this.mnuViewToolbarsCombo = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.mnuViewCaptions = new System.Windows.Forms.MenuItem();
			this.mnuViewIcons = new System.Windows.Forms.MenuItem();
			this.mnuViewBackground = new System.Windows.Forms.MenuItem();
			this.txtMain = new System.Windows.Forms.RichTextBox();
			this.rbMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// rbMain
			// 
			this.rbMain.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("rbMain.BackgroundImage")));
			this.rbMain.Bands.Add(this.bndFile);
			this.rbMain.Bands.Add(this.bndEdit);
			this.rbMain.Bands.Add(this.bndCombo);
			this.rbMain.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.tbFile,
																				 this.tbEdit,
																				 this.comboBox1});
			this.rbMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.rbMain.ForeColor = System.Drawing.Color.White;
			this.rbMain.ImageList = this.imlMain;
			this.rbMain.Name = "rbMain";
			this.rbMain.Size = new System.Drawing.Size(616, 92);
			this.rbMain.TabIndex = 0;
			// 
			// bndFile
			// 
			this.bndFile.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("bndFile.BackgroundImage")));
			this.bndFile.Caption = "File";
			this.bndFile.Child = this.tbFile;
			this.bndFile.Header = -1;
			this.bndFile.IdealWidth = 120;
			this.bndFile.Image = 0;
			this.bndFile.Integral = 1;
			this.bndFile.Key = "File";
			this.bndFile.MaxHeight = 0;
			this.bndFile.ShowIcon = true;
			// 
			// tbFile
			// 
			this.tbFile.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tbFile.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					  this.btnNew,
																					  this.btnSep1,
																					  this.btnOpen,
																					  this.btnSave,
																					  this.btnSep2,
																					  this.btnPrint});
			this.tbFile.Divider = false;
			this.tbFile.Dock = System.Windows.Forms.DockStyle.None;
			this.tbFile.DropDownArrows = true;
			this.tbFile.ImageList = this.imlMain;
			this.tbFile.Location = new System.Drawing.Point(47, 2);
			this.tbFile.Name = "tbFile";
			this.tbFile.ShowToolTips = true;
			this.tbFile.Size = new System.Drawing.Size(561, 24);
			this.tbFile.TabIndex = 3;
			this.tbFile.Wrappable = false;
			// 
			// btnNew
			// 
			this.btnNew.ImageIndex = 10;
			this.btnNew.ToolTipText = "New";
			// 
			// btnSep1
			// 
			this.btnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnOpen
			// 
			this.btnOpen.ImageIndex = 11;
			// 
			// btnSave
			// 
			this.btnSave.ImageIndex = 7;
			// 
			// btnSep2
			// 
			this.btnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnPrint
			// 
			this.btnPrint.ImageIndex = 8;
			// 
			// imlMain
			// 
			this.imlMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imlMain.ImageSize = new System.Drawing.Size(16, 16);
			this.imlMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMain.ImageStream")));
			this.imlMain.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// bndEdit
			// 
			this.bndEdit.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("bndEdit.BackgroundImage")));
			this.bndEdit.Caption = "Edit";
			this.bndEdit.Child = this.tbEdit;
			this.bndEdit.Header = -1;
			this.bndEdit.IdealWidth = 160;
			this.bndEdit.Image = 1;
			this.bndEdit.Integral = 1;
			this.bndEdit.Key = "Edit";
			this.bndEdit.MaxHeight = 0;
			this.bndEdit.ShowIcon = true;
			// 
			// tbEdit
			// 
			this.tbEdit.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tbEdit.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					  this.btnUndo,
																					  this.btnRedo,
																					  this.btnSep3,
																					  this.btnCut,
																					  this.btnCopy,
																					  this.btnPaste,
																					  this.btnDelete});
			this.tbEdit.Divider = false;
			this.tbEdit.Dock = System.Windows.Forms.DockStyle.None;
			this.tbEdit.DropDownArrows = true;
			this.tbEdit.ImageList = this.imlMain;
			this.tbEdit.Location = new System.Drawing.Point(49, 32);
			this.tbEdit.Name = "tbEdit";
			this.tbEdit.ShowToolTips = true;
			this.tbEdit.Size = new System.Drawing.Size(559, 24);
			this.tbEdit.TabIndex = 5;
			this.tbEdit.Wrappable = false;
			// 
			// btnUndo
			// 
			this.btnUndo.ImageIndex = 2;
			// 
			// btnRedo
			// 
			this.btnRedo.ImageIndex = 3;
			// 
			// btnSep3
			// 
			this.btnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// btnCut
			// 
			this.btnCut.ImageIndex = 6;
			// 
			// btnCopy
			// 
			this.btnCopy.ImageIndex = 4;
			// 
			// btnPaste
			// 
			this.btnPaste.ImageIndex = 9;
			// 
			// btnDelete
			// 
			this.btnDelete.ImageIndex = 5;
			// 
			// bndCombo
			// 
			this.bndCombo.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("bndCombo.BackgroundImage")));
			this.bndCombo.Caption = "Combobox";
			this.bndCombo.Child = this.comboBox1;
			this.bndCombo.Header = -1;
			this.bndCombo.Image = 12;
			this.bndCombo.Integral = 1;
			this.bndCombo.Key = "Combo";
			this.bndCombo.MaxHeight = 0;
			this.bndCombo.MinWidth = 200;
			this.bndCombo.ShowIcon = true;
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(82, 62);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(526, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "comboBox1";
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuFile,
																					this.mnuEdit,
																					this.mnuView});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuFileNew,
																					this.menuItem7,
																					this.mnuFileOpen,
																					this.mnuFileSave,
																					this.menuItem6,
																					this.mnuFileExit});
			this.mnuFile.Text = "&File";
			// 
			// mnuFileNew
			// 
			this.mnuFileNew.Index = 0;
			this.mnuFileNew.Text = "&New";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "-";
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Index = 2;
			this.mnuFileOpen.Text = "&Open";
			// 
			// mnuFileSave
			// 
			this.mnuFileSave.Index = 3;
			this.mnuFileSave.Text = "&Save";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "-";
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Index = 5;
			this.mnuFileExit.Text = "E&xit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuEdit
			// 
			this.mnuEdit.Index = 1;
			this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuEditUndo,
																					this.mnuEditRedo,
																					this.menuItem13,
																					this.mnuEditCut,
																					this.mnuEditCopy,
																					this.mnuEditPaste,
																					this.mnuEditDelete});
			this.mnuEdit.Text = "&Edit";
			// 
			// mnuEditUndo
			// 
			this.mnuEditUndo.Index = 0;
			this.mnuEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.mnuEditUndo.Text = "&Undo";
			// 
			// mnuEditRedo
			// 
			this.mnuEditRedo.Index = 1;
			this.mnuEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
			this.mnuEditRedo.Text = "&Redo";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "-";
			// 
			// mnuEditCut
			// 
			this.mnuEditCut.Index = 3;
			this.mnuEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.mnuEditCut.Text = "Cu&t";
			// 
			// mnuEditCopy
			// 
			this.mnuEditCopy.Index = 4;
			this.mnuEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.mnuEditCopy.Text = "&Copy";
			// 
			// mnuEditPaste
			// 
			this.mnuEditPaste.Index = 5;
			this.mnuEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.mnuEditPaste.Text = "&Paste";
			// 
			// mnuEditDelete
			// 
			this.mnuEditDelete.Index = 6;
			this.mnuEditDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.mnuEditDelete.Text = "&Delete";
			// 
			// mnuView
			// 
			this.mnuView.Index = 2;
			this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuViewToolbars,
																					this.menuItem23,
																					this.mnuViewCaptions,
																					this.mnuViewIcons,
																					this.mnuViewBackground});
			this.mnuView.Text = "&View";
			// 
			// mnuViewToolbars
			// 
			this.mnuViewToolbars.Index = 0;
			this.mnuViewToolbars.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.mnuViewToolbarsEdit,
																							this.mnuViewToolbarsFile,
																							this.mnuViewToolbarsCombo});
			this.mnuViewToolbars.Text = "Toolbars";
			// 
			// mnuViewToolbarsEdit
			// 
			this.mnuViewToolbarsEdit.Checked = true;
			this.mnuViewToolbarsEdit.Index = 0;
			this.mnuViewToolbarsEdit.Text = "Edit";
			this.mnuViewToolbarsEdit.Click += new System.EventHandler(this.mnuViewToolbarsEdit_Click);
			// 
			// mnuViewToolbarsFile
			// 
			this.mnuViewToolbarsFile.Checked = true;
			this.mnuViewToolbarsFile.Index = 1;
			this.mnuViewToolbarsFile.Text = "File";
			this.mnuViewToolbarsFile.Click += new System.EventHandler(this.mnuViewToolbarsFile_Click);
			// 
			// mnuViewToolbarsCombo
			// 
			this.mnuViewToolbarsCombo.Checked = true;
			this.mnuViewToolbarsCombo.Index = 2;
			this.mnuViewToolbarsCombo.Text = "Combobox";
			this.mnuViewToolbarsCombo.Click += new System.EventHandler(this.mnuViewToolbarsCombo_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 1;
			this.menuItem23.Text = "-";
			// 
			// mnuViewCaptions
			// 
			this.mnuViewCaptions.Checked = true;
			this.mnuViewCaptions.Index = 2;
			this.mnuViewCaptions.Text = "Rebar Captions";
			this.mnuViewCaptions.Click += new System.EventHandler(this.mnuViewCaptions_Click);
			// 
			// mnuViewIcons
			// 
			this.mnuViewIcons.Checked = true;
			this.mnuViewIcons.Index = 3;
			this.mnuViewIcons.Text = "Rebar Icons";
			this.mnuViewIcons.Click += new System.EventHandler(this.mnuViewIcons_Click);
			// 
			// mnuViewBackground
			// 
			this.mnuViewBackground.Checked = true;
			this.mnuViewBackground.Index = 4;
			this.mnuViewBackground.Text = "Background Image";
			this.mnuViewBackground.Click += new System.EventHandler(this.mnuViewBackground_Click);
			// 
			// txtMain
			// 
			this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMain.Location = new System.Drawing.Point(0, 92);
			this.txtMain.Name = "txtMain";
			this.txtMain.Size = new System.Drawing.Size(616, 237);
			this.txtMain.TabIndex = 1;
			this.txtMain.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 329);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.txtMain,
																		  this.rbMain});
			this.Menu = this.mnuMain;
			this.Name = "Form1";
			this.Text = "Form1";
			this.rbMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void mnuViewToolbarsEdit_Click(object sender, System.EventArgs e)
		{
			mnuViewToolbarsEdit.Checked = !mnuViewToolbarsEdit.Checked;
			rbMain.Bands["Edit"].Visible = mnuViewToolbarsEdit.Checked;
		}

		private void mnuViewToolbarsFile_Click(object sender, System.EventArgs e)
		{
			mnuViewToolbarsFile.Checked = !mnuViewToolbarsFile.Checked;
			rbMain.Bands["File"].Visible = mnuViewToolbarsFile.Checked;
		}

		private void mnuViewToolbarsCombo_Click(object sender, System.EventArgs e)
		{
			mnuViewToolbarsCombo.Checked = !mnuViewToolbarsCombo.Checked;
			rbMain.Bands["Combo"].Visible = mnuViewToolbarsCombo.Checked;
		}

		private void mnuViewCaptions_Click(object sender, System.EventArgs e)
		{
			mnuViewCaptions.Checked = !mnuViewCaptions.Checked;
			foreach(BandWrapper band in rbMain.Bands)
			{
				band.ShowCaption = mnuViewCaptions.Checked;
			}
		}

		private void mnuViewIcons_Click(object sender, System.EventArgs e)
		{
			mnuViewIcons.Checked = !mnuViewIcons.Checked;
			foreach(BandWrapper band in rbMain.Bands)
			{
				band.ShowIcon = mnuViewIcons.Checked;
			}
		}

		private void mnuViewBackground_Click(object sender, System.EventArgs e)
		{
			mnuViewBackground.Checked = ! mnuViewBackground.Checked;
			rbMain.ShowBackgroundImage = mnuViewBackground.Checked;
			//This is just to make the caption text visible with the dumb background picture
			rbMain.ForeColor = (mnuViewBackground.Checked)?Color.White:SystemColors.ControlText;
		}

		protected override void OnLoad(System.EventArgs e)
		{
			mnuViewBackground.PerformClick();
		}
	}
}
