using System.Text.Json;

namespace WhatOffice;

public partial class FormSettings : Form
{
    public FormSettings()
    {
        InitializeComponent();

        foreach (string product in Config.SupportedProducts)
        {
            int lastRow = dataGridView_path.Rows.Add(product);
            dataGridView_path.Rows[lastRow].Cells["_ProductName"].Value = product;
            dataGridView_path.Rows[lastRow].Cells["WordProcessing"].Value = Config.Current.products[product].appWordProcessing;
            dataGridView_path.Rows[lastRow].Cells["Spreadsheet"].Value = Config.Current.products[product].appSpreadsheet;
            dataGridView_path.Rows[lastRow].Cells["Presentation"].Value = Config.Current.products[product].appPresentation;
        }
        checkBox_charmoji.Checked = Config.Current.enableCharmoji;
        checkBox_notify.Checked = Config.Current.enableNotification;
        comboBox_default.SelectedIndex = (int)Config.Current.defaultMethod - 1;
        label_counter.Text = string.Format(label_counter.Text, Config.Current.counter);
    }

    private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
    {
        foreach (DataGridViewRow row in dataGridView_path.Rows)
        {
            string productName = (string)row.Cells["_ProductName"].Value;
            OfficeProduct newProd;
            newProd.appWordProcessing = (string)row.Cells["WordProcessing"].Value;
            newProd.appSpreadsheet = (string)row.Cells["Spreadsheet"].Value;
            newProd.appPresentation = (string)row.Cells["Presentation"].Value;
            Config.Current.products[productName] = newProd;
        }
        Config.Current.enableCharmoji = checkBox_charmoji.Checked;
        Config.Current.enableNotification = checkBox_notify.Checked;
        Config.Current.defaultMethod = (OfficeType)(comboBox_default.SelectedIndex + 1);
        string configJson = JsonSerializer.Serialize(Config.Current);
        File.WriteAllText(Program.configPath ?? "", configJson);
    }
}
