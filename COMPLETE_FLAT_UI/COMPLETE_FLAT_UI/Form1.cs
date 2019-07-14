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
using System.Threading;

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
        private SerialPort _serialPort;

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
                    MessageBox.Show("Error al seleccionar puerto");

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
                    LBX1.Text = "Esperando...";
                    LBX2.Text = "Esperando...";
                    LBX3.Text = "Esperando...";
                    LBY1.Text = "Esperando...";
                    LBY2.Text = "Esperando...";
                    LBY3.Text = "Esperando...";
                    LBZ1.Text = "Esperando...";
                    LBZ2.Text = "Esperando...";
                    LBZ3.Text = "Esperando...";
                    
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
                    LBX1.Text = Datos[0];
                    LBY1.Text = Datos[1];
                    LBZ1.Text = Datos[2];

                    LBX2.Text = Datos[3];
                    LBY2.Text = Datos[4];
                    LBZ2.Text = Datos[5];

                    LBX3.Text = Datos2[0];
                    LBY3.Text = Datos2[1];
                    LBZ3.Text = Datos2[2];

                    grafica1.Series[0].Points.AddXY(count, Datos[0]);
                    grafica1.Series[1].Points.AddXY(count, Datos[1]);
                    grafica1.Series[2].Points.AddXY(count, Datos[2]);

                    grafica2.Series[0].Points.AddXY(count, Datos[3]);
                    grafica2.Series[1].Points.AddXY(count, Datos[4]);
                    grafica2.Series[2].Points.AddXY(count, Datos[5]);

                    grafica3.Series[0].Points.AddXY(count, Datos2[0]);
                    grafica3.Series[1].Points.AddXY(count, Datos2[1]);
                    grafica3.Series[2].Points.AddXY(count, Datos2[2]);

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
                    LBX1.Text = "";
                    LBX2.Text = "";
                    LBX3.Text = "";
                    LBY1.Text = "";
                    LBY2.Text = "";
                    LBY3.Text = "";
                    LBZ1.Text = "";
                    LBZ2.Text = "";
                    LBZ3.Text = "";


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

        private void BTGuardarG_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string file;
            Bitmap bmp = new Bitmap(grafica1.Width, grafica1.Height);
            grafica1.DrawToBitmap(bmp, grafica1.DisplayRectangle);
            file = saveFileDialog1.FileName;
            bmp.Save(file);

            saveFileDialog2.ShowDialog();
            string file1;
            Bitmap bmp1 = new Bitmap(grafica2.Width, grafica2.Height);
            grafica2.DrawToBitmap(bmp1, grafica2.DisplayRectangle);
            file1 = saveFileDialog1.FileName;
            bmp1.Save(file1);

            saveFileDialog2.ShowDialog();
            string file2;
            Bitmap bmp2 = new Bitmap(grafica3.Width, grafica3.Height);
            grafica3.DrawToBitmap(bmp2, grafica3.DisplayRectangle);
            file2 = saveFileDialog1.FileName;
            bmp2.Save(file2);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            string number = "+526683962759";//numero a enviar el sms
            string message = "Se ha detectado un cierre en el programa"; //mensaje enviado

            //Reemplazar el COM7 por el puerto serial del GSM

            _serialPort = new SerialPort("COM27", 115200);

            Thread.Sleep(1000);

            _serialPort.Open();

            Thread.Sleep(1000);

            _serialPort.Write("AT+CMGF=1\r");

            Thread.Sleep(1000);

            _serialPort.Write("AT+CMGS=\"" + number + "\"\r\n");

            Thread.Sleep(1000);

            _serialPort.Write(message + "\x1A");

            Thread.Sleep(1000);

            MessageBox.Show("Status: Message sent");

            _serialPort.Close();
        }
    } 
    }




