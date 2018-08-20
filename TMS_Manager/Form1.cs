using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using BusinessRefinery.Barcode;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace TMS_Manager
{
    public partial class Form1 : Form
    {
        public int totalLine = 0;
        public int totalSection = 0;
        FTPManager fm = null;
        private XmlConfig _xmlConfig = new XmlConfig();

        ExcelManager em = new ExcelManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// 조건 선택 후 검색
        /// </summary>
        private void SearchData()
        {
            SQLiteDataAdapter adapter = null;
            try
            {
                string dbPath = this.lblDBPath.Text;

                strConn = string.Format(@"Data Source={0};Version=3;", dbPath);

                string sql = string.Format("Select * from TB_Tree ");

                if (this.cmbLine.SelectedIndex != 0)
                {
                    if (!sql.Contains("where")) sql += " where ";
                    sql += string.Format(" and LineNo = '{0}'", this.cmbLine.Text);
                }

                if (this.cmbSection.SelectedIndex != 0)
                {
                    sql += sql.Contains("where") ? " and " : " where ";
                    sql += string.Format(" SectionNo = '{0}'", this.cmbSection.Text);
                }

                if (this.cmbTreeType.SelectedIndex != 0)
                {
                    sql += sql.Contains("where") ? " and " : " where ";
                    sql += string.Format(" TreeType = '{0}'", this.cmbTreeType.Text);
                }                

                adapter = new SQLiteDataAdapter(sql, strConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                dgvTree.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvTree.DataSource == null || this.dgvTree.Rows.Count == 0) return;

                saveFileDialog1.Filter = "Excel File|*.xls";
                saveFileDialog1.Title = "엑셀 파일 저장경로 설정";
                saveFileDialog1.FileName = string.Format("TMS_{0}", DateTime.Now.ToString("yyyy-MM-dd"));
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    em.SaveToExcel(Common.GetDataTableFromDGV(this.dgvTree), saveFileDialog1.FileName);                    
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        string strConn = "";
        private void btnOpenDB_Click(object sender, EventArgs e)
        {            
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string dbName = openFileDialog1.FileName;
                    
                    SetDataBase(dbName);
                }  
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void SetDataBase(string dbPath)
        {
            SQLiteDataAdapter adapter = null;
            try
            {
                this.lblDBPath.Text = dbPath;

                strConn = string.Format(@"Data Source={0};Version=3;", dbPath);

                string sql = "Select * from TB_Tree; Select * from TB_Line;";
                adapter = new SQLiteDataAdapter(sql, strConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                DataTable dt1 = ds.Tables[1];

                totalLine = Convert.ToInt16(dt1.Rows[0][0]);
                totalSection = Convert.ToInt16(dt1.Rows[0][1]);

                cmbLine.Items.Clear();
                cmbSection.Items.Clear();

                cmbLine.Items.Add("전체");
                cmbSection.Items.Add("전체");

                //// cmbLine에 라인번호 셋팅
                for (int i = 0; i < totalLine; i++)
                {
                    cmbLine.Items.Add(i + 1);
                    cmbLine2.Items.Add(i + 1);
                }
                if (cmbLine.Items.Count > 0)
                {
                    cmbLine.SelectedIndex = 0;
                    cmbLine2.SelectedIndex = 0;
                }
                //// cmbLine에 섹션번호 셋팅
                for (int i = 0; i < totalSection; i++)
                {
                    cmbSection.Items.Add(i + 1);
                    cmbSection2.Items.Add(i + 1);
                }
                if (cmbSection.Items.Count > 0)
                {
                    cmbSection.SelectedIndex = 0;
                    cmbSection2.SelectedIndex = 0;
                }

                if (dt != null)
                {
                    this.dgvTree.DataSource = dt.DefaultView;
                }

                //// 기본 정보 설정
                this.txt_lineNo.Text = totalLine.ToString();
                this.txt_SectionNo.Text = totalSection.ToString();
                this.txtEmail.Text = dt1.Rows[0][2].ToString();

                _xmlConfig.XmlWriteStr("Config/DB_PATH", dbPath);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            finally
            {
                adapter.Dispose();
                adapter = null;
            }
        }

        /// <summary>
        /// 초기 정보 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInit_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbTreeType.Items.Count == 0)
                {                    
                    this.cmbTreeType.Items.Add(EnumTreeType.전체.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.거봉.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.자옥.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.탐나라.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.하니.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.홍부사.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.결실불량.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.결주.ToString());
                    this.cmbTreeType.Items.Add(EnumTreeType.수확끝.ToString());

                    this.cmbTreeType.SelectedIndex = 0;
                }

                if (this.cmbCondition.Items.Count == 0)
                {
                    this.cmbCondition.Items.Add(EnumSearchOption.전체);
                    this.cmbCondition.Items.Add(EnumSearchOption.무핵탈립성);
                    this.cmbCondition.Items.Add(EnumSearchOption.착색도);
                    this.cmbCondition.Items.Add(EnumSearchOption.병해);
                    this.cmbCondition.Items.Add(EnumSearchOption.충해);
                    this.cmbCondition.Items.Add(EnumSearchOption.장해);

                    this.cmbCondition.SelectedIndex = 0;
                }

                if (this.cmbResolution.Items.Count == 0)
                {                    
                    this.cmbResolution.Items.Add(500);
                    this.cmbResolution.Items.Add(600);
                    this.cmbResolution.Items.Add(700);
                    this.cmbResolution.Items.Add(800);

                    cmbResolution.SelectedIndex = 0;
                    cmbResolution.Enabled = false;
                }

                if (this.cmbSize.Items.Count == 0)
                {                    
                    this.cmbSize.Items.Add(5.0f);
                    this.cmbSize.Items.Add(6.0f);
                    this.cmbSize.Items.Add(7.0f);
                    this.cmbSize.Items.Add(8.0f);
                    this.cmbSize.Items.Add(9.0f);
                    this.cmbSize.Items.Add(10.0f);                                            
                }

                this.cmbSize.SelectedIndex = 0;

                string dbPath = _xmlConfig.XmlReadStr("Config/DB_PATH");

                if (System.IO.File.Exists(dbPath))
                {
                    SetDataBase(dbPath);
                }

                if (fm == null)
                {
                    fm = new FTPManager();
                    fm.OnDownloadedEvent += new FTPManager.OnDownloadCompeleteHandler(fm_OnDownloadedEvent);
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        void fm_OnDownloadedEvent(string path)
        {
            MessageBox.Show(string.Format("DB파일이 다운로드 되었습니다. 위치 : {0} ", path), "DB 다운로드 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetDataBase(path);
        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                this.cmbSubCondition.DataSource = null;
                this.cmbSubCondition.Enabled = true;
                EnumSearchOption option = (EnumSearchOption) this.cmbCondition.SelectedItem;
                switch(option)
                {
                    case EnumSearchOption.전체:
                        this.cmbSubCondition.Enabled = false;
                        break;
                    case EnumSearchOption.착색도:
                        this.cmbSubCondition.DataSource = Common.GetEnumList(typeof(EnumGrade));
                        break;
                    case EnumSearchOption.무핵탈립성:
                        this.cmbSubCondition.DataSource = Common.GetEnumList(typeof(EnumGrade));
                        break;
                    case EnumSearchOption.병해:
                        this.cmbSubCondition.DataSource = Common.GetEnumList(typeof(EnumGrade));
                        break;
                    case EnumSearchOption.충해:
                        this.cmbSubCondition.DataSource = Common.GetEnumList(typeof(EnumGrade));
                        break;
                    case EnumSearchOption.장해:
                        this.cmbSubCondition.DataSource = Common.GetEnumList(typeof(EnumGrade));
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }



        #region QR Code 처리단

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtQRSavePath.Text.Length > 0 && System.IO.Directory.Exists(this.txtQRSavePath.Text))
                {
                    System.Diagnostics.Process.Start(this.txtQRSavePath.Text);
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void btnCreateQR_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQRContents.Text == "")
                {
                    MessageBox.Show("QR코드에 저장할 내용을 입력하세요", "생성 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string savePath = "";
                if (this.txtQRSavePath.Text == "")
                {
                    savePath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "QRCode");
                    this.txtQRSavePath.Text = savePath;
                }
                else
                {
                    savePath = this.txtQRSavePath.Text;
                }

                QRCode barcode = new QRCode();
                barcode.Code = txtQRContents.Text;
                barcode.ModuleSize = Convert.ToInt32(this.cmbSize.Text.ToString());
                barcode.Resolution = Convert.ToInt32(this.cmbResolution.Text.ToString());

                string filePath = System.IO.Path.Combine(savePath, string.Format("QR_{0}.png", DateTime.Now.ToString("HHmmss")));
                barcode.drawBarcode2ImageFile(filePath);

                this.pbQR.Image = System.Drawing.Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void btnSelectQRSavePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtQRSavePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreateQR_AutoIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = "";
                if (this.txtQRSavePath.Text == "")
                {
                    savePath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "QRCode");

                    if (!System.IO.Directory.Exists(savePath))
                    {
                        System.IO.Directory.CreateDirectory(savePath);
                    }
                    this.txtQRSavePath.Text = savePath;
                }
                else
                {
                    savePath = this.txtQRSavePath.Text;
                }

                QRCode barcode = new QRCode();
                string contents = string.Format("L{0}S{1}T{2}", cmbLine2.Text.ToString(), cmbSection2.Text.ToString(), GetNextTreeNo());
                lblQRContents.Text = "QR 저장 내용 : " + contents;
                barcode.Code = contents;
                barcode.ModuleSize = Convert.ToInt32(this.cmbSize.Text.ToString());
                barcode.Resolution = Convert.ToInt32(this.cmbResolution.Text.ToString());

                string filePath = System.IO.Path.Combine(savePath, string.Format("QR_{0}.png", contents));
                barcode.drawBarcode2ImageFile(filePath);

                this.txtTreeNoInc.Text = (++treeNo).ToString();

                this.pbQR.Image = System.Drawing.Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        int treeNo = 1;
        public string GetNextTreeNo()
        {
            try
            {
                if (this.txtTreeNoInc.Text == "")
                {
                    treeNo = 1;
                }
                else
                {
                    treeNo = Convert.ToInt32(this.txtTreeNoInc.Text);
                }

                this.txtTreeNoInc.Text = treeNo.ToString();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
            return treeNo.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(this.txtQRSavePath.Text))
                {
                    Process.Start(this.txtQRSavePath.Text);
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }
        #endregion

        private TreeInfo _selectedTree = null;
        private void dgvTree_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTree.CurrentRow.Index > 0)
                {
                    DataGridViewRow dr = this.dgvTree.CurrentRow;
                    this._selectedTree = dr.DataBoundItem as TreeInfo;
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void dgvTree_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (this._selectedTree == null)
                {
                    DataGridViewRow dr = this.dgvTree.CurrentRow;
                    this._selectedTree = dr.DataBoundItem as TreeInfo;
                }
                

            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void btnFTP_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "tms.db";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string dbName = saveFileDialog1.FileName;

                    fm.UpAndDownloadFile(dbName, true);
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                fm.UpAndDownloadFile(this.lblDBPath.Text, false);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }

        private void btnExcelToDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string dbName = openFileDialog1.FileName;

                    em.ReadFromExcel(dbName);
                }  
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }
    }
}
