namespace InkSpill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelChance = new System.Windows.Forms.Panel();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_game = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_start = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_level = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_level0 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_level4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_about = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_author = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Location = new System.Drawing.Point(148, 39);
            this.panelGame.Margin = new System.Windows.Forms.Padding(5);
            this.panelGame.MaximumSize = new System.Drawing.Size(400, 400);
            this.panelGame.MinimumSize = new System.Drawing.Size(400, 400);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(400, 400);
            this.panelGame.TabIndex = 0;
            this.panelGame.Visible = false;
            // 
            // panelChance
            // 
            this.panelChance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelChance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelChance.BackColor = System.Drawing.Color.White;
            this.panelChance.Location = new System.Drawing.Point(14, 39);
            this.panelChance.Margin = new System.Windows.Forms.Padding(5);
            this.panelChance.MaximumSize = new System.Drawing.Size(40, 400);
            this.panelChance.MinimumSize = new System.Drawing.Size(40, 400);
            this.panelChance.Name = "panelChance";
            this.panelChance.Size = new System.Drawing.Size(40, 400);
            this.panelChance.TabIndex = 1;
            this.panelChance.Visible = false;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(62, 40);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 75);
            this.btnRed.TabIndex = 2;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Visible = false;
            this.btnRed.Click += new System.EventHandler(this.BtnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(62, 121);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 75);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Visible = false;
            this.btnGreen.Click += new System.EventHandler(this.BtnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(62, 283);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 75);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Visible = false;
            this.btnYellow.Click += new System.EventHandler(this.BtnYellow_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(62, 202);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 75);
            this.btnBlue.TabIndex = 5;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Visible = false;
            this.btnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(62, 365);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(75, 75);
            this.btnPurple.TabIndex = 6;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Visible = false;
            this.btnPurple.Click += new System.EventHandler(this.BtnPurple_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_game,
            this.TSMI_level,
            this.TSMI_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_game
            // 
            this.TSMI_game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_start,
            this.TSMI_restart,
            this.TSMI_top,
            this.TSMI_exit});
            this.TSMI_game.Name = "TSMI_game";
            this.TSMI_game.Size = new System.Drawing.Size(53, 24);
            this.TSMI_game.Text = "游戏";
            // 
            // TSMI_start
            // 
            this.TSMI_start.Name = "TSMI_start";
            this.TSMI_start.Size = new System.Drawing.Size(224, 26);
            this.TSMI_start.Text = "开始";
            this.TSMI_start.Click += new System.EventHandler(this.TSMI_start_Click);
            // 
            // TSMI_restart
            // 
            this.TSMI_restart.Enabled = false;
            this.TSMI_restart.Name = "TSMI_restart";
            this.TSMI_restart.Size = new System.Drawing.Size(224, 26);
            this.TSMI_restart.Text = "重新开始";
            this.TSMI_restart.Click += new System.EventHandler(this.TSMI_restart_Click);
            // 
            // TSMI_top
            // 
            this.TSMI_top.Name = "TSMI_top";
            this.TSMI_top.Size = new System.Drawing.Size(224, 26);
            this.TSMI_top.Text = "排行榜";
            this.TSMI_top.Click += new System.EventHandler(this.TSMI_top_Click);
            // 
            // TSMI_exit
            // 
            this.TSMI_exit.Name = "TSMI_exit";
            this.TSMI_exit.Size = new System.Drawing.Size(224, 26);
            this.TSMI_exit.Text = "退出";
            this.TSMI_exit.Click += new System.EventHandler(this.TSMI_exit_Click);
            // 
            // TSMI_level
            // 
            this.TSMI_level.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_level0,
            this.TSMI_level1,
            this.TSMI_level2,
            this.TSMI_level3,
            this.TSMI_level4});
            this.TSMI_level.Name = "TSMI_level";
            this.TSMI_level.Size = new System.Drawing.Size(53, 24);
            this.TSMI_level.Text = "难度";
            // 
            // TSMI_level0
            // 
            this.TSMI_level0.Name = "TSMI_level0";
            this.TSMI_level0.Size = new System.Drawing.Size(224, 26);
            this.TSMI_level0.Text = "脑残";
            this.TSMI_level0.Click += new System.EventHandler(this.TSMI_level0_Click);
            // 
            // TSMI_level1
            // 
            this.TSMI_level1.Name = "TSMI_level1";
            this.TSMI_level1.Size = new System.Drawing.Size(224, 26);
            this.TSMI_level1.Text = "简单";
            this.TSMI_level1.Click += new System.EventHandler(this.TSMI_level1_Click);
            // 
            // TSMI_level2
            // 
            this.TSMI_level2.Name = "TSMI_level2";
            this.TSMI_level2.Size = new System.Drawing.Size(224, 26);
            this.TSMI_level2.Text = "中等";
            this.TSMI_level2.Click += new System.EventHandler(this.TSMI_level2_Click);
            // 
            // TSMI_level3
            // 
            this.TSMI_level3.Name = "TSMI_level3";
            this.TSMI_level3.Size = new System.Drawing.Size(224, 26);
            this.TSMI_level3.Text = "高级";
            this.TSMI_level3.Click += new System.EventHandler(this.TSMI_level3_Click);
            // 
            // TSMI_level4
            // 
            this.TSMI_level4.Name = "TSMI_level4";
            this.TSMI_level4.Size = new System.Drawing.Size(224, 26);
            this.TSMI_level4.Text = "困难";
            this.TSMI_level4.Click += new System.EventHandler(this.TSMI_level4_Click);
            // 
            // TSMI_about
            // 
            this.TSMI_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_author});
            this.TSMI_about.Name = "TSMI_about";
            this.TSMI_about.Size = new System.Drawing.Size(53, 24);
            this.TSMI_about.Text = "关于";
            // 
            // TSMI_author
            // 
            this.TSMI_author.Name = "TSMI_author";
            this.TSMI_author.Size = new System.Drawing.Size(122, 26);
            this.TSMI_author.Text = "作者";
            this.TSMI_author.Click += new System.EventHandler(this.TSMI_author_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 453);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.panelChance);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(580, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InkSpill";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelChance;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_game;
        private System.Windows.Forms.ToolStripMenuItem TSMI_start;
        private System.Windows.Forms.ToolStripMenuItem TSMI_restart;
        private System.Windows.Forms.ToolStripMenuItem TSMI_top;
        private System.Windows.Forms.ToolStripMenuItem TSMI_exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_level;
        private System.Windows.Forms.ToolStripMenuItem TSMI_level1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_level2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_level4;
        private System.Windows.Forms.ToolStripMenuItem TSMI_level0;
        private System.Windows.Forms.ToolStripMenuItem TSMI_level3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_about;
        private System.Windows.Forms.ToolStripMenuItem TSMI_author;
    }
}

