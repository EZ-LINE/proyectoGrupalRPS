namespace Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelBarraHerramientas = new Panel();
            picCerrar = new PictureBox();
            picMinimizar = new PictureBox();
            labelTitulo = new Label();
            picIcono = new PictureBox();
            panelContainer = new Panel();
            panel1 = new Panel();
            panelBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            SuspendLayout();
            // 
            // panelBarraHerramientas
            // 
            panelBarraHerramientas.BackColor = Color.SpringGreen;
            panelBarraHerramientas.Controls.Add(picCerrar);
            panelBarraHerramientas.Controls.Add(picMinimizar);
            panelBarraHerramientas.Controls.Add(labelTitulo);
            panelBarraHerramientas.Controls.Add(picIcono);
            panelBarraHerramientas.Location = new Point(0, 0);
            panelBarraHerramientas.Name = "panelBarraHerramientas";
            panelBarraHerramientas.Size = new Size(800, 35);
            panelBarraHerramientas.TabIndex = 0;
            panelBarraHerramientas.MouseDown += panelBarraHerramientas_MouseDown;
            // 
            // picCerrar
            // 
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = Properties.Resources.cerrar;
            picCerrar.Location = new Point(758, 3);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(30, 30);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 1;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinimizar
            // 
            picMinimizar.BackgroundImageLayout = ImageLayout.Zoom;
            picMinimizar.Image = Properties.Resources.minimizar;
            picMinimizar.Location = new Point(713, 2);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(30, 30);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 1;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Permanent Marker", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Fuchsia;
            labelTitulo.Location = new Point(49, 3);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(219, 27);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Piedra, Papel o Tijera";
            // 
            // picIcono
            // 
            picIcono.BackColor = SystemColors.Control;
            picIcono.BackgroundImageLayout = ImageLayout.Zoom;
            picIcono.Image = Properties.Resources.icono;
            picIcono.Location = new Point(3, 3);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(40, 30);
            picIcono.SizeMode = PictureBoxSizeMode.Zoom;
            picIcono.TabIndex = 1;
            picIcono.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.ActiveCaption;
            panelContainer.Location = new Point(0, 35);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 416);
            panelContainer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panelBarraHerramientas);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            panelBarraHerramientas.ResumeLayout(false);
            panelBarraHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBarraHerramientas;
        private PictureBox picIcono;
        private Label labelTitulo;
        private PictureBox picMinimizar;
        private PictureBox picCerrar;
        private Panel panelContainer;
        private Panel panel1;
    }
}