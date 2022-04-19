using MaterialSkin.Controls;
using MedicProFW.Win.Data;
using MedicProFW.Win.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicProFW.Win
{
    public partial class frmLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                var usuario = db.Users.FirstOrDefault(u => u.Usuario == txtUser.Text && u.Clave == txtClave.Text);
                if(usuario!=null)
                {
                    Global.UserLogin = usuario.Usuario;
                    Global.UserTipo = usuario.Rol;

                    txtUser.Text = "";
                    txtClave.Text = "";
                    this.Hide();
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();

                }
                else
                {
                    MaterialMessageBox.Show("Usuario o clave incorrectos");
                }
            }
        }
    }
}
