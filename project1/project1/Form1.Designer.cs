namespace project1
{
    partial class formfirst
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
            this.btn = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.MaskedTextBox();
            this.textbox1 = new System.Windows.Forms.MaskedTextBox();
            this.textbox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(163, 44);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.TabStop = false;
            this.btn.Text = "click me";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(25, 44);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 1;
            this.textbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textbox_MaskInputRejected);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(25, 102);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 20);
            this.textbox1.TabIndex = 1;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(25, 165);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(100, 20);
            this.textbox2.TabIndex = 1;
            // 
            // formfirst
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 451);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.btn);
            this.Name = "formfirst";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formfirst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.MaskedTextBox textbox;
        private System.Windows.Forms.MaskedTextBox textbox1;
        private System.Windows.Forms.MaskedTextBox textbox2;
    }
}

