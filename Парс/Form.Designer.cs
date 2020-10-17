namespace Парс
{
    partial class Form
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
            this.write_inn = new System.Windows.Forms.Label();
            this.ready_ogrn = new System.Windows.Forms.Label();
            this.Inn = new System.Windows.Forms.TextBox();
            this.Ogrn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Kpp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // write_inn
            // 
            this.write_inn.AutoSize = true;
            this.write_inn.Location = new System.Drawing.Point(92, 86);
            this.write_inn.Name = "write_inn";
            this.write_inn.Size = new System.Drawing.Size(144, 13);
            this.write_inn.TabIndex = 0;
            this.write_inn.Text = "Введите ИНН организации";
            this.write_inn.Click += new System.EventHandler(this.Label_WriteInn);
            // 
            // ready_ogrn
            // 
            this.ready_ogrn.AutoSize = true;
            this.ready_ogrn.Location = new System.Drawing.Point(92, 192);
            this.ready_ogrn.Name = "ready_ogrn";
            this.ready_ogrn.Size = new System.Drawing.Size(104, 13);
            this.ready_ogrn.TabIndex = 1;
            this.ready_ogrn.Text = "ОГРН организации";
            this.ready_ogrn.Click += new System.EventHandler(this.Ready_ogrn_Click);
            // 
            // Inn
            // 
            this.Inn.Location = new System.Drawing.Point(95, 121);
            this.Inn.Name = "Inn";
            this.Inn.Size = new System.Drawing.Size(100, 20);
            this.Inn.TabIndex = 2;
            this.Inn.TextChanged += new System.EventHandler(this.Inn_TextForParsing);
            // 
            // Ogrn
            // 
            this.Ogrn.Location = new System.Drawing.Point(95, 234);
            this.Ogrn.Name = "Ogrn";
            this.Ogrn.ReadOnly = true;
            this.Ogrn.Size = new System.Drawing.Size(207, 20);
            this.Ogrn.TabIndex = 3;
            this.Ogrn.TextChanged += new System.EventHandler(this.Ogrn_ResultOfParsing);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 253);
            this.button1.TabIndex = 4;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_StartParsing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "КПП организации";
            this.label1.Click += new System.EventHandler(this.Label_WriteKpp);
            // 
            // Kpp
            // 
            this.Kpp.Location = new System.Drawing.Point(95, 319);
            this.Kpp.Name = "Kpp";
            this.Kpp.ReadOnly = true;
            this.Kpp.Size = new System.Drawing.Size(207, 20);
            this.Kpp.TabIndex = 8;
            this.Kpp.TextChanged += new System.EventHandler(this.Kpp_ResultOfParsing);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 429);
            this.Controls.Add(this.Kpp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ogrn);
            this.Controls.Add(this.Inn);
            this.Controls.Add(this.ready_ogrn);
            this.Controls.Add(this.write_inn);
            this.Name = "Form";
            this.Text = "Парс";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label write_inn;
        private System.Windows.Forms.Label ready_ogrn;
        private System.Windows.Forms.TextBox Inn;
        private System.Windows.Forms.TextBox Ogrn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kpp;
    }
}

