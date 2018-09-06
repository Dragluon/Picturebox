namespace PictureBox2._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArrow = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.矩形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.椭圆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特殊处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰度化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.cmbThickness = new System.Windows.Forms.ComboBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArrow
            // 
            this.btnArrow.Location = new System.Drawing.Point(12, 42);
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(75, 23);
            this.btnArrow.TabIndex = 0;
            this.btnArrow.Text = "箭头";
            this.btnArrow.UseVisualStyleBackColor = true;
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(12, 88);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(75, 23);
            this.btnPen.TabIndex = 1;
            this.btnPen.Text = "画笔";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.图形ToolStripMenuItem,
            this.特殊处理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 图形ToolStripMenuItem
            // 
            this.图形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.线ToolStripMenuItem,
            this.矩形ToolStripMenuItem,
            this.椭圆ToolStripMenuItem});
            this.图形ToolStripMenuItem.Name = "图形ToolStripMenuItem";
            this.图形ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图形ToolStripMenuItem.Text = "图形选择";
            // 
            // 线ToolStripMenuItem
            // 
            this.线ToolStripMenuItem.Name = "线ToolStripMenuItem";
            this.线ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.线ToolStripMenuItem.Text = "线";
            this.线ToolStripMenuItem.Click += new System.EventHandler(this.线ToolStripMenuItem_Click);
            // 
            // 矩形ToolStripMenuItem
            // 
            this.矩形ToolStripMenuItem.Name = "矩形ToolStripMenuItem";
            this.矩形ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.矩形ToolStripMenuItem.Text = "矩形";
            this.矩形ToolStripMenuItem.Click += new System.EventHandler(this.矩形ToolStripMenuItem_Click);
            // 
            // 椭圆ToolStripMenuItem
            // 
            this.椭圆ToolStripMenuItem.Name = "椭圆ToolStripMenuItem";
            this.椭圆ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.椭圆ToolStripMenuItem.Text = "椭圆";
            this.椭圆ToolStripMenuItem.Click += new System.EventHandler(this.椭圆ToolStripMenuItem_Click);
            // 
            // 特殊处理ToolStripMenuItem
            // 
            this.特殊处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.灰度化ToolStripMenuItem});
            this.特殊处理ToolStripMenuItem.Name = "特殊处理ToolStripMenuItem";
            this.特殊处理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.特殊处理ToolStripMenuItem.Text = "特殊处理";
            // 
            // 灰度化ToolStripMenuItem
            // 
            this.灰度化ToolStripMenuItem.Name = "灰度化ToolStripMenuItem";
            this.灰度化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.灰度化ToolStripMenuItem.Text = "灰度化";
            this.灰度化ToolStripMenuItem.Click += new System.EventHandler(this.灰度化ToolStripMenuItem_Click);
            // 
            // picDraw
            // 
            this.picDraw.Location = new System.Drawing.Point(196, 82);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(519, 415);
            this.picDraw.TabIndex = 3;
            this.picDraw.TabStop = false;
            this.picDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(12, 134);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "线";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(12, 180);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(75, 23);
            this.btnRec.TabIndex = 5;
            this.btnRec.Text = "矩形";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(12, 226);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(75, 23);
            this.btnEllipse.TabIndex = 6;
            this.btnEllipse.Text = "椭圆";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(12, 272);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(75, 23);
            this.btnEraser.TabIndex = 7;
            this.btnEraser.Text = "橡皮擦";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 318);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "写字";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清屏";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 410);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 10;
            this.btnColor.Text = "颜色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // cmbThickness
            // 
            this.cmbThickness.FormattingEnabled = true;
            this.cmbThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbThickness.Location = new System.Drawing.Point(80, 449);
            this.cmbThickness.Name = "cmbThickness";
            this.cmbThickness.Size = new System.Drawing.Size(75, 20);
            this.cmbThickness.TabIndex = 11;
            this.cmbThickness.SelectedIndexChanged += new System.EventHandler(this.cmbThickness_SelectedIndexChanged);
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(300, 210);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWrite.Size = new System.Drawing.Size(100, 21);
            this.txtWrite.TabIndex = 12;
            this.txtWrite.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "画笔粗细";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 497);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "图像处理";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(759, 532);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.cmbThickness);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.picDraw);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnArrow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArrow;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 特殊处理ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cmbThickness;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.ToolStripMenuItem 线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 矩形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 椭圆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰度化ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
    }
}

