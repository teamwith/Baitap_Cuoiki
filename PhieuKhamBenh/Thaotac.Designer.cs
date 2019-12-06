namespace PhieuKhamBenh
{
    partial class Thaotac
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
            this.btnXem = new System.Windows.Forms.Button();
            this.btnTaophieumoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(26, 175);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(165, 58);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem danh sách";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnTaophieumoi
            // 
            this.btnTaophieumoi.Location = new System.Drawing.Point(257, 175);
            this.btnTaophieumoi.Name = "btnTaophieumoi";
            this.btnTaophieumoi.Size = new System.Drawing.Size(177, 58);
            this.btnTaophieumoi.TabIndex = 0;
            this.btnTaophieumoi.Text = "Tạo  Phiếu Mới ";
            this.btnTaophieumoi.UseVisualStyleBackColor = true;
            this.btnTaophieumoi.Click += new System.EventHandler(this.BtnTaophieumoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!!!";
            // 
            // btnHoso
            // 
            this.btnHoso.Location = new System.Drawing.Point(147, 253);
            this.btnHoso.Name = "btnHoso";
            this.btnHoso.Size = new System.Drawing.Size(165, 58);
            this.btnHoso.TabIndex = 2;
            this.btnHoso.Text = "Hồ sơ của bạn";
            this.btnHoso.UseVisualStyleBackColor = true;
            // 
            // Thaotac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 337);
            this.Controls.Add(this.btnHoso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaophieumoi);
            this.Controls.Add(this.btnXem);
            this.MaximizeBox = false;
            this.Name = "Thaotac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thao Tác";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTaophieumoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoso;
    }
}