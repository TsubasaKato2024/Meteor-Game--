namespace Meteor_Game
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pMsg = new System.Windows.Forms.PictureBox();
            this.pGameover = new System.Windows.Forms.PictureBox();
            this.pTitle = new System.Windows.Forms.PictureBox();
            this.pExp = new System.Windows.Forms.PictureBox();
            this.pPlayer = new System.Windows.Forms.PictureBox();
            this.pBase = new System.Windows.Forms.PictureBox();
            this.pMeteor = new System.Windows.Forms.PictureBox();
            this.pBG = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pMsg
            // 
            this.pMsg.Image = global::Meteor_Game.Properties.Resources.メッセージ_メテオ_;
            this.pMsg.Location = new System.Drawing.Point(261, 172);
            this.pMsg.Name = "pMsg";
            this.pMsg.Size = new System.Drawing.Size(98, 49);
            this.pMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMsg.TabIndex = 7;
            this.pMsg.TabStop = false;
            // 
            // pGameover
            // 
            this.pGameover.Image = global::Meteor_Game.Properties.Resources.ゲームオーバー_メテオ_;
            this.pGameover.Location = new System.Drawing.Point(323, 35);
            this.pGameover.Name = "pGameover";
            this.pGameover.Size = new System.Drawing.Size(111, 75);
            this.pGameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pGameover.TabIndex = 6;
            this.pGameover.TabStop = false;
            // 
            // pTitle
            // 
            this.pTitle.Image = global::Meteor_Game.Properties.Resources.タイトル_メテオ_;
            this.pTitle.Location = new System.Drawing.Point(85, 154);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(140, 94);
            this.pTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pTitle.TabIndex = 5;
            this.pTitle.TabStop = false;
            // 
            // pExp
            // 
            this.pExp.Image = global::Meteor_Game.Properties.Resources.爆発;
            this.pExp.Location = new System.Drawing.Point(199, 34);
            this.pExp.Name = "pExp";
            this.pExp.Size = new System.Drawing.Size(104, 70);
            this.pExp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pExp.TabIndex = 4;
            this.pExp.TabStop = false;
            // 
            // pPlayer
            // 
            this.pPlayer.Image = global::Meteor_Game.Properties.Resources.自機;
            this.pPlayer.Location = new System.Drawing.Point(12, 180);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(51, 55);
            this.pPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPlayer.TabIndex = 3;
            this.pPlayer.TabStop = false;
            // 
            // pBase
            // 
            this.pBase.Location = new System.Drawing.Point(-3, 0);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(617, 437);
            this.pBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBase.TabIndex = 2;
            this.pBase.TabStop = false;
            this.pBase.Click += new System.EventHandler(this.pBase_Click);
            // 
            // pMeteor
            // 
            this.pMeteor.Image = global::Meteor_Game.Properties.Resources.隕石;
            this.pMeteor.Location = new System.Drawing.Point(58, 34);
            this.pMeteor.Name = "pMeteor";
            this.pMeteor.Size = new System.Drawing.Size(84, 76);
            this.pMeteor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pMeteor.TabIndex = 0;
            this.pMeteor.TabStop = false;
            // 
            // pBG
            // 
            this.pBG.Image = global::Meteor_Game.Properties.Resources.背景_宇宙_;
            this.pBG.Location = new System.Drawing.Point(12, 12);
            this.pBG.Name = "pBG";
            this.pBG.Size = new System.Drawing.Size(170, 124);
            this.pBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBG.TabIndex = 1;
            this.pBG.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 433);
            this.Controls.Add(this.pMsg);
            this.Controls.Add(this.pGameover);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pExp);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.pMeteor);
            this.Controls.Add(this.pBG);
            this.Name = "Form1";
            this.Text = "メテオゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pMeteor;
        private System.Windows.Forms.PictureBox pBG;
        private System.Windows.Forms.PictureBox pBase;
        private System.Windows.Forms.PictureBox pPlayer;
        private System.Windows.Forms.PictureBox pExp;
        private System.Windows.Forms.PictureBox pTitle;
        private System.Windows.Forms.PictureBox pGameover;
        private System.Windows.Forms.PictureBox pMsg;
        private System.Windows.Forms.Timer timer1;
    }
}

