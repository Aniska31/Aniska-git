namespace _1
{
  partial class Best_Form
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
      this.Question = new System.Windows.Forms.Label();
      this.Yes = new System.Windows.Forms.Button();
      this.No = new System.Windows.Forms.Button();
      this.OX = new System.Windows.Forms.TextBox();
      this.OY = new System.Windows.Forms.TextBox();
      this.X = new System.Windows.Forms.Label();
      this.Y = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Question
      // 
      this.Question.AutoSize = true;
      this.Question.Font = new System.Drawing.Font("Swis721 BlkOul BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Question.Location = new System.Drawing.Point(71, 184);
      this.Question.Name = "Question";
      this.Question.Size = new System.Drawing.Size(315, 29);
      this.Question.TabIndex = 0;
      this.Question.Text = "Вы хотите попить пивка?";
      this.Question.Click += new System.EventHandler(this.label1_Click);
      // 
      // Yes
      // 
      this.Yes.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Yes.Location = new System.Drawing.Point(76, 325);
      this.Yes.Name = "Yes";
      this.Yes.Size = new System.Drawing.Size(91, 34);
      this.Yes.TabIndex = 1;
      this.Yes.Text = "Безусловно!!!";
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
      // X
      // 
      this.X.AutoSize = true;
      this.X.Location = new System.Drawing.Point(15, 15);
      this.X.Name = "X";
      this.X.Size = new System.Drawing.Size(17, 13);
      this.X.TabIndex = 5;
      this.X.Text = "X:";
      // 
      // Y
      // 
      this.Y.AutoSize = true;
      this.Y.Location = new System.Drawing.Point(15, 52);
      this.Y.Name = "Y";
      this.Y.Size = new System.Drawing.Size(17, 13);
      this.Y.TabIndex = 6;
      this.Y.Text = "Y:";
      // 
      // Best_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(453, 444);
      this.Controls.Add(this.Y);
      this.Controls.Add(this.X);
      this.Controls.Add(this.OY);
      this.Controls.Add(this.OX);
      this.Controls.Add(this.No);
      this.Controls.Add(this.Yes);
      this.Controls.Add(this.Question);
      this.Name = "Best_Form";
      this.Text = "Предложение, от которого нельзя отказаться";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.TextBox OX;
        private System.Windows.Forms.TextBox OY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
    }
}

