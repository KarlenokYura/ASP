﻿namespace Lab7b
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
            this.Get = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.Button();
            this.Put = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Get
            // 
            this.Get.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get.Location = new System.Drawing.Point(14, 298);
            this.Get.Margin = new System.Windows.Forms.Padding(2);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(134, 38);
            this.Get.TabIndex = 0;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Post
            // 
            this.Post.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Post.Location = new System.Drawing.Point(166, 298);
            this.Post.Margin = new System.Windows.Forms.Padding(2);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(134, 38);
            this.Post.TabIndex = 1;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // Put
            // 
            this.Put.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Put.Location = new System.Drawing.Point(319, 298);
            this.Put.Margin = new System.Windows.Forms.Padding(2);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(134, 38);
            this.Put.TabIndex = 2;
            this.Put.Text = "Put";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Put_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(472, 298);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 38);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(46, 262);
            this.id.Margin = new System.Windows.Forms.Padding(2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(115, 24);
            this.id.TabIndex = 4;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(274, 263);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 24);
            this.name.TabIndex = 5;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.Location = new System.Drawing.Point(492, 264);
            this.number.Margin = new System.Windows.Forms.Padding(2);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(115, 24);
            this.number.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 240);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "SURNAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Put);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.Get);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ASMX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Button Put;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

