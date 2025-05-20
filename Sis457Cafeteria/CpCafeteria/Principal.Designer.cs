namespace CpCafeteria
{
    partial class Principal
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paBarraTitulo = new System.Windows.Forms.Panel();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnDeslizar = new System.Windows.Forms.PictureBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(250, 650);
            this.pnMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CpCafeteria.Properties.Resources.ChatGPT_Image_20_may_2025__10_35_46_a_m__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paBarraTitulo
            // 
            this.paBarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paBarraTitulo.Controls.Add(this.iconMinimizar);
            this.paBarraTitulo.Controls.Add(this.iconRestaurar);
            this.paBarraTitulo.Controls.Add(this.iconMaximizar);
            this.paBarraTitulo.Controls.Add(this.iconCerrar);
            this.paBarraTitulo.Controls.Add(this.btnDeslizar);
            this.paBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paBarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.paBarraTitulo.Name = "paBarraTitulo";
            this.paBarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.paBarraTitulo.TabIndex = 1;
            this.paBarraTitulo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.paBarraTitulo_MouseDoubleClick);
            this.paBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paBarraTitulo_MouseDown);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::CpCafeteria.Properties.Resources.horizontal_rule_25dp_434343_FILL0_wght400_GRAD0_opsz24;
            this.iconMinimizar.Location = new System.Drawing.Point(966, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMinimizar.TabIndex = 4;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = global::CpCafeteria.Properties.Resources.select_window_2_25dp_434343_FILL0_wght400_GRAD0_opsz24;
            this.iconRestaurar.Location = new System.Drawing.Point(992, 12);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 3;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = global::CpCafeteria.Properties.Resources.check_box_outline_blank_25dp_434343_FILL0_wght400_GRAD0_opsz24;
            this.iconMaximizar.Location = new System.Drawing.Point(992, 12);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = global::CpCafeteria.Properties.Resources.close_25dp_434343_FILL0_wght400_GRAD0_opsz24;
            this.iconCerrar.Location = new System.Drawing.Point(1018, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // btnDeslizar
            // 
            this.btnDeslizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeslizar.Image = global::CpCafeteria.Properties.Resources.list_35;
            this.btnDeslizar.Location = new System.Drawing.Point(6, 6);
            this.btnDeslizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeslizar.Name = "btnDeslizar";
            this.btnDeslizar.Size = new System.Drawing.Size(35, 35);
            this.btnDeslizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeslizar.TabIndex = 0;
            this.btnDeslizar.TabStop = false;
            this.btnDeslizar.Click += new System.EventHandler(this.btnDeslizar_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(250, 50);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(1050, 600);
            this.pnContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.paBarraTitulo);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeslizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox btnDeslizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paBarraTitulo;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconMinimizar;
    }
}