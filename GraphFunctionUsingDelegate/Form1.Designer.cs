namespace GraphFunctionUsingDelegate
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
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.equationComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Location = new System.Drawing.Point(13, 40);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(259, 209);
            this.graphPictureBox.TabIndex = 1;
            this.graphPictureBox.TabStop = false;
            this.graphPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPictureBox_Paint);
            // 
            // equationComboBox
            // 
            this.equationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationComboBox.FormattingEnabled = true;
            this.equationComboBox.Items.AddRange(new object[] {
            "12 * Sin(3 * x) / (1 + |x|)",
            "|20 * Cos(|x|) / (|x| + 1)|",
            "Ax^6 + Bx^5 + Cx^4 + Dx^3 + Ex^2 + Fx + G"});
            this.equationComboBox.Location = new System.Drawing.Point(13, 12);
            this.equationComboBox.Name = "equationComboBox";
            this.equationComboBox.Size = new System.Drawing.Size(260, 21);
            this.equationComboBox.TabIndex = 7;
            this.equationComboBox.SelectedIndexChanged += new System.EventHandler(this.equationComboBox_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.equationComboBox);
            this.Controls.Add(this.graphPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.ComboBox equationComboBox;
    }
}

