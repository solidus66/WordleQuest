namespace WordleQuest
{
    partial class StartScreenUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvl5 = new Button();
            lvl4 = new Button();
            lvl3 = new Button();
            lvl2 = new Button();
            lvl1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 280);
            panel1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(64, 232);
            label5.Name = "label5";
            label5.Size = new Size(330, 37);
            label5.TabIndex = 19;
            label5.Text = "собери все части пазла....";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(88, 192);
            label4.Name = "label4";
            label4.Size = new Size(266, 37);
            label4.TabIndex = 18;
            label4.Text = "Пройди все уровни,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 144);
            label3.Name = "label3";
            label3.Size = new Size(423, 50);
            label3.TabIndex = 17;
            label3.Text = "Эта игра-квест для тебя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 72);
            label2.Name = "label2";
            label2.Size = new Size(229, 50);
            label2.TabIndex = 16;
            label2.Text = "C 8 Мартой!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 16);
            label1.Name = "label1";
            label1.Size = new Size(303, 54);
            label1.TabIndex = 15;
            label1.Text = "Привет медвед";
            // 
            // lvl5
            // 
            lvl5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvl5.Location = new Point(72, 656);
            lvl5.Name = "lvl5";
            lvl5.Size = new Size(304, 72);
            lvl5.TabIndex = 21;
            lvl5.Text = "Уровень 5";
            lvl5.UseVisualStyleBackColor = true;
            lvl5.Click += lvl5_Click;
            // 
            // lvl4
            // 
            lvl4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvl4.Location = new Point(72, 568);
            lvl4.Name = "lvl4";
            lvl4.Size = new Size(304, 72);
            lvl4.TabIndex = 20;
            lvl4.Text = "Уровень 4";
            lvl4.UseVisualStyleBackColor = true;
            lvl4.Click += lvl4_Click;
            // 
            // lvl3
            // 
            lvl3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvl3.Location = new Point(72, 480);
            lvl3.Name = "lvl3";
            lvl3.Size = new Size(304, 72);
            lvl3.TabIndex = 19;
            lvl3.Text = "Уровень 3";
            lvl3.UseVisualStyleBackColor = true;
            lvl3.Click += lvl3_Click;
            // 
            // lvl2
            // 
            lvl2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvl2.Location = new Point(72, 392);
            lvl2.Name = "lvl2";
            lvl2.Size = new Size(304, 72);
            lvl2.TabIndex = 18;
            lvl2.Text = "Уровень 2";
            lvl2.UseVisualStyleBackColor = true;
            lvl2.Click += lvl2_Click;
            // 
            // lvl1
            // 
            lvl1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvl1.Location = new Point(72, 304);
            lvl1.Name = "lvl1";
            lvl1.Size = new Size(304, 72);
            lvl1.TabIndex = 17;
            lvl1.Text = "Уровень 1";
            lvl1.UseVisualStyleBackColor = true;
            lvl1.Click += lvl1_Click;
            // 
            // StartScreenUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lvl5);
            Controls.Add(lvl4);
            Controls.Add(lvl3);
            Controls.Add(lvl2);
            Controls.Add(lvl1);
            Name = "StartScreenUC";
            Size = new Size(450, 744);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button lvl5;
        private Button lvl4;
        private Button lvl3;
        private Button lvl2;
        private Button lvl1;
    }
}
