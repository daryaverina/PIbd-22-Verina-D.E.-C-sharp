﻿namespace WindowsFormsPlanes
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkPlane = new System.Windows.Forms.Button();
            this.buttonParkAirbus = new System.Windows.Forms.Button();
            this.BoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBoxTake = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDeleteParking = new System.Windows.Forms.Button();
            this.textBoxParkingName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.BoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(680, 450);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkPlane
            // 
            this.buttonParkPlane.Location = new System.Drawing.Point(682, 263);
            this.buttonParkPlane.Name = "buttonParkPlane";
            this.buttonParkPlane.Size = new System.Drawing.Size(117, 38);
            this.buttonParkPlane.TabIndex = 1;
            this.buttonParkPlane.Text = "Припарковать самолет";
            this.buttonParkPlane.UseVisualStyleBackColor = true;
            this.buttonParkPlane.Click += new System.EventHandler(this.buttonParkPlane_Click);
            // 
            // buttonParkAirbus
            // 
            this.buttonParkAirbus.Location = new System.Drawing.Point(682, 307);
            this.buttonParkAirbus.Name = "buttonParkAirbus";
            this.buttonParkAirbus.Size = new System.Drawing.Size(117, 38);
            this.buttonParkAirbus.TabIndex = 2;
            this.buttonParkAirbus.Text = "Припарковать аэробус";
            this.buttonParkAirbus.UseVisualStyleBackColor = true;
            this.buttonParkAirbus.Click += new System.EventHandler(this.buttonParkAirbus_Click);
            // 
            // BoxDelete
            // 
            this.BoxDelete.Controls.Add(this.buttonTakePlane);
            this.BoxDelete.Controls.Add(this.maskedTextBoxTake);
            this.BoxDelete.Controls.Add(this.labelPlace);
            this.BoxDelete.Location = new System.Drawing.Point(682, 351);
            this.BoxDelete.Name = "BoxDelete";
            this.BoxDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BoxDelete.Size = new System.Drawing.Size(117, 87);
            this.BoxDelete.TabIndex = 3;
            this.BoxDelete.TabStop = false;
            this.BoxDelete.Text = "Забрать самолет";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(18, 45);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(75, 23);
            this.buttonTakePlane.TabIndex = 2;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBoxTake
            // 
            this.maskedTextBoxTake.Location = new System.Drawing.Point(63, 19);
            this.maskedTextBoxTake.Name = "maskedTextBoxTake";
            this.maskedTextBoxTake.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBoxTake.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(15, 22);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(682, 80);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(117, 95);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(715, 9);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(52, 13);
            this.labelParkings.TabIndex = 5;
            this.labelParkings.Text = "Стоянки:";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(682, 51);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(117, 23);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить стоянку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDeleteParking
            // 
            this.buttonDeleteParking.Location = new System.Drawing.Point(682, 181);
            this.buttonDeleteParking.Name = "buttonDeleteParking";
            this.buttonDeleteParking.Size = new System.Drawing.Size(117, 23);
            this.buttonDeleteParking.TabIndex = 7;
            this.buttonDeleteParking.Text = "Удалить стоянку";
            this.buttonDeleteParking.UseVisualStyleBackColor = true;
            this.buttonDeleteParking.Click += new System.EventHandler(this.buttonDeleteParking_Click);
            // 
            // textBoxParkingName
            // 
            this.textBoxParkingName.Location = new System.Drawing.Point(682, 25);
            this.textBoxParkingName.Name = "textBoxParkingName";
            this.textBoxParkingName.Size = new System.Drawing.Size(117, 20);
            this.textBoxParkingName.TabIndex = 8;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxParkingName);
            this.Controls.Add(this.buttonDeleteParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.BoxDelete);
            this.Controls.Add(this.buttonParkAirbus);
            this.Controls.Add(this.buttonParkPlane);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.BoxDelete.ResumeLayout(false);
            this.BoxDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkPlane;
        private System.Windows.Forms.Button buttonParkAirbus;
        private System.Windows.Forms.GroupBox BoxDelete;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDeleteParking;
        private System.Windows.Forms.TextBox textBoxParkingName;
    }
}