namespace Odev
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
            this.lstIsimListesi = new System.Windows.Forms.ListBox();
            this.btnListeYaz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIsimListesi
            // 
            this.lstIsimListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstIsimListesi.FormattingEnabled = true;
            this.lstIsimListesi.ItemHeight = 20;
            this.lstIsimListesi.Location = new System.Drawing.Point(12, 12);
            this.lstIsimListesi.Name = "lstIsimListesi";
            this.lstIsimListesi.Size = new System.Drawing.Size(180, 184);
            this.lstIsimListesi.TabIndex = 0;
            // 
            // btnListeYaz
            // 
            this.btnListeYaz.Location = new System.Drawing.Point(12, 217);
            this.btnListeYaz.Name = "btnListeYaz";
            this.btnListeYaz.Size = new System.Drawing.Size(180, 23);
            this.btnListeYaz.TabIndex = 1;
            this.btnListeYaz.Text = "Liste Yaz";
            this.btnListeYaz.UseVisualStyleBackColor = true;
            this.btnListeYaz.Click += new System.EventHandler(this.btnListeYazTiklandiginda);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListeYaz);
            this.Controls.Add(this.lstIsimListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstIsimListesi;
        private System.Windows.Forms.Button btnListeYaz;
        private System.Windows.Forms.Button button1;
    }
}

