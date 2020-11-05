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
    public partial class sssss : Form
    {
        void ShowCustoms()
        {
            listViewCustoms.Items.Clear();
            foreach (CustomsSet customSet in Program.zooDb.CustomsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    customSet.Id.ToString(),
                    customSet.ProvidersSet.CompanyName,
                    customSet.NameProduct,
                    customSet.TypeProduct,
                    customSet.MkProduct.ToString(),
                    customSet.NumberProduct.ToString(),
                    customSet.Price.ToString(),
                    customSet.Date.ToString(),
                    customSet.Status
                });
                item.Tag = customSet;
                listViewCustoms.Items.Add(item);
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
        public sssss()
        {
            InitializeComponent();
            ShowCustoms();
            ShowProvider();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeProduct.SelectedItem != null && comboBoxProvider.SelectedItem != null)
            {
                CustomsSet customSet = new CustomsSet();
                customSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                customSet.NameProduct = textBoxNameProduct.Text;
                customSet.MkProduct = Convert.ToInt32(textBoxMkProduct.Text);
                customSet.NumberProduct = Convert.ToInt32(textBoxNumberProduct.Text);
                customSet.Price = Convert.ToInt32(textBoxPrice.Text);
                customSet.Date = dateTimePickerCustom.Value;
                if (comboBoxTypeProduct.SelectedIndex == 0)
                {
                    customSet.TypeProduct = "Корм";
                }
                else if (comboBoxTypeProduct.SelectedIndex == 1)
                {
                    customSet.TypeProduct = "Игрушки";
                }
                else if (comboBoxTypeProduct.SelectedIndex == 2)
                {
                    customSet.TypeProduct = "Поводки";
                }
                else
                {
                    customSet.TypeProduct = "Медикаменты";
                }
                if (comboBoxStatus.SelectedIndex == 0)
                {
                    customSet.Status = "Заказ формируется";
                }
                else if (comboBoxStatus.SelectedIndex == 1)
                {
                    customSet.Status = "Отправка заказа";
                }
                else if (comboBoxStatus.SelectedIndex == 2)
                {
                    customSet.Status = "Заказ отправлен";
                }
                else 
                {
                    customSet.Status = "Доставлено";
                }
                Program.zooDb.CustomsSet.Add(customSet);
                Program.zooDb.SaveChanges();
                ShowCustoms(); 
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeProduct.SelectedItem != null && comboBoxProvider.SelectedItem != null)
                {
                    if (listViewCustoms.SelectedItems.Count == 1)
                    {
                        CustomsSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomsSet;
                        customSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                        customSet.NameProduct = textBoxNameProduct.Text;
                        customSet.MkProduct = Convert.ToInt32(textBoxMkProduct.Text);
                        customSet.NumberProduct = Convert.ToInt32(textBoxNumberProduct.Text);
                        customSet.Price = Convert.ToInt32(textBoxPrice.Text);
                        customSet.Date = dateTimePickerCustom.Value;
                        if (comboBoxTypeProduct.SelectedIndex == 0)
                        {
                            customSet.TypeProduct = "Корм";
                        }
                        else if (comboBoxTypeProduct.SelectedIndex == 1)
                        {
                            customSet.TypeProduct = "Игрушки";
                        }
                        else if (comboBoxTypeProduct.SelectedIndex == 2)
                        {
                            customSet.TypeProduct = "Поводки";
                        }
                        else
                        {
                            customSet.TypeProduct = "Медикаменты";
                        }
                        if (comboBoxStatus.SelectedIndex == 0)
                        {
                            customSet.Status = "Заказ формируется";
                        }
                        else if (comboBoxStatus.SelectedIndex == 1)
                        {
                            customSet.Status = "Отправка заказа";
                        }
                        else if (comboBoxStatus.SelectedIndex == 2)
                        {
                            customSet.Status = "Заказ отправлен";
                        }
                        else
                        {
                            customSet.Status = "Доставлено";
                        }
                        Program.zooDb.SaveChanges();
                        ShowCustoms();
                    }
                    else
                    {
                        comboBoxStatus.SelectedItem = null;
                        comboBoxTypeProduct.SelectedItem = null;
                        comboBoxProvider.SelectedItem = null;
                        textBoxNameProduct.Text = "";
                        textBoxMkProduct.Text = "";
                        textBoxNumberProduct.Text = "";
                        textBoxPrice.Text = "";
                        dateTimePickerCustom.Value = DateTime.Now;
                    }
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewCustoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustoms.SelectedItems.Count == 1)
            {
                CustomsSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomsSet;
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(customSet.IdProvider.ToString());
                textBoxNameProduct.Text = customSet.NameProduct;
                textBoxMkProduct.Text = customSet.MkProduct.ToString();
                textBoxNumberProduct.Text = customSet.NumberProduct.ToString();
                textBoxPrice.Text = customSet.Price.ToString();
                comboBoxTypeProduct.Text = customSet.TypeProduct;
                dateTimePickerCustom.Value = customSet.Date;
                comboBoxStatus.Text = customSet.Status;
            }
            else
            {
                comboBoxStatus.SelectedItem = null;
                comboBoxTypeProduct.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
                textBoxNameProduct.Text = "";
                textBoxMkProduct.Text = "";
                textBoxNumberProduct.Text = "";
                textBoxPrice.Text = "";
                dateTimePickerCustom.Value = DateTime.Now;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustoms.SelectedItems.Count == 1)
                {
                    CustomsSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomsSet;
                    Program.zooDb.CustomsSet.Remove(customSet);
                    Program.zooDb.SaveChanges();
                    ShowCustoms();
                }
                else 
                {
                    comboBoxStatus.SelectedItem = null;
                    comboBoxTypeProduct.SelectedItem = null;
                    comboBoxProvider.SelectedItem = null;
                    textBoxNameProduct.Text = "";
                    textBoxMkProduct.Text = "";
                    textBoxNumberProduct.Text = "";
                    textBoxPrice.Text = "";
                    dateTimePickerCustom.Value = DateTime.Now;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMkProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberProduct_KeyPress(object sender, KeyPressEventArgs e)
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
