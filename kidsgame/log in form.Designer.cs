namespace kidsgame
{
    partial class log_in_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in_form));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.loads_list = new System.Windows.Forms.ComboBox();
            this.btn_login_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(57, 35);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(67, 43);
            this.btn_back.TabIndex = 3;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // loads_list
            // 
            this.loads_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loads_list.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loads_list.FormattingEnabled = true;
            this.loads_list.Location = new System.Drawing.Point(348, 158);
            this.loads_list.Name = "loads_list";
            this.loads_list.Size = new System.Drawing.Size(349, 29);
            this.loads_list.TabIndex = 5;
            this.loads_list.Text = "load";
            this.loads_list.SelectedIndexChanged += new System.EventHandler(this.loads_list_SelectedIndexChanged);
            // 
            // btn_login_game
            // 
            this.btn_login_game.BackColor = System.Drawing.SystemColors.Info;
            this.btn_login_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_game.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_game.Location = new System.Drawing.Point(62, 317);
            this.btn_login_game.Name = "btn_login_game";
            this.btn_login_game.Size = new System.Drawing.Size(145, 50);
            this.btn_login_game.TabIndex = 6;
            this.btn_login_game.Text = "Log In";
            this.btn_login_game.UseVisualStyleBackColor = false;
            this.btn_login_game.Click += new System.EventHandler(this.btn_login_game_Click);
            // 
            // log_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.btn_login_game);
            this.Controls.Add(this.loads_list);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Name = "log_in_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "log_in_form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.log_in_form_FormClosing);
            this.Load += new System.EventHandler(this.log_in_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox loads_list;
        private System.Windows.Forms.Button btn_login_game;
    }
}