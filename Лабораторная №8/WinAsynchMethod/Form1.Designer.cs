﻿namespace WinAsynchMethod
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.help = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Значение A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(216, 24);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Значение B";
            // 
            // txbA
            // 
            this.helpProvider1.SetHelpString(this.txbA, "For input integer A");
            this.txbA.Location = new System.Drawing.Point(88, 24);
            this.txbA.Name = "txbA";
            this.helpProvider1.SetShowHelp(this.txbA, true);
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txbA, "For input integer A");
            // 
            // txbB
            // 
            this.helpProvider1.SetHelpString(this.txbB, "For input integer B");
            this.txbB.Location = new System.Drawing.Point(296, 24);
            this.txbB.Name = "txbB";
            this.helpProvider1.SetShowHelp(this.txbB, true);
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txbB, "For input integer B");
            // 
            // btnRun
            // 
            this.helpProvider1.SetHelpString(this.btnRun, "Summ");
            this.btnRun.Location = new System.Drawing.Point(16, 64);
            this.btnRun.Name = "btnRun";
            this.helpProvider1.SetShowHelp(this.btnRun, true);
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Сумма";
            this.toolTip1.SetToolTip(this.btnRun, "Summ");
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWork
            // 
            this.helpProvider1.SetHelpString(this.btnWork, "Start work");
            this.btnWork.Location = new System.Drawing.Point(120, 128);
            this.btnWork.Name = "btnWork";
            this.helpProvider1.SetShowHelp(this.btnWork, true);
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 5;
            this.btnWork.Text = "Работа";
            this.toolTip1.SetToolTip(this.btnWork, "Start work");
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\resid\\Desktop\\ОП\\Forms\\Лабораторная №8\\WinAsynchMethod\\Справка.docx";
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(322, 128);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 6;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.help);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

