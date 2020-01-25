namespace Project_Calculator
{
    partial class length
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
            this.lblKM = new System.Windows.Forms.Label();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.btnCalculateL = new System.Windows.Forms.Button();
            this.btnResetL = new System.Windows.Forms.Button();
            this.txtResultL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKM
            // 
            this.lblKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(13, 13);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(100, 25);
            this.lblKM.TabIndex = 0;
            this.lblKM.Text = "KiloMeters:";
            this.lblKM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtkm
            // 
            this.txtkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkm.Location = new System.Drawing.Point(119, 12);
            this.txtkm.Multiline = true;
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(194, 26);
            this.txtkm.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(13, 58);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(100, 25);
            this.lab.TabIndex = 2;
            this.lab.Text = "Miles:";
            this.lab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(120, 58);
            this.txtMiles.Multiline = true;
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(193, 25);
            this.txtMiles.TabIndex = 3;
            // 
            // btnCalculateL
            // 
            this.btnCalculateL.Location = new System.Drawing.Point(12, 191);
            this.btnCalculateL.Name = "btnCalculateL";
            this.btnCalculateL.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateL.TabIndex = 4;
            this.btnCalculateL.Text = "&Calculate";
            this.btnCalculateL.UseVisualStyleBackColor = true;
            this.btnCalculateL.Click += new System.EventHandler(this.btnCalculateL_Click);
            // 
            // btnResetL
            // 
            this.btnResetL.Location = new System.Drawing.Point(237, 191);
            this.btnResetL.Name = "btnResetL";
            this.btnResetL.Size = new System.Drawing.Size(75, 23);
            this.btnResetL.TabIndex = 5;
            this.btnResetL.Text = "&Reset";
            this.btnResetL.UseVisualStyleBackColor = true;
            this.btnResetL.Click += new System.EventHandler(this.btnResetL_Click);
            // 
            // txtResultL
            // 
            this.txtResultL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultL.Location = new System.Drawing.Point(12, 89);
            this.txtResultL.Multiline = true;
            this.txtResultL.Name = "txtResultL";
            this.txtResultL.Size = new System.Drawing.Size(300, 56);
            this.txtResultL.TabIndex = 6;
            this.txtResultL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // length
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 226);
            this.Controls.Add(this.txtResultL);
            this.Controls.Add(this.btnResetL);
            this.Controls.Add(this.btnCalculateL);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.lblKM);
            this.Name = "length";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "length";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Button btnCalculateL;
        private System.Windows.Forms.Button btnResetL;
        private System.Windows.Forms.TextBox txtResultL;
    }
}