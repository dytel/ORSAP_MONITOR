namespace WindowsFormsApp
{
    partial class Monitor
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
            this._textBoxHeightMonitor = new System.Windows.Forms.TextBox();
            this._textBoxWightMonitor = new System.Windows.Forms.TextBox();
            this._textBoxHeightStande = new System.Windows.Forms.TextBox();
            this._textBoxWigthStande = new System.Windows.Forms.TextBox();
            this._textBoxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxScreenRatio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _textBoxHeightMonitor
            // 
            this._textBoxHeightMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxHeightMonitor.Location = new System.Drawing.Point(200, 37);
            this._textBoxHeightMonitor.Name = "_textBoxHeightMonitor";
            this._textBoxHeightMonitor.Size = new System.Drawing.Size(100, 20);
            this._textBoxHeightMonitor.TabIndex = 1;
            this._textBoxHeightMonitor.Leave += new System.EventHandler(this._textBoxHeightMonito_Leave);
            // 
            // _textBoxWightMonitor
            // 
            this._textBoxWightMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxWightMonitor.Location = new System.Drawing.Point(200, 63);
            this._textBoxWightMonitor.Name = "_textBoxWightMonitor";
            this._textBoxWightMonitor.Size = new System.Drawing.Size(100, 20);
            this._textBoxWightMonitor.TabIndex = 2;
            this._textBoxWightMonitor.Leave += new System.EventHandler(this._textBoxWightMonitor_Leave);
            // 
            // _textBoxHeightStande
            // 
            this._textBoxHeightStande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxHeightStande.Location = new System.Drawing.Point(200, 89);
            this._textBoxHeightStande.Name = "_textBoxHeightStande";
            this._textBoxHeightStande.Size = new System.Drawing.Size(100, 20);
            this._textBoxHeightStande.TabIndex = 3;
            this._textBoxHeightStande.Leave += new System.EventHandler(this._textBoxHeightStande_Leave);
            // 
            // _textBoxWigthStande
            // 
            this._textBoxWigthStande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxWigthStande.Location = new System.Drawing.Point(200, 115);
            this._textBoxWigthStande.Name = "_textBoxWigthStande";
            this._textBoxWigthStande.Size = new System.Drawing.Size(100, 20);
            this._textBoxWigthStande.TabIndex = 4;
            this._textBoxWigthStande.Leave += new System.EventHandler(this._textBoxWigthStande_Leave);
            // 
            // _textBoxRadius
            // 
            this._textBoxRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxRadius.Location = new System.Drawing.Point(200, 141);
            this._textBoxRadius.Name = "_textBoxRadius";
            this._textBoxRadius.Size = new System.Drawing.Size(100, 20);
            this._textBoxRadius.TabIndex = 5;
            this._textBoxRadius.Leave += new System.EventHandler(this._textBoxRadius_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота Монитора";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина монитора";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Высота подставки";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ширина подставки";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Радиус нижней части подставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Собрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BuildModel_Click);
            // 
            // comboBoxScreenRatio
            // 
            this.comboBoxScreenRatio.AutoCompleteCustomSource.AddRange(new string[] {
            "\\"});
            this.comboBoxScreenRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScreenRatio.FormattingEnabled = true;
            this.comboBoxScreenRatio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxScreenRatio.Items.AddRange(new object[] {
            "16 : 9",
            "3 : 2",
            "4 : 3"});
            this.comboBoxScreenRatio.Location = new System.Drawing.Point(200, 10);
            this.comboBoxScreenRatio.Name = "comboBoxScreenRatio";
            this.comboBoxScreenRatio.Size = new System.Drawing.Size(100, 21);
            this.comboBoxScreenRatio.Sorted = true;
            this.comboBoxScreenRatio.TabIndex = 0;
            this.comboBoxScreenRatio.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBoxScreenRatio.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            this.comboBoxScreenRatio.DisplayMemberChanged += new System.EventHandler(this.comboBox_DisplayMemberChanged);
            this.comboBoxScreenRatio.SelectedValueChanged += new System.EventHandler(this.AspectRatio_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Разрешение экрана";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 202);
            this.Controls.Add(this.comboBoxScreenRatio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxRadius);
            this.Controls.Add(this._textBoxWigthStande);
            this.Controls.Add(this._textBoxHeightStande);
            this.Controls.Add(this._textBoxWightMonitor);
            this.Controls.Add(this._textBoxHeightMonitor);
            this.Name = "Monitor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = ".";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxHeightMonitor;
        private System.Windows.Forms.TextBox _textBoxWightMonitor;
        private System.Windows.Forms.TextBox _textBoxHeightStande;
        private System.Windows.Forms.TextBox _textBoxWigthStande;
        private System.Windows.Forms.TextBox _textBoxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxScreenRatio;
        private System.Windows.Forms.Label label6;
    }
}

