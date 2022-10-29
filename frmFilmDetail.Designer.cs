
namespace devoir2
{
    partial class frmFilmDetail
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbtDateDetail = new System.Windows.Forms.Label();
            this.lblOverViewDetail = new System.Windows.Forms.Label();
            this.lblTitleDetail = new System.Windows.Forms.Label();
            this.lbl_vote_count = new System.Windows.Forms.Label();
            this.lbl_vote_average = new System.Windows.Forms.Label();
            this.lblPopularity = new System.Windows.Forms.Label();
            this.lblOriginal_language = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(399, 253);
            this.webBrowser1.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnBack.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.btnBack.Location = new System.Drawing.Point(349, 437);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbtDateDetail
            // 
            this.lbtDateDetail.AutoSize = true;
            this.lbtDateDetail.Location = new System.Drawing.Point(111, 295);
            this.lbtDateDetail.Name = "lbtDateDetail";
            this.lbtDateDetail.Size = new System.Drawing.Size(72, 13);
            this.lbtDateDetail.TabIndex = 10;
            this.lbtDateDetail.Text = "Release Date";
            // 
            // lblOverViewDetail
            // 
            this.lblOverViewDetail.AutoSize = true;
            this.lblOverViewDetail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverViewDetail.Location = new System.Drawing.Point(438, 71);
            this.lblOverViewDetail.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblOverViewDetail.Name = "lblOverViewDetail";
            this.lblOverViewDetail.Size = new System.Drawing.Size(69, 16);
            this.lblOverViewDetail.TabIndex = 9;
            this.lblOverViewDetail.Text = "OverView";
            // 
            // lblTitleDetail
            // 
            this.lblTitleDetail.AutoSize = true;
            this.lblTitleDetail.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDetail.Location = new System.Drawing.Point(437, 41);
            this.lblTitleDetail.Name = "lblTitleDetail";
            this.lblTitleDetail.Size = new System.Drawing.Size(48, 21);
            this.lblTitleDetail.TabIndex = 8;
            this.lblTitleDetail.Text = "Title";
            // 
            // lbl_vote_count
            // 
            this.lbl_vote_count.AutoSize = true;
            this.lbl_vote_count.Location = new System.Drawing.Point(111, 383);
            this.lbl_vote_count.Name = "lbl_vote_count";
            this.lbl_vote_count.Size = new System.Drawing.Size(61, 13);
            this.lbl_vote_count.TabIndex = 16;
            this.lbl_vote_count.Text = "vote_count";
            // 
            // lbl_vote_average
            // 
            this.lbl_vote_average.AutoSize = true;
            this.lbl_vote_average.Location = new System.Drawing.Point(111, 415);
            this.lbl_vote_average.Name = "lbl_vote_average";
            this.lbl_vote_average.Size = new System.Drawing.Size(73, 13);
            this.lbl_vote_average.TabIndex = 17;
            this.lbl_vote_average.Text = "vote_average";
            // 
            // lblPopularity
            // 
            this.lblPopularity.AutoSize = true;
            this.lblPopularity.Location = new System.Drawing.Point(111, 352);
            this.lblPopularity.Name = "lblPopularity";
            this.lblPopularity.Size = new System.Drawing.Size(52, 13);
            this.lblPopularity.TabIndex = 18;
            this.lblPopularity.Text = "popularity";
            // 
            // lblOriginal_language
            // 
            this.lblOriginal_language.AutoSize = true;
            this.lblOriginal_language.Location = new System.Drawing.Point(111, 322);
            this.lblOriginal_language.Name = "lblOriginal_language";
            this.lblOriginal_language.Size = new System.Drawing.Size(90, 13);
            this.lblOriginal_language.TabIndex = 19;
            this.lblOriginal_language.Text = "original_language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Realase Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Original Language:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Popularity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vote Count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Vote Average";
            // 
            // frmFilmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(774, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOriginal_language);
            this.Controls.Add(this.lblPopularity);
            this.Controls.Add(this.lbl_vote_average);
            this.Controls.Add(this.lbl_vote_count);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbtDateDetail);
            this.Controls.Add(this.lblOverViewDetail);
            this.Controls.Add(this.lblTitleDetail);
            this.Name = "frmFilmDetail";
            this.Text = "frmFilmDetail";
            this.Load += new System.EventHandler(this.frmFilmDetail_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFilmDetail_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbtDateDetail;
        private System.Windows.Forms.Label lblOverViewDetail;
        private System.Windows.Forms.Label lblTitleDetail;
        private System.Windows.Forms.Label lbl_vote_count;
        private System.Windows.Forms.Label lbl_vote_average;
        private System.Windows.Forms.Label lblPopularity;
        private System.Windows.Forms.Label lblOriginal_language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}