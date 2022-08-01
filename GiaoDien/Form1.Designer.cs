using System;

namespace GiaoDien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user = new System.Windows.Forms.Label();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(159)))));
            this.user.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Transparent;
            this.user.Location = new System.Drawing.Point(103, 308);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(187, 33);
            this.user.TabIndex = 0;
            this.user.Text = "Tài khoản:";
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // taikhoan
            // 
            this.taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taikhoan.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.Location = new System.Drawing.Point(273, 381);
            this.taikhoan.Multiline = true;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(398, 27);
            this.taikhoan.TabIndex = 0;
            this.taikhoan.TextChanged += new System.EventHandler(this.taikhoan_TextChanged);
            // 
            // matkhau
            // 
            this.matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.matkhau.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(289, 308);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(382, 27);
            this.matkhau.TabIndex = 2;
            this.matkhau.UseSystemPasswordChar = true;
            this.matkhau.TextChanged += new System.EventHandler(this.matkhau_TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(59)))), ((int)(((byte)(159)))));
            this.pass.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(103, 375);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(187, 33);
            this.pass.TabIndex = 2;
            this.pass.Text = "Mật khẩu:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(457, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Đăng nhập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(213, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 763);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.user);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private EventHandler textBox1_TextChanged;
    }
}

