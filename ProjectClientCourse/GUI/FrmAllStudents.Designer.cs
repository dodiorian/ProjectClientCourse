namespace ProjectClientCourse.GUI
{
    partial class FrmAllStudents
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
            this.dgvAllStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllStudents
            // 
            this.dgvAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStudents.Location = new System.Drawing.Point(182, 76);
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.Size = new System.Drawing.Size(464, 261);
            this.dgvAllStudents.TabIndex = 1;
            // 
            // FrmAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllStudents);
            this.Name = "FrmAllStudents";
            this.Text = "FrmAllStudents";
            this.Load += new System.EventHandler(this.FrmAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllStudents;
    }
}