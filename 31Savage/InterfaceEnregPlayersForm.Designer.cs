namespace _31Savage
{
    partial class InterfaceEnregPlayersForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.listBox_nbPlayer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Mangal", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(187, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(249, 40);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Enregistre les joueurs";
            // 
            // listBox_nbPlayer
            // 
            this.listBox_nbPlayer.FormattingEnabled = true;
            this.listBox_nbPlayer.Location = new System.Drawing.Point(52, 76);
            this.listBox_nbPlayer.Name = "listBox_nbPlayer";
            this.listBox_nbPlayer.Size = new System.Drawing.Size(120, 17);
            this.listBox_nbPlayer.TabIndex = 1;
            this.listBox_nbPlayer.SelectedIndexChanged += new System.EventHandler(this.listBox_nbPlayer_SelectedIndexChanged);
            // 
            // InterfaceEnregPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 360);
            this.Controls.Add(this.listBox_nbPlayer);
            this.Controls.Add(this.lbl_title);
            this.Name = "InterfaceEnregPlayersForm";
            this.Text = "InterfaceEnregPlayersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ListBox listBox_nbPlayer;
    }
}