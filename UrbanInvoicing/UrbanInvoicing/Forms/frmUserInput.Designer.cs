namespace UrbanInvoicing.Forms
{
    partial class frmUserInput
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 64);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(8, 92);
            this.labelVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(64, 13);
            this.labelVat.TabIndex = 1;
            this.labelVat.Text = "MwSt - Satz";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 60);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(105, 90);
            this.textBoxVat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(231, 20);
            this.textBoxVat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Abbrechen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmUserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVat);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUserInput";
            this.ShowIcon = false;
            this.Text = "Benutzereingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}