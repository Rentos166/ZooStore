using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоомагазин
{
    public partial class FormProvider : Form
    {
        void ShowProviders()
        {
            listViewProvider.Items.Clear();
            foreach (ProvidersSet providerSet in Program.zooDb.ProvidersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    providerSet.Id.ToString(),
                    providerSet.CompanyName,
                    "г. " + providerSet.Address_City+", " + "ул. " + providerSet.Address_Street+", "+
                    "д. " + providerSet.Address_Home,
                    providerSet.Phone,
                    providerSet.Email
                });
                item.Tag = providerSet;
                listViewProvider.Items.Add(item);
            }
        }
        
        public FormProvider()
        {
            InitializeComponent();
            ShowProviders();
        }

        private void FormProvider_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProvidersSet providerSet = new ProvidersSet();
                providerSet.CompanyName = textBoxCompanyName.Text;
                providerSet.Address_City = textBoxAddress_City.Text;
                providerSet.Address_Street = textBoxAddress_Street.Text;
                providerSet.Address_Home = textBoxAddress_Home.Text;
                providerSet.Phone = textBoxPhone.Text;
                providerSet.Email = textBoxEmail.Text;
                if (providerSet.CompanyName == "" || providerSet.Address_City == "" || providerSet.Address_Street == "" || providerSet.Phone == "")
                {
                    throw new Exception("Данные о поставщике не заполнены");
                }

                Program.zooDb.ProvidersSet.Add(providerSet);
                Program.zooDb.SaveChanges();
                ShowProviders();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                    providerSet.CompanyName = textBoxCompanyName.Text;
                    providerSet.Address_City = textBoxAddress_City.Text;
                    providerSet.Address_Street = textBoxAddress_Street.Text;
                    providerSet.Address_Home = textBoxAddress_Home.Text;
                    providerSet.Phone = textBoxPhone.Text;
                    providerSet.Email = textBoxEmail.Text;
                    if (providerSet.CompanyName == "" || providerSet.Address_City == "" || providerSet.Address_Street == "" || providerSet.Phone == "")
                    {
                        throw new Exception("Данные о поставщике не заполнены");
                    }
                    Program.zooDb.SaveChanges();
                    ShowProviders();
                }
                else
                {
                    textBoxCompanyName.Text = "";
                    textBoxAddress_City.Text = "";
                    textBoxAddress_Home.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                    Program.zooDb.ProvidersSet.Remove(providerSet);
                    Program.zooDb.SaveChanges();
                    ShowProviders();
                }
                textBoxCompanyName.Text = "";
                textBoxAddress_City.Text = "";
                textBoxAddress_Home.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                textBoxCompanyName.Text = providerSet.CompanyName;
                textBoxAddress_City.Text = providerSet.Address_City;
                textBoxAddress_Street.Text = providerSet.Address_Street;
                textBoxAddress_Home.Text = providerSet.Address_Home;
                textBoxPhone.Text = providerSet.Phone;
                textBoxEmail.Text = providerSet.Email;
            }
            else
            {
                textBoxCompanyName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress_City.Text = "";
                textBoxAddress_Home.Text = "";
                textBoxAddress_Street.Text = "";

            }
        }

        private void textBoxPhone_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
