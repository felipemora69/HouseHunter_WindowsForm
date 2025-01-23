using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseHunterLesson2
{
    public partial class Form1 : Form
    {
        private string connectionString;


        List<HouseData> houses = new List<HouseData>();
        public Form1()
        {
            InitializeComponent();
            /*houses = new List<HouseData>
            {
                new HouseData { Id = 1, Address = "123 Maple St", PostalCode = "12345", ListPrice = 250000.0f },
                new HouseData { Id = 2, Address = "456 Oak St", PostalCode = "67890", ListPrice = 320000.0f },
                new HouseData { Id = 3, Address = "789 Pine St", PostalCode = "11223", ListPrice = 420000.0f },
                new HouseData { Id = 4, Address = "101 Elm St", PostalCode = "44556", ListPrice = 350000.0f },
                new HouseData { Id = 5, Address = "202 Birch St", PostalCode = "33445", ListPrice = 280000.0f },
                new HouseData { Id = 6, Address = "303 Cedar St", PostalCode = "55678", ListPrice = 290000.0f },
                new HouseData { Id = 7, Address = "404 Willow St", PostalCode = "66789", ListPrice = 375000.0f },
                new HouseData { Id = 8, Address = "505 Redwood St", PostalCode = "88990", ListPrice = 550000.0f },
                new HouseData { Id = 9, Address = "606 Spruce St", PostalCode = "10112", ListPrice = 400000.0f },
                new HouseData { Id = 10, Address = "707 Fir St", PostalCode = "21345", ListPrice = 475000.0f }
            };*/
        }

        private void FillTheData(IEnumerable<HouseData> list)
        {
            foreach (var house in list)
            {
                ListViewItem item = new ListViewItem(house.Id.ToString());
                item.SubItems.Add(house.Address);
                item.SubItems.Add(house.PostalCode);
                item.SubItems.Add(house.ListPrice.ToString());
                MainList.Items.Add(item);
            }
        }

        private void btn_GetData_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter client = new SqlDataAdapter("SELECT * FROM Houses", con))
            {
                DataTable clientData = new DataTable();
                con.Open();
                client.Fill(clientData);
                con.Close();

                clientData.DefaultView.Sort = "postalCode";
                clientData = clientData.DefaultView.ToTable();

                for (int row = 0; row < clientData.Rows.Count; row++)
                {
                    int id = (int)clientData.Rows[row]["houseID"];
                    //MessageBox.Show(id.ToString());
                    string address = clientData.Rows[row]["address"].ToString();

                    string postalCode = clientData.Rows[row]["postalCode"].ToString();

                    string listPrice = Math.Round((decimal)clientData.Rows[row]["listPrice"], 2).ToString();

                    HouseData house = new HouseData()
                    {
                        Id = id,
                        Address = address,
                        PostalCode = postalCode,
                        ListPrice = listPrice,
                    };

                    houses.Add(house);

                }

                FillTheData(houses);



            }



        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string s = text_Input.Text;
            FilterData(s);

        }

        private void FilterData(string s)
        {
            MainList.Items.Clear();
            IEnumerable<HouseData> filteredList = houses;

            string type = cb_FilterTyper.Text;
            
            switch (type)
            {
                case "Id":
                    filteredList = houses.Where(house => house.Id.ToString().Contains(s));
                    break;
                case "Address":
                    filteredList = houses.Where(house => house.Address.Contains(s));
                    break;
                case "Postal Code":
                    filteredList = houses.Where(house => house.PostalCode.Contains(s));
                    break;
                case "List Price":
                    filteredList = houses.Where(house => house.ListPrice.ToString().Contains(s));
                    break;
            }


            FillTheData(filteredList);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["HouseHunterLesson2.Properties.Settings.HouseDataConnectionString"].ConnectionString;
        }

        private void MainList_Click(object sender, EventArgs e)
        {

        }
    }
}
