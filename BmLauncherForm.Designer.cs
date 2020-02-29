namespace BmLauncherWForm
{
    partial class BmLauncherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BmLauncherForm));
            this.msaaLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.vsyncLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.fscreenLabel = new System.Windows.Forms.Label();
            this.vsyncBox = new System.Windows.Forms.ComboBox();
            this.detailBox = new System.Windows.Forms.ComboBox();
            this.fullscreenBox = new System.Windows.Forms.ComboBox();
            this.resBox = new System.Windows.Forms.ComboBox();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.langLabel = new System.Windows.Forms.Label();
            this.maxSmoothTextBox = new System.Windows.Forms.MaskedTextBox();
            this.smoothFrameLabel = new System.Windows.Forms.Label();
            this.aaBox = new System.Windows.Forms.ComboBox();
            this.dofLabel = new System.Windows.Forms.Label();
            this.dofBox = new System.Windows.Forms.ComboBox();
            this.aoLabel = new System.Windows.Forms.Label();
            this.aoBox = new System.Windows.Forms.ComboBox();
            this.lensFlareLabel = new System.Windows.Forms.Label();
            this.lensFlareBox = new System.Windows.Forms.ComboBox();
            this.bloomLabel = new System.Windows.Forms.Label();
            this.bloomBox = new System.Windows.Forms.ComboBox();
            this.anisoLabel = new System.Windows.Forms.Label();
            this.anisoBox = new System.Windows.Forms.ComboBox();
            this.dshadowLabel = new System.Windows.Forms.Label();
            this.dShadowBox = new System.Windows.Forms.ComboBox();
            this.maxShadowLabel = new System.Windows.Forms.Label();
            this.maxShadowBox = new System.Windows.Forms.ComboBox();
            this.graphicsBox = new System.Windows.Forms.GroupBox();
            this.miscBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fov2 = new System.Windows.Forms.Label();
            this.fov1 = new System.Windows.Forms.Label();
            this.mBlurBox = new System.Windows.Forms.ComboBox();
            this.mBlurLabel = new System.Windows.Forms.Label();
            this.distBox = new System.Windows.Forms.ComboBox();
            this.distLabel = new System.Windows.Forms.Label();
            this.fogBox = new System.Windows.Forms.ComboBox();
            this.fogLabel = new System.Windows.Forms.Label();
            this.sphericBox = new System.Windows.Forms.ComboBox();
            this.sphericalLabel = new System.Windows.Forms.Label();
            this.memPoolBox = new System.Windows.Forms.ComboBox();
            this.memPoolLabel = new System.Windows.Forms.Label();
            this.texelBox = new System.Windows.Forms.ComboBox();
            this.shadowTexelLabel = new System.Windows.Forms.Label();
            this.nvidiaBox = new System.Windows.Forms.GroupBox();
            this.nvBox = new System.Windows.Forms.CheckBox();
            this.physxBox = new System.Windows.Forms.ComboBox();
            this.physxLabel = new System.Windows.Forms.Label();
            this.keyButton = new System.Windows.Forms.Button();
            this.ultraButton = new System.Windows.Forms.Button();
            this.optiButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.texgroupButton = new System.Windows.Forms.Button();
            this.gpLabel = new System.Windows.Forms.Label();
            this.gpInfoLabel = new System.Windows.Forms.Label();
            this.credLabel = new System.Windows.Forms.LinkLabel();
            this.launchButton = new System.Windows.Forms.Button();
            this.basicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.disableIntroButton = new System.Windows.Forms.Button();
            this.nvidiaToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.amdToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.displayBox.SuspendLayout();
            this.graphicsBox.SuspendLayout();
            this.miscBox.SuspendLayout();
            this.nvidiaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // msaaLabel
            // 
            this.msaaLabel.AutoSize = true;
            this.msaaLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msaaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msaaLabel.Location = new System.Drawing.Point(13, 22);
            this.msaaLabel.Name = "msaaLabel";
            this.msaaLabel.Size = new System.Drawing.Size(79, 15);
            this.msaaLabel.TabIndex = 11;
            this.msaaLabel.Text = "Anti-Aliasing:";
            this.basicToolTip.SetToolTip(this.msaaLabel, "Cleans up edge aliasing using MSAA. Off is recommended if you are using Reshade -" +
        " Reshade SMAA and/or downsampling is recommended.\r\n");
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(6, 49);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(69, 15);
            this.resLabel.TabIndex = 0;
            this.resLabel.Text = "Resolution:";
            this.basicToolTip.SetToolTip(this.resLabel, "Every resolution available on your machine is supported.");
            // 
            // vsyncLabel
            // 
            this.vsyncLabel.AutoSize = true;
            this.vsyncLabel.Location = new System.Drawing.Point(285, 22);
            this.vsyncLabel.Name = "vsyncLabel";
            this.vsyncLabel.Size = new System.Drawing.Size(79, 15);
            this.vsyncLabel.TabIndex = 1;
            this.vsyncLabel.Text = "Vertical Sync:";
            this.basicToolTip.SetToolTip(this.vsyncLabel, "Turn on to eliminate screen tearing.");
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Location = new System.Drawing.Point(286, 49);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(78, 15);
            this.detailLabel.TabIndex = 3;
            this.detailLabel.Text = "Detail Mode:";
            this.basicToolTip.SetToolTip(this.detailLabel, "Highest setting is required for GPUnitys Texturepack.");
            // 
            // fscreenLabel
            // 
            this.fscreenLabel.AutoSize = true;
            this.fscreenLabel.Location = new System.Drawing.Point(6, 22);
            this.fscreenLabel.Name = "fscreenLabel";
            this.fscreenLabel.Size = new System.Drawing.Size(66, 15);
            this.fscreenLabel.TabIndex = 4;
            this.fscreenLabel.Text = "Fullscreen:";
            this.basicToolTip.SetToolTip(this.fscreenLabel, "You can press \"scroll lock\" in game to switch between fullscreen and windowed mod" +
        "e. ");
            // 
            // vsyncBox
            // 
            this.vsyncBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vsyncBox.FormattingEnabled = true;
            this.vsyncBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.vsyncBox.Location = new System.Drawing.Point(369, 19);
            this.vsyncBox.Name = "vsyncBox";
            this.vsyncBox.Size = new System.Drawing.Size(110, 23);
            this.vsyncBox.TabIndex = 5;
            this.vsyncBox.TabStop = false;
            this.vsyncBox.SelectedIndexChanged += new System.EventHandler(this.vsyncBox_SelectedIndexChanged);
            // 
            // detailBox
            // 
            this.detailBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.detailBox.FormattingEnabled = true;
            this.detailBox.Items.AddRange(new object[] {
            "Lowest",
            "Medium",
            "Highest"});
            this.detailBox.Location = new System.Drawing.Point(369, 46);
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(110, 23);
            this.detailBox.TabIndex = 6;
            this.basicToolTip.SetToolTip(this.detailBox, "Highest setting is required for GPUnity\'s Texture Pack.");
            this.detailBox.SelectedIndexChanged += new System.EventHandler(this.detailBox_SelectedIndexChanged);
            // 
            // fullscreenBox
            // 
            this.fullscreenBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullscreenBox.FormattingEnabled = true;
            this.fullscreenBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.fullscreenBox.Location = new System.Drawing.Point(95, 19);
            this.fullscreenBox.Name = "fullscreenBox";
            this.fullscreenBox.Size = new System.Drawing.Size(110, 23);
            this.fullscreenBox.TabIndex = 7;
            this.fullscreenBox.SelectedIndexChanged += new System.EventHandler(this.fullscreenBox_SelectedIndexChanged);
            // 
            // resBox
            // 
            this.resBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resBox.FormattingEnabled = true;
            this.resBox.Location = new System.Drawing.Point(95, 46);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(110, 23);
            this.resBox.TabIndex = 8;
            this.resBox.SelectedIndexChanged += new System.EventHandler(this.resBox_SelectedIndexChanged);
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.Transparent;
            this.displayBox.Controls.Add(this.langBox);
            this.displayBox.Controls.Add(this.langLabel);
            this.displayBox.Controls.Add(this.resBox);
            this.displayBox.Controls.Add(this.fullscreenBox);
            this.displayBox.Controls.Add(this.maxSmoothTextBox);
            this.displayBox.Controls.Add(this.detailBox);
            this.displayBox.Controls.Add(this.smoothFrameLabel);
            this.displayBox.Controls.Add(this.vsyncBox);
            this.displayBox.Controls.Add(this.fscreenLabel);
            this.displayBox.Controls.Add(this.detailLabel);
            this.displayBox.Controls.Add(this.vsyncLabel);
            this.displayBox.Controls.Add(this.resLabel);
            this.displayBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayBox.Location = new System.Drawing.Point(19, 16);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(489, 103);
            this.displayBox.TabIndex = 12;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Display";
            // 
            // langBox
            // 
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "English",
            "Deutsch",
            "Français",
            "Italiano",
            "Español"});
            this.langBox.Location = new System.Drawing.Point(369, 73);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(110, 23);
            this.langBox.TabIndex = 37;
            this.basicToolTip.SetToolTip(this.langBox, "Highest setting is required for GPUnity\'s Texture Pack.");
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(302, 76);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(62, 15);
            this.langLabel.TabIndex = 36;
            this.langLabel.Text = "Language:";
            this.basicToolTip.SetToolTip(this.langLabel, "Sets the voice & text language in the game.\r\n");
            // 
            // maxSmoothTextBox
            // 
            this.maxSmoothTextBox.Location = new System.Drawing.Point(163, 72);
            this.maxSmoothTextBox.Mask = "000";
            this.maxSmoothTextBox.Name = "maxSmoothTextBox";
            this.maxSmoothTextBox.PromptChar = ' ';
            this.maxSmoothTextBox.Size = new System.Drawing.Size(42, 23);
            this.maxSmoothTextBox.TabIndex = 35;
            this.maxSmoothTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxSmoothTextBox.TextChanged += new System.EventHandler(this.maxSmoothTextBox_TextChanged);
            // 
            // smoothFrameLabel
            // 
            this.smoothFrameLabel.AutoSize = true;
            this.smoothFrameLabel.Location = new System.Drawing.Point(6, 76);
            this.smoothFrameLabel.Name = "smoothFrameLabel";
            this.smoothFrameLabel.Size = new System.Drawing.Size(158, 15);
            this.smoothFrameLabel.TabIndex = 34;
            this.smoothFrameLabel.Text = "Max. Smoothed Framerate:";
            this.basicToolTip.SetToolTip(this.smoothFrameLabel, resources.GetString("smoothFrameLabel.ToolTip"));
            // 
            // aaBox
            // 
            this.aaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aaBox.FormattingEnabled = true;
            this.aaBox.Items.AddRange(new object[] {
            "Off",
            "2x MSAA",
            "4x MSAA",
            "8xQ MSAA"});
            this.aaBox.Location = new System.Drawing.Point(95, 19);
            this.aaBox.Name = "aaBox";
            this.aaBox.Size = new System.Drawing.Size(110, 23);
            this.aaBox.TabIndex = 13;
            this.aaBox.SelectedIndexChanged += new System.EventHandler(this.aaBox_SelectedIndexChanged);
            // 
            // dofLabel
            // 
            this.dofLabel.AutoSize = true;
            this.dofLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dofLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dofLabel.Location = new System.Drawing.Point(4, 138);
            this.dofLabel.Name = "dofLabel";
            this.dofLabel.Size = new System.Drawing.Size(88, 15);
            this.dofLabel.TabIndex = 14;
            this.dofLabel.Text = "Depth of Field:";
            this.basicToolTip.SetToolTip(this.dofLabel, "Tied with Colour Grading filters and Bloom. Off is recommended for GPUnity\'s Resh" +
        "ade.\r\n");
            // 
            // dofBox
            // 
            this.dofBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dofBox.FormattingEnabled = true;
            this.dofBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.dofBox.Location = new System.Drawing.Point(95, 135);
            this.dofBox.Name = "dofBox";
            this.dofBox.Size = new System.Drawing.Size(110, 23);
            this.dofBox.TabIndex = 15;
            this.basicToolTip.SetToolTip(this.dofBox, "Tied with Colour Grading filters and Bloom. Turn off to improve colour accuracy.");
            this.dofBox.SelectedIndexChanged += new System.EventHandler(this.dofBox_SelectedIndexChanged);
            // 
            // aoLabel
            // 
            this.aoLabel.AutoSize = true;
            this.aoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aoLabel.Location = new System.Drawing.Point(253, 80);
            this.aoLabel.Name = "aoLabel";
            this.aoLabel.Size = new System.Drawing.Size(113, 15);
            this.aoLabel.TabIndex = 16;
            this.aoLabel.Text = "Ambient Occlusion:";
            this.basicToolTip.SetToolTip(this.aoLabel, "Off is recommended due to low sample count. Use Reshade AO or enable NVIDIA HBAO+" +
        ".\r\n");
            // 
            // aoBox
            // 
            this.aoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aoBox.FormattingEnabled = true;
            this.aoBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.aoBox.Location = new System.Drawing.Point(369, 77);
            this.aoBox.Name = "aoBox";
            this.aoBox.Size = new System.Drawing.Size(110, 23);
            this.aoBox.TabIndex = 17;
            this.aoBox.SelectedIndexChanged += new System.EventHandler(this.aoBox_SelectedIndexChanged);
            // 
            // lensFlareLabel
            // 
            this.lensFlareLabel.AutoSize = true;
            this.lensFlareLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lensFlareLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lensFlareLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lensFlareLabel.Location = new System.Drawing.Point(21, 109);
            this.lensFlareLabel.Name = "lensFlareLabel";
            this.lensFlareLabel.Size = new System.Drawing.Size(71, 15);
            this.lensFlareLabel.TabIndex = 18;
            this.lensFlareLabel.Text = "Lens Flares:";
            this.basicToolTip.SetToolTip(this.lensFlareLabel, "Simulates perspective-based flares when looking at bright lights.");
            // 
            // lensFlareBox
            // 
            this.lensFlareBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lensFlareBox.FormattingEnabled = true;
            this.lensFlareBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.lensFlareBox.Location = new System.Drawing.Point(95, 106);
            this.lensFlareBox.Name = "lensFlareBox";
            this.lensFlareBox.Size = new System.Drawing.Size(110, 23);
            this.lensFlareBox.TabIndex = 19;
            this.lensFlareBox.SelectedIndexChanged += new System.EventHandler(this.lensFlareBox_SelectedIndexChanged);
            // 
            // bloomLabel
            // 
            this.bloomLabel.AutoSize = true;
            this.bloomLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloomLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bloomLabel.Location = new System.Drawing.Point(46, 80);
            this.bloomLabel.Name = "bloomLabel";
            this.bloomLabel.Size = new System.Drawing.Size(46, 15);
            this.bloomLabel.TabIndex = 20;
            this.bloomLabel.Text = "Bloom:";
            this.basicToolTip.SetToolTip(this.bloomLabel, "Enunciates lighting by adding a soft glow to bright areas - Requires Depth of Fie" +
        "ld to be enabled.\r\nEnabling Bloom will automatically enable High Quality Bloom a" +
        "s well.\r\n");
            // 
            // bloomBox
            // 
            this.bloomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloomBox.FormattingEnabled = true;
            this.bloomBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.bloomBox.Location = new System.Drawing.Point(95, 77);
            this.bloomBox.Name = "bloomBox";
            this.bloomBox.Size = new System.Drawing.Size(110, 23);
            this.bloomBox.TabIndex = 21;
            this.bloomBox.SelectedIndexChanged += new System.EventHandler(this.bloomBox_SelectedIndexChanged);
            // 
            // anisoLabel
            // 
            this.anisoLabel.AutoSize = true;
            this.anisoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anisoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anisoLabel.Location = new System.Drawing.Point(245, 22);
            this.anisoLabel.Name = "anisoLabel";
            this.anisoLabel.Size = new System.Drawing.Size(121, 15);
            this.anisoLabel.TabIndex = 24;
            this.anisoLabel.Text = "Anisotropic Filtering:";
            this.basicToolTip.SetToolTip(this.anisoLabel, "Improve texture clarity across oblique surfaces.");
            // 
            // anisoBox
            // 
            this.anisoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anisoBox.FormattingEnabled = true;
            this.anisoBox.Items.AddRange(new object[] {
            "4x",
            "8x",
            "16x"});
            this.anisoBox.Location = new System.Drawing.Point(369, 19);
            this.anisoBox.Name = "anisoBox";
            this.anisoBox.Size = new System.Drawing.Size(110, 23);
            this.anisoBox.TabIndex = 25;
            this.anisoBox.SelectedIndexChanged += new System.EventHandler(this.anisoBox_SelectedIndexChanged);
            // 
            // dshadowLabel
            // 
            this.dshadowLabel.AutoSize = true;
            this.dshadowLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshadowLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dshadowLabel.Location = new System.Drawing.Point(258, 109);
            this.dshadowLabel.Name = "dshadowLabel";
            this.dshadowLabel.Size = new System.Drawing.Size(108, 15);
            this.dshadowLabel.TabIndex = 26;
            this.dshadowLabel.Text = "Dynamic Shadows:";
            this.basicToolTip.SetToolTip(this.dshadowLabel, "Only baked shadows from static meshes will be visible if you disable Dynamic Shad" +
        "ows.\r\n");
            // 
            // dShadowBox
            // 
            this.dShadowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dShadowBox.FormattingEnabled = true;
            this.dShadowBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.dShadowBox.Location = new System.Drawing.Point(369, 106);
            this.dShadowBox.Name = "dShadowBox";
            this.dShadowBox.Size = new System.Drawing.Size(110, 23);
            this.dShadowBox.TabIndex = 27;
            this.dShadowBox.SelectedIndexChanged += new System.EventHandler(this.dShadowBox_SelectedIndexChanged);
            // 
            // maxShadowLabel
            // 
            this.maxShadowLabel.AutoSize = true;
            this.maxShadowLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxShadowLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maxShadowLabel.Location = new System.Drawing.Point(222, 167);
            this.maxShadowLabel.Name = "maxShadowLabel";
            this.maxShadowLabel.Size = new System.Drawing.Size(144, 15);
            this.maxShadowLabel.TabIndex = 30;
            this.maxShadowLabel.Text = "Max. Shadow Resolution:";
            this.basicToolTip.SetToolTip(this.maxShadowLabel, "Demanding Setting! The higher the value, the less shimmering. Difference becomes " +
        "negligable above 4096.");
            // 
            // maxShadowBox
            // 
            this.maxShadowBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxShadowBox.FormattingEnabled = true;
            this.maxShadowBox.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096"});
            this.maxShadowBox.Location = new System.Drawing.Point(369, 164);
            this.maxShadowBox.Name = "maxShadowBox";
            this.maxShadowBox.Size = new System.Drawing.Size(110, 23);
            this.maxShadowBox.TabIndex = 31;
            this.maxShadowBox.SelectedIndexChanged += new System.EventHandler(this.maxShadowBox_SelectedIndexChanged);
            // 
            // graphicsBox
            // 
            this.graphicsBox.BackColor = System.Drawing.Color.Transparent;
            this.graphicsBox.Controls.Add(this.miscBox);
            this.graphicsBox.Controls.Add(this.mBlurBox);
            this.graphicsBox.Controls.Add(this.mBlurLabel);
            this.graphicsBox.Controls.Add(this.distBox);
            this.graphicsBox.Controls.Add(this.distLabel);
            this.graphicsBox.Controls.Add(this.fogBox);
            this.graphicsBox.Controls.Add(this.fogLabel);
            this.graphicsBox.Controls.Add(this.sphericBox);
            this.graphicsBox.Controls.Add(this.sphericalLabel);
            this.graphicsBox.Controls.Add(this.memPoolBox);
            this.graphicsBox.Controls.Add(this.memPoolLabel);
            this.graphicsBox.Controls.Add(this.texelBox);
            this.graphicsBox.Controls.Add(this.shadowTexelLabel);
            this.graphicsBox.Controls.Add(this.maxShadowBox);
            this.graphicsBox.Controls.Add(this.maxShadowLabel);
            this.graphicsBox.Controls.Add(this.dShadowBox);
            this.graphicsBox.Controls.Add(this.dshadowLabel);
            this.graphicsBox.Controls.Add(this.anisoBox);
            this.graphicsBox.Controls.Add(this.anisoLabel);
            this.graphicsBox.Controls.Add(this.bloomBox);
            this.graphicsBox.Controls.Add(this.bloomLabel);
            this.graphicsBox.Controls.Add(this.lensFlareBox);
            this.graphicsBox.Controls.Add(this.lensFlareLabel);
            this.graphicsBox.Controls.Add(this.aoBox);
            this.graphicsBox.Controls.Add(this.aoLabel);
            this.graphicsBox.Controls.Add(this.dofBox);
            this.graphicsBox.Controls.Add(this.dofLabel);
            this.graphicsBox.Controls.Add(this.aaBox);
            this.graphicsBox.Controls.Add(this.msaaLabel);
            this.graphicsBox.Controls.Add(this.nvidiaBox);
            this.graphicsBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graphicsBox.Location = new System.Drawing.Point(19, 162);
            this.graphicsBox.Name = "graphicsBox";
            this.graphicsBox.Size = new System.Drawing.Size(489, 277);
            this.graphicsBox.TabIndex = 32;
            this.graphicsBox.TabStop = false;
            this.graphicsBox.Text = "Advanced Graphics";
            // 
            // miscBox
            // 
            this.miscBox.Controls.Add(this.label3);
            this.miscBox.Controls.Add(this.label2);
            this.miscBox.Controls.Add(this.label1);
            this.miscBox.Controls.Add(this.fov2);
            this.miscBox.Controls.Add(this.fov1);
            this.miscBox.Location = new System.Drawing.Point(211, 195);
            this.miscBox.Name = "miscBox";
            this.miscBox.Size = new System.Drawing.Size(101, 76);
            this.miscBox.TabIndex = 50;
            this.miscBox.TabStop = false;
            this.miscBox.Text = "Miscellaneous";
            this.basicToolTip.SetToolTip(this.miscBox, "Enable/Disable HUD/User Interface with the F4 key.\r\n\r\nChange Field of View settin" +
        "gs according to F5-8 keys.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "F3 - Toggle HUD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "F8 - FoV   110";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "F7 - FoV   100";
            // 
            // fov2
            // 
            this.fov2.AutoSize = true;
            this.fov2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.fov2.Location = new System.Drawing.Point(6, 39);
            this.fov2.Name = "fov2";
            this.fov2.Size = new System.Drawing.Size(61, 13);
            this.fov2.TabIndex = 1;
            this.fov2.Text = "F6 - FoV   95";
            // 
            // fov1
            // 
            this.fov1.AutoSize = true;
            this.fov1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.fov1.Location = new System.Drawing.Point(6, 27);
            this.fov1.Name = "fov1";
            this.fov1.Size = new System.Drawing.Size(79, 13);
            this.fov1.TabIndex = 0;
            this.fov1.Text = "F5 - Default FoV";
            // 
            // mBlurBox
            // 
            this.mBlurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mBlurBox.FormattingEnabled = true;
            this.mBlurBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.mBlurBox.Location = new System.Drawing.Point(95, 193);
            this.mBlurBox.Name = "mBlurBox";
            this.mBlurBox.Size = new System.Drawing.Size(110, 23);
            this.mBlurBox.TabIndex = 47;
            this.basicToolTip.SetToolTip(this.mBlurBox, "Blurs camera movement.");
            this.mBlurBox.SelectedIndexChanged += new System.EventHandler(this.mBlurBox_SelectedIndexChanged);
            // 
            // mBlurLabel
            // 
            this.mBlurLabel.AutoSize = true;
            this.mBlurLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBlurLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mBlurLabel.Location = new System.Drawing.Point(16, 196);
            this.mBlurLabel.Name = "mBlurLabel";
            this.mBlurLabel.Size = new System.Drawing.Size(76, 15);
            this.mBlurLabel.TabIndex = 46;
            this.mBlurLabel.Text = "Motion Blur:";
            this.basicToolTip.SetToolTip(this.mBlurLabel, "Emphasizes movement using blur to connect movement between frames. Motion blur in" +
        " this game is of low quality due to being an early implementation.");
            // 
            // distBox
            // 
            this.distBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distBox.FormattingEnabled = true;
            this.distBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.distBox.Location = new System.Drawing.Point(95, 164);
            this.distBox.Name = "distBox";
            this.distBox.Size = new System.Drawing.Size(110, 23);
            this.distBox.TabIndex = 45;
            this.distBox.SelectedIndexChanged += new System.EventHandler(this.distBox_SelectedIndexChanged);
            // 
            // distLabel
            // 
            this.distLabel.AutoSize = true;
            this.distLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.distLabel.Location = new System.Drawing.Point(26, 167);
            this.distLabel.Name = "distLabel";
            this.distLabel.Size = new System.Drawing.Size(66, 15);
            this.distLabel.TabIndex = 44;
            this.distLabel.Text = "Distortion:";
            this.basicToolTip.SetToolTip(this.distLabel, "Distorts the screen for certain actions (explosive gel, heat, etc..).");
            // 
            // fogBox
            // 
            this.fogBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fogBox.FormattingEnabled = true;
            this.fogBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.fogBox.Location = new System.Drawing.Point(95, 48);
            this.fogBox.Name = "fogBox";
            this.fogBox.Size = new System.Drawing.Size(110, 23);
            this.fogBox.TabIndex = 43;
            this.fogBox.SelectedIndexChanged += new System.EventHandler(this.fogBox_SelectedIndexChanged);
            // 
            // fogLabel
            // 
            this.fogLabel.AutoSize = true;
            this.fogLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fogLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fogLabel.Location = new System.Drawing.Point(12, 51);
            this.fogLabel.Name = "fogLabel";
            this.fogLabel.Size = new System.Drawing.Size(80, 15);
            this.fogLabel.TabIndex = 42;
            this.fogLabel.Text = "Fog Volumes:";
            this.basicToolTip.SetToolTip(this.fogLabel, "Enables fog in certain areas.");
            // 
            // sphericBox
            // 
            this.sphericBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sphericBox.FormattingEnabled = true;
            this.sphericBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.sphericBox.Location = new System.Drawing.Point(369, 48);
            this.sphericBox.Name = "sphericBox";
            this.sphericBox.Size = new System.Drawing.Size(110, 23);
            this.sphericBox.TabIndex = 41;
            this.sphericBox.SelectedIndexChanged += new System.EventHandler(this.sphericBox_SelectedIndexChanged);
            // 
            // sphericalLabel
            // 
            this.sphericalLabel.AutoSize = true;
            this.sphericalLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sphericalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sphericalLabel.Location = new System.Drawing.Point(216, 51);
            this.sphericalLabel.Name = "sphericalLabel";
            this.sphericalLabel.Size = new System.Drawing.Size(150, 15);
            this.sphericalLabel.TabIndex = 40;
            this.sphericalLabel.Text = "Spherical Harmonic Lights:";
            this.basicToolTip.SetToolTip(this.sphericalLabel, "Adds additional lighting to the game. Do not disable this if Depth of Field is al" +
        "so disabled.");
            // 
            // memPoolBox
            // 
            this.memPoolBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memPoolBox.FormattingEnabled = true;
            this.memPoolBox.Items.AddRange(new object[] {
            "512 (Default)",
            "1024"});
            this.memPoolBox.Location = new System.Drawing.Point(95, 222);
            this.memPoolBox.Name = "memPoolBox";
            this.memPoolBox.Size = new System.Drawing.Size(110, 23);
            this.memPoolBox.TabIndex = 39;
            this.memPoolBox.SelectedIndexChanged += new System.EventHandler(this.memPoolBox_SelectedIndexChanged);
            // 
            // memPoolLabel
            // 
            this.memPoolLabel.AutoSize = true;
            this.memPoolLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memPoolLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.memPoolLabel.Location = new System.Drawing.Point(2, 225);
            this.memPoolLabel.Name = "memPoolLabel";
            this.memPoolLabel.Size = new System.Drawing.Size(90, 15);
            this.memPoolLabel.TabIndex = 38;
            this.memPoolLabel.Text = "Memory Pools:";
            this.basicToolTip.SetToolTip(this.memPoolLabel, "512 is default and recommended. 1024 might improve texture loading.");
            // 
            // texelBox
            // 
            this.texelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texelBox.FormattingEnabled = true;
            this.texelBox.Items.AddRange(new object[] {
            "1.273240 (Default)",
            "2.000000",
            "4.000000"});
            this.texelBox.Location = new System.Drawing.Point(369, 135);
            this.texelBox.Name = "texelBox";
            this.texelBox.Size = new System.Drawing.Size(110, 23);
            this.texelBox.TabIndex = 37;
            this.texelBox.SelectedIndexChanged += new System.EventHandler(this.texelBox_SelectedIndexChanged);
            // 
            // shadowTexelLabel
            // 
            this.shadowTexelLabel.AutoSize = true;
            this.shadowTexelLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowTexelLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shadowTexelLabel.Location = new System.Drawing.Point(225, 138);
            this.shadowTexelLabel.Name = "shadowTexelLabel";
            this.shadowTexelLabel.Size = new System.Drawing.Size(141, 15);
            this.shadowTexelLabel.TabIndex = 36;
            this.shadowTexelLabel.Text = "Shadow Texels per Pixel:";
            this.basicToolTip.SetToolTip(this.shadowTexelLabel, "2 is recommended with a Shadow Resolution of 2048. \r\n4 is recommended with a Shad" +
        "ow Resolution of 4096.");
            // 
            // nvidiaBox
            // 
            this.nvidiaBox.Controls.Add(this.nvBox);
            this.nvidiaBox.Controls.Add(this.physxBox);
            this.nvidiaBox.Controls.Add(this.physxLabel);
            this.nvidiaBox.Location = new System.Drawing.Point(318, 195);
            this.nvidiaBox.Name = "nvidiaBox";
            this.nvidiaBox.Size = new System.Drawing.Size(165, 76);
            this.nvidiaBox.TabIndex = 49;
            this.nvidiaBox.TabStop = false;
            this.nvidiaBox.Text = "NVIDIA Settings";
            // 
            // nvBox
            // 
            this.nvBox.AutoSize = true;
            this.nvBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nvBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nvBox.ForeColor = System.Drawing.Color.Green;
            this.nvBox.Location = new System.Drawing.Point(19, 51);
            this.nvBox.Name = "nvBox";
            this.nvBox.Size = new System.Drawing.Size(142, 19);
            this.nvBox.TabIndex = 48;
            this.nvBox.Text = "Enable NVIDIA HBAO+";
            this.nvidiaToolTip.SetToolTip(this.nvBox, "Higher end ambient occlusion solution for creating realistic shadowing around obj" +
        "ects. You can choose between this or Reshade AO.");
            this.amdToolTip.SetToolTip(this.nvBox, "Nvidia GPU required for HBAO+ as it uses NvAPI");
            this.nvBox.UseVisualStyleBackColor = true;
            this.nvBox.CheckedChanged += new System.EventHandler(this.nvBox_CheckedChanged);
            // 
            // physxBox
            // 
            this.physxBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.physxBox.FormattingEnabled = true;
            this.physxBox.Items.AddRange(new object[] {
            "Off",
            "Medium",
            "High"});
            this.physxBox.Location = new System.Drawing.Point(51, 24);
            this.physxBox.Name = "physxBox";
            this.physxBox.Size = new System.Drawing.Size(110, 23);
            this.physxBox.TabIndex = 33;
            this.physxBox.SelectedIndexChanged += new System.EventHandler(this.physxBox_SelectedIndexChanged);
            // 
            // physxLabel
            // 
            this.physxLabel.AutoSize = true;
            this.physxLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physxLabel.ForeColor = System.Drawing.Color.Black;
            this.physxLabel.Location = new System.Drawing.Point(5, 27);
            this.physxLabel.Name = "physxLabel";
            this.physxLabel.Size = new System.Drawing.Size(43, 15);
            this.physxLabel.TabIndex = 32;
            this.physxLabel.Text = "PhysX:";
            this.nvidiaToolTip.SetToolTip(this.physxLabel, "Demanding feature!\r\nIt is NOT recommended to go above Medium!\r\nBreakable tiles, r" +
        "ealistic paper simulation, advanced smoke effects.");
            this.amdToolTip.SetToolTip(this.physxLabel, resources.GetString("physxLabel.ToolTip"));
            // 
            // keyButton
            // 
            this.keyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.keyButton.Location = new System.Drawing.Point(19, 445);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(489, 30);
            this.keyButton.TabIndex = 48;
            this.keyButton.Text = "Keybinds";
            this.basicToolTip.SetToolTip(this.keyButton, "Opens a configuration window for keyboard+mouse settings.");
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // ultraButton
            // 
            this.ultraButton.BackColor = System.Drawing.Color.Transparent;
            this.ultraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ultraButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ultraButton.Location = new System.Drawing.Point(19, 125);
            this.ultraButton.Name = "ultraButton";
            this.ultraButton.Size = new System.Drawing.Size(237, 31);
            this.ultraButton.TabIndex = 33;
            this.ultraButton.Text = "Ultra Preset";
            this.basicToolTip.SetToolTip(this.ultraButton, "Highly demanding!");
            this.ultraButton.UseVisualStyleBackColor = false;
            this.ultraButton.Click += new System.EventHandler(this.ultraButton_Click);
            // 
            // optiButton
            // 
            this.optiButton.BackColor = System.Drawing.Color.Transparent;
            this.optiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optiButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optiButton.Location = new System.Drawing.Point(271, 125);
            this.optiButton.Name = "optiButton";
            this.optiButton.Size = new System.Drawing.Size(237, 31);
            this.optiButton.TabIndex = 34;
            this.optiButton.Text = "Optimized Preset";
            this.basicToolTip.SetToolTip(this.optiButton, "Provides a great experience with reasonable performance.");
            this.optiButton.UseVisualStyleBackColor = false;
            this.optiButton.Click += new System.EventHandler(this.optiButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.Enabled = false;
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyButton.Location = new System.Drawing.Point(389, 481);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(119, 25);
            this.applyButton.TabIndex = 35;
            this.applyButton.Text = "Apply Settings";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // texgroupButton
            // 
            this.texgroupButton.BackColor = System.Drawing.Color.Transparent;
            this.texgroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.texgroupButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texgroupButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.texgroupButton.Location = new System.Drawing.Point(19, 481);
            this.texgroupButton.Name = "texgroupButton";
            this.texgroupButton.Size = new System.Drawing.Size(188, 25);
            this.texgroupButton.TabIndex = 37;
            this.texgroupButton.Text = "Apply Texture Pack Fix";
            this.basicToolTip.SetToolTip(this.texgroupButton, "This is only required if you are using the GPUnity Texturepack.");
            this.texgroupButton.UseVisualStyleBackColor = false;
            this.texgroupButton.Click += new System.EventHandler(this.texgroupButton_Click);
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpLabel.Location = new System.Drawing.Point(16, 568);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(73, 13);
            this.gpLabel.TabIndex = 38;
            this.gpLabel.Text = "Graphics Card:";
            // 
            // gpInfoLabel
            // 
            this.gpInfoLabel.AutoSize = true;
            this.gpInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpInfoLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpInfoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpInfoLabel.Location = new System.Drawing.Point(87, 568);
            this.gpInfoLabel.Name = "gpInfoLabel";
            this.gpInfoLabel.Size = new System.Drawing.Size(137, 13);
            this.gpInfoLabel.TabIndex = 39;
            this.gpInfoLabel.Text = "Graphics Card Info goes here";
            // 
            // credLabel
            // 
            this.credLabel.AutoSize = true;
            this.credLabel.BackColor = System.Drawing.Color.Transparent;
            this.credLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.credLabel.LinkColor = System.Drawing.Color.DimGray;
            this.credLabel.Location = new System.Drawing.Point(451, 567);
            this.credLabel.Name = "credLabel";
            this.credLabel.Size = new System.Drawing.Size(59, 13);
            this.credLabel.TabIndex = 41;
            this.credLabel.TabStop = true;
            this.credLabel.Text = "Information";
            this.credLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credLabel_LinkClicked);
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.Color.Transparent;
            this.launchButton.BackgroundImage = global::BmLauncherWForm.Properties.Resources.LauncherStart1;
            this.launchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.launchButton.Location = new System.Drawing.Point(19, 512);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(489, 53);
            this.launchButton.TabIndex = 36;
            this.launchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.basicToolTip.SetToolTip(this.launchButton, "Currently selected settings will automatically be applied.");
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // basicToolTip
            // 
            this.basicToolTip.AutomaticDelay = 50000;
            this.basicToolTip.AutoPopDelay = 50000;
            this.basicToolTip.InitialDelay = 500;
            this.basicToolTip.ReshowDelay = 100;
            this.basicToolTip.ShowAlways = true;
            this.basicToolTip.ToolTipTitle = "Information";
            // 
            // disableIntroButton
            // 
            this.disableIntroButton.BackColor = System.Drawing.Color.Transparent;
            this.disableIntroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableIntroButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableIntroButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disableIntroButton.Location = new System.Drawing.Point(213, 481);
            this.disableIntroButton.Name = "disableIntroButton";
            this.disableIntroButton.Size = new System.Drawing.Size(170, 25);
            this.disableIntroButton.TabIndex = 49;
            this.disableIntroButton.Text = "Disable Startup Movies";
            this.basicToolTip.SetToolTip(this.disableIntroButton, "Find intro videos annoying? Click this to jump straight to the main menu.");
            this.disableIntroButton.UseVisualStyleBackColor = false;
            this.disableIntroButton.Click += new System.EventHandler(this.disableIntroButton_Click);
            // 
            // nvidiaToolTip
            // 
            this.nvidiaToolTip.Active = false;
            this.nvidiaToolTip.ToolTipTitle = "Information";
            // 
            // amdToolTip
            // 
            this.amdToolTip.Active = false;
            this.amdToolTip.ToolTipTitle = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(334, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tooltips are available for each setting.\r\n";
            // 
            // BmLauncherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(527, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disableIntroButton);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.credLabel);
            this.Controls.Add(this.gpInfoLabel);
            this.Controls.Add(this.gpLabel);
            this.Controls.Add(this.texgroupButton);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.optiButton);
            this.Controls.Add(this.graphicsBox);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.ultraButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BmLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batman: Arkham Asylum - Advanced Launcher";
            this.TopMost = true;
            this.displayBox.ResumeLayout(false);
            this.displayBox.PerformLayout();
            this.graphicsBox.ResumeLayout(false);
            this.graphicsBox.PerformLayout();
            this.miscBox.ResumeLayout(false);
            this.miscBox.PerformLayout();
            this.nvidiaBox.ResumeLayout(false);
            this.nvidiaBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label msaaLabel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label vsyncLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Label fscreenLabel;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.Label dofLabel;
        private System.Windows.Forms.Label aoLabel;
        private System.Windows.Forms.Label lensFlareLabel;
        private System.Windows.Forms.Label bloomLabel;
        private System.Windows.Forms.Label anisoLabel;
        private System.Windows.Forms.Label dshadowLabel;
        private System.Windows.Forms.Label maxShadowLabel;
        private System.Windows.Forms.GroupBox graphicsBox;
        private System.Windows.Forms.Label physxLabel;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Label smoothFrameLabel;
        private System.Windows.Forms.Label gpLabel;
        public System.Windows.Forms.Button texgroupButton;
        public System.Windows.Forms.ComboBox vsyncBox;
        public System.Windows.Forms.ComboBox detailBox;
        public System.Windows.Forms.ComboBox fullscreenBox;
        public System.Windows.Forms.ComboBox resBox;
        public System.Windows.Forms.ComboBox aaBox;
        public System.Windows.Forms.ComboBox dofBox;
        public System.Windows.Forms.ComboBox aoBox;
        public System.Windows.Forms.ComboBox lensFlareBox;
        public System.Windows.Forms.ComboBox bloomBox;
        public System.Windows.Forms.ComboBox anisoBox;
        public System.Windows.Forms.ComboBox dShadowBox;
        public System.Windows.Forms.ComboBox maxShadowBox;
        public System.Windows.Forms.ComboBox physxBox;
        public System.Windows.Forms.Button ultraButton;
        public System.Windows.Forms.Button optiButton;
        public System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.LinkLabel credLabel;
        public System.Windows.Forms.ComboBox texelBox;
        private System.Windows.Forms.Label shadowTexelLabel;
        public System.Windows.Forms.Label gpInfoLabel;
        public System.Windows.Forms.ComboBox memPoolBox;
        private System.Windows.Forms.Label memPoolLabel;
        public System.Windows.Forms.ComboBox distBox;
        private System.Windows.Forms.Label distLabel;
        public System.Windows.Forms.ComboBox fogBox;
        private System.Windows.Forms.Label fogLabel;
        public System.Windows.Forms.ComboBox sphericBox;
        private System.Windows.Forms.Label sphericalLabel;
        public System.Windows.Forms.ComboBox mBlurBox;
        private System.Windows.Forms.Label mBlurLabel;
        private System.Windows.Forms.Button keyButton;
        public System.Windows.Forms.MaskedTextBox maxSmoothTextBox;
        private System.Windows.Forms.GroupBox nvidiaBox;
        public System.Windows.Forms.CheckBox nvBox;
        private System.Windows.Forms.ToolTip basicToolTip;
        public System.Windows.Forms.ToolTip amdToolTip;
        public System.Windows.Forms.ToolTip nvidiaToolTip;
        public System.Windows.Forms.Button disableIntroButton;
        private System.Windows.Forms.GroupBox miscBox;
        private System.Windows.Forms.Label fov1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fov2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox langBox;
        private System.Windows.Forms.Label langLabel;
    }
}

