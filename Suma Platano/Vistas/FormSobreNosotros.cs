using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_Platano
{
    public partial class FormSobreNosotros : MaterialForm
    {
        public FormSobreNosotros()
        {
            InitializeComponent();

            //
            //Material Skin manager (crear la apariencia del Form estilo Material Design)
            //
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
        
        private void FormSobreNosotros_Load(object sender, EventArgs e)
        {
            this.btnCerrar.DialogResult = DialogResult.OK;
        }
    }
}
