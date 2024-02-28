namespace WordleQuest
{
    partial class LvlScreenUC
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
            restart_button = new Button();
            back_button = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 184);
            panel1.TabIndex = 9;
            // 
            // restart_button
            // 
            restart_button.Location = new Point(304, 16);
            restart_button.Name = "restart_button";
            restart_button.Size = new Size(128, 48);
            restart_button.TabIndex = 8;
            restart_button.Text = "Начать заново";
            restart_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            back_button.Location = new Point(16, 16);
            back_button.Name = "back_button";
            back_button.Size = new Size(128, 48);
            back_button.TabIndex = 7;
            back_button.Text = "В меню";
            back_button.UseVisualStyleBackColor = true;
            // 
            // LvlScreenUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(restart_button);
            Controls.Add(back_button);
            Name = "LvlScreenUC";
            Size = new Size(450, 744);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button restart_button;
        private Button back_button;
    }
}
