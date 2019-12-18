namespace KSU.CIS300.Math.Expressions
{
    partial class UserInterface
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
            this.uxExpression = new System.Windows.Forms.TextBox();
            this.uxExpressionLbl = new System.Windows.Forms.Label();
            this.uxInfixExpression = new System.Windows.Forms.TextBox();
            this.uxInfixLbl = new System.Windows.Forms.Label();
            this.uxPostfixLbl = new System.Windows.Forms.Label();
            this.uxPrefixLbl = new System.Windows.Forms.Label();
            this.uxPostfixExpression = new System.Windows.Forms.TextBox();
            this.uxPrefixExpression = new System.Windows.Forms.TextBox();
            this.uxVarAVal = new System.Windows.Forms.TextBox();
            this.uxVarBVal = new System.Windows.Forms.TextBox();
            this.uxVarCVal = new System.Windows.Forms.TextBox();
            this.uxALbl = new System.Windows.Forms.Label();
            this.uxBLbl = new System.Windows.Forms.Label();
            this.uxCLbl = new System.Windows.Forms.Label();
            this.uxVarsLbl = new System.Windows.Forms.Label();
            this.uxValuesLbl = new System.Windows.Forms.Label();
            this.uxInfixResult = new System.Windows.Forms.TextBox();
            this.uxPostfixResult = new System.Windows.Forms.TextBox();
            this.uxPrefixResult = new System.Windows.Forms.TextBox();
            this.uxResultLbl = new System.Windows.Forms.Label();
            this.uxCreateTree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uxEvaluate = new System.Windows.Forms.Button();
            this.uxInfixSelection = new System.Windows.Forms.RadioButton();
            this.uxPostfixSelection = new System.Windows.Forms.RadioButton();
            this.uxPrefixSelection = new System.Windows.Forms.RadioButton();
            this.uxExpFixFormat = new System.Windows.Forms.GroupBox();
            this.uxExpFixFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxExpression
            // 
            this.uxExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExpression.Location = new System.Drawing.Point(62, 147);
            this.uxExpression.Name = "uxExpression";
            this.uxExpression.Size = new System.Drawing.Size(288, 35);
            this.uxExpression.TabIndex = 0;
            // 
            // uxExpressionLbl
            // 
            this.uxExpressionLbl.AutoSize = true;
            this.uxExpressionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExpressionLbl.Location = new System.Drawing.Point(55, 96);
            this.uxExpressionLbl.Name = "uxExpressionLbl";
            this.uxExpressionLbl.Size = new System.Drawing.Size(184, 37);
            this.uxExpressionLbl.TabIndex = 10;
            this.uxExpressionLbl.Text = "Expression";
            // 
            // uxInfixExpression
            // 
            this.uxInfixExpression.Enabled = false;
            this.uxInfixExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfixExpression.Location = new System.Drawing.Point(198, 342);
            this.uxInfixExpression.Name = "uxInfixExpression";
            this.uxInfixExpression.Size = new System.Drawing.Size(288, 35);
            this.uxInfixExpression.TabIndex = 11;
            // 
            // uxInfixLbl
            // 
            this.uxInfixLbl.AutoSize = true;
            this.uxInfixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfixLbl.Location = new System.Drawing.Point(95, 342);
            this.uxInfixLbl.Name = "uxInfixLbl";
            this.uxInfixLbl.Size = new System.Drawing.Size(79, 37);
            this.uxInfixLbl.TabIndex = 12;
            this.uxInfixLbl.Text = "Infix";
            // 
            // uxPostfixLbl
            // 
            this.uxPostfixLbl.AutoSize = true;
            this.uxPostfixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPostfixLbl.Location = new System.Drawing.Point(55, 392);
            this.uxPostfixLbl.Name = "uxPostfixLbl";
            this.uxPostfixLbl.Size = new System.Drawing.Size(119, 37);
            this.uxPostfixLbl.TabIndex = 13;
            this.uxPostfixLbl.Text = "Postfix";
            // 
            // uxPrefixLbl
            // 
            this.uxPrefixLbl.AutoSize = true;
            this.uxPrefixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrefixLbl.Location = new System.Drawing.Point(67, 444);
            this.uxPrefixLbl.Name = "uxPrefixLbl";
            this.uxPrefixLbl.Size = new System.Drawing.Size(103, 37);
            this.uxPrefixLbl.TabIndex = 14;
            this.uxPrefixLbl.Text = "Prefix";
            // 
            // uxPostfixExpression
            // 
            this.uxPostfixExpression.Enabled = false;
            this.uxPostfixExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPostfixExpression.Location = new System.Drawing.Point(198, 392);
            this.uxPostfixExpression.Name = "uxPostfixExpression";
            this.uxPostfixExpression.Size = new System.Drawing.Size(288, 35);
            this.uxPostfixExpression.TabIndex = 15;
            // 
            // uxPrefixExpression
            // 
            this.uxPrefixExpression.Enabled = false;
            this.uxPrefixExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrefixExpression.Location = new System.Drawing.Point(198, 444);
            this.uxPrefixExpression.Name = "uxPrefixExpression";
            this.uxPrefixExpression.Size = new System.Drawing.Size(288, 35);
            this.uxPrefixExpression.TabIndex = 16;
            // 
            // uxVarAVal
            // 
            this.uxVarAVal.Enabled = false;
            this.uxVarAVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxVarAVal.Location = new System.Drawing.Point(198, 563);
            this.uxVarAVal.Name = "uxVarAVal";
            this.uxVarAVal.Size = new System.Drawing.Size(70, 35);
            this.uxVarAVal.TabIndex = 17;
            // 
            // uxVarBVal
            // 
            this.uxVarBVal.Enabled = false;
            this.uxVarBVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxVarBVal.Location = new System.Drawing.Point(309, 563);
            this.uxVarBVal.Name = "uxVarBVal";
            this.uxVarBVal.Size = new System.Drawing.Size(70, 35);
            this.uxVarBVal.TabIndex = 18;
            // 
            // uxVarCVal
            // 
            this.uxVarCVal.Enabled = false;
            this.uxVarCVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxVarCVal.Location = new System.Drawing.Point(416, 563);
            this.uxVarCVal.Name = "uxVarCVal";
            this.uxVarCVal.Size = new System.Drawing.Size(70, 35);
            this.uxVarCVal.TabIndex = 19;
            // 
            // uxALbl
            // 
            this.uxALbl.AutoSize = true;
            this.uxALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxALbl.Location = new System.Drawing.Point(215, 523);
            this.uxALbl.Name = "uxALbl";
            this.uxALbl.Size = new System.Drawing.Size(40, 37);
            this.uxALbl.TabIndex = 20;
            this.uxALbl.Text = "A";
            // 
            // uxBLbl
            // 
            this.uxBLbl.AutoSize = true;
            this.uxBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBLbl.Location = new System.Drawing.Point(326, 523);
            this.uxBLbl.Name = "uxBLbl";
            this.uxBLbl.Size = new System.Drawing.Size(39, 37);
            this.uxBLbl.TabIndex = 21;
            this.uxBLbl.Text = "B";
            // 
            // uxCLbl
            // 
            this.uxCLbl.AutoSize = true;
            this.uxCLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCLbl.Location = new System.Drawing.Point(435, 523);
            this.uxCLbl.Name = "uxCLbl";
            this.uxCLbl.Size = new System.Drawing.Size(41, 37);
            this.uxCLbl.TabIndex = 22;
            this.uxCLbl.Text = "C";
            // 
            // uxVarsLbl
            // 
            this.uxVarsLbl.AutoSize = true;
            this.uxVarsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxVarsLbl.Location = new System.Drawing.Point(91, 523);
            this.uxVarsLbl.Name = "uxVarsLbl";
            this.uxVarsLbl.Size = new System.Drawing.Size(88, 37);
            this.uxVarsLbl.TabIndex = 23;
            this.uxVarsLbl.Text = "Vars";
            // 
            // uxValuesLbl
            // 
            this.uxValuesLbl.AutoSize = true;
            this.uxValuesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxValuesLbl.Location = new System.Drawing.Point(82, 566);
            this.uxValuesLbl.Name = "uxValuesLbl";
            this.uxValuesLbl.Size = new System.Drawing.Size(92, 29);
            this.uxValuesLbl.TabIndex = 24;
            this.uxValuesLbl.Text = "Values";
            // 
            // uxInfixResult
            // 
            this.uxInfixResult.Enabled = false;
            this.uxInfixResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfixResult.Location = new System.Drawing.Point(546, 342);
            this.uxInfixResult.Name = "uxInfixResult";
            this.uxInfixResult.Size = new System.Drawing.Size(149, 35);
            this.uxInfixResult.TabIndex = 25;
            // 
            // uxPostfixResult
            // 
            this.uxPostfixResult.Enabled = false;
            this.uxPostfixResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPostfixResult.Location = new System.Drawing.Point(546, 392);
            this.uxPostfixResult.Name = "uxPostfixResult";
            this.uxPostfixResult.Size = new System.Drawing.Size(149, 35);
            this.uxPostfixResult.TabIndex = 26;
            // 
            // uxPrefixResult
            // 
            this.uxPrefixResult.Enabled = false;
            this.uxPrefixResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrefixResult.Location = new System.Drawing.Point(546, 447);
            this.uxPrefixResult.Name = "uxPrefixResult";
            this.uxPrefixResult.Size = new System.Drawing.Size(149, 35);
            this.uxPrefixResult.TabIndex = 27;
            // 
            // uxResultLbl
            // 
            this.uxResultLbl.AutoSize = true;
            this.uxResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxResultLbl.Location = new System.Drawing.Point(583, 290);
            this.uxResultLbl.Name = "uxResultLbl";
            this.uxResultLbl.Size = new System.Drawing.Size(112, 37);
            this.uxResultLbl.TabIndex = 28;
            this.uxResultLbl.Text = "Result";
            // 
            // uxCreateTree
            // 
            this.uxCreateTree.Enabled = false;
            this.uxCreateTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateTree.Location = new System.Drawing.Point(546, 187);
            this.uxCreateTree.Name = "uxCreateTree";
            this.uxCreateTree.Size = new System.Drawing.Size(149, 55);
            this.uxCreateTree.TabIndex = 29;
            this.uxCreateTree.Text = "Create";
            this.uxCreateTree.UseVisualStyleBackColor = true;
            this.uxCreateTree.Click += new System.EventHandler(this.UxCreateTree_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(546, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 59);
            this.button1.TabIndex = 30;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.uxValidateExp_Click);
            // 
            // uxEvaluate
            // 
            this.uxEvaluate.Enabled = false;
            this.uxEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEvaluate.Location = new System.Drawing.Point(546, 540);
            this.uxEvaluate.Name = "uxEvaluate";
            this.uxEvaluate.Size = new System.Drawing.Size(149, 55);
            this.uxEvaluate.TabIndex = 31;
            this.uxEvaluate.Text = "Evaluate";
            this.uxEvaluate.UseVisualStyleBackColor = true;
            this.uxEvaluate.Click += new System.EventHandler(this.UxEvaluate_Click);
            // 
            // uxInfixSelection
            // 
            this.uxInfixSelection.AutoSize = true;
            this.uxInfixSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfixSelection.Location = new System.Drawing.Point(13, 30);
            this.uxInfixSelection.Name = "uxInfixSelection";
            this.uxInfixSelection.Size = new System.Drawing.Size(72, 29);
            this.uxInfixSelection.TabIndex = 32;
            this.uxInfixSelection.TabStop = true;
            this.uxInfixSelection.Text = "Infix";
            this.uxInfixSelection.UseVisualStyleBackColor = true;
            // 
            // uxPostfixSelection
            // 
            this.uxPostfixSelection.AutoSize = true;
            this.uxPostfixSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPostfixSelection.Location = new System.Drawing.Point(13, 65);
            this.uxPostfixSelection.Name = "uxPostfixSelection";
            this.uxPostfixSelection.Size = new System.Drawing.Size(95, 29);
            this.uxPostfixSelection.TabIndex = 33;
            this.uxPostfixSelection.TabStop = true;
            this.uxPostfixSelection.Text = "Postfix";
            this.uxPostfixSelection.UseVisualStyleBackColor = true;
            // 
            // uxPrefixSelection
            // 
            this.uxPrefixSelection.AutoSize = true;
            this.uxPrefixSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPrefixSelection.Location = new System.Drawing.Point(13, 105);
            this.uxPrefixSelection.Name = "uxPrefixSelection";
            this.uxPrefixSelection.Size = new System.Drawing.Size(86, 29);
            this.uxPrefixSelection.TabIndex = 34;
            this.uxPrefixSelection.TabStop = true;
            this.uxPrefixSelection.Text = "Prefix";
            this.uxPrefixSelection.UseVisualStyleBackColor = true;
            // 
            // uxExpFixFormat
            // 
            this.uxExpFixFormat.Controls.Add(this.uxInfixSelection);
            this.uxExpFixFormat.Controls.Add(this.uxPrefixSelection);
            this.uxExpFixFormat.Controls.Add(this.uxPostfixSelection);
            this.uxExpFixFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExpFixFormat.Location = new System.Drawing.Point(383, 96);
            this.uxExpFixFormat.Name = "uxExpFixFormat";
            this.uxExpFixFormat.Size = new System.Drawing.Size(136, 146);
            this.uxExpFixFormat.TabIndex = 35;
            this.uxExpFixFormat.TabStop = false;
            this.uxExpFixFormat.Text = "Fix Format";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 725);
            this.Controls.Add(this.uxExpFixFormat);
            this.Controls.Add(this.uxEvaluate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxCreateTree);
            this.Controls.Add(this.uxResultLbl);
            this.Controls.Add(this.uxPrefixResult);
            this.Controls.Add(this.uxPostfixResult);
            this.Controls.Add(this.uxInfixResult);
            this.Controls.Add(this.uxValuesLbl);
            this.Controls.Add(this.uxVarsLbl);
            this.Controls.Add(this.uxCLbl);
            this.Controls.Add(this.uxBLbl);
            this.Controls.Add(this.uxALbl);
            this.Controls.Add(this.uxVarCVal);
            this.Controls.Add(this.uxVarBVal);
            this.Controls.Add(this.uxVarAVal);
            this.Controls.Add(this.uxPrefixExpression);
            this.Controls.Add(this.uxPostfixExpression);
            this.Controls.Add(this.uxPrefixLbl);
            this.Controls.Add(this.uxPostfixLbl);
            this.Controls.Add(this.uxInfixLbl);
            this.Controls.Add(this.uxInfixExpression);
            this.Controls.Add(this.uxExpressionLbl);
            this.Controls.Add(this.uxExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Math Expressions";
            this.uxExpFixFormat.ResumeLayout(false);
            this.uxExpFixFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxExpression;
        private System.Windows.Forms.Label uxExpressionLbl;
        private System.Windows.Forms.TextBox uxInfixExpression;
        private System.Windows.Forms.Label uxInfixLbl;
        private System.Windows.Forms.Label uxPostfixLbl;
        private System.Windows.Forms.Label uxPrefixLbl;
        private System.Windows.Forms.TextBox uxPostfixExpression;
        private System.Windows.Forms.TextBox uxPrefixExpression;
        private System.Windows.Forms.TextBox uxVarAVal;
        private System.Windows.Forms.TextBox uxVarBVal;
        private System.Windows.Forms.TextBox uxVarCVal;
        private System.Windows.Forms.Label uxALbl;
        private System.Windows.Forms.Label uxBLbl;
        private System.Windows.Forms.Label uxCLbl;
        private System.Windows.Forms.Label uxVarsLbl;
        private System.Windows.Forms.Label uxValuesLbl;
        private System.Windows.Forms.TextBox uxInfixResult;
        private System.Windows.Forms.TextBox uxPostfixResult;
        private System.Windows.Forms.TextBox uxPrefixResult;
        private System.Windows.Forms.Label uxResultLbl;
        private System.Windows.Forms.Button uxCreateTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uxEvaluate;
        private System.Windows.Forms.RadioButton uxInfixSelection;
        private System.Windows.Forms.RadioButton uxPostfixSelection;
        private System.Windows.Forms.RadioButton uxPrefixSelection;
        private System.Windows.Forms.GroupBox uxExpFixFormat;
    }
}

