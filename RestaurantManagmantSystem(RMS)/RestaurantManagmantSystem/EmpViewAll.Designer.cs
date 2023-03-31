
namespace RestaurantManagmantSystem
{
    partial class EmpViewAll
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
            this.btnEmpBack = new System.Windows.Forms.Button();
            this.btnEmpEidt = new System.Windows.Forms.Button();
            this.dgvEmpload = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpload)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpBack
            // 
            this.btnEmpBack.Location = new System.Drawing.Point(12, 493);
            this.btnEmpBack.Name = "btnEmpBack";
            this.btnEmpBack.Size = new System.Drawing.Size(69, 23);
            this.btnEmpBack.TabIndex = 3;
            this.btnEmpBack.Text = "Back";
            this.btnEmpBack.UseVisualStyleBackColor = true;
            this.btnEmpBack.Click += new System.EventHandler(this.btnEmpBack_Click);
            // 
            // btnEmpEidt
            // 
            this.btnEmpEidt.Location = new System.Drawing.Point(812, 60);
            this.btnEmpEidt.Name = "btnEmpEidt";
            this.btnEmpEidt.Size = new System.Drawing.Size(69, 23);
            this.btnEmpEidt.TabIndex = 5;
            this.btnEmpEidt.Text = "Edit";
            this.btnEmpEidt.UseVisualStyleBackColor = true;
            this.btnEmpEidt.Click += new System.EventHandler(this.btnEmpEidt_Click);
            // 
            // dgvEmpload
            // 
            this.dgvEmpload.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpload.Location = new System.Drawing.Point(12, 100);
            this.dgvEmpload.Name = "dgvEmpload";
            this.dgvEmpload.Size = new System.Drawing.Size(896, 387);
            this.dgvEmpload.TabIndex = 2;
            // 
            // EmpViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 521);
            this.Controls.Add(this.btnEmpBack);
            this.Controls.Add(this.btnEmpEidt);
            this.Controls.Add(this.dgvEmpload);
            this.Name = "EmpViewAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpViewAll";
            this.Load += new System.EventHandler(this.EmpViewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpBack;
        private System.Windows.Forms.Button btnEmpEidt;
        private System.Windows.Forms.DataGridView dgvEmpload;
    }
}