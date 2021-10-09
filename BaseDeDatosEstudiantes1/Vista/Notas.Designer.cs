
namespace BaseDeDatosEstudiantes1.Vista
{
    partial class Notas
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDEstudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDMateria \r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IDNotas\r\n";
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(39, 78);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(120, 20);
            this.textBox01.TabIndex = 3;
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(39, 182);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(132, 20);
            this.textBox02.TabIndex = 4;
            // 
            // textBox03
            // 
            this.textBox03.Location = new System.Drawing.Point(39, 280);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(132, 20);
            this.textBox03.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(583, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox03);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Notas";
            this.Text = "Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.Button button1;
    }
}