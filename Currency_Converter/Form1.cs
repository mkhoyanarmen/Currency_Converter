using WebApi.Controllers;
using WebApi.Models;

namespace Currency_Converter
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }
        public Root rate { get; set; }
        private async void frmConverter_Load(object sender, EventArgs e)
        {
            await RatesController.GetAllData();
            rate = RatesController.rates;

            cbFromCurrency.Items.Add("USD");
            cbFromCurrency.SelectedItem = cbFromCurrency.Items[0];
            cbFromCurrency.Items.Add("AMD");
            cbFromCurrency.Items.Add("RUB");
            cbFromCurrency.Items.Add("EUR");

            cbToCurrency.Items.Add("USD");
            cbToCurrency.Items.Add("AMD");
            cbToCurrency.SelectedItem = cbToCurrency.Items[1];
            cbToCurrency.Items.Add("RUB");
            cbToCurrency.Items.Add("EUR");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtFromCurrency.Text == "")
            {
                MessageBox.Show("Please, input the number", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Convert(cbFromCurrency.SelectedItem.ToString(), cbToCurrency.SelectedItem.ToString());
        }
        void Convert(string fromCurrency, string toCurrency)
        {
            double fromAmount = 0, toAmount = 0;
            switch (fromCurrency)
            {
                case "USD":
                    fromAmount = rate.rates.USD;
                    break;
                case "AMD":
                    fromAmount = rate.rates.AMD;
                    break;
                case "RUB":
                    fromAmount = rate.rates.RUB;
                    break;
                case "EUR":
                    fromAmount = rate.rates.EUR;
                    break;
            }
            switch (toCurrency)
            {
                case "USD":
                    toAmount = rate.rates.USD;
                    break;
                case "AMD":
                    toAmount = rate.rates.AMD;
                    break;
                case "RUB":
                    toAmount = rate.rates.RUB;
                    break;
                case "EUR":
                    toAmount = rate.rates.EUR;
                    break;
            }
            double converted = (double.Parse(txtFromCurrency.Text) / fromAmount) * toAmount;
            if (int.Parse(txtFromCurrency.Text) <= 2)
                txtToCurrency.Text = Math.Round(converted, 6).ToString();
            else
                txtToCurrency.Text = Math.Round(converted,2).ToString();
        }

        private void txtFromCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != 8;
        }
    }
}