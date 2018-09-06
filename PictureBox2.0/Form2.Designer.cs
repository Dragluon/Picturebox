namespace PictureBox2._0
{
    partial class Form2
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
            this.picChange = new System.Windows.Forms.PictureBox();
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnCameo = new System.Windows.Forms.Button();
            this.btnBackcolor = new System.Windows.Forms.Button();
            this.btnColation = new System.Windows.Forms.Button();
            this.btnLeft_right = new System.Windows.Forms.Button();
            this.btnUp_down = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picChange
            // 
            this.picChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChange.Location = new System.Drawing.Point(571, 68);
            this.picChange.Name = "picChange";
            this.picChange.Size = new System.Drawing.Size(319, 431);
            this.picChange.TabIndex = 0;
            this.picChange.TabStop = false;
            // 
            // picOrigin
            // 
            this.picOrigin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOrigin.Location = new System.Drawing.Point(152, 68);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(319, 431);
            this.picOrigin.TabIndex = 2;
            this.picOrigin.TabStop = false;
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(31, 95);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(75, 23);
            this.btnAdjust.TabIndex = 3;
            this.btnAdjust.Text = "调整光暗";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 25);
            this.menuStrip1.TabIndex = 4;
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
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(31, 134);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(100, 21);
            this.txtVal.TabIndex = 5;
            // 
            // btnBlack
            // 
            this.btnBlack.Location = new System.Drawing.Point(31, 174);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(75, 23);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.Text = "黑白图片";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnCameo
            // 
            this.btnCameo.Location = new System.Drawing.Point(31, 217);
            this.btnCameo.Name = "btnCameo";
            this.btnCameo.Size = new System.Drawing.Size(75, 23);
            this.btnCameo.TabIndex = 7;
            this.btnCameo.Text = "浮雕";
            this.btnCameo.UseVisualStyleBackColor = true;
            this.btnCameo.Click += new System.EventHandler(this.btnCameo_Click);
            // 
            // btnBackcolor
            // 
            this.btnBackcolor.Location = new System.Drawing.Point(31, 246);
            this.btnBackcolor.Name = "btnBackcolor";
            this.btnBackcolor.Size = new System.Drawing.Size(75, 23);
            this.btnBackcolor.TabIndex = 10;
            this.btnBackcolor.Text = "反色";
            this.btnBackcolor.UseVisualStyleBackColor = true;
            this.btnBackcolor.Click += new System.EventHandler(this.btnBackcolor_Click);
            // 
            // btnColation
            // 
            this.btnColation.Location = new System.Drawing.Point(31, 388);
            this.btnColation.Name = "btnColation";
            this.btnColation.Size = new System.Drawing.Size(75, 23);
            this.btnColation.TabIndex = 11;
            this.btnColation.Text = "滤色";
            this.btnColation.UseVisualStyleBackColor = true;
            this.btnColation.Click += new System.EventHandler(this.btnColation_Click);
            // 
            // btnLeft_right
            // 
            this.btnLeft_right.Location = new System.Drawing.Point(31, 433);
            this.btnLeft_right.Name = "btnLeft_right";
            this.btnLeft_right.Size = new System.Drawing.Size(75, 23);
            this.btnLeft_right.TabIndex = 12;
            this.btnLeft_right.Text = "左右翻转";
            this.btnLeft_right.UseVisualStyleBackColor = true;
            this.btnLeft_right.Click += new System.EventHandler(this.btnLeft_right_Click);
            // 
            // btnUp_down
            // 
            this.btnUp_down.Location = new System.Drawing.Point(31, 476);
            this.btnUp_down.Name = "btnUp_down";
            this.btnUp_down.Size = new System.Drawing.Size(75, 23);
            this.btnUp_down.TabIndex = 13;
            this.btnUp_down.Text = "上下翻转";
            this.btnUp_down.UseVisualStyleBackColor = true;
            this.btnUp_down.Click += new System.EventHandler(this.btnUp_down_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(31, 295);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 14;
            this.btnGray.Text = "灰度化";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(947, 624);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnUp_down);
            this.Controls.Add(this.btnLeft_right);
            this.Controls.Add(this.btnColation);
            this.Controls.Add(this.btnBackcolor);
            this.Controls.Add(this.btnCameo);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.picOrigin);
            this.Controls.Add(this.picChange);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picChange;
        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnCameo;
        private System.Windows.Forms.Button btnBackcolor;
        private System.Windows.Forms.Button btnColation;
        private System.Windows.Forms.Button btnLeft_right;
        private System.Windows.Forms.Button btnUp_down;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.Button btnGray;
    }
}