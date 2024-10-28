namespace RutaCorta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodoInicio = new System.Windows.Forms.TextBox();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.Nodo0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nodo11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNodoDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dijkstra - Ruta más corta ";
            // 
            // txtNodoInicio
            // 
            this.txtNodoInicio.Location = new System.Drawing.Point(223, 77);
            this.txtNodoInicio.Name = "txtNodoInicio";
            this.txtNodoInicio.Size = new System.Drawing.Size(100, 22);
            this.txtNodoInicio.TabIndex = 1;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.AllowUserToResizeRows = false;
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nodo0,
            this.Nodo1,
            this.Nodo2,
            this.Nodo3,
            this.Nodo4,
            this.Nodo5,
            this.Nodo6,
            this.Nodo7,
            this.Nodo8,
            this.Nodo9,
            this.Nodo10,
            this.Nodo11});
            this.dgvMatriz.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMatriz.Location = new System.Drawing.Point(47, 202);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(719, 49);
            this.dgvMatriz.TabIndex = 2;
            // 
            // Nodo0
            // 
            this.Nodo0.HeaderText = "A";
            this.Nodo0.MinimumWidth = 6;
            this.Nodo0.Name = "Nodo0";
            // 
            // Nodo1
            // 
            this.Nodo1.HeaderText = "B";
            this.Nodo1.MinimumWidth = 6;
            this.Nodo1.Name = "Nodo1";
            // 
            // Nodo2
            // 
            this.Nodo2.HeaderText = "C";
            this.Nodo2.MinimumWidth = 6;
            this.Nodo2.Name = "Nodo2";
            // 
            // Nodo3
            // 
            this.Nodo3.HeaderText = "D";
            this.Nodo3.MinimumWidth = 6;
            this.Nodo3.Name = "Nodo3";
            // 
            // Nodo4
            // 
            this.Nodo4.HeaderText = "E";
            this.Nodo4.MinimumWidth = 6;
            this.Nodo4.Name = "Nodo4";
            // 
            // Nodo5
            // 
            this.Nodo5.HeaderText = "F";
            this.Nodo5.MinimumWidth = 6;
            this.Nodo5.Name = "Nodo5";
            // 
            // Nodo6
            // 
            this.Nodo6.HeaderText = "G";
            this.Nodo6.MinimumWidth = 6;
            this.Nodo6.Name = "Nodo6";
            // 
            // Nodo7
            // 
            this.Nodo7.HeaderText = "H";
            this.Nodo7.MinimumWidth = 6;
            this.Nodo7.Name = "Nodo7";
            // 
            // Nodo8
            // 
            this.Nodo8.HeaderText = "I";
            this.Nodo8.MinimumWidth = 6;
            this.Nodo8.Name = "Nodo8";
            // 
            // Nodo9
            // 
            this.Nodo9.HeaderText = "J";
            this.Nodo9.MinimumWidth = 6;
            this.Nodo9.Name = "Nodo9";
            // 
            // Nodo10
            // 
            this.Nodo10.HeaderText = "K";
            this.Nodo10.MinimumWidth = 6;
            this.Nodo10.Name = "Nodo10";
            // 
            // Nodo11
            // 
            this.Nodo11.HeaderText = "L";
            this.Nodo11.MinimumWidth = 6;
            this.Nodo11.Name = "Nodo11";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(493, 98);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "La ruta más corta es:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(396, 357);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "label3";
            // 
            // txtNodoDestino
            // 
            this.txtNodoDestino.Location = new System.Drawing.Point(223, 123);
            this.txtNodoDestino.Name = "txtNodoDestino";
            this.txtNodoDestino.Size = new System.Drawing.Size(100, 22);
            this.txtNodoDestino.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nodo inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nodo final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNodoDestino);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.txtNodoInicio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNodoInicio;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNodoDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nodo11;
    }
}

