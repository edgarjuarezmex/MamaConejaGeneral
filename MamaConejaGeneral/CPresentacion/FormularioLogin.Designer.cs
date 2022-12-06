
namespace MamaConejaGeneral
{
    partial class FormularioLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLogin));
            this.MenuStripGeneral = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.ButtomSalir = new System.Windows.Forms.Button();
            this.ButtomIniciarSesion = new System.Windows.Forms.Button();
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.TextBoxNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStripGeneral.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.GroupBoxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripGeneral
            // 
            this.MenuStripGeneral.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuStripGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            resources.ApplyResources(this.MenuStripGeneral, "MenuStripGeneral");
            this.MenuStripGeneral.Name = "MenuStripGeneral";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarAltF4ToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // cerrarAltF4ToolStripMenuItem
            // 
            this.cerrarAltF4ToolStripMenuItem.Name = "cerrarAltF4ToolStripMenuItem";
            resources.ApplyResources(this.cerrarAltF4ToolStripMenuItem, "cerrarAltF4ToolStripMenuItem");
            this.cerrarAltF4ToolStripMenuItem.Click += new System.EventHandler(this.cerrarAltF4ToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            resources.ApplyResources(this.acercaDeToolStripMenuItem, "acercaDeToolStripMenuItem");
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MamaConejaGeneral.Properties.Resources.LogoConeja;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.GroupBoxPrincipal, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // GroupBoxPrincipal
            // 
            this.GroupBoxPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxPrincipal.Controls.Add(this.ButtomSalir);
            this.GroupBoxPrincipal.Controls.Add(this.ButtomIniciarSesion);
            this.GroupBoxPrincipal.Controls.Add(this.TextBoxContraseña);
            this.GroupBoxPrincipal.Controls.Add(this.TextBoxNumeroEmpleado);
            this.GroupBoxPrincipal.Controls.Add(this.label2);
            this.GroupBoxPrincipal.Controls.Add(this.label1);
            resources.ApplyResources(this.GroupBoxPrincipal, "GroupBoxPrincipal");
            this.GroupBoxPrincipal.Name = "GroupBoxPrincipal";
            this.GroupBoxPrincipal.TabStop = false;
            // 
            // ButtomSalir
            // 
            this.ButtomSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.ButtomSalir, "ButtomSalir");
            this.ButtomSalir.ForeColor = System.Drawing.Color.White;
            this.ButtomSalir.Name = "ButtomSalir";
            this.ButtomSalir.UseVisualStyleBackColor = false;
            this.ButtomSalir.Click += new System.EventHandler(this.ButtomSalir_Click);
            // 
            // ButtomIniciarSesion
            // 
            this.ButtomIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.ButtomIniciarSesion, "ButtomIniciarSesion");
            this.ButtomIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.ButtomIniciarSesion.Name = "ButtomIniciarSesion";
            this.ButtomIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // TextBoxContraseña
            // 
            resources.ApplyResources(this.TextBoxContraseña, "TextBoxContraseña");
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            // 
            // TextBoxNumeroEmpleado
            // 
            resources.ApplyResources(this.TextBoxNumeroEmpleado, "TextBoxNumeroEmpleado");
            this.TextBoxNumeroEmpleado.Name = "TextBoxNumeroEmpleado";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormularioLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::MamaConejaGeneral.Properties.Resources.Fondo;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.MenuStripGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStripGeneral;
            this.MaximizeBox = false;
            this.Name = "FormularioLogin";
            this.Load += new System.EventHandler(this.FormularioLogin_Load);
            this.MenuStripGeneral.ResumeLayout(false);
            this.MenuStripGeneral.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.GroupBoxPrincipal.ResumeLayout(false);
            this.GroupBoxPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStripGeneral;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAltF4ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox GroupBoxPrincipal;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.TextBox TextBoxNumeroEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtomSalir;
        private System.Windows.Forms.Button ButtomIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

