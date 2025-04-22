namespace fBicycles.Designer.cs
{
    partial class Bike
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbWheelSize = new System.Windows.Forms.TextBox();
            this.tbFrameMaterial = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Розмір колеса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Матеріал рами";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вага";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ціна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Колір";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(277, 53);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(124, 22);
            this.tbBrand.TabIndex = 8;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(277, 100);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(124, 22);
            this.tbModel.TabIndex = 9;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(277, 146);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(124, 22);
            this.tbType.TabIndex = 10;
            // 
            // tbWheelSize
            // 
            this.tbWheelSize.Location = new System.Drawing.Point(277, 193);
            this.tbWheelSize.Name = "tbWheelSize";
            this.tbWheelSize.Size = new System.Drawing.Size(124, 22);
            this.tbWheelSize.TabIndex = 11;
            // 
            // tbFrameMaterial
            // 
            this.tbFrameMaterial.Location = new System.Drawing.Point(277, 242);
            this.tbFrameMaterial.Name = "tbFrameMaterial";
            this.tbFrameMaterial.Size = new System.Drawing.Size(124, 22);
            this.tbFrameMaterial.TabIndex = 12;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(277, 286);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(124, 22);
            this.tbWeight.TabIndex = 13;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(277, 336);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(124, 22);
            this.tbPrice.TabIndex = 14;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(277, 386);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(124, 22);
            this.tbColor.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ок";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 447);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbFrameMaterial);
            this.Controls.Add(this.tbWheelSize);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Дані про велосипед";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbWheelSize;
        private System.Windows.Forms.TextBox tbFrameMaterial;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}

