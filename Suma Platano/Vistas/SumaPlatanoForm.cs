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
using Antlr4;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.IO;
using Suma_Platano.Lenguaje;

namespace Suma_Platano
{
    public partial class SumaPlatanoForm : MaterialForm
    {
        public SumaPlatanoForm()
        {
            InitializeComponent();

            //
            //Material Skin manager (crear la apariencia del Form estilo Material Design)
            //
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal100, Accent.Amber700, TextShade.WHITE);

            //
            //Color del panel que contiene el boton de menu y el tab selector
            //
            splitContainer1.Panel1.BackColor = skinManager.ColorScheme.PrimaryColor;

            //
            //Letra de los text box de codigo y consola
            //
            textEditorCode.Font = new Font("Inconsolata", 12, FontStyle.Regular);
            textConsola.Font = new Font("Inconsolata", 12, FontStyle.Regular);
            textListaErrores.Font = new Font("Inconsolata", 12, FontStyle.Regular);
        }

        //
        //Boton para abrir el panel de menu
        //
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (splitContainer2.SplitterDistance == 44)
            {
                splitContainer2.SplitterDistance = 136;
            }
            else
            {
                splitContainer2.SplitterDistance = 44;
            }
        }

        //
        //Mostrar ventana "Sobre Nosotros" con la informacion de los desarrolladores
        //
        private void btnNosotros_Click(object sender, EventArgs e)
        {
            FormSobreNosotros FSN = new FormSobreNosotros();
            FSN.ShowDialog();
        }

        //
        //Compilar la solucion
        //
        private void btnCompilar_Click(object sender, EventArgs e)
        {
            //StringReader prueba = new StringReader(textEditorCode.Text);
            ProgressBar.Minimum = 0;
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 100;
            textConsola.Text = "";
            textListaErrores.Text = "";

            try
            {
                StringReader prueba = new StringReader(textEditorCode.Text);
                AntlrInputStream input = new AntlrInputStream(prueba.ReadToEnd());
                LenguajeLexer lexer = new LenguajeLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                LenguajeParser parser = new LenguajeParser(tokens);
                IParseTree tree = parser.programa();

                SumaPlatanoVisitor MyVisitor = new SumaPlatanoVisitor();
                MyVisitor.Visit(tree);

                foreach (var i in MyVisitor.ListaDeImpresion)
                {
                    textConsola.Text += i.ToString() + '\n';
                }

            }
            catch (Exception ex)
            {
                textListaErrores.Text = ex.Message;
                //throw;
            }

            //AntlrInputStream input = new AntlrInputStream(prueba.ReadToEnd());
            //LenguajeLexer lexer = new LenguajeLexer(input);
            //CommonTokenStream tokens = new CommonTokenStream(lexer);
            //LenguajeParser parser = new LenguajeParser(tokens);
            //IParseTree tree = parser.programa();
            //Console.WriteLine(tree.ToStringTree(parser));

            //textConsola.Text = tree.ToStringTree(parser);
            //textConsola.Text += "\n\n---Prueba del Visitor---\n\n";
            //SumaPlatanoVisitor MyVisitor = new SumaPlatanoVisitor();
            //MyVisitor.Visit(tree);

            //foreach (var i in MyVisitor.ListaDeImpresion)
            //{
            //    textConsola.Text += i.ToString() + '\n';
            //}


            ProgressBar.Value = 100;
        }

        private void compilar()
        {
            StringReader prueba = new StringReader(textEditorCode.Text);

            AntlrInputStream input = new AntlrInputStream(prueba.ReadToEnd());
            LenguajeLexer lexer = new LenguajeLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            LenguajeParser parser = new LenguajeParser(tokens);

            IParseTree tree = parser.programa();
            SumaPlatanoVisitor MyVisitor = new SumaPlatanoVisitor();
            MyVisitor.Visit(tree);
        }

        //
        //Guardar el codigo en un archivo SPL
        //
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textEditorCode.Text);
                
            }
        }

        //
        //Abrir un archivo de codigo SPL
        //
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            StreamReader texto = null;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                texto = new StreamReader(openFileDialog1.FileName);
                textEditorCode.Text = texto.ReadToEnd();
                texto.Close();
            }
        }
       
    }
}
