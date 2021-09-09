
namespace Week7.EquazioniGrado2.WinForm
{
    partial class CalculatorFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.FirstValue = new System.Windows.Forms.Label();
            this.SecondValue = new System.Windows.Forms.Label();
            this.ThirdValue = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.uguale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(64, 60);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(119, 39);
            this.txtValue1.TabIndex = 0;

            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(228, 60);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(118, 39);
            this.txtValue2.TabIndex = 1;

            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(382, 60);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(119, 39);
            this.txtValue3.TabIndex = 2;

            // 
            // FirstValue
            // 
            this.FirstValue.AutoSize = true;
            this.FirstValue.Location = new System.Drawing.Point(68, 9);
            this.FirstValue.Name = "FirstValue";
            this.FirstValue.Size = new System.Drawing.Size(103, 32);
            this.FirstValue.TabIndex = 3;
            this.FirstValue.Text = "Value x2";
            // 
            // SecondValue
            // 
            this.SecondValue.AutoSize = true;
            this.SecondValue.Location = new System.Drawing.Point(242, 9);
            this.SecondValue.Name = "SecondValue";
            this.SecondValue.Size = new System.Drawing.Size(90, 32);
            this.SecondValue.TabIndex = 4;
            this.SecondValue.Text = "Value x";
            // 
            // ThirdValue
            // 
            this.ThirdValue.AutoSize = true;
            this.ThirdValue.Location = new System.Drawing.Point(391, 9);
            this.ThirdValue.Name = "ThirdValue";
            this.ThirdValue.Size = new System.Drawing.Size(90, 32);
            this.ThirdValue.TabIndex = 5;
            this.ThirdValue.Text = "Value c";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(254, 241);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(78, 32);
            this.Result.TabIndex = 6;
            this.Result.Text = "Result";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(77, 286);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(424, 39);
            this.txtValue.TabIndex = 7;
            // 
            // uguale
            // 
            this.uguale.Location = new System.Drawing.Point(254, 148);
            this.uguale.Name = "uguale";
            this.uguale.Size = new System.Drawing.Size(92, 43);
            this.uguale.TabIndex = 19;
            this.uguale.Tag = "uguale";
            this.uguale.Text = "=";
            this.uguale.UseVisualStyleBackColor = true;
            this.uguale.Click += new System.EventHandler(this.uguale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "= 0";
            // 
            // CalculatorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uguale);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ThirdValue);
            this.Controls.Add(this.SecondValue);
            this.Controls.Add(this.FirstValue);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Name = "CalculatorFrom";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.Label FirstValue;
        private System.Windows.Forms.Label SecondValue;
        private System.Windows.Forms.Label ThirdValue;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button uguale;
        private System.Windows.Forms.Label label1;
    }
}

