namespace Presentacion_TallerAutomotiz
{
    partial class FrmMenu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtInfo = new System.Windows.Forms.ToolStripTextBox();
            this.btnEspacios = new System.Windows.Forms.ToolStripButton();
            this.btnInventarios = new System.Windows.Forms.ToolStripButton();
            this.btnTarjetas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtInfo,
            this.btnEspacios,
            this.btnInventarios,
            this.btnTarjetas,
            this.toolStripLabel1,
            this.btnSalir,
            this.btnConfig});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(302, 1080);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(293, 39);
            // 
            // btnEspacios
            // 
            this.btnEspacios.AutoSize = false;
            this.btnEspacios.BackColor = System.Drawing.Color.Transparent;
            this.btnEspacios.BackgroundImage = global::Inventarios_VMG.Properties.Resources._1;
            this.btnEspacios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspacios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEspacios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEspacios.Name = "btnEspacios";
            this.btnEspacios.Size = new System.Drawing.Size(250, 120);
            this.btnEspacios.Text = "Módulo de ESPACIOS";
            this.btnEspacios.Click += new System.EventHandler(this.btnEspacios_Click);
            // 
            // btnInventarios
            // 
            this.btnInventarios.AutoSize = false;
            this.btnInventarios.BackgroundImage = global::Inventarios_VMG.Properties.Resources._2;
            this.btnInventarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInventarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.Size = new System.Drawing.Size(250, 120);
            this.btnInventarios.Text = "Módulo de INVENTARIOS";
            this.btnInventarios.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.AutoSize = false;
            this.btnTarjetas.BackgroundImage = global::Inventarios_VMG.Properties.Resources._3;
            this.btnTarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTarjetas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTarjetas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(250, 120);
            this.btnTarjetas.Text = "Módulo de RFID";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(300, 250);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.BackgroundImage = global::Inventarios_VMG.Properties.Resources._6;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 120);
            this.btnSalir.Text = "CERRAR SESIÓN";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(302, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(2100, 1800);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1618, 1080);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(194, 1300);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1578, 50);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1598, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE INVENTARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Inventarios_VMG.Properties.Resources.fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-600, 29);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(3200, 3200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2500, 1400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = false;
            this.btnConfig.BackgroundImage = global::Inventarios_VMG.Properties.Resources._4;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(250, 120);
            this.btnConfig.Text = "CONFIGURACIÓN";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInventarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnTarjetas;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripTextBox txtInfo;
        private System.Windows.Forms.ToolStripButton btnEspacios;
        private System.Windows.Forms.ToolStripButton btnConfig;
    }
}