using pr7;
using System;
using System.Windows.Forms;

namespace fBicycles.Designer.cs
{
    public partial class Bike : Form
    {
        private Bicycle bicycle;

        public Bike(ref Bicycle bicycle)
        {
            InitializeComponent();
            this.bicycle = bicycle;
        }
        private void btnCancel_Click(object sender, EventArgs e)  // очищує всі поля
        {
            tbBrand.Clear();
            tbModel.Clear();
            tbType.Clear();
            tbWheelSize.Clear();
            tbFrameMaterial.Clear();
            tbWeight.Clear();
            tbPrice.Clear();
            tbColor.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // перевірка всі поля заповнені?
            if (string.IsNullOrWhiteSpace(tbBrand.Text) || string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbType.Text) || string.IsNullOrWhiteSpace(tbWheelSize.Text) ||
                string.IsNullOrWhiteSpace(tbFrameMaterial.Text) || string.IsNullOrWhiteSpace(tbWeight.Text) ||
                string.IsNullOrWhiteSpace(tbPrice.Text) || string.IsNullOrWhiteSpace(tbColor.Text))
            {
                MessageBox.Show("заповни всі поля", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            if (!double.TryParse(tbWheelSize.Text, out double wheelSize) || //перевірка числові поля?
                !double.TryParse(tbWeight.Text, out double weight) ||
                !double.TryParse(tbPrice.Text, out double price))
            {
                MessageBox.Show("розмір колеса, вага і ціна — тільки числа", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            bicycle.brand = tbBrand.Text;                             //запис значень
            bicycle.model = tbModel.Text;
            bicycle.type = tbType.Text;
            bicycle.wheelSize = wheelSize;
            bicycle.frameMaterial = tbFrameMaterial.Text;
            bicycle.weight = weight;
            bicycle.price = price;
            bicycle.color = tbColor.Text;

            DialogResult = DialogResult.OK;                         //закрити форму з OK
        }
    }
}
