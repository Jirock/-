namespace Neva
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClick = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.t_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(153, 435);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(250, 48);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Войти";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(153, 374);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(250, 20);
            this.t_password.TabIndex = 3;
            this.t_password.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Авторизация";
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(153, 313);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(250, 20);
            this.t_name.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 157);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "66";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

