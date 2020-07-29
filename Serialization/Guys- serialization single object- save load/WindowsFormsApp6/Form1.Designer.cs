namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.give10Joe = new System.Windows.Forms.Button();
            this.receive5Bob = new System.Windows.Forms.Button();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.BobLabel = new System.Windows.Forms.Label();
            this.BankLabel = new System.Windows.Forms.Label();
            this.joeBob10 = new System.Windows.Forms.Button();
            this.bobJoe5 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // give10Joe
            // 
            this.give10Joe.Location = new System.Drawing.Point(12, 173);
            this.give10Joe.Name = "give10Joe";
            this.give10Joe.Size = new System.Drawing.Size(123, 63);
            this.give10Joe.TabIndex = 0;
            this.give10Joe.Text = "Give 10 to Joe";
            this.give10Joe.UseVisualStyleBackColor = true;
            this.give10Joe.Click += new System.EventHandler(this.give10Joe_Click);
            // 
            // receive5Bob
            // 
            this.receive5Bob.Location = new System.Drawing.Point(144, 173);
            this.receive5Bob.Name = "receive5Bob";
            this.receive5Bob.Size = new System.Drawing.Size(127, 63);
            this.receive5Bob.TabIndex = 1;
            this.receive5Bob.Text = "Receive 5 from Bob";
            this.receive5Bob.UseVisualStyleBackColor = true;
            this.receive5Bob.Click += new System.EventHandler(this.receive5Bob_Click);
            // 
            // JoeLabel
            // 
            this.JoeLabel.AutoSize = true;
            this.JoeLabel.Location = new System.Drawing.Point(39, 29);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(44, 13);
            this.JoeLabel.TabIndex = 2;
            this.JoeLabel.Text = "Joe has";
            // 
            // BobLabel
            // 
            this.BobLabel.AutoSize = true;
            this.BobLabel.Location = new System.Drawing.Point(39, 63);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(49, 13);
            this.BobLabel.TabIndex = 3;
            this.BobLabel.Text = "Bob has ";
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Location = new System.Drawing.Point(39, 97);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(52, 13);
            this.BankLabel.TabIndex = 4;
            this.BankLabel.Text = "Bank has";
            // 
            // joeBob10
            // 
            this.joeBob10.Location = new System.Drawing.Point(16, 268);
            this.joeBob10.Name = "joeBob10";
            this.joeBob10.Size = new System.Drawing.Size(119, 47);
            this.joeBob10.TabIndex = 5;
            this.joeBob10.Text = "Joes gives 10 to Bob";
            this.joeBob10.UseVisualStyleBackColor = true;
            this.joeBob10.Click += new System.EventHandler(this.joeBob10_Click);
            // 
            // bobJoe5
            // 
            this.bobJoe5.Location = new System.Drawing.Point(144, 268);
            this.bobJoe5.Name = "bobJoe5";
            this.bobJoe5.Size = new System.Drawing.Size(127, 47);
            this.bobJoe5.TabIndex = 6;
            this.bobJoe5.Text = "Bob gives 5 to Joe";
            this.bobJoe5.UseVisualStyleBackColor = true;
            this.bobJoe5.Click += new System.EventHandler(this.bobJoe5_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 364);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Joe";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(144, 364);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "Load Joe";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 399);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bobJoe5);
            this.Controls.Add(this.joeBob10);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.BobLabel);
            this.Controls.Add(this.JoeLabel);
            this.Controls.Add(this.receive5Bob);
            this.Controls.Add(this.give10Joe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button give10Joe;
        private System.Windows.Forms.Button receive5Bob;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Button joeBob10;
        private System.Windows.Forms.Button bobJoe5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

