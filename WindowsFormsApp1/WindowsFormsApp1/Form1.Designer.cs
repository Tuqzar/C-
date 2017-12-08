namespace WindowsFormsApp1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlustMinus = new System.Windows.Forms.Button();
            this.btnPersent = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPlust = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnPlustMinus);
            this.flowLayoutPanel1.Controls.Add(this.btnPersent);
            this.flowLayoutPanel1.Controls.Add(this.btnDivision);
            this.flowLayoutPanel1.Controls.Add(this.btnSeven);
            this.flowLayoutPanel1.Controls.Add(this.btnEight);
            this.flowLayoutPanel1.Controls.Add(this.btnNine);
            this.flowLayoutPanel1.Controls.Add(this.btnMultiply);
            this.flowLayoutPanel1.Controls.Add(this.btnFour);
            this.flowLayoutPanel1.Controls.Add(this.btnFive);
            this.flowLayoutPanel1.Controls.Add(this.btnSix);
            this.flowLayoutPanel1.Controls.Add(this.btnMinus);
            this.flowLayoutPanel1.Controls.Add(this.btnOne);
            this.flowLayoutPanel1.Controls.Add(this.btnTwo);
            this.flowLayoutPanel1.Controls.Add(this.btnThree);
            this.flowLayoutPanel1.Controls.Add(this.btnPlust);
            this.flowLayoutPanel1.Controls.Add(this.btnZero);
            this.flowLayoutPanel1.Controls.Add(this.btnComma);
            this.flowLayoutPanel1.Controls.Add(this.btnEqual);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 219);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 330);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.FlatAppearance.BorderSize = 10;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(3, 3);
            this.btnClear.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnClear.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClick);
            // 
            // btnPlustMinus
            // 
            this.btnPlustMinus.FlatAppearance.BorderSize = 0;
            this.btnPlustMinus.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlustMinus.Location = new System.Drawing.Point(69, 3);
            this.btnPlustMinus.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnPlustMinus.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnPlustMinus.Name = "btnPlustMinus";
            this.btnPlustMinus.Size = new System.Drawing.Size(60, 60);
            this.btnPlustMinus.TabIndex = 1;
            this.btnPlustMinus.Text = "+/-";
            this.btnPlustMinus.UseVisualStyleBackColor = true;
            this.btnPlustMinus.Click += new System.EventHandler(this.btnClick);
            // 
            // btnPersent
            // 
            this.btnPersent.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPersent.Location = new System.Drawing.Point(135, 3);
            this.btnPersent.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnPersent.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnPersent.Name = "btnPersent";
            this.btnPersent.Size = new System.Drawing.Size(60, 60);
            this.btnPersent.TabIndex = 2;
            this.btnPersent.Text = "%";
            this.btnPersent.UseVisualStyleBackColor = true;
            this.btnPersent.Click += new System.EventHandler(this.btnClick);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivision.Location = new System.Drawing.Point(201, 3);
            this.btnDivision.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnDivision.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(60, 60);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeven.Location = new System.Drawing.Point(3, 69);
            this.btnSeven.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnSeven.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(60, 60);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnClick);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEight.Location = new System.Drawing.Point(69, 69);
            this.btnEight.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnEight.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(60, 60);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnClick);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNine.Location = new System.Drawing.Point(135, 69);
            this.btnNine.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnNine.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(60, 60);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(201, 69);
            this.btnMultiply.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnMultiply.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 60);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnClick);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFour.Location = new System.Drawing.Point(3, 135);
            this.btnFour.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnFour.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(60, 60);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnClick);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFive.Location = new System.Drawing.Point(69, 135);
            this.btnFive.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnFive.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(60, 60);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSix.Location = new System.Drawing.Point(135, 135);
            this.btnSix.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnSix.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(60, 60);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(201, 135);
            this.btnMinus.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnMinus.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnClick);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOne.Location = new System.Drawing.Point(3, 201);
            this.btnOne.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnOne.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 60);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnClick);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTwo.Location = new System.Drawing.Point(69, 201);
            this.btnTwo.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnTwo.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(60, 60);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnClick);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThree.Location = new System.Drawing.Point(135, 201);
            this.btnThree.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnThree.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(60, 60);
            this.btnThree.TabIndex = 14;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnClick);
            // 
            // btnPlust
            // 
            this.btnPlust.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPlust.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlust.Location = new System.Drawing.Point(201, 201);
            this.btnPlust.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnPlust.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnPlust.Name = "btnPlust";
            this.btnPlust.Size = new System.Drawing.Size(60, 60);
            this.btnPlust.TabIndex = 15;
            this.btnPlust.Text = "+";
            this.btnPlust.UseVisualStyleBackColor = false;
            this.btnPlust.Click += new System.EventHandler(this.btnClick);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZero.Location = new System.Drawing.Point(3, 267);
            this.btnZero.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnZero.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(126, 60);
            this.btnZero.TabIndex = 16;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnClick);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComma.Location = new System.Drawing.Point(135, 267);
            this.btnComma.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnComma.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(60, 60);
            this.btnComma.TabIndex = 18;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.btnClick);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEqual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEqual.Location = new System.Drawing.Point(201, 267);
            this.btnEqual.MaximumSize = new System.Drawing.Size(130, 130);
            this.btnEqual.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(60, 60);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 182);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(330, 600);
            this.MinimumSize = new System.Drawing.Size(330, 600);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlustMinus;
        private System.Windows.Forms.Button btnPersent;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnPlust;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label1;
    }
}

