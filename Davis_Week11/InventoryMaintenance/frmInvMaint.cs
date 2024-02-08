using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            LoadComboBox();
            FillItemListBox();
        }

        private void LoadComboBox()
        {
            cboFilterBy.DataSource = new string[] {
                "All", "Under $10", "$10 to $50", "Over $50"
            };
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();

            string filter = cboFilterBy.SelectedValue.ToString();
            IEnumerable<InvItem> filteredItems = null;

            // add items to the filteredItems collection based on FilterBy value
            if (filter.Equals("All"))
            {
                filteredItems = invItems.OrderBy(item => item.Description).ToList();
            }
            else if (filter.Equals("Under $10"))
            {
                filteredItems = invItems.Where(item => item.Price < 10).OrderBy(item => item.Description).ToList();
            }
            else if (filter.Equals("$10 to $50"))
            {
                filteredItems = invItems.Where(item => item.Price >= 10 && item.Price <= 50)
                                        .OrderBy(item => item.Description).ToList();
            }
            else if (filter.Equals("Over $50"))
            {
                filteredItems = invItems.Where(item => item.Price > 50).OrderBy(item => item.Description).ToList();
            }
            else
            {
                filteredItems = invItems;
            }
            // change code to loop the filteredItems collection
            foreach (InvItem item in filteredItems)
            {
                lstItems.Items.Add(item.DisplayText);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                //InvItem invItem = (InvItem)invItems[i];
                var displayText = lstItems.Items[i].ToString();
                InvItem deleteItem = invItems.FirstOrDefault(item => item.DisplayText == displayText);
                string message = $"Are you sure you want to delete {displayText}?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(deleteItem);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemListBox();
        }
    }
}
