namespace WindowsFormsPlanes
{
    partial class FormPlaneConfig
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
            this.groupBox_Type = new System.Windows.Forms.GroupBox();
            this.labelAirbus = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.groupBox_ParamInput = new System.Windows.Forms.GroupBox();
            this.checkBox_SecLevel = new System.Windows.Forms.CheckBox();
            this.CheckBox_Star = new System.Windows.Forms.CheckBox();
            this.numericUpDown_Weight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Speed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBrown = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancell = new System.Windows.Forms.Button();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBox_Type.SuspendLayout();
            this.groupBox_ParamInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Type
            // 
            this.groupBox_Type.Controls.Add(this.labelAirbus);
            this.groupBox_Type.Controls.Add(this.labelPlane);
            this.groupBox_Type.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Type.Name = "groupBox_Type";
            this.groupBox_Type.Size = new System.Drawing.Size(130, 143);
            this.groupBox_Type.TabIndex = 3;
            this.groupBox_Type.TabStop = false;
            this.groupBox_Type.Text = "Тип самолета";
            // 
            // labelAirbus
            // 
            this.labelAirbus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirbus.Location = new System.Drawing.Point(9, 79);
            this.labelAirbus.Name = "labelAirbus";
            this.labelAirbus.Size = new System.Drawing.Size(100, 37);
            this.labelAirbus.TabIndex = 1;
            this.labelAirbus.Text = "Аэробус";
            this.labelAirbus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAirbus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelAirbus_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(9, 26);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(100, 37);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Обычный самолет";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPlane_MouseDwon);
            // 
            // groupBox_ParamInput
            // 
            this.groupBox_ParamInput.Controls.Add(this.checkBox_SecLevel);
            this.groupBox_ParamInput.Controls.Add(this.CheckBox_Star);
            this.groupBox_ParamInput.Controls.Add(this.numericUpDown_Weight);
            this.groupBox_ParamInput.Controls.Add(this.numericUpDown_Speed);
            this.groupBox_ParamInput.Controls.Add(this.labelWeight);
            this.groupBox_ParamInput.Controls.Add(this.labelMaxSpeed);
            this.groupBox_ParamInput.Location = new System.Drawing.Point(12, 172);
            this.groupBox_ParamInput.Name = "groupBox_ParamInput";
            this.groupBox_ParamInput.Size = new System.Drawing.Size(296, 96);
            this.groupBox_ParamInput.TabIndex = 4;
            this.groupBox_ParamInput.TabStop = false;
            this.groupBox_ParamInput.Text = "Параметры";
            // 
            // checkBox_SecLevel
            // 
            this.checkBox_SecLevel.AutoSize = true;
            this.checkBox_SecLevel.Location = new System.Drawing.Point(196, 24);
            this.checkBox_SecLevel.Name = "checkBox_SecLevel";
            this.checkBox_SecLevel.Size = new System.Drawing.Size(90, 17);
            this.checkBox_SecLevel.TabIndex = 1;
            this.checkBox_SecLevel.Text = "Второй этаж";
            this.checkBox_SecLevel.UseVisualStyleBackColor = true;
            this.checkBox_SecLevel.Click += new System.EventHandler(this.checkBox_SecLevel_Click);
            // 
            // CheckBox_Star
            // 
            this.CheckBox_Star.AutoSize = true;
            this.CheckBox_Star.Location = new System.Drawing.Point(196, 55);
            this.CheckBox_Star.Name = "CheckBox_Star";
            this.CheckBox_Star.Size = new System.Drawing.Size(77, 17);
            this.CheckBox_Star.TabIndex = 2;
            this.CheckBox_Star.Text = "Граффити";
            this.CheckBox_Star.UseVisualStyleBackColor = true;
            this.CheckBox_Star.Click += new System.EventHandler(this.CheckBox_Star_Click);
            // 
            // numericUpDown_Weight
            // 
            this.numericUpDown_Weight.Location = new System.Drawing.Point(115, 54);
            this.numericUpDown_Weight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Weight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Weight.Name = "numericUpDown_Weight";
            this.numericUpDown_Weight.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_Weight.TabIndex = 1;
            this.numericUpDown_Weight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_Speed
            // 
            this.numericUpDown_Speed.Location = new System.Drawing.Point(115, 23);
            this.numericUpDown_Speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Speed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Speed.Name = "numericUpDown_Speed";
            this.numericUpDown_Speed.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_Speed.TabIndex = 1;
            this.numericUpDown_Speed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(19, 56);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(81, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес самолета:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(19, 25);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGrey);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelBrown);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(535, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(227, 143);
            this.groupBoxColors.TabIndex = 5;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Выбор цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(120, 26);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(92, 34);
            this.labelDopColor.TabIndex = 5;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(171, 99);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(30, 30);
            this.panelOrange.TabIndex = 7;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(18, 26);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(96, 34);
            this.labelMainColor.TabIndex = 4;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.SlateBlue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(171, 63);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 6;
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.Color.Gray;
            this.panelGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrey.Location = new System.Drawing.Point(75, 99);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(30, 30);
            this.panelGrey.TabIndex = 5;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(27, 99);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(30, 30);
            this.panelPink.TabIndex = 4;
            // 
            // panelBrown
            // 
            this.panelBrown.BackColor = System.Drawing.Color.Sienna;
            this.panelBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrown.Location = new System.Drawing.Point(123, 99);
            this.panelBrown.Name = "panelBrown";
            this.panelBrown.Size = new System.Drawing.Size(30, 30);
            this.panelBrown.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(123, 63);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(75, 63);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 1;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Firebrick;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(27, 63);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(688, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancell
            // 
            this.buttonCancell.Location = new System.Drawing.Point(687, 245);
            this.buttonCancell.Name = "buttonCancell";
            this.buttonCancell.Size = new System.Drawing.Size(75, 23);
            this.buttonCancell.TabIndex = 7;
            this.buttonCancell.Text = "Отмена";
            this.buttonCancell.UseVisualStyleBackColor = true;
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(166, 12);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(330, 143);
            this.panelPlane.TabIndex = 8;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(322, 135);
            this.pictureBoxPlane.TabIndex = 1;
            this.pictureBoxPlane.TabStop = false;
            this.pictureBoxPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.pictureBoxPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 285);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.buttonCancell);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBox_ParamInput);
            this.Controls.Add(this.groupBox_Type);
            this.Name = "FormPlaneConfig";
            this.Text = "Выбор самолета";
            this.groupBox_Type.ResumeLayout(false);
            this.groupBox_ParamInput.ResumeLayout(false);
            this.groupBox_ParamInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Type;
        private System.Windows.Forms.Label labelAirbus;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.GroupBox groupBox_ParamInput;
        private System.Windows.Forms.CheckBox checkBox_SecLevel;
        private System.Windows.Forms.CheckBox CheckBox_Star;
        private System.Windows.Forms.NumericUpDown numericUpDown_Weight;
        private System.Windows.Forms.NumericUpDown numericUpDown_Speed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBrown;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancell;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
    }
}