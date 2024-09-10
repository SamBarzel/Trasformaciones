namespace Trasformaciones
{
    partial class Form1
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
            plano = new PictureBox();
            btnPoligono = new Button();
            ((System.ComponentModel.ISupportInitialize)plano).BeginInit();
            SuspendLayout();
            // 
            // plano
            // 
            plano.Location = new Point(243, 32);
            plano.Name = "plano";
            plano.Size = new Size(600, 600);
            plano.TabIndex = 0;
            plano.TabStop = false;
            plano.Paint += plano_Paint;
            // 
            // btnPoligono
            // 
            btnPoligono.Location = new Point(40, 78);
            btnPoligono.Name = "btnPoligono";
            btnPoligono.Size = new Size(153, 60);
            btnPoligono.TabIndex = 1;
            btnPoligono.Text = "Dibujar Poligono";
            btnPoligono.UseVisualStyleBackColor = true;
            btnPoligono.Click += btnPoligono_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 670);
            Controls.Add(btnPoligono);
            Controls.Add(plano);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)plano).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox plano;
        private Button btnPoligono;
    }
}
