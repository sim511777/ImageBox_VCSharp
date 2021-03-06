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
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWideImage = new System.Windows.Forms.Button();
            this.bntLongImage = new System.Windows.Forms.Button();
            this.btnGradient = new System.Windows.Forms.Button();
            this.btnChess = new System.Windows.Forms.Button();
            this.btnCoinsDouble = new System.Windows.Forms.Button();
            this.btnCoinsFloat = new System.Windows.Forms.Button();
            this.btnCoins = new System.Windows.Forms.Button();
            this.btnLenna4 = new System.Windows.Forms.Button();
            this.btnLenna = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnZoomToImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnZoomReset = new System.Windows.Forms.Button();
            this.btnImmediateDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxDraw = new ShimLib.ImageBox();
            this.rlbxTestMode = new ShimLib.RadioListBox();
            this.rlbxTestItem = new ShimLib.RadioListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "Bmp File(*.bmp)|*.bmp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWideImage);
            this.groupBox1.Controls.Add(this.bntLongImage);
            this.groupBox1.Controls.Add(this.btnGradient);
            this.groupBox1.Controls.Add(this.btnChess);
            this.groupBox1.Controls.Add(this.btnCoinsDouble);
            this.groupBox1.Controls.Add(this.btnCoinsFloat);
            this.groupBox1.Controls.Add(this.btnCoins);
            this.groupBox1.Controls.Add(this.btnLenna4);
            this.groupBox1.Controls.Add(this.btnLenna);
            this.groupBox1.Controls.Add(this.btnPaste);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // btnWideImage
            // 
            this.btnWideImage.Location = new System.Drawing.Point(6, 310);
            this.btnWideImage.Name = "btnWideImage";
            this.btnWideImage.Size = new System.Drawing.Size(106, 23);
            this.btnWideImage.TabIndex = 12;
            this.btnWideImage.Text = "Wide Image";
            this.btnWideImage.UseVisualStyleBackColor = true;
            this.btnWideImage.Click += new System.EventHandler(this.btnWideImage_Click);
            // 
            // bntLongImage
            // 
            this.bntLongImage.Location = new System.Drawing.Point(6, 281);
            this.bntLongImage.Name = "bntLongImage";
            this.bntLongImage.Size = new System.Drawing.Size(106, 23);
            this.bntLongImage.TabIndex = 11;
            this.bntLongImage.Text = "Long Image";
            this.bntLongImage.UseVisualStyleBackColor = true;
            this.bntLongImage.Click += new System.EventHandler(this.bntLongImage_Click);
            // 
            // btnGradient
            // 
            this.btnGradient.Location = new System.Drawing.Point(6, 252);
            this.btnGradient.Name = "btnGradient";
            this.btnGradient.Size = new System.Drawing.Size(106, 23);
            this.btnGradient.TabIndex = 10;
            this.btnGradient.Text = "Gradient";
            this.btnGradient.UseVisualStyleBackColor = true;
            this.btnGradient.Click += new System.EventHandler(this.btnGradient_Click);
            // 
            // btnChess
            // 
            this.btnChess.Location = new System.Drawing.Point(6, 223);
            this.btnChess.Name = "btnChess";
            this.btnChess.Size = new System.Drawing.Size(106, 23);
            this.btnChess.TabIndex = 9;
            this.btnChess.Text = "Chess";
            this.btnChess.UseVisualStyleBackColor = true;
            this.btnChess.Click += new System.EventHandler(this.btnChess_Click);
            // 
            // btnCoinsDouble
            // 
            this.btnCoinsDouble.Location = new System.Drawing.Point(6, 194);
            this.btnCoinsDouble.Name = "btnCoinsDouble";
            this.btnCoinsDouble.Size = new System.Drawing.Size(106, 23);
            this.btnCoinsDouble.TabIndex = 8;
            this.btnCoinsDouble.Text = "Coins Double";
            this.btnCoinsDouble.UseVisualStyleBackColor = true;
            this.btnCoinsDouble.Click += new System.EventHandler(this.btnCoinsDouble_Click);
            // 
            // btnCoinsFloat
            // 
            this.btnCoinsFloat.Location = new System.Drawing.Point(6, 165);
            this.btnCoinsFloat.Name = "btnCoinsFloat";
            this.btnCoinsFloat.Size = new System.Drawing.Size(106, 23);
            this.btnCoinsFloat.TabIndex = 7;
            this.btnCoinsFloat.Text = "Coins Float";
            this.btnCoinsFloat.UseVisualStyleBackColor = true;
            this.btnCoinsFloat.Click += new System.EventHandler(this.btnCoinsFloat_Click);
            // 
            // btnCoins
            // 
            this.btnCoins.Location = new System.Drawing.Point(6, 136);
            this.btnCoins.Name = "btnCoins";
            this.btnCoins.Size = new System.Drawing.Size(106, 23);
            this.btnCoins.TabIndex = 6;
            this.btnCoins.Text = "Coins";
            this.btnCoins.UseVisualStyleBackColor = true;
            this.btnCoins.Click += new System.EventHandler(this.btnCoins_Click);
            // 
            // btnLenna4
            // 
            this.btnLenna4.Location = new System.Drawing.Point(6, 107);
            this.btnLenna4.Name = "btnLenna4";
            this.btnLenna4.Size = new System.Drawing.Size(106, 23);
            this.btnLenna4.TabIndex = 5;
            this.btnLenna4.Text = "Lenna4";
            this.btnLenna4.UseVisualStyleBackColor = true;
            this.btnLenna4.Click += new System.EventHandler(this.btnLenna4_Click);
            // 
            // btnLenna
            // 
            this.btnLenna.Location = new System.Drawing.Point(6, 78);
            this.btnLenna.Name = "btnLenna";
            this.btnLenna.Size = new System.Drawing.Size(106, 23);
            this.btnLenna.TabIndex = 4;
            this.btnLenna.Text = "Lenna";
            this.btnLenna.UseVisualStyleBackColor = true;
            this.btnLenna.Click += new System.EventHandler(this.btnLenna_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(6, 49);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(106, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Clipboard Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(6, 20);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(106, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnZoomToImage
            // 
            this.btnZoomToImage.Location = new System.Drawing.Point(6, 49);
            this.btnZoomToImage.Name = "btnZoomToImage";
            this.btnZoomToImage.Size = new System.Drawing.Size(106, 23);
            this.btnZoomToImage.TabIndex = 1;
            this.btnZoomToImage.Text = "Zoom to Image";
            this.btnZoomToImage.UseVisualStyleBackColor = true;
            this.btnZoomToImage.Click += new System.EventHandler(this.btnZoomToImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnZoomToImage);
            this.groupBox2.Controls.Add(this.btnZoomReset);
            this.groupBox2.Location = new System.Drawing.Point(130, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // btnZoomReset
            // 
            this.btnZoomReset.Location = new System.Drawing.Point(6, 20);
            this.btnZoomReset.Name = "btnZoomReset";
            this.btnZoomReset.Size = new System.Drawing.Size(106, 23);
            this.btnZoomReset.TabIndex = 0;
            this.btnZoomReset.Text = "Zoom Reset";
            this.btnZoomReset.UseVisualStyleBackColor = true;
            this.btnZoomReset.Click += new System.EventHandler(this.btnZoomReset_Click);
            // 
            // btnImmediateDraw
            // 
            this.btnImmediateDraw.Location = new System.Drawing.Point(6, 20);
            this.btnImmediateDraw.Name = "btnImmediateDraw";
            this.btnImmediateDraw.Size = new System.Drawing.Size(106, 23);
            this.btnImmediateDraw.TabIndex = 0;
            this.btnImmediateDraw.Text = "Immediate Draw";
            this.btnImmediateDraw.UseVisualStyleBackColor = true;
            this.btnImmediateDraw.Click += new System.EventHandler(this.btnImmediateDraw_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxLog);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(742, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 578);
            this.panel1.TabIndex = 5;
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(6, 366);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.Size = new System.Drawing.Size(242, 222);
            this.tbxLog.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rlbxTestMode);
            this.groupBox3.Controls.Add(this.rlbxTestItem);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnImmediateDraw);
            this.groupBox3.Location = new System.Drawing.Point(130, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Mode";
            // 
            // pbxDraw
            // 
            this.pbxDraw.AllowDrop = true;
            this.pbxDraw.BackColor = System.Drawing.Color.Gray;
            this.pbxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDraw.DrawPixelValueMode = ShimLib.PixelValueRenderer.Raster_05x08;
            this.pbxDraw.Location = new System.Drawing.Point(0, 0);
            this.pbxDraw.Name = "pbxDraw";
            this.pbxDraw.PanX = 0;
            this.pbxDraw.PanY = 0;
            this.pbxDraw.PixelValueDispFont = new System.Drawing.Font("Arial", 6F);
            this.pbxDraw.PixelValueDispZoomFactorFloat = 48;
            this.pbxDraw.PixelValueDispZoomFactorGray16 = 32;
            this.pbxDraw.PixelValueDispZoomFactorGray8 = 16;
            this.pbxDraw.PixelValueDispZoomFactorRgb = 32;
            this.pbxDraw.Size = new System.Drawing.Size(742, 578);
            this.pbxDraw.TabIndex = 6;
            this.pbxDraw.Text = "imageBox1";
            this.pbxDraw.UseDrawCenterLine = true;
            this.pbxDraw.UseDrawDrawTime = true;
            this.pbxDraw.UseDrawInfo = true;
            this.pbxDraw.UseDrawPixelValue = true;
            this.pbxDraw.UseMouseMove = true;
            this.pbxDraw.UseMousePanClamp = true;
            this.pbxDraw.UseMouseWheelZoom = true;
            this.pbxDraw.ZoomLevel = 8;
            this.pbxDraw.ZoomLevelMax = 16;
            this.pbxDraw.ZoomLevelMin = -16;
            this.pbxDraw.PaintBackBuffer += new ShimLib.PaintBackbufferEventHandler(this.pbxDraw_PaintBackBuffer);
            this.pbxDraw.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbxDraw_DragDrop);
            this.pbxDraw.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbxDraw_DragEnter);
            this.pbxDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxDraw_Paint);
            // 
            // rlbxTestMode
            // 
            this.rlbxTestMode.BackColor = System.Drawing.SystemColors.Window;
            this.rlbxTestMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rlbxTestMode.FormattingEnabled = true;
            this.rlbxTestMode.ItemHeight = 14;
            this.rlbxTestMode.Items.AddRange(new object[] {
            "None",
            "OnPaint",
            "OnPaintBack"});
            this.rlbxTestMode.Location = new System.Drawing.Point(6, 69);
            this.rlbxTestMode.Name = "rlbxTestMode";
            this.rlbxTestMode.Size = new System.Drawing.Size(106, 46);
            this.rlbxTestMode.TabIndex = 7;
            this.rlbxTestMode.SelectedIndexChanged += new System.EventHandler(this.rlbxTestMode_SelectedIndexChanged);
            // 
            // rlbxTestItem
            // 
            this.rlbxTestItem.BackColor = System.Drawing.SystemColors.Window;
            this.rlbxTestItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rlbxTestItem.FormattingEnabled = true;
            this.rlbxTestItem.ItemHeight = 14;
            this.rlbxTestItem.Items.AddRange(new object[] {
            "Draw Circle",
            "Fill Circle",
            "Draw Rectangle",
            "Fill Rectangle",
            "Draw String",
            "Draw 2 Lines",
            "Polygon Test"});
            this.rlbxTestItem.Location = new System.Drawing.Point(6, 150);
            this.rlbxTestItem.Name = "rlbxTestItem";
            this.rlbxTestItem.Size = new System.Drawing.Size(106, 102);
            this.rlbxTestItem.TabIndex = 6;
            this.rlbxTestItem.SelectedIndexChanged += new System.EventHandler(this.rlbxTestItem_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 578);
            this.Controls.Add(this.pbxDraw);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "ImageBox Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWideImage;
        private System.Windows.Forms.Button bntLongImage;
        private System.Windows.Forms.Button btnGradient;
        private System.Windows.Forms.Button btnChess;
        private System.Windows.Forms.Button btnCoinsDouble;
        private System.Windows.Forms.Button btnCoinsFloat;
        private System.Windows.Forms.Button btnCoins;
        private System.Windows.Forms.Button btnLenna4;
        private System.Windows.Forms.Button btnLenna;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnZoomToImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZoomReset;
        private System.Windows.Forms.Button btnImmediateDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ShimLib.ImageBox pbxDraw;
        private ShimLib.RadioListBox rlbxTestMode;
        private ShimLib.RadioListBox rlbxTestItem;
    }
}

