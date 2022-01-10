namespace printSystem
{
    partial class ouside
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ouside));
            this.devgrid = new System.Windows.Forms.DataGridView();
            this.studentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new printSystem.dataDataSet();
            this.studentDataTableAdapter = new printSystem.dataDataSetTableAdapters.studentDataTableAdapter();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcourse = new MetroFramework.Controls.MetroComboBox();
            this.txtseatNo = new MetroFramework.Controls.MetroTextBox();
            this.btnprintqarar = new MetroFramework.Controls.MetroButton();
            this.btnprintgolaph = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtschool = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnumherman = new MetroFramework.Controls.MetroTextBox();
            this.txtreport = new MetroFramework.Controls.MetroTextBox();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.txtDay = new MetroFramework.Controls.MetroTextBox();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.seerTxt = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regionText = new MetroFramework.Controls.MetroTextBox();
            this.subjectStaticsmetroButton = new MetroFramework.Controls.MetroButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.seatnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seercodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examscnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examScidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeadescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shows = new System.Windows.Forms.DataGridViewImageColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.stType = new MetroFramework.Controls.MetroTextBox();
            this.typedesc = new MetroFramework.Controls.MetroTextBox();
            this.lagnaNumTxt = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reportTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTypesTableAdapter = new printSystem.dataDataSetTableAdapters.reportTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.devgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // devgrid
            // 
            this.devgrid.AllowUserToAddRows = false;
            this.devgrid.AllowUserToDeleteRows = false;
            this.devgrid.AllowUserToOrderColumns = true;
            this.devgrid.AllowUserToResizeColumns = false;
            this.devgrid.AllowUserToResizeRows = false;
            this.devgrid.AutoGenerateColumns = false;
            this.devgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.devgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.devgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatnoDataGridViewTextBoxColumn,
            this.stnameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn,
            this.typecodeDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.scnameDataGridViewTextBoxColumn,
            this.seercodeDataGridViewTextBoxColumn,
            this.scidDataGridViewTextBoxColumn,
            this.examscnameDataGridViewTextBoxColumn,
            this.examScidDataGridViewTextBoxColumn,
            this.typeadescDataGridViewTextBoxColumn,
            this.sttypeDataGridViewTextBoxColumn,
            this.shows,
            this.del});
            this.devgrid.DataSource = this.studentDataBindingSource;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devgrid.DefaultCellStyle = dataGridViewCellStyle22;
            this.devgrid.EnableHeadersVisualStyles = false;
            this.devgrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.devgrid.Location = new System.Drawing.Point(683, 81);
            this.devgrid.MultiSelect = false;
            this.devgrid.Name = "devgrid";
            this.devgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.devgrid.RowHeadersVisible = false;
            this.devgrid.RowHeadersWidth = 51;
            this.devgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devgrid.Size = new System.Drawing.Size(593, 591);
            this.devgrid.TabIndex = 4;
            this.devgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devgrid_CellClick);
            this.devgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devgrid_CellContentClick);
            // 
            // studentDataBindingSource
            // 
            this.studentDataBindingSource.DataMember = "studentData";
            this.studentDataBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // txtsearch
            // 
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(569, 1);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(683, 50);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PromptText = "بحث بإسم الطالب او رقم الجلوس";
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(593, 25);
            this.txtsearch.TabIndex = 5;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMark = "بحث بإسم الطالب او رقم الجلوس";
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.metroTextBox1);
            this.panel1.Controls.Add(this.metroComboBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.subjectStaticsmetroButton);
            this.panel1.Controls.Add(this.regionText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.seerTxt);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.txtDay);
            this.panel1.Controls.Add(this.txtreport);
            this.panel1.Controls.Add(this.txtnumherman);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtschool);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnprintgolaph);
            this.panel1.Controls.Add(this.btnprintqarar);
            this.panel1.Controls.Add(this.txtseatNo);
            this.panel1.Controls.Add(this.cmbcourse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(46, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(550, 593);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(77, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "تسجيل قرار حرمان لمادة خارج الجدول";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(393, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "رقم الجلوس للطالب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbcourse
            // 
            this.cmbcourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.ItemHeight = 24;
            this.cmbcourse.Items.AddRange(new object[] {
            "القرآن الكريم",
            "الدستور وحقوق الإنسان"});
            this.cmbcourse.Location = new System.Drawing.Point(3, 187);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.PromptText = "اختر مادة الاختبار";
            this.cmbcourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbcourse.Size = new System.Drawing.Size(385, 30);
            this.cmbcourse.TabIndex = 3;
            this.cmbcourse.UseSelectable = true;
            // 
            // txtseatNo
            // 
            // 
            // 
            // 
            this.txtseatNo.CustomButton.Image = null;
            this.txtseatNo.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtseatNo.CustomButton.Name = "";
            this.txtseatNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtseatNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtseatNo.CustomButton.TabIndex = 1;
            this.txtseatNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtseatNo.CustomButton.UseSelectable = true;
            this.txtseatNo.CustomButton.Visible = false;
            this.txtseatNo.Lines = new string[0];
            this.txtseatNo.Location = new System.Drawing.Point(3, 38);
            this.txtseatNo.MaxLength = 32767;
            this.txtseatNo.Multiline = true;
            this.txtseatNo.Name = "txtseatNo";
            this.txtseatNo.PasswordChar = '\0';
            this.txtseatNo.PromptText = "رقم جلوس الطالب";
            this.txtseatNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtseatNo.SelectedText = "";
            this.txtseatNo.SelectionLength = 0;
            this.txtseatNo.SelectionStart = 0;
            this.txtseatNo.ShortcutsEnabled = true;
            this.txtseatNo.Size = new System.Drawing.Size(385, 25);
            this.txtseatNo.TabIndex = 6;
            this.txtseatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtseatNo.UseSelectable = true;
            this.txtseatNo.WaterMark = "رقم جلوس الطالب";
            this.txtseatNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtseatNo.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // btnprintqarar
            // 
            this.btnprintqarar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprintqarar.Location = new System.Drawing.Point(198, 519);
            this.btnprintqarar.Name = "btnprintqarar";
            this.btnprintqarar.Size = new System.Drawing.Size(113, 29);
            this.btnprintqarar.Style = MetroFramework.MetroColorStyle.Black;
            this.btnprintqarar.TabIndex = 8;
            this.btnprintqarar.Text = "طباعة قرار الحرمان";
            this.btnprintqarar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnprintqarar.UseCustomForeColor = true;
            this.btnprintqarar.UseSelectable = true;
            this.btnprintqarar.UseStyleColors = true;
            // 
            // btnprintgolaph
            // 
            this.btnprintgolaph.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprintgolaph.Location = new System.Drawing.Point(77, 519);
            this.btnprintgolaph.Name = "btnprintgolaph";
            this.btnprintgolaph.Size = new System.Drawing.Size(115, 29);
            this.btnprintgolaph.Style = MetroFramework.MetroColorStyle.Black;
            this.btnprintgolaph.TabIndex = 8;
            this.btnprintgolaph.Text = "غلاف ورقة مسحوبة";
            this.btnprintgolaph.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnprintgolaph.UseCustomForeColor = true;
            this.btnprintgolaph.UseSelectable = true;
            this.btnprintgolaph.UseStyleColors = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(394, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "اسم الطالب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(3, 76);
            this.txtname.MaxLength = 32767;
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PromptText = "اسم الطالب";
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(385, 25);
            this.txtname.TabIndex = 10;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.UseSelectable = true;
            this.txtname.WaterMark = "اسم الطالب";
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(393, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "مدرسة الطالب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtschool
            // 
            // 
            // 
            // 
            this.txtschool.CustomButton.Image = null;
            this.txtschool.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtschool.CustomButton.Name = "";
            this.txtschool.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtschool.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtschool.CustomButton.TabIndex = 1;
            this.txtschool.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtschool.CustomButton.UseSelectable = true;
            this.txtschool.CustomButton.Visible = false;
            this.txtschool.Lines = new string[0];
            this.txtschool.Location = new System.Drawing.Point(3, 107);
            this.txtschool.MaxLength = 32767;
            this.txtschool.Multiline = true;
            this.txtschool.Name = "txtschool";
            this.txtschool.PasswordChar = '\0';
            this.txtschool.PromptText = "مدرسة الطالب";
            this.txtschool.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtschool.SelectedText = "";
            this.txtschool.SelectionLength = 0;
            this.txtschool.SelectionStart = 0;
            this.txtschool.ShortcutsEnabled = true;
            this.txtschool.Size = new System.Drawing.Size(385, 25);
            this.txtschool.TabIndex = 12;
            this.txtschool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtschool.UseSelectable = true;
            this.txtschool.WaterMark = "مدرسة الطالب";
            this.txtschool.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtschool.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(394, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "تاريخ الإختبار";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(394, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "مادة الإختبار";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(394, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "نوع الحرمان";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(393, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "رقم قرار الحرمان";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(415, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "تقرير عن الواقعة";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(394, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "يوم الإختبار";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnumherman
            // 
            // 
            // 
            // 
            this.txtnumherman.CustomButton.Image = null;
            this.txtnumherman.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtnumherman.CustomButton.Name = "";
            this.txtnumherman.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtnumherman.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnumherman.CustomButton.TabIndex = 1;
            this.txtnumherman.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnumherman.CustomButton.UseSelectable = true;
            this.txtnumherman.CustomButton.Visible = false;
            this.txtnumherman.Lines = new string[0];
            this.txtnumherman.Location = new System.Drawing.Point(3, 357);
            this.txtnumherman.MaxLength = 32767;
            this.txtnumherman.Multiline = true;
            this.txtnumherman.Name = "txtnumherman";
            this.txtnumherman.PasswordChar = '\0';
            this.txtnumherman.PromptText = "رقم قرار الحرمان";
            this.txtnumherman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnumherman.SelectedText = "";
            this.txtnumherman.SelectionLength = 0;
            this.txtnumherman.SelectionStart = 0;
            this.txtnumherman.ShortcutsEnabled = true;
            this.txtnumherman.Size = new System.Drawing.Size(406, 29);
            this.txtnumherman.TabIndex = 15;
            this.txtnumherman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumherman.UseSelectable = true;
            this.txtnumherman.WaterMark = "رقم قرار الحرمان";
            this.txtnumherman.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnumherman.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // txtreport
            // 
            this.txtreport.AllowDrop = true;
            // 
            // 
            // 
            this.txtreport.CustomButton.Image = null;
            this.txtreport.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.txtreport.CustomButton.Name = "";
            this.txtreport.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.txtreport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtreport.CustomButton.TabIndex = 1;
            this.txtreport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtreport.CustomButton.UseSelectable = true;
            this.txtreport.CustomButton.Visible = false;
            this.txtreport.Lines = new string[0];
            this.txtreport.Location = new System.Drawing.Point(3, 392);
            this.txtreport.MaxLength = 32767;
            this.txtreport.Multiline = true;
            this.txtreport.Name = "txtreport";
            this.txtreport.PasswordChar = '\0';
            this.txtreport.PromptText = "اكتب تقرير";
            this.txtreport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtreport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtreport.SelectedText = "";
            this.txtreport.SelectionLength = 0;
            this.txtreport.SelectionStart = 0;
            this.txtreport.ShortcutsEnabled = true;
            this.txtreport.Size = new System.Drawing.Size(406, 108);
            this.txtreport.TabIndex = 15;
            this.txtreport.UseSelectable = true;
            this.txtreport.WaterMark = "اكتب تقرير";
            this.txtreport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtreport.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(758, 291);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.PromptText = "تاريخ الإختبار";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(303, 25);
            this.txtDate.TabIndex = 16;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMark = "تاريخ الإختبار";
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // txtDay
            // 
            // 
            // 
            // 
            this.txtDay.CustomButton.Image = null;
            this.txtDay.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.txtDay.CustomButton.Name = "";
            this.txtDay.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDay.CustomButton.TabIndex = 1;
            this.txtDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDay.CustomButton.UseSelectable = true;
            this.txtDay.CustomButton.Visible = false;
            this.txtDay.Lines = new string[0];
            this.txtDay.Location = new System.Drawing.Point(3, 252);
            this.txtDay.MaxLength = 32767;
            this.txtDay.Multiline = true;
            this.txtDay.Name = "txtDay";
            this.txtDay.PasswordChar = '\0';
            this.txtDay.PromptText = "يوم الإختبار";
            this.txtDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDay.SelectedText = "";
            this.txtDay.SelectionLength = 0;
            this.txtDay.SelectionStart = 0;
            this.txtDay.ShortcutsEnabled = true;
            this.txtDay.Size = new System.Drawing.Size(385, 29);
            this.txtDay.TabIndex = 17;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.UseSelectable = true;
            this.txtDay.WaterMark = "يوم الإختبار";
            this.txtDay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDay.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.reportTypesBindingSource;
            this.cmbType.DisplayMember = "description";
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 24;
            this.cmbType.Location = new System.Drawing.Point(3, 284);
            this.cmbType.Name = "cmbType";
            this.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbType.Size = new System.Drawing.Size(385, 30);
            this.cmbType.TabIndex = 18;
            this.cmbType.UseSelectable = true;
            this.cmbType.ValueMember = "Id";
            // 
            // metroButton3
            // 
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroButton3.Location = new System.Drawing.Point(317, 519);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(92, 29);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton3.TabIndex = 19;
            this.metroButton3.Text = "مسح البيانات";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            // 
            // seerTxt
            // 
            // 
            // 
            // 
            this.seerTxt.CustomButton.Image = null;
            this.seerTxt.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.seerTxt.CustomButton.Name = "";
            this.seerTxt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.seerTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seerTxt.CustomButton.TabIndex = 1;
            this.seerTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seerTxt.CustomButton.UseSelectable = true;
            this.seerTxt.CustomButton.Visible = false;
            this.seerTxt.Lines = new string[0];
            this.seerTxt.Location = new System.Drawing.Point(3, 134);
            this.seerTxt.MaxLength = 32767;
            this.seerTxt.Multiline = true;
            this.seerTxt.Name = "seerTxt";
            this.seerTxt.PasswordChar = '\0';
            this.seerTxt.PromptText = "لجنة السير";
            this.seerTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seerTxt.SelectedText = "";
            this.seerTxt.SelectionLength = 0;
            this.seerTxt.SelectionStart = 0;
            this.seerTxt.ShortcutsEnabled = true;
            this.seerTxt.Size = new System.Drawing.Size(385, 25);
            this.seerTxt.TabIndex = 20;
            this.seerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seerTxt.UseSelectable = true;
            this.seerTxt.WaterMark = "لجنة السير";
            this.seerTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seerTxt.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(393, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "لجنة السير";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regionText
            // 
            // 
            // 
            // 
            this.regionText.CustomButton.Image = null;
            this.regionText.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.regionText.CustomButton.Name = "";
            this.regionText.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.regionText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.regionText.CustomButton.TabIndex = 1;
            this.regionText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regionText.CustomButton.UseSelectable = true;
            this.regionText.CustomButton.Visible = false;
            this.regionText.Lines = new string[0];
            this.regionText.Location = new System.Drawing.Point(3, 162);
            this.regionText.MaxLength = 32767;
            this.regionText.Multiline = true;
            this.regionText.Name = "regionText";
            this.regionText.PasswordChar = '\0';
            this.regionText.PromptText = "المنطقة";
            this.regionText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.regionText.SelectedText = "";
            this.regionText.SelectionLength = 0;
            this.regionText.SelectionStart = 0;
            this.regionText.ShortcutsEnabled = true;
            this.regionText.Size = new System.Drawing.Size(385, 25);
            this.regionText.TabIndex = 19;
            this.regionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regionText.UseSelectable = true;
            this.regionText.WaterMark = "المنطقة";
            this.regionText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.regionText.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // subjectStaticsmetroButton
            // 
            this.subjectStaticsmetroButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subjectStaticsmetroButton.Location = new System.Drawing.Point(415, 519);
            this.subjectStaticsmetroButton.Name = "subjectStaticsmetroButton";
            this.subjectStaticsmetroButton.Size = new System.Drawing.Size(94, 29);
            this.subjectStaticsmetroButton.Style = MetroFramework.MetroColorStyle.Black;
            this.subjectStaticsmetroButton.TabIndex = 23;
            this.subjectStaticsmetroButton.Text = "احصائية ";
            this.subjectStaticsmetroButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.subjectStaticsmetroButton.UseCustomForeColor = true;
            this.subjectStaticsmetroButton.UseSelectable = true;
            this.subjectStaticsmetroButton.UseStyleColors = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(393, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "المنطقة التعليمية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(309, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "نوع الورقة المسحوبة";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            " اختر نوع الورقة",
            "حرمان مجال دراسي ",
            "حرمان جميع المجالات الدراسية",
            "حرمان نهائي "});
            this.metroComboBox1.Location = new System.Drawing.Point(3, 319);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "نوع الورقة المسحوبة";
            this.metroComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroComboBox1.Size = new System.Drawing.Size(314, 30);
            this.metroComboBox1.TabIndex = 25;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(85, 561);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "نوع القرار";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(303, 25);
            this.metroTextBox1.TabIndex = 26;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMark = "نوع القرار";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(599, 609);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // seatnoDataGridViewTextBoxColumn
            // 
            this.seatnoDataGridViewTextBoxColumn.DataPropertyName = "seatno";
            this.seatnoDataGridViewTextBoxColumn.HeaderText = "رقم جلوس";
            this.seatnoDataGridViewTextBoxColumn.Name = "seatnoDataGridViewTextBoxColumn";
            // 
            // stnameDataGridViewTextBoxColumn
            // 
            this.stnameDataGridViewTextBoxColumn.DataPropertyName = "stname";
            this.stnameDataGridViewTextBoxColumn.HeaderText = "اسم الطالب";
            this.stnameDataGridViewTextBoxColumn.Name = "stnameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Visible = false;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "cid";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Visible = false;
            // 
            // typecodeDataGridViewTextBoxColumn
            // 
            this.typecodeDataGridViewTextBoxColumn.DataPropertyName = "typecode";
            this.typecodeDataGridViewTextBoxColumn.HeaderText = "typecode";
            this.typecodeDataGridViewTextBoxColumn.Name = "typecodeDataGridViewTextBoxColumn";
            this.typecodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "typename";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "typename";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "school";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "كود المدرسة";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.Visible = false;
            // 
            // scnameDataGridViewTextBoxColumn
            // 
            this.scnameDataGridViewTextBoxColumn.DataPropertyName = "scname";
            this.scnameDataGridViewTextBoxColumn.HeaderText = "المدرسة";
            this.scnameDataGridViewTextBoxColumn.Name = "scnameDataGridViewTextBoxColumn";
            // 
            // seercodeDataGridViewTextBoxColumn
            // 
            this.seercodeDataGridViewTextBoxColumn.DataPropertyName = "seercode";
            this.seercodeDataGridViewTextBoxColumn.HeaderText = "seercode";
            this.seercodeDataGridViewTextBoxColumn.Name = "seercodeDataGridViewTextBoxColumn";
            this.seercodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // scidDataGridViewTextBoxColumn
            // 
            this.scidDataGridViewTextBoxColumn.DataPropertyName = "scid";
            this.scidDataGridViewTextBoxColumn.HeaderText = "scid";
            this.scidDataGridViewTextBoxColumn.Name = "scidDataGridViewTextBoxColumn";
            this.scidDataGridViewTextBoxColumn.Visible = false;
            // 
            // examscnameDataGridViewTextBoxColumn
            // 
            this.examscnameDataGridViewTextBoxColumn.DataPropertyName = "examscname";
            this.examscnameDataGridViewTextBoxColumn.HeaderText = "لجنة السير";
            this.examscnameDataGridViewTextBoxColumn.Name = "examscnameDataGridViewTextBoxColumn";
            // 
            // examScidDataGridViewTextBoxColumn
            // 
            this.examScidDataGridViewTextBoxColumn.DataPropertyName = "examScid";
            this.examScidDataGridViewTextBoxColumn.HeaderText = "examScid";
            this.examScidDataGridViewTextBoxColumn.Name = "examScidDataGridViewTextBoxColumn";
            this.examScidDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeadescDataGridViewTextBoxColumn
            // 
            this.typeadescDataGridViewTextBoxColumn.DataPropertyName = "type_adesc";
            this.typeadescDataGridViewTextBoxColumn.HeaderText = "type_adesc";
            this.typeadescDataGridViewTextBoxColumn.Name = "typeadescDataGridViewTextBoxColumn";
            this.typeadescDataGridViewTextBoxColumn.Visible = false;
            // 
            // sttypeDataGridViewTextBoxColumn
            // 
            this.sttypeDataGridViewTextBoxColumn.DataPropertyName = "st_type";
            this.sttypeDataGridViewTextBoxColumn.HeaderText = "st_type";
            this.sttypeDataGridViewTextBoxColumn.Name = "sttypeDataGridViewTextBoxColumn";
            this.sttypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // shows
            // 
            this.shows.FillWeight = 30F;
            this.shows.HeaderText = "عرض";
            this.shows.Image = ((System.Drawing.Image)(resources.GetObject("shows.Image")));
            this.shows.MinimumWidth = 6;
            this.shows.Name = "shows";
            this.shows.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // del
            // 
            this.del.FillWeight = 30F;
            this.del.HeaderText = "حذف";
            this.del.Image = ((System.Drawing.Image)(resources.GetObject("del.Image")));
            this.del.MinimumWidth = 6;
            this.del.Name = "del";
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // stType
            // 
            // 
            // 
            // 
            this.stType.CustomButton.Image = null;
            this.stType.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.stType.CustomButton.Name = "";
            this.stType.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.stType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.stType.CustomButton.TabIndex = 1;
            this.stType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.stType.CustomButton.UseSelectable = true;
            this.stType.CustomButton.Visible = false;
            this.stType.Lines = new string[0];
            this.stType.Location = new System.Drawing.Point(802, 19);
            this.stType.MaxLength = 32767;
            this.stType.Multiline = true;
            this.stType.Name = "stType";
            this.stType.PasswordChar = '\0';
            this.stType.PromptText = "رقم نوع التعليم";
            this.stType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stType.SelectedText = "";
            this.stType.SelectionLength = 0;
            this.stType.SelectionStart = 0;
            this.stType.ShortcutsEnabled = true;
            this.stType.Size = new System.Drawing.Size(144, 25);
            this.stType.TabIndex = 21;
            this.stType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stType.UseSelectable = true;
            this.stType.Visible = false;
            this.stType.WaterMark = "رقم نوع التعليم";
            this.stType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.stType.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // typedesc
            // 
            // 
            // 
            // 
            this.typedesc.CustomButton.Image = null;
            this.typedesc.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.typedesc.CustomButton.Name = "";
            this.typedesc.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.typedesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.typedesc.CustomButton.TabIndex = 1;
            this.typedesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.typedesc.CustomButton.UseSelectable = true;
            this.typedesc.CustomButton.Visible = false;
            this.typedesc.Lines = new string[0];
            this.typedesc.Location = new System.Drawing.Point(1102, 19);
            this.typedesc.MaxLength = 32767;
            this.typedesc.Multiline = true;
            this.typedesc.Name = "typedesc";
            this.typedesc.PasswordChar = '\0';
            this.typedesc.PromptText = "نوع التعليم";
            this.typedesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.typedesc.SelectedText = "";
            this.typedesc.SelectionLength = 0;
            this.typedesc.SelectionStart = 0;
            this.typedesc.ShortcutsEnabled = true;
            this.typedesc.Size = new System.Drawing.Size(144, 25);
            this.typedesc.TabIndex = 20;
            this.typedesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typedesc.UseSelectable = true;
            this.typedesc.Visible = false;
            this.typedesc.WaterMark = "نوع التعليم";
            this.typedesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typedesc.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // lagnaNumTxt
            // 
            // 
            // 
            // 
            this.lagnaNumTxt.CustomButton.Image = null;
            this.lagnaNumTxt.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.lagnaNumTxt.CustomButton.Name = "";
            this.lagnaNumTxt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.lagnaNumTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lagnaNumTxt.CustomButton.TabIndex = 1;
            this.lagnaNumTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lagnaNumTxt.CustomButton.UseSelectable = true;
            this.lagnaNumTxt.CustomButton.Visible = false;
            this.lagnaNumTxt.Lines = new string[0];
            this.lagnaNumTxt.Location = new System.Drawing.Point(952, 19);
            this.lagnaNumTxt.MaxLength = 32767;
            this.lagnaNumTxt.Multiline = true;
            this.lagnaNumTxt.Name = "lagnaNumTxt";
            this.lagnaNumTxt.PasswordChar = '\0';
            this.lagnaNumTxt.PromptText = "رقم لجنة السير";
            this.lagnaNumTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lagnaNumTxt.SelectedText = "";
            this.lagnaNumTxt.SelectionLength = 0;
            this.lagnaNumTxt.SelectionStart = 0;
            this.lagnaNumTxt.ShortcutsEnabled = true;
            this.lagnaNumTxt.Size = new System.Drawing.Size(144, 25);
            this.lagnaNumTxt.TabIndex = 19;
            this.lagnaNumTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lagnaNumTxt.UseSelectable = true;
            this.lagnaNumTxt.WaterMark = "رقم لجنة السير";
            this.lagnaNumTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lagnaNumTxt.WaterMarkFont = new System.Drawing.Font("Tahoma", 10F);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 224);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(385, 22);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // reportTypesBindingSource
            // 
            this.reportTypesBindingSource.DataMember = "reportTypes";
            this.reportTypesBindingSource.DataSource = this.dataDataSet;
            // 
            // reportTypesTableAdapter
            // 
            this.reportTypesTableAdapter.ClearBeforeFill = true;
            // 
            // ouside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 687);
            this.Controls.Add(this.typedesc);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lagnaNumTxt);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.stType);
            this.Controls.Add(this.devgrid);
            this.Controls.Add(this.txtDate);
            this.Name = "ouside";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ouside";
            this.Load += new System.EventHandler(this.ouside_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView devgrid;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource studentDataBindingSource;
        private dataDataSetTableAdapters.studentDataTableAdapter studentDataTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroButton subjectStaticsmetroButton;
        private MetroFramework.Controls.MetroTextBox regionText;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox seerTxt;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroTextBox txtDay;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private MetroFramework.Controls.MetroTextBox txtreport;
        private MetroFramework.Controls.MetroTextBox txtnumherman;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtschool;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtname;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnprintgolaph;
        private MetroFramework.Controls.MetroButton btnprintqarar;
        private MetroFramework.Controls.MetroTextBox txtseatNo;
        private MetroFramework.Controls.MetroComboBox cmbcourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seercodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examscnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examScidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeadescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn shows;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private MetroFramework.Controls.MetroTextBox stType;
        private MetroFramework.Controls.MetroTextBox typedesc;
        private MetroFramework.Controls.MetroTextBox lagnaNumTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource reportTypesBindingSource;
        private dataDataSetTableAdapters.reportTypesTableAdapter reportTypesTableAdapter;
    }
}