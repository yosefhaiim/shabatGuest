namespace shabatGuest
{
    partial class FrmCategory
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
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.pAddFood = new System.Windows.Forms.Panel();
            this.txtNameDish = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.gdvAllChoises = new System.Windows.Forms.DataGridView();
            this.dgvGuestChoise = new System.Windows.Forms.DataGridView();
            this.pAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAllChoises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestChoise)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(234, 9);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(73, 16);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "שם קטגוריה";
            this.lblCategoryName.Click += new System.EventHandler(this.lblCategoryName_Click);
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(530, 9);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(55, 16);
            this.lblGuestName.TabIndex = 1;
            this.lblGuestName.Text = "שם אורח";
            // 
            // pAddFood
            // 
            this.pAddFood.Controls.Add(this.txtNameDish);
            this.pAddFood.Controls.Add(this.btnOk);
            this.pAddFood.Location = new System.Drawing.Point(259, 184);
            this.pAddFood.Name = "pAddFood";
            this.pAddFood.Size = new System.Drawing.Size(259, 100);
            this.pAddFood.TabIndex = 2;
            // 
            // txtNameDish
            // 
            this.txtNameDish.Location = new System.Drawing.Point(138, 37);
            this.txtNameDish.Name = "txtNameDish";
            this.txtNameDish.Size = new System.Drawing.Size(100, 22);
            this.txtNameDish.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(18, 37);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "הוסף אוכל";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(609, 460);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = ">>>";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(152, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "<<<";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gdvAllChoises
            // 
            this.gdvAllChoises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAllChoises.Location = new System.Drawing.Point(209, 28);
            this.gdvAllChoises.Name = "gdvAllChoises";
            this.gdvAllChoises.RowHeadersWidth = 51;
            this.gdvAllChoises.RowTemplate.Height = 24;
            this.gdvAllChoises.Size = new System.Drawing.Size(395, 150);
            this.gdvAllChoises.TabIndex = 2;
            this.gdvAllChoises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvAllChoises_CellContentClick);
            // 
            // dgvGuestChoise
            // 
            this.dgvGuestChoise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestChoise.Location = new System.Drawing.Point(209, 307);
            this.dgvGuestChoise.Name = "dgvGuestChoise";
            this.dgvGuestChoise.RowHeadersWidth = 51;
            this.dgvGuestChoise.RowTemplate.Height = 24;
            this.dgvGuestChoise.Size = new System.Drawing.Size(395, 150);
            this.dgvGuestChoise.TabIndex = 4;
            this.dgvGuestChoise.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuestChoise_CellContentClick);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.dgvGuestChoise);
            this.Controls.Add(this.gdvAllChoises);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pAddFood);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblCategoryName);
            this.Name = "FrmCategory";
            this.Text = "frmCategory";
            this.pAddFood.ResumeLayout(false);
            this.pAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAllChoises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestChoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Panel pAddFood;
        private System.Windows.Forms.DataGridView gdvAllChoises;
        private System.Windows.Forms.TextBox txtNameDish;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvGuestChoise;
    }
}

