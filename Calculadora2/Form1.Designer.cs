namespace Calculadora2
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
            this.label2 = new System.Windows.Forms.Label();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.lblOper = new System.Windows.Forms.Label();
            this.btIgual = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btSoma = new System.Windows.Forms.Button();
            this.btnSegue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2";
            // 
            // numOper1
            // 
            this.numOper1.DecimalPlaces = 3;
            this.numOper1.Location = new System.Drawing.Point(284, 83);
            this.numOper1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(120, 20);
            this.numOper1.TabIndex = 2;
            // 
            // numOper2
            // 
            this.numOper2.DecimalPlaces = 3;
            this.numOper2.Location = new System.Drawing.Point(271, 220);
            this.numOper2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(120, 20);
            this.numOper2.TabIndex = 3;
            this.numOper2.ValueChanged += new System.EventHandler(this.numOper2_ValueChanged);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(271, 133);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(44, 38);
            this.btSub.TabIndex = 5;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(345, 133);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(46, 38);
            this.btMult.TabIndex = 6;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(423, 133);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(40, 38);
            this.btDiv.TabIndex = 7;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(502, 144);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(25, 22);
            this.lblOper.TabIndex = 8;
            this.lblOper.Text = "...";
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(271, 292);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(84, 38);
            this.btIgual.TabIndex = 9;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(57, 366);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(658, 33);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "NaN";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(203, 133);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(43, 38);
            this.btSoma.TabIndex = 11;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click_1);
            // 
            // btnSegue
            // 
            this.btnSegue.Enabled = false;
            this.btnSegue.Location = new System.Drawing.Point(160, 295);
            this.btnSegue.Name = "btnSegue";
            this.btnSegue.Size = new System.Drawing.Size(70, 38);
            this.btnSegue.TabIndex = 12;
            this.btnSegue.Text = "Segue";
            this.btnSegue.UseVisualStyleBackColor = true;
            this.btnSegue.Click += new System.EventHandler(this.btnSegue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSegue);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btnSegue;
        private System.Windows.Forms.Button button1;
    }
}

