﻿namespace ImageBoxTest {
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
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenna4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsFloatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinsDoubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.longImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wideImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.immediateDrawTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retainedimmediateDrawTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.drawEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawPixelCirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutImageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.pbxDraw = new ShimLib.ImageBox();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioListBox1 = new ShimLib.RadioListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.testToolStripMenuItem,
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
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToClipboardToolStripMenuItem,
            this.pasteFromClipboardToolStripMenuItem,
            this.toolStripSeparator2,
            this.lennaToolStripMenuItem,
            this.lenna4ToolStripMenuItem,
            this.coinsToolStripMenuItem,
            this.coinsFloatToolStripMenuItem,
            this.coinsDoubleToolStripMenuItem,
            this.chessToolStripMenuItem,
            this.gradientToolStripMenuItem,
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
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // pasteFromClipboardToolStripMenuItem
            // 
            this.pasteFromClipboardToolStripMenuItem.Name = "pasteFromClipboardToolStripMenuItem";
            this.pasteFromClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteFromClipboardToolStripMenuItem.Text = "Paste";
            this.pasteFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.pasteFromClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // lennaToolStripMenuItem
            // 
            this.lennaToolStripMenuItem.Name = "lennaToolStripMenuItem";
            this.lennaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.lennaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lennaToolStripMenuItem.Text = "Lenna";
            this.lennaToolStripMenuItem.Click += new System.EventHandler(this.lennaToolStripMenuItem_Click);
            // 
            // lenna4ToolStripMenuItem
            // 
            this.lenna4ToolStripMenuItem.Name = "lenna4ToolStripMenuItem";
            this.lenna4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.lenna4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lenna4ToolStripMenuItem.Text = "Lenna4";
            this.lenna4ToolStripMenuItem.Click += new System.EventHandler(this.lenna4ToolStripMenuItem_Click);
            // 
            // coinsToolStripMenuItem
            // 
            this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            this.coinsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.coinsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coinsToolStripMenuItem.Text = "Coins";
            this.coinsToolStripMenuItem.Click += new System.EventHandler(this.coinsToolStripMenuItem_Click);
            // 
            // coinsFloatToolStripMenuItem
            // 
            this.coinsFloatToolStripMenuItem.Name = "coinsFloatToolStripMenuItem";
            this.coinsFloatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coinsFloatToolStripMenuItem.Text = "Coins Float";
            this.coinsFloatToolStripMenuItem.Click += new System.EventHandler(this.coinsFloatToolStripMenuItem_Click);
            // 
            // coinsDoubleToolStripMenuItem
            // 
            this.coinsDoubleToolStripMenuItem.Name = "coinsDoubleToolStripMenuItem";
            this.coinsDoubleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coinsDoubleToolStripMenuItem.Text = "Coins Double";
            this.coinsDoubleToolStripMenuItem.Click += new System.EventHandler(this.coinsDoubleToolStripMenuItem_Click);
            // 
            // chessToolStripMenuItem
            // 
            this.chessToolStripMenuItem.Name = "chessToolStripMenuItem";
            this.chessToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.chessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chessToolStripMenuItem.Text = "Chess";
            this.chessToolStripMenuItem.Click += new System.EventHandler(this.chessToolStripMenuItem_Click);
            // 
            // gradientToolStripMenuItem
            // 
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            this.gradientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.gradientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradientToolStripMenuItem.Text = "Gradient";
            this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // longImageToolStripMenuItem
            // 
            this.longImageToolStripMenuItem.Name = "longImageToolStripMenuItem";
            this.longImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.longImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.longImageToolStripMenuItem.Text = "Long Image";
            this.longImageToolStripMenuItem.Click += new System.EventHandler(this.longImageToolStripMenuItem_Click);
            // 
            // wideImageToolStripMenuItem
            // 
            this.wideImageToolStripMenuItem.Name = "wideImageToolStripMenuItem";
            this.wideImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.wideImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wideImageToolStripMenuItem.Text = "Wide Image";
            this.wideImageToolStripMenuItem.Click += new System.EventHandler(this.wideImageToolStripMenuItem_Click);
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
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.immediateDrawTestToolStripMenuItem,
            this.retainedimmediateDrawTestToolStripMenuItem,
            this.toolStripSeparator4,
            this.drawEllipseToolStripMenuItem,
            this.fillEllipseToolStripMenuItem,
            this.drawStringToolStripMenuItem,
            this.drawShapesToolStripMenuItem,
            this.drawPixelCirclesToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // immediateDrawTestToolStripMenuItem
            // 
            this.immediateDrawTestToolStripMenuItem.Name = "immediateDrawTestToolStripMenuItem";
            this.immediateDrawTestToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.immediateDrawTestToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.immediateDrawTestToolStripMenuItem.Text = "Immediate Draw Test";
            this.immediateDrawTestToolStripMenuItem.Click += new System.EventHandler(this.immediateDrawTestToolStripMenuItem_Click);
            // 
            // retainedimmediateDrawTestToolStripMenuItem
            // 
            this.retainedimmediateDrawTestToolStripMenuItem.CheckOnClick = true;
            this.retainedimmediateDrawTestToolStripMenuItem.Name = "retainedimmediateDrawTestToolStripMenuItem";
            this.retainedimmediateDrawTestToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.retainedimmediateDrawTestToolStripMenuItem.Text = "Retained Draw Test";
            this.retainedimmediateDrawTestToolStripMenuItem.Click += new System.EventHandler(this.retainedimmediateDrawTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
            // 
            // drawEllipseToolStripMenuItem
            // 
            this.drawEllipseToolStripMenuItem.Checked = true;
            this.drawEllipseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawEllipseToolStripMenuItem.Name = "drawEllipseToolStripMenuItem";
            this.drawEllipseToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.drawEllipseToolStripMenuItem.Text = "DrawEllipse";
            this.drawEllipseToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseToolStripMenuItem_Click);
            // 
            // fillEllipseToolStripMenuItem
            // 
            this.fillEllipseToolStripMenuItem.Name = "fillEllipseToolStripMenuItem";
            this.fillEllipseToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.fillEllipseToolStripMenuItem.Text = "FillEllipse";
            this.fillEllipseToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseToolStripMenuItem_Click);
            // 
            // drawStringToolStripMenuItem
            // 
            this.drawStringToolStripMenuItem.Name = "drawStringToolStripMenuItem";
            this.drawStringToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.drawStringToolStripMenuItem.Text = "DrawString";
            this.drawStringToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseToolStripMenuItem_Click);
            // 
            // drawShapesToolStripMenuItem
            // 
            this.drawShapesToolStripMenuItem.Name = "drawShapesToolStripMenuItem";
            this.drawShapesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.drawShapesToolStripMenuItem.Text = "Draw Shapes";
            this.drawShapesToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseToolStripMenuItem_Click);
            // 
            // drawPixelCirclesToolStripMenuItem
            // 
            this.drawPixelCirclesToolStripMenuItem.Name = "drawPixelCirclesToolStripMenuItem";
            this.drawPixelCirclesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.drawPixelCirclesToolStripMenuItem.Text = "Draw Pixel Circles";
            this.drawPixelCirclesToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutImageBoxToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutImageBoxToolStripMenuItem
            // 
            this.aboutImageBoxToolStripMenuItem.Name = "aboutImageBoxToolStripMenuItem";
            this.aboutImageBoxToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutImageBoxToolStripMenuItem.Text = "About ImageBox";
            this.aboutImageBoxToolStripMenuItem.Click += new System.EventHandler(this.aboutImageBoxToolStripMenuItem_Click);
            // 
            // pbxDraw
            // 
            this.pbxDraw.AllowDrop = true;
            this.pbxDraw.BackColor = System.Drawing.Color.Gray;
            this.pbxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDraw.Location = new System.Drawing.Point(3, 3);
            this.pbxDraw.Name = "pbxDraw";
            this.pbxDraw.PanX = 0D;
            this.pbxDraw.PanY = 0D;
            this.pbxDraw.PixelValueDispFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pbxDraw.PixelValueDispZoomFactor = 20;
            this.pbxDraw.Size = new System.Drawing.Size(270, 297);
            this.pbxDraw.TabIndex = 1;
            this.pbxDraw.Text = "imageBox1";
            this.pbxDraw.UseDrawCenterLine = true;
            this.pbxDraw.UseDrawDrawTime = true;
            this.pbxDraw.UseDrawInfo = true;
            this.pbxDraw.UseDrawPixelValue = true;
            this.pbxDraw.UseInterPorlation = false;
            this.pbxDraw.UseMouseMove = true;
            this.pbxDraw.UseMousePanClamp = true;
            this.pbxDraw.UseMouseWheelZoom = true;
            this.pbxDraw.UseParallel = false;
            this.pbxDraw.ZoomLevel = 0;
            this.pbxDraw.ZoomLevelMax = 12;
            this.pbxDraw.ZoomLevelMin = -12;
            this.pbxDraw.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxDraw_DragDrop);
            this.pbxDraw.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxDraw_DragEnter);
            this.pbxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxDraw_Paint);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "Bmp File(*.bmp)|*.bmp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 511);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbxDraw);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ImageBox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioListBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RadioListBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioListBox1
            // 
            this.radioListBox1.BackColor = System.Drawing.SystemColors.Window;
            this.radioListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.radioListBox1.FormattingEnabled = true;
            this.radioListBox1.ItemHeight = 18;
            this.radioListBox1.Items.AddRange(new object[] {
            "Item0",
            "Item1",
            "Item2",
            "Item3",
            "Item4"});
            this.radioListBox1.Location = new System.Drawing.Point(8, 6);
            this.radioListBox1.Name = "radioListBox1";
            this.radioListBox1.Size = new System.Drawing.Size(120, 112);
            this.radioListBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "ImageBox Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShimLib.ImageBox pbxDraw;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutImageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenna4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem longImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wideImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem immediateDrawTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retainedimmediateDrawTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem drawEllipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillEllipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawPixelCirclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.ToolStripMenuItem coinsFloatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinsDoubleToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ShimLib.RadioListBox radioListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

