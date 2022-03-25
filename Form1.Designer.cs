namespace AK_obvestila
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saveBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.dateTimeDatum = new System.Windows.Forms.DateTimePicker();
            this.datumUpDown = new System.Windows.Forms.NumericUpDown();
            this.obvestiloLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.datumLabel = new System.Windows.Forms.Label();
            this.textBoxObvestilo = new System.Windows.Forms.TextBox();
            this.editValueBtn = new System.Windows.Forms.Button();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.exitIcon = new FontAwesome.Sharp.IconPictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.opozoriloLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addObvestilo = new System.Windows.Forms.TextBox();
            this.addDatum = new System.Windows.Forms.DateTimePicker();
            this.addDelay = new System.Windows.Forms.NumericUpDown();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.minIcon = new FontAwesome.Sharp.IconPictureBox();
            this.backgroundBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.askBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.credentialsBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.timerDrop = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3600000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(7, 436);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(155, 34);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Shrani v datoteko";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.displayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.displayBtn.FlatAppearance.BorderSize = 2;
            this.displayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.displayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.displayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayBtn.Location = new System.Drawing.Point(7, 478);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(155, 34);
            this.displayBtn.TabIndex = 13;
            this.displayBtn.Text = "Osveži podatke";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 522);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sendBtn.FlatAppearance.BorderSize = 2;
            this.sendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.sendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Location = new System.Drawing.Point(789, 49);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(139, 34);
            this.sendBtn.TabIndex = 16;
            this.sendBtn.Text = "Pošlji obvestila";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // dateTimeDatum
            // 
            this.dateTimeDatum.Enabled = false;
            this.dateTimeDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDatum.Location = new System.Drawing.Point(297, 45);
            this.dateTimeDatum.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDatum.Name = "dateTimeDatum";
            this.dateTimeDatum.Size = new System.Drawing.Size(151, 25);
            this.dateTimeDatum.TabIndex = 4;
            // 
            // datumUpDown
            // 
            this.datumUpDown.Enabled = false;
            this.datumUpDown.Location = new System.Drawing.Point(456, 45);
            this.datumUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.datumUpDown.Name = "datumUpDown";
            this.datumUpDown.Size = new System.Drawing.Size(62, 25);
            this.datumUpDown.TabIndex = 5;
            // 
            // obvestiloLabel
            // 
            this.obvestiloLabel.AutoSize = true;
            this.obvestiloLabel.Location = new System.Drawing.Point(4, 4);
            this.obvestiloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.obvestiloLabel.Name = "obvestiloLabel";
            this.obvestiloLabel.Padding = new System.Windows.Forms.Padding(5);
            this.obvestiloLabel.Size = new System.Drawing.Size(85, 29);
            this.obvestiloLabel.TabIndex = 7;
            this.obvestiloLabel.Text = "Obvestilo";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(13, 64);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 551);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(293, 4);
            this.datumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Padding = new System.Windows.Forms.Padding(5);
            this.datumLabel.Size = new System.Drawing.Size(66, 29);
            this.datumLabel.TabIndex = 9;
            this.datumLabel.Text = "Datum";
            // 
            // textBoxObvestilo
            // 
            this.textBoxObvestilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxObvestilo.Enabled = false;
            this.textBoxObvestilo.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxObvestilo.Location = new System.Drawing.Point(8, 47);
            this.textBoxObvestilo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxObvestilo.Name = "textBoxObvestilo";
            this.textBoxObvestilo.Size = new System.Drawing.Size(270, 19);
            this.textBoxObvestilo.TabIndex = 3;
            // 
            // editValueBtn
            // 
            this.editValueBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.editValueBtn.FlatAppearance.BorderSize = 2;
            this.editValueBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.editValueBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.editValueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editValueBtn.Location = new System.Drawing.Point(7, 7);
            this.editValueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editValueBtn.Name = "editValueBtn";
            this.editValueBtn.Size = new System.Drawing.Size(112, 34);
            this.editValueBtn.TabIndex = 1;
            this.editValueBtn.Text = "Uredi";
            this.editValueBtn.UseVisualStyleBackColor = true;
            this.editValueBtn.Click += new System.EventHandler(this.editValueBtn_Click);
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.Enabled = false;
            this.saveDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saveDataBtn.FlatAppearance.BorderSize = 2;
            this.saveDataBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.saveDataBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.saveDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDataBtn.Location = new System.Drawing.Point(599, 90);
            this.saveDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(112, 34);
            this.saveDataBtn.TabIndex = 6;
            this.saveDataBtn.Text = "Shrani";
            this.saveDataBtn.UseVisualStyleBackColor = true;
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // exitIcon
            // 
            this.exitIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitIcon.BackColor = System.Drawing.Color.Transparent;
            this.exitIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.exitIcon.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.exitIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.exitIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.exitIcon.Location = new System.Drawing.Point(905, 4);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(32, 32);
            this.exitIcon.TabIndex = 15;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            this.exitIcon.MouseLeave += new System.EventHandler(this.exitIcon_MouseLeave);
            this.exitIcon.MouseHover += new System.EventHandler(this.exitIcon_MouseHover);
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.addBtn.FlatAppearance.BorderSize = 2;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(11, 153);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 34);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Dodaj obvestilo";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // opozoriloLabel
            // 
            this.opozoriloLabel.AutoSize = true;
            this.opozoriloLabel.Location = new System.Drawing.Point(452, 4);
            this.opozoriloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opozoriloLabel.Name = "opozoriloLabel";
            this.opozoriloLabel.Padding = new System.Windows.Forms.Padding(5);
            this.opozoriloLabel.Size = new System.Drawing.Size(76, 29);
            this.opozoriloLabel.TabIndex = 17;
            this.opozoriloLabel.Text = "Obvesti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "dni prej";
            // 
            // addObvestilo
            // 
            this.addObvestilo.Location = new System.Drawing.Point(8, 45);
            this.addObvestilo.Margin = new System.Windows.Forms.Padding(4);
            this.addObvestilo.Name = "addObvestilo";
            this.addObvestilo.Size = new System.Drawing.Size(270, 25);
            this.addObvestilo.TabIndex = 8;
            // 
            // addDatum
            // 
            this.addDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addDatum.Location = new System.Drawing.Point(297, 45);
            this.addDatum.Margin = new System.Windows.Forms.Padding(4);
            this.addDatum.Name = "addDatum";
            this.addDatum.Size = new System.Drawing.Size(151, 25);
            this.addDatum.TabIndex = 9;
            // 
            // addDelay
            // 
            this.addDelay.Location = new System.Drawing.Point(456, 45);
            this.addDelay.Margin = new System.Windows.Forms.Padding(4);
            this.addDelay.Name = "addDelay";
            this.addDelay.Size = new System.Drawing.Size(62, 25);
            this.addDelay.TabIndex = 10;
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.deleteBtn.FlatAppearance.BorderSize = 2;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(127, 7);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 34);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Izbriši";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // minIcon
            // 
            this.minIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minIcon.BackColor = System.Drawing.Color.Transparent;
            this.minIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.minIcon.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.minIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.minIcon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.minIcon.Location = new System.Drawing.Point(873, 4);
            this.minIcon.Name = "minIcon";
            this.minIcon.Size = new System.Drawing.Size(32, 32);
            this.minIcon.TabIndex = 28;
            this.minIcon.TabStop = false;
            this.minIcon.Click += new System.EventHandler(this.minIcon_Click);
            this.minIcon.MouseLeave += new System.EventHandler(this.minIcon_MouseLeave);
            this.minIcon.MouseHover += new System.EventHandler(this.minIcon_MouseHover);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backgroundBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.backgroundBtn.FlatAppearance.BorderSize = 2;
            this.backgroundBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.backgroundBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.backgroundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundBtn.Location = new System.Drawing.Point(304, 478);
            this.backgroundBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.Size = new System.Drawing.Size(342, 34);
            this.backgroundBtn.TabIndex = 14;
            this.backgroundBtn.Text = "Pošlji v ozadje";
            this.backgroundBtn.UseVisualStyleBackColor = true;
            this.backgroundBtn.Click += new System.EventHandler(this.backgroundBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://avtokrka.si/media/dsg/header.png";
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 574);
            this.panel1.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 54);
            this.panel4.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.askBox);
            this.panel2.Controls.Add(this.minIcon);
            this.panel2.Controls.Add(this.exitIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(282, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 54);
            this.panel2.TabIndex = 32;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(205, 39);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nadzorna Plošča";
            // 
            // askBox
            // 
            this.askBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.askBox.AutoSize = true;
            this.askBox.Checked = true;
            this.askBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askBox.Location = new System.Drawing.Point(666, 7);
            this.askBox.Name = "askBox";
            this.askBox.Size = new System.Drawing.Size(198, 23);
            this.askBox.TabIndex = 30;
            this.askBox.Text = "Vprašaj pred zapiranjem?";
            this.askBox.UseVisualStyleBackColor = true;
            this.askBox.CheckedChanged += new System.EventHandler(this.askBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.credentialsBtn);
            this.panel3.Controls.Add(this.dodajBtn);
            this.panel3.Controls.Add(this.panelAdd);
            this.panel3.Controls.Add(this.backgroundBtn);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.sendBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.deleteBtn);
            this.panel3.Controls.Add(this.displayBtn);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Controls.Add(this.editValueBtn);
            this.panel3.Controls.Add(this.saveDataBtn);
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(282, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 520);
            this.panel3.TabIndex = 33;
            // 
            // credentialsBtn
            // 
            this.credentialsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.credentialsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.credentialsBtn.FlatAppearance.BorderSize = 2;
            this.credentialsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.credentialsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.credentialsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credentialsBtn.Location = new System.Drawing.Point(789, 7);
            this.credentialsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.credentialsBtn.Name = "credentialsBtn";
            this.credentialsBtn.Size = new System.Drawing.Size(139, 34);
            this.credentialsBtn.TabIndex = 15;
            this.credentialsBtn.Text = "Set Credentials";
            this.credentialsBtn.UseVisualStyleBackColor = true;
            this.credentialsBtn.Click += new System.EventHandler(this.credentialsBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dodajBtn.FlatAppearance.BorderSize = 2;
            this.dodajBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dodajBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.Location = new System.Drawing.Point(599, 236);
            this.dodajBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(112, 34);
            this.dodajBtn.TabIndex = 11;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Visible = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.Window;
            this.panelAdd.Controls.Add(this.panel8);
            this.panelAdd.Controls.Add(this.label11);
            this.panelAdd.Controls.Add(this.addObvestilo);
            this.panelAdd.Controls.Add(this.addDatum);
            this.panelAdd.Controls.Add(this.addDelay);
            this.panelAdd.Location = new System.Drawing.Point(7, 194);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(585, 80);
            this.panelAdd.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(585, 38);
            this.panel8.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Obvestilo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Datum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(76, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "Obvesti:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(521, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "dni prej";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ImageLocation = "https://www.pikpng.com/pngl/b/138-1380465_abstract-art-geometry-stock-blue-abstra" +
    "ct-triangle-png.png";
            this.pictureBox2.Location = new System.Drawing.Point(596, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(438, 434);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dateTimeDatum);
            this.panel5.Controls.Add(this.datumUpDown);
            this.panel5.Controls.Add(this.textBoxObvestilo);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(7, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 80);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.obvestiloLabel);
            this.panel6.Controls.Add(this.datumLabel);
            this.panel6.Controls.Add(this.opozoriloLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 38);
            this.panel6.TabIndex = 31;
            // 
            // timerLoad
            // 
            this.timerLoad.Interval = 10;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // timerDrop
            // 
            this.timerDrop.Interval = 10;
            this.timerDrop.Tick += new System.EventHandler(this.timerDrop_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "AK obvestila";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1222, 578);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Window";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AK obvestila";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.datumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.DateTimePicker dateTimeDatum;
        private System.Windows.Forms.NumericUpDown datumUpDown;
        private System.Windows.Forms.Label obvestiloLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.TextBox textBoxObvestilo;
        private System.Windows.Forms.Button editValueBtn;
        private System.Windows.Forms.Button saveDataBtn;
        private FontAwesome.Sharp.IconPictureBox exitIcon;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label opozoriloLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addObvestilo;
        private System.Windows.Forms.DateTimePicker addDatum;
        private System.Windows.Forms.NumericUpDown addDelay;
        private System.Windows.Forms.Button deleteBtn;
        private FontAwesome.Sharp.IconPictureBox minIcon;
        private System.Windows.Forms.Button backgroundBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox askBox;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timerDrop;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button credentialsBtn;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

