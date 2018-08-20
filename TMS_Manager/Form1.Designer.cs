namespace TMS_Manager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcelToDB = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnFTP = new System.Windows.Forms.Button();
            this.lblDBPath = new System.Windows.Forms.Label();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbTreeType = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLine = new System.Windows.Forms.ComboBox();
            this.dgvTree = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTfloreDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDfloreDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fruitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earlyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSubCondition = new System.Windows.Forms.ComboBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveInit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txt_SectionNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_lineNo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.lblQRContents = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreateQR_Contents = new System.Windows.Forms.Button();
            this.btnSelectQRSavePath = new System.Windows.Forms.Button();
            this.btnCreateQR_AutoIncrease = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQRSavePath = new System.Windows.Forms.TextBox();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.txtQRContents = new System.Windows.Forms.TextBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTreeNoInc = new System.Windows.Forms.TextBox();
            this.cmbSection2 = new System.Windows.Forms.ComboBox();
            this.cmbLine2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeInfoBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardInfoBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnExcelToDB, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpload, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnFTP, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDBPath, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpenDB, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(993, 44);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnExcelToDB
            // 
            this.btnExcelToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.btnExcelToDB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcelToDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcelToDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnExcelToDB.FlatAppearance.BorderSize = 0;
            this.btnExcelToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelToDB.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnExcelToDB.ForeColor = System.Drawing.Color.Black;
            this.btnExcelToDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcelToDB.Location = new System.Drawing.Point(596, 2);
            this.btnExcelToDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelToDB.Name = "btnExcelToDB";
            this.btnExcelToDB.Size = new System.Drawing.Size(194, 40);
            this.btnExcelToDB.TabIndex = 23;
            this.btnExcelToDB.TabStop = false;
            this.btnExcelToDB.Text = "엑셀 파일로부터 변환";
            this.btnExcelToDB.UseVisualStyleBackColor = false;
            this.btnExcelToDB.Click += new System.EventHandler(this.btnExcelToDB_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(195)))), ((int)(((byte)(124)))));
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpload.Location = new System.Drawing.Point(398, 2);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(194, 40);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.TabStop = false;
            this.btnUpload.Text = "현재 DB 업로드";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnFTP
            // 
            this.btnFTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(113)))), ((int)(((byte)(93)))));
            this.btnFTP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFTP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnFTP.FlatAppearance.BorderSize = 0;
            this.btnFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFTP.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnFTP.ForeColor = System.Drawing.Color.Black;
            this.btnFTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFTP.Location = new System.Drawing.Point(200, 2);
            this.btnFTP.Margin = new System.Windows.Forms.Padding(2);
            this.btnFTP.Name = "btnFTP";
            this.btnFTP.Size = new System.Drawing.Size(194, 40);
            this.btnFTP.TabIndex = 21;
            this.btnFTP.TabStop = false;
            this.btnFTP.Text = "FTP 다운로드";
            this.btnFTP.UseVisualStyleBackColor = false;
            this.btnFTP.Click += new System.EventHandler(this.btnFTP_Click);
            // 
            // lblDBPath
            // 
            this.lblDBPath.AutoSize = true;
            this.lblDBPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDBPath.Location = new System.Drawing.Point(795, 0);
            this.lblDBPath.Name = "lblDBPath";
            this.lblDBPath.Size = new System.Drawing.Size(195, 44);
            this.lblDBPath.TabIndex = 20;
            this.lblDBPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.BackColor = System.Drawing.Color.Purple;
            this.btnOpenDB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpenDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnOpenDB.FlatAppearance.BorderSize = 0;
            this.btnOpenDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDB.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnOpenDB.ForeColor = System.Drawing.Color.White;
            this.btnOpenDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenDB.Location = new System.Drawing.Point(2, 2);
            this.btnOpenDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(194, 40);
            this.btnOpenDB.TabIndex = 19;
            this.btnOpenDB.TabStop = false;
            this.btnOpenDB.Text = "DB파일 열기";
            this.btnOpenDB.UseVisualStyleBackColor = false;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbTreeType, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbSection, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbLine, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(650, 36);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 30);
            this.btnSave.TabIndex = 26;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "엑셀 저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTreeType
            // 
            this.cmbTreeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTreeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTreeType.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbTreeType.FormattingEnabled = true;
            this.cmbTreeType.Location = new System.Drawing.Point(489, 37);
            this.cmbTreeType.Name = "cmbTreeType";
            this.cmbTreeType.Size = new System.Drawing.Size(156, 24);
            this.cmbTreeType.TabIndex = 25;
            // 
            // cmbSection
            // 
            this.cmbSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(489, 3);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(156, 24);
            this.cmbSection.TabIndex = 23;
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(159)))));
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(650, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "검 색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "라인번호 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(327, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "구역번호 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(327, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "품종 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLine
            // 
            this.cmbLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLine.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbLine.FormattingEnabled = true;
            this.cmbLine.Location = new System.Drawing.Point(165, 3);
            this.cmbLine.Name = "cmbLine";
            this.cmbLine.Size = new System.Drawing.Size(156, 24);
            this.cmbLine.TabIndex = 22;
            // 
            // dgvTree
            // 
            this.dgvTree.AllowUserToAddRows = false;
            this.dgvTree.AllowUserToDeleteRows = false;
            this.dgvTree.AllowUserToResizeRows = false;
            this.dgvTree.AutoGenerateColumns = false;
            this.dgvTree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.lineNoDataGridViewTextBoxColumn,
            this.sectionNoDataGridViewTextBoxColumn,
            this.treeNoDataGridViewTextBoxColumn,
            this.treeTypeDataGridViewTextBoxColumn,
            this.sTfloreDateDataGridViewTextBoxColumn,
            this.eDfloreDateDataGridViewTextBoxColumn,
            this.fruitDateDataGridViewTextBoxColumn,
            this.countDegDataGridViewTextBoxColumn,
            this.countLevelDataGridViewTextBoxColumn,
            this.earlyAmountDataGridViewTextBoxColumn,
            this.colorDateDataGridViewTextBoxColumn,
            this.colorLevelDataGridViewTextBoxColumn,
            this.harvestDateDataGridViewTextBoxColumn,
            this.postAmountDataGridViewTextBoxColumn,
            this.tPADataGridViewTextBoxColumn,
            this.tPBDataGridViewTextBoxColumn,
            this.tPCDataGridViewTextBoxColumn,
            this.tPDDataGridViewTextBoxColumn,
            this.diseaseDateDataGridViewTextBoxColumn,
            this.diseaseNameDataGridViewTextBoxColumn,
            this.bugDateDataGridViewTextBoxColumn,
            this.bugNameDataGridViewTextBoxColumn,
            this.periodDateDataGridViewTextBoxColumn,
            this.periodNameDataGridViewTextBoxColumn});
            this.dgvTree.DataSource = this.treeInfoBindingSource;
            this.dgvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTree.Location = new System.Drawing.Point(3, 108);
            this.dgvTree.MultiSelect = false;
            this.dgvTree.Name = "dgvTree";
            this.dgvTree.ReadOnly = true;
            this.dgvTree.RowHeadersVisible = false;
            this.dgvTree.RowTemplate.Height = 23;
            this.dgvTree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTree.Size = new System.Drawing.Size(973, 465);
            this.dgvTree.TabIndex = 3;
            this.dgvTree.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTree_CellMouseDoubleClick);
            this.dgvTree.SelectionChanged += new System.EventHandler(this.dgvTree_SelectionChanged);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.DataPropertyName = "idx";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle2;
            this.No.FillWeight = 45F;
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 45;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 45;
            // 
            // lineNoDataGridViewTextBoxColumn
            // 
            this.lineNoDataGridViewTextBoxColumn.DataPropertyName = "LineNo";
            this.lineNoDataGridViewTextBoxColumn.HeaderText = "라인번호";
            this.lineNoDataGridViewTextBoxColumn.Name = "lineNoDataGridViewTextBoxColumn";
            this.lineNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineNoDataGridViewTextBoxColumn.Width = 78;
            // 
            // sectionNoDataGridViewTextBoxColumn
            // 
            this.sectionNoDataGridViewTextBoxColumn.DataPropertyName = "SectionNo";
            this.sectionNoDataGridViewTextBoxColumn.HeaderText = "섹션번호";
            this.sectionNoDataGridViewTextBoxColumn.Name = "sectionNoDataGridViewTextBoxColumn";
            this.sectionNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNoDataGridViewTextBoxColumn.Width = 78;
            // 
            // treeNoDataGridViewTextBoxColumn
            // 
            this.treeNoDataGridViewTextBoxColumn.DataPropertyName = "TreeNo";
            this.treeNoDataGridViewTextBoxColumn.HeaderText = "과수번호";
            this.treeNoDataGridViewTextBoxColumn.Name = "treeNoDataGridViewTextBoxColumn";
            this.treeNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.treeNoDataGridViewTextBoxColumn.Width = 78;
            // 
            // treeTypeDataGridViewTextBoxColumn
            // 
            this.treeTypeDataGridViewTextBoxColumn.DataPropertyName = "TreeType";
            this.treeTypeDataGridViewTextBoxColumn.HeaderText = "품종";
            this.treeTypeDataGridViewTextBoxColumn.Name = "treeTypeDataGridViewTextBoxColumn";
            this.treeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.treeTypeDataGridViewTextBoxColumn.Width = 54;
            // 
            // sTfloreDateDataGridViewTextBoxColumn
            // 
            this.sTfloreDateDataGridViewTextBoxColumn.DataPropertyName = "ST_floreDate";
            this.sTfloreDateDataGridViewTextBoxColumn.HeaderText = "개화시작일자";
            this.sTfloreDateDataGridViewTextBoxColumn.Name = "sTfloreDateDataGridViewTextBoxColumn";
            this.sTfloreDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTfloreDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // eDfloreDateDataGridViewTextBoxColumn
            // 
            this.eDfloreDateDataGridViewTextBoxColumn.DataPropertyName = "ED_floreDate";
            this.eDfloreDateDataGridViewTextBoxColumn.HeaderText = "개화종료일자";
            this.eDfloreDateDataGridViewTextBoxColumn.Name = "eDfloreDateDataGridViewTextBoxColumn";
            this.eDfloreDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDfloreDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // fruitDateDataGridViewTextBoxColumn
            // 
            this.fruitDateDataGridViewTextBoxColumn.DataPropertyName = "FruitDate";
            this.fruitDateDataGridViewTextBoxColumn.HeaderText = "결실처리일";
            this.fruitDateDataGridViewTextBoxColumn.Name = "fruitDateDataGridViewTextBoxColumn";
            this.fruitDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fruitDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // countDegDataGridViewTextBoxColumn
            // 
            this.countDegDataGridViewTextBoxColumn.DataPropertyName = "CountDeg";
            this.countDegDataGridViewTextBoxColumn.HeaderText = "초기평균착립수";
            this.countDegDataGridViewTextBoxColumn.Name = "countDegDataGridViewTextBoxColumn";
            this.countDegDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDegDataGridViewTextBoxColumn.Width = 114;
            // 
            // countLevelDataGridViewTextBoxColumn
            // 
            this.countLevelDataGridViewTextBoxColumn.DataPropertyName = "CountLevel";
            this.countLevelDataGridViewTextBoxColumn.HeaderText = "무핵탈립성";
            this.countLevelDataGridViewTextBoxColumn.Name = "countLevelDataGridViewTextBoxColumn";
            this.countLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.countLevelDataGridViewTextBoxColumn.Width = 90;
            // 
            // earlyAmountDataGridViewTextBoxColumn
            // 
            this.earlyAmountDataGridViewTextBoxColumn.DataPropertyName = "EarlyAmount";
            this.earlyAmountDataGridViewTextBoxColumn.HeaderText = "초기착과량";
            this.earlyAmountDataGridViewTextBoxColumn.Name = "earlyAmountDataGridViewTextBoxColumn";
            this.earlyAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.earlyAmountDataGridViewTextBoxColumn.Width = 90;
            // 
            // colorDateDataGridViewTextBoxColumn
            // 
            this.colorDateDataGridViewTextBoxColumn.DataPropertyName = "ColorDate";
            this.colorDateDataGridViewTextBoxColumn.HeaderText = "착색일자";
            this.colorDateDataGridViewTextBoxColumn.Name = "colorDateDataGridViewTextBoxColumn";
            this.colorDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // colorLevelDataGridViewTextBoxColumn
            // 
            this.colorLevelDataGridViewTextBoxColumn.DataPropertyName = "ColorLevel";
            this.colorLevelDataGridViewTextBoxColumn.HeaderText = "착색도";
            this.colorLevelDataGridViewTextBoxColumn.Name = "colorLevelDataGridViewTextBoxColumn";
            this.colorLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorLevelDataGridViewTextBoxColumn.Width = 66;
            // 
            // harvestDateDataGridViewTextBoxColumn
            // 
            this.harvestDateDataGridViewTextBoxColumn.DataPropertyName = "HarvestDate";
            this.harvestDateDataGridViewTextBoxColumn.HeaderText = "수확개시일";
            this.harvestDateDataGridViewTextBoxColumn.Name = "harvestDateDataGridViewTextBoxColumn";
            this.harvestDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.harvestDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // postAmountDataGridViewTextBoxColumn
            // 
            this.postAmountDataGridViewTextBoxColumn.DataPropertyName = "PostAmount";
            this.postAmountDataGridViewTextBoxColumn.HeaderText = "후기착과량";
            this.postAmountDataGridViewTextBoxColumn.Name = "postAmountDataGridViewTextBoxColumn";
            this.postAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.postAmountDataGridViewTextBoxColumn.Width = 90;
            // 
            // tPADataGridViewTextBoxColumn
            // 
            this.tPADataGridViewTextBoxColumn.DataPropertyName = "TP_A";
            this.tPADataGridViewTextBoxColumn.HeaderText = "A등급";
            this.tPADataGridViewTextBoxColumn.Name = "tPADataGridViewTextBoxColumn";
            this.tPADataGridViewTextBoxColumn.ReadOnly = true;
            this.tPADataGridViewTextBoxColumn.Width = 62;
            // 
            // tPBDataGridViewTextBoxColumn
            // 
            this.tPBDataGridViewTextBoxColumn.DataPropertyName = "TP_B";
            this.tPBDataGridViewTextBoxColumn.HeaderText = "B등급";
            this.tPBDataGridViewTextBoxColumn.Name = "tPBDataGridViewTextBoxColumn";
            this.tPBDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPBDataGridViewTextBoxColumn.Width = 62;
            // 
            // tPCDataGridViewTextBoxColumn
            // 
            this.tPCDataGridViewTextBoxColumn.DataPropertyName = "TP_C";
            this.tPCDataGridViewTextBoxColumn.HeaderText = "C등급";
            this.tPCDataGridViewTextBoxColumn.Name = "tPCDataGridViewTextBoxColumn";
            this.tPCDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPCDataGridViewTextBoxColumn.Width = 63;
            // 
            // tPDDataGridViewTextBoxColumn
            // 
            this.tPDDataGridViewTextBoxColumn.DataPropertyName = "TP_D";
            this.tPDDataGridViewTextBoxColumn.HeaderText = "D등급";
            this.tPDDataGridViewTextBoxColumn.Name = "tPDDataGridViewTextBoxColumn";
            this.tPDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPDDataGridViewTextBoxColumn.Width = 62;
            // 
            // diseaseDateDataGridViewTextBoxColumn
            // 
            this.diseaseDateDataGridViewTextBoxColumn.DataPropertyName = "DiseaseDate";
            this.diseaseDateDataGridViewTextBoxColumn.HeaderText = "발병일자";
            this.diseaseDateDataGridViewTextBoxColumn.Name = "diseaseDateDataGridViewTextBoxColumn";
            this.diseaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // diseaseNameDataGridViewTextBoxColumn
            // 
            this.diseaseNameDataGridViewTextBoxColumn.DataPropertyName = "DiseaseName";
            this.diseaseNameDataGridViewTextBoxColumn.HeaderText = "병명";
            this.diseaseNameDataGridViewTextBoxColumn.Name = "diseaseNameDataGridViewTextBoxColumn";
            this.diseaseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.diseaseNameDataGridViewTextBoxColumn.Width = 54;
            // 
            // bugDateDataGridViewTextBoxColumn
            // 
            this.bugDateDataGridViewTextBoxColumn.DataPropertyName = "BugDate";
            this.bugDateDataGridViewTextBoxColumn.HeaderText = "해충일자";
            this.bugDateDataGridViewTextBoxColumn.Name = "bugDateDataGridViewTextBoxColumn";
            this.bugDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bugDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // bugNameDataGridViewTextBoxColumn
            // 
            this.bugNameDataGridViewTextBoxColumn.DataPropertyName = "BugName";
            this.bugNameDataGridViewTextBoxColumn.HeaderText = "해충명";
            this.bugNameDataGridViewTextBoxColumn.Name = "bugNameDataGridViewTextBoxColumn";
            this.bugNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bugNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // periodDateDataGridViewTextBoxColumn
            // 
            this.periodDateDataGridViewTextBoxColumn.DataPropertyName = "PeriodDate";
            this.periodDateDataGridViewTextBoxColumn.HeaderText = "장해일자";
            this.periodDateDataGridViewTextBoxColumn.Name = "periodDateDataGridViewTextBoxColumn";
            this.periodDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // periodNameDataGridViewTextBoxColumn
            // 
            this.periodNameDataGridViewTextBoxColumn.DataPropertyName = "PeriodName";
            this.periodNameDataGridViewTextBoxColumn.HeaderText = "장해명";
            this.periodNameDataGridViewTextBoxColumn.Name = "periodNameDataGridViewTextBoxColumn";
            this.periodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodNameDataGridViewTextBoxColumn.Width = 66;
            // 
            // treeInfoBindingSource
            // 
            this.treeInfoBindingSource.DataSource = typeof(TMS_Manager.TreeInfo);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 664);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 608);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "과수 정보";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dgvTree, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(979, 576);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.Controls.Add(this.cmbSubCondition, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.cmbCondition, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(979, 35);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // cmbSubCondition
            // 
            this.cmbSubCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSubCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCondition.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbSubCondition.FormattingEnabled = true;
            this.cmbSubCondition.Location = new System.Drawing.Point(393, 3);
            this.cmbSubCondition.Name = "cmbSubCondition";
            this.cmbSubCondition.Size = new System.Drawing.Size(189, 24);
            this.cmbSubCondition.TabIndex = 26;
            // 
            // cmbCondition
            // 
            this.cmbCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Location = new System.Drawing.Point(198, 3);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(189, 24);
            this.cmbCondition.TabIndex = 25;
            this.cmbCondition.SelectedIndexChanged += new System.EventHandler(this.cmbCondition_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 35);
            this.label16.TabIndex = 22;
            this.label16.Text = "기타 조건 검색 :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox1.Location = new System.Drawing.Point(588, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 26);
            this.textBox1.TabIndex = 27;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(985, 582);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "기준 나무 정보";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.986111F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.01389F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(979, 576);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idxDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.diameterDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.colorDegreeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.standardInfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(973, 525);
            this.dataGridView1.TabIndex = 4;
            // 
            // idxDataGridViewTextBoxColumn
            // 
            this.idxDataGridViewTextBoxColumn.DataPropertyName = "idx";
            this.idxDataGridViewTextBoxColumn.HeaderText = "No.";
            this.idxDataGridViewTextBoxColumn.Name = "idxDataGridViewTextBoxColumn";
            this.idxDataGridViewTextBoxColumn.ReadOnly = true;
            this.idxDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "기준ID";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            this.diameterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diameterDataGridViewTextBoxColumn.DataPropertyName = "diameter";
            this.diameterDataGridViewTextBoxColumn.HeaderText = "지름";
            this.diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            this.diameterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "적정착과량";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDegreeDataGridViewTextBoxColumn
            // 
            this.colorDegreeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colorDegreeDataGridViewTextBoxColumn.DataPropertyName = "colorDegree";
            this.colorDegreeDataGridViewTextBoxColumn.HeaderText = "착색도";
            this.colorDegreeDataGridViewTextBoxColumn.Name = "colorDegreeDataGridViewTextBoxColumn";
            this.colorDegreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // standardInfoBindingSource
            // 
            this.standardInfoBindingSource.DataSource = typeof(TMS_Manager.StandardInfo);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "초기 설정 정보";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88585F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.11415F));
            this.tableLayoutPanel5.Controls.Add(this.btnSaveInit, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.txt_SectionNo, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_lineNo, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(438, 154);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnSaveInit
            // 
            this.btnSaveInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(159)))));
            this.btnSaveInit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveInit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnSaveInit.FlatAppearance.BorderSize = 0;
            this.btnSaveInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInit.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnSaveInit.ForeColor = System.Drawing.Color.White;
            this.btnSaveInit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveInit.Location = new System.Drawing.Point(111, 116);
            this.btnSaveInit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveInit.Name = "btnSaveInit";
            this.btnSaveInit.Size = new System.Drawing.Size(325, 36);
            this.btnSaveInit.TabIndex = 26;
            this.btnSaveInit.TabStop = false;
            this.btnSaveInit.Text = "저 장";
            this.btnSaveInit.UseVisualStyleBackColor = false;
            this.btnSaveInit.Click += new System.EventHandler(this.btnSaveInit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("굴림", 15F);
            this.txtEmail.Location = new System.Drawing.Point(112, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 30);
            this.txtEmail.TabIndex = 25;
            // 
            // txt_SectionNo
            // 
            this.txt_SectionNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SectionNo.Font = new System.Drawing.Font("굴림", 15F);
            this.txt_SectionNo.Location = new System.Drawing.Point(112, 41);
            this.txt_SectionNo.Name = "txt_SectionNo";
            this.txt_SectionNo.Size = new System.Drawing.Size(323, 30);
            this.txt_SectionNo.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 38);
            this.label8.TabIndex = 22;
            this.label8.Text = "섹션 수 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "전송 E-Mail :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "라인 수 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_lineNo
            // 
            this.txt_lineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_lineNo.Font = new System.Drawing.Font("굴림", 15F);
            this.txt_lineNo.Location = new System.Drawing.Point(112, 3);
            this.txt_lineNo.Name = "txt_lineNo";
            this.txt_lineNo.Size = new System.Drawing.Size(323, 30);
            this.txt_lineNo.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(985, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "QR코드 생성";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.00558F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.99441F));
            this.tableLayoutPanel6.Controls.Add(this.btnSaveFolder, 2, 6);
            this.tableLayoutPanel6.Controls.Add(this.lblQRContents, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnCreateQR_Contents, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnSelectQRSavePath, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCreateQR_AutoIncrease, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtQRSavePath, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmbResolution, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.cmbSize, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtQRContents, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.pbQR, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(979, 576);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveFolder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaveFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnSaveFolder.FlatAppearance.BorderSize = 0;
            this.btnSaveFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFolder.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveFolder.ForeColor = System.Drawing.Color.White;
            this.btnSaveFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveFolder.Location = new System.Drawing.Point(814, 542);
            this.btnSaveFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(163, 32);
            this.btnSaveFolder.TabIndex = 27;
            this.btnSaveFolder.TabStop = false;
            this.btnSaveFolder.Text = "QR 저장폴더 열기";
            this.btnSaveFolder.UseVisualStyleBackColor = false;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // lblQRContents
            // 
            this.lblQRContents.AutoSize = true;
            this.lblQRContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQRContents.Location = new System.Drawing.Point(103, 540);
            this.lblQRContents.Name = "lblQRContents";
            this.lblQRContents.Size = new System.Drawing.Size(706, 36);
            this.lblQRContents.TabIndex = 26;
            this.lblQRContents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 40);
            this.label12.TabIndex = 24;
            this.label12.Text = "자동증가";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreateQR_Contents
            // 
            this.btnCreateQR_Contents.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreateQR_Contents.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreateQR_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateQR_Contents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnCreateQR_Contents.FlatAppearance.BorderSize = 0;
            this.btnCreateQR_Contents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQR_Contents.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnCreateQR_Contents.ForeColor = System.Drawing.Color.White;
            this.btnCreateQR_Contents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateQR_Contents.Location = new System.Drawing.Point(814, 122);
            this.btnCreateQR_Contents.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateQR_Contents.Name = "btnCreateQR_Contents";
            this.btnCreateQR_Contents.Size = new System.Drawing.Size(163, 36);
            this.btnCreateQR_Contents.TabIndex = 23;
            this.btnCreateQR_Contents.TabStop = false;
            this.btnCreateQR_Contents.Text = "QR생성";
            this.btnCreateQR_Contents.UseVisualStyleBackColor = false;
            this.btnCreateQR_Contents.Click += new System.EventHandler(this.btnCreateQR_Click);
            // 
            // btnSelectQRSavePath
            // 
            this.btnSelectQRSavePath.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelectQRSavePath.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectQRSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectQRSavePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnSelectQRSavePath.FlatAppearance.BorderSize = 0;
            this.btnSelectQRSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectQRSavePath.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnSelectQRSavePath.ForeColor = System.Drawing.Color.White;
            this.btnSelectQRSavePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectQRSavePath.Location = new System.Drawing.Point(814, 2);
            this.btnSelectQRSavePath.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectQRSavePath.Name = "btnSelectQRSavePath";
            this.btnSelectQRSavePath.Size = new System.Drawing.Size(163, 36);
            this.btnSelectQRSavePath.TabIndex = 22;
            this.btnSelectQRSavePath.TabStop = false;
            this.btnSelectQRSavePath.Text = "저장경로";
            this.btnSelectQRSavePath.UseVisualStyleBackColor = false;
            this.btnSelectQRSavePath.Click += new System.EventHandler(this.btnSelectQRSavePath_Click);
            // 
            // btnCreateQR_AutoIncrease
            // 
            this.btnCreateQR_AutoIncrease.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCreateQR_AutoIncrease.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreateQR_AutoIncrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateQR_AutoIncrease.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btnCreateQR_AutoIncrease.FlatAppearance.BorderSize = 0;
            this.btnCreateQR_AutoIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateQR_AutoIncrease.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.btnCreateQR_AutoIncrease.ForeColor = System.Drawing.Color.White;
            this.btnCreateQR_AutoIncrease.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateQR_AutoIncrease.Location = new System.Drawing.Point(814, 162);
            this.btnCreateQR_AutoIncrease.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateQR_AutoIncrease.Name = "btnCreateQR_AutoIncrease";
            this.btnCreateQR_AutoIncrease.Size = new System.Drawing.Size(163, 36);
            this.btnCreateQR_AutoIncrease.TabIndex = 20;
            this.btnCreateQR_AutoIncrease.TabStop = false;
            this.btnCreateQR_AutoIncrease.Text = "자동QR생성";
            this.btnCreateQR_AutoIncrease.UseVisualStyleBackColor = false;
            this.btnCreateQR_AutoIncrease.Click += new System.EventHandler(this.btnCreateQR_AutoIncrease_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "QR코드 크기";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "내용";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "해상도";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 40);
            this.label11.TabIndex = 2;
            this.label11.Text = "저장 경로";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtQRSavePath
            // 
            this.txtQRSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQRSavePath.Font = new System.Drawing.Font("굴림", 12F);
            this.txtQRSavePath.Location = new System.Drawing.Point(103, 3);
            this.txtQRSavePath.Name = "txtQRSavePath";
            this.txtQRSavePath.Size = new System.Drawing.Size(706, 26);
            this.txtQRSavePath.TabIndex = 3;
            // 
            // cmbResolution
            // 
            this.cmbResolution.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(103, 43);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(210, 24);
            this.cmbResolution.TabIndex = 4;
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(103, 83);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(210, 24);
            this.cmbSize.TabIndex = 5;
            // 
            // txtQRContents
            // 
            this.txtQRContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQRContents.Font = new System.Drawing.Font("굴림", 12F);
            this.txtQRContents.Location = new System.Drawing.Point(103, 123);
            this.txtQRContents.Name = "txtQRContents";
            this.txtQRContents.Size = new System.Drawing.Size(706, 26);
            this.txtQRContents.TabIndex = 6;
            // 
            // pbQR
            // 
            this.pbQR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbQR.Location = new System.Drawing.Point(103, 257);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(706, 280);
            this.pbQR.TabIndex = 21;
            this.pbQR.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel7.Controls.Add(this.txtTreeNoInc, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.cmbSection2, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.cmbLine2, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(101, 161);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(710, 38);
            this.tableLayoutPanel7.TabIndex = 25;
            // 
            // txtTreeNoInc
            // 
            this.txtTreeNoInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTreeNoInc.Font = new System.Drawing.Font("굴림", 12F);
            this.txtTreeNoInc.Location = new System.Drawing.Point(561, 3);
            this.txtTreeNoInc.Name = "txtTreeNoInc";
            this.txtTreeNoInc.Size = new System.Drawing.Size(146, 26);
            this.txtTreeNoInc.TabIndex = 30;
            // 
            // cmbSection2
            // 
            this.cmbSection2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection2.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbSection2.FormattingEnabled = true;
            this.cmbSection2.Location = new System.Drawing.Point(326, 3);
            this.cmbSection2.Name = "cmbSection2";
            this.cmbSection2.Size = new System.Drawing.Size(114, 24);
            this.cmbSection2.TabIndex = 29;
            // 
            // cmbLine2
            // 
            this.cmbLine2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLine2.Font = new System.Drawing.Font("굴림", 12F);
            this.cmbLine2.FormattingEnabled = true;
            this.cmbLine2.Location = new System.Drawing.Point(91, 3);
            this.cmbLine2.Name = "cmbLine2";
            this.cmbLine2.Size = new System.Drawing.Size(114, 24);
            this.cmbLine2.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(473, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 38);
            this.label15.TabIndex = 27;
            this.label15.Text = "과수번호:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(238, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 38);
            this.label14.TabIndex = 26;
            this.label14.Text = "섹션번호:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 38);
            this.label13.TabIndex = 25;
            this.label13.Text = "라인번호:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "포도 과수 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeInfoBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardInfoBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource treeInfoBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDBPath;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTreeType;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLine;
        private System.Windows.Forms.DataGridView dgvTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txt_SectionNo;
        private System.Windows.Forms.TextBox txt_lineNo;
        private System.Windows.Forms.Button btnSaveInit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQRSavePath;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtQRContents;
        private System.Windows.Forms.Button btnCreateQR_AutoIncrease;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Button btnSelectQRSavePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreateQR_Contents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSection2;
        private System.Windows.Forms.ComboBox cmbLine2;
        private System.Windows.Forms.TextBox txtTreeNoInc;
        private System.Windows.Forms.Label lblQRContents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ComboBox cmbSubCondition;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTfloreDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDfloreDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fruitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn earlyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnFTP;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnExcelToDB;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource standardInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDegreeDataGridViewTextBoxColumn;
    }
}

