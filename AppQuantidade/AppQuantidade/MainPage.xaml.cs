using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        private int quantidade;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Soma(object sender, EventArgs e)
        {
            this.quantidade++;
            this.Quantidade.Text = this.quantidade.ToString();
        }

        private void Subtrai(object sender, EventArgs e)
        {
            if (quantidade > 0)
            {
                this.quantidade--;
                this.Quantidade.Text = this.quantidade.ToString();
            }
        }
    }
}
