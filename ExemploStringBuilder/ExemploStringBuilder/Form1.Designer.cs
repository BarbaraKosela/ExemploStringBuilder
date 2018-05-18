namespace ExemploStringBuilder
{
    partial class Form1
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
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btProcessar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(63, 12);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(193, 20);
            this.txtNome1.TabIndex = 2;
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(63, 38);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(193, 20);
            this.txtNome2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME:";
            // 
            // txtNome3
            // 
            this.txtNome3.Location = new System.Drawing.Point(63, 64);
            this.txtNome3.Name = "txtNome3";
            this.txtNome3.Size = new System.Drawing.Size(193, 20);
            this.txtNome3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOME:";
            // 
            // btProcessar
            // 
            this.btProcessar.Location = new System.Drawing.Point(135, 90);
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(121, 55);
            this.btProcessar.TabIndex = 7;
            this.btProcessar.Text = "Processar";
            this.btProcessar.UseVisualStyleBackColor = true;
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 167);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(244, 189);
            this.txtResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 385);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btProcessar);
            this.Controls.Add(this.txtNome3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btProcessar;
        private System.Windows.Forms.TextBox txtResultado;

    }
}

