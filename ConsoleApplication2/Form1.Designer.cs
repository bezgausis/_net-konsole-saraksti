namespace ConsoleApplication2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosaukumsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventaranrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzskaitesvalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iegadesvalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datorklaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datorklaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datorklaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodsDataGridViewTextBoxColumn1,
            this.nosaukumsDataGridViewTextBoxColumn1,
            this.inventaranrDataGridViewTextBoxColumn1,
            this.uzskaitesvalDataGridViewTextBoxColumn1,
            this.iegadesvalDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.datorklaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 433);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kodsDataGridViewTextBoxColumn1
            // 
            this.kodsDataGridViewTextBoxColumn1.DataPropertyName = "kods";
            this.kodsDataGridViewTextBoxColumn1.HeaderText = "kods";
            this.kodsDataGridViewTextBoxColumn1.Name = "kodsDataGridViewTextBoxColumn1";
            // 
            // nosaukumsDataGridViewTextBoxColumn1
            // 
            this.nosaukumsDataGridViewTextBoxColumn1.DataPropertyName = "nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn1.HeaderText = "nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn1.Name = "nosaukumsDataGridViewTextBoxColumn1";
            // 
            // inventaranrDataGridViewTextBoxColumn1
            // 
            this.inventaranrDataGridViewTextBoxColumn1.DataPropertyName = "inventara_nr";
            this.inventaranrDataGridViewTextBoxColumn1.HeaderText = "inventara_nr";
            this.inventaranrDataGridViewTextBoxColumn1.Name = "inventaranrDataGridViewTextBoxColumn1";
            // 
            // uzskaitesvalDataGridViewTextBoxColumn1
            // 
            this.uzskaitesvalDataGridViewTextBoxColumn1.DataPropertyName = "uzskaites_val";
            this.uzskaitesvalDataGridViewTextBoxColumn1.HeaderText = "uzskaites_val";
            this.uzskaitesvalDataGridViewTextBoxColumn1.Name = "uzskaitesvalDataGridViewTextBoxColumn1";
            // 
            // iegadesvalDataGridViewTextBoxColumn1
            // 
            this.iegadesvalDataGridViewTextBoxColumn1.DataPropertyName = "iegades_val";
            this.iegadesvalDataGridViewTextBoxColumn1.HeaderText = "iegades_val";
            this.iegadesvalDataGridViewTextBoxColumn1.Name = "iegadesvalDataGridViewTextBoxColumn1";
            // 
            // datorklaseBindingSource
            // 
            this.datorklaseBindingSource.DataSource = typeof(_2prd_injinierija.Datorklase);
            // 
            // datorklaseBindingSource2
            // 
            this.datorklaseBindingSource2.DataSource = typeof(_2prd_injinierija.Datorklase);
            // 
            // datorklaseBindingSource1
            // 
            this.datorklaseBindingSource1.DataSource = typeof(_2prd_injinierija.Datorklase);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 464);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datorklaseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource datorklaseBindingSource;
        private System.Windows.Forms.BindingSource datorklaseBindingSource1;
        private System.Windows.Forms.BindingSource datorklaseBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventaranrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzskaitesvalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iegadesvalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
    }
}