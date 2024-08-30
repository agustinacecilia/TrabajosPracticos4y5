using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrabajosPracticos4y5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGFuncion_Click(object sender, EventArgs e)
        {
            GenerarNumeros();
            UpdateChart("GenerarFuncion");
        }

        // Método para validar la entrada de los TextBox y generar números
        private void GenerarNumeros(string filtro = "todos")
        {
            listBoxNumeros.Items.Clear();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textBoxDesde.Text))
            {
                MessageBox.Show("El campo 'Desde' no puede estar vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxHasta.Text))
            {
                MessageBox.Show("El campo 'Hasta' no puede estar vacío.");
                return;
            }

            // Validar que los valores sean enteros
            int desde, hasta;
            if (!int.TryParse(textBoxDesde.Text, out desde) || !int.TryParse(textBoxHasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese solo números.");
                return;
            }

            // Validar que "Desde" no sea mayor que "Hasta"
            if (desde > hasta)
            {
                MessageBox.Show("'Desde' no puede ser mayor que 'Hasta'.");
                return;
            }

            // Generar números basados en el filtro seleccionado
            for (int i = desde; i <= hasta; i++)
            {
                if (filtro == "pares" && i % 2 == 0)
                {
                    listBoxNumeros.Items.Add(i);
                }
                else if (filtro == "impares" && i % 2 != 0)
                {
                    listBoxNumeros.Items.Add(i);
                }
                else if (filtro == "primos" && EsPrimo(i))
                {
                    listBoxNumeros.Items.Add(i);
                }
                else if (filtro == "todos")
                {
                    listBoxNumeros.Items.Add(i);
                }
            }
        }

        // Método para comprobar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) return false;
            }

            return true;
        }

        private void BNumerosPares_Click(object sender, EventArgs e)
        {
            GenerarNumeros(filtro: "pares");
            UpdateChart("Pares");
        }

        private void BNumerosImpares_Click(object sender, EventArgs e)
        {
            GenerarNumeros(filtro: "impares");
            UpdateChart("Impares");
        }
        private void BNumerosPrimos_Click(object sender, EventArgs e)
        {
            GenerarNumeros(filtro: "primos");
            UpdateChart("Primos");
        }

        private void listBoxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();
            textBoxDesde.Clear();
            textBoxHasta.Clear();
            chart1.Series.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateChart(string tipo)
        {
            chart1.Series.Clear(); // Limpiar las series anteriores
            Series serie = new Series("Números");

            // Cambiar el tipo de gráfico según el tipo de números seleccionado
            switch (tipo)
            {
                case "GenerarFuncion":
                    serie.ChartType = SeriesChartType.Area; // Gráfico de área como ejemplo para "Generar Función"
                    break;
                case "Pares":
                    serie.ChartType = SeriesChartType.Column; // Gráfico de columnas para números pares
                    break;
                case "Impares":
                    serie.ChartType = SeriesChartType.Line; // Gráfico de líneas para números impares
                    break;
                case "Primos":
                    serie.ChartType = SeriesChartType.Pie; // Gráfico de torta para números primos
                    break;
                default:
                    serie.ChartType = SeriesChartType.Column; // Gráfico por defecto
                    break;
            }

            // Agregar los valores al gráfico
            foreach (var item in listBoxNumeros.Items)
            {
                serie.Points.AddXY(item, Convert.ToInt32(item));
            }

            chart1.Series.Add(serie);
        }
    }
}
