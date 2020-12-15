namespace PrototypePattern
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lsKids = new System.Windows.Forms.ListBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lsNewKids = new System.Windows.Forms.ListBox();
            this.btnA = new System.Windows.Forms.Button();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lsKids);
            this.pnlLeft.Location = new System.Drawing.Point(24, 29);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 323);
            this.pnlLeft.TabIndex = 0;
            // 
            // lsKids
            // 
            this.lsKids.FormattingEnabled = true;
            this.lsKids.Location = new System.Drawing.Point(0, 0);
            this.lsKids.Name = "lsKids";
            this.lsKids.Size = new System.Drawing.Size(200, 329);
            this.lsKids.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lsNewKids);
            this.pnlRight.Location = new System.Drawing.Point(340, 29);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(200, 323);
            this.pnlRight.TabIndex = 1;
            // 
            // lsNewKids
            // 
            this.lsNewKids.FormattingEnabled = true;
            this.lsNewKids.Location = new System.Drawing.Point(3, 0);
            this.lsNewKids.Name = "lsNewKids";
            this.lsNewKids.Size = new System.Drawing.Size(194, 329);
            this.lsNewKids.TabIndex = 0;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(246, 96);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "->";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Location = new System.Drawing.Point(18, 29);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(31, 17);
            this.radioFem.TabIndex = 4;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "F";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(18, 52);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(34, 17);
            this.radioMasc.TabIndex = 5;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "M";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioMasc);
            this.groupBox.Controls.Add(this.radioFem);
            this.groupBox.Location = new System.Drawing.Point(243, 125);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(91, 75);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ListBox lsKids;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.ListBox lsNewKids;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

