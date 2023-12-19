namespace kidsgame
{
    partial class Welcome_formcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_formcs));
            this.btn_sign_in_form = new System.Windows.Forms.Button();
            this.btn_loads_form = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sign_in_form
            // 
            this.btn_sign_in_form.BackColor = System.Drawing.SystemColors.Info;
            this.btn_sign_in_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sign_in_form.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign_in_form.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sign_in_form.Location = new System.Drawing.Point(62, 260);
            this.btn_sign_in_form.Name = "btn_sign_in_form";
            this.btn_sign_in_form.Size = new System.Drawing.Size(331, 95);
            this.btn_sign_in_form.TabIndex = 0;
            this.btn_sign_in_form.Text = "New Start";
            this.btn_sign_in_form.UseVisualStyleBackColor = false;
            this.btn_sign_in_form.Click += new System.EventHandler(this.btn_sign_in_form_Click);
            // 
            // btn_loads_form
            // 
            this.btn_loads_form.BackColor = System.Drawing.SystemColors.Info;
            this.btn_loads_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loads_form.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loads_form.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_loads_form.Location = new System.Drawing.Point(533, 260);
            this.btn_loads_form.Name = "btn_loads_form";
            this.btn_loads_form.Size = new System.Drawing.Size(331, 95);
            this.btn_loads_form.TabIndex = 1;
            this.btn_loads_form.Text = "Load";
            this.btn_loads_form.UseVisualStyleBackColor = false;
            this.btn_loads_form.Click += new System.EventHandler(this.btn_loads_form_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(200, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wonder Learn";
            // 
            // Welcome_formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loads_form);
            this.Controls.Add(this.btn_sign_in_form);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Welcome_formcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wonder Learn";
            this.Load += new System.EventHandler(this.Welcome_formcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sign_in_form;
        private System.Windows.Forms.Button btn_loads_form;
        private System.Windows.Forms.Label label1;
    }
}