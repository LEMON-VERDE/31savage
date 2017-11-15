namespace _31Savage
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.imageListPlayers = new System.Windows.Forms.ImageList(this.components);
            this.listViewPlayerActive = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageListPlayers
            // 
            this.imageListPlayers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlayers.ImageStream")));
            this.imageListPlayers.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPlayers.Images.SetKeyName(0, "cartoon_PEPE.png");
            this.imageListPlayers.Images.SetKeyName(1, "HomerSimpson.jpg");
            this.imageListPlayers.Images.SetKeyName(2, "Madame.jpg");
            this.imageListPlayers.Images.SetKeyName(3, "KungFuPanda.png");
            this.imageListPlayers.Images.SetKeyName(4, "msuhMario.png");
            this.imageListPlayers.Images.SetKeyName(5, "Doris.jpg");
            // 
            // listViewPlayerActive
            // 
            this.listViewPlayerActive.Location = new System.Drawing.Point(12, 12);
            this.listViewPlayerActive.Name = "listViewPlayerActive";
            this.listViewPlayerActive.Size = new System.Drawing.Size(121, 97);
            this.listViewPlayerActive.TabIndex = 0;
            this.listViewPlayerActive.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView2.LargeImageList = this.imageListPlayers;
            this.listView2.Location = new System.Drawing.Point(575, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 97);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 501);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listViewPlayerActive);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListPlayers;
        private System.Windows.Forms.ListView listViewPlayerActive;
        private System.Windows.Forms.ListView listView2;
    }
}