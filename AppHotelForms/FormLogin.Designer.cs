namespace AppHotelForms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.BtnEntrarLogin = new System.Windows.Forms.Button();
            this.txtBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(343, 157);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(58, 16);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Email";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(350, 210);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(54, 17);
            this.labelSenha.TabIndex = 1;
            this.labelSenha.Text = "Senha";
            this.labelSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEntrarLogin
            // 
            this.BtnEntrarLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEntrarLogin.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrarLogin.Location = new System.Drawing.Point(346, 272);
            this.BtnEntrarLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEntrarLogin.Name = "BtnEntrarLogin";
            this.BtnEntrarLogin.Size = new System.Drawing.Size(56, 27);
            this.BtnEntrarLogin.TabIndex = 5;
            this.BtnEntrarLogin.Text = "Entrar";
            this.BtnEntrarLogin.UseVisualStyleBackColor = false;
            // 
            // txtBoxLoginEmail
            // 
            this.txtBoxLoginEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxLoginEmail.BackColor = System.Drawing.Color.Aquamarine;
            this.txtBoxLoginEmail.Location = new System.Drawing.Point(281, 176);
            this.txtBoxLoginEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxLoginEmail.Name = "txtBoxLoginEmail";
            this.txtBoxLoginEmail.Size = new System.Drawing.Size(180, 20);
            this.txtBoxLoginEmail.TabIndex = 6;
            // 
            // txtBoxLoginSenha
            // 
            this.txtBoxLoginSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxLoginSenha.BackColor = System.Drawing.Color.Aquamarine;
            this.txtBoxLoginSenha.Location = new System.Drawing.Point(281, 228);
            this.txtBoxLoginSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxLoginSenha.Name = "txtBoxLoginSenha";
            this.txtBoxLoginSenha.Size = new System.Drawing.Size(180, 20);
            this.txtBoxLoginSenha.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(317, 324);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 28);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastre-se";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppHotelForms.Properties.Resources._6122609;
            this.ClientSize = new System.Drawing.Size(773, 499);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxLoginSenha);
            this.Controls.Add(this.txtBoxLoginEmail);
            this.Controls.Add(this.BtnEntrarLogin);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN HOTEL ARA";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button BtnEntrarLogin;
        private System.Windows.Forms.TextBox txtBoxLoginEmail;
        private System.Windows.Forms.TextBox txtBoxLoginSenha;
        private System.Windows.Forms.Button btnCadastrar;
    }
}