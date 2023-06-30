
namespace ExamenPractico
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
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.txtihss = new System.Windows.Forms.TextBox();
            this.txtrap = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txtantiguedad = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnisr = new System.Windows.Forms.Button();
            this.btnihss = new System.Windows.Forms.Button();
            this.btnrap = new System.Windows.Forms.Button();
            this.btnantiguedad = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(33, 169);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(755, 232);
            this.dgvempleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "rap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ihss";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ISR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "antiguedad";
            // 
            // txtempleado
            // 
            this.txtempleado.Location = new System.Drawing.Point(156, 33);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(100, 20);
            this.txtempleado.TabIndex = 10;
            // 
            // txtihss
            // 
            this.txtihss.Location = new System.Drawing.Point(358, 102);
            this.txtihss.Name = "txtihss";
            this.txtihss.Size = new System.Drawing.Size(100, 20);
            this.txtihss.TabIndex = 12;
            // 
            // txtrap
            // 
            this.txtrap.Location = new System.Drawing.Point(358, 59);
            this.txtrap.Name = "txtrap";
            this.txtrap.Size = new System.Drawing.Size(100, 20);
            this.txtrap.TabIndex = 13;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(358, 26);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 14;
            // 
            // txtantiguedad
            // 
            this.txtantiguedad.Location = new System.Drawing.Point(156, 99);
            this.txtantiguedad.Name = "txtantiguedad";
            this.txtantiguedad.Size = new System.Drawing.Size(100, 20);
            this.txtantiguedad.TabIndex = 15;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(156, 66);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 16;
            this.txtapellido.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 131);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 18;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnisr
            // 
            this.btnisr.Location = new System.Drawing.Point(491, 131);
            this.btnisr.Name = "btnisr";
            this.btnisr.Size = new System.Drawing.Size(151, 23);
            this.btnisr.TabIndex = 19;
            this.btnisr.Text = "calculando ISR";
            this.btnisr.UseVisualStyleBackColor = true;
            // 
            // btnihss
            // 
            this.btnihss.Location = new System.Drawing.Point(358, 131);
            this.btnihss.Name = "btnihss";
            this.btnihss.Size = new System.Drawing.Size(121, 23);
            this.btnihss.TabIndex = 20;
            this.btnihss.Text = "calculando ihss";
            this.btnihss.UseVisualStyleBackColor = true;
            // 
            // btnrap
            // 
            this.btnrap.Location = new System.Drawing.Point(254, 131);
            this.btnrap.Name = "btnrap";
            this.btnrap.Size = new System.Drawing.Size(98, 23);
            this.btnrap.TabIndex = 21;
            this.btnrap.Text = "calculando rap";
            this.btnrap.UseVisualStyleBackColor = true;
            // 
            // btnantiguedad
            // 
            this.btnantiguedad.Location = new System.Drawing.Point(107, 131);
            this.btnantiguedad.Name = "btnantiguedad";
            this.btnantiguedad.Size = new System.Drawing.Size(141, 23);
            this.btnantiguedad.TabIndex = 22;
            this.btnantiguedad.Text = "calculando antiguedad";
            this.btnantiguedad.UseVisualStyleBackColor = true;
            // 
            // btnpagar
            // 
            this.btnpagar.Location = new System.Drawing.Point(653, 131);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(135, 23);
            this.btnpagar.TabIndex = 23;
            this.btnpagar.Text = "calculando total a pagar";
            this.btnpagar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.btnantiguedad);
            this.Controls.Add(this.btnrap);
            this.Controls.Add(this.btnihss);
            this.Controls.Add(this.btnisr);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtantiguedad);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtrap);
            this.Controls.Add(this.txtihss);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvempleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.TextBox txtihss;
        private System.Windows.Forms.TextBox txtrap;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txtantiguedad;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnisr;
        private System.Windows.Forms.Button btnihss;
        private System.Windows.Forms.Button btnrap;
        private System.Windows.Forms.Button btnantiguedad;
        private System.Windows.Forms.Button btnpagar;
    }
}

