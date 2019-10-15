using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnDoesBroswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EncryptService.ServiceClient myClient = new EncryptService.ServiceClient();
            try { lblEncrypted.Text = myClient.Encrypt(txtInput.Text); }
            catch (Exception ec) { lblEncrypted.Text = ec.Message.ToString(); }
            try { lblDecrypted.Text = myClient.Decrypt(lblEncrypted.Text); }
            catch (Exception dc) { lblDecrypted.Text = dc.Message.ToString(); }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StockService.ServiceClient myclient = new StockService.ServiceClient();
            string stockPrice = myclient.getStockquote(getStock.Text);
            getPrice.Text = stockPrice;
        }
    }
}
