using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace acelerometro
{
    public partial class Form1 : Form
    {
        string Lectura;
        string Lectura2;
        string[] Datos;
        string[] Datos2;
        //Random val = new Random();
        int count = 0;
        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
        float tiempo = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void Puertos_DropDown(object sender, EventArgs e)
        {
            Puertos.Items.Clear();
            string[] puertosDisponibles = SerialPort.GetPortNames();
            foreach (string puerto in puertosDisponibles)
            {
                Puertos.Items.Add(puerto);
            }
        }

        private void puerto1_Click(object sender, EventArgs e)
        {
            puerto1.Items.Clear();
            string[] puertosDisponibles = SerialPort.GetPortNames();
            foreach (string puerto in puertosDisponibles)
            {
                puerto1.Items.Add(puerto);
            }
        }

        private void boton_Click(object sender, EventArgs e)
        {
            if (boton.Text == "Conectar")
            {
                try
                {
                    if (!puerto.IsOpen)
                    {
                        puerto.BaudRate = 9600;
                        puerto.PortName = Puertos.SelectedItem.ToString();
                        puerto.Open();
                        puerto2.BaudRate = 9600;
                        puerto2.PortName = puerto1.SelectedItem.ToString();
                        puerto2.Open();
                        boton.Text = "Desconectar";
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al seleccionar puerto ( ╯°□°)╯ ┻━━┻", "Aguas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (boton.Text == "Desconectar")
            {
                if (puerto.IsOpen)
                {
                    tiempo = 0;
                    puerto.Close();
                    boton.Text = "Conectar";
                    Puertos.Text = "";
                    Puertos.ResetText();
                    Puertos.SelectedItem = null;
                    puerto.Dispose();
                    puerto2.Close();
                    puerto1.Text = "";
                    puerto1.ResetText();
                    puerto1.SelectedItem = null;
                    puerto.Dispose();
                    tx1.Text = "";
                    ty1.Text = "";
                    tz1.Text = "";
                    tx2.Text = "";
                    ty2.Text = "";
                    tz2.Text = "";
                    x3.Text = "";
                    y3.Text = "";
                    z3.Text = "";
                    
                }
            }
        }

        private delegate void elDelegado(string leer, string[] datos);

        private void puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Lectura = puerto.ReadLine();
                Datos = Lectura.Split('/');
                BeginInvoke(new elDelegado(datosSeriales), Lectura, Datos);
            }
            catch (Exception)
            {

            }


        }

        private void puerto2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Lectura2 = puerto2.ReadLine();
                Datos2 = Lectura2.Split('/');
            }
            catch (Exception)
            {

            }
        }

        private void datosSeriales(string leer, string[] datos)
        {
            try
            {
                if (datos.Length == 6)
                {
                    tx1.Text = Datos[0];
                    ty1.Text = Datos[1];
                    tz1.Text = Datos[2];

                    tx2.Text = Datos[3];
                    ty2.Text = Datos[4];
                    tz2.Text = Datos[5];

                    x3.Text = Datos2[0];
                    y3.Text = Datos2[1];
                    z3.Text = Datos2[2];

                    grafica1.Series["x"].Points.AddXY(count, Datos[0]);
                    grafica1.Series["y"].Points.AddXY(count, Datos[1]);
                    grafica1.Series["z"].Points.AddXY(count, Datos[2]);

                    grafica2.Series["x"].Points.AddXY(count, Datos[3]);
                    grafica2.Series["y"].Points.AddXY(count, Datos[4]);
                    grafica2.Series["z"].Points.AddXY(count, Datos[5]);

                    grafica3.Series["x"].Points.AddXY(count, Datos2[0]);
                    grafica3.Series["y"].Points.AddXY(count, Datos2[1]);
                    grafica3.Series["z"].Points.AddXY(count, Datos2[2]);

                    txtTiempo.Text = Convert.ToString(tiempo);

                    if (excel.Visible == false)
                    {
                        if (puerto.IsOpen && puerto2.IsOpen)
                        {
                            tiempo += 0.1f;
                        }                       
                        for (int i = 0; i < 10; i++)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(grid);
                            row.Cells[0].Value = Datos[0];
                            row.Cells[1].Value = Datos[1];
                            row.Cells[2].Value = Datos[2];
                            row.Cells[3].Value = Datos[3];
                            row.Cells[4].Value = Datos[4];
                            row.Cells[5].Value = Datos[5];
                            row.Cells[6].Value = Datos2[0];
                            row.Cells[7].Value = Datos2[1];
                            row.Cells[8].Value = Datos2[2];
                            row.Cells[9].Value = tiempo + " Segundos";
                            grid.Rows.Add(row);
                        }
                    }
                    else
                    {
                        tiempo = 0;
                    }
                    
                    count++;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grafica1.Series.Add("x");
            grafica1.Series["x"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica1.Series["x"].Color = Color.Red;
            grafica1.Series.Add("y");
            grafica1.Series["y"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica1.Series["y"].Color = Color.Blue;
            grafica1.Series.Add("z");
            grafica1.Series["z"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica1.Series["z"].Color = Color.Green;

            grafica2.Series.Add("x");
            grafica2.Series["x"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica2.Series["x"].Color = Color.Red;
            grafica2.Series.Add("y");
            grafica2.Series["y"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica2.Series["y"].Color = Color.Blue;
            grafica2.Series.Add("z");
            grafica2.Series["z"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica2.Series["z"].Color = Color.Green;

            grafica3.Series.Add("x");
            grafica3.Series["x"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica3.Series["x"].Color = Color.Red;
            grafica3.Series.Add("y");
            grafica3.Series["y"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica3.Series["y"].Color = Color.Blue;
            grafica3.Series.Add("z");
            grafica3.Series["z"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            grafica3.Series["z"].Color = Color.Green;

            grid.ColumnCount = 13;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (puerto.IsOpen)
                {
                    tiempo = 0;
                    puerto.Close();
                    boton.Text = "Conectar";
                    Puertos.Text = "";
                    Puertos.ResetText();
                    Puertos.SelectedItem = null;
                    puerto.Dispose();
                    puerto2.Close();
                    puerto1.Text = "";
                    puerto1.ResetText();
                    puerto1.SelectedItem = null;
                    puerto.Dispose();
                    tx1.Text = "";
                    ty1.Text = "";
                    tz1.Text = "";
                    tx2.Text = "";
                    ty2.Text = "";
                    tz2.Text = "";
                    x3.Text = "";
                    y3.Text = "";
                    z3.Text = "";

                }
                excel.Application.Workbooks.Add(true);
                excel.Visible = true;

                int indiceCol = 0;
                int indiceFila = 0;

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    indiceFila++;
                    excel.Cells[indiceFila, indiceCol + 1] = grid.Rows[i].Cells[0].Value;
                    excel.Cells[indiceFila, indiceCol + 2] = grid.Rows[i].Cells[1].Value;
                    excel.Cells[indiceFila, indiceCol + 3] = grid.Rows[i].Cells[2].Value;
                    excel.Cells[indiceFila, indiceCol + 5] = grid.Rows[i].Cells[3].Value;
                    excel.Cells[indiceFila, indiceCol + 6] = grid.Rows[i].Cells[4].Value;
                    excel.Cells[indiceFila, indiceCol + 7] = grid.Rows[i].Cells[5].Value;
                    excel.Cells[indiceFila, indiceCol + 9] = grid.Rows[i].Cells[6].Value;
                    excel.Cells[indiceFila, indiceCol + 10] = grid.Rows[i].Cells[7].Value;
                    excel.Cells[indiceFila, indiceCol + 11] = grid.Rows[i].Cells[8].Value;
                    excel.Cells[indiceFila, indiceCol + 13] = grid.Rows[i].Cells[9].Value;
                }

                tiempo = 0;
        
            }
            catch (Exception)
            {

            }       
        }

        private void grafica1_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
    }




