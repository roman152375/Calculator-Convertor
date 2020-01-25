namespace Project_Calculator
{
    partial class weight
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
            this.lblKG = new System.Windows.Forms.Label();
            this.txtKG = new System.Windows.Forms.TextBox();
            this.lblPounds = new System.Windows.Forms.Label();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtResultW = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKG
            // 
            this.lblKG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.Location = new System.Drawing.Point(13, 13);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(100, 25);
            this.lblKG.TabIndex = 0;
            this.lblKG.Text = "Kilograms:";
            this.lblKG.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKG
            // 
            this.txtKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKG.Location = new System.Drawing.Point(119, 13);
            this.txtKG.Multiline = true;
            this.txtKG.Name = "txtKG";
            this.txtKG.Size = new System.Drawing.Size(175, 25);
            this.txtKG.TabIndex = 1;
            // 
            // lblPounds
            // 
            this.lblPounds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPounds.Location = new System.Drawing.Point(13, 67);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(100, 25);
            this.lblPounds.TabIndex = 2;
            this.lblPounds.Text = "Pounds:";
            this.lblPounds.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPounds
            // 
            this.txtPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPounds.Location = new System.Drawing.Point(120, 67);
            this.txtPounds.Multiline = true;
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(174, 25);
            this.txtPounds.TabIndex = 3;
            // 
            // txtResultW
            // 
            this.txtResultW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultW.Location = new System.Drawing.Point(12, 109);
            this.txtResultW.Multiline = true;
            this.txtResultW.Name = "txtResultW";
            this.txtResultW.Size = new System.Drawing.Size(281, 51);
            this.txtResultW.TabIndex = 4;
            this.txtResultW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(217, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Reset";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 213);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResultW);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.txtKG);
            this.Controls.Add(this.lblKG);
            this.Name = "weight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.TextBox txtKG;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.TextBox txtResultW;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}