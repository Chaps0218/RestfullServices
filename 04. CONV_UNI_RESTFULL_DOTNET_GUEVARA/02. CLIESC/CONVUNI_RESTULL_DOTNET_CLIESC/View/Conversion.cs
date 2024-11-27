using CONVUNI_RESTULL_DOTNET_CLIESC.Controller;
using CONVUNI_RESTULL_DOTNET_CLIESC.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVUNI_RESTULL_DOTNET_CLIESC.View
{
    public partial class Conversion : Form
    {
        private readonly ConversionController _convController;
        private readonly Dictionary<string, string> unidades;

        public Conversion()
        {
            InitializeComponent();
            _convController = new ConversionController();

            // Inicializamos el diccionario de unidades
            unidades = new Dictionary<string, string>
            {
                { "Pascal (Pa)", "pa" },
                { "Bar (bar)", "bar" },
                { "Psi (psi)", "psi" },
                { "Atmósfera (atm)", "atm" },
                { "Torr (torr)", "mmhg" }
            };

            // Poblar los ComboBox con las unidades legibles
            comboBox1.Items.AddRange(unidades.Keys.ToArray());
            comboBox2.Items.AddRange(unidades.Keys.ToArray());

            // Crear y agregar el botón de convertir
            Button btnConvertir = new Button
            {
                Text = "Convertir",
                Location = new Point(300, 250)
            };
            Controls.Add(btnConvertir);
            btnConvertir.Click += BtnConvertir_Click;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void BtnConvertir_Click(object sender, EventArgs e)
        {
            double value;
            if (!double.TryParse(valor.Text, out value))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            // Obtener las unidades seleccionadas (en su forma legible)
            string fromUnit = comboBox1.SelectedItem?.ToString();
            string toUnit = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(fromUnit) || string.IsNullOrWhiteSpace(toUnit))
            {
                MessageBox.Show("Por favor, seleccione las unidades de origen y destino.");
                return;
            }

            // Convertir las unidades legibles a las formas simplificadas
            string fromUnitSimplificado = unidades[fromUnit];
            string toUnitSimplificado = unidades[toUnit];

            // Crear la solicitud de conversión
            var conversionRequest = new ConversionRequest
            {
                Value = value,
                FromUnit = fromUnitSimplificado,
                ToUnit = toUnitSimplificado
            };

            // Realizar la conversión
            string result = await _convController.Convertir(conversionRequest);

            respuesta.Text = double.TryParse(result, out double resultValue)
            ? resultValue.ToString("F2")
            : result;
            // Mostrar el resultado en el Label llamado "respuesta"
            respuesta.Text = result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
