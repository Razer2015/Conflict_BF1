using Conflict_BF1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflict_BF1
{
    public partial class Results : Form
    {
        public Results() {
            InitializeComponent();

            SandBagIndexes.Refreshed += SandBagIndexes_Refreshed;
            GenerateGridView(ref dataGridView1);
        }

        private void SandBagIndexes_Refreshed() {
            this.layoutPanel_tileLights.Invalidate();
            this.dataGridView1.Invalidate();
        }

        private void GenerateGridView(ref DataGridView dataGridView) {
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");
            dataGridView.Rows.Add("", "", "", "", "", "", "", "");

            foreach (DataGridViewColumn col in dataGridView.Columns) {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.Width = ((dataGridView.Width - 50) / 8);
            }
            foreach (DataGridViewRow row in dataGridView.Rows) {
                row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                row.Height = 35;
            }
        }

        private void layoutPanel_TileColors_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if ((e.Column + e.Row) % 2 == 1) {
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
                if (SandBagIndexes.GetIndex(e.Row, e.Column)) {
                    using (Brush brush = new SolidBrush(Color.FromArgb(180, 223, 205, 0))) {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }
                    using (Brush brush = new SolidBrush(Color.FromArgb(255, 223, 205, 0))) {
                        e.Graphics.FillEllipse(brush, new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, e.CellBounds.Height - 12));
                    }
                }
            }
            else {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
                if (SandBagIndexes.GetIndex(e.Row, e.Column)) {
                    using (Brush brush = new SolidBrush(Color.FromArgb(180, 223, 205, 0))) {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }
                    using (Brush brush = new SolidBrush(Color.FromArgb(255, 223, 205, 0))) {
                        e.Graphics.FillEllipse(brush, new Rectangle(e.CellBounds.X + 6, e.CellBounds.Y + 6, e.CellBounds.Width - 12, e.CellBounds.Height - 12));
                    }
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) {
                return;
            }
            var dGridView = sender as DataGridView;

            if ((e.ColumnIndex + e.RowIndex) % 2 == 1) {
                // Black tile
                if (SandBagIndexes.GetIndex(e.RowIndex, e.ColumnIndex)) {
                    // Need to be lit
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Black;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.DarkGreen;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Silver;
                }
                else {
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Black;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.Black;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.White;
                }
            }
            else {
                // White tile
                if (SandBagIndexes.GetIndex(e.RowIndex, e.ColumnIndex)) {
                    // Need to be lit
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.DarkGreen;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Silver;
                }
                else {
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.White;
                    dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = Color.Black;
                }
            }

            //if ((e.ColumnIndex + e.RowIndex) % 2 == 0) {
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Black;
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Silver;
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Silver;
            //    if (SandBagIndexes.GetIndex(e.RowIndex, e.ColumnIndex)) {
            //        //dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
            //        //dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = Color.DarkGreen;
            //    }
            //}
            //else {
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Silver;
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            //    dGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Silver;
            //}
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) {
                return;
            }
            var dGridView = sender as DataGridView;
            var value = dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString().Replace(".", ",").Replace(" ", string.Empty) ?? "";
            lbl_error.Visible = false;
            if (!FormatValid(value)) {
                dGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                lbl_error.Text = $"Invalid input. Make sure you don't have the same value for row and column.";
                lbl_error.Visible = true;
                this.Update();
                return;
            }

            CheckRowsAndColumns(dGridView, e.RowIndex, e.ColumnIndex);

            for (int i = 0; i < dGridView.RowCount; i++) {
                if (Rows[i] != -1) {
                    dGridView.Rows[i].HeaderCell.Value = Rows[i].ToString();
                }
                else {
                    dGridView.Rows[i].HeaderCell.Value = "";
                }
            }
            for (int i = 0; i < dGridView.ColumnCount; i++) {
                if (Columns[i] != -1) {
                    dGridView.Columns[i].HeaderCell.Value = Columns[i].ToString();
                    for (int j = 0; j < dGridView.RowCount; j++) {
                        if (Rows[j] != -1) {
                            if (!string.IsNullOrEmpty(value)) {
                                dGridView.Rows[j].Cells[i].Value = $"{Rows[j]}, {Columns[i]}";
                            }
                        }
                    }
                }
                else {
                    dGridView.Columns[i].HeaderCell.Value = "";
                }
            }
            //dGridView.Rows[0].HeaderCell.Value = "1";
            //dGridView.Columns[0].HeaderCell.Value = "1";
        }

        int[] Columns = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };
        int[] Rows = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };

        private void CheckRowsAndColumns(DataGridView dGridView, int row, int column) {
            // Check columns
            {
                var sb = new StringBuilder();
                foreach (DataGridViewCell item in dGridView.Rows[row].Cells) {
                    sb.Append(item.Value);
                    sb.Append(",");
                    //item.Value = $"{item.RowIndex}, {item.ColumnIndex}";
                }

                var parts = sb.Replace(" ", string.Empty).ToString().Split(',').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Rows[row] = -1;
                if (parts.Length > 2) {
                    var result = Duplicates(parts);
                    if (result == 0 || result == -1) {
                        lbl_error.Text = $"Your row {row + 1} has two or more inputs but the RowIndex is not the same for all entries.";
                        lbl_error.Visible = true;
                        this.Update();
                        //MessageBox.Show(this, "Your row has two or more inputs but the RowIndex is not the same for all entries.", "Incorrect RowIndex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        Rows[row] = result;
                    }
                }
            }
            // Check rows
            {
                var sb = new StringBuilder();
                for (int i = 0; i < dGridView.RowCount; i++) {
                    sb.Append(dGridView.Rows[i].Cells[column].Value);
                    sb.Append(",");
                    //item.Value = $"{item.RowIndex}, {item.ColumnIndex}";
                }

                var parts = sb.Replace(" ", string.Empty).ToString().Split(',').Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Columns[column] = -1;
                if (parts.Length > 2) {
                    var result = Duplicates(parts);
                    if (result == 0 || result == -1) {
                        lbl_error.Text = $"Your column {column + 1} has two or more inputs but the ColumnIndex is not the same for all entries.";
                        lbl_error.Visible = true;
                        this.Update();
                        //MessageBox.Show(this, "Your column has two or more inputs but the ColumnIndex is not the same for all entries.", "Incorrect ColumnIndex", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        Columns[column] = result;
                    }
                }
            }
        }

        private int Duplicates(string[] items) {
            var vals = new List<string>();
            var temp = new List<string>();
            foreach (var s in items) {
                if (vals.Contains(s)) {
                    temp.Add(s);
                }
                vals.Add(s);
            }

            if (temp.Count <= 0) {
                return (0);
            }
            else {
                var duplicates = temp.Distinct().ToArray();
                if (duplicates.Length == 1) {
                    return int.Parse(duplicates[0]);
                }
                else {
                    Console.WriteLine("Found too many duplicates.");
                    return (-1);
                }
            }
        }

        bool FormatValid(string format) {
            string allowableCharacters = "0123456789,";

            foreach (char c in format) {
                // This is using String.Contains for .NET 2 compat.,
                //   hence the requirement for ToString()
                if (!allowableCharacters.Contains(c.ToString()))
                    return false;
            }

            var splitted = format.Split(',');
            if (splitted.Length > 1) {
                if (splitted[0].Equals(splitted[1], StringComparison.OrdinalIgnoreCase)) {
                    return false;
                }
            }

            return true;
        }
    }
}
