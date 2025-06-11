namespace destinygoalplanner
{
    partial class mainScreenForm
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
            accountLoginbtn = new Button();
            welcomeBannerlbl = new Label();
            SuspendLayout();
            // 
            // accountLoginbtn
            // 
            accountLoginbtn.BackColor = Color.Transparent;
            accountLoginbtn.BackgroundImage = Properties.Resources.d2Login;
            accountLoginbtn.BackgroundImageLayout = ImageLayout.Stretch;
            accountLoginbtn.Location = new Point(293, 184);
            accountLoginbtn.Name = "accountLoginbtn";
            accountLoginbtn.Size = new Size(226, 122);
            accountLoginbtn.TabIndex = 0;
            accountLoginbtn.TextAlign = ContentAlignment.BottomCenter;
            accountLoginbtn.UseVisualStyleBackColor = false;
            accountLoginbtn.Click += accountLoginbtn_Click;
            // 
            // welcomeBannerlbl
            // 
            welcomeBannerlbl.AutoSize = true;
            welcomeBannerlbl.BackColor = Color.Transparent;
            welcomeBannerlbl.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeBannerlbl.ForeColor = Color.Black;
            welcomeBannerlbl.Location = new Point(133, 45);
            welcomeBannerlbl.Name = "welcomeBannerlbl";
            welcomeBannerlbl.Size = new Size(579, 118);
            welcomeBannerlbl.TabIndex = 1;
            welcomeBannerlbl.Text = "Welcome to Sparrow's \r\nDestiny Goal Planner!";
            welcomeBannerlbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // mainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.destinyMainScreenGUIimage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(welcomeBannerlbl);
            Controls.Add(accountLoginbtn);
            Name = "mainScreenForm";
            Text = "Path to Pinnacle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button accountLoginbtn;
        private Label welcomeBannerlbl;
    }
}
