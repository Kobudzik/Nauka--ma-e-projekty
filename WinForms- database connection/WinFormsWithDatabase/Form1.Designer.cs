namespace WinFormsWithDatabase
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
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.Location = new System.Drawing.Point(21, 140);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(245, 147);
            this.lstCars.TabIndex = 0;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAdd.Location = new System.Drawing.Point(278, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(18, 113);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Database Cars";
            // 
            // txbInput
            // 
            this.txbInput.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txbInput.Location = new System.Drawing.Point(253, 92);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(100, 20);
            this.txbInput.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDelete.Location = new System.Drawing.Point(278, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnUpdate.Location = new System.Drawing.Point(278, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

