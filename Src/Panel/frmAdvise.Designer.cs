namespace HCG_NNLT.Src.Panel
{
    partial class frmAdvise
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
<<<<<<< HEAD
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.AnswerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
=======
            this.btnStart = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer5 = new System.Windows.Forms.Button();
>>>>>>> origin/kendz
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tư Vấn Lựa Chọn Ngôn Ngữ Lập Trình";
            // 
<<<<<<< HEAD
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 583);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuestion);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(375, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 583);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(65, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 27);
            this.textBox1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnswerID,
            this.CurrentQuestion,
            this.NextQuestion,
            this.AnswerName});
            this.dgv.Location = new System.Drawing.Point(6, 255);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(694, 322);
            this.dgv.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(65, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(47, 36);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(349, 25);
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.Text = "Tư Vấn Lựa Chọn Ngôn Ngữ Lập Trình";
            // 
            // AnswerID
            // 
            this.AnswerID.DataPropertyName = "AnswerID";
            this.AnswerID.HeaderText = "AnswerID";
            this.AnswerID.MinimumWidth = 6;
            this.AnswerID.Name = "AnswerID";
            this.AnswerID.ReadOnly = true;
            // 
            // CurrentQuestion
            // 
            this.CurrentQuestion.DataPropertyName = "CurrentQuestion";
            this.CurrentQuestion.HeaderText = "CurrentQuestion";
            this.CurrentQuestion.MinimumWidth = 6;
            this.CurrentQuestion.Name = "CurrentQuestion";
            this.CurrentQuestion.ReadOnly = true;
            // 
            // NextQuestion
            // 
            this.NextQuestion.DataPropertyName = "NextQuestion";
            this.NextQuestion.HeaderText = "NextQuestion";
            this.NextQuestion.MinimumWidth = 6;
            this.NextQuestion.Name = "NextQuestion";
            this.NextQuestion.ReadOnly = true;
            // 
            // AnswerName
            // 
            this.AnswerName.DataPropertyName = "AnswerName";
            this.AnswerName.HeaderText = "AnswerName";
            this.AnswerName.MinimumWidth = 6;
            this.AnswerName.Name = "AnswerName";
            this.AnswerName.ReadOnly = true;
=======
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(353, 225);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(219, 137);
            this.lbQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(415, 26);
            this.lbQuestion.TabIndex = 2;
            this.lbQuestion.Text = "Tư Vấn Lựa Chọn Ngôn Ngữ Lập Trình";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(84, 331);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(139, 52);
            this.btnAnswer1.TabIndex = 3;
            this.btnAnswer1.Text = "Bắt Đầu";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(570, 331);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(139, 52);
            this.btnAnswer2.TabIndex = 4;
            this.btnAnswer2.Text = "Bắt Đầu";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(84, 442);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(139, 52);
            this.btnAnswer3.TabIndex = 5;
            this.btnAnswer3.Text = "Bắt Đầu";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(570, 442);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(139, 52);
            this.btnAnswer4.TabIndex = 6;
            this.btnAnswer4.Text = "Bắt Đầu";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnAnswer5
            // 
            this.btnAnswer5.Location = new System.Drawing.Point(353, 569);
            this.btnAnswer5.Name = "btnAnswer5";
            this.btnAnswer5.Size = new System.Drawing.Size(139, 52);
            this.btnAnswer5.TabIndex = 7;
            this.btnAnswer5.Text = "Bắt Đầu";
            this.btnAnswer5.UseVisualStyleBackColor = true;
>>>>>>> origin/kendz
            // 
            // frmAdvise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1093, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
=======
            this.ClientSize = new System.Drawing.Size(820, 660);
            this.Controls.Add(this.btnAnswer5);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.btnStart);
>>>>>>> origin/kendz
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdvise";
            this.Text = "frmAdvise";
            this.Load += new System.EventHandler(this.frmAdvise_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerName;
=======
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer5;
>>>>>>> origin/kendz
    }
}