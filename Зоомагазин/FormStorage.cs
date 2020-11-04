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
    public partial class FormStorage : Form
    {
        void ShowStorage()
        {
            //Предварительно очищаем listView
            listViewStorage.Items.Clear();
            foreach (StoragSet storageSet in Program.zooDb.StoragSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    storageSet.Id.ToString(),
                    storageSet.ProvidersSet.CompanyName,
                    storageSet.Name,
                    storageSet.Type,
                    storageSet.Mk.ToString(),
                    storageSet.Number.ToString(),
                    storageSet.Price.ToString()
                });
                item.Tag = storageSet;
                listViewStorage.Items.Add(item);
            }
        }
        void ShowProvider()
        {
            comboBoxProvider.Items.Clear();
            foreach (ProvidersSet providerSet in Program.zooDb.ProvidersSet)

            {
                string[] item = { providerSet.Id.ToString() + ".", providerSet.CompanyName };
                comboBoxProvider.Items.Add(string.Join(" ", item));
            }
        }
        public FormStorage()
        {
            InitializeComponent();
            ShowStorage();
            ShowProvider();
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem != null && comboBoxProvider.SelectedItem != null)
            {
                StoragSet storageSet = new StoragSet();
                storageSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                storageSet.Name = textBoxName.Text;
                storageSet.Mk = Convert.ToInt32(textBoxMk.Text);
                storageSet.Number = Convert.ToInt32(textBoxNumber.Text);
                storageSet.Price = Convert.ToInt32(textBoxPrice.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    storageSet.Type = "Корм";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    storageSet.Type = "Игрушки";
                }
                else if (comboBoxType.SelectedIndex == 2)
                {
                    storageSet.Type = "Поводки";
                }
                else
                {
                    storageSet.Type = "Медикаменты";
                }
                Program.zooDb.StoragSet.Add(storageSet);
                Program.zooDb.SaveChanges();
                ShowStorage();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem != null && comboBoxProvider.SelectedItem != null)
            {
                if (listViewStorage.SelectedItems.Count == 1)
                {
                    StoragSet storageSet = listViewStorage.SelectedItems[0].Tag as StoragSet;
                    storageSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                    storageSet.Name = textBoxName.Text;
                    storageSet.Mk = Convert.ToInt32(textBoxMk.Text);
                    storageSet.Number = Convert.ToInt32(textBoxNumber.Text);
                    storageSet.Price = Convert.ToInt32(textBoxPrice.Text);
                    if (comboBoxType.SelectedIndex == 0)
                    {
                        storageSet.Type = "Корм";
                    }
                    else if (comboBoxType.SelectedIndex == 1)
                    {
                        storageSet.Type = "Игрушки";
                    }
                    else if (comboBoxType.SelectedIndex == 2)
                    {
                        storageSet.Type = "Поводки";
                    }
                    else
                    {
                        storageSet.Type = "Медикаменты";
                    }
                    Program.zooDb.SaveChanges();
                    ShowStorage();
                }
                else
                {
                    comboBoxType.SelectedItem = null;
                    comboBoxProvider.SelectedItem = null;
                    textBoxName.Text = "";
                    textBoxMk.Text = "";
                    textBoxNumber.Text = "";
                    textBoxPrice.Text = "";
                }
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count == 1)
            {
                StoragSet storageSet = listViewStorage.SelectedItems[0].Tag as StoragSet;
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(storageSet.IdProvider.ToString());
                textBoxName.Text = storageSet.Name;
                textBoxMk.Text = storageSet.Mk.ToString();
                textBoxNumber.Text = storageSet.Number.ToString();
                textBoxPrice.Text = storageSet.Price.ToString();
                comboBoxType.Text = storageSet.Type;
                

            }
            else
            {
                comboBoxType.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
                textBoxName.Text = "";
                textBoxMk.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStorage.SelectedItems.Count == 1)
                {
                    StoragSet storageSet = listViewStorage.SelectedItems[0].Tag as StoragSet;
                    Program.zooDb.StoragSet.Remove(storageSet);
                    Program.zooDb.SaveChanges();
                    ShowStorage();
                }
                comboBoxType.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
                textBoxName.Text = "";
                textBoxMk.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
