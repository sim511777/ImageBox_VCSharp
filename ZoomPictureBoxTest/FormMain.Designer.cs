﻿namespace ZoomPictureBoxTest {
    partial class FormMain {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenna4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mousePanningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wheelZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showPixelValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCursorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDrawCenterLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDrawTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userParallelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutZoomPictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.longImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wideImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pbxDraw = new ShimLib.ZoomPictureBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.pasteFromClipboardToolStripMenuItem,
            this.toolStripSeparator2,
            this.lennaToolStripMenuItem,
            this.lenna4ToolStripMenuItem,
            this.coinsToolStripMenuItem,
            this.chessToolStripMenuItem,
            this.toolStripSeparator3,
            this.longImageToolStripMenuItem,
            this.wideImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // pasteFromClipboardToolStripMenuItem
            // 
            this.pasteFromClipboardToolStripMenuItem.Name = "pasteFromClipboardToolStripMenuItem";
            this.pasteFromClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.pasteFromClipboardToolStripMenuItem.Text = "Paste from Clipboard";
            this.pasteFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.pasteFromClipboardToolStripMenuItem_Click);
            // 
            // lennaToolStripMenuItem
            // 
            this.lennaToolStripMenuItem.Name = "lennaToolStripMenuItem";
            this.lennaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.lennaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.lennaToolStripMenuItem.Text = "Lenna";
            this.lennaToolStripMenuItem.Click += new System.EventHandler(this.lennaToolStripMenuItem_Click);
            // 
            // lenna4ToolStripMenuItem
            // 
            this.lenna4ToolStripMenuItem.Name = "lenna4ToolStripMenuItem";
            this.lenna4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.lenna4ToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.lenna4ToolStripMenuItem.Text = "Lenna4";
            this.lenna4ToolStripMenuItem.Click += new System.EventHandler(this.lenna4ToolStripMenuItem_Click);
            // 
            // coinsToolStripMenuItem
            // 
            this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            this.coinsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.coinsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.coinsToolStripMenuItem.Text = "Coins";
            this.coinsToolStripMenuItem.Click += new System.EventHandler(this.coinsToolStripMenuItem_Click);
            // 
            // chessToolStripMenuItem
            // 
            this.chessToolStripMenuItem.Name = "chessToolStripMenuItem";
            this.chessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.chessToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.chessToolStripMenuItem.Text = "Chess";
            this.chessToolStripMenuItem.Click += new System.EventHandler(this.chessToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomResetToolStripMenuItem,
            this.zoomToImageToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomResetToolStripMenuItem
            // 
            this.zoomResetToolStripMenuItem.Name = "zoomResetToolStripMenuItem";
            this.zoomResetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.zoomResetToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zoomResetToolStripMenuItem.Text = "Zoom Reset";
            this.zoomResetToolStripMenuItem.Click += new System.EventHandler(this.zoomResetToolStripMenuItem_Click_1);
            // 
            // zoomToImageToolStripMenuItem
            // 
            this.zoomToImageToolStripMenuItem.Name = "zoomToImageToolStripMenuItem";
            this.zoomToImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.zoomToImageToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zoomToImageToolStripMenuItem.Text = "Zoom to Image";
            this.zoomToImageToolStripMenuItem.Click += new System.EventHandler(this.zoomToImageToolStripMenuItem_Click_1);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.CheckOnClick = true;
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mousePanningToolStripMenuItem,
            this.wheelZoomToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPixelValueToolStripMenuItem,
            this.showCursorInfoToolStripMenuItem,
            this.showDrawCenterLineToolStripMenuItem,
            this.showDrawTimeToolStripMenuItem,
            this.useInterpolationToolStripMenuItem,
            this.userParallelToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // mousePanningToolStripMenuItem
            // 
            this.mousePanningToolStripMenuItem.Checked = true;
            this.mousePanningToolStripMenuItem.CheckOnClick = true;
            this.mousePanningToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mousePanningToolStripMenuItem.Name = "mousePanningToolStripMenuItem";
            this.mousePanningToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.mousePanningToolStripMenuItem.Text = "Mouse Panning";
            this.mousePanningToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // wheelZoomToolStripMenuItem
            // 
            this.wheelZoomToolStripMenuItem.Checked = true;
            this.wheelZoomToolStripMenuItem.CheckOnClick = true;
            this.wheelZoomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wheelZoomToolStripMenuItem.Name = "wheelZoomToolStripMenuItem";
            this.wheelZoomToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.wheelZoomToolStripMenuItem.Text = "Wheel Zoom";
            this.wheelZoomToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // showPixelValueToolStripMenuItem
            // 
            this.showPixelValueToolStripMenuItem.Checked = true;
            this.showPixelValueToolStripMenuItem.CheckOnClick = true;
            this.showPixelValueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPixelValueToolStripMenuItem.Name = "showPixelValueToolStripMenuItem";
            this.showPixelValueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.showPixelValueToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.showPixelValueToolStripMenuItem.Text = "Show Pixel Value";
            this.showPixelValueToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // showCursorInfoToolStripMenuItem
            // 
            this.showCursorInfoToolStripMenuItem.Checked = true;
            this.showCursorInfoToolStripMenuItem.CheckOnClick = true;
            this.showCursorInfoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCursorInfoToolStripMenuItem.Name = "showCursorInfoToolStripMenuItem";
            this.showCursorInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.showCursorInfoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.showCursorInfoToolStripMenuItem.Text = "Show Cursor Info";
            this.showCursorInfoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // showDrawCenterLineToolStripMenuItem
            // 
            this.showDrawCenterLineToolStripMenuItem.Checked = true;
            this.showDrawCenterLineToolStripMenuItem.CheckOnClick = true;
            this.showDrawCenterLineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDrawCenterLineToolStripMenuItem.Name = "showDrawCenterLineToolStripMenuItem";
            this.showDrawCenterLineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.showDrawCenterLineToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.showDrawCenterLineToolStripMenuItem.Text = "Show Draw Center Line";
            this.showDrawCenterLineToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // showDrawTimeToolStripMenuItem
            // 
            this.showDrawTimeToolStripMenuItem.Checked = true;
            this.showDrawTimeToolStripMenuItem.CheckOnClick = true;
            this.showDrawTimeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDrawTimeToolStripMenuItem.Name = "showDrawTimeToolStripMenuItem";
            this.showDrawTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.showDrawTimeToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.showDrawTimeToolStripMenuItem.Text = "Show Draw Time";
            this.showDrawTimeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // useInterpolationToolStripMenuItem
            // 
            this.useInterpolationToolStripMenuItem.CheckOnClick = true;
            this.useInterpolationToolStripMenuItem.Name = "useInterpolationToolStripMenuItem";
            this.useInterpolationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.useInterpolationToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.useInterpolationToolStripMenuItem.Text = "Use Interpolation";
            this.useInterpolationToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // userParallelToolStripMenuItem
            // 
            this.userParallelToolStripMenuItem.CheckOnClick = true;
            this.userParallelToolStripMenuItem.Name = "userParallelToolStripMenuItem";
            this.userParallelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.userParallelToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.userParallelToolStripMenuItem.Text = "User Parallel";
            this.userParallelToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showPixelValueToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutZoomPictureBoxToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutZoomPictureBoxToolStripMenuItem
            // 
            this.aboutZoomPictureBoxToolStripMenuItem.Name = "aboutZoomPictureBoxToolStripMenuItem";
            this.aboutZoomPictureBoxToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutZoomPictureBoxToolStripMenuItem.Text = "About ZoomPictureBox";
            this.aboutZoomPictureBoxToolStripMenuItem.Click += new System.EventHandler(this.aboutZoomPictureBoxToolStripMenuItem_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // longImageToolStripMenuItem
            // 
            this.longImageToolStripMenuItem.Name = "longImageToolStripMenuItem";
            this.longImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.longImageToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.longImageToolStripMenuItem.Text = "Long Image";
            this.longImageToolStripMenuItem.Click += new System.EventHandler(this.longImageToolStripMenuItem_Click);
            // 
            // wideImageToolStripMenuItem
            // 
            this.wideImageToolStripMenuItem.Name = "wideImageToolStripMenuItem";
            this.wideImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.wideImageToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.wideImageToolStripMenuItem.Text = "Wide Image";
            this.wideImageToolStripMenuItem.Click += new System.EventHandler(this.wideImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // pbxDraw
            // 
            this.pbxDraw.AllowDrop = true;
            this.pbxDraw.BackColor = System.Drawing.Color.Gray;
            this.pbxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDraw.Location = new System.Drawing.Point(0, 24);
            this.pbxDraw.Name = "pbxDraw";
            this.pbxDraw.PanX = 0D;
            this.pbxDraw.PanY = 0D;
            this.pbxDraw.Size = new System.Drawing.Size(820, 511);
            this.pbxDraw.TabIndex = 1;
            this.pbxDraw.Text = "zoomPictureBox1";
            this.pbxDraw.UseDrawCenterLine = true;
            this.pbxDraw.UseDrawDrawTime = true;
            this.pbxDraw.UseDrawInfo = true;
            this.pbxDraw.UseDrawPixelValue = true;
            this.pbxDraw.UseInterPorlation = false;
            this.pbxDraw.UseMouseMove = true;
            this.pbxDraw.UseMouseWheelZoom = true;
            this.pbxDraw.UseParallel = false;
            this.pbxDraw.ZoomLevel = 0;
            this.pbxDraw.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxDraw_DragDrop);
            this.pbxDraw.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxDraw_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 535);
            this.Controls.Add(this.pbxDraw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "ZoomPictureBox Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShimLib.ZoomPictureBox pbxDraw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPixelValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCursorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDrawCenterLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDrawTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mousePanningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wheelZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutZoomPictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userParallelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem lennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenna4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem longImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wideImageToolStripMenuItem;
    }
}

