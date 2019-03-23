using System;
using System.Data;
using System.Windows.Forms;
using Functions;

namespace Bill_System
{
    public partial class Purchase : Form
    {
        int[] rate = { 50, 30, 120, 300, 500, 40, 20, 130 };
        int total = 0;
        DataTable dt;
        DataTable dt2;
        Class1 dllfile = new Class1();
        public Purchase()
        {
            InitializeComponent();
            dt = new DataTable();
            dt2 = new DataTable();
            DataColumn d1 = new DataColumn("Item Name");
            DataColumn d2 = new DataColumn("Qty");
            DataColumn d3 = new DataColumn("Rate");
            DataColumn d4 = new DataColumn("Amount");
            DataColumn d5 = new DataColumn("Item Name");
            DataColumn d6 = new DataColumn("Qty");
            DataColumn d7 = new DataColumn("Rate");
            DataColumn d8 = new DataColumn("Amount");
            dt.Columns.Add(d1);
            dt.Columns.Add(d2);
            dt.Columns.Add(d3);
            dt.Columns.Add(d4);
            dt2.Columns.Add(d5);
            dt2.Columns.Add(d6);
            dt2.Columns.Add(d7);
            dt2.Columns.Add(d8);
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt2.NewRow();
            CartView.DataSource = dt;
            Bill_GV.DataSource = dt2;
            Bill_GV.Visible = false;
        }

        private void Item_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item_CB.Text == "Pepsi")
            {
                Rate_TB.Text = rate[0].ToString();
            }
            else if (Item_CB.Text == "Lays")
            {
                Rate_TB.Text = rate[1].ToString();
            }
            else if (Item_CB.Text == "Coffee")
            {
                Rate_TB.Text = rate[2].ToString();
            }
            else if (Item_CB.Text == "Suger")
            {
                Rate_TB.Text = rate[3].ToString();
            }
            else if (Item_CB.Text == "Floor")
            {
                Rate_TB.Text = rate[4].ToString();
            }
            else if (Item_CB.Text == "Popcorn")
            {
                Rate_TB.Text = rate[5].ToString();
            }
            else if (Item_CB.Text == "Juice")
            {
                Rate_TB.Text = rate[6].ToString();
            }
            else if (Item_CB.Text == "Chocolate")
            {
                Rate_TB.Text = rate[7].ToString();
            }
        }

        private void AddtoCart_Btn_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            DataRow dr2 = dt2.NewRow();
            dr[0] = Item_CB.Text;
            dr[1] = Qty_TB.Text;
            dr[2] = Rate_TB.Text;
            dr[3] = (int.Parse(Qty_TB.Text) * int.Parse(Rate_TB.Text)).ToString();
            dt.Rows.Add(dr);
            CartView.DataSource = dt;
            dr2[0] = Item_CB.Text;
            dr2[1] = Qty_TB.Text;
            dr2[2] = Rate_TB.Text;
            dr2[3] = (int.Parse(Qty_TB.Text) * int.Parse(Rate_TB.Text)).ToString();
            dt2.Rows.Add(dr2);
            total += int.Parse(dr2[3].ToString());
            Item_CB.Text = null;
            Qty_TB.Clear();
            Rate_TB.Clear();
        }

        private void ClearCart_Btn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
        }

        private void ChkOut_Btn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            Bill_GV.Visible = true;
            BillNo_Lbl.Text = dllfile.Counter().ToString();
            Bill_GV.DataSource = dt2;
            TotalItems_Lbl.Text = dt2.Rows.Count.ToString();
            Date_Lbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
            TotalAmount_Lbl.Text = total.ToString();
        }

        private void Print_Btn_Click(object sender, EventArgs e)
        {
            dt2.Rows.Clear();
            Bill_GV.Visible = false;
            Date_Lbl.Text = null;
            BillNo_Lbl.Text = null;
            TotalAmount_Lbl.Text = null;
            TotalItems_Lbl.Text = null;
        }
    }
}
