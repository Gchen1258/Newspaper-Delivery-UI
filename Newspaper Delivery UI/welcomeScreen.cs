using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Newspaper_Delivery_UI
{
    public partial class welcomeScreen : Form
    {
        bool hidden = true,
            hidden1 = true,
            hidden2 = true,
            hidden3 = true,
            filled = false;
        const int panelWidth = 1080;
        public string sqlConn = "Data Source=DESKTOP-GQKF1H8\\SQLEXPRESS;Initial Catalog=Households;Integrated Security=True;Pooling=False";
        public welcomeScreen()
        {
            InitializeComponent();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            LoginTimer.Start();
        }



        private void welcomeScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'householdsDataSet.Address' table. You can move, or remove it, as needed.
            
            LoginPanel.Width = 0;
            pnlNewCust.Width = 0;
            pnlSearch.Width = 0;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                LoginPanel.Width = LoginPanel.Width + 10;
                if (LoginPanel.Width >= panelWidth)
                {
                    LoginTimer.Stop();
                    hidden = false;
                    this.Refresh();
                }
                this.LoginPanel.BringToFront();
            }
            else
            {
                LoginPanel.Width = LoginPanel.Width - 10;
                if (LoginPanel.Width <= 0)
                {
                    LoginTimer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        //Moveable borderless window
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void FNameField_TextChanged(object sender, EventArgs e)
        {
            if (!FNameField.Text.Any(c => char.IsLetter(c)))
                {
                Console.WriteLine("Name must be letters only!");   
                }
        }

        private void LastNameField_TextChanged(object sender, EventArgs e)
        {
            if (!LastNameField.Text.Any(c => char.IsLetter(c)))
            {
                Console.WriteLine("Name must be letters only!");
            }
        }

        private void StNumberField_TextChanged(object sender, EventArgs e)
        {
            if (!StNumberField.Text.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("Street number must be numbers only!");

            }
        }
        private void ZipField_TextChanged(object sender, EventArgs e)
        {
            if (!ZipField.Text.Any(c => char.IsDigit(c)))
            {
                Console.WriteLine("Zip code must be numbers only!");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            if (hidden2)
            {
                pnlSearch.Width = pnlSearch.Width + 10;
                if (pnlSearch.Width >= panelWidth)
                {
                    SearchTimer.Stop();
                    hidden2 = false;
                    this.Refresh();
                    this.pnlSearch.BringToFront();
                }
            }
            else
            {
                pnlSearch.Width = pnlSearch.Width - 10;
                if (pnlSearch.Width <= 0)
                {
                    SearchTimer.Stop();
                    hidden2 = true;
                    this.Refresh();
                }
            }
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerTimer.Start();
        }

        private void CustomerTimer_Tick(object sender, EventArgs e)
        {
            if (hidden1)
            {
                pnlNewCust.Width = pnlNewCust.Width + 10;
                if (pnlNewCust.Width >= panelWidth)
                {
                    CustomerTimer.Stop();
                    hidden1 = false;
                    this.Refresh();
                }
                this.pnlNewCust.BringToFront();
            }
            else
            {
                pnlNewCust.Width = pnlNewCust.Width - 10;
                if (pnlNewCust.Width <= 0)
                {
                    CustomerTimer.Stop();
                    hidden1 = true;
                    this.Refresh();
                }
            }
        }

        bool Filled()
        {
            filled = true;
            foreach (Control child in pnlNewCust.Controls)
            {
                if (child is TextBox)
                {
                    TextBox box = child as TextBox;
                    if (string.IsNullOrEmpty(box.Text) && child.Name != "ApartmentField")
                    {
                        filled = false;
                    }
                };
            }
            return filled;
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sqlConn);
            conn.Open();
            if (!Filled())
            {
                foreach (Control child in pnlNewCust.Controls)
                {
                    if (child is TextBox)
                    {
                        TextBox box = child as TextBox;
                        if (string.IsNullOrEmpty(box.Text) && child.Name != "ApartmentField")
                        {
                            string s = child.Name;
                            child.Text = null;
                            MessageBox.Show(s + " cannot be empty!", "Please enter a value");
                        }
                        
                    };
                }
            }


            if (Filled() && conn.State == System.Data.ConnectionState.Open)
            {
                string query = "Insert into (FirstName,LastName,StreetName,StreetNumber,PostalCode,Apartment)values('"+FNameField.Text
                    + "','" + LastNameField.Text + "','" +StNameField.Text + "','" + StNumberField.Text + "','" + ZipField.Text + "','"+ ApartmentField.Text.ToString()+"')" ;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added!");
            }
        }
    }
}
