using Calculator_Scientific.Main;

namespace Calculator_Scientific
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmboperacion = new ComboBox();
            btncalcular = new Button();
            txtvalor2 = new TextBox();
            txtvalor1 = new TextBox();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // cmboperacion
            // 
            cmboperacion.FormattingEnabled = true;
            cmboperacion.Items.AddRange(new object[] { "suma", "resta", "multiplicacion", "division" });
            cmboperacion.Location = new Point(71, 57);
            cmboperacion.Name = "cmboperacion";
            cmboperacion.Size = new Size(151, 28);
            cmboperacion.TabIndex = 0;
            cmboperacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(230, 223);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(94, 29);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "button1";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtvalor2
            // 
            txtvalor2.Location = new Point(71, 161);
            txtvalor2.Name = "txtvalor2";
            txtvalor2.Size = new Size(125, 27);
            txtvalor2.TabIndex = 2;
            // 
            // txtvalor1
            // 
            txtvalor1.Location = new Point(71, 128);
            txtvalor1.Name = "txtvalor1";
            txtvalor1.Size = new Size(125, 27);
            txtvalor1.TabIndex = 3;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(553, 161);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(50, 20);
            LblResultado.TabIndex = 4;
            LblResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResultado);
            Controls.Add(txtvalor1);
            Controls.Add(txtvalor2);
            Controls.Add(btncalcular);
            Controls.Add(cmboperacion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmboperacion;
        private Button btncalcular;
        private TextBox txtvalor2;
        private TextBox txtvalor1;
        private Label LblResultado;
    }
}
