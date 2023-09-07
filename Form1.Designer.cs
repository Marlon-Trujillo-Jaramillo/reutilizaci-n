namespace reutilización
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnRepro = new System.Windows.Forms.Button();
            this.lbArchivo = new System.Windows.Forms.Label();
            this.WinMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(574, 122);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(123, 40);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(574, 214);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(123, 40);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(574, 260);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(123, 40);
            this.btnPausar.TabIndex = 3;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnRepro
            // 
            this.btnRepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepro.Location = new System.Drawing.Point(574, 168);
            this.btnRepro.Name = "btnRepro";
            this.btnRepro.Size = new System.Drawing.Size(152, 40);
            this.btnRepro.TabIndex = 4;
            this.btnRepro.Text = "Reproducir";
            this.btnRepro.UseVisualStyleBackColor = true;
            this.btnRepro.Click += new System.EventHandler(this.btnRepro_Click);
            // 
            // lbArchivo
            // 
            this.lbArchivo.AutoSize = true;
            this.lbArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArchivo.Location = new System.Drawing.Point(582, 73);
            this.lbArchivo.Name = "lbArchivo";
            this.lbArchivo.Size = new System.Drawing.Size(79, 29);
            this.lbArchivo.TabIndex = 6;
            this.lbArchivo.Text = "label1";
            // 
            // WinMediaPlayer
            // 
            this.WinMediaPlayer.Enabled = true;
            this.WinMediaPlayer.Location = new System.Drawing.Point(0, -1);
            this.WinMediaPlayer.Name = "WinMediaPlayer";
            this.WinMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WinMediaPlayer.OcxState")));
            this.WinMediaPlayer.Size = new System.Drawing.Size(376, 255);
            this.WinMediaPlayer.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 452);
            this.Controls.Add(this.WinMediaPlayer);
            this.Controls.Add(this.lbArchivo);
            this.Controls.Add(this.btnRepro);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnCargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WinMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnRepro;
        private System.Windows.Forms.Label lbArchivo;
        private AxWMPLib.AxWindowsMediaPlayer WinMediaPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

