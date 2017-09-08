namespace CopiaPdp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnPathDestino = new System.Windows.Forms.Button();
            this.btnPathOrigen = new System.Windows.Forms.Button();
            this.txtPathDestino = new System.Windows.Forms.TextBox();
            this.txtPathOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrigen = new System.Windows.Forms.DataGridView();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowFullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblTrabajando = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTrabajando);
            this.groupBox1.Controls.Add(this.pbProgreso);
            this.groupBox1.Controls.Add(this.btnCopiar);
            this.groupBox1.Controls.Add(this.btnPathDestino);
            this.groupBox1.Controls.Add(this.btnPathOrigen);
            this.groupBox1.Controls.Add(this.txtPathDestino);
            this.groupBox1.Controls.Add(this.txtPathOrigen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen/Destino";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(597, 59);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnPathDestino
            // 
            this.btnPathDestino.Location = new System.Drawing.Point(516, 59);
            this.btnPathDestino.Name = "btnPathDestino";
            this.btnPathDestino.Size = new System.Drawing.Size(75, 23);
            this.btnPathDestino.TabIndex = 5;
            this.btnPathDestino.Text = "Seleccionar";
            this.btnPathDestino.UseVisualStyleBackColor = true;
            this.btnPathDestino.Click += new System.EventHandler(this.btnPathDestino_Click);
            // 
            // btnPathOrigen
            // 
            this.btnPathOrigen.Location = new System.Drawing.Point(516, 23);
            this.btnPathOrigen.Name = "btnPathOrigen";
            this.btnPathOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnPathOrigen.TabIndex = 4;
            this.btnPathOrigen.Text = "Seleccionar";
            this.btnPathOrigen.UseVisualStyleBackColor = true;
            this.btnPathOrigen.Click += new System.EventHandler(this.btnPathOrigen_Click);
            // 
            // txtPathDestino
            // 
            this.txtPathDestino.Enabled = false;
            this.txtPathDestino.Location = new System.Drawing.Point(75, 61);
            this.txtPathDestino.Name = "txtPathDestino";
            this.txtPathDestino.Size = new System.Drawing.Size(423, 20);
            this.txtPathDestino.TabIndex = 3;
            // 
            // txtPathOrigen
            // 
            this.txtPathOrigen.Enabled = false;
            this.txtPathOrigen.Location = new System.Drawing.Point(75, 25);
            this.txtPathOrigen.Name = "txtPathOrigen";
            this.txtPathOrigen.Size = new System.Drawing.Size(423, 20);
            this.txtPathOrigen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Origen";
            // 
            // dgvOrigen
            // 
            this.dgvOrigen.AllowUserToAddRows = false;
            this.dgvOrigen.AllowUserToDeleteRows = false;
            this.dgvOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowPath,
            this.RowFullPath});
            this.dgvOrigen.Location = new System.Drawing.Point(12, 127);
            this.dgvOrigen.Name = "dgvOrigen";
            this.dgvOrigen.ReadOnly = true;
            this.dgvOrigen.RowHeadersVisible = false;
            this.dgvOrigen.Size = new System.Drawing.Size(324, 393);
            this.dgvOrigen.TabIndex = 1;
            // 
            // dgvDestino
            // 
            this.dgvDestino.AllowUserToAddRows = false;
            this.dgvDestino.AllowUserToDeleteRows = false;
            this.dgvDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvDestino.Location = new System.Drawing.Point(353, 127);
            this.dgvDestino.Name = "dgvDestino";
            this.dgvDestino.ReadOnly = true;
            this.dgvDestino.RowHeadersVisible = false;
            this.dgvDestino.Size = new System.Drawing.Size(331, 393);
            this.dgvDestino.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Carpetas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // RowPath
            // 
            this.RowPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RowPath.HeaderText = "Archivos PDP";
            this.RowPath.Name = "RowPath";
            this.RowPath.ReadOnly = true;
            // 
            // RowFullPath
            // 
            this.RowFullPath.HeaderText = "Column1";
            this.RowFullPath.Name = "RowFullPath";
            this.RowFullPath.ReadOnly = true;
            this.RowFullPath.Visible = false;
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(75, 87);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(151, 23);
            this.pbProgreso.TabIndex = 7;
            // 
            // lblTrabajando
            // 
            this.lblTrabajando.AutoSize = true;
            this.lblTrabajando.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajando.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTrabajando.Location = new System.Drawing.Point(232, 87);
            this.lblTrabajando.Name = "lblTrabajando";
            this.lblTrabajando.Size = new System.Drawing.Size(15, 18);
            this.lblTrabajando.TabIndex = 8;
            this.lblTrabajando.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 532);
            this.Controls.Add(this.dgvDestino);
            this.Controls.Add(this.dgvOrigen);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PDP Copy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPathDestino;
        private System.Windows.Forms.Button btnPathOrigen;
        private System.Windows.Forms.TextBox txtPathDestino;
        private System.Windows.Forms.TextBox txtPathOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrigen;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowFullPath;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lblTrabajando;
    }
}

