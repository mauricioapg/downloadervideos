namespace DownloaderVideos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ptBoxCarregando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // ptBoxCarregando
            // 
            this.ptBoxCarregando.Image = ((System.Drawing.Image)(resources.GetObject("ptBoxCarregando.Image")));
            this.ptBoxCarregando.Location = new System.Drawing.Point(55, 16);
            this.ptBoxCarregando.Name = "ptBoxCarregando";
            this.ptBoxCarregando.Size = new System.Drawing.Size(112, 64);
            this.ptBoxCarregando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBoxCarregando.TabIndex = 0;
            this.ptBoxCarregando.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 98);
            this.ControlBox = false;
            this.Controls.Add(this.ptBoxCarregando);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxCarregando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptBoxCarregando;
    }
}