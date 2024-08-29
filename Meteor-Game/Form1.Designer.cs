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
            this.pBG = new System.Windows.Forms.PictureBox();
            this.pMeteor = new System.Windows.Forms.PictureBox();
            this.pBase = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).BeginInit();
            this.SuspendLayout();
            // 
            // pBG
            // 
            this.pBG.Image = global::Meteor_Game.Properties.Resources.背景_宇宙_;
            this.pBG.Location = new System.Drawing.Point(12, 12);
            this.pBG.Name = "pBG";
            this.pBG.Size = new System.Drawing.Size(170, 124);
            this.pBG.TabIndex = 1;
            this.pBG.TabStop = false;
            // 
            // pMeteor
            // 
            this.pMeteor.Image = global::Meteor_Game.Properties.Resources.隕石;
            this.pMeteor.Location = new System.Drawing.Point(58, 34);
            this.pMeteor.Name = "pMeteor";
            this.pMeteor.Size = new System.Drawing.Size(84, 76);
            this.pMeteor.TabIndex = 0;
            this.pMeteor.TabStop = false;
            // 
            // pBase
            // 
            this.pBase.Location = new System.Drawing.Point(231, 12);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(219, 249);
            this.pBase.TabIndex = 2;
            this.pBase.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 273);
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.pMeteor);
            this.Controls.Add(this.pBG);
            this.Name = "Form1";
            this.Text = "メテオゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pMeteor;
        private System.Windows.Forms.PictureBox pBG;
        private System.Windows.Forms.PictureBox pBase;
    }
}

