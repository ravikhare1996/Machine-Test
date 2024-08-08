using common.OFM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XpertStudio.Common;
using XpertStudio.Common.Globals;
using XpertStudio.Common.Metadata;
using XpertStudio.Framework.WinFormUI;
using XpertStudio.Framework.WinFormUI.Metadata;
using XpertStudio.UI.Domain.Queryable;

//using XpertStudio.UI.Domain.Queryable;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        //private string _CurrentAssemblyName;
        private string _CurrentFormName;
        RadTreeView treeview1 = new RadTreeView();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string CurrentFormName)
        {
            //_CurrentAssemblyName = CurrentAssemblyName;
            _CurrentFormName = CurrentFormName;
            InitializeComponent();
        }
        public Form TryGetFormByName(string frmname)
        {
            var formType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.Name == frmname)
                .FirstOrDefault();

            if (formType == null) // If there is no form with the given frmname
                return null;

            return (Form)Activator.CreateInstance(formType);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadForms();
            }
            catch (Exception ex)
            {

                clsCommon.MyMessageBoxShow(ex.Message);
            }
            //try
            //{
            //    treeview1.DataSource = null;
            //    treeview1.TreeViewElement.AutoSizeItems = true;
            //    treeview1.ShowLines = true;
            //    treeview1.ShowRootLines = true;
            //    //treeview1.TreeViewElement.ViewElement.Margin = New Padding(4);
            //    treeview1.ShowExpandCollapse = true;
            //    treeview1.TreeIndent = 15;
            //    treeview1.FullRowSelect = false;
            //    treeview1.ShowLines = true;
            //    treeview1.LineStyle = TreeLineStyle.Dot;
            //    treeview1.LineColor = Color.FromArgb(110, 153, 210);
            //    treeview1.ExpandAnimation = ExpandAnimation.Opacity;
            //    treeview1.AllowEdit = false;
            //    treeview1.ShowRootLines = true;

            //    //load menus
            //    XpertMetadataFilter _filter = new XpertMetadataFilter();
            //    _filter.Assembly_Name = Assembly.GetExecutingAssembly().GetName().Name;
            //    _filter.Project_Code = XpertMetadataProvider.GetProjectByAssemblyName(_filter.Assembly_Name);
            //    var modules = XpertMetadataProvider.GetModules(_filter).ToList();
            //    var Programs = XpertMetadataProvider.GetPrograms(_filter).ToList().OrderBy(o1 => o1.Module_Name).ThenBy(o2 => o2.Seq_No);
            //    //Programs.Add(new XpertMetadataPrograms() { Module_Name = "Programs", Program_Code = "", Program_Name = "", Form_Name = "" });
            //    xpertCollapsiblePanel1.Controls.Add(treeview1);
            //    treeview1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            //    treeview1.Dock = DockStyle.Fill;
            //    treeview1.DataSource = null;
            //    RadTreeNode mnode;
            //    RadTreeNode Pnode;
            //    foreach (var _module in modules)
            //    {
            //        mnode = new RadTreeNode() { Name = _module.Module_ID.ToString(), Text = _module.Module_Name, Tag = _module.Project_ID.ToString() };
            //        treeview1.Nodes.Add(mnode);

            //        foreach (var _program in Programs.Where(p => p.Module_Name == _module.Module_Name))
            //        {
            //            Pnode = new RadTreeNode() { Name = _program.Program_Code, Text = _program.Program_Name, Tag = _program.Form_Name };
            //            mnode.Nodes.Add(Pnode);
            //        }
            //    }
            //    //treeview1.DataMember = "Module_Name";

            //    //DataTable dt = new DataTable();

            //    //var dc = new DataColumn();
            //    //dc.ColumnName = "Program_Name";
            //    //dc.DataType = typeof(System.String);
            //    //dt.Columns.Add(dc);

            //    //dc = new DataColumn();
            //    //dc.ColumnName = "Module_Name";
            //    //dc.DataType = typeof(System.String);
            //    //dt.Columns.Add(dc);

            //    //dc = new DataColumn();
            //    //dc.ColumnName = "Form_Name";
            //    //dc.DataType = typeof(System.String);
            //    //dt.Columns.Add(dc);


            //    //dc = new DataColumn();
            //    //dc.ColumnName = "Program_Code";
            //    //dc.DataType = typeof(System.String);
            //    //dt.Columns.Add(dc);

            //    //dc = new DataColumn();
            //    //dc.ColumnName = "Programs";
            //    //dc.DataType = typeof(System.String);
            //    //dt.Columns.Add(dc);
            //    //// var dr = new DataRow;
            //    //var dr = dt.NewRow();
            //    //dr["Programs"] = "Programs";
            //    //dr["Program_Name"] = "Programs";
            //    //dr["Module_Name"] = "Programs";
            //    //dr["Form_Name"] = "Programs";
            //    //dr["Program_Code"] = "Programs";
            //    //dt.Rows.Add(dr);
            //    //foreach (var program in Programs)
            //    //{
            //    //     dr = dt.NewRow();
            //    //    dr["Programs"] = "Programs";
            //    //    dr["Program_Name"] = program.Program_Name;
            //    //    dr["Module_Name"] = program.Module_Name;
            //    //    dr["Form_Name"] = program.Form_Name;
            //    //    dr["Program_Code"] = program.Program_Code;
            //    //    dt.Rows.Add(dr);
            //    //    // dt.Rows.Add(program);
            //    //}
            //    //treeview1.DataMember = "Module_Name";
            //    //treeview1.DisplayMember = "Program_Name";
            //    //treeview1.ParentMember = "Module_Name";
            //    //treeview1.ValueMember = "Form_Name";
            //    //treeview1.ChildMember = "Form_Name";
            //    //treeview1.DataSource = Programs;
            //    //treeview1.Update();

            //    //treeview1.Nodes.Add(new RadTreeNode() { Name = "Programs", Text = "Programs" });
            //    if (clsCommon.myLen(_CurrentFormName) > 0)
            //    {
            //        var currForm = TryGetFormByName(_CurrentFormName);
            //        if (currForm != null)
            //        {
            //            currForm.MdiParent = this;
            //            currForm.Show();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    clsCommon.MyMessageBoxShow(ex.Message);
            //}
        }
        private void LoadForms()
        {
            try
            {
                treeview1.DataSource = null;
                treeview1.TreeViewElement.AutoSizeItems = true;
                treeview1.ShowLines = true;
                treeview1.ShowRootLines = true;
                //treeview1.TreeViewElement.ViewElement.Margin = New Padding(4);
                treeview1.ShowExpandCollapse = true;
                treeview1.TreeIndent = 15;
                treeview1.FullRowSelect = false;
                treeview1.ShowLines = true;
                treeview1.LineStyle = TreeLineStyle.Dot;
                treeview1.LineColor = Color.FromArgb(110, 153, 210);
                treeview1.ExpandAnimation = ExpandAnimation.Opacity;
                treeview1.AllowEdit = false;
                treeview1.ShowRootLines = true;

                //load menus
                //XpertMetadataFilter _filter = new XpertMetadataFilter();
                //_filter.Assembly_Name = Assembly.GetExecutingAssembly().GetName().Name;
                //_filter.Project_Code = XpertMetadataProvider.GetProjectByAssemblyName(_filter.Assembly_Name);
                //var modules = XpertMetadataProvider.GetModules(_filter).ToList();
                //var Programs = XpertMetadataProvider.GetPrograms(_filter).ToList().OrderBy(o1 => o1.Module_Name).ThenBy(o2 => o2.Seq_No);
                //Programs.Add(new XpertMetadataPrograms() { Module_Name = "Programs", Program_Code = "", Program_Name = "", Form_Name = "" });
                var currAssembly = Assembly.GetExecutingAssembly();
                var XSFormsTypes = currAssembly.DefinedTypes.Where(f => f.IsAssignableTo(typeof(IXpertBaseForm))).ToList();
                if (DomainLayerData.XSProject == null)
                {
                    return;
                }
                var modules = DomainLayerData.XSProject.Modules;
                var XSForms = new List<IXpertBaseForm>();
                foreach (var typeForm in XSFormsTypes)
                {
                    var instance = Activator.CreateInstance(typeForm);
                    if (instance is IXpertBaseForm xpertBaseForm)
                    {
                        XSForms.Add(xpertBaseForm);
                    }
                }
                xpertCollapsiblePanel1.Controls.Add(treeview1);
                treeview1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
                treeview1.Dock = DockStyle.Fill;
                treeview1.DataSource = null;
                RadTreeNode mnode;
                RadTreeNode Pnode;
                foreach (var _module in modules)
                {
                    mnode = new RadTreeNode() { Name = _module.Module_Name.ToString(), Text = _module.Module_Name, Tag = _module.ParentID.ToString() };
                    treeview1.Nodes.Add(mnode);

                    foreach (IXpertBaseForm _program in XSForms.Where(p => p.ModuleName == _module.Module_Name))
                    {
                        Pnode = new RadTreeNode() { Name = _program.Program_Code, Text = _program.Program_Name, Tag = _program };
                        mnode.Nodes.Add(Pnode);
                    }
                }

                if (clsCommon.myLen(_CurrentFormName) > 0)
                {
                    var currForm = TryGetFormByName(_CurrentFormName);
                    if (currForm != null)
                    {
                        currForm.MdiParent = this;
                        currForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                clsCommon.MyMessageBoxShow(ex.Message);
            }
        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (treeview1.SelectedNode != null && treeview1.SelectedNode.Parent != null)
                {

                    //var formType = AccessTools.TypeByName(clsCommon.myCstr(treeview1.SelectedNode.Tag));                    
                    //Form f = (Form)Activator.CreateInstance(formType);
                    XpertBaseForm f = treeview1.SelectedNode.Tag as XpertBaseForm;
                    f.MdiParent = this;
                    f.WindowState = FormWindowState.Normal;
                    f.Show();
                }

            }
            catch (Exception ex)
            {
                clsCommon.MyMessageBoxShow(ex.Message);
            }
        }
    }
}
