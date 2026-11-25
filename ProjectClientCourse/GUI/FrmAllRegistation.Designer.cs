namespace ProjectClientCourse.GUI
{
    partial class FrmAllRegistation
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
            this.dgvAllRegistation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRegistation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllRegistation
            // 
            this.dgvAllRegistation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRegistation.Location = new System.Drawing.Point(154, 76);
            this.dgvAllRegistation.Name = "dgvAllRegistation";
            this.dgvAllRegistation.Size = new System.Drawing.Size(464, 261);
            this.dgvAllRegistation.TabIndex = 7;
            // 
            // FrmAllRegistation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllRegistation);
            this.Name = "FrmAllRegistation";
            this.Text = "FrmAllRegistation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRegistation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRegistation;
    }
}