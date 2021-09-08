﻿namespace taskt.UI.Forms
{
    partial class frmScriptBuilder
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
            taskt.Core.Theme theme2 = new taskt.Core.Theme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScriptBuilder));
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new taskt.UI.CustomControls.UIMenuStrip();
            this.fileActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileActionsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileActionsSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileActionsSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.restartApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutScriptStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSplitMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSearchHighlightsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSearchBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSearchResult = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasktProjectPageStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasktWikiStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new taskt.UI.CustomControls.UISplitContainer();
            this.pnlCommandHelper = new System.Windows.Forms.Panel();
            this.lnkStartEdit = new System.Windows.Forms.LinkLabel();
            this.flwRecentFiles = new taskt.UI.CustomControls.UIFlowLayoutPanel();
            this.lblFilesMissing = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecentFiles = new System.Windows.Forms.Label();
            this.lnkGitWiki = new System.Windows.Forms.LinkLabel();
            this.lnkGitIssue = new System.Windows.Forms.LinkLabel();
            this.lnkGitLatestReleases = new System.Windows.Forms.LinkLabel();
            this.lnkGitProject = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lstScriptActions = new taskt.UI.CustomControls.UIListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commandColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain = new taskt.UI.CustomControls.UIPanel();
            this.lblMainLogo = new System.Windows.Forms.Label();
            this.lblCoordinatorInfo = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.pnlControlContainer = new System.Windows.Forms.Panel();
            this.grpSearch = new taskt.UI.CustomControls.UIGroupBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lblCurrentlyViewing = new System.Windows.Forms.Label();
            this.lblTotalResults = new System.Windows.Forms.Label();
            this.txtCommandSearch = new System.Windows.Forms.TextBox();
            this.grpSaveClose = new taskt.UI.CustomControls.UIGroupBox();
            this.btnSequenceImport = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnKeep = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnClose = new taskt.UI.CustomControls.UIPictureButton();
            this.grpFileActions = new taskt.UI.CustomControls.UIGroupBox();
            this.uiBtnImport = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnSaveAs = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnSave = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnNew = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnOpen = new taskt.UI.CustomControls.UIPictureButton();
            this.grpRecordRun = new taskt.UI.CustomControls.UIGroupBox();
            this.uiBtnRecordSequence = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnRunScript = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnScheduleManagement = new taskt.UI.CustomControls.UIPictureButton();
            this.grpVariable = new taskt.UI.CustomControls.UIGroupBox();
            this.uiBtnClearAll = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnSettings = new taskt.UI.CustomControls.UIPictureButton();
            this.uiBtnAddVariable = new taskt.UI.CustomControls.UIPictureButton();
            this.tmrNotify = new System.Windows.Forms.Timer(this.components);
            this.lstContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editThisCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpThisCommandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContextStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.enableSelectedCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableSelectedCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseBeforeExecutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContextStripSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutSelectedActionssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContextStripSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.moveToParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContextStripSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.searchThisCommnadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHighlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstContextStripSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showScriptInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.commandListTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.commandsListPanelU = new System.Windows.Forms.Panel();
            this.commandListPanelD = new System.Windows.Forms.Panel();
            this.tvCommands = new taskt.UI.CustomControls.UITreeView();
            this.txtCommandFilter = new System.Windows.Forms.TextBox();
            this.picCommandSearch = new System.Windows.Forms.PictureBox();
            this.picCommandClear = new System.Windows.Forms.PictureBox();
            this.tlpControls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlCommandHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlControlContainer.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.grpSaveClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSequenceImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnKeep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnClose)).BeginInit();
            this.grpFileActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnSaveAs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnOpen)).BeginInit();
            this.grpRecordRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnRecordSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnRunScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnScheduleManagement)).BeginInit();
            this.grpVariable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnClearAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnAddVariable)).BeginInit();
            this.lstContextStrip.SuspendLayout();
            this.commandListTablePanel.SuspendLayout();
            this.commandsListPanelU.SuspendLayout();
            this.commandListPanelD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCommandSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommandClear)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpControls
            // 
            this.tlpControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.tlpControls.ColumnCount = 3;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 524F));
            this.tlpControls.Controls.Add(this.menuStrip1, 0, 1);
            this.tlpControls.Controls.Add(this.panel1, 0, 3);
            this.tlpControls.Controls.Add(this.splitContainer1, 0, 4);
            this.tlpControls.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpControls.Controls.Add(this.pnlStatus, 0, 5);
            this.tlpControls.Controls.Add(this.pnlControlContainer, 0, 2);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 6;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpControls.Size = new System.Drawing.Size(979, 558);
            this.tlpControls.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tlpControls.SetColumnSpan(this.menuStrip1, 3);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileActionsToolStripMenuItem,
            this.editStripMenuItem,
            this.modifyToolStripMenuItem,
            this.scriptActionsToolStripMenuItem,
            this.saveAndRunToolStripMenuItem,
            this.tsSearchBox,
            this.tsSearchButton,
            this.tsSearchResult,
            this.helpStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(979, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileActionsToolStripMenuItem
            // 
            this.fileActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.fileActionsSep1,
            this.importFileToolStripMenuItem,
            this.sampleToolStripMenuItem,
            this.fileActionsSep2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.fileActionsSep3,
            this.restartApplicationToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileActionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileActionsToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_new;
            this.fileActionsToolStripMenuItem.Name = "fileActionsToolStripMenuItem";
            this.fileActionsToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.fileActionsToolStripMenuItem.Text = "&File Actions";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.newToolStripMenuItem.Text = "&New File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.openToolStripMenuItem.Text = "&Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fileActionsSep1
            // 
            this.fileActionsSep1.Name = "fileActionsSep1";
            this.fileActionsSep1.Size = new System.Drawing.Size(225, 6);
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.importFileToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_import;
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.importFileToolStripMenuItem.Text = "&Import File";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // sampleToolStripMenuItem
            // 
            this.sampleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sampleToolStripMenuItem.Image = global::taskt.Properties.Resources.sample_templete;
            this.sampleToolStripMenuItem.Name = "sampleToolStripMenuItem";
            this.sampleToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.sampleToolStripMenuItem.Text = "Sample/Templete (&M)";
            this.sampleToolStripMenuItem.Click += new System.EventHandler(this.sampleToolStripMenuItem_Click);
            // 
            // fileActionsSep2
            // 
            this.fileActionsSep2.Name = "fileActionsSep2";
            this.fileActionsSep2.Size = new System.Drawing.Size(225, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_saveas;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // fileActionsSep3
            // 
            this.fileActionsSep3.Name = "fileActionsSep3";
            this.fileActionsSep3.Size = new System.Drawing.Size(225, 6);
            // 
            // restartApplicationToolStripMenuItem
            // 
            this.restartApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restartApplicationToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_restart;
            this.restartApplicationToolStripMenuItem.Name = "restartApplicationToolStripMenuItem";
            this.restartApplicationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.restartApplicationToolStripMenuItem.Text = "&Restart Application";
            this.restartApplicationToolStripMenuItem.Click += new System.EventHandler(this.restartApplicationToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeApplicationToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_close;
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application (&X)";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllStripMenuItem,
            this.CutScriptStripMenuItem,
            this.CopyStripMenuItem,
            this.PasteStripMenuItem,
            this.editSplitMenuSeparator1,
            this.SearchStripMenuItem,
            this.ReplaceStripMenuItem,
            this.clearSearchHighlightsToolStripMenuItem1});
            this.editStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editStripMenuItem.Image = global::taskt.Properties.Resources.actionbar_edit;
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.editStripMenuItem.Text = "&Edit";
            // 
            // SelectAllStripMenuItem
            // 
            this.SelectAllStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SelectAllStripMenuItem.Name = "SelectAllStripMenuItem";
            this.SelectAllStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.SelectAllStripMenuItem.Text = "Select &All";
            this.SelectAllStripMenuItem.Click += new System.EventHandler(this.SelectAllStripMenuItem_Click);
            // 
            // CutScriptStripMenuItem
            // 
            this.CutScriptStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CutScriptStripMenuItem.Name = "CutScriptStripMenuItem";
            this.CutScriptStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutScriptStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.CutScriptStripMenuItem.Text = "Cut (&X)";
            this.CutScriptStripMenuItem.Click += new System.EventHandler(this.CutScriptStripMenuItem_Click);
            // 
            // CopyStripMenuItem
            // 
            this.CopyStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CopyStripMenuItem.Name = "CopyStripMenuItem";
            this.CopyStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.CopyStripMenuItem.Text = "&Copy";
            this.CopyStripMenuItem.Click += new System.EventHandler(this.CopyStripMenuItem_Click);
            // 
            // PasteStripMenuItem
            // 
            this.PasteStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.PasteStripMenuItem.Name = "PasteStripMenuItem";
            this.PasteStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.PasteStripMenuItem.Text = "Paste (&V)";
            this.PasteStripMenuItem.Click += new System.EventHandler(this.PasteStripMenuItem_Click);
            // 
            // editSplitMenuSeparator1
            // 
            this.editSplitMenuSeparator1.Name = "editSplitMenuSeparator1";
            this.editSplitMenuSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // SearchStripMenuItem
            // 
            this.SearchStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SearchStripMenuItem.Image = global::taskt.Properties.Resources.command_search;
            this.SearchStripMenuItem.Name = "SearchStripMenuItem";
            this.SearchStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.SearchStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.SearchStripMenuItem.Text = "&Search";
            this.SearchStripMenuItem.Click += new System.EventHandler(this.SearchStripMenuItem_Click);
            // 
            // ReplaceStripMenuItem
            // 
            this.ReplaceStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ReplaceStripMenuItem.Image = global::taskt.Properties.Resources.command_search;
            this.ReplaceStripMenuItem.Name = "ReplaceStripMenuItem";
            this.ReplaceStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ReplaceStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ReplaceStripMenuItem.Text = "&Replace";
            this.ReplaceStripMenuItem.Click += new System.EventHandler(this.ReplaceStripMenuItem_Click);
            // 
            // clearSearchHighlightsToolStripMenuItem1
            // 
            this.clearSearchHighlightsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.clearSearchHighlightsToolStripMenuItem1.Image = global::taskt.Properties.Resources.action_bar_clear;
            this.clearSearchHighlightsToolStripMenuItem1.Name = "clearSearchHighlightsToolStripMenuItem1";
            this.clearSearchHighlightsToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.clearSearchHighlightsToolStripMenuItem1.Text = "Clear Search &Highlights (&L)";
            this.clearSearchHighlightsToolStripMenuItem1.Click += new System.EventHandler(this.clearSearchHighlightsToolStripMenuItem1_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variablesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.showSearchBarToolStripMenuItem});
            this.modifyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modifyToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_options;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.modifyToolStripMenuItem.Text = "&Options";
            // 
            // variablesToolStripMenuItem
            // 
            this.variablesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.variablesToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_variable;
            this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
            this.variablesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.variablesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.variablesToolStripMenuItem.Text = "&Variable Manager";
            this.variablesToolStripMenuItem.Click += new System.EventHandler(this.variablesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_config;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.settingsToolStripMenuItem.Text = "&Settings Manager";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // showSearchBarToolStripMenuItem
            // 
            this.showSearchBarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showSearchBarToolStripMenuItem.Name = "showSearchBarToolStripMenuItem";
            this.showSearchBarToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showSearchBarToolStripMenuItem.Text = "Show Search &Bar";
            this.showSearchBarToolStripMenuItem.Click += new System.EventHandler(this.showSearchBarToolStripMenuItem_Click);
            // 
            // scriptActionsToolStripMenuItem
            // 
            this.scriptActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.runToolStripMenuItem});
            this.scriptActionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scriptActionsToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_record;
            this.scriptActionsToolStripMenuItem.Name = "scriptActionsToolStripMenuItem";
            this.scriptActionsToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.scriptActionsToolStripMenuItem.Text = "&Script Actions";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recordToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_record;
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordToolStripMenuItem.Text = "R&ecord";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scheduleToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_schedule;
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scheduleToolStripMenuItem.Text = "&Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.runToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_run;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // saveAndRunToolStripMenuItem
            // 
            this.saveAndRunToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAndRunToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_run;
            this.saveAndRunToolStripMenuItem.Name = "saveAndRunToolStripMenuItem";
            this.saveAndRunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.saveAndRunToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.saveAndRunToolStripMenuItem.Text = "Save and &Run";
            this.saveAndRunToolStripMenuItem.ToolTipText = "F5";
            this.saveAndRunToolStripMenuItem.Click += new System.EventHandler(this.saveAndRunToolStripMenuItem_Clicked);
            // 
            // tsSearchBox
            // 
            this.tsSearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsSearchBox.Name = "tsSearchBox";
            this.tsSearchBox.Size = new System.Drawing.Size(100, 26);
            this.tsSearchBox.Visible = false;
            this.tsSearchBox.TextChanged += new System.EventHandler(this.txtCommandSearch_TextChanged);
            // 
            // tsSearchButton
            // 
            this.tsSearchButton.ForeColor = System.Drawing.Color.White;
            this.tsSearchButton.Image = global::taskt.Properties.Resources.command_search;
            this.tsSearchButton.Name = "tsSearchButton";
            this.tsSearchButton.Size = new System.Drawing.Size(28, 26);
            this.tsSearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsSearchButton.Visible = false;
            this.tsSearchButton.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tsSearchResult
            // 
            this.tsSearchResult.ForeColor = System.Drawing.Color.White;
            this.tsSearchResult.Name = "tsSearchResult";
            this.tsSearchResult.Size = new System.Drawing.Size(12, 26);
            this.tsSearchResult.Visible = false;
            // 
            // helpStripMenuItem
            // 
            this.helpStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasktProjectPageStripMenuItem,
            this.tasktWikiStripMenuItem,
            this.helpToolStripSeparator1,
            this.releaseToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.helpToolStripSeparator2,
            this.aboutStripMenuItem});
            this.helpStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpStripMenuItem.Image = global::taskt.Properties.Resources.various_question;
            this.helpStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.helpStripMenuItem.Name = "helpStripMenuItem";
            this.helpStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.helpStripMenuItem.Text = "&Help";
            // 
            // tasktProjectPageStripMenuItem
            // 
            this.tasktProjectPageStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tasktProjectPageStripMenuItem.Image = global::taskt.Properties.Resources.taskt_logo_alt;
            this.tasktProjectPageStripMenuItem.Name = "tasktProjectPageStripMenuItem";
            this.tasktProjectPageStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tasktProjectPageStripMenuItem.Text = "taskt &Project Page";
            this.tasktProjectPageStripMenuItem.Click += new System.EventHandler(this.tasktProjectPageStripMenuItem_Click);
            // 
            // tasktWikiStripMenuItem
            // 
            this.tasktWikiStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tasktWikiStripMenuItem.Image = global::taskt.Properties.Resources.taskt_logo_alt;
            this.tasktWikiStripMenuItem.Name = "tasktWikiStripMenuItem";
            this.tasktWikiStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tasktWikiStripMenuItem.Text = "taskt &Wiki";
            this.tasktWikiStripMenuItem.Click += new System.EventHandler(this.tasktWikiStripMenuItem_Click);
            // 
            // helpToolStripSeparator1
            // 
            this.helpToolStripSeparator1.Name = "helpToolStripSeparator1";
            this.helpToolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.releaseToolStripMenuItem.Text = "&Release";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.issueToolStripMenuItem.Text = "&Issue";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // helpToolStripSeparator2
            // 
            this.helpToolStripSeparator2.Name = "helpToolStripSeparator2";
            this.helpToolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutStripMenuItem
            // 
            this.aboutStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutStripMenuItem.Image = global::taskt.Properties.Resources.logo;
            this.aboutStripMenuItem.Name = "aboutStripMenuItem";
            this.aboutStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutStripMenuItem.Text = "&About";
            this.aboutStripMenuItem.Click += new System.EventHandler(this.aboutStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.tlpControls.SetColumnSpan(this.panel1, 4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 5);
            this.panel1.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.tlpControls.SetColumnSpan(this.splitContainer1, 3);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 160);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.commandListTablePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.pnlCommandHelper);
            this.splitContainer1.Panel2.Controls.Add(this.lstScriptActions);
            this.splitContainer1.Size = new System.Drawing.Size(973, 364);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 4;
            // 
            // pnlCommandHelper
            // 
            this.pnlCommandHelper.AllowDrop = true;
            this.pnlCommandHelper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pnlCommandHelper.Controls.Add(this.lnkStartEdit);
            this.pnlCommandHelper.Controls.Add(this.flwRecentFiles);
            this.pnlCommandHelper.Controls.Add(this.lblFilesMissing);
            this.pnlCommandHelper.Controls.Add(this.pictureBox4);
            this.pnlCommandHelper.Controls.Add(this.pictureBox3);
            this.pnlCommandHelper.Controls.Add(this.pictureBox1);
            this.pnlCommandHelper.Controls.Add(this.lblRecentFiles);
            this.pnlCommandHelper.Controls.Add(this.lnkGitWiki);
            this.pnlCommandHelper.Controls.Add(this.lnkGitIssue);
            this.pnlCommandHelper.Controls.Add(this.lnkGitLatestReleases);
            this.pnlCommandHelper.Controls.Add(this.lnkGitProject);
            this.pnlCommandHelper.Controls.Add(this.label1);
            this.pnlCommandHelper.Controls.Add(this.lblNote);
            this.pnlCommandHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommandHelper.Location = new System.Drawing.Point(0, 0);
            this.pnlCommandHelper.Name = "pnlCommandHelper";
            this.pnlCommandHelper.Size = new System.Drawing.Size(731, 364);
            this.pnlCommandHelper.TabIndex = 7;
            this.pnlCommandHelper.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlCommandHelper_DragDrop);
            this.pnlCommandHelper.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlCommandHelper_DragEnter);
            this.pnlCommandHelper.DragLeave += new System.EventHandler(this.pnlCommandHelper_DragLeave);
            // 
            // lnkStartEdit
            // 
            this.lnkStartEdit.AutoSize = true;
            this.lnkStartEdit.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lnkStartEdit.LinkColor = System.Drawing.Color.AliceBlue;
            this.lnkStartEdit.Location = new System.Drawing.Point(315, 4);
            this.lnkStartEdit.Name = "lnkStartEdit";
            this.lnkStartEdit.Size = new System.Drawing.Size(156, 30);
            this.lnkStartEdit.TabIndex = 17;
            this.lnkStartEdit.TabStop = true;
            this.lnkStartEdit.Text = "Start Edit Script";
            this.lnkStartEdit.Click += new System.EventHandler(this.lnkStartEdit_Click);
            // 
            // flwRecentFiles
            // 
            this.flwRecentFiles.AutoScroll = true;
            this.flwRecentFiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwRecentFiles.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwRecentFiles.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.flwRecentFiles.Location = new System.Drawing.Point(116, 233);
            this.flwRecentFiles.Name = "flwRecentFiles";
            this.flwRecentFiles.Size = new System.Drawing.Size(397, 144);
            this.flwRecentFiles.TabIndex = 12;
            this.flwRecentFiles.WrapContents = false;
            // 
            // lblFilesMissing
            // 
            this.lblFilesMissing.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesMissing.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFilesMissing.Location = new System.Drawing.Point(115, 231);
            this.lblFilesMissing.Name = "lblFilesMissing";
            this.lblFilesMissing.Size = new System.Drawing.Size(358, 64);
            this.lblFilesMissing.TabIndex = 16;
            this.lblFilesMissing.Text = "there were no script files found in your script directory.";
            this.lblFilesMissing.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::taskt.Properties.Resources.recent_files;
            this.pictureBox4.Location = new System.Drawing.Point(12, 210);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::taskt.Properties.Resources.links_header;
            this.pictureBox3.Location = new System.Drawing.Point(12, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::taskt.Properties.Resources.item_header;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblRecentFiles
            // 
            this.lblRecentFiles.AutoSize = true;
            this.lblRecentFiles.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentFiles.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblRecentFiles.Location = new System.Drawing.Point(110, 201);
            this.lblRecentFiles.Name = "lblRecentFiles";
            this.lblRecentFiles.Size = new System.Drawing.Size(121, 30);
            this.lblRecentFiles.TabIndex = 8;
            this.lblRecentFiles.Text = "Recent Files";
            // 
            // lnkGitWiki
            // 
            this.lnkGitWiki.AutoSize = true;
            this.lnkGitWiki.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitWiki.ForeColor = System.Drawing.Color.White;
            this.lnkGitWiki.LinkColor = System.Drawing.Color.AliceBlue;
            this.lnkGitWiki.Location = new System.Drawing.Point(116, 169);
            this.lnkGitWiki.Name = "lnkGitWiki";
            this.lnkGitWiki.Size = new System.Drawing.Size(169, 20);
            this.lnkGitWiki.TabIndex = 6;
            this.lnkGitWiki.TabStop = true;
            this.lnkGitWiki.Text = "View Documentation/Wiki";
            this.lnkGitWiki.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            this.lnkGitWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitWiki_LinkClicked);
            // 
            // lnkGitIssue
            // 
            this.lnkGitIssue.AutoSize = true;
            this.lnkGitIssue.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitIssue.ForeColor = System.Drawing.Color.White;
            this.lnkGitIssue.LinkColor = System.Drawing.Color.AliceBlue;
            this.lnkGitIssue.Location = new System.Drawing.Point(116, 149);
            this.lnkGitIssue.Name = "lnkGitIssue";
            this.lnkGitIssue.Size = new System.Drawing.Size(251, 20);
            this.lnkGitIssue.TabIndex = 5;
            this.lnkGitIssue.TabStop = true;
            this.lnkGitIssue.Text = "Request Enhancement or Report a bug";
            this.lnkGitIssue.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            this.lnkGitIssue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitIssue_LinkClicked);
            // 
            // lnkGitLatestReleases
            // 
            this.lnkGitLatestReleases.AutoSize = true;
            this.lnkGitLatestReleases.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitLatestReleases.ForeColor = System.Drawing.Color.White;
            this.lnkGitLatestReleases.LinkColor = System.Drawing.Color.AliceBlue;
            this.lnkGitLatestReleases.Location = new System.Drawing.Point(116, 129);
            this.lnkGitLatestReleases.Name = "lnkGitLatestReleases";
            this.lnkGitLatestReleases.Size = new System.Drawing.Size(137, 20);
            this.lnkGitLatestReleases.TabIndex = 4;
            this.lnkGitLatestReleases.TabStop = true;
            this.lnkGitLatestReleases.Text = "View Latest Releases";
            this.lnkGitLatestReleases.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            this.lnkGitLatestReleases.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitLatestReleases_LinkClicked);
            // 
            // lnkGitProject
            // 
            this.lnkGitProject.AutoSize = true;
            this.lnkGitProject.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGitProject.ForeColor = System.Drawing.Color.White;
            this.lnkGitProject.LinkColor = System.Drawing.Color.AliceBlue;
            this.lnkGitProject.Location = new System.Drawing.Point(116, 109);
            this.lnkGitProject.Name = "lnkGitProject";
            this.lnkGitProject.Size = new System.Drawing.Size(153, 20);
            this.lnkGitProject.TabIndex = 3;
            this.lnkGitProject.TabStop = true;
            this.lnkGitProject.Text = "View Project on GitHub";
            this.lnkGitProject.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            this.lnkGitProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitProject_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(111, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to taskt!";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(114, 32);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(399, 43);
            this.lblNote.TabIndex = 1;
            this.lblNote.Text = "Start building automation by double-clicking a command from the list to the left." +
    "";
            // 
            // lstScriptActions
            // 
            this.lstScriptActions.AllowDrop = true;
            this.lstScriptActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstScriptActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstScriptActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.commandColumn});
            this.lstScriptActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstScriptActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScriptActions.FullRowSelect = true;
            this.lstScriptActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstScriptActions.HideSelection = false;
            this.lstScriptActions.Location = new System.Drawing.Point(0, 0);
            this.lstScriptActions.Margin = new System.Windows.Forms.Padding(5);
            this.lstScriptActions.Name = "lstScriptActions";
            this.lstScriptActions.OwnerDraw = true;
            this.lstScriptActions.Size = new System.Drawing.Size(731, 364);
            this.lstScriptActions.TabIndex = 6;
            this.lstScriptActions.UseCompatibleStateImageBehavior = false;
            this.lstScriptActions.View = System.Windows.Forms.View.Details;
            this.lstScriptActions.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lstScriptActions_DrawSubItem);
            this.lstScriptActions.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lstScriptActions_ItemDrag);
            this.lstScriptActions.SelectedIndexChanged += new System.EventHandler(this.lstScriptActions_SelectedIndexChanged);
            this.lstScriptActions.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstScriptActions_DragDrop);
            this.lstScriptActions.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstScriptActions_DragEnter);
            this.lstScriptActions.DragLeave += new System.EventHandler(this.lstScriptActions_DragLeave);
            this.lstScriptActions.DoubleClick += new System.EventHandler(this.lstScriptActions_DoubleClick);
            this.lstScriptActions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstScriptActions_KeyDown);
            this.lstScriptActions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstScriptActions_MouseClick);
            this.lstScriptActions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstScriptActions_MouseMove);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 20;
            // 
            // commandColumn
            // 
            this.commandColumn.Text = "Script Commands";
            this.commandColumn.Width = 800;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.tlpControls.SetColumnSpan(this.pnlHeader, 3);
            this.pnlHeader.Controls.Add(this.pnlMain);
            this.pnlHeader.Controls.Add(this.lblCoordinatorInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(979, 41);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblMainLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(979, 41);
            this.pnlMain.TabIndex = 2;
            theme2.BgGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            theme2.BgGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlMain.Theme = theme2;
            // 
            // lblMainLogo
            // 
            this.lblMainLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMainLogo.AutoSize = true;
            this.lblMainLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblMainLogo.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLogo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblMainLogo.Location = new System.Drawing.Point(2, -1);
            this.lblMainLogo.Margin = new System.Windows.Forms.Padding(0);
            this.lblMainLogo.Name = "lblMainLogo";
            this.lblMainLogo.Size = new System.Drawing.Size(82, 45);
            this.lblMainLogo.TabIndex = 0;
            this.lblMainLogo.Text = "taskt";
            this.lblMainLogo.Click += new System.EventHandler(this.lblMainLogo_Click);
            // 
            // lblCoordinatorInfo
            // 
            this.lblCoordinatorInfo.AutoSize = true;
            this.lblCoordinatorInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCoordinatorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinatorInfo.ForeColor = System.Drawing.Color.White;
            this.lblCoordinatorInfo.Location = new System.Drawing.Point(228, 16);
            this.lblCoordinatorInfo.Name = "lblCoordinatorInfo";
            this.lblCoordinatorInfo.Size = new System.Drawing.Size(0, 20);
            this.lblCoordinatorInfo.TabIndex = 3;
            this.lblCoordinatorInfo.Visible = false;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.tlpControls.SetColumnSpan(this.pnlStatus, 3);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus.Location = new System.Drawing.Point(0, 527);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(979, 31);
            this.pnlStatus.TabIndex = 3;
            this.pnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStatus_Paint);
            // 
            // pnlControlContainer
            // 
            this.pnlControlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tlpControls.SetColumnSpan(this.pnlControlContainer, 3);
            this.pnlControlContainer.Controls.Add(this.grpSearch);
            this.pnlControlContainer.Controls.Add(this.grpSaveClose);
            this.pnlControlContainer.Controls.Add(this.grpFileActions);
            this.pnlControlContainer.Controls.Add(this.grpRecordRun);
            this.pnlControlContainer.Controls.Add(this.grpVariable);
            this.pnlControlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlContainer.Location = new System.Drawing.Point(0, 71);
            this.pnlControlContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControlContainer.Name = "pnlControlContainer";
            this.pnlControlContainer.Size = new System.Drawing.Size(979, 81);
            this.pnlControlContainer.TabIndex = 7;
            this.pnlControlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControlContainer_Paint);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.pbSearch);
            this.grpSearch.Controls.Add(this.lblCurrentlyViewing);
            this.grpSearch.Controls.Add(this.lblTotalResults);
            this.grpSearch.Controls.Add(this.txtCommandSearch);
            this.grpSearch.Location = new System.Drawing.Point(593, 6);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(198, 73);
            this.grpSearch.TabIndex = 20;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            this.grpSearch.TitleBackColor = System.Drawing.Color.Transparent;
            this.grpSearch.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.TitleForeColor = System.Drawing.Color.GhostWhite;
            this.grpSearch.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::taskt.Properties.Resources.command_search;
            this.pbSearch.Location = new System.Drawing.Point(158, 18);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(16, 16);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 17;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
            this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
            // 
            // lblCurrentlyViewing
            // 
            this.lblCurrentlyViewing.AutoSize = true;
            this.lblCurrentlyViewing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentlyViewing.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurrentlyViewing.Location = new System.Drawing.Point(5, 56);
            this.lblCurrentlyViewing.Name = "lblCurrentlyViewing";
            this.lblCurrentlyViewing.Size = new System.Drawing.Size(102, 13);
            this.lblCurrentlyViewing.TabIndex = 3;
            this.lblCurrentlyViewing.Text = "Viewing Result X/Y";
            this.lblCurrentlyViewing.Visible = false;
            // 
            // lblTotalResults
            // 
            this.lblTotalResults.AutoSize = true;
            this.lblTotalResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResults.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalResults.Location = new System.Drawing.Point(5, 42);
            this.lblTotalResults.Name = "lblTotalResults";
            this.lblTotalResults.Size = new System.Drawing.Size(118, 13);
            this.lblTotalResults.TabIndex = 2;
            this.lblTotalResults.Text = "X Total Results Found";
            this.lblTotalResults.Visible = false;
            // 
            // txtCommandSearch
            // 
            this.txtCommandSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandSearch.Location = new System.Drawing.Point(5, 16);
            this.txtCommandSearch.Name = "txtCommandSearch";
            this.txtCommandSearch.Size = new System.Drawing.Size(151, 23);
            this.txtCommandSearch.TabIndex = 0;
            this.txtCommandSearch.TextChanged += new System.EventHandler(this.txtCommandSearch_TextChanged);
            // 
            // grpSaveClose
            // 
            this.grpSaveClose.BackColor = System.Drawing.Color.Transparent;
            this.grpSaveClose.Controls.Add(this.btnSequenceImport);
            this.grpSaveClose.Controls.Add(this.uiBtnKeep);
            this.grpSaveClose.Controls.Add(this.uiBtnClose);
            this.grpSaveClose.Location = new System.Drawing.Point(787, 3);
            this.grpSaveClose.Name = "grpSaveClose";
            this.grpSaveClose.Size = new System.Drawing.Size(165, 73);
            this.grpSaveClose.TabIndex = 19;
            this.grpSaveClose.TabStop = false;
            this.grpSaveClose.Text = "Save and Close";
            this.grpSaveClose.TitleBackColor = System.Drawing.Color.Transparent;
            this.grpSaveClose.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaveClose.TitleForeColor = System.Drawing.Color.GhostWhite;
            this.grpSaveClose.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            this.grpSaveClose.Visible = false;
            // 
            // btnSequenceImport
            // 
            this.btnSequenceImport.BackColor = System.Drawing.Color.Transparent;
            this.btnSequenceImport.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSequenceImport.DisplayText = "Import";
            this.btnSequenceImport.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.btnSequenceImport.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSequenceImport.Image = global::taskt.Properties.Resources.action_bar_import;
            this.btnSequenceImport.IsMouseOver = false;
            this.btnSequenceImport.Location = new System.Drawing.Point(110, 18);
            this.btnSequenceImport.Name = "btnSequenceImport";
            this.btnSequenceImport.Size = new System.Drawing.Size(48, 50);
            this.btnSequenceImport.TabIndex = 20;
            this.btnSequenceImport.TabStop = false;
            this.btnSequenceImport.Text = "Import";
            this.btnSequenceImport.Click += new System.EventHandler(this.btnSequenceImport_Click);
            // 
            // uiBtnKeep
            // 
            this.uiBtnKeep.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnKeep.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnKeep.DisplayText = "Keep";
            this.uiBtnKeep.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnKeep.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnKeep.Image = global::taskt.Properties.Resources.action_bar_record;
            this.uiBtnKeep.IsMouseOver = false;
            this.uiBtnKeep.Location = new System.Drawing.Point(2, 18);
            this.uiBtnKeep.Name = "uiBtnKeep";
            this.uiBtnKeep.Size = new System.Drawing.Size(48, 50);
            this.uiBtnKeep.TabIndex = 19;
            this.uiBtnKeep.TabStop = false;
            this.uiBtnKeep.Text = "Keep";
            this.uiBtnKeep.Click += new System.EventHandler(this.uiBtnKeep_Click);
            // 
            // uiBtnClose
            // 
            this.uiBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnClose.DisplayText = "Close";
            this.uiBtnClose.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnClose.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnClose.Image = global::taskt.Properties.Resources.action_bar_schedule;
            this.uiBtnClose.IsMouseOver = false;
            this.uiBtnClose.Location = new System.Drawing.Point(54, 18);
            this.uiBtnClose.Name = "uiBtnClose";
            this.uiBtnClose.Size = new System.Drawing.Size(52, 50);
            this.uiBtnClose.TabIndex = 13;
            this.uiBtnClose.TabStop = false;
            this.uiBtnClose.Text = "Close";
            this.uiBtnClose.Click += new System.EventHandler(this.uiBtnClose_Click);
            // 
            // grpFileActions
            // 
            this.grpFileActions.BackColor = System.Drawing.Color.Transparent;
            this.grpFileActions.Controls.Add(this.uiBtnImport);
            this.grpFileActions.Controls.Add(this.uiBtnSaveAs);
            this.grpFileActions.Controls.Add(this.uiBtnSave);
            this.grpFileActions.Controls.Add(this.uiBtnNew);
            this.grpFileActions.Controls.Add(this.uiBtnOpen);
            this.grpFileActions.Location = new System.Drawing.Point(2, 5);
            this.grpFileActions.Name = "grpFileActions";
            this.grpFileActions.Size = new System.Drawing.Size(255, 73);
            this.grpFileActions.TabIndex = 16;
            this.grpFileActions.TabStop = false;
            this.grpFileActions.Text = "File Actions";
            this.grpFileActions.TitleBackColor = System.Drawing.Color.Transparent;
            this.grpFileActions.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFileActions.TitleForeColor = System.Drawing.Color.GhostWhite;
            this.grpFileActions.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // uiBtnImport
            // 
            this.uiBtnImport.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnImport.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnImport.DisplayText = "Import";
            this.uiBtnImport.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnImport.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnImport.Image = global::taskt.Properties.Resources.action_bar_import;
            this.uiBtnImport.IsMouseOver = false;
            this.uiBtnImport.Location = new System.Drawing.Point(100, 19);
            this.uiBtnImport.Name = "uiBtnImport";
            this.uiBtnImport.Size = new System.Drawing.Size(48, 50);
            this.uiBtnImport.TabIndex = 14;
            this.uiBtnImport.TabStop = false;
            this.uiBtnImport.Text = "Import";
            this.uiBtnImport.Click += new System.EventHandler(this.uiBtnImport_Click);
            // 
            // uiBtnSaveAs
            // 
            this.uiBtnSaveAs.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnSaveAs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnSaveAs.DisplayText = "Save As";
            this.uiBtnSaveAs.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnSaveAs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnSaveAs.Image = global::taskt.Properties.Resources.action_bar_saveas;
            this.uiBtnSaveAs.IsMouseOver = false;
            this.uiBtnSaveAs.Location = new System.Drawing.Point(198, 19);
            this.uiBtnSaveAs.Name = "uiBtnSaveAs";
            this.uiBtnSaveAs.Size = new System.Drawing.Size(48, 50);
            this.uiBtnSaveAs.TabIndex = 13;
            this.uiBtnSaveAs.TabStop = false;
            this.uiBtnSaveAs.Text = "Save As";
            this.uiBtnSaveAs.Click += new System.EventHandler(this.uiBtnSaveAs_Click);
            // 
            // uiBtnSave
            // 
            this.uiBtnSave.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnSave.DisplayText = "Save";
            this.uiBtnSave.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnSave.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnSave.Image = global::taskt.Properties.Resources.action_bar_save;
            this.uiBtnSave.IsMouseOver = false;
            this.uiBtnSave.Location = new System.Drawing.Point(149, 19);
            this.uiBtnSave.Name = "uiBtnSave";
            this.uiBtnSave.Size = new System.Drawing.Size(48, 50);
            this.uiBtnSave.TabIndex = 11;
            this.uiBtnSave.TabStop = false;
            this.uiBtnSave.Text = "Save";
            this.uiBtnSave.Click += new System.EventHandler(this.uiBtnSave_Click);
            // 
            // uiBtnNew
            // 
            this.uiBtnNew.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnNew.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnNew.DisplayText = "New";
            this.uiBtnNew.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uiBtnNew.Image = global::taskt.Properties.Resources.action_bar_new;
            this.uiBtnNew.IsMouseOver = false;
            this.uiBtnNew.Location = new System.Drawing.Point(2, 19);
            this.uiBtnNew.Name = "uiBtnNew";
            this.uiBtnNew.Size = new System.Drawing.Size(48, 50);
            this.uiBtnNew.TabIndex = 12;
            this.uiBtnNew.TabStop = false;
            this.uiBtnNew.Text = "New";
            this.uiBtnNew.Click += new System.EventHandler(this.uiBtnNew_Click);
            // 
            // uiBtnOpen
            // 
            this.uiBtnOpen.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnOpen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnOpen.DisplayText = "Open";
            this.uiBtnOpen.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnOpen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnOpen.Image = global::taskt.Properties.Resources.action_bar_open;
            this.uiBtnOpen.IsMouseOver = false;
            this.uiBtnOpen.Location = new System.Drawing.Point(51, 19);
            this.uiBtnOpen.Name = "uiBtnOpen";
            this.uiBtnOpen.Size = new System.Drawing.Size(48, 50);
            this.uiBtnOpen.TabIndex = 10;
            this.uiBtnOpen.TabStop = false;
            this.uiBtnOpen.Text = "Open";
            this.uiBtnOpen.Click += new System.EventHandler(this.uiBtnOpen_Click);
            // 
            // grpRecordRun
            // 
            this.grpRecordRun.BackColor = System.Drawing.Color.Transparent;
            this.grpRecordRun.Controls.Add(this.uiBtnRecordSequence);
            this.grpRecordRun.Controls.Add(this.uiBtnRunScript);
            this.grpRecordRun.Controls.Add(this.uiBtnScheduleManagement);
            this.grpRecordRun.Location = new System.Drawing.Point(433, 6);
            this.grpRecordRun.Name = "grpRecordRun";
            this.grpRecordRun.Size = new System.Drawing.Size(162, 73);
            this.grpRecordRun.TabIndex = 18;
            this.grpRecordRun.TabStop = false;
            this.grpRecordRun.Text = "Record and Run";
            this.grpRecordRun.TitleBackColor = System.Drawing.Color.Transparent;
            this.grpRecordRun.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecordRun.TitleForeColor = System.Drawing.Color.GhostWhite;
            this.grpRecordRun.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // uiBtnRecordSequence
            // 
            this.uiBtnRecordSequence.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnRecordSequence.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnRecordSequence.DisplayText = "Record";
            this.uiBtnRecordSequence.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnRecordSequence.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnRecordSequence.Image = global::taskt.Properties.Resources.action_bar_record;
            this.uiBtnRecordSequence.IsMouseOver = false;
            this.uiBtnRecordSequence.Location = new System.Drawing.Point(2, 18);
            this.uiBtnRecordSequence.Name = "uiBtnRecordSequence";
            this.uiBtnRecordSequence.Size = new System.Drawing.Size(48, 50);
            this.uiBtnRecordSequence.TabIndex = 19;
            this.uiBtnRecordSequence.TabStop = false;
            this.uiBtnRecordSequence.Text = "Record";
            this.uiBtnRecordSequence.Click += new System.EventHandler(this.uiBtnRecordSequence_Click);
            // 
            // uiBtnRunScript
            // 
            this.uiBtnRunScript.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnRunScript.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnRunScript.DisplayText = "Run";
            this.uiBtnRunScript.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnRunScript.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnRunScript.Image = global::taskt.Properties.Resources.action_bar_run;
            this.uiBtnRunScript.IsMouseOver = false;
            this.uiBtnRunScript.Location = new System.Drawing.Point(104, 18);
            this.uiBtnRunScript.Name = "uiBtnRunScript";
            this.uiBtnRunScript.Size = new System.Drawing.Size(48, 50);
            this.uiBtnRunScript.TabIndex = 12;
            this.uiBtnRunScript.TabStop = false;
            this.uiBtnRunScript.Text = "Run";
            this.uiBtnRunScript.Click += new System.EventHandler(this.uiBtnRunScript_Click);
            // 
            // uiBtnScheduleManagement
            // 
            this.uiBtnScheduleManagement.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnScheduleManagement.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnScheduleManagement.DisplayText = "Schedule";
            this.uiBtnScheduleManagement.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnScheduleManagement.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnScheduleManagement.Image = global::taskt.Properties.Resources.action_bar_schedule;
            this.uiBtnScheduleManagement.IsMouseOver = false;
            this.uiBtnScheduleManagement.Location = new System.Drawing.Point(51, 18);
            this.uiBtnScheduleManagement.Name = "uiBtnScheduleManagement";
            this.uiBtnScheduleManagement.Size = new System.Drawing.Size(52, 50);
            this.uiBtnScheduleManagement.TabIndex = 13;
            this.uiBtnScheduleManagement.TabStop = false;
            this.uiBtnScheduleManagement.Text = "Schedule";
            this.uiBtnScheduleManagement.Click += new System.EventHandler(this.uiBtnScheduleManagement_Click);
            // 
            // grpVariable
            // 
            this.grpVariable.BackColor = System.Drawing.Color.Transparent;
            this.grpVariable.Controls.Add(this.uiBtnClearAll);
            this.grpVariable.Controls.Add(this.uiBtnSettings);
            this.grpVariable.Controls.Add(this.uiBtnAddVariable);
            this.grpVariable.Location = new System.Drawing.Point(257, 6);
            this.grpVariable.Name = "grpVariable";
            this.grpVariable.Size = new System.Drawing.Size(171, 73);
            this.grpVariable.TabIndex = 17;
            this.grpVariable.TabStop = false;
            this.grpVariable.Text = "Variables and Settings";
            this.grpVariable.TitleBackColor = System.Drawing.Color.Transparent;
            this.grpVariable.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVariable.TitleForeColor = System.Drawing.Color.GhostWhite;
            this.grpVariable.TitleHatchStyle = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            // 
            // uiBtnClearAll
            // 
            this.uiBtnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnClearAll.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnClearAll.DisplayText = "Clear";
            this.uiBtnClearAll.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnClearAll.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnClearAll.Image = global::taskt.Properties.Resources.action_bar_clear;
            this.uiBtnClearAll.IsMouseOver = false;
            this.uiBtnClearAll.Location = new System.Drawing.Point(108, 19);
            this.uiBtnClearAll.Name = "uiBtnClearAll";
            this.uiBtnClearAll.Size = new System.Drawing.Size(48, 50);
            this.uiBtnClearAll.TabIndex = 14;
            this.uiBtnClearAll.TabStop = false;
            this.uiBtnClearAll.Text = "Clear";
            this.uiBtnClearAll.Click += new System.EventHandler(this.uiBtnClearAll_Click);
            // 
            // uiBtnSettings
            // 
            this.uiBtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnSettings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnSettings.DisplayText = "Settings";
            this.uiBtnSettings.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnSettings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnSettings.Image = global::taskt.Properties.Resources.action_bar_options;
            this.uiBtnSettings.IsMouseOver = false;
            this.uiBtnSettings.Location = new System.Drawing.Point(59, 19);
            this.uiBtnSettings.Name = "uiBtnSettings";
            this.uiBtnSettings.Size = new System.Drawing.Size(48, 50);
            this.uiBtnSettings.TabIndex = 12;
            this.uiBtnSettings.TabStop = false;
            this.uiBtnSettings.Text = "Settings";
            this.uiBtnSettings.Click += new System.EventHandler(this.uiBtnSettings_Click);
            // 
            // uiBtnAddVariable
            // 
            this.uiBtnAddVariable.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnAddVariable.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiBtnAddVariable.DisplayText = "Variables";
            this.uiBtnAddVariable.DisplayTextBrush = System.Drawing.Color.AliceBlue;
            this.uiBtnAddVariable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.uiBtnAddVariable.Image = global::taskt.Properties.Resources.action_bar_variable;
            this.uiBtnAddVariable.IsMouseOver = false;
            this.uiBtnAddVariable.Location = new System.Drawing.Point(6, 19);
            this.uiBtnAddVariable.Name = "uiBtnAddVariable";
            this.uiBtnAddVariable.Size = new System.Drawing.Size(52, 50);
            this.uiBtnAddVariable.TabIndex = 13;
            this.uiBtnAddVariable.TabStop = false;
            this.uiBtnAddVariable.Text = "Variables";
            this.uiBtnAddVariable.Click += new System.EventHandler(this.uiBtnAddVariable_Click);
            // 
            // tmrNotify
            // 
            this.tmrNotify.Enabled = true;
            this.tmrNotify.Interval = 500;
            this.tmrNotify.Tick += new System.EventHandler(this.tmrNotify_Tick);
            // 
            // lstContextStrip
            // 
            this.lstContextStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editThisCodeToolStripMenuItem,
            this.helpThisCommandToolStripMenuItem1,
            this.lstContextStripSep1,
            this.enableSelectedCodeToolStripMenuItem,
            this.disableSelectedCodeToolStripMenuItem,
            this.pauseBeforeExecutionToolStripMenuItem,
            this.lstContextStripSep2,
            this.selectAllToolStripMenuItem,
            this.cutSelectedActionssToolStripMenuItem,
            this.copySelectedToolStripMenuItem,
            this.pasteSelectedToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem,
            this.lstContextStripSep3,
            this.moveToParentToolStripMenuItem,
            this.lstContextStripSep4,
            this.searchThisCommnadToolStripMenuItem,
            this.clearHighlightToolStripMenuItem,
            this.lstContextStripSep5,
            this.viewCodeToolStripMenuItem,
            this.showScriptInfoMenuItem,
            this.variableManagerToolStripMenuItem});
            this.lstContextStrip.Name = "lstContextStrip";
            this.lstContextStrip.Size = new System.Drawing.Size(345, 418);
            // 
            // editThisCodeToolStripMenuItem
            // 
            this.editThisCodeToolStripMenuItem.Image = global::taskt.Properties.Resources.actionbar_edit;
            this.editThisCodeToolStripMenuItem.Name = "editThisCodeToolStripMenuItem";
            this.editThisCodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.editThisCodeToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.editThisCodeToolStripMenuItem.Text = "Edit &This Action";
            this.editThisCodeToolStripMenuItem.Click += new System.EventHandler(this.editThisCodeToolStripMenuItem_Click);
            // 
            // helpThisCommandToolStripMenuItem1
            // 
            this.helpThisCommandToolStripMenuItem1.Image = global::taskt.Properties.Resources.web_help;
            this.helpThisCommandToolStripMenuItem1.Name = "helpThisCommandToolStripMenuItem1";
            this.helpThisCommandToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpThisCommandToolStripMenuItem1.Size = new System.Drawing.Size(344, 24);
            this.helpThisCommandToolStripMenuItem1.Text = "Help This Command (&Web)";
            this.helpThisCommandToolStripMenuItem1.Click += new System.EventHandler(this.helpThisCommandToolStripMenuItem1_Click);
            // 
            // lstContextStripSep1
            // 
            this.lstContextStripSep1.Name = "lstContextStripSep1";
            this.lstContextStripSep1.Size = new System.Drawing.Size(341, 6);
            // 
            // enableSelectedCodeToolStripMenuItem
            // 
            this.enableSelectedCodeToolStripMenuItem.Image = global::taskt.Properties.Resources.various_ok_button;
            this.enableSelectedCodeToolStripMenuItem.Name = "enableSelectedCodeToolStripMenuItem";
            this.enableSelectedCodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.enableSelectedCodeToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.enableSelectedCodeToolStripMenuItem.Text = "&Enable Selected Action";
            this.enableSelectedCodeToolStripMenuItem.Click += new System.EventHandler(this.enableSelectedCodeToolStripMenuItem_Click);
            // 
            // disableSelectedCodeToolStripMenuItem
            // 
            this.disableSelectedCodeToolStripMenuItem.Image = global::taskt.Properties.Resources.various_cancel_button;
            this.disableSelectedCodeToolStripMenuItem.Name = "disableSelectedCodeToolStripMenuItem";
            this.disableSelectedCodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.disableSelectedCodeToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.disableSelectedCodeToolStripMenuItem.Text = "&Disable Selected Action";
            this.disableSelectedCodeToolStripMenuItem.Click += new System.EventHandler(this.disableSelectedCodeToolStripMenuItem_Click);
            // 
            // pauseBeforeExecutionToolStripMenuItem
            // 
            this.pauseBeforeExecutionToolStripMenuItem.Image = global::taskt.Properties.Resources.command_pause;
            this.pauseBeforeExecutionToolStripMenuItem.Name = "pauseBeforeExecutionToolStripMenuItem";
            this.pauseBeforeExecutionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pauseBeforeExecutionToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.pauseBeforeExecutionToolStripMenuItem.Text = "&Pause Before Execution";
            this.pauseBeforeExecutionToolStripMenuItem.Click += new System.EventHandler(this.pauseBeforeExecutionToolStripMenuItem_Click);
            // 
            // lstContextStripSep2
            // 
            this.lstContextStripSep2.Name = "lstContextStripSep2";
            this.lstContextStripSep2.Size = new System.Drawing.Size(341, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutSelectedActionssToolStripMenuItem
            // 
            this.cutSelectedActionssToolStripMenuItem.Name = "cutSelectedActionssToolStripMenuItem";
            this.cutSelectedActionssToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutSelectedActionssToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.cutSelectedActionssToolStripMenuItem.Text = "Cut Selected Action(s) (&X)";
            this.cutSelectedActionssToolStripMenuItem.Click += new System.EventHandler(this.cutSelectedActionssToolStripMenuItem_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.copySelectedToolStripMenuItem.Text = "&Copy Selected Action(s)";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // pasteSelectedToolStripMenuItem
            // 
            this.pasteSelectedToolStripMenuItem.Name = "pasteSelectedToolStripMenuItem";
            this.pasteSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteSelectedToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.pasteSelectedToolStripMenuItem.Text = "Paste Selected Action(s) (&V)";
            this.pasteSelectedToolStripMenuItem.Click += new System.EventHandler(this.pasteSelectedToolStripMenuItem_Click);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected Action(s)";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // lstContextStripSep3
            // 
            this.lstContextStripSep3.Name = "lstContextStripSep3";
            this.lstContextStripSep3.Size = new System.Drawing.Size(341, 6);
            this.lstContextStripSep3.Visible = false;
            // 
            // moveToParentToolStripMenuItem
            // 
            this.moveToParentToolStripMenuItem.Name = "moveToParentToolStripMenuItem";
            this.moveToParentToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.moveToParentToolStripMenuItem.Text = "&Move Out To Parent";
            this.moveToParentToolStripMenuItem.Visible = false;
            this.moveToParentToolStripMenuItem.Click += new System.EventHandler(this.moveToParentToolStripMenuItem_Click);
            // 
            // lstContextStripSep4
            // 
            this.lstContextStripSep4.Name = "lstContextStripSep4";
            this.lstContextStripSep4.Size = new System.Drawing.Size(341, 6);
            // 
            // searchThisCommnadToolStripMenuItem
            // 
            this.searchThisCommnadToolStripMenuItem.Image = global::taskt.Properties.Resources.command_search;
            this.searchThisCommnadToolStripMenuItem.Name = "searchThisCommnadToolStripMenuItem";
            this.searchThisCommnadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.searchThisCommnadToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.searchThisCommnadToolStripMenuItem.Text = "&Highlight This Command";
            this.searchThisCommnadToolStripMenuItem.Click += new System.EventHandler(this.searchThisCommnadToolStripMenuItem_Click);
            // 
            // clearHighlightToolStripMenuItem
            // 
            this.clearHighlightToolStripMenuItem.Name = "clearHighlightToolStripMenuItem";
            this.clearHighlightToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.clearHighlightToolStripMenuItem.Text = "Clear Highlight (&L)";
            this.clearHighlightToolStripMenuItem.Click += new System.EventHandler(this.clearHighlightToolStripMenuItem_Click);
            // 
            // lstContextStripSep5
            // 
            this.lstContextStripSep5.Name = "lstContextStripSep5";
            this.lstContextStripSep5.Size = new System.Drawing.Size(341, 6);
            // 
            // viewCodeToolStripMenuItem
            // 
            this.viewCodeToolStripMenuItem.Name = "viewCodeToolStripMenuItem";
            this.viewCodeToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.viewCodeToolStripMenuItem.Text = "View Code (&I)";
            this.viewCodeToolStripMenuItem.Click += new System.EventHandler(this.viewCodeToolStripMenuItem_Click);
            // 
            // showScriptInfoMenuItem
            // 
            this.showScriptInfoMenuItem.Image = global::taskt.Properties.Resources.various_question;
            this.showScriptInfoMenuItem.Name = "showScriptInfoMenuItem";
            this.showScriptInfoMenuItem.Size = new System.Drawing.Size(344, 24);
            this.showScriptInfoMenuItem.Text = "&Show Script Informations";
            this.showScriptInfoMenuItem.Click += new System.EventHandler(this.showScriptInfoMenuItem_Click);
            // 
            // variableManagerToolStripMenuItem
            // 
            this.variableManagerToolStripMenuItem.Image = global::taskt.Properties.Resources.action_bar_variable;
            this.variableManagerToolStripMenuItem.Name = "variableManagerToolStripMenuItem";
            this.variableManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.variableManagerToolStripMenuItem.Size = new System.Drawing.Size(344, 24);
            this.variableManagerToolStripMenuItem.Text = "Variable &Manager";
            this.variableManagerToolStripMenuItem.Click += new System.EventHandler(this.variableManagerToolStripMenuItem_Click);
            // 
            // notifyTray
            // 
            this.notifyTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyTray.BalloonTipText = "taskt is still running in your system tray. Double-click to restore taskt to full" +
    " size!\r\n";
            this.notifyTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTray.Icon")));
            this.notifyTray.Text = "taskt, free and open-source process automation";
            this.notifyTray.Visible = true;
            this.notifyTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyTray_MouseDoubleClick);
            // 
            // commandListTablePanel
            // 
            this.commandListTablePanel.ColumnCount = 1;
            this.commandListTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commandListTablePanel.Controls.Add(this.commandsListPanelU, 0, 0);
            this.commandListTablePanel.Controls.Add(this.commandListPanelD, 0, 1);
            this.commandListTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandListTablePanel.Location = new System.Drawing.Point(0, 0);
            this.commandListTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.commandListTablePanel.Name = "commandListTablePanel";
            this.commandListTablePanel.RowCount = 2;
            this.commandListTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.commandListTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.commandListTablePanel.Size = new System.Drawing.Size(238, 364);
            this.commandListTablePanel.TabIndex = 9;
            // 
            // commandsListPanelU
            // 
            this.commandsListPanelU.Controls.Add(this.picCommandClear);
            this.commandsListPanelU.Controls.Add(this.picCommandSearch);
            this.commandsListPanelU.Controls.Add(this.txtCommandFilter);
            this.commandsListPanelU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsListPanelU.Location = new System.Drawing.Point(0, 0);
            this.commandsListPanelU.Margin = new System.Windows.Forms.Padding(0);
            this.commandsListPanelU.Name = "commandsListPanelU";
            this.commandsListPanelU.Size = new System.Drawing.Size(238, 25);
            this.commandsListPanelU.TabIndex = 0;
            // 
            // commandListPanelD
            // 
            this.commandListPanelD.Controls.Add(this.tvCommands);
            this.commandListPanelD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandListPanelD.Location = new System.Drawing.Point(0, 25);
            this.commandListPanelD.Margin = new System.Windows.Forms.Padding(0);
            this.commandListPanelD.Name = "commandListPanelD";
            this.commandListPanelD.Size = new System.Drawing.Size(238, 339);
            this.commandListPanelD.TabIndex = 1;
            // 
            // tvCommands
            // 
            this.tvCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.tvCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCommands.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvCommands.ForeColor = System.Drawing.Color.White;
            this.tvCommands.Location = new System.Drawing.Point(0, 0);
            this.tvCommands.Name = "tvCommands";
            this.tvCommands.ShowLines = false;
            this.tvCommands.Size = new System.Drawing.Size(238, 339);
            this.tvCommands.TabIndex = 19;
            this.tvCommands.DoubleClick += new System.EventHandler(this.tvCommands_DoubleClick);
            this.tvCommands.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvCommands_KeyPress);
            // 
            // txtCommandFilter
            // 
            this.txtCommandFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCommandFilter.Location = new System.Drawing.Point(0, 0);
            this.txtCommandFilter.Name = "txtCommandFilter";
            this.txtCommandFilter.Size = new System.Drawing.Size(182, 23);
            this.txtCommandFilter.TabIndex = 19;
            // 
            // picCommandSearch
            // 
            this.picCommandSearch.Image = global::taskt.Properties.Resources.command_search;
            this.picCommandSearch.Location = new System.Drawing.Point(184, -1);
            this.picCommandSearch.Name = "picCommandSearch";
            this.picCommandSearch.Size = new System.Drawing.Size(24, 24);
            this.picCommandSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCommandSearch.TabIndex = 20;
            this.picCommandSearch.TabStop = false;
            this.picCommandSearch.Click += new System.EventHandler(this.picCommandSearch_Click);
            // 
            // picCommandClear
            // 
            this.picCommandClear.Image = global::taskt.Properties.Resources.command_error;
            this.picCommandClear.Location = new System.Drawing.Point(214, 2);
            this.picCommandClear.Name = "picCommandClear";
            this.picCommandClear.Size = new System.Drawing.Size(20, 20);
            this.picCommandClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCommandClear.TabIndex = 21;
            this.picCommandClear.TabStop = false;
            // 
            // frmScriptBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(979, 558);
            this.Controls.Add(this.tlpControls);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmScriptBuilder";
            this.Text = "taskt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScriptBuilder_FormClosing);
            this.Load += new System.EventHandler(this.frmScriptBuilder_Load);
            this.Shown += new System.EventHandler(this.frmScriptBuilder_Shown);
            this.SizeChanged += new System.EventHandler(this.frmScriptBuilder_SizeChanged);
            this.Resize += new System.EventHandler(this.frmScriptBuilder_Resize);
            this.tlpControls.ResumeLayout(false);
            this.tlpControls.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlCommandHelper.ResumeLayout(false);
            this.pnlCommandHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlControlContainer.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.grpSaveClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSequenceImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnKeep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnClose)).EndInit();
            this.grpFileActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnSaveAs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnOpen)).EndInit();
            this.grpRecordRun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnRecordSequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnRunScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnScheduleManagement)).EndInit();
            this.grpVariable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnClearAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBtnAddVariable)).EndInit();
            this.lstContextStrip.ResumeLayout(false);
            this.commandListTablePanel.ResumeLayout(false);
            this.commandsListPanelU.ResumeLayout(false);
            this.commandsListPanelU.PerformLayout();
            this.commandListPanelD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCommandSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCommandClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblMainLogo;
        private System.Windows.Forms.Timer tmrNotify;
        private System.Windows.Forms.ContextMenuStrip lstContextStrip;
        private System.Windows.Forms.ToolStripMenuItem enableSelectedCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableSelectedCodeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControlContainer;
        private taskt.UI.CustomControls.UIPictureButton uiBtnRunScript;
        private taskt.UI.CustomControls.UIPictureButton uiBtnAddVariable;
        private taskt.UI.CustomControls.UIPictureButton uiBtnSave;
        private taskt.UI.CustomControls.UIPictureButton uiBtnOpen;
        private taskt.UI.CustomControls.UIPictureButton uiBtnNew;
        private taskt.UI.CustomControls.UIPictureButton uiBtnScheduleManagement;
        private System.Windows.Forms.ToolStripMenuItem pauseBeforeExecutionToolStripMenuItem;
        private System.Windows.Forms.Label lblCoordinatorInfo;
        private CustomControls.UIPictureButton uiBtnSettings;
        private UI.CustomControls.UISplitContainer splitContainer1;
        private CustomControls.UIGroupBox grpFileActions;
        private CustomControls.UIGroupBox grpVariable;
        private CustomControls.UIGroupBox grpRecordRun;
        private System.Windows.Forms.Panel pnlCommandHelper;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSelectedToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkGitProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkGitIssue;
        private System.Windows.Forms.LinkLabel lnkGitLatestReleases;
        private System.Windows.Forms.LinkLabel lnkGitWiki;
        private System.Windows.Forms.Label lblRecentFiles;
        private CustomControls.UIFlowLayoutPanel flwRecentFiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblFilesMissing;
        private CustomControls.UIPictureButton uiBtnRecordSequence;
        private CustomControls.UIPictureButton uiBtnClearAll;
        private CustomControls.UIGroupBox grpSaveClose;
        private CustomControls.UIPictureButton uiBtnKeep;
        private CustomControls.UIPictureButton uiBtnClose;
        private CustomControls.UIGroupBox grpSearch;
        private System.Windows.Forms.TextBox txtCommandSearch;
        private System.Windows.Forms.Label lblCurrentlyViewing;
        private System.Windows.Forms.Label lblTotalResults;
        private System.Windows.Forms.PictureBox pbSearch;
        private CustomControls.UIPictureButton uiBtnSaveAs;
        private UI.CustomControls.UIPanel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem cutSelectedActionssToolStripMenuItem;
        private CustomControls.UIPictureButton uiBtnImport;
        private System.Windows.Forms.ToolStripMenuItem moveToParentToolStripMenuItem;
        private CustomControls.UIPictureButton btnSequenceImport;
        private System.Windows.Forms.NotifyIcon notifyTray;
        private taskt.UI.CustomControls.UIMenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSearchBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsSearchBox;
        private System.Windows.Forms.ToolStripMenuItem tsSearchButton;
        private System.Windows.Forms.ToolStripMenuItem tsSearchResult;
        private System.Windows.Forms.ToolStripMenuItem viewCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileActionsSep3;
        private System.Windows.Forms.ToolStripSeparator fileActionsSep1;
        private System.Windows.Forms.ToolStripSeparator fileActionsSep2;
        private System.Windows.Forms.ToolStripSeparator lstContextStripSep1;
        private System.Windows.Forms.ToolStripSeparator lstContextStripSep2;
        private System.Windows.Forms.ToolStripSeparator lstContextStripSep3;
        private System.Windows.Forms.ToolStripMenuItem editThisCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkStartEdit;
        private System.Windows.Forms.ToolStripSeparator lstContextStripSep4;
        private System.Windows.Forms.ToolStripMenuItem showScriptInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutScriptStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator editSplitMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SelectAllStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasktProjectPageStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasktWikiStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator helpToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator helpToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearSearchHighlightsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchThisCommnadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHighlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpThisCommandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator lstContextStripSep5;
        private System.Windows.Forms.ToolStripMenuItem variableManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private CustomControls.UIListView lstScriptActions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader commandColumn;
        private System.Windows.Forms.TableLayoutPanel commandListTablePanel;
        private System.Windows.Forms.Panel commandsListPanelU;
        private System.Windows.Forms.Panel commandListPanelD;
        private CustomControls.UITreeView tvCommands;
        private System.Windows.Forms.PictureBox picCommandClear;
        private System.Windows.Forms.PictureBox picCommandSearch;
        private System.Windows.Forms.TextBox txtCommandFilter;
    }
}

