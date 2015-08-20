﻿namespace QLQuanCafe.GUI.Dialog
{
    partial class ThongTin
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
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.LabIConfirm = new DevComponents.DotNetBar.LabelX();
            this.LbConfirm = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(197, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            // 
            // LabIConfirm
            // 
            this.LabIConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabIConfirm.BackgroundImage = global::QLQuanCafe.Properties.Resources.Confirm;
            // 
            // 
            // 
            this.LabIConfirm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabIConfirm.ForeColor = System.Drawing.Color.Black;
            this.LabIConfirm.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.LabIConfirm.Location = new System.Drawing.Point(21, 30);
            this.LabIConfirm.Name = "LabIConfirm";
            this.LabIConfirm.Size = new System.Drawing.Size(45, 45);
            this.LabIConfirm.TabIndex = 1;
            this.LabIConfirm.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // LbConfirm
            // 
            this.LbConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LbConfirm.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LbConfirm.ForeColor = System.Drawing.Color.Black;
            this.LbConfirm.Location = new System.Drawing.Point(105, 41);
            this.LbConfirm.Name = "LbConfirm";
            this.LbConfirm.Size = new System.Drawing.Size(119, 23);
            this.LbConfirm.TabIndex = 2;
            this.LbConfirm.Text = "Lưu Thành Công";
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.LbConfirm);
            this.Controls.Add(this.LabIConfirm);
            this.Controls.Add(this.btnOK);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTin";
            this.ShowIcon = false;
            this.TitleText = "<font color=\"#FFFFFF\">Thông \r\nTin</font>";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.LabelX LabIConfirm;
        private DevComponents.DotNetBar.LabelX LbConfirm;
    }
}