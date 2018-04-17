namespace Matriz
{
    partial class Form1
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
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnLlenarColumnas = new System.Windows.Forms.Button();
            this.btnLlenarInversa = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMostrarDP = new System.Windows.Forms.Button();
            this.btnMostrarDS = new System.Windows.Forms.Button();
            this.btnAbajoDP = new System.Windows.Forms.Button();
            this.btnArribaDS = new System.Windows.Forms.Button();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnInvertirDP = new System.Windows.Forms.Button();
            this.btnInvertirDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(49, 54);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(115, 23);
            this.btnLlenar.TabIndex = 0;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnLlenarColumnas
            // 
            this.btnLlenarColumnas.Location = new System.Drawing.Point(49, 83);
            this.btnLlenarColumnas.Name = "btnLlenarColumnas";
            this.btnLlenarColumnas.Size = new System.Drawing.Size(115, 23);
            this.btnLlenarColumnas.TabIndex = 1;
            this.btnLlenarColumnas.Text = "Llenar Columnas";
            this.btnLlenarColumnas.UseVisualStyleBackColor = true;
            this.btnLlenarColumnas.Click += new System.EventHandler(this.btnLlenarColumnas_Click);
            // 
            // btnLlenarInversa
            // 
            this.btnLlenarInversa.Location = new System.Drawing.Point(49, 112);
            this.btnLlenarInversa.Name = "btnLlenarInversa";
            this.btnLlenarInversa.Size = new System.Drawing.Size(115, 23);
            this.btnLlenarInversa.TabIndex = 2;
            this.btnLlenarInversa.Text = "Llenar Inversa";
            this.btnLlenarInversa.UseVisualStyleBackColor = true;
            this.btnLlenarInversa.Click += new System.EventHandler(this.btnLlenarInversa_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(49, 141);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(115, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMostrarDP
            // 
            this.btnMostrarDP.Location = new System.Drawing.Point(49, 170);
            this.btnMostrarDP.Name = "btnMostrarDP";
            this.btnMostrarDP.Size = new System.Drawing.Size(115, 23);
            this.btnMostrarDP.TabIndex = 4;
            this.btnMostrarDP.Text = "Mostrar DP";
            this.btnMostrarDP.UseVisualStyleBackColor = true;
            this.btnMostrarDP.Click += new System.EventHandler(this.btnMostrarDP_Click);
            // 
            // btnMostrarDS
            // 
            this.btnMostrarDS.Location = new System.Drawing.Point(49, 199);
            this.btnMostrarDS.Name = "btnMostrarDS";
            this.btnMostrarDS.Size = new System.Drawing.Size(115, 23);
            this.btnMostrarDS.TabIndex = 5;
            this.btnMostrarDS.Text = "Mostrar DS";
            this.btnMostrarDS.UseVisualStyleBackColor = true;
            this.btnMostrarDS.Click += new System.EventHandler(this.btnMostrarDS_Click);
            // 
            // btnAbajoDP
            // 
            this.btnAbajoDP.Location = new System.Drawing.Point(49, 228);
            this.btnAbajoDP.Name = "btnAbajoDP";
            this.btnAbajoDP.Size = new System.Drawing.Size(115, 23);
            this.btnAbajoDP.TabIndex = 6;
            this.btnAbajoDP.Text = "Abajo DP";
            this.btnAbajoDP.UseVisualStyleBackColor = true;
            this.btnAbajoDP.Click += new System.EventHandler(this.btnAbajoDP_Click);
            // 
            // btnArribaDS
            // 
            this.btnArribaDS.Location = new System.Drawing.Point(49, 257);
            this.btnArribaDS.Name = "btnArribaDS";
            this.btnArribaDS.Size = new System.Drawing.Size(115, 23);
            this.btnArribaDS.TabIndex = 7;
            this.btnArribaDS.Text = "Arriba DS";
            this.btnArribaDS.UseVisualStyleBackColor = true;
            this.btnArribaDS.Click += new System.EventHandler(this.btnAbajoDS_Click);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrompt.Location = new System.Drawing.Point(185, 12);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrompt.Size = new System.Drawing.Size(308, 477);
            this.txtPrompt.TabIndex = 8;
            // 
            // btnInvertirDP
            // 
            this.btnInvertirDP.Location = new System.Drawing.Point(49, 286);
            this.btnInvertirDP.Name = "btnInvertirDP";
            this.btnInvertirDP.Size = new System.Drawing.Size(115, 23);
            this.btnInvertirDP.TabIndex = 9;
            this.btnInvertirDP.Text = "Invertir sobre DP";
            this.btnInvertirDP.UseVisualStyleBackColor = true;
            this.btnInvertirDP.Click += new System.EventHandler(this.btnInvertirDP_Click);
            // 
            // btnInvertirDS
            // 
            this.btnInvertirDS.Location = new System.Drawing.Point(49, 315);
            this.btnInvertirDS.Name = "btnInvertirDS";
            this.btnInvertirDS.Size = new System.Drawing.Size(115, 23);
            this.btnInvertirDS.TabIndex = 10;
            this.btnInvertirDS.Text = "Invertir sobre DS";
            this.btnInvertirDS.UseVisualStyleBackColor = true;
            this.btnInvertirDS.Click += new System.EventHandler(this.btnInvertirDS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 501);
            this.Controls.Add(this.btnInvertirDS);
            this.Controls.Add(this.btnInvertirDP);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.btnArribaDS);
            this.Controls.Add(this.btnAbajoDP);
            this.Controls.Add(this.btnMostrarDS);
            this.Controls.Add(this.btnMostrarDP);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLlenarInversa);
            this.Controls.Add(this.btnLlenarColumnas);
            this.Controls.Add(this.btnLlenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnLlenarColumnas;
        private System.Windows.Forms.Button btnLlenarInversa;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMostrarDP;
        private System.Windows.Forms.Button btnMostrarDS;
        private System.Windows.Forms.Button btnAbajoDP;
        private System.Windows.Forms.Button btnArribaDS;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnInvertirDP;
        private System.Windows.Forms.Button btnInvertirDS;
    }
}

