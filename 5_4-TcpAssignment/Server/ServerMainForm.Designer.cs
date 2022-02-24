namespace Server
{
    partial class ServerMainForm
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
            this.marioPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.marioPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // marioPicBox
            // 
            this.marioPicBox.Image = global::Server.Properties.Resources.mario_transparent;
            this.marioPicBox.Location = new System.Drawing.Point(254, 41);
            this.marioPicBox.Name = "marioPicBox";
            this.marioPicBox.Size = new System.Drawing.Size(117, 114);
            this.marioPicBox.TabIndex = 0;
            this.marioPicBox.TabStop = false;
            this.marioPicBox.Visible = false;
            // 
            // ServerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marioPicBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerMainForm";
            this.ShowIcon = false;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.marioPicBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox marioPicBox;

        #endregion
    }
}