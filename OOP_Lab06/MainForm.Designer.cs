namespace OOP_Lab06 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.Input1 = new System.Windows.Forms.TextBox();
            this.MoreCheck = new System.Windows.Forms.Label();
            this.LessCheck = new System.Windows.Forms.Label();
            this.EquallyCheck = new System.Windows.Forms.Label();
            this.NotEqualCheck = new System.Windows.Forms.Label();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.LeftButton1 = new System.Windows.Forms.Button();
            this.LeftButton2 = new System.Windows.Forms.Button();
            this.RightButton1 = new System.Windows.Forms.Button();
            this.RightButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input1.Location = new System.Drawing.Point(12, 12);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(473, 64);
            this.Input1.TabIndex = 0;
            // 
            // MoreCheck
            // 
            this.MoreCheck.AutoSize = true;
            this.MoreCheck.BackColor = System.Drawing.Color.Red;
            this.MoreCheck.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreCheck.Location = new System.Drawing.Point(117, 79);
            this.MoreCheck.Name = "MoreCheck";
            this.MoreCheck.Size = new System.Drawing.Size(50, 56);
            this.MoreCheck.TabIndex = 1;
            this.MoreCheck.Text = ">";
            this.MoreCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LessCheck
            // 
            this.LessCheck.AutoSize = true;
            this.LessCheck.BackColor = System.Drawing.Color.Red;
            this.LessCheck.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessCheck.Location = new System.Drawing.Point(173, 79);
            this.LessCheck.Name = "LessCheck";
            this.LessCheck.Size = new System.Drawing.Size(50, 56);
            this.LessCheck.TabIndex = 2;
            this.LessCheck.Text = "<";
            this.LessCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquallyCheck
            // 
            this.EquallyCheck.AutoSize = true;
            this.EquallyCheck.BackColor = System.Drawing.Color.Red;
            this.EquallyCheck.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EquallyCheck.Location = new System.Drawing.Point(229, 79);
            this.EquallyCheck.Name = "EquallyCheck";
            this.EquallyCheck.Size = new System.Drawing.Size(76, 56);
            this.EquallyCheck.TabIndex = 3;
            this.EquallyCheck.Text = "==";
            this.EquallyCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotEqualCheck
            // 
            this.NotEqualCheck.AutoSize = true;
            this.NotEqualCheck.BackColor = System.Drawing.Color.Red;
            this.NotEqualCheck.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotEqualCheck.Location = new System.Drawing.Point(311, 79);
            this.NotEqualCheck.Name = "NotEqualCheck";
            this.NotEqualCheck.Size = new System.Drawing.Size(76, 56);
            this.NotEqualCheck.TabIndex = 4;
            this.NotEqualCheck.Text = "!=";
            this.NotEqualCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input2
            // 
            this.Input2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input2.Location = new System.Drawing.Point(12, 138);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(473, 64);
            this.Input2.TabIndex = 5;
            // 
            // LeftButton1
            // 
            this.LeftButton1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftButton1.Location = new System.Drawing.Point(491, 12);
            this.LeftButton1.Name = "LeftButton1";
            this.LeftButton1.Size = new System.Drawing.Size(96, 64);
            this.LeftButton1.TabIndex = 6;
            this.LeftButton1.Text = "<<";
            this.LeftButton1.UseVisualStyleBackColor = true;
            this.LeftButton1.Click += new System.EventHandler(this.LeftButton1_Click);
            // 
            // LeftButton2
            // 
            this.LeftButton2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftButton2.Location = new System.Drawing.Point(491, 138);
            this.LeftButton2.Name = "LeftButton2";
            this.LeftButton2.Size = new System.Drawing.Size(96, 64);
            this.LeftButton2.TabIndex = 7;
            this.LeftButton2.Text = "<<";
            this.LeftButton2.UseVisualStyleBackColor = true;
            this.LeftButton2.Click += new System.EventHandler(this.LeftButton2_Click);
            // 
            // RightButton1
            // 
            this.RightButton1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightButton1.Location = new System.Drawing.Point(593, 12);
            this.RightButton1.Name = "RightButton1";
            this.RightButton1.Size = new System.Drawing.Size(96, 64);
            this.RightButton1.TabIndex = 8;
            this.RightButton1.Text = ">>";
            this.RightButton1.UseVisualStyleBackColor = true;
            this.RightButton1.Click += new System.EventHandler(this.RightButton1_Click);
            // 
            // RightButton2
            // 
            this.RightButton2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightButton2.Location = new System.Drawing.Point(593, 138);
            this.RightButton2.Name = "RightButton2";
            this.RightButton2.Size = new System.Drawing.Size(96, 64);
            this.RightButton2.TabIndex = 9;
            this.RightButton2.Text = ">>";
            this.RightButton2.UseVisualStyleBackColor = true;
            this.RightButton2.Click += new System.EventHandler(this.RightButton2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 214);
            this.Controls.Add(this.RightButton2);
            this.Controls.Add(this.RightButton1);
            this.Controls.Add(this.LeftButton2);
            this.Controls.Add(this.LeftButton1);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.NotEqualCheck);
            this.Controls.Add(this.EquallyCheck);
            this.Controls.Add(this.LessCheck);
            this.Controls.Add(this.MoreCheck);
            this.Controls.Add(this.Input1);
            this.Name = "MainForm";
            this.Text = "String Comparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.Label MoreCheck;
        private System.Windows.Forms.Label LessCheck;
        private System.Windows.Forms.Label EquallyCheck;
        private System.Windows.Forms.Label NotEqualCheck;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Button LeftButton1;
        private System.Windows.Forms.Button LeftButton2;
        private System.Windows.Forms.Button RightButton1;
        private System.Windows.Forms.Button RightButton2;
    }
}

