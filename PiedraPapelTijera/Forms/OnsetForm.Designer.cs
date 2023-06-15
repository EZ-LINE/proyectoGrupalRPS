namespace Forms
{
    partial class OnsetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonIniciar = new Customs.MyButtons();
            SuspendLayout();
            // 
            // botonIniciar
            // 
            botonIniciar.BackColor = Color.HotPink;
            botonIniciar.BackgroundColor = Color.HotPink;
            botonIniciar.BorderColor = Color.Gold;
            botonIniciar.BorderRadius = 60;
            botonIniciar.BorderSize = 3;
            botonIniciar.FlatAppearance.BorderSize = 0;
            botonIniciar.FlatAppearance.MouseOverBackColor = Color.Magenta;
            botonIniciar.FlatStyle = FlatStyle.Flat;
            botonIniciar.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botonIniciar.ForeColor = Color.DarkTurquoise;
            botonIniciar.Location = new Point(365, 340);
            botonIniciar.Name = "botonIniciar";
            botonIniciar.Size = new Size(70, 70);
            botonIniciar.TabIndex = 0;
            botonIniciar.Text = "INICIA JUEGO";
            botonIniciar.TextColor = Color.DarkTurquoise;
            botonIniciar.UseVisualStyleBackColor = false;
            botonIniciar.Click += botonIniciar_Click;
            // 
            // OnsetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.piedraPapelTijera;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 416);
            Controls.Add(botonIniciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OnsetForm";
            Text = "OnsetForm";
            ResumeLayout(false);
        }

        #endregion

        private Customs.MyButtons botonIniciar;
    }
}