namespace CarRepairShopAccounting
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.customers = new System.Windows.Forms.Button();
            this.cars = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.things = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customers.Location = new System.Drawing.Point(451, 12);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(200, 150);
            this.customers.TabIndex = 0;
            this.customers.Text = "مشتری";
            this.customers.UseVisualStyleBackColor = false;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // cars
            // 
            this.cars.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cars.Location = new System.Drawing.Point(451, 180);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(200, 150);
            this.cars.TabIndex = 1;
            this.cars.Text = "خودرو";
            this.cars.UseVisualStyleBackColor = false;
            this.cars.Click += new System.EventHandler(this.cars_Click);
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.staff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staff.Location = new System.Drawing.Point(230, 12);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(200, 150);
            this.staff.TabIndex = 2;
            this.staff.Text = "کارکنان";
            this.staff.UseVisualStyleBackColor = false;
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bill.Location = new System.Drawing.Point(230, 180);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(200, 150);
            this.bill.TabIndex = 3;
            this.bill.Text = "فاکتور";
            this.bill.UseVisualStyleBackColor = false;
            // 
            // things
            // 
            this.things.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.things.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.things.Location = new System.Drawing.Point(12, 12);
            this.things.Name = "things";
            this.things.Size = new System.Drawing.Size(200, 150);
            this.things.TabIndex = 4;
            this.things.Text = "قطعات";
            this.things.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(12, 180);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(200, 150);
            this.exit.TabIndex = 5;
            this.exit.Text = "خروج از نرم افراز";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(669, 345);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.things);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.cars);
            this.Controls.Add(this.customers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel";
            this.Text = "Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button customers;
        private Button cars;
        private Button staff;
        private Button bill;
        private Button things;
        private Button exit;
    }
}