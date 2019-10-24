namespace Quadratic_equation
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSolution1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSolution2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(142, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.Location = new System.Drawing.Point(251, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 32);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox3.Location = new System.Drawing.Point(353, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 32);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "-4";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "x² + ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(299, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 100;
            this.label2.Text = "x + ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(401, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 26);
            this.label3.TabIndex = 101;
            this.label3.Text = "= 0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSolution1
            // 
            this.textBoxSolution1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxSolution1.Location = new System.Drawing.Point(195, 202);
            this.textBoxSolution1.Name = "textBoxSolution1";
            this.textBoxSolution1.ReadOnly = true;
            this.textBoxSolution1.Size = new System.Drawing.Size(249, 32);
            this.textBoxSolution1.TabIndex = 102;
            this.textBoxSolution1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 104;
            this.label4.Text = "x₁ =";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 106;
            this.label5.Text = "x₂ =";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSolution2
            // 
            this.textBoxSolution2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxSolution2.Location = new System.Drawing.Point(195, 240);
            this.textBoxSolution2.Name = "textBoxSolution2";
            this.textBoxSolution2.ReadOnly = true;
            this.textBoxSolution2.Size = new System.Drawing.Size(249, 32);
            this.textBoxSolution2.TabIndex = 105;
            this.textBoxSolution2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSolution2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSolution1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Quadratic equation solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSolution1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSolution2;
    }
}

