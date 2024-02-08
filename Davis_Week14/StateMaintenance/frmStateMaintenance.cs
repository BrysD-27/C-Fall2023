using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StateMaintenance.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StateMaintenance
{
    public partial class frmStateMaintenance : Form
    {
        public frmStateMaintenance()
        {
            InitializeComponent();
        }

        MMABooksContext context = new MMABooksContext();
        State selectedState = null;
        const int modifyBtnIndex = 2;
        const int deleteBtnIndex = 3;
        private const int MaxRows = 10;
        private int totalRows = 0;
        private int pages = 0;
        private int currentPage;


        // private constants for the index values of the Modify and Delete button columns

        private void frmStateMaintenance_Load(object sender, EventArgs e)
        {
            totalRows = context.States.Count();
            pages = totalRows / MaxRows;
            if (totalRows % MaxRows != 0)
            {
                pages += 1;
            }
            currentPage = 1;
            DisplayStates(currentPage);
        }
        private void EnableDisableButtons(int pageNumber)
        {
            if (pageNumber == 1)
            {
                firstPage.Enabled = false;
                previousPage.Enabled = false;
            }
            else
            {
                firstPage.Enabled = true;
                previousPage.Enabled = true;
            }
            if (pageNumber == pages)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            else
            {
                nextPage.Enabled = true;
                lastPage.Enabled = true;
            }
        }

        private void firstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            dataGridView.Columns.Clear();
            DisplayStates(1);
        }
        private void previousPage_Click(object sender, EventArgs e)
        {
            currentPage -= 1;
            dataGridView.Columns.Clear();
            DisplayStates(currentPage);
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            dataGridView.Columns.Clear();
            DisplayStates(currentPage);
        }

        private void lastPage_Click(object sender, EventArgs e)
        {
            currentPage = pages;
            dataGridView.Columns.Clear();
            DisplayStates(pages);
        }


        private void DisplayStates(int pageNumber)
        {
            int skip = MaxRows * (pageNumber - 1);

            int take = MaxRows;
            if (pageNumber == pages)
            {
                take = totalRows - skip;
            }
            if (totalRows <= MaxRows)
            {
                take = totalRows;
            }

            // get states and bind grid
            dataGridView.DataSource = context.States.OrderBy(s => s.StateName)
                                    .Select(s => new { s.StateCode, s.StateName })
                                    .Skip(skip)
                                    .Take(take)
                                    .ToList();
            // format grid
            if (dataGridView.Columns.Count < 3)
            {
                dataGridView.Columns.Insert(modifyBtnIndex, new DataGridViewButtonColumn() { Name = "Modify", Text = "Modify", HeaderText = "", UseColumnTextForButtonValue = true, Width = 100 });
                dataGridView.Columns.Insert(deleteBtnIndex, new DataGridViewButtonColumn() { Name = "Delete", Text = "Delete", HeaderText = "", UseColumnTextForButtonValue = true, Width = 100 });
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.Columns[0].HeaderText = "Code";
                dataGridView.Columns[0].Width = 55;
                dataGridView.Columns[1].HeaderText = "State Name";
                dataGridView.Columns[1].Width = 153;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;
            }
            EnableDisableButtons(pageNumber);

        }

        private void ModifyState()
        {
            var modifyForm = new frmAddModify()
            {
                AddState = false,
                State = selectedState
            };
            DialogResult result = modifyForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedState = modifyForm.State;
                    context.SaveChanges();
                    dataGridView.Columns.Clear();
                    DisplayStates(currentPage);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void DeleteState()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedState.StateName.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.States.Remove(selectedState);
                    context.SaveChanges(true);
                    dataGridView.Columns.Clear();
                    DisplayStates(currentPage);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddModify
            {
                AddState = true
            };
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedState = addForm.State;
                    context.States.Add(selectedState);
                    context.SaveChanges();
                    dataGridView.Columns.Clear();
                    DisplayStates(currentPage);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();
            var entityState = context.Entry(selectedState).State;
            if (entityState == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that state.",
                "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that state.\n" +
                "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            DisplayStates(currentPage);
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE: " + error.Number + " " +
                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == modifyBtnIndex || e.ColumnIndex == deleteBtnIndex)
            {
                string stateCode =
                    dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedState = context.States.Find(stateCode);
            }
            if (e.ColumnIndex == modifyBtnIndex)
                ModifyState();
            else if (e.ColumnIndex == deleteBtnIndex)
                DeleteState();
        }
    }
}
