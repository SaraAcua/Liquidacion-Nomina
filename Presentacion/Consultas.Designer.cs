
namespace Presentacion
{
    partial class Consultas
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
            this.dtgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbo3 = new System.Windows.Forms.ComboBox();
            this.cmbo2 = new System.Windows.Forms.ComboBox();
            this.cmbo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vigencia = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvConsulta
            // 
            this.dtgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConsulta.Location = new System.Drawing.Point(32, 157);
            this.dtgvConsulta.Name = "dtgvConsulta";
            this.dtgvConsulta.Size = new System.Drawing.Size(508, 174);
            this.dtgvConsulta.TabIndex = 0;
            // 
            // cmbo3
            // 
            this.cmbo3.FormattingEnabled = true;
            this.cmbo3.Location = new System.Drawing.Point(118, 99);
            this.cmbo3.Name = "cmbo3";
            this.cmbo3.Size = new System.Drawing.Size(169, 21);
            this.cmbo3.TabIndex = 11;
            // 
            // cmbo2
            // 
            this.cmbo2.FormattingEnabled = true;
            this.cmbo2.Location = new System.Drawing.Point(118, 59);
            this.cmbo2.Name = "cmbo2";
            this.cmbo2.Size = new System.Drawing.Size(169, 21);
            this.cmbo2.TabIndex = 10;
            // 
            // cmbo1
            // 
            this.cmbo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo1.FormattingEnabled = true;
            this.cmbo1.Location = new System.Drawing.Point(118, 26);
            this.cmbo1.Name = "cmbo1";
            this.cmbo1.Size = new System.Drawing.Size(169, 28);
            this.cmbo1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sede";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Periodo";
            // 
            // Vigencia
            // 
            this.Vigencia.AutoSize = true;
            this.Vigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vigencia.Location = new System.Drawing.Point(28, 26);
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.Size = new System.Drawing.Size(78, 20);
            this.Vigencia.TabIndex = 6;
            this.Vigencia.Text = "Vigencia";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(368, 68);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(122, 52);
            this.btnConsulta.TabIndex = 12;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(581, 392);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.cmbo3);
            this.Controls.Add(this.cmbo2);
            this.Controls.Add(this.cmbo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vigencia);
            this.Controls.Add(this.dtgvConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvConsulta;
        private System.Windows.Forms.ComboBox cmbo3;
        private System.Windows.Forms.ComboBox cmbo2;
        private System.Windows.Forms.ComboBox cmbo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Vigencia;
        private System.Windows.Forms.Button btnConsulta;
    }
}