namespace Suma_Platano
{
    partial class SumaPlatanoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumaPlatanoForm));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageEditor = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEditorCode = new System.Windows.Forms.RichTextBox();
            this.tabPageConsola = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textConsola = new System.Windows.Forms.RichTextBox();
            this.tabPageErrores = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textListaErrores = new System.Windows.Forms.RichTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnMenu = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAbrir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCompilar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnIniciar = new MaterialSkin.Controls.MaterialFlatButton();
            this.PanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.btnNosotros = new MaterialSkin.Controls.MaterialFlatButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.TabControl.SuspendLayout();
            this.tabPageEditor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageConsola.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageErrores.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPageEditor);
            this.TabControl.Controls.Add(this.tabPageConsola);
            this.TabControl.Controls.Add(this.tabPageErrores);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(2, 6);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(700, 463);
            this.TabControl.TabIndex = 0;
            // 
            // tabPageEditor
            // 
            this.tabPageEditor.Controls.Add(this.panel1);
            this.tabPageEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditor.Name = "tabPageEditor";
            this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditor.Size = new System.Drawing.Size(692, 437);
            this.tabPageEditor.TabIndex = 0;
            this.tabPageEditor.Text = "Editor de código";
            this.tabPageEditor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.textEditorCode);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 431);
            this.panel1.TabIndex = 0;
            // 
            // textEditorCode
            // 
            this.textEditorCode.AcceptsTab = true;
            this.textEditorCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textEditorCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditorCode.DetectUrls = false;
            this.textEditorCode.Font = new System.Drawing.Font("Inconsolata", 11.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditorCode.ForeColor = System.Drawing.Color.White;
            this.textEditorCode.Location = new System.Drawing.Point(3, 3);
            this.textEditorCode.Name = "textEditorCode";
            this.textEditorCode.Size = new System.Drawing.Size(680, 425);
            this.textEditorCode.TabIndex = 1;
            this.textEditorCode.Text = "programa prueba\n{\n\n}";
            this.textEditorCode.WordWrap = false;
            // 
            // tabPageConsola
            // 
            this.tabPageConsola.Controls.Add(this.panel2);
            this.tabPageConsola.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsola.Name = "tabPageConsola";
            this.tabPageConsola.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsola.Size = new System.Drawing.Size(692, 457);
            this.tabPageConsola.TabIndex = 1;
            this.tabPageConsola.Text = "Consola";
            this.tabPageConsola.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.textConsola);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 451);
            this.panel2.TabIndex = 0;
            // 
            // textConsola
            // 
            this.textConsola.AcceptsTab = true;
            this.textConsola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textConsola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textConsola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textConsola.DetectUrls = false;
            this.textConsola.Font = new System.Drawing.Font("Inconsolata", 11.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConsola.ForeColor = System.Drawing.Color.White;
            this.textConsola.Location = new System.Drawing.Point(3, 3);
            this.textConsola.Name = "textConsola";
            this.textConsola.Size = new System.Drawing.Size(680, 425);
            this.textConsola.TabIndex = 2;
            this.textConsola.Text = "...";
            this.textConsola.WordWrap = false;
            // 
            // tabPageErrores
            // 
            this.tabPageErrores.Controls.Add(this.panel3);
            this.tabPageErrores.Location = new System.Drawing.Point(4, 22);
            this.tabPageErrores.Name = "tabPageErrores";
            this.tabPageErrores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageErrores.Size = new System.Drawing.Size(692, 457);
            this.tabPageErrores.TabIndex = 2;
            this.tabPageErrores.Text = "Lista de errores";
            this.tabPageErrores.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.textListaErrores);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 451);
            this.panel3.TabIndex = 0;
            // 
            // textListaErrores
            // 
            this.textListaErrores.AcceptsTab = true;
            this.textListaErrores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textListaErrores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textListaErrores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textListaErrores.DetectUrls = false;
            this.textListaErrores.Font = new System.Drawing.Font("Inconsolata", 11.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textListaErrores.ForeColor = System.Drawing.Color.White;
            this.textListaErrores.Location = new System.Drawing.Point(3, 3);
            this.textListaErrores.Name = "textListaErrores";
            this.textListaErrores.ReadOnly = true;
            this.textListaErrores.Size = new System.Drawing.Size(680, 425);
            this.textListaErrores.TabIndex = 2;
            this.textListaErrores.Text = "...";
            this.textListaErrores.WordWrap = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.TabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(42, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(807, 36);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMenu.Depth = 0;
            this.btnMenu.Icon = global::Suma_Platano.Properties.Resources.Menu;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Primary = false;
            this.btnMenu.Size = new System.Drawing.Size(44, 36);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.AutoSize = true;
            this.btnAbrir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbrir.Depth = 0;
            this.btnAbrir.Icon = global::Suma_Platano.Properties.Resources.Abrir;
            this.btnAbrir.Location = new System.Drawing.Point(4, 6);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbrir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Primary = false;
            this.btnAbrir.Size = new System.Drawing.Size(91, 36);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = " Abrir";
            this.toolTipMensajes.SetToolTip(this.btnAbrir, "Abrir");
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = global::Suma_Platano.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(4, 54);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(115, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = " Guardar";
            this.toolTipMensajes.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCompilar
            // 
            this.btnCompilar.AutoSize = true;
            this.btnCompilar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompilar.Depth = 0;
            this.btnCompilar.Icon = global::Suma_Platano.Properties.Resources.Compilar;
            this.btnCompilar.Location = new System.Drawing.Point(4, 102);
            this.btnCompilar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompilar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Primary = false;
            this.btnCompilar.Size = new System.Drawing.Size(121, 36);
            this.btnCompilar.TabIndex = 9;
            this.btnCompilar.Text = " Compilar";
            this.toolTipMensajes.SetToolTip(this.btnCompilar, "Compilar");
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.Depth = 0;
            this.btnIniciar.Icon = global::Suma_Platano.Properties.Resources.Iniciar;
            this.btnIniciar.Location = new System.Drawing.Point(4, 150);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Primary = false;
            this.btnIniciar.Size = new System.Drawing.Size(100, 36);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = " Iniciar";
            this.toolTipMensajes.SetToolTip(this.btnIniciar, "Iniciar");
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.btnAbrir);
            this.PanelMenu.Controls.Add(this.btnGuardar);
            this.PanelMenu.Controls.Add(this.btnCompilar);
            this.PanelMenu.Controls.Add(this.btnIniciar);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(136, 367);
            this.PanelMenu.TabIndex = 11;
            // 
            // btnNosotros
            // 
            this.btnNosotros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNosotros.AutoSize = true;
            this.btnNosotros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNosotros.Depth = 0;
            this.btnNosotros.Icon = global::Suma_Platano.Properties.Resources.SobreNosotros;
            this.btnNosotros.Location = new System.Drawing.Point(4, 450);
            this.btnNosotros.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNosotros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNosotros.Name = "btnNosotros";
            this.btnNosotros.Primary = false;
            this.btnNosotros.Size = new System.Drawing.Size(124, 36);
            this.btnNosotros.TabIndex = 0;
            this.btnNosotros.Text = " Nosotros";
            this.toolTipMensajes.SetToolTip(this.btnNosotros, "Nosotros");
            this.btnNosotros.UseVisualStyleBackColor = true;
            this.btnNosotros.Click += new System.EventHandler(this.btnNosotros_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnMenu);
            this.splitContainer1.Panel1.Controls.Add(this.materialTabSelector1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(846, 532);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.TabIndex = 13;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnNosotros);
            this.splitContainer2.Panel1.Controls.Add(this.PanelMenu);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TabControl);
            this.splitContainer2.Panel2.Controls.Add(this.ProgressBar);
            this.splitContainer2.Size = new System.Drawing.Size(846, 492);
            this.splitContainer2.SplitterDistance = 136;
            this.splitContainer2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "SPL";
            this.openFileDialog1.DereferenceLinks = false;
            this.openFileDialog1.Filter = "Archivos SPL (*.SPL)|*.SPL";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Abrir Proyecto Suma Platano (SPL)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "SPL";
            this.saveFileDialog1.FileName = "Proyecto1";
            this.saveFileDialog1.Filter = "Archivos SPL (*.SPL)|*.SPL";
            this.saveFileDialog1.Title = "Guardar Proyecto Suma Platano (SPL)";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Depth = 0;
            this.ProgressBar.Location = new System.Drawing.Point(6, 475);
            this.ProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(692, 5);
            this.ProgressBar.TabIndex = 12;
            // 
            // SumaPlatanoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 594);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(682, 520);
            this.Name = "SumaPlatanoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suma Platano";
            this.TabControl.ResumeLayout(false);
            this.tabPageEditor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageConsola.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPageErrores.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tabPageEditor;
        private System.Windows.Forms.TabPage tabPageConsola;
        private System.Windows.Forms.TabPage tabPageErrores;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton btnMenu;
        private MaterialSkin.Controls.MaterialFlatButton btnAbrir;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnCompilar;
        private MaterialSkin.Controls.MaterialFlatButton btnIniciar;
        private System.Windows.Forms.FlowLayoutPanel PanelMenu;
        private System.Windows.Forms.ToolTip toolTipMensajes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MaterialSkin.Controls.MaterialFlatButton btnNosotros;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textEditorCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textConsola;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox textListaErrores;
        private MaterialSkin.Controls.MaterialProgressBar ProgressBar;
    }
}

