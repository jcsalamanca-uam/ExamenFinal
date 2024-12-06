namespace ExamenFinal
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
            this.TbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbCantidad = new System.Windows.Forms.TextBox();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.DGVReporte_ = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TbEliminarID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte_)).BeginInit();
            this.SuspendLayout();
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(109, 48);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(100, 22);
            this.TbID.TabIndex = 0;
            this.TbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(109, 94);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 22);
            this.TbNombre.TabIndex = 5;
            this.TbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TbCantidad
            // 
            this.TbCantidad.Location = new System.Drawing.Point(109, 201);
            this.TbCantidad.Name = "TbCantidad";
            this.TbCantidad.Size = new System.Drawing.Size(100, 22);
            this.TbCantidad.TabIndex = 6;
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(109, 144);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(100, 22);
            this.TbPrecio.TabIndex = 7;
            // 
            // DGVReporte_
            // 
            this.DGVReporte_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReporte_.Location = new System.Drawing.Point(85, 229);
            this.DGVReporte_.Name = "DGVReporte_";
            this.DGVReporte_.RowHeadersWidth = 51;
            this.DGVReporte_.RowTemplate.Height = 24;
            this.DGVReporte_.Size = new System.Drawing.Size(587, 214);
            this.DGVReporte_.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(656, 38);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 29);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(656, 137);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // TbEliminarID
            // 
            this.TbEliminarID.Location = new System.Drawing.Point(520, 93);
            this.TbEliminarID.Name = "TbEliminarID";
            this.TbEliminarID.Size = new System.Drawing.Size(100, 22);
            this.TbEliminarID.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbEliminarID);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DGVReporte_);
            this.Controls.Add(this.TbPrecio);
            this.Controls.Add(this.TbCantidad);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbCantidad;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.DataGridView DGVReporte_;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TbEliminarID;
    }
}

