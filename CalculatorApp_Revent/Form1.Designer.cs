namespace CalculatorApp_Revent
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.backSpace = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.plusMinus_btn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Equal_btn = new System.Windows.Forms.Button();
            this.label_screen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.Window;
            this.display.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.WindowText;
            this.display.Location = new System.Drawing.Point(3, 48);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(354, 67);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 50);
            this.button9.TabIndex = 1;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btn_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(93, 208);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 50);
            this.button10.TabIndex = 1;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btn_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(183, 208);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 50);
            this.button11.TabIndex = 1;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btn_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(273, 208);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 50);
            this.button12.TabIndex = 1;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.operator_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(3, 264);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 50);
            this.button13.TabIndex = 1;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btn_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(93, 264);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 50);
            this.button14.TabIndex = 1;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btn_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(183, 264);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 50);
            this.button15.TabIndex = 1;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btn_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(273, 264);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 50);
            this.button16.TabIndex = 1;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.operator_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(3, 320);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 50);
            this.button17.TabIndex = 1;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btn_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button18.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(93, 320);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 50);
            this.button18.TabIndex = 1;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btn_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button19.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(183, 320);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 50);
            this.button19.TabIndex = 1;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.btn_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(273, 320);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 50);
            this.button20.TabIndex = 1;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.operator_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(3, 131);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(84, 50);
            this.button21.TabIndex = 1;
            this.button21.Text = "C";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // backSpace
            // 
            this.backSpace.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSpace.Location = new System.Drawing.Point(93, 131);
            this.backSpace.Name = "backSpace";
            this.backSpace.Size = new System.Drawing.Size(84, 50);
            this.backSpace.TabIndex = 1;
            this.backSpace.Text = "←";
            this.backSpace.UseVisualStyleBackColor = true;
            this.backSpace.Click += new System.EventHandler(this.backSpace_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(183, 131);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(84, 50);
            this.button23.TabIndex = 1;
            this.button23.Text = "√";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(273, 131);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(84, 50);
            this.button24.TabIndex = 1;
            this.button24.Text = "/";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.operator_Click);
            // 
            // plusMinus_btn
            // 
            this.plusMinus_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinus_btn.Location = new System.Drawing.Point(3, 376);
            this.plusMinus_btn.Name = "plusMinus_btn";
            this.plusMinus_btn.Size = new System.Drawing.Size(84, 50);
            this.plusMinus_btn.TabIndex = 1;
            this.plusMinus_btn.Text = "± ";
            this.plusMinus_btn.UseVisualStyleBackColor = true;
            this.plusMinus_btn.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(93, 376);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 50);
            this.button6.TabIndex = 1;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(183, 376);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 50);
            this.button7.TabIndex = 1;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_Click);
            // 
            // Equal_btn
            // 
            this.Equal_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal_btn.Location = new System.Drawing.Point(273, 376);
            this.Equal_btn.Name = "Equal_btn";
            this.Equal_btn.Size = new System.Drawing.Size(84, 50);
            this.Equal_btn.TabIndex = 1;
            this.Equal_btn.Text = "=";
            this.Equal_btn.UseVisualStyleBackColor = true;
            this.Equal_btn.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label_screen
            // 
            this.label_screen.AutoSize = true;
            this.label_screen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_screen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_screen.Location = new System.Drawing.Point(5, 9);
            this.label_screen.Name = "label_screen";
            this.label_screen.Padding = new System.Windows.Forms.Padding(20, 5, 100, 5);
            this.label_screen.Size = new System.Drawing.Size(120, 31);
            this.label_screen.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 448);
            this.Controls.Add(this.label_screen);
            this.Controls.Add(this.Equal_btn);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.backSpace);
            this.Controls.Add(this.plusMinus_btn);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button backSpace;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button plusMinus_btn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Equal_btn;
        private System.Windows.Forms.Label label_screen;
    }
}

