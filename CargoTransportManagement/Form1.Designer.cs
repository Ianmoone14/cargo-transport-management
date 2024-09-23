namespace CargoTransportManagement
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            TabPage tabPage3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            tabPage3 = new TabPage();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "spisak komitenata.png";
            tabPage3.Location = new Point(4, 40);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1346, 688);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Customer list";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Controls.Add(tabPage7);
            materialTabControl1.Controls.Add(tabPage8);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1354, 732);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.ImageKey = "homepage.png";
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1346, 688);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "unos komitenta.png";
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1346, 688);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer entry";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.ImageKey = "default.png";
            tabPage4.Location = new Point(4, 40);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1346, 688);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Default1";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.ImageKey = "default - Copy.png";
            tabPage5.Location = new Point(4, 40);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1346, 688);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Default2";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.ImageKey = "default - Copy (2).png";
            tabPage6.Location = new Point(4, 40);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1346, 688);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Default3";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.ImageKey = "notification.png";
            tabPage7.Location = new Point(4, 40);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1346, 688);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Notifications";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.ImageKey = "vozila.png";
            tabPage8.Location = new Point(4, 40);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1346, 688);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Vehicles";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "default.png");
            imageList1.Images.SetKeyName(1, "spisak komitenata.png");
            imageList1.Images.SetKeyName(2, "unos komitenta.png");
            imageList1.Images.SetKeyName(3, "vozila.png");
            imageList1.Images.SetKeyName(4, "notification.png");
            imageList1.Images.SetKeyName(5, "homepage.png");
            imageList1.Images.SetKeyName(6, "default - Copy (2).png");
            imageList1.Images.SetKeyName(7, "default - Copy.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1360, 799);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargo Transport Management";
            Load += Form1_Load;
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}
