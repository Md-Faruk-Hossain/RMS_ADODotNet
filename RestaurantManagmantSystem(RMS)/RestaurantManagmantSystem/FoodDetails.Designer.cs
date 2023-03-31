
namespace RestaurantManagmantSystem
{
    partial class FoodDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmdCatName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImgload = new System.Windows.Forms.Button();
            this.pictureBox1Emp = new System.Windows.Forms.PictureBox();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFoodView = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Id :";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(138, 136);
            this.txtItemId.Margin = new System.Windows.Forms.Padding(5);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(164, 27);
            this.txtItemId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name :";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(138, 173);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(164, 27);
            this.txtItemName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = " Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(670, 179);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 27);
            this.txtPrice.TabIndex = 1;
            // 
            // cmdCatName
            // 
            this.cmdCatName.FormattingEnabled = true;
            this.cmdCatName.Location = new System.Drawing.Point(670, 139);
            this.cmdCatName.Name = "cmdCatName";
            this.cmdCatName.Size = new System.Drawing.Size(164, 28);
            this.cmdCatName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(704, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImgload
            // 
            this.btnImgload.Location = new System.Drawing.Point(415, 292);
            this.btnImgload.Margin = new System.Windows.Forms.Padding(2);
            this.btnImgload.Name = "btnImgload";
            this.btnImgload.Size = new System.Drawing.Size(49, 27);
            this.btnImgload.TabIndex = 60;
            this.btnImgload.Text = "....";
            this.btnImgload.UseVisualStyleBackColor = true;
            this.btnImgload.UseWaitCursor = true;
            this.btnImgload.Click += new System.EventHandler(this.btnImgload_Click);
            // 
            // pictureBox1Emp
            // 
            this.pictureBox1Emp.Location = new System.Drawing.Point(379, 136);
            this.pictureBox1Emp.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1Emp.Name = "pictureBox1Emp";
            this.pictureBox1Emp.Size = new System.Drawing.Size(117, 138);
            this.pictureBox1Emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Emp.TabIndex = 59;
            this.pictureBox1Emp.TabStop = false;
            // 
            // txtImgPath
            // 
            this.txtImgPath.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtImgPath.Location = new System.Drawing.Point(670, 227);
            this.txtImgPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(164, 27);
            this.txtImgPath.TabIndex = 58;
            this.txtImgPath.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 227);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Image :";
            this.label10.UseWaitCursor = true;
            // 
            // btnFoodView
            // 
            this.btnFoodView.Location = new System.Drawing.Point(777, 41);
            this.btnFoodView.Name = "btnFoodView";
            this.btnFoodView.Size = new System.Drawing.Size(57, 33);
            this.btnFoodView.TabIndex = 61;
            this.btnFoodView.Text = "View";
            this.btnFoodView.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FoodDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 350);
            this.Controls.Add(this.btnFoodView);
            this.Controls.Add(this.btnImgload);
            this.Controls.Add(this.pictureBox1Emp);
            this.Controls.Add(this.txtImgPath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmdCatName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FoodDetails";
            this.Text = "FoodDetails";
            this.Load += new System.EventHandler(this.FoodDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmdCatName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImgload;
        private System.Windows.Forms.PictureBox pictureBox1Emp;
        private System.Windows.Forms.TextBox txtImgPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFoodView;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}