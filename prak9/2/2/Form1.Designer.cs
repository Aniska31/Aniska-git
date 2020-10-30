namespace _2
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.форматPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
      // 
      // загрузитьToolStripMenuItem
      // 
      this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изображениеToolStripMenuItem});
      this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
      this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
      this.загрузитьToolStripMenuItem.Text = "Загрузить";
      // 
      // изображениеToolStripMenuItem
      // 
      this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форматToolStripMenuItem,
            this.форматPNGToolStripMenuItem});
      this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
      this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.изображениеToolStripMenuItem.Text = "Изображение";
      // 
      // форматToolStripMenuItem
      // 
      this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
      this.форматToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.форматToolStripMenuItem.Text = "Формат JPG";
      this.форматToolStripMenuItem.Click += new System.EventHandler(this.форматToolStripMenuItem_Click);
      // 
      // форматPNGToolStripMenuItem
      // 
      this.форматPNGToolStripMenuItem.Name = "форматPNGToolStripMenuItem";
      this.форматPNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.форматPNGToolStripMenuItem.Text = "Формат PNG";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматPNGToolStripMenuItem;
    }
}

