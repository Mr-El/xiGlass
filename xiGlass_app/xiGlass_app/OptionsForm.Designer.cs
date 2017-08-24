namespace xiGlass_app
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.resolutionGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controllerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.resolutionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // resolutionGroup
            // 
            this.resolutionGroup.Controls.Add(this.heightBox);
            this.resolutionGroup.Controls.Add(this.widthBox);
            this.resolutionGroup.Controls.Add(this.label3);
            this.resolutionGroup.Controls.Add(this.label2);
            this.resolutionGroup.Location = new System.Drawing.Point(12, 22);
            this.resolutionGroup.Name = "resolutionGroup";
            this.resolutionGroup.Size = new System.Drawing.Size(258, 145);
            this.resolutionGroup.TabIndex = 1;
            this.resolutionGroup.TabStop = false;
            this.resolutionGroup.Text = "Resolution:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controller:";
            // 
            // controllerList
            // 
            this.controllerList.FormattingEnabled = true;
            this.controllerList.Items.AddRange(new object[] {
            "Xbox 360/One",
            "PlayStation 4"});
            this.controllerList.Location = new System.Drawing.Point(131, 187);
            this.controllerList.Name = "controllerList";
            this.controllerList.Size = new System.Drawing.Size(139, 24);
            this.controllerList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height:";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(143, 31);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 22);
            this.widthBox.TabIndex = 2;
            this.widthBox.Text = "1920";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(143, 82);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 22);
            this.heightBox.TabIndex = 3;
            this.heightBox.Text = "1080";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(195, 234);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 45);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "testing";
            this.notifyIcon.Visible = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 291);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.controllerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resolutionGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.Text = "xiGlass";
            this.resolutionGroup.ResumeLayout(false);
            this.resolutionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox resolutionGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox controllerList;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}