namespace Lab_14
{
    partial class fCity
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
            groupBox1 = new GroupBox();
            tbArea = new TextBox();
            tbIncome = new TextBox();
            tbPopulation = new TextBox();
            tbRegion = new TextBox();
            tbCountry = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbHasAirport = new CheckBox();
            cbHasPort = new CheckBox();
            bOk = new Button();
            bCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbIncome);
            groupBox1.Controls.Add(tbPopulation);
            groupBox1.Controls.Add(tbRegion);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 252);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Info";
            // 
            // tbArea
            // 
            tbArea.Location = new Point(241, 208);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(215, 23);
            tbArea.TabIndex = 11;
            // 
            // tbIncome
            // 
            tbIncome.Location = new Point(241, 174);
            tbIncome.Name = "tbIncome";
            tbIncome.Size = new Size(215, 23);
            tbIncome.TabIndex = 10;
            // 
            // tbPopulation
            // 
            tbPopulation.Location = new Point(241, 138);
            tbPopulation.Name = "tbPopulation";
            tbPopulation.Size = new Size(215, 23);
            tbPopulation.TabIndex = 9;
            // 
            // tbRegion
            // 
            tbRegion.Location = new Point(241, 105);
            tbRegion.Name = "tbRegion";
            tbRegion.Size = new Size(215, 23);
            tbRegion.TabIndex = 8;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(241, 71);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(215, 23);
            tbCountry.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(241, 36);
            tbName.Name = "tbName";
            tbName.Size = new Size(215, 23);
            tbName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 211);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 177);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Annual income";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 141);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 108);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Region";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbHasAirport);
            groupBox2.Controls.Add(cbHasPort);
            groupBox2.Location = new Point(35, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 104);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transport";
            // 
            // cbHasAirport
            // 
            cbHasAirport.AutoSize = true;
            cbHasAirport.Location = new Point(35, 70);
            cbHasAirport.Name = "cbHasAirport";
            cbHasAirport.Size = new Size(106, 19);
            cbHasAirport.TabIndex = 1;
            cbHasAirport.Text = "City has airport";
            cbHasAirport.UseVisualStyleBackColor = true;
            // 
            // cbHasPort
            // 
            cbHasPort.AutoSize = true;
            cbHasPort.Location = new Point(35, 35);
            cbHasPort.Name = "cbHasPort";
            cbHasPort.Size = new Size(93, 19);
            cbHasPort.TabIndex = 0;
            cbHasPort.Text = "City has port";
            cbHasPort.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            bOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bOk.ForeColor = SystemColors.ControlText;
            bOk.Location = new Point(556, 31);
            bOk.Name = "bOk";
            bOk.Size = new Size(109, 33);
            bOk.TabIndex = 2;
            bOk.Text = "Ok";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // bCancel
            // 
            bCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bCancel.ForeColor = SystemColors.ControlText;
            bCancel.Location = new Point(556, 70);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(109, 33);
            bCancel.TabIndex = 3;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // fCity
            // 
            AcceptButton = bOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bCancel;
            ClientSize = new Size(699, 450);
            Controls.Add(bCancel);
            Controls.Add(bOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "fCity";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New city info";
            Load += fCity_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbArea;
        private TextBox tbIncome;
        private TextBox tbPopulation;
        private TextBox tbRegion;
        private TextBox tbCountry;
        private TextBox tbName;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private CheckBox cbHasAirport;
        private CheckBox cbHasPort;
        private Button bOk;
        private Button bCancel;
    }
}