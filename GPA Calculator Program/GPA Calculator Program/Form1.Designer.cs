namespace GPA_Calculator_Program
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.userControl31 = new GPA_Calculator_Program.UserControl3();
            this.userControl11 = new GPA_Calculator_Program.UserControl1();
            this.userControl21 = new GPA_Calculator_Program.UserControl2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 87);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPA Calculator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPA_Calculator_Program.Properties.Resources.grade;
            this.pictureBox1.Location = new System.Drawing.Point(26, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::GPA_Calculator_Program.Properties.Resources.turn_off1;
            this.closeButton.Location = new System.Drawing.Point(932, 25);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gradeBtn);
            this.panel2.Controls.Add(this.predictBtn);
            this.panel2.Controls.Add(this.normalBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 544);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GPA_Calculator_Program.Properties.Resources.calculator_2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 322);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(199, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 544);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // gradeBtn
            // 
            this.gradeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gradeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradeBtn.FlatAppearance.BorderSize = 0;
            this.gradeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.gradeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.gradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradeBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeBtn.ForeColor = System.Drawing.Color.White;
            this.gradeBtn.Image = global::GPA_Calculator_Program.Properties.Resources.microsoft_excel;
            this.gradeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradeBtn.Location = new System.Drawing.Point(0, 63);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(200, 49);
            this.gradeBtn.TabIndex = 0;
            this.gradeBtn.Text = " Grading System";
            this.gradeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gradeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gradeBtn.UseVisualStyleBackColor = false;
            this.gradeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // predictBtn
            // 
            this.predictBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.predictBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.predictBtn.FlatAppearance.BorderSize = 0;
            this.predictBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.predictBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.predictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictBtn.ForeColor = System.Drawing.Color.White;
            this.predictBtn.Image = global::GPA_Calculator_Program.Properties.Resources.two;
            this.predictBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.predictBtn.Location = new System.Drawing.Point(0, 173);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(200, 49);
            this.predictBtn.TabIndex = 0;
            this.predictBtn.Text = " Predict Mode";
            this.predictBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.predictBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.predictBtn.UseVisualStyleBackColor = false;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.normalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.normalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalBtn.FlatAppearance.BorderSize = 0;
            this.normalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.normalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.normalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.normalBtn.Image = global::GPA_Calculator_Program.Properties.Resources.one1;
            this.normalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.normalBtn.Location = new System.Drawing.Point(0, 118);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(200, 49);
            this.normalBtn.TabIndex = 0;
            this.normalBtn.Text = " Normal Mode";
            this.normalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.normalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.normalBtn.UseVisualStyleBackColor = false;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // userControl31
            // 
            this.userControl31.Location = new System.Drawing.Point(199, 87);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(805, 544);
            this.userControl31.TabIndex = 2;
            this.userControl31.Load += new System.EventHandler(this.userControl31_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(199, 87);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(805, 544);
            this.userControl11.TabIndex = 4;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(199, 87);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(805, 544);
            this.userControl21.TabIndex = 3;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gradeBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Button normalBtn;
        private UserControl3 userControl31;
        private UserControl2 userControl21;
        private UserControl1 userControl11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

