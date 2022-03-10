namespace ControleEstoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Inventory = new System.Windows.Forms.Label();
            this.lb_Cody = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCody = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Send);
            this.panel1.Controls.Add(this.txtInventory);
            this.panel1.Controls.Add(this.txtCody);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lb_Inventory);
            this.panel1.Controls.Add(this.lb_Cody);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 261);
            this.panel1.TabIndex = 0;
            // 
            // lb_Inventory
            // 
            this.lb_Inventory.AutoSize = true;
            this.lb_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inventory.Location = new System.Drawing.Point(26, 129);
            this.lb_Inventory.Name = "lb_Inventory";
            this.lb_Inventory.Size = new System.Drawing.Size(108, 24);
            this.lb_Inventory.TabIndex = 2;
            this.lb_Inventory.Text = "Quantidade";
            this.lb_Inventory.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_Cody
            // 
            this.lb_Cody.AutoSize = true;
            this.lb_Cody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cody.Location = new System.Drawing.Point(26, 72);
            this.lb_Cody.Name = "lb_Cody";
            this.lb_Cody.Size = new System.Drawing.Size(71, 24);
            this.lb_Cody.TabIndex = 1;
            this.lb_Cody.Text = "Código";
            this.lb_Cody.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(26, 23);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(62, 24);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtCody
            // 
            this.txtCody.Location = new System.Drawing.Point(140, 77);
            this.txtCody.Name = "txtCody";
            this.txtCody.Size = new System.Drawing.Size(100, 20);
            this.txtCody.TabIndex = 4;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(140, 129);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(100, 20);
            this.txtInventory.TabIndex = 5;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(227, 204);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(86, 29);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "Enviar";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 285);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Inventory;
        private System.Windows.Forms.Label lb_Cody;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtCody;
        private System.Windows.Forms.TextBox txtName;
    }
}

