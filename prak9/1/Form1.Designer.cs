﻿namespace _1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.OX = new System.Windows.Forms.TextBox();
      this.OY = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Swis721 BlkOul BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(71, 184);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(315, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "Вы хотите попить пивка?";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(76, 325);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(91, 34);
      this.button1.TabIndex = 1;
      this.button1.Text = "Безусловно!";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(246, 325);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(140, 34);
      this.button2.TabIndex = 2;
      this.button2.Text = "Ни в коем случаи!";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // OX
      // 
      this.OX.Location = new System.Drawing.Point(38, 12);
      this.OX.Name = "OX";
      this.OX.Size = new System.Drawing.Size(49, 20);
      this.OX.TabIndex = 3;
      // 
      // OY
      // 
      this.OY.Location = new System.Drawing.Point(38, 49);
      this.OY.Name = "OY";
      this.OY.Size = new System.Drawing.Size(49, 20);
      this.OY.TabIndex = 4;
      this.OY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(17, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "X:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(17, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Y:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(453, 444);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.OY);
      this.Controls.Add(this.OX);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Предложение, от которого нельзя отказаться";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox OX;
        private System.Windows.Forms.TextBox OY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

