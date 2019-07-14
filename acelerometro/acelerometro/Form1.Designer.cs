namespace acelerometro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.puerto = new System.IO.Ports.SerialPort(this.components);
            this.tx1 = new System.Windows.Forms.TextBox();
            this.ty1 = new System.Windows.Forms.TextBox();
            this.tz1 = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.ty2 = new System.Windows.Forms.TextBox();
            this.tz2 = new System.Windows.Forms.TextBox();
            this.Puertos = new System.Windows.Forms.ComboBox();
            this.boton = new System.Windows.Forms.Button();
            this.grafica1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.puerto2 = new System.IO.Ports.SerialPort(this.components);
            this.x3 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.z3 = new System.Windows.Forms.TextBox();
            this.puerto1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.grafica2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grafica3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // puerto
            // 
            this.puerto.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.puerto_DataReceived);
            // 
            // tx1
            // 
            this.tx1.Location = new System.Drawing.Point(41, 110);
            this.tx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(99, 22);
            this.tx1.TabIndex = 0;
            // 
            // ty1
            // 
            this.ty1.Location = new System.Drawing.Point(183, 110);
            this.ty1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ty1.Name = "ty1";
            this.ty1.Size = new System.Drawing.Size(99, 22);
            this.ty1.TabIndex = 1;
            // 
            // tz1
            // 
            this.tz1.Location = new System.Drawing.Point(327, 110);
            this.tz1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tz1.Name = "tz1";
            this.tz1.Size = new System.Drawing.Size(97, 22);
            this.tz1.TabIndex = 2;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(549, 110);
            this.tx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(99, 22);
            this.tx2.TabIndex = 3;
            // 
            // ty2
            // 
            this.ty2.Location = new System.Drawing.Point(696, 110);
            this.ty2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ty2.Name = "ty2";
            this.ty2.Size = new System.Drawing.Size(99, 22);
            this.ty2.TabIndex = 4;
            // 
            // tz2
            // 
            this.tz2.Location = new System.Drawing.Point(845, 110);
            this.tz2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tz2.Name = "tz2";
            this.tz2.Size = new System.Drawing.Size(99, 22);
            this.tz2.TabIndex = 5;
            // 
            // Puertos
            // 
            this.Puertos.FormattingEnabled = true;
            this.Puertos.Location = new System.Drawing.Point(652, 64);
            this.Puertos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Puertos.Name = "Puertos";
            this.Puertos.Size = new System.Drawing.Size(160, 24);
            this.Puertos.TabIndex = 6;
            this.Puertos.DropDown += new System.EventHandler(this.Puertos_DropDown);
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(524, 64);
            this.boton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(100, 28);
            this.boton.TabIndex = 7;
            this.boton.Text = "Conectar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // grafica1
            // 
            this.grafica1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.grafica1.BackImage = "C:\\Users\\dell\\Pictures\\Screenshots\\Sin título.png";
            this.grafica1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grafica1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica1.Legends.Add(legend1);
            this.grafica1.Location = new System.Drawing.Point(4, 142);
            this.grafica1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafica1.Name = "grafica1";
            this.grafica1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.grafica1.Size = new System.Drawing.Size(421, 369);
            this.grafica1.TabIndex = 8;
            this.grafica1.Text = "grafica1";
            this.grafica1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.grafica1.Click += new System.EventHandler(this.grafica1_Click);
            // 
            // puerto2
            // 
            this.puerto2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.puerto2_DataReceived);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(1061, 110);
            this.x3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(99, 22);
            this.x3.TabIndex = 10;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(1209, 110);
            this.y3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(99, 22);
            this.y3.TabIndex = 11;
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(1357, 110);
            this.z3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(99, 22);
            this.z3.TabIndex = 12;
            // 
            // puerto1
            // 
            this.puerto1.FormattingEnabled = true;
            this.puerto1.Location = new System.Drawing.Point(839, 64);
            this.puerto1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.puerto1.Name = "puerto1";
            this.puerto1.Size = new System.Drawing.Size(160, 24);
            this.puerto1.TabIndex = 13;
            this.puerto1.Click += new System.EventHandler(this.puerto1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "X1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Y1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 110);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Z1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(512, 110);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(28, 22);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "X2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(659, 110);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(28, 22);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Y2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(808, 110);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(28, 22);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Z2";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1024, 110);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(28, 22);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "X3";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1172, 110);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(28, 22);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "Y3";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1320, 110);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(28, 22);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "Z3";
            // 
            // grafica2
            // 
            this.grafica2.BackColor = System.Drawing.Color.Red;
            this.grafica2.BackImage = "C:\\Users\\dell\\Pictures\\Screenshots\\Sin título.png";
            this.grafica2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.grafica2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafica2.Legends.Add(legend2);
            this.grafica2.Location = new System.Drawing.Point(524, 146);
            this.grafica2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafica2.Name = "grafica2";
            this.grafica2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.grafica2.Size = new System.Drawing.Size(421, 369);
            this.grafica2.TabIndex = 23;
            this.grafica2.Text = "chart1";
            this.grafica2.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // grafica3
            // 
            this.grafica3.BackColor = System.Drawing.Color.Red;
            this.grafica3.BackImage = "C:\\Users\\dell\\Pictures\\Screenshots\\Sin título.png";
            this.grafica3.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.grafica3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafica3.Legends.Add(legend3);
            this.grafica3.Location = new System.Drawing.Point(1012, 173);
            this.grafica3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafica3.Name = "grafica3";
            this.grafica3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.grafica3.Size = new System.Drawing.Size(421, 369);
            this.grafica3.TabIndex = 24;
            this.grafica3.Text = "chart1";
            this.grafica3.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1144, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "EXPORTAR A EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(65, 518);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1483, 217);
            this.grid.TabIndex = 26;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(1383, 47);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(132, 22);
            this.txtTiempo.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1617, 750);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grafica3);
            this.Controls.Add(this.grafica2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.puerto1);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.grafica1);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.Puertos);
            this.Controls.Add(this.tz2);
            this.Controls.Add(this.ty2);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.tz1);
            this.Controls.Add(this.ty1);
            this.Controls.Add(this.tx1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort puerto;
        private System.Windows.Forms.TextBox tx1;
        private System.Windows.Forms.TextBox ty1;
        private System.Windows.Forms.TextBox tz1;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.TextBox ty2;
        private System.Windows.Forms.TextBox tz2;
        private System.Windows.Forms.ComboBox Puertos;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica1;
        private System.IO.Ports.SerialPort puerto2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox z3;
        private System.Windows.Forms.ComboBox puerto1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtTiempo;
    }
}

