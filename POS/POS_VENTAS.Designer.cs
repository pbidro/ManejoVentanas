namespace POS
{
    partial class POS_VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_VENTAS));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Ventas = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SimpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.LTotal = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Pagar = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TabControl1.SuspendLayout();
            this.Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Pagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Ventas);
            this.TabControl1.Controls.Add(this.Pagar);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.MinimumSize = new System.Drawing.Size(973, 451);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(977, 451);
            this.TabControl1.TabIndex = 2;
            // 
            // Ventas
            // 
            this.Ventas.Controls.Add(this.gridControl1);
            this.Ventas.Controls.Add(this.SimpleButton12);
            this.Ventas.Controls.Add(this.SimpleButton11);
            this.Ventas.Controls.Add(this.SimpleButton10);
            this.Ventas.Controls.Add(this.SimpleButton9);
            this.Ventas.Controls.Add(this.SimpleButton3);
            this.Ventas.Controls.Add(this.SimpleButton2);
            this.Ventas.Controls.Add(this.SimpleButton8);
            this.Ventas.Controls.Add(this.SimpleButton7);
            this.Ventas.Controls.Add(this.SimpleButton6);
            this.Ventas.Controls.Add(this.SimpleButton5);
            this.Ventas.Controls.Add(this.SimpleButton4);
            this.Ventas.Controls.Add(this.SimpleButton1);
            this.Ventas.Controls.Add(this.LTotal);
            this.Ventas.Controls.Add(this.Label2);
            this.Ventas.Controls.Add(this.txtBuscar);
            this.Ventas.Controls.Add(this.Label1);
            this.Ventas.Location = new System.Drawing.Point(4, 22);
            this.Ventas.Name = "Ventas";
            this.Ventas.Padding = new System.Windows.Forms.Padding(3);
            this.Ventas.Size = new System.Drawing.Size(969, 425);
            this.Ventas.TabIndex = 0;
            this.Ventas.Text = " Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(10, 97);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(951, 270);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SimpleButton12
            // 
            this.SimpleButton12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButton12.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton12.Image")));
            this.SimpleButton12.Location = new System.Drawing.Point(861, 373);
            this.SimpleButton12.Name = "SimpleButton12";
            this.SimpleButton12.Size = new System.Drawing.Size(100, 35);
            this.SimpleButton12.TabIndex = 32;
            this.SimpleButton12.Text = "F12 Pagar";
            // 
            // SimpleButton11
            // 
            this.SimpleButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimpleButton11.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton11.Image")));
            this.SimpleButton11.Location = new System.Drawing.Point(116, 373);
            this.SimpleButton11.Name = "SimpleButton11";
            this.SimpleButton11.Size = new System.Drawing.Size(100, 35);
            this.SimpleButton11.TabIndex = 31;
            this.SimpleButton11.Text = "Vista Previa";
            // 
            // SimpleButton10
            // 
            this.SimpleButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SimpleButton10.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton10.Image")));
            this.SimpleButton10.Location = new System.Drawing.Point(10, 373);
            this.SimpleButton10.Name = "SimpleButton10";
            this.SimpleButton10.Size = new System.Drawing.Size(100, 35);
            this.SimpleButton10.TabIndex = 30;
            this.SimpleButton10.Text = "Atrás";
            // 
            // SimpleButton9
            // 
            this.SimpleButton9.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton9.Image")));
            this.SimpleButton9.Location = new System.Drawing.Point(222, 56);
            this.SimpleButton9.Name = "SimpleButton9";
            this.SimpleButton9.Size = new System.Drawing.Size(170, 35);
            this.SimpleButton9.TabIndex = 30;
            this.SimpleButton9.Text = "Enter - Agregar producto";
            // 
            // SimpleButton3
            // 
            this.SimpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton3.Image")));
            this.SimpleButton3.Location = new System.Drawing.Point(116, 56);
            this.SimpleButton3.Name = "SimpleButton3";
            this.SimpleButton3.Size = new System.Drawing.Size(100, 35);
            this.SimpleButton3.TabIndex = 29;
            this.SimpleButton3.Text = "Eliminar";
            // 
            // SimpleButton2
            // 
            this.SimpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton2.Image")));
            this.SimpleButton2.Location = new System.Drawing.Point(10, 56);
            this.SimpleButton2.Name = "SimpleButton2";
            this.SimpleButton2.Size = new System.Drawing.Size(100, 35);
            this.SimpleButton2.TabIndex = 28;
            this.SimpleButton2.Text = "F2 Editar";
            // 
            // SimpleButton8
            // 
            this.SimpleButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SimpleButton8.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton8.Image")));
            this.SimpleButton8.Location = new System.Drawing.Point(847, 13);
            this.SimpleButton8.Name = "SimpleButton8";
            this.SimpleButton8.Size = new System.Drawing.Size(114, 35);
            this.SimpleButton8.TabIndex = 27;
            this.SimpleButton8.Text = "Pendientes";
            // 
            // SimpleButton7
            // 
            this.SimpleButton7.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton7.Image")));
            this.SimpleButton7.Location = new System.Drawing.Point(683, 13);
            this.SimpleButton7.Name = "SimpleButton7";
            this.SimpleButton7.Size = new System.Drawing.Size(43, 35);
            this.SimpleButton7.TabIndex = 26;
            // 
            // SimpleButton6
            // 
            this.SimpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton6.Image")));
            this.SimpleButton6.Location = new System.Drawing.Point(781, 13);
            this.SimpleButton6.Name = "SimpleButton6";
            this.SimpleButton6.Size = new System.Drawing.Size(43, 35);
            this.SimpleButton6.TabIndex = 25;
            // 
            // SimpleButton5
            // 
            this.SimpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton5.Image")));
            this.SimpleButton5.Location = new System.Drawing.Point(732, 13);
            this.SimpleButton5.Name = "SimpleButton5";
            this.SimpleButton5.Size = new System.Drawing.Size(43, 35);
            this.SimpleButton5.TabIndex = 24;
            // 
            // SimpleButton4
            // 
            this.SimpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton4.Image")));
            this.SimpleButton4.Location = new System.Drawing.Point(633, 13);
            this.SimpleButton4.Name = "SimpleButton4";
            this.SimpleButton4.Size = new System.Drawing.Size(43, 35);
            this.SimpleButton4.TabIndex = 21;
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.ImageUri.Uri = "Zoom";
            this.SimpleButton1.Location = new System.Drawing.Point(513, 15);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(100, 31);
            this.SimpleButton1.TabIndex = 17;
            this.SimpleButton1.Text = "F1 Buscar";
            // 
            // LTotal
            // 
            this.LTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.LTotal.Location = new System.Drawing.Point(814, 375);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(25, 30);
            this.LTotal.TabIndex = 15;
            this.LTotal.Text = "0";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label2.Location = new System.Drawing.Point(606, 375);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 30);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Total: $";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(130, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(391, 31);
            this.txtBuscar.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Código de Barra";
            // 
            // Pagar
            // 
            this.Pagar.Controls.Add(this.listBox1);
            this.Pagar.Location = new System.Drawing.Point(4, 22);
            this.Pagar.Name = "Pagar";
            this.Pagar.Padding = new System.Windows.Forms.Padding(3);
            this.Pagar.Size = new System.Drawing.Size(969, 425);
            this.Pagar.TabIndex = 1;
            this.Pagar.Text = "l";
            this.Pagar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "EFECTIVO",
            "CHEQUE",
            "TARJETA CRÉDITO",
            "TARJETA DÉBITO",
            "TRANSFERENCIA",
            "A CUENTA",
            "MULTIPAGO"});
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 179);
            this.listBox1.TabIndex = 1;
            // 
            // POS_VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 436);
            this.Controls.Add(this.TabControl1);
            this.Name = "POS_VENTAS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.POS_VENTAS_KeyPress);
            this.TabControl1.ResumeLayout(false);
            this.Ventas.ResumeLayout(false);
            this.Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Pagar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage Ventas;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton12;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton11;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton10;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton9;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton3;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton2;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton8;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton7;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton6;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton5;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton4;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
        internal System.Windows.Forms.Label LTotal;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage Pagar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

