using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        short PriceTotal;
        short PriceOfSizes;
        short PriceOfCrustType;
        short PriceOfToppings;
        short tempTopping;
        string ToppingsOrders;
        public Form1()
        {
            InitializeComponent();
            PriceOfSizes = 0;
            PriceOfCrustType = 0;
            PriceOfToppings = 0;
            tempTopping = 0;
            ChangePrice.Tag = 0;
            GroupToppingsO.Tag = 0;
            ToppingsOrders = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            PriceOfCrustType = 5;
            PriceOfSizes = 5;
            PriceTotal = Convert.ToInt16(PriceOfSizes + PriceOfCrustType);
            ChangePrice.Text = PriceTotal.ToString();


            Size_RadioSmallButton.Checked = true;
            OrSum_LableTextSize.Text = "Small";

            WTE_EatIn.Checked = true;
            OrSum_LableTextWhereYouEat.Text = "Eat In";

            CrustType_ThinCrust.Checked = true;
            OrSum_LableTextCrustType.Text = "Thin Crust";


            ChangePrice.Text = "$" + PriceTotal.ToString();
            ChangePrice.ForeColor = Color.LawnGreen;


        }


        private void ResetAll() 
        {
            Size_RadioSmallButton.Checked = true;
            Size_RadioMeduimButton.Checked = false;
            Size_RadioLargButton.Checked = false;
            CrustType_ThinCrust.Checked = true;
            CrustType_ThickCrust.Checked = false;
            PriceTotal = 0;
            PriceOfSizes = 0;
            PriceOfCrustType = 0;
            PriceOfToppings = 0;
            tempTopping = 0;
            ToppingsOrders = "";
            OrSum_WhereToEat.Text = "";
            Toppings_ExtraChees.Checked = false;
            Toppings_GreenPeppers.Checked = false;
            Toppings_Mushrooms.Checked = false;
            Toppings_Olives.Checked = false;
            Toppings_Onion.Checked = false;
            Toppings_Tomatoes.Checked = false;



            PriceOfCrustType = 5;
            PriceOfSizes = 5;
            PriceTotal = Convert.ToInt16(PriceOfSizes + PriceOfCrustType);
            ChangePrice.Text = PriceTotal.ToString();



        }
        private void EnabledAllButtons()

        {

            GroupSizeO.Enabled = true;
            GroupToppingsO.Enabled = true;
            GroupCrustTypeO.Enabled = true;
            GroupWhereToEatO.Enabled = true;
            GroupWhereToEatO.FillColor = Color.Transparent;
            GroupCrustTypeO.FillColor = Color.Transparent;
            GroupToppingsO.FillColor = Color.Transparent;
            GroupSizeO.FillColor = Color.Transparent;



        }
        private void UnEnabledAllButtons() 
        
        {

            GroupSizeO.Enabled = false;
            GroupToppingsO.Enabled = false;
            GroupCrustTypeO.Enabled = false;
            GroupWhereToEatO.Enabled = false;

            GroupWhereToEatO.FillColor = Color.DarkRed;
            GroupCrustTypeO.BorderRadius = 20;

            GroupCrustTypeO.FillColor = Color.DarkRed;
            GroupCrustTypeO.BorderRadius = 20;

            GroupToppingsO.FillColor = Color.DarkRed;
            GroupToppingsO.BorderRadius = 20;

            GroupSizeO.FillColor = Color.DarkRed;
            GroupSizeO.BorderRadius = 20;
            


        }

        private void TotalPrice() 
        {

            PriceTotal = (short)(PriceOfToppings + PriceOfSizes + PriceOfCrustType);
            ChangePrice.Text = "$" + PriceTotal.ToString();
            ChangePrice.ForeColor = Color.LawnGreen;
        }
        private void _ChangePriceOfSize(short value)
        {

            GroupSizeO.Tag = value;
            PriceOfSizes = Convert.ToInt16(GroupSizeO.Tag);
            TotalPrice();

        }
        private void _ChangePriceOfCrustType(short value)
        {

            GroupCrustTypeO.Tag = value;
            PriceOfCrustType = Convert.ToInt16(GroupCrustTypeO.Tag);
           // ChangePrice.Text = PriceOfCrustType.ToString();
            TotalPrice();
        }


        private void _ChangePriceOfToppings(short value,string Text = "")
        {



            if(Text != "" && value > 0) 
            {

                ToppingsOrders = (ToppingsOrders == "") ? ToppingsOrders += Text : ToppingsOrders += ", "+Text;
                OrSum_LableTextToppings.Text = ToppingsOrders;

            }else if(value < 0&& Text != "") 
            {

                ToppingsOrders = ToppingsOrders.Replace(Text + ", ", "");
                if (ToppingsOrders != "") ToppingsOrders = ToppingsOrders.Replace(", " + Text, "");
                if (ToppingsOrders == Text) ToppingsOrders = ToppingsOrders.Replace(Text, "");


                OrSum_LableTextToppings.Text = ToppingsOrders;

            }



            tempTopping = Convert.ToInt16(GroupToppingsO.Tag);
            tempTopping += value;
            GroupToppingsO.Tag = tempTopping;


            PriceOfToppings = Convert.ToInt16(GroupToppingsO.Tag);
            //  ChangePrice.Text = PriceOfToppings.ToString();
            TotalPrice();
        }
     


        private void GroupSizeO_Click(object sender, EventArgs e)
        {

            

        }
        


        private void RadioSmallButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Size_RadioSmallButton.Checked == true) 
            {
                OrSum_LableTextSize.Text = "Small";
                _ChangePriceOfSize(5);
            }
           

        }
        private void RadioMeduimButton_CheckedChanged(object sender, EventArgs e)
        {

            if (Size_RadioMeduimButton.Checked == true)
            {
                OrSum_LableTextSize.Text = "Meduim";
                _ChangePriceOfSize(10);
            }
        }
        private void RadioLargButton_CheckedChanged(object sender, EventArgs e)
        {

            if (Size_RadioLargButton.Checked == true)
            {

                OrSum_LableTextSize.Text = "Larg";
                _ChangePriceOfSize(15);
            }
        }
     
        private void LableTextSize_Click(object sender, EventArgs e)
        {

        }



        private void GroupCrustTypeO_Click(object sender, EventArgs e)
        {

        }
        private void CrustType_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {

            if(CrustType_ThinCrust.Checked == true) 
            {
                OrSum_LableTextCrustType.Text = "Thin Crust";
                _ChangePriceOfCrustType(5);
            }

        }

        private void CrustType_ThickCrust_CheckedChanged(object sender, EventArgs e)
        {

            if (CrustType_ThickCrust.Checked == true)
            {
              
                OrSum_LableTextCrustType.Text = "Thick Crust";
                _ChangePriceOfCrustType(10);


            }

        }










 private void GroupToppingsO_Click(object sender, EventArgs e)
        {

        }


        private void Toppings_ExtraChees_CheckedChanged(object sender, EventArgs e)
        {

            if(Toppings_ExtraChees.Checked == true) 
            {

                _ChangePriceOfToppings(5, "Extra Chees");
            
            } else if(Toppings_ExtraChees.Checked == false) 
            {

                _ChangePriceOfToppings(-5, "Extra Chees");

            }


        }

        private void Toppings_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {

            if (Toppings_Mushrooms.Checked == true)
            {

                _ChangePriceOfToppings(5, "Mushrooms");

            }
            else
            {

                _ChangePriceOfToppings(-5, "Mushrooms");

            }


        }

        private void Toppings_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {


            if (Toppings_Tomatoes.Checked == true)
            {

                _ChangePriceOfToppings(5,"Tomatoes");

            }
            else 
            {

                _ChangePriceOfToppings(-5, "Tomatoes");

            }


        }

        private void Toppings_Onion_CheckedChanged(object sender, EventArgs e)
        {
            if (Toppings_Onion.Checked == true)
            {

                _ChangePriceOfToppings(5,"Onion");

            }
            else
            {

                _ChangePriceOfToppings(-5, "Onion");

            }

        }

        private void Toppings_Olives_CheckedChanged(object sender, EventArgs e)
        {
            if (Toppings_Olives.Checked == true)
            {

                _ChangePriceOfToppings(5,"Olives");

            }
            else 
            {

                _ChangePriceOfToppings(-5, "Olives");

            }

        }

        private void Toppings_GreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (Toppings_GreenPeppers.Checked == true)
            {

                _ChangePriceOfToppings(5,"Green Peppers");

            }
            else
            {

                _ChangePriceOfToppings(-5, "Green Peppers");

            }

        }

        private void OrSum_Topping_Click(object sender, EventArgs e)
        {

        }

        private void OrSum_LableTextToppings_Click(object sender, EventArgs e)
        {

          

        }

       





        private void GroupButtonsO_Click(object sender, EventArgs e)
        {

        }

        private void OrderPizzaButton_Click(object sender, EventArgs e)
        {




           
            if(DialogResult.Yes == MessageBox_ConfirmOrder.Show()) 
            {

                UnEnabledAllButtons();
                MessageBoxShowSuccesebleOrder.Show();

            }


        }

     

        private void GroupWhereToEatO_Click(object sender, EventArgs e)
        {

        }

        private void WTE_EatIn_CheckedChanged(object sender, EventArgs e)
        {

            OrSum_LableTextWhereYouEat.Text = "Eat In";

        }

        private void WTE_TakeOut_CheckedChanged(object sender, EventArgs e)
        {

            OrSum_LableTextWhereYouEat.Text = "Take Out";


        }

        private void ResetFormButton_Click_1(object sender, EventArgs e)
        {
            EnabledAllButtons();
            ResetAll();


        }

        private void OrSum_WhereToEat_Click(object sender, EventArgs e)
        {

        }

        private void ChangePrice_Click(object sender, EventArgs e)
        {

        }
    }



}
