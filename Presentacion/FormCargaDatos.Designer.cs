
namespace Presentacion
{
    partial class FormCargaDatos
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
            this.Vigencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboVigencia = new System.Windows.Forms.ComboBox();
            this.cmboPerido = new System.Windows.Forms.ComboBox();
            this.cmboSede = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vigencia
            // 
            this.Vigencia.AutoSize = true;
            this.Vigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vigencia.Location = new System.Drawing.Point(92, 53);
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.Size = new System.Drawing.Size(78, 20);
            this.Vigencia.TabIndex = 0;
            this.Vigencia.Text = "Vigencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sede";
            // 
            // cmboVigencia
            // 
            this.cmboVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboVigencia.FormattingEnabled = true;
            this.cmboVigencia.Location = new System.Drawing.Point(182, 53);
            this.cmboVigencia.Name = "cmboVigencia";
            this.cmboVigencia.Size = new System.Drawing.Size(169, 28);
            this.cmboVigencia.TabIndex = 3;
            // 
            // cmboPerido
            // 
            this.cmboPerido.FormattingEnabled = true;
            this.cmboPerido.Location = new System.Drawing.Point(182, 86);
            this.cmboPerido.Name = "cmboPerido";
            this.cmboPerido.Size = new System.Drawing.Size(169, 21);
            this.cmboPerido.TabIndex = 4;
            // 
            // cmboSede
            // 
            this.cmboSede.FormattingEnabled = true;
            this.cmboSede.Location = new System.Drawing.Point(182, 126);
            this.cmboSede.Name = "cmboSede";
            this.cmboSede.Size = new System.Drawing.Size(169, 21);
            this.cmboSede.TabIndex = 5;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(210, 195);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(102, 51);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(182, 153);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(303, 20);
            this.txtRuta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruta";
            // 
            // FormCargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(581, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cmboSede);
            this.Controls.Add(this.cmboPerido);
            this.Controls.Add(this.cmboVigencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vigencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCargaDatos";
            this.Text = "FormCargaDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Vigencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboVigencia;
        private System.Windows.Forms.ComboBox cmboPerido;
        private System.Windows.Forms.ComboBox cmboSede;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
    }
}