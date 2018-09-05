using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Generador_de_contraseñas
{
    public partial class PantallaPrincipal : MaterialForm
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema 1.
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9, numero10, numero11, numero12,
                numero13, numero14, numero15, numero16, numero17, numero18, numero19, numero20, numero21;

            char generado1, generado2, generado3, generado4, generado5, generado6, generado7, generado8, generado9, generado10,
                generado11, generado12, generado13, generado14, generado15, generado16, generado17, generado18, generado19,
                generado20, generado21;

            Random rdn = new Random();
            numero1 = rdn.Next(33, 125);
            numero2 = rdn.Next(33, 125);
            numero3 = rdn.Next(33, 125);
            numero4 = rdn.Next(33, 125);
            numero5 = rdn.Next(33, 125);
            numero6 = rdn.Next(33, 125);
            numero7 = rdn.Next(33, 125);
            numero8 = rdn.Next(33, 125);
            numero9 = rdn.Next(33, 125);
            numero10 = rdn.Next(33, 125);
            numero11 = rdn.Next(33, 125);
            numero12 = rdn.Next(33, 125);
            numero13 = rdn.Next(33, 125);
            numero14 = rdn.Next(33, 125);
            numero15 = rdn.Next(33, 125);
            numero16 = rdn.Next(33, 125);
            numero17 = rdn.Next(33, 125);
            numero18 = rdn.Next(33, 125);
            numero19 = rdn.Next(33, 125);
            numero20 = rdn.Next(33, 125);
            numero21 = rdn.Next(33, 125);

            generado1 = Convert.ToChar(numero1);
            generado2 = Convert.ToChar(numero2);
            generado3 = Convert.ToChar(numero3);
            generado4 = Convert.ToChar(numero4);
            generado5 = Convert.ToChar(numero5);
            generado6 = Convert.ToChar(numero6);
            generado7 = Convert.ToChar(numero7);
            generado8 = Convert.ToChar(numero8);
            generado9 = Convert.ToChar(numero9);
            generado10 = Convert.ToChar(numero10);
            generado11 = Convert.ToChar(numero11);
            generado12 = Convert.ToChar(numero12);
            generado13 = Convert.ToChar(numero13);
            generado14 = Convert.ToChar(numero14);
            generado15 = Convert.ToChar(numero15);
            generado16 = Convert.ToChar(numero16);
            generado17 = Convert.ToChar(numero17);
            generado18 = Convert.ToChar(numero18);
            generado19 = Convert.ToChar(numero19);
            generado20 = Convert.ToChar(numero20);
            generado21 = Convert.ToChar(numero21);

            Password.Text = (generado1.ToString() + generado2.ToString() + generado3.ToString() + generado4.ToString() + generado5.ToString()
                + generado6.ToString() + generado7.ToString() + generado8.ToString() + generado9.ToString() + generado10.ToString() 
                + generado11.ToString() + generado12.ToString() + generado13.ToString() + generado14.ToString() + generado15.ToString() 
                + generado16.ToString() + generado17.ToString() + generado18.ToString() + generado19.ToString() + generado20.ToString() 
                + generado21.ToString());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            /*
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            */        
        }
    }
}
