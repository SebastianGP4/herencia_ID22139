
namespace Herencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.valor1t = new System.Windows.Forms.Label();
            this.valor2t = new System.Windows.Forms.Label();
            this.resultadot = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.Color.Azure;
            this.sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(313, 12);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(120, 30);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = false;
            // 
            // restar
            // 
            this.restar.BackColor = System.Drawing.Color.Azure;
            this.restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.Location = new System.Drawing.Point(313, 48);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(120, 34);
            this.restar.TabIndex = 1;
            this.restar.Text = "Restar";
            this.restar.UseVisualStyleBackColor = false;
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.Azure;
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(313, 88);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(120, 31);
            this.multiplicar.TabIndex = 2;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = false;
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.Azure;
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(313, 125);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(120, 31);
            this.dividir.TabIndex = 3;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = false;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Azure;
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(313, 162);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(120, 35);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = false;
            // 
            // valor1t
            // 
            this.valor1t.AutoSize = true;
            this.valor1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1t.Location = new System.Drawing.Point(12, 22);
            this.valor1t.Name = "valor1t";
            this.valor1t.Size = new System.Drawing.Size(69, 24);
            this.valor1t.TabIndex = 5;
            this.valor1t.Text = "Valor 1";
            // 
            // valor2t
            // 
            this.valor2t.AutoSize = true;
            this.valor2t.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2t.Location = new System.Drawing.Point(12, 58);
            this.valor2t.Name = "valor2t";
            this.valor2t.Size = new System.Drawing.Size(69, 24);
            this.valor2t.TabIndex = 6;
            this.valor2t.Text = "Valor 2";
            // 
            // resultadot
            // 
            this.resultadot.AutoSize = true;
            this.resultadot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadot.Location = new System.Drawing.Point(12, 95);
            this.resultadot.Name = "resultadot";
            this.resultadot.Size = new System.Drawing.Size(94, 24);
            this.resultadot.TabIndex = 7;
            this.resultadot.Text = "Resultado";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(128, 27);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(139, 20);
            this.valor1.TabIndex = 8;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(128, 63);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(139, 20);
            this.valor2.TabIndex = 9;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(128, 100);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(139, 20);
            this.resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 209);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.resultadot);
            this.Controls.Add(this.valor2t);
            this.Controls.Add(this.valor1t);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label valor1t;
        private System.Windows.Forms.Label valor2t;
        private System.Windows.Forms.Label resultadot;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox resultado;
    }
}

