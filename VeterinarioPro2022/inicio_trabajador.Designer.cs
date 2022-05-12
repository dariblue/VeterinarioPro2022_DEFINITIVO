
namespace VeterinarioPro2022
{
    partial class inicio_trabajador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio_trabajador));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Inicio = new System.Windows.Forms.TabPage();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tab_buscador = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getChip = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_Inicio.SuspendLayout();
            this.tab_buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Inicio);
            this.tabControl1.Controls.Add(this.tab_buscador);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 620);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_Inicio
            // 
            this.tab_Inicio.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.razas_gatos_portada_848x477x80xX;
            this.tab_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tab_Inicio.Controls.Add(this.botonAcceder);
            this.tab_Inicio.Controls.Add(this.button8);
            this.tab_Inicio.Controls.Add(this.button9);
            this.tab_Inicio.Controls.Add(this.button3);
            this.tab_Inicio.ImageIndex = 5;
            this.tab_Inicio.Location = new System.Drawing.Point(4, 23);
            this.tab_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Inicio.Name = "tab_Inicio";
            this.tab_Inicio.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Inicio.Size = new System.Drawing.Size(949, 593);
            this.tab_Inicio.TabIndex = 0;
            this.tab_Inicio.Text = "Inicio";
            this.tab_Inicio.UseVisualStyleBackColor = true;
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackColor = System.Drawing.Color.Transparent;
            this.botonAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonAcceder.FlatAppearance.BorderSize = 3;
            this.botonAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.botonAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonAcceder.Location = new System.Drawing.Point(837, 42);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(100, 34);
            this.botonAcceder.TabIndex = 28;
            this.botonAcceder.Text = "Log-Out";
            this.botonAcceder.UseVisualStyleBackColor = false;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(42, 241);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 74);
            this.button8.TabIndex = 6;
            this.button8.Text = "Tienda de productos para animales";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(42, 132);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 74);
            this.button9.TabIndex = 5;
            this.button9.Text = "Pida cita si todavía no la pidió";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 34);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Registre su animal si todavia no lo ha registrado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tab_buscador
            // 
            this.tab_buscador.BackgroundImage = global::VeterinarioPro2022.Properties.Resources.beneficios_de_tener_un_gato;
            this.tab_buscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_buscador.Controls.Add(this.button6);
            this.tab_buscador.Controls.Add(this.dataGridView1);
            this.tab_buscador.Controls.Add(this.getChip);
            this.tab_buscador.ImageIndex = 6;
            this.tab_buscador.Location = new System.Drawing.Point(4, 23);
            this.tab_buscador.Margin = new System.Windows.Forms.Padding(2);
            this.tab_buscador.Name = "tab_buscador";
            this.tab_buscador.Padding = new System.Windows.Forms.Padding(2);
            this.tab_buscador.Size = new System.Drawing.Size(949, 593);
            this.tab_buscador.TabIndex = 1;
            this.tab_buscador.Text = "Busacor Animales";
            this.tab_buscador.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(6, 256);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 22);
            this.button6.TabIndex = 4;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(501, 190);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // getChip
            // 
            this.getChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getChip.Location = new System.Drawing.Point(6, 23);
            this.getChip.Margin = new System.Windows.Forms.Padding(2);
            this.getChip.Name = "getChip";
            this.getChip.Size = new System.Drawing.Size(501, 35);
            this.getChip.TabIndex = 1;
            this.getChip.TextChanged += new System.EventHandler(this.getChip_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye_60px.png");
            this.imageList1.Images.SetKeyName(1, "invisible_60px.png");
            this.imageList1.Images.SetKeyName(2, "Password.png");
            this.imageList1.Images.SetKeyName(3, "test_account_100px.png");
            this.imageList1.Images.SetKeyName(4, "Usuario.png");
            this.imageList1.Images.SetKeyName(5, "home_32px.png");
            this.imageList1.Images.SetKeyName(6, "search_32px.png");
            // 
            // inicio_trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 614);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inicio_trabajador";
            this.Text = "inicio_trabajador";
            this.tabControl1.ResumeLayout(false);
            this.tab_Inicio.ResumeLayout(false);
            this.tab_buscador.ResumeLayout(false);
            this.tab_buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_Inicio;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_buscador;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox getChip;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.ImageList imageList1;
    }
}