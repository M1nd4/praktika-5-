using System.Windows.Forms;

namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BClick
            // 
            this.BClick.Image = ((System.Drawing.Image)(resources.GetObject("BClick.Image")));
            this.BClick.Location = new System.Drawing.Point(232, 147);
            this.BClick.Name = "BClick";
            this.BClick.Size = new System.Drawing.Size(274, 82);
            this.BClick.TabIndex = 0;
            this.BClick.Tag = "";
            this.BClick.UseVisualStyleBackColor = true;
            this.BClick.Click += new System.EventHandler(this.BClick_Click);
            this.BClick.MouseEnter += new System.EventHandler(this.BClick_MouseEnter);
            this.BClick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BClick);
            this.Name = "Form1";
            this.Text = "red";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BClick;

        public MouseEventHandler BClick_MouseClick { get; private set; }
    }
}

