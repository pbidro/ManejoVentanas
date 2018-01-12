using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class POS_MAIN : Form
    {
        public POS_MAIN()
        {
            InitializeComponent();
        }

        private void POS_MAIN_Load(object sender, EventArgs e)
        {

        }


        private void tileNavPane1_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

            Console.WriteLine(e.Element.Name);
            switch (e.Element.Name)
            {
                case "F":
                    label1.Text = "A";
                    CargarFormulario(new POS_VENTAS());




                    break;
                case "G":
                    label1.Text = "B";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

        //Console.WriteLine(e.Element.Name);
        //switch (e.Element.Name)
        //{
        //    case "A":
        //        label1.Text = "A";
        //        CargarFormulario(new POS_VENTAS());




        //        break;
        //    case "B":
        //        label1.Text = "B";
        //        break;
        //    default:
        //        Console.WriteLine("Default case");
        //        break;
        //}

        private void CargarFormulario(Form formulario)
        {

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formulario);
            this.panel1.Tag = formulario;
            formulario.Show();

            //frmLoad.TopLevel = False
            //frmLoad.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            //frmLoad.Dock = DockStyle.Fill
            //frmLoad.MaximizeBox = True
            //frm.Anchor = AnchorStyles.Bottom
            //frm.Anchor = AnchorStyles.Top
            //frm.Anchor = AnchorStyles.Left
            //frm.Anchor = AnchorStyles.Right
            //Panel1.Controls.Add(frmLoad)
            //frmLoad.Show()



        }

   

        private void tileNavPane1_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Console.WriteLine(e.Element.Name);
            switch (e.Element.Name)
            {
                case "D":
                    label1.Text = "A";
                    CargarFormulario(new POS_VENTAS());




                    break;
                case "E":
                    label1.Text = "B";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        private void POS_MAIN_Load_1(object sender, EventArgs e)
        {

        }
    }
}
