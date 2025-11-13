namespace PizzaProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupSizeO = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Size_RadioLargButton = new System.Windows.Forms.RadioButton();
            this.Size_RadioMeduimButton = new System.Windows.Forms.RadioButton();
            this.Size_RadioSmallButton = new System.Windows.Forms.RadioButton();
            this.GroupToppingsO = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Toppings_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.Toppings_Olives = new System.Windows.Forms.CheckBox();
            this.Toppings_Onion = new System.Windows.Forms.CheckBox();
            this.Toppings_Tomatoes = new System.Windows.Forms.CheckBox();
            this.Toppings_Mushrooms = new System.Windows.Forms.CheckBox();
            this.Toppings_ExtraChees = new System.Windows.Forms.CheckBox();
            this.GroupCrustTypeO = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CrustType_ThickCrust = new System.Windows.Forms.RadioButton();
            this.CrustType_ThinCrust = new System.Windows.Forms.RadioButton();
            this.GroupWhereToEatO = new Guna.UI2.WinForms.Guna2GroupBox();
            this.WTE_TakeOut = new System.Windows.Forms.RadioButton();
            this.WTE_EatIn = new System.Windows.Forms.RadioButton();
            this.PriceOrder = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ChangePrice = new System.Windows.Forms.Label();
            this.GroupOrderSummary = new Guna.UI2.WinForms.Guna2GroupBox();
            this.OrSum_LableTextWhereYouEat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_LableTextCrustType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_LableTextToppings = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_LableTextSize = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_WhereToEat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_CrustType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_Topping = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OrSum_Size = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LableText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GroupButtonsO = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ResetFormButton = new Guna.UI2.WinForms.Guna2Button();
            this.OrderPizzaButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MessageBox_ConfirmOrder = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageBoxShowSuccesebleOrder = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GroupSizeO.SuspendLayout();
            this.GroupToppingsO.SuspendLayout();
            this.GroupCrustTypeO.SuspendLayout();
            this.GroupWhereToEatO.SuspendLayout();
            this.PriceOrder.SuspendLayout();
            this.GroupOrderSummary.SuspendLayout();
            this.GroupButtonsO.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupSizeO
            // 
            this.GroupSizeO.BackColor = System.Drawing.Color.Transparent;
            this.GroupSizeO.BorderColor = System.Drawing.Color.Black;
            this.GroupSizeO.BorderRadius = 66;
            this.GroupSizeO.BorderThickness = 0;
            this.GroupSizeO.Controls.Add(this.Size_RadioLargButton);
            this.GroupSizeO.Controls.Add(this.Size_RadioMeduimButton);
            this.GroupSizeO.Controls.Add(this.Size_RadioSmallButton);
            this.GroupSizeO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupSizeO.CustomBorderColor = System.Drawing.Color.Black;
            this.GroupSizeO.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupSizeO.FillColor = System.Drawing.Color.Transparent;
            this.GroupSizeO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupSizeO.ForeColor = System.Drawing.SystemColors.Menu;
            this.GroupSizeO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GroupSizeO.Location = new System.Drawing.Point(29, 137);
            this.GroupSizeO.Name = "GroupSizeO";
            this.GroupSizeO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupSizeO.Size = new System.Drawing.Size(215, 206);
            this.GroupSizeO.TabIndex = 0;
            this.GroupSizeO.Tag = "short";
            this.GroupSizeO.Text = "Size";
            this.GroupSizeO.Click += new System.EventHandler(this.GroupSizeO_Click);
            // 
            // Size_RadioLargButton
            // 
            this.Size_RadioLargButton.AutoSize = true;
            this.Size_RadioLargButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Size_RadioLargButton.Location = new System.Drawing.Point(14, 168);
            this.Size_RadioLargButton.Name = "Size_RadioLargButton";
            this.Size_RadioLargButton.Size = new System.Drawing.Size(59, 24);
            this.Size_RadioLargButton.TabIndex = 2;
            this.Size_RadioLargButton.Text = "Larg";
            this.Size_RadioLargButton.UseVisualStyleBackColor = true;
            this.Size_RadioLargButton.CheckedChanged += new System.EventHandler(this.RadioLargButton_CheckedChanged);
            // 
            // Size_RadioMeduimButton
            // 
            this.Size_RadioMeduimButton.AutoSize = true;
            this.Size_RadioMeduimButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Size_RadioMeduimButton.Location = new System.Drawing.Point(14, 121);
            this.Size_RadioMeduimButton.Name = "Size_RadioMeduimButton";
            this.Size_RadioMeduimButton.Size = new System.Drawing.Size(85, 24);
            this.Size_RadioMeduimButton.TabIndex = 1;
            this.Size_RadioMeduimButton.Text = "Meduim";
            this.Size_RadioMeduimButton.UseVisualStyleBackColor = true;
            this.Size_RadioMeduimButton.CheckedChanged += new System.EventHandler(this.RadioMeduimButton_CheckedChanged);
            // 
            // Size_RadioSmallButton
            // 
            this.Size_RadioSmallButton.AutoSize = true;
            this.Size_RadioSmallButton.BackColor = System.Drawing.Color.Transparent;
            this.Size_RadioSmallButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Size_RadioSmallButton.Checked = true;
            this.Size_RadioSmallButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_RadioSmallButton.Location = new System.Drawing.Point(14, 69);
            this.Size_RadioSmallButton.Name = "Size_RadioSmallButton";
            this.Size_RadioSmallButton.Size = new System.Drawing.Size(67, 24);
            this.Size_RadioSmallButton.TabIndex = 0;
            this.Size_RadioSmallButton.TabStop = true;
            this.Size_RadioSmallButton.Text = "Small";
            this.Size_RadioSmallButton.UseVisualStyleBackColor = false;
            this.Size_RadioSmallButton.CheckedChanged += new System.EventHandler(this.RadioSmallButton_CheckedChanged);
            // 
            // GroupToppingsO
            // 
            this.GroupToppingsO.BackColor = System.Drawing.Color.Transparent;
            this.GroupToppingsO.BorderColor = System.Drawing.Color.Black;
            this.GroupToppingsO.BorderRadius = 66;
            this.GroupToppingsO.BorderThickness = 0;
            this.GroupToppingsO.Controls.Add(this.Toppings_GreenPeppers);
            this.GroupToppingsO.Controls.Add(this.Toppings_Olives);
            this.GroupToppingsO.Controls.Add(this.Toppings_Onion);
            this.GroupToppingsO.Controls.Add(this.Toppings_Tomatoes);
            this.GroupToppingsO.Controls.Add(this.Toppings_Mushrooms);
            this.GroupToppingsO.Controls.Add(this.Toppings_ExtraChees);
            this.GroupToppingsO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupToppingsO.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupToppingsO.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupToppingsO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupToppingsO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupToppingsO.ForeColor = System.Drawing.Color.White;
            this.GroupToppingsO.Location = new System.Drawing.Point(330, 137);
            this.GroupToppingsO.Name = "GroupToppingsO";
            this.GroupToppingsO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupToppingsO.Size = new System.Drawing.Size(338, 206);
            this.GroupToppingsO.TabIndex = 1;
            this.GroupToppingsO.Tag = "short";
            this.GroupToppingsO.Text = "Toppings";
            this.GroupToppingsO.Click += new System.EventHandler(this.GroupToppingsO_Click);
            // 
            // Toppings_GreenPeppers
            // 
            this.Toppings_GreenPeppers.AutoSize = true;
            this.Toppings_GreenPeppers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Toppings_GreenPeppers.Location = new System.Drawing.Point(175, 150);
            this.Toppings_GreenPeppers.Name = "Toppings_GreenPeppers";
            this.Toppings_GreenPeppers.Size = new System.Drawing.Size(126, 24);
            this.Toppings_GreenPeppers.TabIndex = 10;
            this.Toppings_GreenPeppers.Text = "Green Peppers";
            this.Toppings_GreenPeppers.UseVisualStyleBackColor = true;
            this.Toppings_GreenPeppers.CheckedChanged += new System.EventHandler(this.Toppings_GreenPeppers_CheckedChanged);
            // 
            // Toppings_Olives
            // 
            this.Toppings_Olives.AutoSize = true;
            this.Toppings_Olives.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Toppings_Olives.Location = new System.Drawing.Point(175, 104);
            this.Toppings_Olives.Name = "Toppings_Olives";
            this.Toppings_Olives.Size = new System.Drawing.Size(71, 24);
            this.Toppings_Olives.TabIndex = 8;
            this.Toppings_Olives.Text = "Olives";
            this.Toppings_Olives.UseVisualStyleBackColor = true;
            this.Toppings_Olives.CheckedChanged += new System.EventHandler(this.Toppings_Olives_CheckedChanged);
            // 
            // Toppings_Onion
            // 
            this.Toppings_Onion.AutoSize = true;
            this.Toppings_Onion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Toppings_Onion.Location = new System.Drawing.Point(175, 60);
            this.Toppings_Onion.Name = "Toppings_Onion";
            this.Toppings_Onion.Size = new System.Drawing.Size(71, 24);
            this.Toppings_Onion.TabIndex = 6;
            this.Toppings_Onion.Text = "Onion";
            this.Toppings_Onion.UseVisualStyleBackColor = true;
            this.Toppings_Onion.CheckedChanged += new System.EventHandler(this.Toppings_Onion_CheckedChanged);
            // 
            // Toppings_Tomatoes
            // 
            this.Toppings_Tomatoes.AutoSize = true;
            this.Toppings_Tomatoes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Toppings_Tomatoes.Location = new System.Drawing.Point(36, 150);
            this.Toppings_Tomatoes.Name = "Toppings_Tomatoes";
            this.Toppings_Tomatoes.Size = new System.Drawing.Size(96, 24);
            this.Toppings_Tomatoes.TabIndex = 9;
            this.Toppings_Tomatoes.Text = "Tomatoes";
            this.Toppings_Tomatoes.UseVisualStyleBackColor = true;
            this.Toppings_Tomatoes.CheckedChanged += new System.EventHandler(this.Toppings_Tomatoes_CheckedChanged);
            // 
            // Toppings_Mushrooms
            // 
            this.Toppings_Mushrooms.AutoSize = true;
            this.Toppings_Mushrooms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Toppings_Mushrooms.Location = new System.Drawing.Point(36, 104);
            this.Toppings_Mushrooms.Name = "Toppings_Mushrooms";
            this.Toppings_Mushrooms.Size = new System.Drawing.Size(108, 24);
            this.Toppings_Mushrooms.TabIndex = 7;
            this.Toppings_Mushrooms.Text = "Mushrooms";
            this.Toppings_Mushrooms.UseVisualStyleBackColor = true;
            this.Toppings_Mushrooms.CheckedChanged += new System.EventHandler(this.Toppings_Mushrooms_CheckedChanged);
            // 
            // Toppings_ExtraChees
            // 
            this.Toppings_ExtraChees.AutoSize = true;
            this.Toppings_ExtraChees.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Toppings_ExtraChees.Location = new System.Drawing.Point(36, 60);
            this.Toppings_ExtraChees.Name = "Toppings_ExtraChees";
            this.Toppings_ExtraChees.Size = new System.Drawing.Size(107, 24);
            this.Toppings_ExtraChees.TabIndex = 5;
            this.Toppings_ExtraChees.Text = "Extra Chees";
            this.Toppings_ExtraChees.UseVisualStyleBackColor = true;
            this.Toppings_ExtraChees.CheckedChanged += new System.EventHandler(this.Toppings_ExtraChees_CheckedChanged);
            // 
            // GroupCrustTypeO
            // 
            this.GroupCrustTypeO.BackColor = System.Drawing.Color.Transparent;
            this.GroupCrustTypeO.BorderColor = System.Drawing.Color.Black;
            this.GroupCrustTypeO.BorderRadius = 66;
            this.GroupCrustTypeO.BorderThickness = 0;
            this.GroupCrustTypeO.Controls.Add(this.CrustType_ThickCrust);
            this.GroupCrustTypeO.Controls.Add(this.CrustType_ThinCrust);
            this.GroupCrustTypeO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupCrustTypeO.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupCrustTypeO.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupCrustTypeO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupCrustTypeO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupCrustTypeO.ForeColor = System.Drawing.Color.White;
            this.GroupCrustTypeO.Location = new System.Drawing.Point(43, 376);
            this.GroupCrustTypeO.Name = "GroupCrustTypeO";
            this.GroupCrustTypeO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupCrustTypeO.Size = new System.Drawing.Size(176, 179);
            this.GroupCrustTypeO.TabIndex = 2;
            this.GroupCrustTypeO.Tag = "short";
            this.GroupCrustTypeO.Text = "Crust Type";
            this.GroupCrustTypeO.Click += new System.EventHandler(this.GroupCrustTypeO_Click);
            // 
            // CrustType_ThickCrust
            // 
            this.CrustType_ThickCrust.AutoSize = true;
            this.CrustType_ThickCrust.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrustType_ThickCrust.Location = new System.Drawing.Point(20, 95);
            this.CrustType_ThickCrust.Name = "CrustType_ThickCrust";
            this.CrustType_ThickCrust.Size = new System.Drawing.Size(101, 24);
            this.CrustType_ThickCrust.TabIndex = 4;
            this.CrustType_ThickCrust.Text = "Thick Crust";
            this.CrustType_ThickCrust.UseVisualStyleBackColor = true;
            this.CrustType_ThickCrust.CheckedChanged += new System.EventHandler(this.CrustType_ThickCrust_CheckedChanged);
            // 
            // CrustType_ThinCrust
            // 
            this.CrustType_ThinCrust.AutoSize = true;
            this.CrustType_ThinCrust.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CrustType_ThinCrust.Checked = true;
            this.CrustType_ThinCrust.Location = new System.Drawing.Point(20, 49);
            this.CrustType_ThinCrust.Name = "CrustType_ThinCrust";
            this.CrustType_ThinCrust.Size = new System.Drawing.Size(95, 24);
            this.CrustType_ThinCrust.TabIndex = 3;
            this.CrustType_ThinCrust.TabStop = true;
            this.CrustType_ThinCrust.Text = "Thin Crust";
            this.CrustType_ThinCrust.UseVisualStyleBackColor = true;
            this.CrustType_ThinCrust.CheckedChanged += new System.EventHandler(this.CrustType_ThinCrust_CheckedChanged);
            // 
            // GroupWhereToEatO
            // 
            this.GroupWhereToEatO.BackColor = System.Drawing.Color.Transparent;
            this.GroupWhereToEatO.BorderColor = System.Drawing.Color.Black;
            this.GroupWhereToEatO.BorderRadius = 20;
            this.GroupWhereToEatO.BorderThickness = 0;
            this.GroupWhereToEatO.Controls.Add(this.WTE_TakeOut);
            this.GroupWhereToEatO.Controls.Add(this.WTE_EatIn);
            this.GroupWhereToEatO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupWhereToEatO.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupWhereToEatO.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupWhereToEatO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupWhereToEatO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupWhereToEatO.ForeColor = System.Drawing.Color.White;
            this.GroupWhereToEatO.Location = new System.Drawing.Point(330, 376);
            this.GroupWhereToEatO.Name = "GroupWhereToEatO";
            this.GroupWhereToEatO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupWhereToEatO.Size = new System.Drawing.Size(287, 73);
            this.GroupWhereToEatO.TabIndex = 3;
            this.GroupWhereToEatO.Tag = "short";
            this.GroupWhereToEatO.Text = "Where To Eat";
            // 
            // WTE_TakeOut
            // 
            this.WTE_TakeOut.AutoSize = true;
            this.WTE_TakeOut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WTE_TakeOut.Location = new System.Drawing.Point(140, 35);
            this.WTE_TakeOut.Name = "WTE_TakeOut";
            this.WTE_TakeOut.Size = new System.Drawing.Size(87, 24);
            this.WTE_TakeOut.TabIndex = 12;
            this.WTE_TakeOut.Text = "Take Out";
            this.WTE_TakeOut.UseVisualStyleBackColor = true;
            this.WTE_TakeOut.CheckedChanged += new System.EventHandler(this.WTE_TakeOut_CheckedChanged);
            // 
            // WTE_EatIn
            // 
            this.WTE_EatIn.AutoSize = true;
            this.WTE_EatIn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WTE_EatIn.Checked = true;
            this.WTE_EatIn.Location = new System.Drawing.Point(45, 35);
            this.WTE_EatIn.Name = "WTE_EatIn";
            this.WTE_EatIn.Size = new System.Drawing.Size(67, 24);
            this.WTE_EatIn.TabIndex = 11;
            this.WTE_EatIn.TabStop = true;
            this.WTE_EatIn.Text = "Eat In";
            this.WTE_EatIn.UseVisualStyleBackColor = true;
            this.WTE_EatIn.CheckedChanged += new System.EventHandler(this.WTE_EatIn_CheckedChanged);
            // 
            // PriceOrder
            // 
            this.PriceOrder.BackColor = System.Drawing.Color.Transparent;
            this.PriceOrder.BorderColor = System.Drawing.Color.Black;
            this.PriceOrder.BorderRadius = 66;
            this.PriceOrder.BorderThickness = 0;
            this.PriceOrder.Controls.Add(this.ChangePrice);
            this.PriceOrder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PriceOrder.CustomBorderColor = System.Drawing.Color.Transparent;
            this.PriceOrder.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.PriceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PriceOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceOrder.ForeColor = System.Drawing.Color.White;
            this.PriceOrder.Location = new System.Drawing.Point(780, 489);
            this.PriceOrder.Name = "PriceOrder";
            this.PriceOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PriceOrder.Size = new System.Drawing.Size(260, 114);
            this.PriceOrder.TabIndex = 4;
            this.PriceOrder.Text = "Total Price:";
            // 
            // ChangePrice
            // 
            this.ChangePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChangePrice.BackColor = System.Drawing.Color.Transparent;
            this.ChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePrice.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePrice.ForeColor = System.Drawing.Color.Transparent;
            this.ChangePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePrice.Location = new System.Drawing.Point(3, 31);
            this.ChangePrice.Name = "ChangePrice";
            this.ChangePrice.Size = new System.Drawing.Size(175, 54);
            this.ChangePrice.TabIndex = 1;
            this.ChangePrice.Tag = "short";
            this.ChangePrice.Text = "0";
            this.ChangePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangePrice.UseCompatibleTextRendering = true;
            this.ChangePrice.Click += new System.EventHandler(this.ChangePrice_Click);
            // 
            // GroupOrderSummary
            // 
            this.GroupOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.GroupOrderSummary.BorderColor = System.Drawing.Color.Black;
            this.GroupOrderSummary.BorderRadius = 66;
            this.GroupOrderSummary.BorderThickness = 0;
            this.GroupOrderSummary.Controls.Add(this.OrSum_LableTextWhereYouEat);
            this.GroupOrderSummary.Controls.Add(this.OrSum_LableTextCrustType);
            this.GroupOrderSummary.Controls.Add(this.OrSum_LableTextToppings);
            this.GroupOrderSummary.Controls.Add(this.OrSum_LableTextSize);
            this.GroupOrderSummary.Controls.Add(this.OrSum_WhereToEat);
            this.GroupOrderSummary.Controls.Add(this.OrSum_CrustType);
            this.GroupOrderSummary.Controls.Add(this.OrSum_Topping);
            this.GroupOrderSummary.Controls.Add(this.OrSum_Size);
            this.GroupOrderSummary.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupOrderSummary.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupOrderSummary.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupOrderSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupOrderSummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupOrderSummary.ForeColor = System.Drawing.Color.White;
            this.GroupOrderSummary.Location = new System.Drawing.Point(674, 137);
            this.GroupOrderSummary.Name = "GroupOrderSummary";
            this.GroupOrderSummary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupOrderSummary.Size = new System.Drawing.Size(382, 328);
            this.GroupOrderSummary.TabIndex = 5;
            this.GroupOrderSummary.Tag = "short";
            this.GroupOrderSummary.Text = "Order Summary";
            // 
            // OrSum_LableTextWhereYouEat
            // 
            this.OrSum_LableTextWhereYouEat.AutoSize = false;
            this.OrSum_LableTextWhereYouEat.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextWhereYouEat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_LableTextWhereYouEat.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextWhereYouEat.Location = new System.Drawing.Point(16, 274);
            this.OrSum_LableTextWhereYouEat.Name = "OrSum_LableTextWhereYouEat";
            this.OrSum_LableTextWhereYouEat.Size = new System.Drawing.Size(147, 38);
            this.OrSum_LableTextWhereYouEat.TabIndex = 7;
            this.OrSum_LableTextWhereYouEat.Text = null;
            // 
            // OrSum_LableTextCrustType
            // 
            this.OrSum_LableTextCrustType.AutoSize = false;
            this.OrSum_LableTextCrustType.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextCrustType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_LableTextCrustType.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextCrustType.Location = new System.Drawing.Point(109, 200);
            this.OrSum_LableTextCrustType.Name = "OrSum_LableTextCrustType";
            this.OrSum_LableTextCrustType.Size = new System.Drawing.Size(175, 30);
            this.OrSum_LableTextCrustType.TabIndex = 6;
            this.OrSum_LableTextCrustType.Tag = "byte";
            this.OrSum_LableTextCrustType.Text = null;
            // 
            // OrSum_LableTextToppings
            // 
            this.OrSum_LableTextToppings.AutoSize = false;
            this.OrSum_LableTextToppings.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextToppings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_LableTextToppings.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextToppings.Location = new System.Drawing.Point(19, 121);
            this.OrSum_LableTextToppings.Name = "OrSum_LableTextToppings";
            this.OrSum_LableTextToppings.Size = new System.Drawing.Size(363, 85);
            this.OrSum_LableTextToppings.TabIndex = 5;
            this.OrSum_LableTextToppings.Text = "No  Toppings";
            this.OrSum_LableTextToppings.Click += new System.EventHandler(this.OrSum_LableTextToppings_Click);
            // 
            // OrSum_LableTextSize
            // 
            this.OrSum_LableTextSize.AutoSize = false;
            this.OrSum_LableTextSize.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_LableTextSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_LableTextSize.Location = new System.Drawing.Point(70, 60);
            this.OrSum_LableTextSize.Name = "OrSum_LableTextSize";
            this.OrSum_LableTextSize.Size = new System.Drawing.Size(120, 22);
            this.OrSum_LableTextSize.TabIndex = 4;
            this.OrSum_LableTextSize.Text = null;
            this.OrSum_LableTextSize.Click += new System.EventHandler(this.LableTextSize_Click);
            // 
            // OrSum_WhereToEat
            // 
            this.OrSum_WhereToEat.AutoSize = false;
            this.OrSum_WhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_WhereToEat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_WhereToEat.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_WhereToEat.Location = new System.Drawing.Point(19, 246);
            this.OrSum_WhereToEat.Name = "OrSum_WhereToEat";
            this.OrSum_WhereToEat.Size = new System.Drawing.Size(144, 22);
            this.OrSum_WhereToEat.TabIndex = 3;
            this.OrSum_WhereToEat.Text = "Where To Eat:";
            this.OrSum_WhereToEat.Click += new System.EventHandler(this.OrSum_WhereToEat_Click);
            // 
            // OrSum_CrustType
            // 
            this.OrSum_CrustType.AutoSize = false;
            this.OrSum_CrustType.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_CrustType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_CrustType.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_CrustType.Location = new System.Drawing.Point(19, 200);
            this.OrSum_CrustType.Name = "OrSum_CrustType";
            this.OrSum_CrustType.Size = new System.Drawing.Size(116, 22);
            this.OrSum_CrustType.TabIndex = 2;
            this.OrSum_CrustType.Text = "Crust Type:";
            // 
            // OrSum_Topping
            // 
            this.OrSum_Topping.AutoSize = false;
            this.OrSum_Topping.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_Topping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_Topping.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_Topping.Location = new System.Drawing.Point(19, 95);
            this.OrSum_Topping.Name = "OrSum_Topping";
            this.OrSum_Topping.Size = new System.Drawing.Size(90, 22);
            this.OrSum_Topping.TabIndex = 1;
            this.OrSum_Topping.Text = "Toppings: ";
            this.OrSum_Topping.Click += new System.EventHandler(this.OrSum_Topping_Click);
            // 
            // OrSum_Size
            // 
            this.OrSum_Size.AutoSize = false;
            this.OrSum_Size.BackColor = System.Drawing.Color.Transparent;
            this.OrSum_Size.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrSum_Size.ForeColor = System.Drawing.Color.Transparent;
            this.OrSum_Size.Location = new System.Drawing.Point(19, 60);
            this.OrSum_Size.Name = "OrSum_Size";
            this.OrSum_Size.Size = new System.Drawing.Size(57, 22);
            this.OrSum_Size.TabIndex = 0;
            this.OrSum_Size.Text = "Size:";
            // 
            // LableText
            // 
            this.LableText.AutoSize = false;
            this.LableText.BackColor = System.Drawing.Color.Transparent;
            this.LableText.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableText.ForeColor = System.Drawing.Color.SeaShell;
            this.LableText.Location = new System.Drawing.Point(198, 12);
            this.LableText.Name = "LableText";
            this.LableText.Size = new System.Drawing.Size(628, 87);
            this.LableText.TabIndex = 6;
            this.LableText.Text = "Make Your Pizza";
            // 
            // GroupButtonsO
            // 
            this.GroupButtonsO.BackColor = System.Drawing.Color.Transparent;
            this.GroupButtonsO.BorderColor = System.Drawing.Color.Black;
            this.GroupButtonsO.BorderRadius = 66;
            this.GroupButtonsO.BorderThickness = 0;
            this.GroupButtonsO.Controls.Add(this.ResetFormButton);
            this.GroupButtonsO.Controls.Add(this.OrderPizzaButton);
            this.GroupButtonsO.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GroupButtonsO.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupButtonsO.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GroupButtonsO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupButtonsO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupButtonsO.ForeColor = System.Drawing.Color.White;
            this.GroupButtonsO.Location = new System.Drawing.Point(246, 489);
            this.GroupButtonsO.Name = "GroupButtonsO";
            this.GroupButtonsO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupButtonsO.Size = new System.Drawing.Size(422, 107);
            this.GroupButtonsO.TabIndex = 9;
            this.GroupButtonsO.Click += new System.EventHandler(this.GroupButtonsO_Click);
            // 
            // ResetFormButton
            // 
            this.ResetFormButton.Animated = true;
            this.ResetFormButton.AutoRoundedCorners = true;
            this.ResetFormButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetFormButton.BorderColor = System.Drawing.Color.Transparent;
            this.ResetFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetFormButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResetFormButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResetFormButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResetFormButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResetFormButton.FillColor = System.Drawing.Color.DimGray;
            this.ResetFormButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResetFormButton.ForeColor = System.Drawing.Color.White;
            this.ResetFormButton.IndicateFocus = true;
            this.ResetFormButton.Location = new System.Drawing.Point(202, 31);
            this.ResetFormButton.Name = "ResetFormButton";
            this.ResetFormButton.Size = new System.Drawing.Size(190, 45);
            this.ResetFormButton.TabIndex = 13;
            this.ResetFormButton.Text = "Reset Form";
            this.ResetFormButton.UseTransparentBackground = true;
            this.ResetFormButton.Click += new System.EventHandler(this.ResetFormButton_Click_1);
            // 
            // OrderPizzaButton
            // 
            this.OrderPizzaButton.Animated = true;
            this.OrderPizzaButton.AutoRoundedCorners = true;
            this.OrderPizzaButton.BackColor = System.Drawing.Color.Transparent;
            this.OrderPizzaButton.BorderColor = System.Drawing.Color.Transparent;
            this.OrderPizzaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderPizzaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OrderPizzaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OrderPizzaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OrderPizzaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OrderPizzaButton.FillColor = System.Drawing.Color.DimGray;
            this.OrderPizzaButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OrderPizzaButton.ForeColor = System.Drawing.Color.White;
            this.OrderPizzaButton.IndicateFocus = true;
            this.OrderPizzaButton.Location = new System.Drawing.Point(0, 31);
            this.OrderPizzaButton.Name = "OrderPizzaButton";
            this.OrderPizzaButton.Size = new System.Drawing.Size(196, 45);
            this.OrderPizzaButton.TabIndex = 14;
            this.OrderPizzaButton.Text = "Order Pizza";
            this.OrderPizzaButton.UseTransparentBackground = true;
            this.OrderPizzaButton.Click += new System.EventHandler(this.OrderPizzaButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1036, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 26);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1000, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 26);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // MessageBox_ConfirmOrder
            // 
            this.MessageBox_ConfirmOrder.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.MessageBox_ConfirmOrder.Caption = null;
            this.MessageBox_ConfirmOrder.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.MessageBox_ConfirmOrder.Parent = this;
            this.MessageBox_ConfirmOrder.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBox_ConfirmOrder.Text = "Confirm Order";
            // 
            // MessageBoxShowSuccesebleOrder
            // 
            this.MessageBoxShowSuccesebleOrder.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxShowSuccesebleOrder.Caption = null;
            this.MessageBoxShowSuccesebleOrder.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageBoxShowSuccesebleOrder.Parent = this;
            this.MessageBoxShowSuccesebleOrder.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxShowSuccesebleOrder.Text = "Order Plased Successfully";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(964, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(30, 26);
            this.guna2ControlBox3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1078, 627);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.GroupButtonsO);
            this.Controls.Add(this.LableText);
            this.Controls.Add(this.GroupOrderSummary);
            this.Controls.Add(this.GroupWhereToEatO);
            this.Controls.Add(this.PriceOrder);
            this.Controls.Add(this.GroupCrustTypeO);
            this.Controls.Add(this.GroupToppingsO);
            this.Controls.Add(this.GroupSizeO);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupSizeO.ResumeLayout(false);
            this.GroupSizeO.PerformLayout();
            this.GroupToppingsO.ResumeLayout(false);
            this.GroupToppingsO.PerformLayout();
            this.GroupCrustTypeO.ResumeLayout(false);
            this.GroupCrustTypeO.PerformLayout();
            this.GroupWhereToEatO.ResumeLayout(false);
            this.GroupWhereToEatO.PerformLayout();
            this.PriceOrder.ResumeLayout(false);
            this.GroupOrderSummary.ResumeLayout(false);
            this.GroupButtonsO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupSizeO;
        private Guna.UI2.WinForms.Guna2GroupBox GroupToppingsO;
        private Guna.UI2.WinForms.Guna2GroupBox GroupCrustTypeO;
        private Guna.UI2.WinForms.Guna2GroupBox GroupWhereToEatO;
        private Guna.UI2.WinForms.Guna2GroupBox PriceOrder;
        private Guna.UI2.WinForms.Guna2GroupBox GroupOrderSummary;
        private Guna.UI2.WinForms.Guna2HtmlLabel LableText;
        private Guna.UI2.WinForms.Guna2GroupBox GroupButtonsO;
        private Guna.UI2.WinForms.Guna2Button ResetFormButton;
        private Guna.UI2.WinForms.Guna2Button OrderPizzaButton;
        private System.Windows.Forms.RadioButton Size_RadioSmallButton;
        private System.Windows.Forms.RadioButton Size_RadioLargButton;
        private System.Windows.Forms.RadioButton Size_RadioMeduimButton;
        private System.Windows.Forms.RadioButton CrustType_ThickCrust;
        private System.Windows.Forms.RadioButton CrustType_ThinCrust;
        private System.Windows.Forms.RadioButton WTE_TakeOut;
        private System.Windows.Forms.RadioButton WTE_EatIn;
        private System.Windows.Forms.CheckBox Toppings_GreenPeppers;
        private System.Windows.Forms.CheckBox Toppings_Olives;
        private System.Windows.Forms.CheckBox Toppings_Onion;
        private System.Windows.Forms.CheckBox Toppings_Tomatoes;
        private System.Windows.Forms.CheckBox Toppings_Mushrooms;
        private System.Windows.Forms.CheckBox Toppings_ExtraChees;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_Size;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_WhereToEat;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_CrustType;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_Topping;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_LableTextSize;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_LableTextWhereYouEat;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_LableTextCrustType;
        private Guna.UI2.WinForms.Guna2HtmlLabel OrSum_LableTextToppings;
        private System.Windows.Forms.Label ChangePrice;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBox_ConfirmOrder;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxShowSuccesebleOrder;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
    }
}

