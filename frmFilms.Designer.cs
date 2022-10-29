
namespace devoir2
{
    partial class frmFilms
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
            this.lblOverView = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOverView
            // 
            this.lblOverView.AutoSize = true;
            this.lblOverView.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverView.Location = new System.Drawing.Point(448, 70);
            this.lblOverView.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblOverView.Name = "lblOverView";
            this.lblOverView.Size = new System.Drawing.Size(69, 16);
            this.lblOverView.TabIndex = 9;
            this.lblOverView.Text = "OverView";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(448, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 21);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(52, 39);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(390, 283);
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuivant.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btnSuivant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.btnSuivant.Location = new System.Drawing.Point(357, 374);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(85, 33);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrecedent.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.btnPrecedent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.btnPrecedent.Location = new System.Drawing.Point(52, 374);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(85, 33);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(728, 436);
            this.Controls.Add(this.lblOverView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Name = "frmFilms";
            this.Text = "frmFilms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFilms_FormClosed);
            this.Load += new System.EventHandler(this.frmFilms_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFilms_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOverView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
    }
}