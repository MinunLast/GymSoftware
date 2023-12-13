namespace GymForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnClientes = new Button();
            BtnProductos = new Button();
            BtnReportes = new Button();
            BtnIngresos = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 69);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "GYM OLYMPIA";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 460);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.577198F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.4228058F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(707, 460);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(BtnIngresos, 0, 3);
            tableLayoutPanel2.Controls.Add(BtnReportes, 0, 2);
            tableLayoutPanel2.Controls.Add(BtnProductos, 0, 1);
            tableLayoutPanel2.Controls.Add(BtnClientes, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(124, 460);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnClientes
            // 
            BtnClientes.BackColor = SystemColors.ActiveCaption;
            BtnClientes.Dock = DockStyle.Fill;
            BtnClientes.FlatAppearance.BorderSize = 0;
            BtnClientes.FlatStyle = FlatStyle.Flat;
            BtnClientes.Location = new Point(0, 0);
            BtnClientes.Margin = new Padding(0);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(124, 115);
            BtnClientes.TabIndex = 1;
            BtnClientes.Text = "CLIENTES";
            BtnClientes.UseVisualStyleBackColor = false;
            // 
            // BtnProductos
            // 
            BtnProductos.BackColor = SystemColors.ActiveCaption;
            BtnProductos.Dock = DockStyle.Fill;
            BtnProductos.FlatAppearance.BorderSize = 0;
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Location = new Point(0, 115);
            BtnProductos.Margin = new Padding(0);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(124, 115);
            BtnProductos.TabIndex = 2;
            BtnProductos.Text = "PRODUCTOS";
            BtnProductos.UseVisualStyleBackColor = false;
            // 
            // BtnReportes
            // 
            BtnReportes.BackColor = SystemColors.ActiveCaption;
            BtnReportes.Dock = DockStyle.Fill;
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Location = new Point(0, 230);
            BtnReportes.Margin = new Padding(0);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(124, 115);
            BtnReportes.TabIndex = 3;
            BtnReportes.Text = "REPORTES";
            BtnReportes.UseVisualStyleBackColor = false;
            // 
            // BtnIngresos
            // 
            BtnIngresos.BackColor = SystemColors.ActiveCaption;
            BtnIngresos.Dock = DockStyle.Fill;
            BtnIngresos.FlatAppearance.BorderSize = 0;
            BtnIngresos.FlatStyle = FlatStyle.Flat;
            BtnIngresos.Location = new Point(0, 345);
            BtnIngresos.Margin = new Padding(0);
            BtnIngresos.Name = "BtnIngresos";
            BtnIngresos.Size = new Size(124, 115);
            BtnIngresos.TabIndex = 4;
            BtnIngresos.Text = "INGRESOS";
            BtnIngresos.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnClientes;
        private Button BtnReportes;
        private Button BtnProductos;
        private Button BtnIngresos;
    }
}