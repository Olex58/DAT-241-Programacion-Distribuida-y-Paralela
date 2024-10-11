namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butSuma = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.butPunto = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.butIgual = new System.Windows.Forms.Button();
            this.butResta = new System.Windows.Forms.Button();
            this.butMulti = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.butBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(356, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butSuma
            // 
            this.butSuma.Location = new System.Drawing.Point(12, 78);
            this.butSuma.Name = "butSuma";
            this.butSuma.Size = new System.Drawing.Size(68, 67);
            this.butSuma.TabIndex = 1;
            this.butSuma.Text = "+";
            this.butSuma.UseVisualStyleBackColor = true;
            this.butSuma.Click += new System.EventHandler(this.butSuma_Click);
            // 
            // but7
            // 
            this.but7.Location = new System.Drawing.Point(27, 151);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(92, 67);
            this.but7.TabIndex = 4;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // but8
            // 
            this.but8.Location = new System.Drawing.Point(146, 151);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(92, 67);
            this.but8.TabIndex = 5;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but9
            // 
            this.but9.Location = new System.Drawing.Point(264, 151);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(92, 67);
            this.but9.TabIndex = 6;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(27, 224);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(92, 67);
            this.but4.TabIndex = 7;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // but5
            // 
            this.but5.Location = new System.Drawing.Point(146, 224);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(92, 67);
            this.but5.TabIndex = 8;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but6
            // 
            this.but6.Location = new System.Drawing.Point(264, 224);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(92, 67);
            this.but6.TabIndex = 9;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(27, 297);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(92, 67);
            this.but1.TabIndex = 10;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(146, 297);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(92, 67);
            this.but2.TabIndex = 11;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(264, 297);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(92, 67);
            this.but3.TabIndex = 12;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // butPunto
            // 
            this.butPunto.Location = new System.Drawing.Point(27, 370);
            this.butPunto.Name = "butPunto";
            this.butPunto.Size = new System.Drawing.Size(92, 67);
            this.butPunto.TabIndex = 13;
            this.butPunto.Text = ".";
            this.butPunto.UseVisualStyleBackColor = true;
            // 
            // but0
            // 
            this.but0.Location = new System.Drawing.Point(146, 370);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(92, 67);
            this.but0.TabIndex = 14;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            this.but0.Click += new System.EventHandler(this.but0_Click);
            // 
            // butIgual
            // 
            this.butIgual.Location = new System.Drawing.Point(264, 370);
            this.butIgual.Name = "butIgual";
            this.butIgual.Size = new System.Drawing.Size(92, 67);
            this.butIgual.TabIndex = 15;
            this.butIgual.Text = "=";
            this.butIgual.UseVisualStyleBackColor = true;
            this.butIgual.Click += new System.EventHandler(this.butIgual_Click);
            // 
            // butResta
            // 
            this.butResta.Location = new System.Drawing.Point(86, 78);
            this.butResta.Name = "butResta";
            this.butResta.Size = new System.Drawing.Size(68, 67);
            this.butResta.TabIndex = 16;
            this.butResta.Text = "-";
            this.butResta.UseVisualStyleBackColor = true;
            this.butResta.Click += new System.EventHandler(this.butResta_Click);
            // 
            // butMulti
            // 
            this.butMulti.Location = new System.Drawing.Point(160, 78);
            this.butMulti.Name = "butMulti";
            this.butMulti.Size = new System.Drawing.Size(68, 67);
            this.butMulti.TabIndex = 17;
            this.butMulti.Text = "x";
            this.butMulti.UseVisualStyleBackColor = true;
            this.butMulti.Click += new System.EventHandler(this.butMulti_Click);
            // 
            // butDiv
            // 
            this.butDiv.Location = new System.Drawing.Point(234, 78);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(68, 67);
            this.butDiv.TabIndex = 18;
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.butDiv_Click);
            // 
            // butBorrar
            // 
            this.butBorrar.Location = new System.Drawing.Point(308, 78);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(68, 67);
            this.butBorrar.TabIndex = 19;
            this.butBorrar.Text = "C";
            this.butBorrar.UseVisualStyleBackColor = true;
            this.butBorrar.Click += new System.EventHandler(this.butBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 468);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butMulti);
            this.Controls.Add(this.butResta);
            this.Controls.Add(this.butIgual);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.butPunto);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.butSuma);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butSuma;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button butPunto;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button butIgual;
        private System.Windows.Forms.Button butResta;
        private System.Windows.Forms.Button butMulti;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Button butBorrar;
    }
}

