namespace Hector_Engel_Rodriguez_Torres_Aplicada1_P2
{
    partial class ConsultaCliente
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TelefonosdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(398, 34);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(192, 37);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechadateTimePicker.TabIndex = 1;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(12, 37);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(174, 20);
            this.NombrestextBox.TabIndex = 2;
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(12, 21);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(49, 13);
            this.Nombres.TabIndex = 3;
            this.Nombres.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // TelefonosdataGridView1
            // 
            this.TelefonosdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TelefonosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelefonosdataGridView1.Location = new System.Drawing.Point(15, 73);
            this.TelefonosdataGridView1.Name = "TelefonosdataGridView1";
            this.TelefonosdataGridView1.Size = new System.Drawing.Size(458, 76);
            this.TelefonosdataGridView1.TabIndex = 5;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 166);
            this.Controls.Add(this.TelefonosdataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Name = "ConsultaCliente";
            this.Text = "ConsultaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.TelefonosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TelefonosdataGridView1;
    }
}