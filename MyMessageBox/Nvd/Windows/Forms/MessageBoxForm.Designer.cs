namespace Nvd.Windows.Forms
{
    partial class MessageBoxForm
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
            this.abortButton = new Nvd.Windows.Forms.Button();
            this.retryButton = new Nvd.Windows.Forms.Button();
            this.noButton = new Nvd.Windows.Forms.Button();
            this.ignoreButton = new Nvd.Windows.Forms.Button();
            this.yesButton = new Nvd.Windows.Forms.Button();
            this.cancelButton = new Nvd.Windows.Forms.Button();
            this.okButton = new Nvd.Windows.Forms.Button();
            this.textLabel = new Nvd.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abortButton.Location = new System.Drawing.Point(29, 114);
            this.abortButton.Name = "abortButton";
            this.abortButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.abortButton.Size = new System.Drawing.Size(70, 36);
            this.abortButton.TabIndex = 4;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Visible = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // retryButton
            // 
            this.retryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.retryButton.Location = new System.Drawing.Point(3, 114);
            this.retryButton.Name = "retryButton";
            this.retryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.retryButton.Size = new System.Drawing.Size(70, 36);
            this.retryButton.TabIndex = 3;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.Location = new System.Drawing.Point(159, 114);
            this.noButton.Name = "noButton";
            this.noButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noButton.Size = new System.Drawing.Size(70, 36);
            this.noButton.TabIndex = 4;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreButton.Location = new System.Drawing.Point(56, 114);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ignoreButton.Size = new System.Drawing.Size(70, 36);
            this.ignoreButton.TabIndex = 2;
            this.ignoreButton.Text = "Ignore";
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Visible = false;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yesButton.Location = new System.Drawing.Point(129, 114);
            this.yesButton.Name = "yesButton";
            this.yesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yesButton.Size = new System.Drawing.Size(70, 36);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(196, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelButton.Size = new System.Drawing.Size(70, 36);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(272, 114);
            this.okButton.Name = "okButton";
            this.okButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.okButton.Size = new System.Drawing.Size(70, 36);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.textLabel.Location = new System.Drawing.Point(13, 13);
            this.textLabel.Name = "textLabel";
            this.textLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textLabel.Size = new System.Drawing.Size(329, 98);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "Text";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 162);
            this.ControlBox = false;
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label textLabel;
        private Button okButton;
        private Button cancelButton;
        private Button yesButton;
        private Button noButton;
        private Button ignoreButton;
        private Button retryButton;
        private Button abortButton;
    }
}