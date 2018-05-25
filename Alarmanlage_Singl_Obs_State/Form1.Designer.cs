namespace Alarmanlage_Singl_Obs_State
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_change = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(33, 40);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(128, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 95);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 186);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_change);
            this.Name = "Form1";
            this.Text = "Alarmanlage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

