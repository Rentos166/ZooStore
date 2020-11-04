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
            //Предварительно очищаем listView
            listViewProvider.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ProvidersSet providerSet in Program.zooDb.ProvidersSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    providerSet.Id.ToString(),
                    providerSet.CompanyName,
                    "г. " + providerSet.Address_City+", " + "ул. " + providerSet.Address_Street+", "+
                    "д. " + providerSet.Address_Home,
                    providerSet.Phone,
                    providerSet.Email
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = providerSet;
                //добавляем элементы в listView для отображения
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
                //Создаем новый экземпляр класса Поставщик
                ProvidersSet providerSet = new ProvidersSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
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
                //Добавляем в таблицу ProviderSet нового клиента providerSet
                Program.zooDb.ProvidersSet.Add(providerSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
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
                    //Делаем ссылку на объект, который хранится в textBox-ax
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
                    //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                    Program.zooDb.SaveChanges();
                    ShowProviders();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //если выбран 1 элемент из listView
                if (listViewProvider.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                    //удаляем из модели и базы данных
                    Program.zooDb.ProvidersSet.Remove(providerSet);
                    //сохраняем изменения
                    Program.zooDb.SaveChanges();
                    //отображаем обновленный список
                    ShowProviders();
                }
                //очищаем textBox-ы
                textBoxCompanyName.Text = "";
                textBoxAddress_City.Text = "";
                textBoxAddress_Home.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";

            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ProvidersSet providerSet = listViewProvider.SelectedItems[0].Tag as ProvidersSet;
                //указываем, что может быть изменено
                textBoxCompanyName.Text = providerSet.CompanyName;
                textBoxAddress_City.Text = providerSet.Address_City;
                textBoxAddress_Street.Text = providerSet.Address_Street;
                textBoxAddress_Home.Text = providerSet.Address_Home;
                textBoxPhone.Text = providerSet.Phone;
                textBoxEmail.Text = providerSet.Email;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
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
