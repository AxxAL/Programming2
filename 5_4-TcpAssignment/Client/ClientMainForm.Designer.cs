namespace Client
{
    partial class ClientMainForm
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
            this.connectionStatusTbx = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.controlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionStatusTbx
            // 
            this.connectionStatusTbx.ForeColor = System.Drawing.Color.Red;
            this.connectionStatusTbx.Location = new System.Drawing.Point(688, 9);
            this.connectionStatusTbx.Name = "connectionStatusTbx";
            this.connectionStatusTbx.Size = new System.Drawing.Size(100, 23);
            this.connectionStatusTbx.TabIndex = 0;
            this.connectionStatusTbx.Text = "Disconnected";
            this.connectionStatusTbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.moveRightButton);
            this.controlGroupBox.Controls.Add(this.moveLeftButton);
            this.controlGroupBox.Controls.Add(this.moveDownButton);
            this.controlGroupBox.Controls.Add(this.moveUpButton);
            this.controlGroupBox.Location = new System.Drawing.Point(40, 160);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(250, 250);
            this.controlGroupBox.TabIndex = 1;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Controls";
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(168, 108);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(50, 50);
            this.moveRightButton.TabIndex = 3;
            this.moveRightButton.Text = "Right";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(19, 106);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(50, 50);
            this.moveLeftButton.TabIndex = 2;
            this.moveLeftButton.Text = "Left";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(98, 184);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(50, 50);
            this.moveDownButton.TabIndex = 1;
            this.moveDownButton.Text = "Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(98, 30);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(50, 50);
            this.moveUpButton.TabIndex = 0;
            this.moveUpButton.Text = "Up";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.connectionStatusTbx);
            this.Name = "ClientMainForm";
            this.ShowIcon = false;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.controlGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveRightButton;

        private System.Windows.Forms.Label connectionStatusTbx;

        #endregion
    }
}