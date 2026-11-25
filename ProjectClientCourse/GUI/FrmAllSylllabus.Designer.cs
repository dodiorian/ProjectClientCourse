namespace ProjectClientCourse.GUI
{
    partial class FrmAllSylllabus
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
            this.dgvAllSylllabus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSylllabus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllSylllabus
            // 
            this.dgvAllSylllabus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSylllabus.Location = new System.Drawing.Point(148, 96);
            this.dgvAllSylllabus.Name = "dgvAllSylllabus";
            this.dgvAllSylllabus.Size = new System.Drawing.Size(464, 261);
            this.dgvAllSylllabus.TabIndex = 5;
            // 
            // FrmAllSylllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllSylllabus);
            this.Name = "FrmAllSylllabus";
            this.Text = "FrmAllSylllabus";
            this.Load += new System.EventHandler(this.FrmAllSylllabus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSylllabus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllSylllabus;
    }
}