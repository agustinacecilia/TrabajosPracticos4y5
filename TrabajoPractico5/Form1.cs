using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowTemplate.Height = 80;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxSaldo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que el saldo sea un número
            if (!decimal.TryParse(textBoxSaldo.Text, out decimal saldo))
            {
                MessageBox.Show("Por favor, ingrese un saldo válido.");
                return;
            }

            // Obtener los valores de los controles
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string sexo = RBHombre.Checked ? "Hombre" : "Mujer";
            string rutaFoto = textBoxFoto.Text;

            // Crear una fila en el DataGridView
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            row.Cells["CApellido"].Value = apellido;
            row.Cells["CNombre"].Value = nombre;
            row.Cells["CFechaNacimiento"].Value = fechaNacimiento.ToShortDateString();
            row.Cells["CSexo"].Value = sexo;
            row.Cells["CSaldo"].Value = saldo;
        
            row.Cells["CRuta"].Value = rutaFoto;

            // Cargar la imagen desde la ruta
            if (System.IO.File.Exists(rutaFoto))
            {
                row.Cells["CFoto"].Value = Image.FromFile(rutaFoto);
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la imagen en la ruta especificada.");
            }

            row.Cells["CRuta"].Value = rutaFoto;

            // Cambiar el color de fondo si el saldo es menor a 50
            if (saldo < 50)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }

            // Crear un botón de eliminar en la columna "Eliminar"
            DataGridViewButtonCell btnEliminar = new DataGridViewButtonCell();
            btnEliminar.Value = "Eliminar";
            row.Cells["CEliminar"] = btnEliminar;

            // Limpiar los controles después de agregar
            LimpiarControles();
        }

        // Método para limpiar los controles después de agregar un registro
        private void LimpiarControles()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxSaldo.Clear();
            textBoxFoto.Clear();
            pictureBox1.Image = null;
            RBHombre.Checked = true;  // Devolver a la selección predeterminada
            dateTimePicker1.Value = DateTime.Today;  // Restablecer la fecha al día actual
        }
    

        private void RBHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                textBoxFoto.Text = openFileDialog.FileName;
            }
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Verifica si la celda no es null y tiene un valor asignado
                var sexoCell = dataGridView1.CurrentRow.Cells["CSexo"];
                if (sexoCell.Value != null)
                {
                    string sexo = sexoCell.Value.ToString();

                    // Selecciona el RadioButton correspondiente
                    if (sexo == "Hombre")
                    {
                        RBHombre.Checked = true;
                    }
                    else if (sexo == "Mujer")
                    {
                        RBMujer.Checked = true;
                    }
                }
                else
                {
                    // Si no hay un valor en la celda, puedes optar por deseleccionar ambos RadioButton
                    RBHombre.Checked = false;
                    RBMujer.Checked = false;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda seleccionada sea la columna de eliminar
            if (e.ColumnIndex == dataGridView1.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                // Pedir confirmación al usuario
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
