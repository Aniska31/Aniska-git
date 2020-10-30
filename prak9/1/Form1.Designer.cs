namespace _1
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
      this.Yes = new System.Windows.Forms.Button();
      this.No = new System.Windows.Forms.Button();
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
      // Yes
      // 
      this.Yes.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Yes.Location = new System.Drawing.Point(76, 325);
      this.Yes.Name = "Yes";
      this.Yes.Size = new System.Drawing.Size(91, 34);
      this.Yes.TabIndex = 1;
      this.Yes.Text = "Безусловно!";
      this.Yes.UseVisualStyleBackColor = true;
      this.Yes.Click += new System.EventHandler(this.button1_Click);
      // 
      // No
      // 
      this.No.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.No.Location = new System.Drawing.Point(246, 325);
      this.No.Name = "No";
      this.No.Size = new System.Drawing.Size(140, 34);
      this.No.TabIndex = 2;
      this.No.Text = "Ни в коем случае!";
      this.No.UseVisualStyleBackColor = true;
      this.No.Click += new System.EventHandler(this.No_Click);
      // 
      // OX
      // 
      this.OX.Location = new System.Drawing.Point(38, 12);
      this.OX.Name = "OX";
      this.OX.Size = new System.Drawing.Size(49, 20);
      this.OX.TabIndex = 3;
      this.OX.TextChanged += new System.EventHandler(this.OX_TextChanged);
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
      this.Controls.Add(this.No);
      this.Controls.Add(this.Yes);
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
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.TextBox OX;
        private System.Windows.Forms.TextBox OY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

