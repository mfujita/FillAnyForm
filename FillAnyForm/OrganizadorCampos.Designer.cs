namespace FillAnyForm
{
    partial class OrganizadorCampos
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
            this.btnRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(443, 547);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(94, 29);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Gravar";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // OrganizadorCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 614);
            this.Controls.Add(this.btnRecord);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "OrganizadorCampos";
            this.Text = "OrganizadorCampos";
            this.Load += new System.EventHandler(this.OrganizadorCampos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRecord;
    }
}