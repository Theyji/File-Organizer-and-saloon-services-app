namespace Lab3B
{
    partial class Form_theyji_hair_shop
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
            this.groupBox_hairdressers = new System.Windows.Forms.GroupBox();
            this.comboBox_hairdressers = new System.Windows.Forms.ComboBox();
            this.groupBox_selected_services = new System.Windows.Forms.GroupBox();
            this.listBox_selected_services_list = new System.Windows.Forms.ListBox();
            this.groupBox_charged_items = new System.Windows.Forms.GroupBox();
            this.textBox_charged_items = new System.Windows.Forms.TextBox();
            this.groupBox_price = new System.Windows.Forms.GroupBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_total_price = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add_service = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_calculate_total_price = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_hairdressers.SuspendLayout();
            this.groupBox_selected_services.SuspendLayout();
            this.groupBox_charged_items.SuspendLayout();
            this.groupBox_price.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_hairdressers
            // 
            this.groupBox_hairdressers.Controls.Add(this.comboBox_hairdressers);
            this.groupBox_hairdressers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_hairdressers.Location = new System.Drawing.Point(26, 27);
            this.groupBox_hairdressers.Name = "groupBox_hairdressers";
            this.groupBox_hairdressers.Size = new System.Drawing.Size(342, 353);
            this.groupBox_hairdressers.TabIndex = 0;
            this.groupBox_hairdressers.TabStop = false;
            this.groupBox_hairdressers.Text = "Hairdressers";
            // 
            // comboBox_hairdressers
            // 
            this.comboBox_hairdressers.FormattingEnabled = true;
            this.comboBox_hairdressers.Location = new System.Drawing.Point(23, 50);
            this.comboBox_hairdressers.Name = "comboBox_hairdressers";
            this.comboBox_hairdressers.Size = new System.Drawing.Size(287, 39);
            this.comboBox_hairdressers.TabIndex = 0;
            // 
            // groupBox_selected_services
            // 
            this.groupBox_selected_services.Controls.Add(this.listBox_selected_services_list);
            this.groupBox_selected_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_selected_services.Location = new System.Drawing.Point(383, 38);
            this.groupBox_selected_services.Name = "groupBox_selected_services";
            this.groupBox_selected_services.Size = new System.Drawing.Size(354, 342);
            this.groupBox_selected_services.TabIndex = 1;
            this.groupBox_selected_services.TabStop = false;
            this.groupBox_selected_services.Text = "Select a Service:";
            // 
            // listBox_selected_services_list
            // 
            this.listBox_selected_services_list.FormattingEnabled = true;
            this.listBox_selected_services_list.ItemHeight = 31;
            this.listBox_selected_services_list.Location = new System.Drawing.Point(6, 37);
            this.listBox_selected_services_list.Name = "listBox_selected_services_list";
            this.listBox_selected_services_list.Size = new System.Drawing.Size(333, 283);
            this.listBox_selected_services_list.TabIndex = 0;
            // 
            // groupBox_charged_items
            // 
            this.groupBox_charged_items.Controls.Add(this.textBox_charged_items);
            this.groupBox_charged_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_charged_items.Location = new System.Drawing.Point(777, 38);
            this.groupBox_charged_items.Name = "groupBox_charged_items";
            this.groupBox_charged_items.Size = new System.Drawing.Size(320, 329);
            this.groupBox_charged_items.TabIndex = 2;
            this.groupBox_charged_items.TabStop = false;
            this.groupBox_charged_items.Text = "Charged Items:";
            // 
            // textBox_charged_items
            // 
            this.textBox_charged_items.Location = new System.Drawing.Point(6, 37);
            this.textBox_charged_items.Multiline = true;
            this.textBox_charged_items.Name = "textBox_charged_items";
            this.textBox_charged_items.ReadOnly = true;
            this.textBox_charged_items.Size = new System.Drawing.Size(297, 270);
            this.textBox_charged_items.TabIndex = 0;
            // 
            // groupBox_price
            // 
            this.groupBox_price.Controls.Add(this.textBox_price);
            this.groupBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_price.Location = new System.Drawing.Point(1135, 38);
            this.groupBox_price.Name = "groupBox_price";
            this.groupBox_price.Size = new System.Drawing.Size(228, 307);
            this.groupBox_price.TabIndex = 3;
            this.groupBox_price.TabStop = false;
            this.groupBox_price.Text = "Price:";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(15, 39);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(207, 249);
            this.textBox_price.TabIndex = 0;
            // 
            // label_total_price
            // 
            this.label_total_price.AutoSize = true;
            this.label_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_price.Location = new System.Drawing.Point(1010, 417);
            this.label_total_price.Name = "label_total_price";
            this.label_total_price.Size = new System.Drawing.Size(144, 31);
            this.label_total_price.TabIndex = 4;
            this.label_total_price.Text = "Total Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1179, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 31);
            this.textBox1.TabIndex = 5;
            // 
            // button_add_service
            // 
            this.button_add_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_service.ForeColor = System.Drawing.Color.Green;
            this.button_add_service.Location = new System.Drawing.Point(127, 552);
            this.button_add_service.Name = "button_add_service";
            this.button_add_service.Size = new System.Drawing.Size(214, 58);
            this.button_add_service.TabIndex = 6;
            this.button_add_service.Text = "Add Service";
            this.button_add_service.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.Orange;
            this.button_reset.Location = new System.Drawing.Point(859, 552);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(197, 58);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // button_calculate_total_price
            // 
            this.button_calculate_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calculate_total_price.ForeColor = System.Drawing.Color.Purple;
            this.button_calculate_total_price.Location = new System.Drawing.Point(438, 552);
            this.button_calculate_total_price.Name = "button_calculate_total_price";
            this.button_calculate_total_price.Size = new System.Drawing.Size(299, 58);
            this.button_calculate_total_price.TabIndex = 8;
            this.button_calculate_total_price.Text = "Calculate Total Price";
            this.button_calculate_total_price.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(1179, 552);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(184, 58);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // Form_theyji_hair_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 718);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_calculate_total_price);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_add_service);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_total_price);
            this.Controls.Add(this.groupBox_price);
            this.Controls.Add(this.groupBox_charged_items);
            this.Controls.Add(this.groupBox_selected_services);
            this.Controls.Add(this.groupBox_hairdressers);
            this.Name = "Form_theyji_hair_shop";
            this.Text = "Theyji Hair Shop";
            this.Load += new System.EventHandler(this.Form_theyji_hair_shop_Load);
            this.groupBox_hairdressers.ResumeLayout(false);
            this.groupBox_selected_services.ResumeLayout(false);
            this.groupBox_charged_items.ResumeLayout(false);
            this.groupBox_charged_items.PerformLayout();
            this.groupBox_price.ResumeLayout(false);
            this.groupBox_price.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_hairdressers;
        private System.Windows.Forms.ComboBox comboBox_hairdressers;
        private System.Windows.Forms.GroupBox groupBox_selected_services;
        private System.Windows.Forms.ListBox listBox_selected_services_list;
        private System.Windows.Forms.GroupBox groupBox_charged_items;
        private System.Windows.Forms.TextBox textBox_charged_items;
        private System.Windows.Forms.GroupBox groupBox_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_total_price;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add_service;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_calculate_total_price;
        private System.Windows.Forms.Button button_exit;
    }
}

