
namespace CYK_Algorithm
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
            this.table = new System.Windows.Forms.DataGridView();
            this.checkGrammarButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addRowButton = new System.Windows.Forms.Button();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.removeColumnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.ColumnHeadersVisible = false;
            this.table.Location = new System.Drawing.Point(12, 48);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(632, 352);
            this.table.TabIndex = 0;
            // 
            // checkGrammarButton
            // 
            this.checkGrammarButton.Location = new System.Drawing.Point(683, 203);
            this.checkGrammarButton.Name = "checkGrammarButton";
            this.checkGrammarButton.Size = new System.Drawing.Size(75, 23);
            this.checkGrammarButton.TabIndex = 1;
            this.checkGrammarButton.Text = "Check";
            this.checkGrammarButton.UseVisualStyleBackColor = true;
            this.checkGrammarButton.Click += new System.EventHandler(this.checkGrammarButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(673, 160);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "Input Text";
            // 
            // addColumnButton
            // 
            this.addColumnButton.Location = new System.Drawing.Point(442, 415);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(81, 23);
            this.addColumnButton.TabIndex = 4;
            this.addColumnButton.Text = "Add Column";
            this.addColumnButton.UseVisualStyleBackColor = true;
            this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "CYK Algorithm";
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(12, 415);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(81, 23);
            this.addRowButton.TabIndex = 6;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // removeRowButton
            // 
            this.removeRowButton.Location = new System.Drawing.Point(99, 415);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(81, 23);
            this.removeRowButton.TabIndex = 7;
            this.removeRowButton.Text = "Remove Row";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.removeRowButton_Click);
            // 
            // removeColumnButton
            // 
            this.removeColumnButton.Location = new System.Drawing.Point(529, 415);
            this.removeColumnButton.Name = "removeColumnButton";
            this.removeColumnButton.Size = new System.Drawing.Size(115, 23);
            this.removeColumnButton.TabIndex = 8;
            this.removeColumnButton.Text = "Remove Column";
            this.removeColumnButton.UseVisualStyleBackColor = true;
            this.removeColumnButton.Click += new System.EventHandler(this.removeColumnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeColumnButton);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addColumnButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.checkGrammarButton);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button checkGrammarButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button addColumnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button removeRowButton;
        private System.Windows.Forms.Button removeColumnButton;
    }
}

