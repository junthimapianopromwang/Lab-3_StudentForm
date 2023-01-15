namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ชื่อ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.รหัส = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.all = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(128, 73);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(129, 27);
            this.Name.TabIndex = 0;
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(128, 118);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(129, 27);
            this.S.TabIndex = 1;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(128, 162);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(129, 27);
            this.B.TabIndex = 2;
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(128, 220);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(129, 27);
            this.T.TabIndex = 3;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(128, 265);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(129, 27);
            this.G.TabIndex = 4;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(128, 309);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(129, 27);
            this.M.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tall";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student.number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birth day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Major";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Information from student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ชื่อ,
            this.รหัส,
            this.bd,
            this.Tell,
            this.gr,
            this.mr});
            this.dataGridView1.Location = new System.Drawing.Point(263, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(760, 365);
            this.dataGridView1.TabIndex = 14;
            // 
            // ชื่อ
            // 
            this.ชื่อ.HeaderText = "Name";
            this.ชื่อ.MinimumWidth = 6;
            this.ชื่อ.Name = "ชื่อ";
            this.ชื่อ.ReadOnly = true;
            this.ชื่อ.Width = 125;
            // 
            // รหัส
            // 
            this.รหัส.HeaderText = "STnumber";
            this.รหัส.MinimumWidth = 6;
            this.รหัส.Name = "รหัส";
            this.รหัส.ReadOnly = true;
            this.รหัส.Width = 125;
            // 
            // bd
            // 
            this.bd.HeaderText = "Birth day";
            this.bd.MinimumWidth = 6;
            this.bd.Name = "bd";
            this.bd.ReadOnly = true;
            this.bd.Width = 125;
            // 
            // Tell
            // 
            this.Tell.HeaderText = "Tall";
            this.Tell.MinimumWidth = 6;
            this.Tell.Name = "Tell";
            this.Tell.ReadOnly = true;
            this.Tell.Width = 125;
            // 
            // gr
            // 
            this.gr.HeaderText = "Grade";
            this.gr.MinimumWidth = 6;
            this.gr.Name = "gr";
            this.gr.ReadOnly = true;
            this.gr.Width = 125;
            // 
            // mr
            // 
            this.mr.HeaderText = "Major";
            this.mr.MinimumWidth = 6;
            this.mr.Name = "mr";
            this.mr.ReadOnly = true;
            this.mr.Width = 125;
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(836, 29);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(187, 27);
            this.all.TabIndex = 15;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(643, 29);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(187, 27);
            this.min.TabIndex = 16;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(450, 29);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(187, 27);
            this.max.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.all);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.M);
            this.Controls.Add(this.G);
            this.Controls.Add(this.T);
            this.Controls.Add(this.B);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Name);
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Name;
        private TextBox TextBox_name;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox S;
        private TextBox B;
        private TextBox T;
        private TextBox G;
        private TextBox M;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ชื่อ;
        private DataGridViewTextBoxColumn รหัส;
        private DataGridViewTextBoxColumn bd;
        private DataGridViewTextBoxColumn Tell;
        private DataGridViewTextBoxColumn gr;
        private DataGridViewTextBoxColumn mr;
        private TextBox all;
        private TextBox min;
        private TextBox max;
    }
}