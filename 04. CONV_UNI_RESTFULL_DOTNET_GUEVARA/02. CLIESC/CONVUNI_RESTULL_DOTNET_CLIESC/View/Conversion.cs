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

            unidades = new Dictionary<string, string>
            {
                { "Pascal (PA)", "pa" },
                { "Bar (BAR)", "bar" },
                { "Psi (PSI)", "psi" },
                { "Atmósfera (ATM)", "atm" },
                { "Torr (TORR)", "mmhg" }
            };

            comboBox1.Items.AddRange(unidades.Keys.ToArray());
            comboBox2.Items.AddRange(unidades.Keys.ToArray());

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
            await ConvertirValoresAsync();
        }
        private async Task ConvertirValoresAsync()
        {
            if (string.IsNullOrEmpty(valor.Text) || !double.TryParse(valor.Text, out double parsedValue))
            {
                respuesta.Text = "Por favor, introduce un valor válido.";
                return;
            }

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                respuesta.Text = "Selecciona ambas unidades.";
                return;
            }

            string fromUnit = comboBox1.SelectedItem.ToString();
            string toUnit = comboBox2.SelectedItem.ToString();

            // Validar existencia en el diccionario
            if (!unidades.TryGetValue(fromUnit, out string fromUnitValue) ||
                !unidades.TryGetValue(toUnit, out string toUnitValue))
            {
                respuesta.Text = "Error al obtener las unidades seleccionadas.";
                return;
            }

            try
            {
                var result = await _convController.Convertir(new Model.ConversionRequest
                {
                    Value = parsedValue,
                    FromUnit = fromUnitValue,
                    ToUnit = toUnitValue
                });

                respuesta.Text = result;
            }
            catch (Exception ex)
            {
                respuesta.Text = $"Error: {ex.Message}";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
