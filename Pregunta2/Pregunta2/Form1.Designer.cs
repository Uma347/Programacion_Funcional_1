namespace Pregunta2
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
            this.descripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.ccuatro = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.cuadrado = new System.Windows.Forms.Button();
            this.uno_sobre_x = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.porcentaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.BackColor = System.Drawing.Color.Transparent;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descripcion.Location = new System.Drawing.Point(18, 30);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(18, 20);
            this.descripcion.TabIndex = 53;
            this.descripcion.Text = "_";
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Open Sans Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(317, 66);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "0";
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Black;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.division.Location = new System.Drawing.Point(252, 171);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(77, 51);
            this.division.TabIndex = 44;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.Color.Black;
            this.multiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplicacion.Location = new System.Drawing.Point(252, 224);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(77, 48);
            this.multiplicacion.TabIndex = 43;
            this.multiplicacion.Text = "x";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.Black;
            this.resta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resta.Location = new System.Drawing.Point(252, 273);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(77, 48);
            this.resta.TabIndex = 42;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.Black;
            this.suma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suma.Location = new System.Drawing.Point(252, 322);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(77, 48);
            this.suma.TabIndex = 41;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.Crimson;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.igual.Location = new System.Drawing.Point(252, 371);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(77, 48);
            this.igual.TabIndex = 40;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.Black;
            this.inv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inv.Location = new System.Drawing.Point(12, 371);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(78, 48);
            this.inv.TabIndex = 39;
            this.inv.Text = "+/-";
            this.inv.UseVisualStyleBackColor = false;
            this.inv.Click += new System.EventHandler(this.inv_Click);
            // 
            // coma
            // 
            this.coma.BackColor = System.Drawing.Color.Black;
            this.coma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coma.Location = new System.Drawing.Point(172, 371);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(78, 48);
            this.coma.TabIndex = 38;
            this.coma.Text = ",";
            this.coma.UseVisualStyleBackColor = false;
            this.coma.Click += new System.EventHandler(this.coma_Click);
            // 
            // cero
            // 
            this.cero.BackColor = System.Drawing.Color.Black;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cero.Location = new System.Drawing.Point(92, 371);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(78, 48);
            this.cero.TabIndex = 37;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // nueve
            // 
            this.nueve.BackColor = System.Drawing.Color.Black;
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nueve.Location = new System.Drawing.Point(172, 322);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(78, 48);
            this.nueve.TabIndex = 36;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = false;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // ocho
            // 
            this.ocho.BackColor = System.Drawing.Color.Black;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ocho.Location = new System.Drawing.Point(92, 322);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(78, 48);
            this.ocho.TabIndex = 35;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = false;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // siete
            // 
            this.siete.BackColor = System.Drawing.Color.Black;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siete.Location = new System.Drawing.Point(12, 322);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(78, 48);
            this.siete.TabIndex = 34;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = false;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.Black;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seis.Location = new System.Drawing.Point(172, 273);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(78, 48);
            this.seis.TabIndex = 33;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.Black;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cinco.Location = new System.Drawing.Point(92, 273);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(78, 48);
            this.cinco.TabIndex = 32;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // ccuatro
            // 
            this.ccuatro.BackColor = System.Drawing.Color.Black;
            this.ccuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccuatro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ccuatro.Location = new System.Drawing.Point(12, 273);
            this.ccuatro.Name = "ccuatro";
            this.ccuatro.Size = new System.Drawing.Size(78, 48);
            this.ccuatro.TabIndex = 31;
            this.ccuatro.Text = "4";
            this.ccuatro.UseVisualStyleBackColor = false;
            this.ccuatro.Click += new System.EventHandler(this.ccuatro_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.Black;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tres.Location = new System.Drawing.Point(172, 224);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(78, 48);
            this.tres.TabIndex = 30;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dos
            // 
            this.dos.BackColor = System.Drawing.Color.Black;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dos.Location = new System.Drawing.Point(92, 224);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(78, 48);
            this.dos.TabIndex = 29;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = false;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // uno
            // 
            this.uno.BackColor = System.Drawing.Color.Black;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uno.Location = new System.Drawing.Point(12, 224);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(78, 48);
            this.uno.TabIndex = 28;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = false;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // raiz
            // 
            this.raiz.BackgroundImage = global::Pregunta2.Properties.Resources.raiz;
            this.raiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(172, 171);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(78, 51);
            this.raiz.TabIndex = 51;
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // cuadrado
            // 
            this.cuadrado.BackgroundImage = global::Pregunta2.Properties.Resources.cuadrado1;
            this.cuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadrado.Location = new System.Drawing.Point(92, 171);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(78, 51);
            this.cuadrado.TabIndex = 50;
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.Click += new System.EventHandler(this.cuadrado_Click);
            // 
            // uno_sobre_x
            // 
            this.uno_sobre_x.BackgroundImage = global::Pregunta2.Properties.Resources.elevado_a_la_menos_1;
            this.uno_sobre_x.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uno_sobre_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno_sobre_x.Location = new System.Drawing.Point(12, 171);
            this.uno_sobre_x.Name = "uno_sobre_x";
            this.uno_sobre_x.Size = new System.Drawing.Size(78, 51);
            this.uno_sobre_x.TabIndex = 49;
            this.uno_sobre_x.UseVisualStyleBackColor = true;
            this.uno_sobre_x.Click += new System.EventHandler(this.uno_sobre_x_Click);
            // 
            // borrar
            // 
            this.borrar.BackgroundImage = global::Pregunta2.Properties.Resources.borrar;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(252, 114);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(78, 55);
            this.borrar.TabIndex = 48;
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // C
            // 
            this.C.BackgroundImage = global::Pregunta2.Properties.Resources.C;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(172, 114);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(78, 55);
            this.C.TabIndex = 47;
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // CE
            // 
            this.CE.BackgroundImage = global::Pregunta2.Properties.Resources.CE;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(92, 114);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(78, 55);
            this.CE.TabIndex = 46;
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // porcentaje
            // 
            this.porcentaje.BackgroundImage = global::Pregunta2.Properties.Resources.porcentaje;
            this.porcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje.Location = new System.Drawing.Point(12, 114);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(78, 55);
            this.porcentaje.TabIndex = 45;
            this.porcentaje.UseVisualStyleBackColor = true;
            this.porcentaje.Click += new System.EventHandler(this.porcentaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(339, 429);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.uno_sobre_x);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.ccuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button cuadrado;
        private System.Windows.Forms.Button uno_sobre_x;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button porcentaje;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button inv;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button ccuatro;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button uno;
    }
}

