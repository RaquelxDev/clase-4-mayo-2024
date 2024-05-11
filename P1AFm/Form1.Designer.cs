namespace P1AFm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1Inicio = new System.Windows.Forms.Button();
            this.label2USR = new System.Windows.Forms.Label();
            this.label3Pass = new System.Windows.Forms.Label();
            this.textBox1USR = new System.Windows.Forms.TextBox();
            this.textBox2Pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(457, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(142, 54);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Padre: Form1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::P1AFm.Properties.Resources.imagen;
            this.pictureBox1.Location = new System.Drawing.Point(64, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1Inicio
            // 
            this.button1Inicio.BackColor = System.Drawing.Color.Gold;
            this.button1Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Inicio.Location = new System.Drawing.Point(424, 327);
            this.button1Inicio.Name = "button1Inicio";
            this.button1Inicio.Size = new System.Drawing.Size(154, 58);
            this.button1Inicio.TabIndex = 3;
            this.button1Inicio.Text = "Ingreso";
            this.button1Inicio.UseVisualStyleBackColor = false;
            this.button1Inicio.Click += new System.EventHandler(this.button1Inicio_Click);
            // 
            // label2USR
            // 
            this.label2USR.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2USR.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2USR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2USR.Location = new System.Drawing.Point(306, 153);
            this.label2USR.Name = "label2USR";
            this.label2USR.Size = new System.Drawing.Size(113, 35);
            this.label2USR.TabIndex = 4;
            this.label2USR.Text = "Usuario";
            // 
            // label3Pass
            // 
            this.label3Pass.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Pass.Location = new System.Drawing.Point(306, 216);
            this.label3Pass.Name = "label3Pass";
            this.label3Pass.Size = new System.Drawing.Size(154, 35);
            this.label3Pass.TabIndex = 5;
            this.label3Pass.Text = "Contraseña";
            // 
            // textBox1USR
            // 
            this.textBox1USR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1USR.Location = new System.Drawing.Point(525, 160);
            this.textBox1USR.Name = "textBox1USR";
            this.textBox1USR.Size = new System.Drawing.Size(145, 38);
            this.textBox1USR.TabIndex = 6;
            // 
            // textBox2Pass
            // 
            this.textBox2Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Pass.Location = new System.Drawing.Point(525, 223);
            this.textBox2Pass.Name = "textBox2Pass";
            this.textBox2Pass.PasswordChar = '*';
            this.textBox2Pass.Size = new System.Drawing.Size(145, 38);
            this.textBox2Pass.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1023, 559);
            this.Controls.Add(this.textBox2Pass);
            this.Controls.Add(this.textBox1USR);
            this.Controls.Add(this.label3Pass);
            this.Controls.Add(this.label2USR);
            this.Controls.Add(this.button1Inicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MY APP";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Inicio;
        private System.Windows.Forms.Label label2USR;
        private System.Windows.Forms.Label label3Pass;
        private System.Windows.Forms.TextBox textBox1USR;
        private System.Windows.Forms.TextBox textBox2Pass;
    }
}

