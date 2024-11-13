namespace Golden_Ed_shop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.TextBox();
            this.Idade = new System.Windows.Forms.TextBox();
            this.CEP = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.NC = new System.Windows.Forms.TextBox();
            this.CVC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(648, 394);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(365, 20);
            this.Nome.TabIndex = 0;
          
            // 
            // Idade
            // 
            this.Idade.Location = new System.Drawing.Point(648, 449);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(365, 20);
            this.Idade.TabIndex = 1;
            // 
            // CEP
            // 
            this.CEP.Location = new System.Drawing.Point(648, 503);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(365, 20);
            this.CEP.TabIndex = 2;
           
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(648, 568);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(365, 20);
            this.Email.TabIndex = 3;
            // 
            // NC
            // 
            this.NC.Location = new System.Drawing.Point(648, 625);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(365, 20);
            this.NC.TabIndex = 4;
          
            // 
            // CVC
            // 
            this.CVC.Location = new System.Drawing.Point(648, 684);
            this.CVC.Name = "CVC";
            this.CVC.Size = new System.Drawing.Size(365, 20);
            this.CVC.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1070, 751);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 100);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Golden_Ed_shop.Properties.Resources.hhhh_resized__3_;
            this.button1.Location = new System.Drawing.Point(748, 898);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 112);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1234, 390);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 314);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golden_Ed_shop.Properties.Resources.hahaha;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CVC);
            this.Controls.Add(this.NC);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.panel1_Click);
            this.DoubleClick += new System.EventHandler(this.panel1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.TextBox CEP;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NC;
        private System.Windows.Forms.TextBox CVC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}

