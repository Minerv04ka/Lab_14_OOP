namespace Lab_14
{
    partial class fMain
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
			tInfo = new TextBox();
			bAdd = new Button();
			bClose = new Button();
			bClear = new Button();
			SuspendLayout();
			// 
			// tInfo
			// 
			tInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			tInfo.Location = new Point(39, 34);
			tInfo.Multiline = true;
			tInfo.Name = "tInfo";
			tInfo.ReadOnly = true;
			tInfo.Size = new Size(564, 379);
			tInfo.TabIndex = 0;
			// 
			// bAdd
			// 
			bAdd.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			bAdd.Location = new Point(646, 34);
			bAdd.Name = "bAdd";
			bAdd.Size = new Size(120, 47);
			bAdd.TabIndex = 1;
			bAdd.Text = "Add a city";
			bAdd.UseVisualStyleBackColor = true;
			bAdd.Click += bAdd_Click;
			// 
			// bClose
			// 
			bClose.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			bClose.Location = new Point(646, 366);
			bClose.Name = "bClose";
			bClose.Size = new Size(120, 47);
			bClose.TabIndex = 2;
			bClose.Text = "Close";
			bClose.UseVisualStyleBackColor = true;
			bClose.Click += bClose_Click;
			// 
			// bClear
			// 
			bClear.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			bClear.Location = new Point(646, 87);
			bClear.Name = "bClear";
			bClear.Size = new Size(120, 47);
			bClear.TabIndex = 3;
			bClear.Text = "Clear";
			bClear.UseVisualStyleBackColor = true;
			bClear.Click += bClear_Click;
			// 
			// fMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(bClear);
			Controls.Add(bClose);
			Controls.Add(bAdd);
			Controls.Add(tInfo);
			MaximizeBox = false;
			Name = "fMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Lab 14";
			Load += fMain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tInfo;
        private Button bAdd;
        private Button bClose;
        private Button bClear;
    }
}
