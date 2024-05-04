namespace Prestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(Monto.Text);
            double interes = double.Parse(Interes.Text);
            double plazo = double.Parse(Periodo.Text);
            interes = interes / 100;

            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes, plazo))) / (Math.Pow(1 + interes, plazo) - 1);
            cuotaMensual = Math.Round(cuotaMensual, 2);
            Calcular.Text = cuotaMensual.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
