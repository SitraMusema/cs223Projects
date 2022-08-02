namespace AddInventory
{
    partial class Form1
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_invrntoryNumber = new System.Windows.Forms.Label();
            this.lbl_objName = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_object_Number = new System.Windows.Forms.TextBox();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.isAvaliable = new System.Windows.Forms.CheckBox();
            this.chk_list = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(32, 33);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(193, 32);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(36, 16);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            this.lbl_date.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_invrntoryNumber
            // 
            this.lbl_invrntoryNumber.AutoSize = true;
            this.lbl_invrntoryNumber.Location = new System.Drawing.Point(420, 33);
            this.lbl_invrntoryNumber.Name = "lbl_invrntoryNumber";
            this.lbl_invrntoryNumber.Size = new System.Drawing.Size(112, 16);
            this.lbl_invrntoryNumber.TabIndex = 2;
            this.lbl_invrntoryNumber.Text = "Inventory Number";
            // 
            // lbl_objName
            // 
            this.lbl_objName.AutoSize = true;
            this.lbl_objName.Location = new System.Drawing.Point(35, 108);
            this.lbl_objName.Name = "lbl_objName";
            this.lbl_objName.Size = new System.Drawing.Size(86, 16);
            this.lbl_objName.TabIndex = 3;
            this.lbl_objName.Text = "Object Name";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(38, 218);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(41, 16);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(269, 218);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 16);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(41, 338);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(125, 338);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(38, 53);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 22);
            this.txt_number.TabIndex = 8;
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Location = new System.Drawing.Point(423, 52);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(100, 22);
            this.txt_inventoryNumber.TabIndex = 10;
            this.txt_inventoryNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_object_Number
            // 
            this.txt_object_Number.Location = new System.Drawing.Point(38, 138);
            this.txt_object_Number.Name = "txt_object_Number";
            this.txt_object_Number.Size = new System.Drawing.Size(100, 22);
            this.txt_object_Number.TabIndex = 11;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(41, 247);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(100, 22);
            this.txt_count.TabIndex = 12;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(251, 247);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 13;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(174, 53);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 22);
            this.txt_date.TabIndex = 14;
            // 
            // isAvaliable
            // 
            this.isAvaliable.AutoSize = true;
            this.isAvaliable.Location = new System.Drawing.Point(231, 138);
            this.isAvaliable.Name = "isAvaliable";
            this.isAvaliable.Size = new System.Drawing.Size(91, 20);
            this.isAvaliable.TabIndex = 15;
            this.isAvaliable.Text = "Avalability";
            this.isAvaliable.UseVisualStyleBackColor = true;
            this.isAvaliable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_list
            // 
            this.chk_list.FormattingEnabled = true;
            this.chk_list.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.chk_list.Location = new System.Drawing.Point(506, 138);
            this.chk_list.Name = "chk_list";
            this.chk_list.Size = new System.Drawing.Size(120, 89);
            this.chk_list.TabIndex = 16;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(328, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 110);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(569, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chk_list);
            this.Controls.Add(this.isAvaliable);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_object_Number);
            this.Controls.Add(this.txt_inventoryNumber);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_objName);
            this.Controls.Add(this.lbl_invrntoryNumber);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_invrntoryNumber;
        private System.Windows.Forms.Label lbl_objName;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_inventoryNumber;
        private System.Windows.Forms.TextBox txt_object_Number;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.CheckBox isAvaliable;
        private System.Windows.Forms.CheckedListBox chk_list;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

