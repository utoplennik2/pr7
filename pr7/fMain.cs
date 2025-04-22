using fBicycles.Designer.cs;
using System;
using System.Windows.Forms;

namespace pr7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvBicycles.AutoGenerateColumns = false;
            gvBicycles.Columns.Clear();
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "brand", Name = "марка" });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "model", Name = "модель" });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "type", Name = "тип" });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "wheelSize", Name = "розмір колеса", Width = 80 });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "frameMaterial", Name = "матеріал рами" });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "weight", Name = "вага", Width = 80 });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "price", Name = "ціна" });
            gvBicycles.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "color", Name = "колір" });

            gvBicycles.DataSource = bindSrcBicycles;

            bindSrcBicycles.Add(new Bicycle("Ghost", "А-3231", "шосейний", 20, "сталь", 11, 400000, "чорний"));

            OnResize(new EventArgs()); // адаптуємо форму
        }

        private void btnAdd_Click(object sender, EventArgs e)       //додавання нового велика
        {
            Bicycle bicycle = new Bicycle();
            Bike fb = new Bike(ref bicycle);
            if (fb.ShowDialog() == DialogResult.OK)
                bindSrcBicycles.Add(bicycle);
        }

        private void btnExit_Click(object sender, EventArgs e)       // вихід
        {
            Application.Exit();
        }

        private void btnClear_Click_1(object sender, EventArgs e)    //очищення списку
        {
            bindSrcBicycles.Clear();
            gvBicycles.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e) //редагування вибраного рядка
        {
            if (bindSrcBicycles.Position == -1)
            {
                MessageBox.Show("вибери велосипед для редагування!", "помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Bicycle bicycle = (Bicycle)bindSrcBicycles.List[bindSrcBicycles.Position];
            Bike fb = new Bike(ref bicycle);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.List[bindSrcBicycles.Position] = bicycle;
                gvBicycles.Refresh();
            }
        }

        private void btnDel_Click(object sender, EventArgs e) //видалення вибраного велика
        {
                bindSrcBicycles.RemoveCurrent();
                gvBicycles.Refresh();
        }
    }
}
