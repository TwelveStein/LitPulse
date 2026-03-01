using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Entities;
using Core.Services;
using DocumentFormat.OpenXml.Office2013.Word;

namespace LitPulse.Forms
{
    public partial class ProxySettingsForm : Form
    {
        private BindingList<Proxys> _proxys = new BindingList<Proxys>();

        public ProxySettingsForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            _proxys = new BindingList<Proxys>(ProxysService.Proxies.ToList());

            checkBoxProxyIsActive.Checked = ProxysService.UseProxy;

            dataGridViewProxys.DataSource = _proxys;
        }

        private void buttonImportProxyList_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Выберите файл с прокси";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProxysService.LoadFromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            LoadData();
        }

        private void buttonClearProxyList_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить все загруженные прокси?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProxysService.Clear();
            }

            LoadData();
        }

        private void buttonDeleteProxy_Click(object sender, EventArgs e)
        {
            if (dataGridViewProxys.CurrentRow != null && dataGridViewProxys.CurrentRow.DataBoundItem is Proxys proxy)
            {
                ProxysService.RemoveProxy(proxy);
                LoadData();
            }
        }

        private void checkBoxProxyIsActive_CheckedChanged(object sender, EventArgs e)
        {
            ProxysService.UseProxy = checkBoxProxyIsActive.Checked;
            ProxysService.SaveToStorage();
        } 
    }
}
