namespace ProjectClientCourse.GUI
{
    partial class FrmAllSchedule
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
            this.dgvAllSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllSchedule
            // 
            this.dgvAllSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSchedule.Location = new System.Drawing.Point(168, 95);
            this.dgvAllSchedule.Name = "dgvAllSchedule";
            this.dgvAllSchedule.Size = new System.Drawing.Size(464, 261);
            this.dgvAllSchedule.TabIndex = 4;
            // 
            // FrmAllSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllSchedule);
            this.Name = "FrmAllSchedule";
            this.Text = "FrmAllSchedule";
            //this.Load += new System.EventHandler(this.FrmAllSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllSchedule;
    }
}