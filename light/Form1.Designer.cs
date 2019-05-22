namespace light
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn1_off = new System.Windows.Forms.Button();
            this.btn1_on = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn1_1_on = new System.Windows.Forms.Button();
            this.btn1_1_off = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn1_2_on = new System.Windows.Forms.Button();
            this.btn1_2_off = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn2_2_on = new System.Windows.Forms.Button();
            this.btn2_2_off = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn2_1_on = new System.Windows.Forms.Button();
            this.btn2_1_off = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn3_2_on = new System.Windows.Forms.Button();
            this.btn3_2_off = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn3_1_on = new System.Windows.Forms.Button();
            this.btn3_1_off = new System.Windows.Forms.Button();
            this.labdate = new System.Windows.Forms.Label();
            this.labtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn1_off
            // 
            this.btn1_off.BackColor = System.Drawing.Color.Transparent;
            this.btn1_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn1_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_off.FlatAppearance.BorderSize = 0;
            this.btn1_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_off.Location = new System.Drawing.Point(73, 20);
            this.btn1_off.Name = "btn1_off";
            this.btn1_off.Size = new System.Drawing.Size(67, 73);
            this.btn1_off.TabIndex = 1;
            this.btn1_off.UseVisualStyleBackColor = false;
            this.btn1_off.Click += new System.EventHandler(this.btn1_off_Click);
            // 
            // btn1_on
            // 
            this.btn1_on.BackColor = System.Drawing.Color.Transparent;
            this.btn1_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn1_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_on.FlatAppearance.BorderSize = 0;
            this.btn1_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_on.Location = new System.Drawing.Point(6, 20);
            this.btn1_on.Name = "btn1_on";
            this.btn1_on.Size = new System.Drawing.Size(70, 73);
            this.btn1_on.TabIndex = 0;
            this.btn1_on.UseVisualStyleBackColor = false;
            this.btn1_on.Click += new System.EventHandler(this.btn1_on_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn1_on);
            this.groupBox1.Controls.Add(this.btn1_off);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开关-门厅";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_on);
            this.groupBox2.Controls.Add(this.btn_off);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(380, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 103);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "总开关";
            // 
            // btn_on
            // 
            this.btn_on.BackColor = System.Drawing.Color.Transparent;
            this.btn_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_on.FlatAppearance.BorderSize = 0;
            this.btn_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_on.Location = new System.Drawing.Point(6, 20);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(70, 73);
            this.btn_on.TabIndex = 0;
            this.btn_on.UseVisualStyleBackColor = false;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // btn_off
            // 
            this.btn_off.BackColor = System.Drawing.Color.Transparent;
            this.btn_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_off.FlatAppearance.BorderSize = 0;
            this.btn_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_off.Location = new System.Drawing.Point(72, 20);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(67, 73);
            this.btn_off.TabIndex = 1;
            this.btn_off.UseVisualStyleBackColor = false;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn1_1_on);
            this.groupBox3.Controls.Add(this.btn1_1_off);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(24, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 103);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "开关1-1";
            // 
            // btn1_1_on
            // 
            this.btn1_1_on.BackColor = System.Drawing.Color.Transparent;
            this.btn1_1_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn1_1_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_1_on.FlatAppearance.BorderSize = 0;
            this.btn1_1_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_1_on.Location = new System.Drawing.Point(6, 20);
            this.btn1_1_on.Name = "btn1_1_on";
            this.btn1_1_on.Size = new System.Drawing.Size(70, 73);
            this.btn1_1_on.TabIndex = 0;
            this.btn1_1_on.UseVisualStyleBackColor = false;
            this.btn1_1_on.Click += new System.EventHandler(this.btn1_1_on_Click);
            // 
            // btn1_1_off
            // 
            this.btn1_1_off.BackColor = System.Drawing.Color.Transparent;
            this.btn1_1_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn1_1_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_1_off.FlatAppearance.BorderSize = 0;
            this.btn1_1_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_1_off.Location = new System.Drawing.Point(72, 20);
            this.btn1_1_off.Name = "btn1_1_off";
            this.btn1_1_off.Size = new System.Drawing.Size(67, 73);
            this.btn1_1_off.TabIndex = 1;
            this.btn1_1_off.UseVisualStyleBackColor = false;
            this.btn1_1_off.Click += new System.EventHandler(this.btn1_1_off_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn1_2_on);
            this.groupBox4.Controls.Add(this.btn1_2_off);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(24, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(146, 103);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "开关1-2";
            // 
            // btn1_2_on
            // 
            this.btn1_2_on.BackColor = System.Drawing.Color.Transparent;
            this.btn1_2_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn1_2_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_2_on.FlatAppearance.BorderSize = 0;
            this.btn1_2_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_2_on.Location = new System.Drawing.Point(6, 20);
            this.btn1_2_on.Name = "btn1_2_on";
            this.btn1_2_on.Size = new System.Drawing.Size(70, 73);
            this.btn1_2_on.TabIndex = 0;
            this.btn1_2_on.UseVisualStyleBackColor = false;
            this.btn1_2_on.Click += new System.EventHandler(this.btn1_2_on_Click);
            // 
            // btn1_2_off
            // 
            this.btn1_2_off.BackColor = System.Drawing.Color.Transparent;
            this.btn1_2_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn1_2_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1_2_off.FlatAppearance.BorderSize = 0;
            this.btn1_2_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1_2_off.Location = new System.Drawing.Point(72, 20);
            this.btn1_2_off.Name = "btn1_2_off";
            this.btn1_2_off.Size = new System.Drawing.Size(67, 73);
            this.btn1_2_off.TabIndex = 1;
            this.btn1_2_off.UseVisualStyleBackColor = false;
            this.btn1_2_off.Click += new System.EventHandler(this.btn1_2_off_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btn2_2_on);
            this.groupBox5.Controls.Add(this.btn2_2_off);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(193, 357);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(146, 103);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "开关2-2";
            // 
            // btn2_2_on
            // 
            this.btn2_2_on.BackColor = System.Drawing.Color.Transparent;
            this.btn2_2_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn2_2_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_2_on.FlatAppearance.BorderSize = 0;
            this.btn2_2_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_2_on.Location = new System.Drawing.Point(6, 20);
            this.btn2_2_on.Name = "btn2_2_on";
            this.btn2_2_on.Size = new System.Drawing.Size(70, 73);
            this.btn2_2_on.TabIndex = 0;
            this.btn2_2_on.UseVisualStyleBackColor = false;
            this.btn2_2_on.Click += new System.EventHandler(this.btn2_2_on_Click);
            // 
            // btn2_2_off
            // 
            this.btn2_2_off.BackColor = System.Drawing.Color.Transparent;
            this.btn2_2_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn2_2_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_2_off.FlatAppearance.BorderSize = 0;
            this.btn2_2_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_2_off.Location = new System.Drawing.Point(72, 20);
            this.btn2_2_off.Name = "btn2_2_off";
            this.btn2_2_off.Size = new System.Drawing.Size(67, 73);
            this.btn2_2_off.TabIndex = 1;
            this.btn2_2_off.UseVisualStyleBackColor = false;
            this.btn2_2_off.Click += new System.EventHandler(this.btn2_2_off_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btn2_1_on);
            this.groupBox6.Controls.Add(this.btn2_1_off);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(199, 224);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(146, 103);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "开关2-1";
            // 
            // btn2_1_on
            // 
            this.btn2_1_on.BackColor = System.Drawing.Color.Transparent;
            this.btn2_1_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn2_1_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_1_on.FlatAppearance.BorderSize = 0;
            this.btn2_1_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_1_on.Location = new System.Drawing.Point(6, 20);
            this.btn2_1_on.Name = "btn2_1_on";
            this.btn2_1_on.Size = new System.Drawing.Size(70, 73);
            this.btn2_1_on.TabIndex = 0;
            this.btn2_1_on.UseVisualStyleBackColor = false;
            this.btn2_1_on.Click += new System.EventHandler(this.btn2_1_on_Click);
            // 
            // btn2_1_off
            // 
            this.btn2_1_off.BackColor = System.Drawing.Color.Transparent;
            this.btn2_1_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn2_1_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2_1_off.FlatAppearance.BorderSize = 0;
            this.btn2_1_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_1_off.Location = new System.Drawing.Point(72, 20);
            this.btn2_1_off.Name = "btn2_1_off";
            this.btn2_1_off.Size = new System.Drawing.Size(67, 73);
            this.btn2_1_off.TabIndex = 1;
            this.btn2_1_off.UseVisualStyleBackColor = false;
            this.btn2_1_off.Click += new System.EventHandler(this.btn2_1_off_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.btn3_2_on);
            this.groupBox7.Controls.Add(this.btn3_2_off);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(380, 357);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(146, 103);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "开关3-2";
            // 
            // btn3_2_on
            // 
            this.btn3_2_on.BackColor = System.Drawing.Color.Transparent;
            this.btn3_2_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn3_2_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_2_on.FlatAppearance.BorderSize = 0;
            this.btn3_2_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_2_on.Location = new System.Drawing.Point(6, 20);
            this.btn3_2_on.Name = "btn3_2_on";
            this.btn3_2_on.Size = new System.Drawing.Size(70, 73);
            this.btn3_2_on.TabIndex = 0;
            this.btn3_2_on.UseVisualStyleBackColor = false;
            this.btn3_2_on.Click += new System.EventHandler(this.btn3_2_on_Click);
            // 
            // btn3_2_off
            // 
            this.btn3_2_off.BackColor = System.Drawing.Color.Transparent;
            this.btn3_2_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn3_2_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_2_off.FlatAppearance.BorderSize = 0;
            this.btn3_2_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_2_off.Location = new System.Drawing.Point(72, 20);
            this.btn3_2_off.Name = "btn3_2_off";
            this.btn3_2_off.Size = new System.Drawing.Size(67, 73);
            this.btn3_2_off.TabIndex = 1;
            this.btn3_2_off.UseVisualStyleBackColor = false;
            this.btn3_2_off.Click += new System.EventHandler(this.btn3_2_off_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.btn3_1_on);
            this.groupBox8.Controls.Add(this.btn3_1_off);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Location = new System.Drawing.Point(380, 224);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(146, 103);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "开关3-1";
            // 
            // btn3_1_on
            // 
            this.btn3_1_on.BackColor = System.Drawing.Color.Transparent;
            this.btn3_1_on.BackgroundImage = global::light.Properties.Resources.画板_001;
            this.btn3_1_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_1_on.FlatAppearance.BorderSize = 0;
            this.btn3_1_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_1_on.Location = new System.Drawing.Point(6, 20);
            this.btn3_1_on.Name = "btn3_1_on";
            this.btn3_1_on.Size = new System.Drawing.Size(70, 73);
            this.btn3_1_on.TabIndex = 0;
            this.btn3_1_on.UseVisualStyleBackColor = false;
            this.btn3_1_on.Click += new System.EventHandler(this.btn3_1_on_Click);
            // 
            // btn3_1_off
            // 
            this.btn3_1_off.BackColor = System.Drawing.Color.Transparent;
            this.btn3_1_off.BackgroundImage = global::light.Properties.Resources.画板_002;
            this.btn3_1_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3_1_off.FlatAppearance.BorderSize = 0;
            this.btn3_1_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3_1_off.Location = new System.Drawing.Point(72, 20);
            this.btn3_1_off.Name = "btn3_1_off";
            this.btn3_1_off.Size = new System.Drawing.Size(67, 73);
            this.btn3_1_off.TabIndex = 1;
            this.btn3_1_off.UseVisualStyleBackColor = false;
            this.btn3_1_off.Click += new System.EventHandler(this.btn3_1_off_Click);
            // 
            // labdate
            // 
            this.labdate.AutoSize = true;
            this.labdate.BackColor = System.Drawing.Color.Transparent;
            this.labdate.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labdate.ForeColor = System.Drawing.Color.White;
            this.labdate.Location = new System.Drawing.Point(188, 117);
            this.labdate.Name = "labdate";
            this.labdate.Size = new System.Drawing.Size(60, 25);
            this.labdate.TabIndex = 13;
            this.labdate.Text = "日期";
            this.labdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.BackColor = System.Drawing.Color.Transparent;
            this.labtime.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labtime.ForeColor = System.Drawing.Color.White;
            this.labtime.Location = new System.Drawing.Point(214, 165);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(60, 25);
            this.labtime.TabIndex = 13;
            this.labtime.Text = "时间";
            this.labtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文隶书", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 57);
            this.label1.TabIndex = 14;
            this.label1.Text = "灯光控制面板";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.Location = new System.Drawing.Point(501, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(47, 41);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::light.Properties.Resources.微信图片_20190411110930;
            this.ClientSize = new System.Drawing.Size(548, 546);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.labdate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn1_off;
        private System.Windows.Forms.Button btn1_on;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn1_1_on;
        private System.Windows.Forms.Button btn1_1_off;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn1_2_on;
        private System.Windows.Forms.Button btn1_2_off;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn2_2_on;
        private System.Windows.Forms.Button btn2_2_off;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn2_1_on;
        private System.Windows.Forms.Button btn2_1_off;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn3_2_on;
        private System.Windows.Forms.Button btn3_2_off;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn3_1_on;
        private System.Windows.Forms.Button btn3_1_off;
        private System.Windows.Forms.Label labdate;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclose;
    }
}

