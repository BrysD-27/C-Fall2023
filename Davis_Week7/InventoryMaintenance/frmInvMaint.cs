using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            string test = omitDoubleCharacter("lotto", "otto");
            InitializeComponent();
        }

        // Add a statement here that declares the list of items.
        List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            this.invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            // Add code here that loads the list box with the items in the list.
            for (int i = 0; i < invItems.Count; i++)
            {
                lstItems.Items.Add(invItems[i].GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            // and then gets a new item from that form.
            frmNewItem frmNewItem = new frmNewItem();
            InvItem item = frmNewItem.GetNewItem();

            if (item != null)
            {
                invItems.Add(item);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.
                DialogResult result = MessageBox.Show("Delete Item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string omitDoubleCharacter(string s1, string s2)
        {
            Stack<string> teams = new Stack<string>();

            string team = teams.Peek();
            var testScores = new decimal[];
            decimal sum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }
            decimal avg = sum / testScores.Length;
            MessageBox.Show("Average Of Array is : " + avg, "title");
        }
            if (s1.EndsWith(s2.Substring(0, 1)))
            {
                return s1 + s2.Substring(1);
            }
            return s1 + s2;
        }
    }
}
