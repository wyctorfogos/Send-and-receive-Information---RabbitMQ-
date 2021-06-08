using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using IronPython.Hosting;


namespace Get_3D_Coordinates_values
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //      var Diretorio = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileName = "..\\..\\Receve_list.py";

            //     Process p = new Process();
            //     p.StartInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Microsoft Visual Studio\Shared\Python36_64\python.exe", fileName)
            //     {
            //         RedirectStandardOutput = true,
            //         UseShellExecute = false,
            //         CreateNoWindow = true
            //     };
            //     p.Start();

            //     string output = p.StandardOutput.ReadToEnd();
            //     p.WaitForExit();

            //     Console.WriteLine(output);

            //     Console.ReadLine();
            try
            {
                var Movimento = comboBox1.Text;
                var ID = numericUpDown1.Value;
                var python = Python.CreateEngine();
                python.ExecuteFile(fileName);

                Console.WriteLine(ID);
                Console.WriteLine(Movimento);
                MessageBox.Show("Dados enviados");
                Console.WriteLine("Dados enviados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta. Veja a conexão VPN e tente outra vez!");
            }
        }
    }
}