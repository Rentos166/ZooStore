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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void OpenProvider_Click(object sender, EventArgs e)
        {
            Form formProviders = new FormProvider();
            formProviders.Show();
        }

        private void OpenStorage_Click(object sender, EventArgs e)
        {
            Form formStorage = new FormStorage();
            formStorage.Show();
        }

        private void OpenCustom_Click(object sender, EventArgs e)
        {
            Form formCustoms = new sssss();
            formCustoms.Show();
        }
    }
}
