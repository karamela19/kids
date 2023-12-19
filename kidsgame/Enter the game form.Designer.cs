namespace kidsgame
{
    partial class Enter_the_game_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter_the_game_form));
            this.btn_quizzes = new System.Windows.Forms.Button();
            this.btn_learing = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quizzes
            // 
            this.btn_quizzes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_quizzes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quizzes.Image = ((System.Drawing.Image)(resources.GetObject("btn_quizzes.Image")));
            this.btn_quizzes.Location = new System.Drawing.Point(126, 101);
            this.btn_quizzes.Name = "btn_quizzes";
            this.btn_quizzes.Size = new System.Drawing.Size(319, 265);
            this.btn_quizzes.TabIndex = 0;
            this.btn_quizzes.UseVisualStyleBackColor = false;
            this.btn_quizzes.Click += new System.EventHandler(this.btn_quizzes_Click);
            // 
            // btn_learing
            // 
            this.btn_learing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_learing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_learing.Image = ((System.Drawing.Image)(resources.GetObject("btn_learing.Image")));
            this.btn_learing.Location = new System.Drawing.Point(573, 101);
            this.btn_learing.Name = "btn_learing";
            this.btn_learing.Size = new System.Drawing.Size(319, 265);
            this.btn_learing.TabIndex = 1;
            this.btn_learing.UseVisualStyleBackColor = false;
            this.btn_learing.Click += new System.EventHandler(this.btn_learing_Click);
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(30, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(72, 38);
            this.btn_back.TabIndex = 2;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Enter_the_game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(969, 532);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_learing);
            this.Controls.Add(this.btn_quizzes);
            this.Name = "Enter_the_game_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Enter_the_game_form_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quizzes;
        private System.Windows.Forms.Button btn_learing;
        private System.Windows.Forms.Button btn_back;
    }
}

