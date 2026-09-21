namespace order_food
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choose_food = new System.Windows.Forms.ComboBox();
            this.punjabi = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.type_p = new System.Windows.Forms.Panel();
            this.take_p = new System.Windows.Forms.RadioButton();
            this.charge_p = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.extra_p = new System.Windows.Forms.Panel();
            this.paneer_p = new System.Windows.Forms.CheckBox();
            this.drink_p = new System.Windows.Forms.CheckBox();
            this.cheese_p = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amt_p = new System.Windows.Forms.TextBox();
            this.qua_p = new System.Windows.Forms.TextBox();
            this.price_p = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.select_item_p = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chinese = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.type_c = new System.Windows.Forms.Panel();
            this.take_c = new System.Windows.Forms.RadioButton();
            this.charge_c = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.extra_c = new System.Windows.Forms.Panel();
            this.souc_c = new System.Windows.Forms.CheckBox();
            this.drink_c = new System.Windows.Forms.CheckBox();
            this.cheese_c = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.amt_c = new System.Windows.Forms.TextBox();
            this.qua_c = new System.Windows.Forms.TextBox();
            this.price_c = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.select_item_c = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.fastfood = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.type_f = new System.Windows.Forms.Panel();
            this.take_f = new System.Windows.Forms.RadioButton();
            this.charge_f = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.extra_f = new System.Windows.Forms.Panel();
            this.ketchp_f = new System.Windows.Forms.CheckBox();
            this.drink_f = new System.Windows.Forms.CheckBox();
            this.cheese_f = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.amt_f = new System.Windows.Forms.TextBox();
            this.qua_f = new System.Windows.Forms.TextBox();
            this.price_f = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.select_item_f = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.fastfood_total = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.chinese_total = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.punjabi_total = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.punjabi.SuspendLayout();
            this.type_p.SuspendLayout();
            this.extra_p.SuspendLayout();
            this.chinese.SuspendLayout();
            this.type_c.SuspendLayout();
            this.extra_c.SuspendLayout();
            this.fastfood.SuspendLayout();
            this.type_f.SuspendLayout();
            this.extra_f.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOOD ORDER SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHOOSE TYPE :-";
            // 
            // choose_food
            // 
            this.choose_food.FormattingEnabled = true;
            this.choose_food.Items.AddRange(new object[] {
            "PUNJABI",
            "CHINESE",
            "FAST FOOD"});
            this.choose_food.Location = new System.Drawing.Point(179, 51);
            this.choose_food.Name = "choose_food";
            this.choose_food.Size = new System.Drawing.Size(121, 21);
            this.choose_food.TabIndex = 2;
            this.choose_food.Text = "CHOOSE";
            this.choose_food.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // punjabi
            // 
            this.punjabi.BackColor = System.Drawing.Color.Brown;
            this.punjabi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.punjabi.Controls.Add(this.label10);
            this.punjabi.Controls.Add(this.punjabi_total);
            this.punjabi.Controls.Add(this.type_p);
            this.punjabi.Controls.Add(this.extra_p);
            this.punjabi.Controls.Add(this.amt_p);
            this.punjabi.Controls.Add(this.qua_p);
            this.punjabi.Controls.Add(this.price_p);
            this.punjabi.Controls.Add(this.label7);
            this.punjabi.Controls.Add(this.label6);
            this.punjabi.Controls.Add(this.select_item_p);
            this.punjabi.Controls.Add(this.label5);
            this.punjabi.Controls.Add(this.label3);
            this.punjabi.Controls.Add(this.label4);
            this.punjabi.Location = new System.Drawing.Point(30, 78);
            this.punjabi.Name = "punjabi";
            this.punjabi.Size = new System.Drawing.Size(270, 474);
            this.punjabi.TabIndex = 3;
            this.punjabi.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "TOTAL AMT :-";
            // 
            // type_p
            // 
            this.type_p.Controls.Add(this.take_p);
            this.type_p.Controls.Add(this.charge_p);
            this.type_p.Controls.Add(this.label9);
            this.type_p.Location = new System.Drawing.Point(17, 291);
            this.type_p.Name = "type_p";
            this.type_p.Size = new System.Drawing.Size(231, 82);
            this.type_p.TabIndex = 10;
            // 
            // take_p
            // 
            this.take_p.AutoSize = true;
            this.take_p.Location = new System.Drawing.Point(16, 55);
            this.take_p.Name = "take_p";
            this.take_p.Size = new System.Drawing.Size(115, 17);
            this.take_p.TabIndex = 0;
            this.take_p.TabStop = true;
            this.take_p.Text = "TAKE AWAY (₹20)";
            this.take_p.UseVisualStyleBackColor = true;
            // 
            // charge_p
            // 
            this.charge_p.AutoSize = true;
            this.charge_p.Location = new System.Drawing.Point(16, 22);
            this.charge_p.Name = "charge_p";
            this.charge_p.Size = new System.Drawing.Size(188, 17);
            this.charge_p.TabIndex = 0;
            this.charge_p.TabStop = true;
            this.charge_p.Text = "DINE IN (NO PACKING CHARGE)";
            this.charge_p.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "ORDER TYPE";
            // 
            // extra_p
            // 
            this.extra_p.Controls.Add(this.paneer_p);
            this.extra_p.Controls.Add(this.drink_p);
            this.extra_p.Controls.Add(this.cheese_p);
            this.extra_p.Controls.Add(this.label8);
            this.extra_p.Location = new System.Drawing.Point(17, 182);
            this.extra_p.Name = "extra_p";
            this.extra_p.Size = new System.Drawing.Size(231, 97);
            this.extra_p.TabIndex = 9;
            // 
            // paneer_p
            // 
            this.paneer_p.AutoSize = true;
            this.paneer_p.Location = new System.Drawing.Point(16, 67);
            this.paneer_p.Name = "paneer_p";
            this.paneer_p.Size = new System.Drawing.Size(136, 17);
            this.paneer_p.TabIndex = 8;
            this.paneer_p.Text = "EXTRA PANEER (₹10)";
            this.paneer_p.UseVisualStyleBackColor = true;
            // 
            // drink_p
            // 
            this.drink_p.AutoSize = true;
            this.drink_p.Location = new System.Drawing.Point(16, 45);
            this.drink_p.Name = "drink_p";
            this.drink_p.Size = new System.Drawing.Size(119, 17);
            this.drink_p.TabIndex = 8;
            this.drink_p.Text = "COLD DRINK (₹50)";
            this.drink_p.UseVisualStyleBackColor = true;
            // 
            // cheese_p
            // 
            this.cheese_p.AutoSize = true;
            this.cheese_p.Location = new System.Drawing.Point(16, 22);
            this.cheese_p.Name = "cheese_p";
            this.cheese_p.Size = new System.Drawing.Size(135, 17);
            this.cheese_p.TabIndex = 8;
            this.cheese_p.Text = "EXTRA CHEESE (₹30)";
            this.cheese_p.UseVisualStyleBackColor = true;
            this.cheese_p.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "EXTRA OPTION";
            // 
            // amt_p
            // 
            this.amt_p.Enabled = false;
            this.amt_p.Location = new System.Drawing.Point(111, 438);
            this.amt_p.Name = "amt_p";
            this.amt_p.Size = new System.Drawing.Size(87, 20);
            this.amt_p.TabIndex = 8;
            // 
            // qua_p
            // 
            this.qua_p.Location = new System.Drawing.Point(108, 149);
            this.qua_p.Name = "qua_p";
            this.qua_p.Size = new System.Drawing.Size(122, 20);
            this.qua_p.TabIndex = 8;
            this.qua_p.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // price_p
            // 
            this.price_p.Enabled = false;
            this.price_p.Location = new System.Drawing.Point(108, 117);
            this.price_p.Name = "price_p";
            this.price_p.Size = new System.Drawing.Size(122, 20);
            this.price_p.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "QUT :-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "PRICE (₹) :-";
            // 
            // select_item_p
            // 
            this.select_item_p.FormattingEnabled = true;
            this.select_item_p.Items.AddRange(new object[] {
            "PANEER SABJI",
            "PANEER TIKA ",
            "CHOLE KULCHE",
            "PANEER TAVA ",
            "PANEER BHURJI ",
            "NAN",
            "TAVA ROTI"});
            this.select_item_p.Location = new System.Drawing.Point(109, 84);
            this.select_item_p.Name = "select_item_p";
            this.select_item_p.Size = new System.Drawing.Size(121, 21);
            this.select_item_p.TabIndex = 6;
            this.select_item_p.Text = "CHOOSE";
            this.select_item_p.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SELECT ITEM :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "PUNJABI";
            // 
            // chinese
            // 
            this.chinese.BackColor = System.Drawing.Color.Teal;
            this.chinese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chinese.Controls.Add(this.label11);
            this.chinese.Controls.Add(this.chinese_total);
            this.chinese.Controls.Add(this.type_c);
            this.chinese.Controls.Add(this.extra_c);
            this.chinese.Controls.Add(this.amt_c);
            this.chinese.Controls.Add(this.qua_c);
            this.chinese.Controls.Add(this.price_c);
            this.chinese.Controls.Add(this.label14);
            this.chinese.Controls.Add(this.label15);
            this.chinese.Controls.Add(this.select_item_c);
            this.chinese.Controls.Add(this.label16);
            this.chinese.Controls.Add(this.label17);
            this.chinese.Controls.Add(this.label18);
            this.chinese.Location = new System.Drawing.Point(498, 78);
            this.chinese.Name = "chinese";
            this.chinese.Size = new System.Drawing.Size(270, 474);
            this.chinese.TabIndex = 4;
            this.chinese.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "TOTAL AMT :-";
            // 
            // type_c
            // 
            this.type_c.Controls.Add(this.take_c);
            this.type_c.Controls.Add(this.charge_c);
            this.type_c.Controls.Add(this.label12);
            this.type_c.Location = new System.Drawing.Point(17, 291);
            this.type_c.Name = "type_c";
            this.type_c.Size = new System.Drawing.Size(231, 82);
            this.type_c.TabIndex = 10;
            // 
            // take_c
            // 
            this.take_c.AutoSize = true;
            this.take_c.Location = new System.Drawing.Point(16, 55);
            this.take_c.Name = "take_c";
            this.take_c.Size = new System.Drawing.Size(115, 17);
            this.take_c.TabIndex = 0;
            this.take_c.TabStop = true;
            this.take_c.Text = "TAKE AWAY (₹20)";
            this.take_c.UseVisualStyleBackColor = true;
            // 
            // charge_c
            // 
            this.charge_c.AutoSize = true;
            this.charge_c.Location = new System.Drawing.Point(16, 22);
            this.charge_c.Name = "charge_c";
            this.charge_c.Size = new System.Drawing.Size(188, 17);
            this.charge_c.TabIndex = 0;
            this.charge_c.TabStop = true;
            this.charge_c.Text = "DINE IN (NO PACKING CHARGE)";
            this.charge_c.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "ORDER TYPE";
            // 
            // extra_c
            // 
            this.extra_c.Controls.Add(this.souc_c);
            this.extra_c.Controls.Add(this.drink_c);
            this.extra_c.Controls.Add(this.cheese_c);
            this.extra_c.Controls.Add(this.label13);
            this.extra_c.Location = new System.Drawing.Point(17, 182);
            this.extra_c.Name = "extra_c";
            this.extra_c.Size = new System.Drawing.Size(231, 97);
            this.extra_c.TabIndex = 9;
            // 
            // souc_c
            // 
            this.souc_c.AutoSize = true;
            this.souc_c.Location = new System.Drawing.Point(16, 67);
            this.souc_c.Name = "souc_c";
            this.souc_c.Size = new System.Drawing.Size(129, 17);
            this.souc_c.TabIndex = 8;
            this.souc_c.Text = "EXTRA SOUCE (₹10)";
            this.souc_c.UseVisualStyleBackColor = true;
            // 
            // drink_c
            // 
            this.drink_c.AutoSize = true;
            this.drink_c.Location = new System.Drawing.Point(16, 45);
            this.drink_c.Name = "drink_c";
            this.drink_c.Size = new System.Drawing.Size(119, 17);
            this.drink_c.TabIndex = 8;
            this.drink_c.Text = "COLD DRINK (₹50)";
            this.drink_c.UseVisualStyleBackColor = true;
            // 
            // cheese_c
            // 
            this.cheese_c.AutoSize = true;
            this.cheese_c.Location = new System.Drawing.Point(16, 22);
            this.cheese_c.Name = "cheese_c";
            this.cheese_c.Size = new System.Drawing.Size(135, 17);
            this.cheese_c.TabIndex = 8;
            this.cheese_c.Text = "EXTRA CHEESE (₹30)";
            this.cheese_c.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, -1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "EXTRA OPTION";
            // 
            // amt_c
            // 
            this.amt_c.Enabled = false;
            this.amt_c.Location = new System.Drawing.Point(111, 438);
            this.amt_c.Name = "amt_c";
            this.amt_c.Size = new System.Drawing.Size(87, 20);
            this.amt_c.TabIndex = 8;
            // 
            // qua_c
            // 
            this.qua_c.Location = new System.Drawing.Point(108, 149);
            this.qua_c.Name = "qua_c";
            this.qua_c.Size = new System.Drawing.Size(122, 20);
            this.qua_c.TabIndex = 8;
            // 
            // price_c
            // 
            this.price_c.Enabled = false;
            this.price_c.Location = new System.Drawing.Point(108, 117);
            this.price_c.Name = "price_c";
            this.price_c.Size = new System.Drawing.Size(122, 20);
            this.price_c.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "QUT :-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "PRICE (₹) :-";
            // 
            // select_item_c
            // 
            this.select_item_c.FormattingEnabled = true;
            this.select_item_c.Items.AddRange(new object[] {
            "NOODLE",
            "MANCHURIYAN",
            "SEZWAN RICE",
            "CHINESE BHEL"});
            this.select_item_c.Location = new System.Drawing.Point(109, 84);
            this.select_item_c.Name = "select_item_c";
            this.select_item_c.Size = new System.Drawing.Size(121, 21);
            this.select_item_c.TabIndex = 6;
            this.select_item_c.Text = "CHOOSE";
            this.select_item_c.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "SELECT ITEM :-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(3, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "CHINESE";
            // 
            // fastfood
            // 
            this.fastfood.BackColor = System.Drawing.Color.Gray;
            this.fastfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastfood.Controls.Add(this.label19);
            this.fastfood.Controls.Add(this.fastfood_total);
            this.fastfood.Controls.Add(this.type_f);
            this.fastfood.Controls.Add(this.extra_f);
            this.fastfood.Controls.Add(this.amt_f);
            this.fastfood.Controls.Add(this.qua_f);
            this.fastfood.Controls.Add(this.price_f);
            this.fastfood.Controls.Add(this.label22);
            this.fastfood.Controls.Add(this.label23);
            this.fastfood.Controls.Add(this.select_item_f);
            this.fastfood.Controls.Add(this.label24);
            this.fastfood.Controls.Add(this.label25);
            this.fastfood.Controls.Add(this.label26);
            this.fastfood.Location = new System.Drawing.Point(924, 78);
            this.fastfood.Name = "fastfood";
            this.fastfood.Size = new System.Drawing.Size(270, 474);
            this.fastfood.TabIndex = 13;
            this.fastfood.Visible = false;
            this.fastfood.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 441);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "TOTAL AMT :-";
            // 
            // type_f
            // 
            this.type_f.Controls.Add(this.take_f);
            this.type_f.Controls.Add(this.charge_f);
            this.type_f.Controls.Add(this.label20);
            this.type_f.Location = new System.Drawing.Point(17, 291);
            this.type_f.Name = "type_f";
            this.type_f.Size = new System.Drawing.Size(231, 82);
            this.type_f.TabIndex = 10;
            // 
            // take_f
            // 
            this.take_f.AutoSize = true;
            this.take_f.Location = new System.Drawing.Point(16, 55);
            this.take_f.Name = "take_f";
            this.take_f.Size = new System.Drawing.Size(115, 17);
            this.take_f.TabIndex = 0;
            this.take_f.TabStop = true;
            this.take_f.Text = "TAKE AWAY (₹20)";
            this.take_f.UseVisualStyleBackColor = true;
            // 
            // charge_f
            // 
            this.charge_f.AutoSize = true;
            this.charge_f.Location = new System.Drawing.Point(16, 22);
            this.charge_f.Name = "charge_f";
            this.charge_f.Size = new System.Drawing.Size(188, 17);
            this.charge_f.TabIndex = 0;
            this.charge_f.TabStop = true;
            this.charge_f.Text = "DINE IN (NO PACKING CHARGE)";
            this.charge_f.UseVisualStyleBackColor = true;
            this.charge_f.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(73, -2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "ORDER TYPE";
            // 
            // extra_f
            // 
            this.extra_f.Controls.Add(this.ketchp_f);
            this.extra_f.Controls.Add(this.drink_f);
            this.extra_f.Controls.Add(this.cheese_f);
            this.extra_f.Controls.Add(this.label21);
            this.extra_f.Location = new System.Drawing.Point(17, 182);
            this.extra_f.Name = "extra_f";
            this.extra_f.Size = new System.Drawing.Size(231, 97);
            this.extra_f.TabIndex = 9;
            // 
            // ketchp_f
            // 
            this.ketchp_f.AutoSize = true;
            this.ketchp_f.Location = new System.Drawing.Point(16, 67);
            this.ketchp_f.Name = "ketchp_f";
            this.ketchp_f.Size = new System.Drawing.Size(143, 17);
            this.ketchp_f.TabIndex = 8;
            this.ketchp_f.Text = "EXTRA KETCHUP (₹10)";
            this.ketchp_f.UseVisualStyleBackColor = true;
            // 
            // drink_f
            // 
            this.drink_f.AutoSize = true;
            this.drink_f.Location = new System.Drawing.Point(16, 45);
            this.drink_f.Name = "drink_f";
            this.drink_f.Size = new System.Drawing.Size(119, 17);
            this.drink_f.TabIndex = 8;
            this.drink_f.Text = "COLD DRINK (₹50)";
            this.drink_f.UseVisualStyleBackColor = true;
            // 
            // cheese_f
            // 
            this.cheese_f.AutoSize = true;
            this.cheese_f.Location = new System.Drawing.Point(16, 22);
            this.cheese_f.Name = "cheese_f";
            this.cheese_f.Size = new System.Drawing.Size(135, 17);
            this.cheese_f.TabIndex = 8;
            this.cheese_f.Text = "EXTRA CHEESE (₹30)";
            this.cheese_f.UseVisualStyleBackColor = true;
            this.cheese_f.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(70, -1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "EXTRA OPTION";
            // 
            // amt_f
            // 
            this.amt_f.Enabled = false;
            this.amt_f.Location = new System.Drawing.Point(111, 438);
            this.amt_f.Name = "amt_f";
            this.amt_f.Size = new System.Drawing.Size(87, 20);
            this.amt_f.TabIndex = 8;
            // 
            // qua_f
            // 
            this.qua_f.Location = new System.Drawing.Point(108, 149);
            this.qua_f.Name = "qua_f";
            this.qua_f.Size = new System.Drawing.Size(122, 20);
            this.qua_f.TabIndex = 8;
            // 
            // price_f
            // 
            this.price_f.Enabled = false;
            this.price_f.Location = new System.Drawing.Point(108, 117);
            this.price_f.Name = "price_f";
            this.price_f.Size = new System.Drawing.Size(122, 20);
            this.price_f.TabIndex = 8;
            this.price_f.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "QUT :-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "PRICE (₹) :-";
            // 
            // select_item_f
            // 
            this.select_item_f.FormattingEnabled = true;
            this.select_item_f.Items.AddRange(new object[] {
            "BURGER",
            "PIZZA ",
            "PANI PURI",
            "SANDWICH"});
            this.select_item_f.Location = new System.Drawing.Point(109, 84);
            this.select_item_f.Name = "select_item_f";
            this.select_item_f.Size = new System.Drawing.Size(121, 21);
            this.select_item_f.TabIndex = 6;
            this.select_item_f.Text = "CHOOSE";
            this.select_item_f.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "SELECT ITEM :-";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Teal;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(3, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(128, 24);
            this.label25.TabIndex = 0;
            this.label25.Text = "FAST FOOD";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = global::order_food.Properties.Resources.icons8_exit_40;
            this.Exit.Location = new System.Drawing.Point(699, 568);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(106, 55);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "EXIT";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Image = global::order_food.Properties.Resources.icons8_clean_48;
            this.Clear.Location = new System.Drawing.Point(457, 568);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(106, 55);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "CLEAR";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // fastfood_total
            // 
            this.fastfood_total.Image = global::order_food.Properties.Resources.icons8_bill_30;
            this.fastfood_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fastfood_total.Location = new System.Drawing.Point(87, 379);
            this.fastfood_total.Name = "fastfood_total";
            this.fastfood_total.Size = new System.Drawing.Size(82, 38);
            this.fastfood_total.TabIndex = 11;
            this.fastfood_total.Text = "TOTAL";
            this.fastfood_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fastfood_total.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fastfood_total.UseVisualStyleBackColor = true;
            this.fastfood_total.Click += new System.EventHandler(this.button3_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Image = global::order_food.Properties.Resources.icons8_burger_70;
            this.label26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label26.Location = new System.Drawing.Point(178, 6);
            this.label26.MaximumSize = new System.Drawing.Size(100, 100);
            this.label26.MinimumSize = new System.Drawing.Size(70, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 70);
            this.label26.TabIndex = 4;
            // 
            // chinese_total
            // 
            this.chinese_total.Image = global::order_food.Properties.Resources.icons8_bill_30;
            this.chinese_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chinese_total.Location = new System.Drawing.Point(87, 379);
            this.chinese_total.Name = "chinese_total";
            this.chinese_total.Size = new System.Drawing.Size(82, 38);
            this.chinese_total.TabIndex = 11;
            this.chinese_total.Text = "TOTAL";
            this.chinese_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chinese_total.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chinese_total.UseVisualStyleBackColor = true;
            this.chinese_total.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Image = global::order_food.Properties.Resources.icons8_noodles_70;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Location = new System.Drawing.Point(178, 6);
            this.label18.MaximumSize = new System.Drawing.Size(100, 100);
            this.label18.MinimumSize = new System.Drawing.Size(70, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 70);
            this.label18.TabIndex = 4;
            // 
            // punjabi_total
            // 
            this.punjabi_total.Image = global::order_food.Properties.Resources.icons8_bill_30;
            this.punjabi_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.punjabi_total.Location = new System.Drawing.Point(87, 379);
            this.punjabi_total.Name = "punjabi_total";
            this.punjabi_total.Size = new System.Drawing.Size(82, 38);
            this.punjabi_total.TabIndex = 11;
            this.punjabi_total.Text = "TOTAL";
            this.punjabi_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.punjabi_total.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.punjabi_total.UseVisualStyleBackColor = true;
            this.punjabi_total.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::order_food.Properties.Resources.WhatsApp_Image_2026_08_11_at_10_39_54_PM__3__removebg_preview;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(178, 6);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.MinimumSize = new System.Drawing.Size(70, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 70);
            this.label4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 635);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.fastfood);
            this.Controls.Add(this.chinese);
            this.Controls.Add(this.choose_food);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punjabi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.punjabi.ResumeLayout(false);
            this.punjabi.PerformLayout();
            this.type_p.ResumeLayout(false);
            this.type_p.PerformLayout();
            this.extra_p.ResumeLayout(false);
            this.extra_p.PerformLayout();
            this.chinese.ResumeLayout(false);
            this.chinese.PerformLayout();
            this.type_c.ResumeLayout(false);
            this.type_c.PerformLayout();
            this.extra_c.ResumeLayout(false);
            this.extra_c.PerformLayout();
            this.fastfood.ResumeLayout(false);
            this.fastfood.PerformLayout();
            this.type_f.ResumeLayout(false);
            this.type_f.PerformLayout();
            this.extra_f.ResumeLayout(false);
            this.extra_f.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choose_food;
        private System.Windows.Forms.Panel punjabi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox select_item_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox qua_p;
        private System.Windows.Forms.TextBox price_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel extra_p;
        private System.Windows.Forms.CheckBox paneer_p;
        private System.Windows.Forms.CheckBox drink_p;
        private System.Windows.Forms.CheckBox cheese_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel type_p;
        private System.Windows.Forms.RadioButton take_p;
        private System.Windows.Forms.RadioButton charge_p;
        private System.Windows.Forms.Button punjabi_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amt_p;
        private System.Windows.Forms.Panel chinese;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button chinese_total;
        private System.Windows.Forms.Panel type_c;
        private System.Windows.Forms.RadioButton take_c;
        private System.Windows.Forms.RadioButton charge_c;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel extra_c;
        private System.Windows.Forms.CheckBox souc_c;
        private System.Windows.Forms.CheckBox drink_c;
        private System.Windows.Forms.CheckBox cheese_c;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox amt_c;
        private System.Windows.Forms.TextBox qua_c;
        private System.Windows.Forms.TextBox price_c;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox select_item_c;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel fastfood;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button fastfood_total;
        private System.Windows.Forms.Panel type_f;
        private System.Windows.Forms.RadioButton take_f;
        private System.Windows.Forms.RadioButton charge_f;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel extra_f;
        private System.Windows.Forms.CheckBox ketchp_f;
        private System.Windows.Forms.CheckBox drink_f;
        private System.Windows.Forms.CheckBox cheese_f;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox amt_f;
        private System.Windows.Forms.TextBox qua_f;
        private System.Windows.Forms.TextBox price_f;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox select_item_f;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

