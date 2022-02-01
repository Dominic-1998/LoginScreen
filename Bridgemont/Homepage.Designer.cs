namespace Bridgemont
{
    partial class Map
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
            this.components = new System.ComponentModel.Container();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.textBox_Registration = new System.Windows.Forms.TextBox();
            this.label_Registration = new System.Windows.Forms.Label();
            this.button_Find = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(12, 13);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(882, 670);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            // 
            // textBox_Registration
            // 
            this.textBox_Registration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Registration.Location = new System.Drawing.Point(903, 31);
            this.textBox_Registration.Name = "textBox_Registration";
            this.textBox_Registration.Size = new System.Drawing.Size(213, 22);
            this.textBox_Registration.TabIndex = 2;
            // 
            // label_Registration
            // 
            this.label_Registration.AutoSize = true;
            this.label_Registration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Registration.Location = new System.Drawing.Point(900, 13);
            this.label_Registration.Name = "label_Registration";
            this.label_Registration.Size = new System.Drawing.Size(77, 16);
            this.label_Registration.TabIndex = 3;
            this.label_Registration.Text = "Registration";
            // 
            // button_Find
            // 
            this.button_Find.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Find.FlatAppearance.BorderSize = 0;
            this.button_Find.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button_Find.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Find.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Find.Location = new System.Drawing.Point(903, 59);
            this.button_Find.Name = "button_Find";
            this.button_Find.Size = new System.Drawing.Size(213, 54);
            this.button_Find.TabIndex = 8;
            this.button_Find.TabStop = false;
            this.button_Find.Text = "Find";
            this.button_Find.UseVisualStyleBackColor = false;
            this.button_Find.Click += new System.EventHandler(this.button_Find_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 695);
            this.Controls.Add(this.button_Find);
            this.Controls.Add(this.label_Registration);
            this.Controls.Add(this.textBox_Registration);
            this.Controls.Add(this.gMap);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Map";
            this.Text = "Map";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.TextBox textBox_Registration;
        private System.Windows.Forms.Label label_Registration;
        private System.Windows.Forms.Button button_Find;
        private System.Windows.Forms.Timer timer1;
    }
}