namespace VaporClient.Views
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "GunShooting"}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128))));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.GameList = new System.Windows.Forms.ListView();
            this.ExplanationText = new System.Windows.Forms.Label();
            this.CreatorText = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.VersionText = new System.Windows.Forms.Label();
            this.SettingButton = new System.Windows.Forms.Button();
            this.RerollButton = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.splitContainer.Panel1.Controls.Add(this.SettingButton);
            this.splitContainer.Panel1.Controls.Add(this.RerollButton);
            this.splitContainer.Panel1.Controls.Add(this.PowerButton);
            this.splitContainer.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer.Panel1.Controls.Add(this.GameList);
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel1_Paint);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.splitContainer.Panel2.Controls.Add(this.ExplanationText);
            this.splitContainer.Panel2.Controls.Add(this.CreatorText);
            this.splitContainer.Panel2.Controls.Add(this.TitleText);
            this.splitContainer.Panel2.Controls.Add(this.VersionText);
            this.splitContainer.Panel2.Controls.Add(this.PlayButton);
            this.splitContainer.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel2_Paint);
            this.splitContainer.Size = new System.Drawing.Size(1920, 1080);
            this.splitContainer.SplitterDistance = 687;
            this.splitContainer.TabIndex = 0;
            // 
            // GameList
            // 
            this.GameList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.GameList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.GameList.BackgroundImageTiled = true;
            this.GameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameList.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameList.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameList.ForeColor = System.Drawing.SystemColors.Window;
            this.GameList.HideSelection = false;
            this.GameList.HoverSelection = true;
            this.GameList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.GameList.LabelWrap = false;
            this.GameList.Location = new System.Drawing.Point(30, 15);
            this.GameList.Margin = new System.Windows.Forms.Padding(0);
            this.GameList.MaximumSize = new System.Drawing.Size(657, 940);
            this.GameList.MinimumSize = new System.Drawing.Size(80, 80);
            this.GameList.MultiSelect = false;
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(657, 940);
            this.GameList.TabIndex = 0;
            this.GameList.TileSize = new System.Drawing.Size(548, 178);
            this.GameList.UseCompatibleStateImageBehavior = false;
            this.GameList.View = System.Windows.Forms.View.List;
            this.GameList.SelectedIndexChanged += new System.EventHandler(this.GameList_SelectedIndexChanged);
            // 
            // ExplanationText
            // 
            this.ExplanationText.AutoSize = true;
            this.ExplanationText.BackColor = System.Drawing.Color.Transparent;
            this.ExplanationText.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExplanationText.ForeColor = System.Drawing.Color.White;
            this.ExplanationText.Location = new System.Drawing.Point(38, 862);
            this.ExplanationText.Name = "ExplanationText";
            this.ExplanationText.Size = new System.Drawing.Size(404, 38);
            this.ExplanationText.TabIndex = 6;
            this.ExplanationText.Text = "ここにゲームの説明を記載";
            // 
            // CreatorText
            // 
            this.CreatorText.AutoSize = true;
            this.CreatorText.BackColor = System.Drawing.Color.Transparent;
            this.CreatorText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreatorText.ForeColor = System.Drawing.Color.White;
            this.CreatorText.Location = new System.Drawing.Point(373, 795);
            this.CreatorText.Name = "CreatorText";
            this.CreatorText.Size = new System.Drawing.Size(141, 24);
            this.CreatorText.TabIndex = 5;
            this.CreatorText.Text = "制作者 : ぺぴ";
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.BackColor = System.Drawing.Color.Transparent;
            this.TitleText.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleText.ForeColor = System.Drawing.Color.White;
            this.TitleText.Location = new System.Drawing.Point(360, 722);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(505, 67);
            this.TitleText.TabIndex = 4;
            this.TitleText.Text = "GAME_NO_TITLE";
            this.TitleText.Click += new System.EventHandler(this.label2_Click);
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.VersionText.ForeColor = System.Drawing.SystemColors.Window;
            this.VersionText.Location = new System.Drawing.Point(1096, 795);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(96, 24);
            this.VersionText.TabIndex = 2;
            this.VersionText.Text = "Ver.1.0.0";
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.Image = global::VaporClient.Properties.Resources.Setting;
            this.SettingButton.Location = new System.Drawing.Point(110, 990);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(80, 80);
            this.SettingButton.TabIndex = 10;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // RerollButton
            // 
            this.RerollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.RerollButton.FlatAppearance.BorderSize = 0;
            this.RerollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RerollButton.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RerollButton.Image = global::VaporClient.Properties.Resources.Reroll;
            this.RerollButton.Location = new System.Drawing.Point(210, 990);
            this.RerollButton.Name = "RerollButton";
            this.RerollButton.Size = new System.Drawing.Size(80, 80);
            this.RerollButton.TabIndex = 9;
            this.RerollButton.UseVisualStyleBackColor = false;
            this.RerollButton.Click += new System.EventHandler(this.RerollButton_Click);
            // 
            // PowerButton
            // 
            this.PowerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.PowerButton.FlatAppearance.BorderSize = 0;
            this.PowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerButton.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerButton.Image = global::VaporClient.Properties.Resources.Power;
            this.PowerButton.Location = new System.Drawing.Point(10, 990);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(80, 80);
            this.PowerButton.TabIndex = 8;
            this.PowerButton.UseVisualStyleBackColor = false;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 980);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(686, 99);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Image = global::VaporClient.Properties.Resources.PLAY;
            this.PlayButton.Location = new System.Drawing.Point(40, 727);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(301, 101);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1152, 648);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Vapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label VersionText;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label ExplanationText;
        private System.Windows.Forms.Label CreatorText;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ListView GameList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.Button RerollButton;
        private System.Windows.Forms.Button SettingButton;
    }
}

