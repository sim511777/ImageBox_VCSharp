﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShimLib;

namespace ImageBoxTest {
    public partial class FormMain : Form {
        static string[] extList = { ".bmp", ".jpg", ".png", ".hra", ".tif" };
        private IntPtr imgBuf;
        private int bw;
        private int bh;
        private int bytepp;

        public FormMain() {
            InitializeComponent();
        }

        public void LoadCommandLine(string[] args) {
            var exts = string.Join(";", extList.Select(ext => "*" + ext));
            dlgOpenFile.Filter = $"Image Files({exts})|{exts}";
            if (args.Length > 0) {
                LoadImageFile(args[0]);
            }
        }

        private void LoadImageFile(string fileName) {
            var ext = Path.GetExtension(fileName).ToLower();
            if (ext == ".hra") {
                LoadHraFile(fileName);
            } else if (ext == ".bmp") {
                LoadBmpFile(fileName);
            } else {
                var bmp = new Bitmap(fileName);
                LoadBitmap(bmp);
                bmp.Dispose();
            }
        }

        private void LoadBmpFile(string fileName) {
            Util.FreeBuffer(ref imgBuf);
            ImageUtil.LoadBmpFile(fileName, ref imgBuf, ref bw, ref bh, ref bytepp);
            pbxDraw.SetImgBuf(imgBuf, bw, bh, bytepp, true);
        }

        private void LoadHraFile(string fileName) {
            Util.FreeBuffer(ref imgBuf);
            ImageUtil.LoadHraFile(fileName, ref imgBuf, ref bw, ref bh, ref bytepp);
            pbxDraw.SetImgBuf(imgBuf, bw, bh, bytepp, true);
        }

        private void PasteFromClipboard() {
            var img = Clipboard.GetImage();
            if (img == null)
                return;

            var bmp = new Bitmap(img);

            LoadBitmap(bmp);

            bmp.Dispose();
            img.Dispose();
        }

        private string GetDragDataImageFile(IDataObject data) {
            string[] files = (string[])data.GetData(DataFormats.FileDrop);
            if (files.Length != 1)
                return null;
            
            string file = files[0];
            FileAttributes attr = File.GetAttributes(file);
            if (attr.HasFlag(FileAttributes.Directory))
                return null;

            string ext = Path.GetExtension(file).ToLower();
            if (extList.Contains(ext) == false)
                return null;

            return file;
        }

        private void pbxDraw_DragEnter(object sender, DragEventArgs e) {
            string imageFile = GetDragDataImageFile(e.Data);
            if (imageFile == null) {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxDraw_DragDrop(object sender, DragEventArgs e) {
            string filePath = GetDragDataImageFile(e.Data);
            if (filePath == null)
                return;

            LoadImageFile(filePath);
        }

        private void LoadBitmap(Bitmap bmp) {
            Util.FreeBuffer(ref imgBuf);
            ImageUtil.BitmapToImageBuffer(bmp, ref imgBuf, ref bw, ref bh, ref bytepp);
            pbxDraw.SetImgBuf(imgBuf, bw, bh, bytepp, true);
        }

        private unsafe void LoadBitmapFloat(Bitmap bmp) {
            Util.FreeBuffer(ref imgBuf);
            ImageUtil.BitmapToImageBuffer(bmp, ref imgBuf, ref bw, ref bh, ref bytepp);

            // byte -> float convert
            IntPtr floatBuf = Util.AllocBuffer(bw * bh * sizeof(float));
            for (int y = 0; y < bh; y++) {
                byte* src = (byte*)imgBuf + bw * y;
                float* dst = (float*)floatBuf + bw * y;
                for (int x = 0; x < bw; x++, src++, dst++) {
                    *dst = *src;
                }
            }
            Util.FreeBuffer(ref imgBuf);
            imgBuf = floatBuf;
            bytepp = sizeof(float);

            // SetFloatBuf
            pbxDraw.SetImgBuf(imgBuf, bw, bh, bytepp, true, true);
        }

        private unsafe void LoadBitmapDouble(Bitmap bmp) {
            Util.FreeBuffer(ref imgBuf);
            ImageUtil.BitmapToImageBuffer(bmp, ref imgBuf, ref bw, ref bh, ref bytepp);

            // byte -> double convert
            IntPtr doubleBuf = Util.AllocBuffer(bw * bh * sizeof(double));
            for (int y = 0; y < bh; y++) {
                byte* src = (byte*)imgBuf + bw * y;
                double* dst = (double*)doubleBuf + bw * y;
                for (int x = 0; x < bw; x++, src++, dst++) {
                    *dst = *src;
                }
            }
            Util.FreeBuffer(ref imgBuf);
            imgBuf = doubleBuf;
            bytepp = sizeof(double);

            // SetFloatBuf
            pbxDraw.SetImgBuf(imgBuf, bw, bh, bytepp, true, true);
        }

        private unsafe void GenerateBitmap(int bw, int bh) {
            Util.FreeBuffer(ref imgBuf);
            long cb = (long)bw * bh;
            imgBuf = Util.AllocBuffer(cb);
            for (long y = 0; y < bh; y++) {
                byte* ptr = (byte*)imgBuf + y * bw;
                for (long x = 0; x < bw; x++) {
                    ptr[x] = (byte)((x + y) % 256);
                }
            }
            pbxDraw.SetImgBuf(imgBuf, bw, bh, 1, true);
        }
        
        private unsafe void GenerateGradient() {
            Util.FreeBuffer(ref imgBuf);
            bytepp = 1;
            bw = 511;
            bh = 511;
            long cb = (long)bw * bh;
            imgBuf = Util.AllocBuffer(cb);
            for (long y = 0; y < bh; y++) {
                byte* ptr = (byte*)imgBuf + y * bw;
                for (long x = 0; x < bw; x++) {
                    var dist = Math.Sqrt((x - 255) * (x - 255) + (y - 255) * (y - 255));
                    ptr[x] = (byte)(255 - Math.Min(Math.Max((int)Math.Round(dist, MidpointRounding.AwayFromZero), 0), 255));
                }
            }
            pbxDraw.SetImgBuf(imgBuf, bw, bh, bytepp, true);
        }

        private void pbxDraw_Paint(object sender, PaintEventArgs e) {
            if (rlbxTestMode.SelectedIndex == 1)
                UserDrawTest(e.Graphics);
        }

        private void UserDrawTest(Graphics g) {
            ImageGraphics ig = new ImageGraphics(pbxDraw, g);
            Pen pen = Pens.Red;
            Brush br = Brushes.Red;
            float size = 0.9f;
            int selIdx = rlbxTestItem.SelectedIndex;
            if (selIdx >= 0 && selIdx < 5) {
                for (int i = 0; i < 100; i++) {
                    for (int j = 0; j < 100; j++) {
                        float y = i;
                        float x = j;
                        if (selIdx == 0)
                            ig.DrawCircle(x, y, size, pen, false);
                        else if (selIdx == 1)
                            ig.DrawCircle(x, y, size, pen, false, true, br);
                        else if (selIdx == 2)
                            ig.DrawSquare(x, y, size, pen, false);
                        else if (selIdx == 3)
                            ig.DrawSquare(x, y, size, pen, false, true, br);
                        else if (selIdx == 4)
                            ig.DrawString($"{x},{y}", x, y, null, br, null);
                    }
                }
            }
            else if (selIdx == 5) {
                ig.DrawLine(0, 0, 64, 64, pen);
                ig.DrawLine(0, 64, 64, 0, pen);
            } else if (selIdx == 6) {
                Random rnd = new Random();
                for (int i = 0; i < 10000; i++) {
                    double[] thetas = {
                        i * Math.PI / 180,
                        (i + 120) * Math.PI / 180,
                        (i + 240) * Math.PI / 180,
                    };
                    float rad = 200;
                    PointF[] triangle = thetas.Select(theta => new PointF(rad * (float)Math.Cos(theta) + rad, rad * (float)Math.Sin(theta) + rad)).ToArray();
                    Pen pn = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
                    ig.DrawPolygon(triangle, pn);
                }
            }
        }

        private void pbxDraw_PaintBackBuffer(object sender, IntPtr buf, int bw, int bh) {
            if (rlbxTestMode.SelectedIndex == 2)
                UserDrawTest(buf, bw, bh);
        }

        private void UserDrawTest(IntPtr buf, int bw, int bh) {
            ImageDrawing id = new ImageDrawing(pbxDraw, buf, bw, bh);
            Color col = Color.Red;
            float size = 0.9f;
            float r = size * 0.5f;
            int selIdx = rlbxTestItem.SelectedIndex;
            if (selIdx >= 0 && selIdx < 5) {
                for (int i = 0; i < 100; i++) {
                    for (int j = 0; j < 100; j++) {
                        float y = i;
                        float x = j;
                        if (selIdx == 0)
                            id.DrawCircle(x, y, r, col, false);
                        else if (selIdx == 1)
                            id.DrawCircle(x, y, r, col, true);
                        else if (selIdx == 2)
                            id.DrawSquare(x, y, size, col, false);
                        else if (selIdx == 3)
                            id.DrawSquare(x, y, size, col, false, true);
                        else if (selIdx == 4)
                            id.DrawString($"{x},{y}", x, y, col);
                    }
                }
            }
            else if (selIdx == 5) {
                id.DrawLine(0, 0, 64, 64, col);
                id.DrawLine(0, 64, 64, 0, col);
            } else if (selIdx == 6) {
                Random rnd = new Random();
                for (int i = 0; i < 10000; i++) {
                    double[] thetas = {
                        i * Math.PI / 180,
                        (i + 120) * Math.PI / 180,
                        (i + 240) * Math.PI / 180,
                    };
                    float rad = 200;
                    PointF[] triangle = thetas.Select(theta => new PointF(rad * (float)Math.Cos(theta) + rad, rad * (float)Math.Sin(theta) + rad)).ToArray();
                    Color clr = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    id.DrawPolygon(triangle, clr);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            var ok = dlgOpenFile.ShowDialog(this);
            if (ok != DialogResult.OK)
                return;

            string filePath = dlgOpenFile.FileName;
            LoadImageFile(filePath);
        }

        private void btnPaste_Click(object sender, EventArgs e) {
            PasteFromClipboard();
        }

        private void btnLenna_Click(object sender, EventArgs e) {
            LoadBitmap(Properties.Resources.Lenna);
        }

        private void btnLenna4_Click(object sender, EventArgs e) {
            LoadBitmap(Properties.Resources.Lenna4);
        }

        private void btnCoins_Click(object sender, EventArgs e) {
            LoadBitmap(Properties.Resources.Coins);
        }

        private void btnCoinsFloat_Click(object sender, EventArgs e) {
            LoadBitmapFloat(Properties.Resources.Coins);
        }

        private void btnCoinsDouble_Click(object sender, EventArgs e) {
            LoadBitmapDouble(Properties.Resources.Coins);
        }

        private void btnChess_Click(object sender, EventArgs e) {
            LoadBitmap(Properties.Resources.Chess);
        }

        private void btnGradient_Click(object sender, EventArgs e) {
            GenerateGradient();
        }

        private void bntLongImage_Click(object sender, EventArgs e) {
            GenerateBitmap(256, 400000);
        }

        private void btnWideImage_Click(object sender, EventArgs e) {
            GenerateBitmap(400000, 256);
        }

        private void btnZoomReset_Click(object sender, EventArgs e) {
            pbxDraw.ZoomReset();
            pbxDraw.Redraw();
        }

        private void btnZoomToImage_Click(object sender, EventArgs e) {
            if (pbxDraw.ImgBW <= 0 || pbxDraw.ImgBH <= 0)
                pbxDraw.ZoomReset();
            else
                pbxDraw.ZoomToRect(0, 0, pbxDraw.ImgBW, pbxDraw.ImgBH);
            pbxDraw.Redraw();
        }

        private void btnImmediateDraw_Click(object sender, EventArgs e) {
            var st = DateTime.Now;
            using (Graphics g = pbxDraw.CreateGraphics()) {
                UserDrawTest(g);
            }
            var dt = DateTime.Now - st;
            tbxLog.Text = $"Immedate Draw Test : {dt.TotalMilliseconds:F0}ms";
        }

        private void rlbxTestItem_SelectedIndexChanged(object sender, EventArgs e) {
            pbxDraw.Redraw();
        }

        private void rlbxTestMode_SelectedIndexChanged(object sender, EventArgs e) {
            pbxDraw.Redraw();
        }
    }
}
