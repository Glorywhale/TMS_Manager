using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMS_Manager
{
    public partial class frmModify : Form
    {
        public frmModify()
        {
            InitializeComponent();
        }

        private TreeInfo _treeInfo = null;
        public frmModify(TreeInfo treeInfo)
        {
            InitializeComponent();

            this._treeInfo = treeInfo;
        }

        private void SetTreeInfo()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }
    }
}
