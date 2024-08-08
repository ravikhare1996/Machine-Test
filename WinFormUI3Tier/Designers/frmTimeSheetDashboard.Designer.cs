using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Xpert.TMS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmTimeSheetDashboard : CommonServices.FrmMainTranScreen
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimeSheetDashboard));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition6 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition8 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition9 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition10 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition11 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition12 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition13 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition14 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition15 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition16 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition17 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition18 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition19 = new Telerik.WinControls.UI.TableViewDefinition();
            SplitContainer2 = new XS.WinForms.Controls.XpertSplitContainer();
            MyLabel3 = new XS.WinForms.Controls.XpertLabel();
            txtOverviewFilled = new XS.WinForms.Controls.XpertLabel();
            btnNext = new XS.WinForms.Controls.XpertLabel();
            PictureBox1 = new XS.WinForms.Controls.XpertPictureBox();
            txtOverviewGap = new XS.WinForms.Controls.XpertLabel();
            txtOverviewDelay = new XS.WinForms.Controls.XpertLabel();
            btnPrevious = new XS.WinForms.Controls.XpertLabel();
            txtOverviewOpen = new XS.WinForms.Controls.XpertLabel();
            txtOverviewClose = new XS.WinForms.Controls.XpertLabel();
            RadPageView1 = new XS.WinForms.Controls.XpertPageView();
            RadPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            Panel23 = new XS.WinForms.Controls.XSMSPanel();
            Panel22 = new XS.WinForms.Controls.XSMSPanel();
            RadPageView2 = new XS.WinForms.Controls.XpertPageView();
            RadPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            Pnl_Type = new XS.WinForms.Controls.XSMSPanel();
            RadPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            RadPageView3 = new XS.WinForms.Controls.XpertPageView();
            rdAllKRAList_PriorityChange = new Telerik.WinControls.UI.RadPageViewPage();
            gvKRA = new XS.WinForms.Controls.XpertDataGridView();
            Panel10 = new XS.WinForms.Controls.XSMSPanel();
            btnRefresh_KRA = new Telerik.WinControls.UI.RadButton();
            rdTimeSheet = new Telerik.WinControls.UI.RadPageViewPage();
            RadPageView4 = new XS.WinForms.Controls.XpertPageView();
            RadPageViewPage4 = new Telerik.WinControls.UI.RadPageViewPage();
            gvList = new XS.WinForms.Controls.XpertDataGridView();
            Panel6 = new XS.WinForms.Controls.XSMSPanel();
            btnSendApp = new Telerik.WinControls.UI.RadButton();
            MyLabel4 = new XS.WinForms.Controls.XpertLabel();
            Panel2 = new XS.WinForms.Controls.XSMSPanel();
            btnTicketType = new Telerik.WinControls.UI.RadSplitButton();
            btnAll = new Telerik.WinControls.UI.RadMenuItem();
            btnFilled = new Telerik.WinControls.UI.RadMenuItem();
            btnNotFilled = new Telerik.WinControls.UI.RadMenuItem();
            btnDaySheet = new Telerik.WinControls.UI.RadMenuItem();
            lblTicketTypeName = new XS.WinForms.Controls.XpertLabel();
            RadPageViewPage5 = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer5 = new XS.WinForms.Controls.XpertSplitContainer();
            gvManual = new XS.WinForms.Controls.XpertDataGridView();
            Panel3 = new XS.WinForms.Controls.XSMSPanel();
            UcRefreshIconButton1 = new Telerik.WinControls.UI.RadButton();
            MyLabel6 = new XS.WinForms.Controls.XpertLabel();
            gv_Auto = new XS.WinForms.Controls.XpertDataGridView();
            Panel5 = new XS.WinForms.Controls.XSMSPanel();
            MyLabel9 = new XS.WinForms.Controls.XpertLabel();
            RadPageViewPage14 = new Telerik.WinControls.UI.RadPageViewPage();
            gvEducation = new XS.WinForms.Controls.XpertDataGridView();
            RadPageViewPage13 = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer9 = new XS.WinForms.Controls.XpertSplitContainer();
            Panel19 = new XS.WinForms.Controls.XSMSPanel();
            lblCountlistAwited = new XS.WinForms.Controls.XpertLabel();
            btnRefreshAwaited = new Telerik.WinControls.UI.RadButton();
            gvAwaitedCommon = new XS.WinForms.Controls.XpertDataGridView();
            RadPageViewPage15 = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer10 = new XS.WinForms.Controls.XpertSplitContainer();
            gvSuspended = new XS.WinForms.Controls.XpertDataGridView();
            rdHeldup = new Telerik.WinControls.UI.RadPageViewPage();
            Panel25 = new XS.WinForms.Controls.XSMSPanel();
            gvHeldUpWork = new XS.WinForms.Controls.XpertDataGridView();
            Panel21 = new XS.WinForms.Controls.XSMSPanel();
            MyLabel51 = new XS.WinForms.Controls.XpertLabel();
            btnHeldupRefresh = new Telerik.WinControls.UI.RadButton();
            RadCollapsiblePanel7 = new XS.WinForms.Controls.XpertCollapsiblePanel();
            MyLabel45 = new XS.WinForms.Controls.XpertLabel();
            txtHedlupUsers = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel49 = new XS.WinForms.Controls.XpertLabel();
            dtHeldFrom = new XS.WinForms.Controls.XpertDateTime();
            MyLabel50 = new XS.WinForms.Controls.XpertLabel();
            dtHeldTo = new XS.WinForms.Controls.XpertDateTime();
            rdExpire = new Telerik.WinControls.UI.RadPageViewPage();
            Panel24 = new XS.WinForms.Controls.XSMSPanel();
            gvExpired = new XS.WinForms.Controls.XpertDataGridView();
            Panel20 = new XS.WinForms.Controls.XSMSPanel();
            MyLabel44 = new XS.WinForms.Controls.XpertLabel();
            btExpiryRefresh = new Telerik.WinControls.UI.RadButton();
            RadCollapsiblePanel6 = new XS.WinForms.Controls.XpertCollapsiblePanel();
            MyLabel46 = new XS.WinForms.Controls.XpertLabel();
            txtExpiredUsers = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel47 = new XS.WinForms.Controls.XpertLabel();
            dtExpiredFrom = new XS.WinForms.Controls.XpertDateTime();
            MyLabel48 = new XS.WinForms.Controls.XpertLabel();
            dtExpiredTo = new XS.WinForms.Controls.XpertDateTime();
            rdAwaitedWork = new Telerik.WinControls.UI.RadPageViewPage();
            gvAwaited = new XS.WinForms.Controls.XpertDataGridView();
            Panel4 = new XS.WinForms.Controls.XSMSPanel();
            MyLabel5 = new XS.WinForms.Controls.XpertLabel();
            btnAwited = new Telerik.WinControls.UI.RadButton();
            RadCollapsiblePanel2 = new XS.WinForms.Controls.XpertCollapsiblePanel();
            MyLabel7 = new XS.WinForms.Controls.XpertLabel();
            AwaitedUsers = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel10 = new XS.WinForms.Controls.XpertLabel();
            AwaitedFromDate = new XS.WinForms.Controls.XpertDateTime();
            MyLabel11 = new XS.WinForms.Controls.XpertLabel();
            AwaitedToDate = new XS.WinForms.Controls.XpertDateTime();
            rdDayToDay = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer8 = new XS.WinForms.Controls.XpertSplitContainer();
            Panel7 = new XS.WinForms.Controls.XSMSPanel();
            btnAddNew = new Telerik.WinControls.UI.RadButton();
            MyLabel12 = new XS.WinForms.Controls.XpertLabel();
            btnDayRefresh = new Telerik.WinControls.UI.RadButton();
            gvDayToDay = new XS.WinForms.Controls.XpertDataGridView();
            rdDone = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer13 = new XS.WinForms.Controls.XpertSplitContainer();
            gvDone = new XS.WinForms.Controls.XpertDataGridView();
            btnDone = new Telerik.WinControls.UI.RadButton();
            rdNotDone = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer12 = new XS.WinForms.Controls.XpertSplitContainer();
            gvNotDone = new XS.WinForms.Controls.XpertDataGridView();
            btnNotDone = new Telerik.WinControls.UI.RadButton();
            RadPageViewPage6 = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer7 = new XS.WinForms.Controls.XpertSplitContainer();
            SplitContainer11 = new XS.WinForms.Controls.XpertSplitContainer();
            gvResponsibility = new XS.WinForms.Controls.XpertDataGridView();
            btnResponsibiltySave = new Telerik.WinControls.UI.RadButton();
            btnReset = new XS.WinForms.Controls.XpertButton();
            btnSave = new XS.WinForms.Controls.XpertButton();
            ControlsContainer = new Telerik.WinControls.UI.CollapsiblePanelControlsContainer();
            RadPageView5 = new XS.WinForms.Controls.XpertPageView();
            RadPageViewPage7 = new Telerik.WinControls.UI.RadPageViewPage();
            MyRadGridView1 = new XS.WinForms.Controls.XpertDataGridView();
            Panel12 = new XS.WinForms.Controls.XSMSPanel();
            UcRefreshIconButton2 = new Telerik.WinControls.UI.RadButton();
            RadCollapsiblePanel4 = new XS.WinForms.Controls.XpertCollapsiblePanel();
            MyLabel24 = new XS.WinForms.Controls.XpertLabel();
            MyComboBox1 = new XS.WinForms.Controls.XpertDropDown();
            MyLabel25 = new XS.WinForms.Controls.XpertLabel();
            TxtMultiSelectFinder1 = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel27 = new XS.WinForms.Controls.XpertLabel();
            TxtMultiSelectFinder2 = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel28 = new XS.WinForms.Controls.XpertLabel();
            TxtMultiSelectFinder3 = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel29 = new XS.WinForms.Controls.XpertLabel();
            MyDateTimePicker1 = new XS.WinForms.Controls.XpertDateTime();
            MyLabel30 = new XS.WinForms.Controls.XpertLabel();
            MyDateTimePicker2 = new XS.WinForms.Controls.XpertDateTime();
            RadPageViewPage8 = new Telerik.WinControls.UI.RadPageViewPage();
            RadPageView6 = new XS.WinForms.Controls.XpertPageView();
            RadPageViewPage9 = new Telerik.WinControls.UI.RadPageViewPage();
            MyRadGridView2 = new XS.WinForms.Controls.XpertDataGridView();
            Panel13 = new XS.WinForms.Controls.XSMSPanel();
            UcSaveButton1 = new Telerik.WinControls.UI.RadButton();
            MyLabel31 = new XS.WinForms.Controls.XpertLabel();
            Panel14 = new XS.WinForms.Controls.XSMSPanel();
            RadSplitButton1 = new Telerik.WinControls.UI.RadSplitButton();
            RadMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            RadMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            RadMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            RadMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            MyLabel32 = new XS.WinForms.Controls.XpertLabel();
            RadPageViewPage10 = new Telerik.WinControls.UI.RadPageViewPage();
            SplitContainer6 = new XS.WinForms.Controls.XpertSplitContainer();
            MyRadGridView3 = new XS.WinForms.Controls.XpertDataGridView();
            Panel15 = new XS.WinForms.Controls.XSMSPanel();
            UcRefreshIconButton3 = new Telerik.WinControls.UI.RadButton();
            MyLabel33 = new XS.WinForms.Controls.XpertLabel();
            MyRadGridView4 = new XS.WinForms.Controls.XpertDataGridView();
            Panel16 = new XS.WinForms.Controls.XSMSPanel();
            MyLabel34 = new XS.WinForms.Controls.XpertLabel();
            RadPageViewPage11 = new Telerik.WinControls.UI.RadPageViewPage();
            RadScrollablePanel2 = new XS.WinForms.Controls.XpertScrollablePanel();
            TableLayoutPanel2 = new XS.WinForms.Controls.XpertTableLayoutPanel();
            Panel17 = new XS.WinForms.Controls.XSMSPanel();
            UcRefreshIconButton4 = new Telerik.WinControls.UI.RadButton();
            RadCollapsiblePanel5 = new XS.WinForms.Controls.XpertCollapsiblePanel();
            MyLabel35 = new XS.WinForms.Controls.XpertLabel();
            TxtMultiSelectFinder4 = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel36 = new XS.WinForms.Controls.XpertLabel();
            TxtMultiSelectFinder5 = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel37 = new XS.WinForms.Controls.XpertLabel();
            TxtMultiSelectFinder6 = new XS.WinForms.Controls.XpertMultiSelctFinder();
            MyLabel38 = new XS.WinForms.Controls.XpertLabel();
            MyDateTimePicker3 = new XS.WinForms.Controls.XpertDateTime();
            MyLabel39 = new XS.WinForms.Controls.XpertLabel();
            MyDateTimePicker4 = new XS.WinForms.Controls.XpertDateTime();
            RadPageViewPage12 = new Telerik.WinControls.UI.RadPageViewPage();
            MyRadGridView5 = new XS.WinForms.Controls.XpertDataGridView();
            Panel18 = new XS.WinForms.Controls.XSMSPanel();
            UcSaveButton2 = new Telerik.WinControls.UI.RadButton();
            MyLabel40 = new XS.WinForms.Controls.XpertLabel();
            UcRefreshIconButton5 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)_RadCollapsiblePanel1).BeginInit();
            _RadCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitContainer2).BeginInit();
            SplitContainer2.Panel1.SuspendLayout();
            SplitContainer2.Panel2.SuspendLayout();
            SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewFilled).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewGap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadPageView1).BeginInit();
            RadPageView1.SuspendLayout();
            RadPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RadPageView2).BeginInit();
            RadPageView2.SuspendLayout();
            RadPageViewPage2.SuspendLayout();
            RadPageViewPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RadPageView3).BeginInit();
            RadPageView3.SuspendLayout();
            rdAllKRAList_PriorityChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvKRA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvKRA.MasterTemplate).BeginInit();
            Panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh_KRA).BeginInit();
            rdTimeSheet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RadPageView4).BeginInit();
            RadPageView4.SuspendLayout();
            RadPageViewPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).BeginInit();
            Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSendApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTicketType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTicketTypeName).BeginInit();
            RadPageViewPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer5).BeginInit();
            SplitContainer5.Panel1.SuspendLayout();
            SplitContainer5.Panel2.SuspendLayout();
            SplitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvManual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvManual.MasterTemplate).BeginInit();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_Auto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_Auto.MasterTemplate).BeginInit();
            Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel9).BeginInit();
            RadPageViewPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvEducation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvEducation.MasterTemplate).BeginInit();
            RadPageViewPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer9).BeginInit();
            SplitContainer9.Panel1.SuspendLayout();
            SplitContainer9.Panel2.SuspendLayout();
            SplitContainer9.SuspendLayout();
            Panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblCountlistAwited).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefreshAwaited).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvAwaitedCommon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvAwaitedCommon.MasterTemplate).BeginInit();
            RadPageViewPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer10).BeginInit();
            SplitContainer10.Panel1.SuspendLayout();
            SplitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvSuspended).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvSuspended.MasterTemplate).BeginInit();
            rdHeldup.SuspendLayout();
            Panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork.MasterTemplate).BeginInit();
            Panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel51).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHeldupRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel7).BeginInit();
            RadCollapsiblePanel7.PanelContainer.SuspendLayout();
            RadCollapsiblePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel45).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel49).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtHeldFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtHeldTo).BeginInit();
            rdExpire.SuspendLayout();
            Panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvExpired).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvExpired.MasterTemplate).BeginInit();
            Panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel44).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btExpiryRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel6).BeginInit();
            RadCollapsiblePanel6.PanelContainer.SuspendLayout();
            RadCollapsiblePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel46).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel47).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtExpiredFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel48).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtExpiredTo).BeginInit();
            rdAwaitedWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvAwaited).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvAwaited.MasterTemplate).BeginInit();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAwited).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel2).BeginInit();
            RadCollapsiblePanel2.PanelContainer.SuspendLayout();
            RadCollapsiblePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AwaitedFromDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AwaitedToDate).BeginInit();
            rdDayToDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer8).BeginInit();
            SplitContainer8.Panel1.SuspendLayout();
            SplitContainer8.Panel2.SuspendLayout();
            SplitContainer8.SuspendLayout();
            Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDayRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDayToDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDayToDay.MasterTemplate).BeginInit();
            rdDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer13).BeginInit();
            SplitContainer13.Panel1.SuspendLayout();
            SplitContainer13.Panel2.SuspendLayout();
            SplitContainer13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvDone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDone.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDone).BeginInit();
            rdNotDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer12).BeginInit();
            SplitContainer12.Panel1.SuspendLayout();
            SplitContainer12.Panel2.SuspendLayout();
            SplitContainer12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvNotDone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvNotDone.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNotDone).BeginInit();
            RadPageViewPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer7).BeginInit();
            SplitContainer7.Panel1.SuspendLayout();
            SplitContainer7.Panel2.SuspendLayout();
            SplitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer11).BeginInit();
            SplitContainer11.Panel1.SuspendLayout();
            SplitContainer11.Panel2.SuspendLayout();
            SplitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvResponsibility).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvResponsibility.MasterTemplate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnResponsibiltySave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ControlsContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadPageView5).BeginInit();
            RadPageView5.SuspendLayout();
            RadPageViewPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView1.MasterTemplate).BeginInit();
            Panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel4).BeginInit();
            RadCollapsiblePanel4.PanelContainer.SuspendLayout();
            RadCollapsiblePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker2).BeginInit();
            RadPageViewPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RadPageView6).BeginInit();
            RadPageView6.SuspendLayout();
            RadPageViewPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView2.MasterTemplate).BeginInit();
            Panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UcSaveButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadSplitButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel32).BeginInit();
            RadPageViewPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer6).BeginInit();
            SplitContainer6.Panel1.SuspendLayout();
            SplitContainer6.Panel2.SuspendLayout();
            SplitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView3.MasterTemplate).BeginInit();
            Panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView4.MasterTemplate).BeginInit();
            Panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel34).BeginInit();
            RadPageViewPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RadScrollablePanel2).BeginInit();
            RadScrollablePanel2.PanelContainer.SuspendLayout();
            RadScrollablePanel2.SuspendLayout();
            Panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel5).BeginInit();
            RadCollapsiblePanel5.PanelContainer.SuspendLayout();
            RadCollapsiblePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel35).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel36).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel37).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel38).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel39).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker4).BeginInit();
            RadPageViewPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView5.MasterTemplate).BeginInit();
            Panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UcSaveButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel40).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // _RadCollapsiblePanel1
            // 
            _RadCollapsiblePanel1.IsExpanded = false;
            _RadCollapsiblePanel1.Location = new Point(0, 0);
            _RadCollapsiblePanel1.OwnerBoundsCache = new Rectangle(0, 0, 908, 21);
            // 
            // _RadCollapsiblePanel1.PanelContainer
            // 
            _RadCollapsiblePanel1.PanelContainer.Size = new Size(908, 0);
            _RadCollapsiblePanel1.Size = new Size(908, 21);
            // 
            // _RMenu_ShiftForward
            // 
            _RMenu_ShiftForward.BackColor = Color.White;
            _RMenu_ShiftForward.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_ShiftForward.ForeColor = Color.Black;
            _RMenu_ShiftForward.Padding = new Padding(8, 1, 8, 1);
            _RMenu_ShiftForward.RightToLeft = true;
            _RMenu_ShiftForward.ShowArrow = false;
            _RMenu_ShiftForward.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_ShiftForward.UseCompatibleTextRendering = true;
            _RMenu_ShiftForward.UseDefaultDisabledPaint = false;
            _RMenu_ShiftForward.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // _RMenu_Attachment
            // 
            _RMenu_Attachment.AccessibleDescription = "Attachment";
            _RMenu_Attachment.AccessibleName = "Attachment";
            _RMenu_Attachment.BackColor = Color.White;
            _RMenu_Attachment.Bounds = new Rectangle(0, 0, 80, 20);
            _RMenu_Attachment.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_Attachment.Padding = new Padding(8, 1, 8, 1);
            _RMenu_Attachment.RightToLeft = true;
            _RMenu_Attachment.ShowArrow = false;
            _RMenu_Attachment.UseCompatibleTextRendering = true;
            _RMenu_Attachment.UseDefaultDisabledPaint = false;
            // 
            // _btnAddAttachment
            // 
            _btnAddAttachment.AccessibleDescription = "     Add";
            _btnAddAttachment.AccessibleName = "     Add";
            _btnAddAttachment.BackColor = SystemColors.Window;
            _btnAddAttachment.RightToLeft = true;
            _btnAddAttachment.ShowArrow = false;
            _btnAddAttachment.UseCompatibleTextRendering = true;
            // 
            // _btnViewAttachment
            // 
            _btnViewAttachment.AccessibleDescription = "     View";
            _btnViewAttachment.AccessibleName = "     View";
            _btnViewAttachment.BackColor = SystemColors.Window;
            _btnViewAttachment.RightToLeft = true;
            _btnViewAttachment.ShowArrow = false;
            _btnViewAttachment.UseCompatibleTextRendering = true;
            // 
            // _RMenuExport_Import
            // 
            _RMenuExport_Import.AccessibleDescription = "Export/Import";
            _RMenuExport_Import.AccessibleName = "Export/Import";
            _RMenuExport_Import.BackColor = Color.White;
            _RMenuExport_Import.Bounds = new Rectangle(0, 0, 92, 20);
            _RMenuExport_Import.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenuExport_Import.Padding = new Padding(8, 1, 8, 1);
            _RMenuExport_Import.RightToLeft = true;
            _RMenuExport_Import.ShowArrow = false;
            _RMenuExport_Import.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenuExport_Import.UseCompatibleTextRendering = true;
            _RMenuExport_Import.UseDefaultDisabledPaint = false;
            // 
            // _RMenu_Export
            // 
            _RMenu_Export.AccessibleDescription = "Export";
            _RMenu_Export.AccessibleName = "Export";
            _RMenu_Export.BackColor = SystemColors.Window;
            _RMenu_Export.RightToLeft = true;
            _RMenu_Export.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_Export.UseCompatibleTextRendering = true;
            // 
            // _RMenu_ExporttoExcel
            // 
            _RMenu_ExporttoExcel.AccessibleDescription = "Excel";
            _RMenu_ExporttoExcel.AccessibleName = "Excel";
            _RMenu_ExporttoExcel.BackColor = SystemColors.Window;
            _RMenu_ExporttoExcel.RightToLeft = true;
            _RMenu_ExporttoExcel.ShowArrow = false;
            _RMenu_ExporttoExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_ExporttoExcel.UseCompatibleTextRendering = true;
            // 
            // _RMenu_ExporttoPDF
            // 
            _RMenu_ExporttoPDF.AccessibleDescription = "PDF";
            _RMenu_ExporttoPDF.AccessibleName = "PDF";
            _RMenu_ExporttoPDF.BackColor = SystemColors.Window;
            _RMenu_ExporttoPDF.RightToLeft = true;
            _RMenu_ExporttoPDF.ShowArrow = false;
            _RMenu_ExporttoPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_ExporttoPDF.UseCompatibleTextRendering = true;
            // 
            // _RMenu_ImportExcel
            // 
            _RMenu_ImportExcel.AccessibleDescription = "Import";
            _RMenu_ImportExcel.AccessibleName = "Import";
            _RMenu_ImportExcel.BackColor = SystemColors.Window;
            _RMenu_ImportExcel.RightToLeft = true;
            _RMenu_ImportExcel.ShowArrow = false;
            _RMenu_ImportExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_ImportExcel.UseCompatibleTextRendering = true;
            // 
            // _RMenu_Utility
            // 
            _RMenu_Utility.AccessibleDescription = "Utility";
            _RMenu_Utility.AccessibleName = "Utility";
            _RMenu_Utility.Bounds = new Rectangle(0, 0, 51, 20);
            _RMenu_Utility.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_Utility.Padding = new Padding(8, 1, 8, 1);
            _RMenu_Utility.RightToLeft = true;
            _RMenu_Utility.ShowArrow = false;
            _RMenu_Utility.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_Utility.UseCompatibleTextRendering = true;
            _RMenu_Utility.UseDefaultDisabledPaint = false;
            // 
            // _RMenu_ReminderSetting
            // 
            _RMenu_ReminderSetting.AccessibleDescription = "Reminder Setting";
            _RMenu_ReminderSetting.AccessibleName = "Reminder Setting";
            _RMenu_ReminderSetting.BackColor = SystemColors.Window;
            _RMenu_ReminderSetting.RightToLeft = true;
            _RMenu_ReminderSetting.ShowArrow = false;
            _RMenu_ReminderSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_ReminderSetting.UseCompatibleTextRendering = true;
            // 
            // _RMenu_ColourChange
            // 
            _RMenu_ColourChange.AccessibleDescription = "Colour Setting";
            _RMenu_ColourChange.AccessibleName = "Colour Setting";
            _RMenu_ColourChange.BackColor = SystemColors.Window;
            _RMenu_ColourChange.RightToLeft = true;
            _RMenu_ColourChange.ShowArrow = false;
            _RMenu_ColourChange.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_ColourChange.UseCompatibleTextRendering = true;
            // 
            // _RMenu_Skip
            // 
            _RMenu_Skip.AccessibleDescription = "Skip Entry";
            _RMenu_Skip.AccessibleName = "Skip Entry";
            _RMenu_Skip.BackColor = Color.White;
            _RMenu_Skip.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_Skip.ForeColor = Color.Black;
            _RMenu_Skip.Padding = new Padding(8, 1, 8, 1);
            _RMenu_Skip.RightToLeft = true;
            _RMenu_Skip.ShowArrow = false;
            _RMenu_Skip.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_Skip.UseCompatibleTextRendering = true;
            _RMenu_Skip.UseDefaultDisabledPaint = false;
            _RMenu_Skip.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // _RMenu_Common
            // 
            _RMenu_Common.AccessibleDescription = "Common";
            _RMenu_Common.AccessibleName = "Common";
            _RMenu_Common.BackColor = Color.White;
            _RMenu_Common.Bounds = new Rectangle(0, 0, 68, 20);
            _RMenu_Common.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_Common.Padding = new Padding(8, 1, 8, 1);
            _RMenu_Common.RightToLeft = true;
            _RMenu_Common.ShowArrow = false;
            _RMenu_Common.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_Common.UseCompatibleTextRendering = true;
            _RMenu_Common.UseDefaultDisabledPaint = false;
            // 
            // _RMenu_Print
            // 
            _RMenu_Print.AccessibleDescription = "Print";
            _RMenu_Print.AccessibleName = "Print";
            _RMenu_Print.BackColor = Color.White;
            _RMenu_Print.Bounds = new Rectangle(0, 0, 45, 20);
            _RMenu_Print.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_Print.Padding = new Padding(8, 1, 8, 1);
            _RMenu_Print.RightToLeft = true;
            _RMenu_Print.ShowArrow = false;
            _RMenu_Print.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_Print.UseCompatibleTextRendering = true;
            _RMenu_Print.UseDefaultDisabledPaint = false;
            // 
            // _RMenu_CHecklist
            // 
            _RMenu_CHecklist.AccessibleDescription = "Checklist";
            _RMenu_CHecklist.AccessibleName = "Checklist";
            _RMenu_CHecklist.Bounds = new Rectangle(0, 0, 67, 20);
            _RMenu_CHecklist.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMenu_CHecklist.ForeColor = Color.Black;
            _RMenu_CHecklist.Padding = new Padding(8, 1, 8, 1);
            _RMenu_CHecklist.RightToLeft = true;
            _RMenu_CHecklist.ShowArrow = false;
            _RMenu_CHecklist.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_CHecklist.UseCompatibleTextRendering = true;
            _RMenu_CHecklist.UseDefaultDisabledPaint = false;
            // 
            // _RMenu_CategoryStatus
            // 
            _RMenu_CategoryStatus.AccessibleDescription = "Category Status";
            _RMenu_CategoryStatus.AccessibleName = "Category Status";
            _RMenu_CategoryStatus.BackColor = SystemColors.Window;
            _RMenu_CategoryStatus.RightToLeft = true;
            _RMenu_CategoryStatus.ShowArrow = false;
            _RMenu_CategoryStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_CategoryStatus.UseCompatibleTextRendering = true;
            _RMenu_CategoryStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // _RMenu_Approval
            // 
            _RMenu_Approval.AccessibleDescription = "Approval Setting";
            _RMenu_Approval.AccessibleName = "Approval Setting";
            _RMenu_Approval.BackColor = SystemColors.Window;
            _RMenu_Approval.RightToLeft = true;
            _RMenu_Approval.ShowArrow = false;
            _RMenu_Approval.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_Approval.UseCompatibleTextRendering = true;
            // 
            // _rmSetReport
            // 
            _rmSetReport.AccessibleDescription = "Set Report";
            _rmSetReport.AccessibleName = "Set Report";
            _rmSetReport.BackColor = Color.White;
            _rmSetReport.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _rmSetReport.ForeColor = Color.Black;
            _rmSetReport.Padding = new Padding(8, 1, 8, 1);
            _rmSetReport.RightToLeft = true;
            _rmSetReport.ShowArrow = false;
            _rmSetReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            _rmSetReport.UseCompatibleTextRendering = true;
            _rmSetReport.UseDefaultDisabledPaint = false;
            _rmSetReport.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // _RMenu_RequiredDiscussion
            // 
            _RMenu_RequiredDiscussion.AccessibleDescription = "Required Discussion";
            _RMenu_RequiredDiscussion.AccessibleName = "Required Discussion";
            _RMenu_RequiredDiscussion.BackColor = SystemColors.Window;
            _RMenu_RequiredDiscussion.RightToLeft = true;
            _RMenu_RequiredDiscussion.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenu_RequiredDiscussion.UseCompatibleTextRendering = true;
            // 
            // _RMCreateTask
            // 
            _RMCreateTask.AccessibleDescription = "Ticket/Task";
            _RMCreateTask.AccessibleName = "Ticket/Task";
            _RMCreateTask.BackColor = Color.White;
            _RMCreateTask.Bounds = new Rectangle(0, 0, 77, 20);
            _RMCreateTask.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _RMCreateTask.ForeColor = Color.Black;
            _RMCreateTask.Padding = new Padding(8, 1, 8, 1);
            _RMCreateTask.RightToLeft = true;
            _RMCreateTask.ShowArrow = false;
            _RMCreateTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMCreateTask.UseCompatibleTextRendering = true;
            _RMCreateTask.UseDefaultDisabledPaint = false;
            // 
            // _RMenuSoftware
            // 
            _RMenuSoftware.AccessibleDescription = "Software";
            _RMenuSoftware.AccessibleName = "Software";
            _RMenuSoftware.BackColor = SystemColors.Window;
            _RMenuSoftware.RightToLeft = true;
            _RMenuSoftware.ShowArrow = false;
            _RMenuSoftware.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenuSoftware.UseCompatibleTextRendering = true;
            // 
            // _RMenuBusiness
            // 
            _RMenuBusiness.AccessibleDescription = "Business";
            _RMenuBusiness.AccessibleName = "Business";
            _RMenuBusiness.BackColor = SystemColors.Window;
            _RMenuBusiness.RightToLeft = true;
            _RMenuBusiness.ShowArrow = false;
            _RMenuBusiness.TextImageRelation = TextImageRelation.ImageBeforeText;
            _RMenuBusiness.UseCompatibleTextRendering = true;
            // 
            // _rbtnTimesheet
            // 
            _rbtnTimesheet.BackColor = Color.White;
            _rbtnTimesheet.Bounds = new Rectangle(0, 0, 18, 20);
            _rbtnTimesheet.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _rbtnTimesheet.ForeColor = Color.Black;
            _rbtnTimesheet.Padding = new Padding(8, 1, 8, 1);
            _rbtnTimesheet.RightToLeft = true;
            _rbtnTimesheet.ShowArrow = false;
            _rbtnTimesheet.TextImageRelation = TextImageRelation.ImageBeforeText;
            _rbtnTimesheet.UseCompatibleTextRendering = true;
            _rbtnTimesheet.UseDefaultDisabledPaint = false;
            // 
            // _rbtnUserName
            // 
            _rbtnUserName.BackColor = Color.White;
            _rbtnUserName.Bounds = new Rectangle(0, 0, 18, 20);
            _rbtnUserName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            _rbtnUserName.ForeColor = Color.Black;
            _rbtnUserName.Padding = new Padding(8, 1, 8, 1);
            _rbtnUserName.RightToLeft = true;
            _rbtnUserName.ShowArrow = false;
            _rbtnUserName.Text = "";
            _rbtnUserName.TextImageRelation = TextImageRelation.ImageBeforeText;
            _rbtnUserName.UseCompatibleTextRendering = true;
            _rbtnUserName.UseDefaultDisabledPaint = false;
            // 
            // SplitContainer2
            // 
            SplitContainer2.BackColor = SystemColors.ControlLight;
            SplitContainer2.Control_Name = "SplitContainer2";
            SplitContainer2.FixedPanel = FixedPanel.Panel1;
            SplitContainer2.Location = new Point(-1, 1);
            SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            SplitContainer2.Panel1.Controls.Add(MyLabel3);
            SplitContainer2.Panel1.Controls.Add(txtOverviewFilled);
            SplitContainer2.Panel1.Controls.Add(btnNext);
            SplitContainer2.Panel1.Controls.Add(PictureBox1);
            SplitContainer2.Panel1.Controls.Add(txtOverviewGap);
            // 
            // SplitContainer2.Panel2
            // 
            SplitContainer2.Panel2.Controls.Add(txtOverviewDelay);
            SplitContainer2.Panel2.Controls.Add(btnPrevious);
            SplitContainer2.Panel2.Controls.Add(txtOverviewOpen);
            SplitContainer2.Panel2.Controls.Add(txtOverviewClose);
            SplitContainer2.Panel2Collapsed = true;
            SplitContainer2.Size = new Size(50, 87);
            SplitContainer2.SplitterDistance = 25;
            SplitContainer2.TabIndex = 2;
            SplitContainer2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel3
            // 
            MyLabel3.AutoSize = false;
            MyLabel3.BorderVisible = true;
            MyLabel3.Calculation_Expression = null;
            MyLabel3.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel3.Calculative = false;
            MyLabel3.Column_Name = null;
            MyLabel3.Control_Name = "MyLabel3";
            MyLabel3.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel3.Cursor = Cursors.Hand;
            MyLabel3.Custom_Data = false;
            MyLabel3.Custom_Default = false;
            MyLabel3.Display_Name = null;
            MyLabel3.Field_Description = null;
            MyLabel3.Field_Name = null;
            MyLabel3.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel3.FieldName = null;
            MyLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel3.ForeColor = Color.Black;
            MyLabel3.Generated = false;
            MyLabel3.Location = new Point(3, 3);
            MyLabel3.MendatroryField = false;
            MyLabel3.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel3.Name = "MyLabel3";
            MyLabel3.Size = new Size(61, 21);
            MyLabel3.SourceColumn = null;
            MyLabel3.TabIndex = 3;
            MyLabel3.Text = "Overview";
            MyLabel3.XpertDisplayMember = null;
            MyLabel3.XpertValueMember = null;
            MyLabel3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtOverviewFilled
            // 
            txtOverviewFilled.AutoSize = false;
            txtOverviewFilled.BackColor = Color.White;
            txtOverviewFilled.BorderVisible = true;
            txtOverviewFilled.Calculation_Expression = null;
            txtOverviewFilled.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtOverviewFilled.Calculative = false;
            txtOverviewFilled.Column_Name = null;
            txtOverviewFilled.Control_Name = "txtOverviewFilled";
            txtOverviewFilled.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtOverviewFilled.Cursor = Cursors.Hand;
            txtOverviewFilled.Custom_Data = false;
            txtOverviewFilled.Custom_Default = false;
            txtOverviewFilled.Display_Name = null;
            txtOverviewFilled.Field_Description = null;
            txtOverviewFilled.Field_Name = null;
            txtOverviewFilled.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtOverviewFilled.FieldName = null;
            txtOverviewFilled.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverviewFilled.Generated = false;
            txtOverviewFilled.Location = new Point(57, 28);
            txtOverviewFilled.MaximumSize = new Size(70, 50);
            txtOverviewFilled.MendatroryField = false;
            txtOverviewFilled.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtOverviewFilled.MinimumSize = new Size(70, 50);
            txtOverviewFilled.Name = "txtOverviewFilled";
            // 
            // 
            // 
            txtOverviewFilled.RootElement.MaxSize = new Size(70, 50);
            txtOverviewFilled.RootElement.MinSize = new Size(70, 50);
            txtOverviewFilled.Size = new Size(70, 50);
            txtOverviewFilled.SourceColumn = null;
            txtOverviewFilled.TabIndex = 0;
            txtOverviewFilled.Text = "<html><p>   0.00</p><p>Filled Hrs.</p></html>";
            txtOverviewFilled.XpertDisplayMember = null;
            txtOverviewFilled.XpertValueMember = null;
            txtOverviewFilled.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnNext
            // 
            btnNext.AutoSize = false;
            btnNext.BackColor = Color.Silver;
            btnNext.BorderVisible = true;
            btnNext.Calculation_Expression = null;
            btnNext.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            btnNext.Calculative = false;
            btnNext.Column_Name = null;
            btnNext.Control_Name = "btnNext";
            btnNext.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Custom_Data = false;
            btnNext.Custom_Default = false;
            btnNext.Display_Name = null;
            btnNext.Dock = DockStyle.Right;
            btnNext.Field_Description = null;
            btnNext.Field_Name = null;
            btnNext.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            btnNext.FieldName = null;
            btnNext.Generated = false;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlignment = ContentAlignment.MiddleCenter;
            btnNext.Location = new Point(42, 0);
            btnNext.MaximumSize = new Size(8, 87);
            btnNext.MendatroryField = false;
            btnNext.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            btnNext.MinimumSize = new Size(8, 87);
            btnNext.Name = "btnNext";
            // 
            // 
            // 
            btnNext.RootElement.MaxSize = new Size(8, 87);
            btnNext.RootElement.MinSize = new Size(8, 87);
            btnNext.Size = new Size(8, 87);
            btnNext.SourceColumn = null;
            btnNext.TabIndex = 1;
            btnNext.XpertDisplayMember = null;
            btnNext.XpertValueMember = null;
            btnNext.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImageLayout = ImageLayout.Center;
            PictureBox1.Calculation_Expression = null;
            PictureBox1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            PictureBox1.Calculative = false;
            PictureBox1.Column_Name = null;
            PictureBox1.Control_Name = "PictureBox1";
            PictureBox1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            PictureBox1.Custom_Data = false;
            PictureBox1.Custom_Default = false;
            PictureBox1.Display_Name = null;
            PictureBox1.Field_Description = null;
            PictureBox1.Field_Name = null;
            PictureBox1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            PictureBox1.Generated = false;
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(7, 35);
            PictureBox1.MendatroryField = false;
            PictureBox1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(36, 35);
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            PictureBox1.XpertBindingSource = null;
            PictureBox1.XpertDisplayMember = null;
            PictureBox1.XpertValueMember = null;
            PictureBox1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtOverviewGap
            // 
            txtOverviewGap.AutoSize = false;
            txtOverviewGap.BackColor = Color.White;
            txtOverviewGap.BorderVisible = true;
            txtOverviewGap.Calculation_Expression = null;
            txtOverviewGap.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtOverviewGap.Calculative = false;
            txtOverviewGap.Column_Name = null;
            txtOverviewGap.Control_Name = "txtOverviewGap";
            txtOverviewGap.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtOverviewGap.Cursor = Cursors.Hand;
            txtOverviewGap.Custom_Data = false;
            txtOverviewGap.Custom_Default = false;
            txtOverviewGap.Display_Name = null;
            txtOverviewGap.Field_Description = null;
            txtOverviewGap.Field_Name = null;
            txtOverviewGap.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtOverviewGap.FieldName = null;
            txtOverviewGap.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverviewGap.Generated = false;
            txtOverviewGap.Location = new Point(129, 28);
            txtOverviewGap.MaximumSize = new Size(70, 50);
            txtOverviewGap.MendatroryField = false;
            txtOverviewGap.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtOverviewGap.MinimumSize = new Size(70, 50);
            txtOverviewGap.Name = "txtOverviewGap";
            // 
            // 
            // 
            txtOverviewGap.RootElement.MaxSize = new Size(70, 50);
            txtOverviewGap.RootElement.MinSize = new Size(70, 50);
            txtOverviewGap.Size = new Size(70, 50);
            txtOverviewGap.SourceColumn = null;
            txtOverviewGap.TabIndex = 1;
            txtOverviewGap.Text = "<html><p>   0.00</p><p>Gap Hrs.</p></html>";
            txtOverviewGap.XpertDisplayMember = null;
            txtOverviewGap.XpertValueMember = null;
            txtOverviewGap.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtOverviewDelay
            // 
            txtOverviewDelay.AutoSize = false;
            txtOverviewDelay.BackColor = Color.White;
            txtOverviewDelay.BorderVisible = true;
            txtOverviewDelay.Calculation_Expression = null;
            txtOverviewDelay.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtOverviewDelay.Calculative = false;
            txtOverviewDelay.Column_Name = null;
            txtOverviewDelay.Control_Name = "txtOverviewDelay";
            txtOverviewDelay.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtOverviewDelay.Cursor = Cursors.Hand;
            txtOverviewDelay.Custom_Data = false;
            txtOverviewDelay.Custom_Default = false;
            txtOverviewDelay.Display_Name = null;
            txtOverviewDelay.Field_Description = null;
            txtOverviewDelay.Field_Name = null;
            txtOverviewDelay.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtOverviewDelay.FieldName = null;
            txtOverviewDelay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverviewDelay.Generated = false;
            txtOverviewDelay.Location = new Point(145, 28);
            txtOverviewDelay.MaximumSize = new Size(70, 50);
            txtOverviewDelay.MendatroryField = false;
            txtOverviewDelay.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtOverviewDelay.MinimumSize = new Size(70, 50);
            txtOverviewDelay.Name = "txtOverviewDelay";
            // 
            // 
            // 
            txtOverviewDelay.RootElement.MaxSize = new Size(70, 50);
            txtOverviewDelay.RootElement.MinSize = new Size(70, 50);
            txtOverviewDelay.Size = new Size(70, 50);
            txtOverviewDelay.SourceColumn = null;
            txtOverviewDelay.TabIndex = 5;
            txtOverviewDelay.Text = "<html><p>0.00</p><p><span style=\"font-size: 9pt\">Delay Hrs.</span></p></html>";
            txtOverviewDelay.XpertDisplayMember = null;
            txtOverviewDelay.XpertValueMember = null;
            txtOverviewDelay.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnPrevious
            // 
            btnPrevious.AutoSize = false;
            btnPrevious.BackColor = Color.Silver;
            btnPrevious.BorderVisible = true;
            btnPrevious.Calculation_Expression = null;
            btnPrevious.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            btnPrevious.Calculative = false;
            btnPrevious.Column_Name = null;
            btnPrevious.Control_Name = "btnPrevious";
            btnPrevious.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.Custom_Data = false;
            btnPrevious.Custom_Default = false;
            btnPrevious.Display_Name = null;
            btnPrevious.Dock = DockStyle.Right;
            btnPrevious.Field_Description = null;
            btnPrevious.Field_Name = null;
            btnPrevious.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            btnPrevious.FieldName = null;
            btnPrevious.Generated = false;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlignment = ContentAlignment.MiddleCenter;
            btnPrevious.Location = new Point(88, 0);
            btnPrevious.MaximumSize = new Size(8, 87);
            btnPrevious.MendatroryField = false;
            btnPrevious.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            btnPrevious.MinimumSize = new Size(8, 87);
            btnPrevious.Name = "btnPrevious";
            // 
            // 
            // 
            btnPrevious.RootElement.MaxSize = new Size(8, 87);
            btnPrevious.RootElement.MinSize = new Size(8, 87);
            btnPrevious.Size = new Size(8, 87);
            btnPrevious.SourceColumn = null;
            btnPrevious.TabIndex = 2;
            btnPrevious.XpertDisplayMember = null;
            btnPrevious.XpertValueMember = null;
            btnPrevious.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtOverviewOpen
            // 
            txtOverviewOpen.AutoSize = false;
            txtOverviewOpen.BackColor = Color.White;
            txtOverviewOpen.BorderVisible = true;
            txtOverviewOpen.Calculation_Expression = null;
            txtOverviewOpen.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtOverviewOpen.Calculative = false;
            txtOverviewOpen.Column_Name = null;
            txtOverviewOpen.Control_Name = "txtOverviewOpen";
            txtOverviewOpen.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtOverviewOpen.Cursor = Cursors.Hand;
            txtOverviewOpen.Custom_Data = false;
            txtOverviewOpen.Custom_Default = false;
            txtOverviewOpen.Display_Name = null;
            txtOverviewOpen.Field_Description = null;
            txtOverviewOpen.Field_Name = null;
            txtOverviewOpen.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtOverviewOpen.FieldName = null;
            txtOverviewOpen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverviewOpen.Generated = false;
            txtOverviewOpen.Location = new Point(1, 28);
            txtOverviewOpen.MaximumSize = new Size(70, 50);
            txtOverviewOpen.MendatroryField = false;
            txtOverviewOpen.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtOverviewOpen.MinimumSize = new Size(70, 50);
            txtOverviewOpen.Name = "txtOverviewOpen";
            // 
            // 
            // 
            txtOverviewOpen.RootElement.MaxSize = new Size(70, 50);
            txtOverviewOpen.RootElement.MinSize = new Size(70, 50);
            txtOverviewOpen.Size = new Size(70, 50);
            txtOverviewOpen.SourceColumn = null;
            txtOverviewOpen.TabIndex = 3;
            txtOverviewOpen.Text = "<html><p>0.00</p><p><span style=\"font-size: 9pt\">Open</span></p></html>";
            txtOverviewOpen.XpertDisplayMember = null;
            txtOverviewOpen.XpertValueMember = null;
            txtOverviewOpen.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtOverviewClose
            // 
            txtOverviewClose.AutoSize = false;
            txtOverviewClose.BackColor = Color.White;
            txtOverviewClose.BorderVisible = true;
            txtOverviewClose.Calculation_Expression = null;
            txtOverviewClose.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtOverviewClose.Calculative = false;
            txtOverviewClose.Column_Name = null;
            txtOverviewClose.Control_Name = "txtOverviewClose";
            txtOverviewClose.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtOverviewClose.Cursor = Cursors.Hand;
            txtOverviewClose.Custom_Data = false;
            txtOverviewClose.Custom_Default = false;
            txtOverviewClose.Display_Name = null;
            txtOverviewClose.Field_Description = null;
            txtOverviewClose.Field_Name = null;
            txtOverviewClose.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtOverviewClose.FieldName = null;
            txtOverviewClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOverviewClose.Generated = false;
            txtOverviewClose.Location = new Point(73, 28);
            txtOverviewClose.MaximumSize = new Size(70, 50);
            txtOverviewClose.MendatroryField = false;
            txtOverviewClose.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtOverviewClose.MinimumSize = new Size(70, 50);
            txtOverviewClose.Name = "txtOverviewClose";
            // 
            // 
            // 
            txtOverviewClose.RootElement.MaxSize = new Size(70, 50);
            txtOverviewClose.RootElement.MinSize = new Size(70, 50);
            txtOverviewClose.Size = new Size(70, 50);
            txtOverviewClose.SourceColumn = null;
            txtOverviewClose.TabIndex = 4;
            txtOverviewClose.Text = "<html><p>   0.00</p><p>Close</p></html>";
            txtOverviewClose.XpertDisplayMember = null;
            txtOverviewClose.XpertValueMember = null;
            txtOverviewClose.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageView1
            // 
            RadPageView1.BackColor = SystemColors.ActiveCaption;
            RadPageView1.BorderColor = Color.Black;
            RadPageView1.Control_Name = "RadPageView1";
            RadPageView1.Controls.Add(RadPageViewPage1);
            RadPageView1.Location = new Point(0, 43);
            RadPageView1.Margin = new Padding(0);
            RadPageView1.Name = "RadPageView1";
            RadPageView1.SelectedPage = RadPageViewPage1;
            RadPageView1.Size = new Size(1055, 495);
            RadPageView1.TabIndex = 34;
            RadPageView1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView1.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView1.GetChildAt(0)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView1.GetChildAt(0)).Padding = new Padding(0);
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).Title = "Time Sheet Dashboard";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).Description = "LMS";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor2 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor3 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor4 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).Text = "Time Sheet Dashboard";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = Color.White;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView1.GetChildAt(0).GetChildAt(1)).BackColor = SystemColors.ActiveCaption;
            // 
            // RadPageViewPage1
            // 
            RadPageViewPage1.BackColor = SystemColors.ActiveCaption;
            RadPageViewPage1.Controls.Add(Panel23);
            RadPageViewPage1.Controls.Add(Panel22);
            RadPageViewPage1.Controls.Add(RadPageView2);
            RadPageViewPage1.Controls.Add(SplitContainer2);
            RadPageViewPage1.Description = "LMS";
            RadPageViewPage1.ItemSize = new SizeF(129F, 28F);
            RadPageViewPage1.Location = new Point(5, 32);
            RadPageViewPage1.Name = "RadPageViewPage1";
            RadPageViewPage1.Size = new Size(1045, 458);
            RadPageViewPage1.Text = "Time Sheet Dashboard";
            RadPageViewPage1.Title = "Time Sheet Dashboard";
            // 
            // Panel23
            // 
            Panel23.BackColor = SystemColors.ControlLight;
            Panel23.Control_Name = "Panel23";
            Panel23.Dock = DockStyle.Top;
            Panel23.Location = new Point(0, 42);
            Panel23.Name = "Panel23";
            Panel23.Size = new Size(1045, 43);
            Panel23.TabIndex = 18;
            Panel23.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Panel22
            // 
            Panel22.Control_Name = "Panel22";
            Panel22.Dock = DockStyle.Top;
            Panel22.Location = new Point(0, 0);
            Panel22.Name = "Panel22";
            Panel22.Size = new Size(1045, 42);
            Panel22.TabIndex = 17;
            Panel22.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageView2
            // 
            RadPageView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RadPageView2.BorderColor = Color.Black;
            RadPageView2.Control_Name = "RadPageView2";
            RadPageView2.Controls.Add(RadPageViewPage2);
            RadPageView2.Controls.Add(RadPageViewPage3);
            RadPageView2.Controls.Add(RadPageViewPage6);
            RadPageView2.DefaultPage = RadPageViewPage2;
            RadPageView2.Location = new Point(7, 104);
            RadPageView2.Name = "RadPageView2";
            RadPageView2.SelectedPage = RadPageViewPage3;
            RadPageView2.Size = new Size(791, 370);
            RadPageView2.TabIndex = 6;
            RadPageView2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView2.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView2.GetChildAt(0)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView2.GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView2.GetChildAt(0)).Padding = new Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)RadPageView2.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.StripViewItemLayout)RadPageView2.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BorderTopWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BorderRightWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BorderColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView2.GetChildAt(0).GetChildAt(1)).Padding = new Padding(0);
            // 
            // RadPageViewPage2
            // 
            RadPageViewPage2.BackColor = Color.White;
            RadPageViewPage2.Controls.Add(Pnl_Type);
            RadPageViewPage2.Description = "Calender";
            RadPageViewPage2.ItemSize = new SizeF(121F, 28F);
            RadPageViewPage2.Location = new Point(1, 28);
            RadPageViewPage2.Name = "RadPageViewPage2";
            RadPageViewPage2.Size = new Size(789, 341);
            RadPageViewPage2.Text = "Time-Sheet Calender";
            RadPageViewPage2.Title = "Calender";
            // 
            // Pnl_Type
            // 
            Pnl_Type.BackColor = Color.White;
            Pnl_Type.BorderStyle = BorderStyle.Fixed3D;
            Pnl_Type.Control_Name = "Pnl_Type";
            Pnl_Type.Dock = DockStyle.Top;
            Pnl_Type.Location = new Point(0, 0);
            Pnl_Type.Name = "Pnl_Type";
            Pnl_Type.Size = new Size(789, 27);
            Pnl_Type.TabIndex = 28;
            Pnl_Type.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage3
            // 
            RadPageViewPage3.BackColor = SystemColors.ControlLight;
            RadPageViewPage3.Controls.Add(RadPageView3);
            RadPageViewPage3.Description = "Leave Type";
            RadPageViewPage3.ItemSize = new SizeF(104F, 28F);
            RadPageViewPage3.Location = new Point(1, 28);
            RadPageViewPage3.Name = "RadPageViewPage3";
            RadPageViewPage3.Size = new Size(789, 341);
            RadPageViewPage3.Text = "Ticket/Task Detail";
            RadPageViewPage3.Title = "Leave Type";
            // 
            // RadPageView3
            // 
            RadPageView3.BorderColor = Color.Black;
            RadPageView3.Control_Name = "RadPageView3";
            RadPageView3.Controls.Add(rdAllKRAList_PriorityChange);
            RadPageView3.Controls.Add(rdTimeSheet);
            RadPageView3.Controls.Add(rdAwaitedWork);
            RadPageView3.Controls.Add(rdDayToDay);
            RadPageView3.Controls.Add(rdDone);
            RadPageView3.Controls.Add(rdNotDone);
            RadPageView3.DefaultPage = rdAllKRAList_PriorityChange;
            RadPageView3.Dock = DockStyle.Fill;
            RadPageView3.Location = new Point(0, 0);
            RadPageView3.Name = "RadPageView3";
            RadPageView3.SelectedPage = rdAllKRAList_PriorityChange;
            RadPageView3.Size = new Size(789, 341);
            RadPageView3.TabIndex = 7;
            RadPageView3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView3.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView3.GetChildAt(0)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView3.GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView3.GetChildAt(0)).Padding = new Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)RadPageView3.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.StripViewItemLayout)RadPageView3.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).BorderTopWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).BorderRightWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView3.GetChildAt(0).GetChildAt(1)).Padding = new Padding(3);
            // 
            // rdAllKRAList_PriorityChange
            // 
            rdAllKRAList_PriorityChange.Controls.Add(gvKRA);
            rdAllKRAList_PriorityChange.Controls.Add(Panel10);
            rdAllKRAList_PriorityChange.Description = "KRA(Work) List";
            rdAllKRAList_PriorityChange.ItemSize = new SizeF(90F, 28F);
            rdAllKRAList_PriorityChange.Location = new Point(4, 31);
            rdAllKRAList_PriorityChange.Name = "rdAllKRAList_PriorityChange";
            rdAllKRAList_PriorityChange.Size = new Size(781, 306);
            rdAllKRAList_PriorityChange.Text = "KRA(Work) List";
            rdAllKRAList_PriorityChange.Title = "KRA(Work) List";
            // 
            // gvKRA
            // 
            gvKRA.BackColor = SystemColors.ActiveCaption;
            gvKRA.Calculation_Expression = null;
            gvKRA.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvKRA.Calculative = false;
            gvKRA.Class_Name = null;
            gvKRA.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvKRA.Column_Name = null;
            gvKRA.Control_Name = "gvKRA";
            gvKRA.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvKRA.Custom_Data = false;
            gvKRA.Custom_Default = false;
            gvKRA.Display_Name = null;
            gvKRA.Dock = DockStyle.Fill;
            gvKRA.Field_Description = null;
            gvKRA.Field_Name = null;
            gvKRA.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvKRA.Generated = false;
            gvKRA.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvKRA.Location = new Point(0, 27);
            // 
            // 
            // 
            gvKRA.MasterTemplate.ShowHeaderCellButtons = true;
            gvKRA.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gvKRA.MendatroryField = false;
            gvKRA.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvKRA.MultiSelection = false;
            gvKRA.Name = "gvKRA";
            gvKRA.Padding = new Padding(0, 10, 0, 0);
            gvKRA.ShowHeaderCellButtons = true;
            gvKRA.Size = new Size(781, 279);
            gvKRA.TabIndex = 49;
            gvKRA.Table_Name = null;
            gvKRA.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvKRA.XpertDisplayMember = null;
            gvKRA.XpertValueMember = null;
            gvKRA.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvKRA.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvKRA.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvKRA.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel10
            // 
            Panel10.BackColor = Color.Transparent;
            Panel10.BorderStyle = BorderStyle.Fixed3D;
            Panel10.Control_Name = "Panel10";
            Panel10.Controls.Add(btnRefresh_KRA);
            Panel10.Dock = DockStyle.Top;
            Panel10.Location = new Point(0, 0);
            Panel10.Name = "Panel10";
            Panel10.Size = new Size(781, 27);
            Panel10.TabIndex = 47;
            Panel10.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnRefresh_KRA
            // 
            btnRefresh_KRA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh_KRA.Location = new Point(753, 1);
            btnRefresh_KRA.Margin = new Padding(4, 3, 4, 3);
            btnRefresh_KRA.MaximumSize = new Size(20, 20);
            btnRefresh_KRA.MinimumSize = new Size(20, 20);
            btnRefresh_KRA.Name = "btnRefresh_KRA";
            // 
            // 
            // 
            btnRefresh_KRA.RootElement.MaxSize = new Size(20, 20);
            btnRefresh_KRA.RootElement.MinSize = new Size(20, 20);
            btnRefresh_KRA.Size = new Size(20, 20);
            btnRefresh_KRA.TabIndex = 1;
            // 
            // rdTimeSheet
            // 
            rdTimeSheet.BackColor = SystemColors.ControlLight;
            rdTimeSheet.Controls.Add(RadPageView4);
            rdTimeSheet.Description = "Calender";
            rdTimeSheet.ItemSize = new SizeF(69F, 28F);
            rdTimeSheet.Location = new Point(4, 31);
            rdTimeSheet.Name = "rdTimeSheet";
            rdTimeSheet.Size = new Size(781, 306);
            rdTimeSheet.Text = "TimeSheet";
            rdTimeSheet.Title = "Calender";
            // 
            // RadPageView4
            // 
            RadPageView4.BorderColor = Color.Black;
            RadPageView4.Control_Name = "RadPageView4";
            RadPageView4.Controls.Add(RadPageViewPage4);
            RadPageView4.Controls.Add(RadPageViewPage5);
            RadPageView4.Controls.Add(RadPageViewPage14);
            RadPageView4.Controls.Add(RadPageViewPage13);
            RadPageView4.Controls.Add(RadPageViewPage15);
            RadPageView4.Controls.Add(rdHeldup);
            RadPageView4.Controls.Add(rdExpire);
            RadPageView4.DefaultPage = RadPageViewPage4;
            RadPageView4.Dock = DockStyle.Fill;
            RadPageView4.Location = new Point(0, 0);
            RadPageView4.Name = "RadPageView4";
            RadPageView4.SelectedPage = RadPageViewPage4;
            RadPageView4.Size = new Size(781, 306);
            RadPageView4.TabIndex = 8;
            RadPageView4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).Padding = new Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)RadPageView4.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.StripViewItemLayout)RadPageView4.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderTopWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderRightWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).Padding = new Padding(3);
            // 
            // RadPageViewPage4
            // 
            RadPageViewPage4.BackColor = SystemColors.ControlLight;
            RadPageViewPage4.Controls.Add(gvList);
            RadPageViewPage4.Controls.Add(Panel6);
            RadPageViewPage4.Description = "Calender";
            RadPageViewPage4.Location = new Point(4, 31);
            RadPageViewPage4.Name = "RadPageViewPage4";
            RadPageViewPage4.Size = new Size(773, 271);
            RadPageViewPage4.Text = "TimeSheet";
            RadPageViewPage4.Title = "Calender";
            // 
            // gvList
            // 
            gvList.BackColor = SystemColors.ActiveCaption;
            gvList.Calculation_Expression = null;
            gvList.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvList.Calculative = false;
            gvList.Class_Name = null;
            gvList.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvList.Column_Name = null;
            gvList.Control_Name = "gvList";
            gvList.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvList.Custom_Data = false;
            gvList.Custom_Default = false;
            gvList.Display_Name = null;
            gvList.Dock = DockStyle.Fill;
            gvList.Field_Description = null;
            gvList.Field_Name = null;
            gvList.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvList.Generated = false;
            gvList.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvList.Location = new Point(0, 30);
            // 
            // 
            // 
            gvList.MasterTemplate.ShowHeaderCellButtons = true;
            gvList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            gvList.MendatroryField = false;
            gvList.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvList.MultiSelection = false;
            gvList.Name = "gvList";
            gvList.Padding = new Padding(0, 10, 0, 0);
            gvList.ShowHeaderCellButtons = true;
            gvList.Size = new Size(773, 241);
            gvList.TabIndex = 7;
            gvList.Table_Name = null;
            gvList.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvList.XpertDisplayMember = null;
            gvList.XpertValueMember = null;
            gvList.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvList.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvList.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvList.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel6
            // 
            Panel6.BackColor = Color.White;
            Panel6.BorderStyle = BorderStyle.Fixed3D;
            Panel6.Control_Name = "Panel6";
            Panel6.Controls.Add(btnSendApp);
            Panel6.Controls.Add(MyLabel4);
            Panel6.Controls.Add(Panel2);
            Panel6.Controls.Add(btnTicketType);
            Panel6.Controls.Add(lblTicketTypeName);
            Panel6.Dock = DockStyle.Top;
            Panel6.Location = new Point(0, 0);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(773, 30);
            Panel6.TabIndex = 10;
            Panel6.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnSendApp
            // 
            btnSendApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSendApp.Location = new Point(675, 1);
            btnSendApp.Margin = new Padding(4, 3, 4, 3);
            btnSendApp.MaximumSize = new Size(72, 21);
            btnSendApp.MinimumSize = new Size(72, 21);
            btnSendApp.Name = "btnSendApp";
            // 
            // 
            // 
            btnSendApp.RootElement.MaxSize = new Size(72, 21);
            btnSendApp.RootElement.MinSize = new Size(72, 21);
            btnSendApp.Size = new Size(72, 21);
            btnSendApp.TabIndex = 34;
            // 
            // MyLabel4
            // 
            MyLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MyLabel4.AutoSize = false;
            MyLabel4.BorderVisible = true;
            MyLabel4.Calculation_Expression = null;
            MyLabel4.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel4.Calculative = false;
            MyLabel4.Column_Name = null;
            MyLabel4.Control_Name = "MyLabel4";
            MyLabel4.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel4.Cursor = Cursors.Hand;
            MyLabel4.Custom_Data = false;
            MyLabel4.Custom_Default = false;
            MyLabel4.Display_Name = null;
            MyLabel4.Field_Description = null;
            MyLabel4.Field_Name = null;
            MyLabel4.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel4.FieldName = null;
            MyLabel4.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel4.ForeColor = Color.Black;
            MyLabel4.Generated = false;
            MyLabel4.Location = new Point(566, 4);
            MyLabel4.MendatroryField = false;
            MyLabel4.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel4.Name = "MyLabel4";
            MyLabel4.Size = new Size(105, 15);
            MyLabel4.SourceColumn = null;
            MyLabel4.TabIndex = 30;
            MyLabel4.Text = "Manual Timesheet Filled";
            MyLabel4.XpertDisplayMember = null;
            MyLabel4.XpertValueMember = null;
            MyLabel4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel2.BackColor = Color.Silver;
            Panel2.BorderStyle = BorderStyle.Fixed3D;
            Panel2.Control_Name = "Panel2";
            Panel2.Location = new Point(549, 4);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(16, 16);
            Panel2.TabIndex = 29;
            Panel2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnTicketType
            // 
            btnTicketType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTicketType.BackColor = SystemColors.ActiveCaption;
            btnTicketType.Image = (Image)resources.GetObject("btnTicketType.Image");
            btnTicketType.ImageAlignment = ContentAlignment.MiddleCenter;
            btnTicketType.Items.AddRange(new Telerik.WinControls.RadItem[] { btnAll, btnFilled, btnNotFilled, btnDaySheet });
            btnTicketType.Location = new Point(751, 1);
            btnTicketType.Name = "btnTicketType";
            btnTicketType.ShowArrow = false;
            btnTicketType.Size = new Size(20, 20);
            btnTicketType.TabIndex = 0;
            // 
            // btnAll
            // 
            btnAll.Name = "btnAll";
            btnAll.Text = "All";
            btnAll.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // btnFilled
            // 
            btnFilled.Name = "btnFilled";
            btnFilled.Text = "Filled";
            // 
            // btnNotFilled
            // 
            btnNotFilled.Name = "btnNotFilled";
            btnNotFilled.Text = "Not Filled";
            // 
            // btnDaySheet
            // 
            btnDaySheet.Name = "btnDaySheet";
            btnDaySheet.Text = "Day-Sheet";
            // 
            // lblTicketTypeName
            // 
            lblTicketTypeName.AutoSize = false;
            lblTicketTypeName.BorderVisible = true;
            lblTicketTypeName.Calculation_Expression = null;
            lblTicketTypeName.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblTicketTypeName.Calculative = false;
            lblTicketTypeName.Column_Name = null;
            lblTicketTypeName.Control_Name = "lblTicketTypeName";
            lblTicketTypeName.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblTicketTypeName.Cursor = Cursors.Hand;
            lblTicketTypeName.Custom_Data = false;
            lblTicketTypeName.Custom_Default = false;
            lblTicketTypeName.Display_Name = null;
            lblTicketTypeName.Field_Description = null;
            lblTicketTypeName.Field_Name = null;
            lblTicketTypeName.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblTicketTypeName.FieldName = null;
            lblTicketTypeName.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketTypeName.Generated = false;
            lblTicketTypeName.Location = new Point(3, 1);
            lblTicketTypeName.MendatroryField = false;
            lblTicketTypeName.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblTicketTypeName.Name = "lblTicketTypeName";
            lblTicketTypeName.Size = new Size(65, 16);
            lblTicketTypeName.SourceColumn = null;
            lblTicketTypeName.TabIndex = 28;
            lblTicketTypeName.Text = "Ticket Type";
            lblTicketTypeName.XpertDisplayMember = null;
            lblTicketTypeName.XpertValueMember = null;
            lblTicketTypeName.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage5
            // 
            RadPageViewPage5.BackColor = SystemColors.ControlLight;
            RadPageViewPage5.Controls.Add(SplitContainer5);
            RadPageViewPage5.Description = "Leave Type";
            RadPageViewPage5.Location = new Point(4, 31);
            RadPageViewPage5.Name = "RadPageViewPage5";
            RadPageViewPage5.Size = new Size(1107, 339);
            RadPageViewPage5.Text = "Gap Hours Detail";
            RadPageViewPage5.Title = "Leave Type";
            // 
            // SplitContainer5
            // 
            SplitContainer5.Control_Name = "SplitContainer5";
            SplitContainer5.Dock = DockStyle.Fill;
            SplitContainer5.Location = new Point(0, 0);
            SplitContainer5.Name = "SplitContainer5";
            // 
            // SplitContainer5.Panel1
            // 
            SplitContainer5.Panel1.Controls.Add(gvManual);
            SplitContainer5.Panel1.Controls.Add(Panel3);
            SplitContainer5.Panel1.Padding = new Padding(1);
            // 
            // SplitContainer5.Panel2
            // 
            SplitContainer5.Panel2.Controls.Add(gv_Auto);
            SplitContainer5.Panel2.Controls.Add(Panel5);
            SplitContainer5.Panel2.Padding = new Padding(1);
            SplitContainer5.Size = new Size(1107, 339);
            SplitContainer5.SplitterDistance = 527;
            SplitContainer5.TabIndex = 0;
            SplitContainer5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvManual
            // 
            gvManual.BackColor = Color.White;
            gvManual.Calculation_Expression = null;
            gvManual.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvManual.Calculative = false;
            gvManual.Class_Name = null;
            gvManual.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvManual.Column_Name = null;
            gvManual.Control_Name = "gvManual";
            gvManual.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvManual.Custom_Data = false;
            gvManual.Custom_Default = false;
            gvManual.Display_Name = null;
            gvManual.Dock = DockStyle.Fill;
            gvManual.Field_Description = null;
            gvManual.Field_Name = null;
            gvManual.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvManual.Generated = false;
            gvManual.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvManual.Location = new Point(1, 25);
            // 
            // 
            // 
            gvManual.MasterTemplate.ShowHeaderCellButtons = true;
            gvManual.MasterTemplate.ViewDefinition = tableViewDefinition3;
            gvManual.MendatroryField = false;
            gvManual.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvManual.MultiSelection = false;
            gvManual.Name = "gvManual";
            gvManual.Padding = new Padding(0, 10, 0, 0);
            gvManual.ShowHeaderCellButtons = true;
            gvManual.Size = new Size(525, 313);
            gvManual.TabIndex = 11;
            gvManual.Table_Name = null;
            gvManual.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvManual.XpertDisplayMember = null;
            gvManual.XpertValueMember = null;
            gvManual.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvManual.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvManual.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvManual.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.BorderStyle = BorderStyle.Fixed3D;
            Panel3.Control_Name = "Panel3";
            Panel3.Controls.Add(UcRefreshIconButton1);
            Panel3.Controls.Add(MyLabel6);
            Panel3.Dock = DockStyle.Top;
            Panel3.Location = new Point(1, 1);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(525, 24);
            Panel3.TabIndex = 12;
            Panel3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcRefreshIconButton1
            // 
            UcRefreshIconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UcRefreshIconButton1.Location = new Point(498, 0);
            UcRefreshIconButton1.Margin = new Padding(4, 3, 4, 3);
            UcRefreshIconButton1.MaximumSize = new Size(20, 20);
            UcRefreshIconButton1.MinimumSize = new Size(20, 20);
            UcRefreshIconButton1.Name = "UcRefreshIconButton1";
            // 
            // 
            // 
            UcRefreshIconButton1.RootElement.MaxSize = new Size(20, 20);
            UcRefreshIconButton1.RootElement.MinSize = new Size(20, 20);
            UcRefreshIconButton1.Size = new Size(20, 20);
            UcRefreshIconButton1.TabIndex = 29;
            // 
            // MyLabel6
            // 
            MyLabel6.AutoSize = false;
            MyLabel6.BorderVisible = true;
            MyLabel6.Calculation_Expression = null;
            MyLabel6.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel6.Calculative = false;
            MyLabel6.Column_Name = null;
            MyLabel6.Control_Name = "MyLabel6";
            MyLabel6.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel6.Cursor = Cursors.Hand;
            MyLabel6.Custom_Data = false;
            MyLabel6.Custom_Default = false;
            MyLabel6.Display_Name = null;
            MyLabel6.Field_Description = null;
            MyLabel6.Field_Name = null;
            MyLabel6.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel6.FieldName = null;
            MyLabel6.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel6.Generated = false;
            MyLabel6.Location = new Point(3, 1);
            MyLabel6.MendatroryField = false;
            MyLabel6.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel6.Name = "MyLabel6";
            MyLabel6.Size = new Size(105, 16);
            MyLabel6.SourceColumn = null;
            MyLabel6.TabIndex = 28;
            MyLabel6.Text = "Manual based gaps";
            MyLabel6.XpertDisplayMember = null;
            MyLabel6.XpertValueMember = null;
            MyLabel6.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gv_Auto
            // 
            gv_Auto.BackColor = Color.White;
            gv_Auto.Calculation_Expression = null;
            gv_Auto.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gv_Auto.Calculative = false;
            gv_Auto.Class_Name = null;
            gv_Auto.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gv_Auto.Column_Name = null;
            gv_Auto.Control_Name = "gv_Auto";
            gv_Auto.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gv_Auto.Custom_Data = false;
            gv_Auto.Custom_Default = false;
            gv_Auto.Display_Name = null;
            gv_Auto.Dock = DockStyle.Fill;
            gv_Auto.Field_Description = null;
            gv_Auto.Field_Name = null;
            gv_Auto.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gv_Auto.Generated = false;
            gv_Auto.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gv_Auto.Location = new Point(1, 25);
            // 
            // 
            // 
            gv_Auto.MasterTemplate.ShowHeaderCellButtons = true;
            gv_Auto.MasterTemplate.ViewDefinition = tableViewDefinition4;
            gv_Auto.MendatroryField = false;
            gv_Auto.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gv_Auto.MultiSelection = false;
            gv_Auto.Name = "gv_Auto";
            gv_Auto.Padding = new Padding(0, 10, 0, 0);
            gv_Auto.ShowHeaderCellButtons = true;
            gv_Auto.Size = new Size(574, 313);
            gv_Auto.TabIndex = 11;
            gv_Auto.Table_Name = null;
            gv_Auto.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gv_Auto.XpertDisplayMember = null;
            gv_Auto.XpertValueMember = null;
            gv_Auto.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gv_Auto.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gv_Auto.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gv_Auto.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.White;
            Panel5.BorderStyle = BorderStyle.Fixed3D;
            Panel5.Control_Name = "Panel5";
            Panel5.Controls.Add(MyLabel9);
            Panel5.Dock = DockStyle.Top;
            Panel5.Location = new Point(1, 1);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(574, 24);
            Panel5.TabIndex = 12;
            Panel5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel9
            // 
            MyLabel9.AutoSize = false;
            MyLabel9.BorderVisible = true;
            MyLabel9.Calculation_Expression = null;
            MyLabel9.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel9.Calculative = false;
            MyLabel9.Column_Name = null;
            MyLabel9.Control_Name = "MyLabel9";
            MyLabel9.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel9.Cursor = Cursors.Hand;
            MyLabel9.Custom_Data = false;
            MyLabel9.Custom_Default = false;
            MyLabel9.Display_Name = null;
            MyLabel9.Field_Description = null;
            MyLabel9.Field_Name = null;
            MyLabel9.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel9.FieldName = null;
            MyLabel9.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel9.Generated = false;
            MyLabel9.Location = new Point(3, 1);
            MyLabel9.MendatroryField = false;
            MyLabel9.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel9.Name = "MyLabel9";
            MyLabel9.Size = new Size(91, 16);
            MyLabel9.SourceColumn = null;
            MyLabel9.TabIndex = 28;
            MyLabel9.Text = "Auto based gaps";
            MyLabel9.XpertDisplayMember = null;
            MyLabel9.XpertValueMember = null;
            MyLabel9.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage14
            // 
            RadPageViewPage14.Controls.Add(gvEducation);
            RadPageViewPage14.Location = new Point(4, 31);
            RadPageViewPage14.Name = "RadPageViewPage14";
            RadPageViewPage14.Size = new Size(1107, 316);
            RadPageViewPage14.Text = "Education Work";
            // 
            // gvEducation
            // 
            gvEducation.BackColor = SystemColors.ActiveCaption;
            gvEducation.Calculation_Expression = null;
            gvEducation.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvEducation.Calculative = false;
            gvEducation.Class_Name = null;
            gvEducation.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvEducation.Column_Name = null;
            gvEducation.Control_Name = "gvEducation";
            gvEducation.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvEducation.Custom_Data = false;
            gvEducation.Custom_Default = false;
            gvEducation.Display_Name = null;
            gvEducation.Dock = DockStyle.Fill;
            gvEducation.Field_Description = null;
            gvEducation.Field_Name = null;
            gvEducation.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvEducation.Generated = false;
            gvEducation.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvEducation.Location = new Point(0, 0);
            // 
            // 
            // 
            gvEducation.MasterTemplate.ShowHeaderCellButtons = true;
            gvEducation.MasterTemplate.ViewDefinition = tableViewDefinition5;
            gvEducation.MendatroryField = false;
            gvEducation.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvEducation.MultiSelection = false;
            gvEducation.Name = "gvEducation";
            gvEducation.Padding = new Padding(0, 10, 0, 0);
            gvEducation.ShowHeaderCellButtons = true;
            gvEducation.Size = new Size(1107, 316);
            gvEducation.TabIndex = 8;
            gvEducation.Table_Name = null;
            gvEducation.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvEducation.XpertDisplayMember = null;
            gvEducation.XpertValueMember = null;
            gvEducation.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvEducation.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvEducation.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvEducation.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // RadPageViewPage13
            // 
            RadPageViewPage13.Controls.Add(SplitContainer9);
            RadPageViewPage13.Location = new Point(4, 31);
            RadPageViewPage13.Name = "RadPageViewPage13";
            RadPageViewPage13.Size = new Size(1107, 316);
            RadPageViewPage13.Text = "Common Awaited";
            // 
            // SplitContainer9
            // 
            SplitContainer9.Control_Name = "SplitContainer9";
            SplitContainer9.Dock = DockStyle.Fill;
            SplitContainer9.FixedPanel = FixedPanel.Panel1;
            SplitContainer9.Location = new Point(0, 0);
            SplitContainer9.Name = "SplitContainer9";
            SplitContainer9.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer9.Panel1
            // 
            SplitContainer9.Panel1.Controls.Add(Panel19);
            // 
            // SplitContainer9.Panel2
            // 
            SplitContainer9.Panel2.Controls.Add(gvAwaitedCommon);
            SplitContainer9.Size = new Size(1107, 316);
            SplitContainer9.SplitterDistance = 29;
            SplitContainer9.TabIndex = 54;
            SplitContainer9.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Panel19
            // 
            Panel19.BackColor = Color.Transparent;
            Panel19.BorderStyle = BorderStyle.Fixed3D;
            Panel19.Control_Name = "Panel19";
            Panel19.Controls.Add(lblCountlistAwited);
            Panel19.Controls.Add(btnRefreshAwaited);
            Panel19.Dock = DockStyle.Top;
            Panel19.Location = new Point(0, 0);
            Panel19.Name = "Panel19";
            Panel19.Size = new Size(1107, 27);
            Panel19.TabIndex = 52;
            Panel19.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblCountlistAwited
            // 
            lblCountlistAwited.AutoSize = false;
            lblCountlistAwited.BorderVisible = true;
            lblCountlistAwited.Calculation_Expression = null;
            lblCountlistAwited.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblCountlistAwited.Calculative = false;
            lblCountlistAwited.Column_Name = null;
            lblCountlistAwited.Control_Name = "lblCountlistAwited";
            lblCountlistAwited.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblCountlistAwited.Cursor = Cursors.Hand;
            lblCountlistAwited.Custom_Data = false;
            lblCountlistAwited.Custom_Default = false;
            lblCountlistAwited.Display_Name = null;
            lblCountlistAwited.Field_Description = null;
            lblCountlistAwited.Field_Name = null;
            lblCountlistAwited.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblCountlistAwited.FieldName = null;
            lblCountlistAwited.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountlistAwited.Generated = false;
            lblCountlistAwited.Location = new Point(1, 3);
            lblCountlistAwited.MendatroryField = false;
            lblCountlistAwited.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblCountlistAwited.Name = "lblCountlistAwited";
            lblCountlistAwited.Size = new Size(40, 16);
            lblCountlistAwited.SourceColumn = null;
            lblCountlistAwited.TabIndex = 27;
            lblCountlistAwited.Text = "List : 0";
            lblCountlistAwited.XpertDisplayMember = null;
            lblCountlistAwited.XpertValueMember = null;
            lblCountlistAwited.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnRefreshAwaited
            // 
            btnRefreshAwaited.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshAwaited.Location = new Point(1079, 1);
            btnRefreshAwaited.Margin = new Padding(4, 3, 4, 3);
            btnRefreshAwaited.MaximumSize = new Size(20, 20);
            btnRefreshAwaited.MinimumSize = new Size(20, 20);
            btnRefreshAwaited.Name = "btnRefreshAwaited";
            // 
            // 
            // 
            btnRefreshAwaited.RootElement.MaxSize = new Size(20, 20);
            btnRefreshAwaited.RootElement.MinSize = new Size(20, 20);
            btnRefreshAwaited.Size = new Size(20, 20);
            btnRefreshAwaited.TabIndex = 1;
            // 
            // gvAwaitedCommon
            // 
            gvAwaitedCommon.BackColor = SystemColors.ActiveCaption;
            gvAwaitedCommon.Calculation_Expression = null;
            gvAwaitedCommon.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvAwaitedCommon.Calculative = false;
            gvAwaitedCommon.Class_Name = null;
            gvAwaitedCommon.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvAwaitedCommon.Column_Name = null;
            gvAwaitedCommon.Control_Name = "gvAwaitedCommon";
            gvAwaitedCommon.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvAwaitedCommon.Custom_Data = false;
            gvAwaitedCommon.Custom_Default = false;
            gvAwaitedCommon.Display_Name = null;
            gvAwaitedCommon.Dock = DockStyle.Fill;
            gvAwaitedCommon.Field_Description = null;
            gvAwaitedCommon.Field_Name = null;
            gvAwaitedCommon.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvAwaitedCommon.Generated = false;
            gvAwaitedCommon.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvAwaitedCommon.Location = new Point(0, 0);
            // 
            // 
            // 
            gvAwaitedCommon.MasterTemplate.ShowHeaderCellButtons = true;
            gvAwaitedCommon.MasterTemplate.ViewDefinition = tableViewDefinition6;
            gvAwaitedCommon.MendatroryField = false;
            gvAwaitedCommon.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvAwaitedCommon.MultiSelection = false;
            gvAwaitedCommon.Name = "gvAwaitedCommon";
            gvAwaitedCommon.Padding = new Padding(0, 10, 0, 0);
            gvAwaitedCommon.ShowHeaderCellButtons = true;
            gvAwaitedCommon.Size = new Size(1107, 283);
            gvAwaitedCommon.TabIndex = 51;
            gvAwaitedCommon.Table_Name = null;
            gvAwaitedCommon.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvAwaitedCommon.XpertDisplayMember = null;
            gvAwaitedCommon.XpertValueMember = null;
            gvAwaitedCommon.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvAwaitedCommon.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvAwaitedCommon.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvAwaitedCommon.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // RadPageViewPage15
            // 
            RadPageViewPage15.Controls.Add(SplitContainer10);
            RadPageViewPage15.Location = new Point(4, 31);
            RadPageViewPage15.Name = "RadPageViewPage15";
            RadPageViewPage15.Size = new Size(1107, 316);
            RadPageViewPage15.Text = "Suspended Group";
            // 
            // SplitContainer10
            // 
            SplitContainer10.Control_Name = "SplitContainer10";
            SplitContainer10.Dock = DockStyle.Fill;
            SplitContainer10.FixedPanel = FixedPanel.Panel2;
            SplitContainer10.IsSplitterFixed = true;
            SplitContainer10.Location = new Point(0, 0);
            SplitContainer10.Name = "SplitContainer10";
            SplitContainer10.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer10.Panel1
            // 
            SplitContainer10.Panel1.Controls.Add(gvSuspended);
            SplitContainer10.Panel2Collapsed = true;
            SplitContainer10.Size = new Size(1107, 316);
            SplitContainer10.SplitterDistance = 277;
            SplitContainer10.TabIndex = 9;
            SplitContainer10.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvSuspended
            // 
            gvSuspended.BackColor = SystemColors.ActiveCaption;
            gvSuspended.Calculation_Expression = null;
            gvSuspended.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvSuspended.Calculative = false;
            gvSuspended.Class_Name = null;
            gvSuspended.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvSuspended.Column_Name = null;
            gvSuspended.Control_Name = "gvSuspended";
            gvSuspended.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvSuspended.Custom_Data = false;
            gvSuspended.Custom_Default = false;
            gvSuspended.Display_Name = null;
            gvSuspended.Dock = DockStyle.Fill;
            gvSuspended.Field_Description = null;
            gvSuspended.Field_Name = null;
            gvSuspended.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvSuspended.Generated = false;
            gvSuspended.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvSuspended.Location = new Point(0, 0);
            // 
            // 
            // 
            gvSuspended.MasterTemplate.ShowHeaderCellButtons = true;
            gvSuspended.MasterTemplate.ViewDefinition = tableViewDefinition7;
            gvSuspended.MendatroryField = false;
            gvSuspended.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvSuspended.MultiSelection = false;
            gvSuspended.Name = "gvSuspended";
            gvSuspended.Padding = new Padding(0, 10, 0, 0);
            gvSuspended.ShowHeaderCellButtons = true;
            gvSuspended.Size = new Size(1107, 316);
            gvSuspended.TabIndex = 8;
            gvSuspended.Table_Name = null;
            gvSuspended.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvSuspended.XpertDisplayMember = null;
            gvSuspended.XpertValueMember = null;
            gvSuspended.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvSuspended.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvSuspended.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvSuspended.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // rdHeldup
            // 
            rdHeldup.Controls.Add(Panel25);
            rdHeldup.Controls.Add(Panel21);
            rdHeldup.Controls.Add(RadCollapsiblePanel7);
            rdHeldup.Location = new Point(4, 31);
            rdHeldup.Name = "rdHeldup";
            rdHeldup.Size = new Size(1107, 271);
            rdHeldup.Text = "Heldup Work";
            // 
            // Panel25
            // 
            Panel25.Control_Name = "Panel25";
            Panel25.Controls.Add(gvHeldUpWork);
            Panel25.Dock = DockStyle.Fill;
            Panel25.Location = new Point(0, 85);
            Panel25.Name = "Panel25";
            Panel25.Size = new Size(1107, 186);
            Panel25.TabIndex = 54;
            Panel25.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvHeldUpWork
            // 
            gvHeldUpWork.BackColor = Color.White;
            gvHeldUpWork.Calculation_Expression = null;
            gvHeldUpWork.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvHeldUpWork.Calculative = false;
            gvHeldUpWork.Class_Name = null;
            gvHeldUpWork.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvHeldUpWork.Column_Name = null;
            gvHeldUpWork.Control_Name = "gvHeldUpWork";
            gvHeldUpWork.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvHeldUpWork.Custom_Data = false;
            gvHeldUpWork.Custom_Default = false;
            gvHeldUpWork.Display_Name = null;
            gvHeldUpWork.Dock = DockStyle.Fill;
            gvHeldUpWork.Field_Description = null;
            gvHeldUpWork.Field_Name = null;
            gvHeldUpWork.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvHeldUpWork.Generated = false;
            gvHeldUpWork.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvHeldUpWork.Location = new Point(0, 0);
            // 
            // 
            // 
            gvHeldUpWork.MasterTemplate.ShowHeaderCellButtons = true;
            gvHeldUpWork.MasterTemplate.ViewDefinition = tableViewDefinition8;
            gvHeldUpWork.MendatroryField = false;
            gvHeldUpWork.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvHeldUpWork.MultiSelection = false;
            gvHeldUpWork.Name = "gvHeldUpWork";
            gvHeldUpWork.Padding = new Padding(0, 10, 0, 0);
            gvHeldUpWork.ShowHeaderCellButtons = true;
            gvHeldUpWork.Size = new Size(1107, 186);
            gvHeldUpWork.TabIndex = 52;
            gvHeldUpWork.Table_Name = null;
            gvHeldUpWork.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvHeldUpWork.XpertDisplayMember = null;
            gvHeldUpWork.XpertValueMember = null;
            gvHeldUpWork.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvHeldUpWork.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvHeldUpWork.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvHeldUpWork.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel21
            // 
            Panel21.BackColor = Color.Transparent;
            Panel21.BorderStyle = BorderStyle.Fixed3D;
            Panel21.Control_Name = "Panel21";
            Panel21.Controls.Add(MyLabel51);
            Panel21.Controls.Add(btnHeldupRefresh);
            Panel21.Dock = DockStyle.Top;
            Panel21.Location = new Point(0, 58);
            Panel21.Name = "Panel21";
            Panel21.Size = new Size(1107, 27);
            Panel21.TabIndex = 53;
            Panel21.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel51
            // 
            MyLabel51.AutoSize = false;
            MyLabel51.BorderVisible = true;
            MyLabel51.Calculation_Expression = null;
            MyLabel51.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel51.Calculative = false;
            MyLabel51.Column_Name = null;
            MyLabel51.Control_Name = "MyLabel51";
            MyLabel51.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel51.Cursor = Cursors.Hand;
            MyLabel51.Custom_Data = false;
            MyLabel51.Custom_Default = false;
            MyLabel51.Display_Name = null;
            MyLabel51.Field_Description = null;
            MyLabel51.Field_Name = null;
            MyLabel51.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel51.FieldName = null;
            MyLabel51.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel51.Generated = false;
            MyLabel51.Location = new Point(1, 3);
            MyLabel51.MendatroryField = false;
            MyLabel51.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel51.Name = "MyLabel51";
            MyLabel51.Size = new Size(40, 16);
            MyLabel51.SourceColumn = null;
            MyLabel51.TabIndex = 27;
            MyLabel51.Text = "List : 0";
            MyLabel51.XpertDisplayMember = null;
            MyLabel51.XpertValueMember = null;
            MyLabel51.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnHeldupRefresh
            // 
            btnHeldupRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHeldupRefresh.Location = new Point(1079, 1);
            btnHeldupRefresh.Margin = new Padding(4, 3, 4, 3);
            btnHeldupRefresh.MaximumSize = new Size(20, 20);
            btnHeldupRefresh.MinimumSize = new Size(20, 20);
            btnHeldupRefresh.Name = "btnHeldupRefresh";
            // 
            // 
            // 
            btnHeldupRefresh.RootElement.MaxSize = new Size(20, 20);
            btnHeldupRefresh.RootElement.MinSize = new Size(20, 20);
            btnHeldupRefresh.Size = new Size(20, 20);
            btnHeldupRefresh.TabIndex = 1;
            // 
            // RadCollapsiblePanel7
            // 
            RadCollapsiblePanel7.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            RadCollapsiblePanel7.BackColor = SystemColors.ControlLight;
            RadCollapsiblePanel7.BorderColor = Color.Black;
            RadCollapsiblePanel7.Control_Name = "RadCollapsiblePanel7";
            RadCollapsiblePanel7.Dock = DockStyle.Top;
            RadCollapsiblePanel7.HeaderText = "Filter";
            RadCollapsiblePanel7.Location = new Point(0, 0);
            RadCollapsiblePanel7.Name = "RadCollapsiblePanel7";
            RadCollapsiblePanel7.OwnerBoundsCache = new Rectangle(0, 0, 900, 75);
            // 
            // RadCollapsiblePanel7.PanelContainer
            // 
            RadCollapsiblePanel7.PanelContainer.Controls.Add(MyLabel45);
            RadCollapsiblePanel7.PanelContainer.Controls.Add(txtHedlupUsers);
            RadCollapsiblePanel7.PanelContainer.Controls.Add(MyLabel49);
            RadCollapsiblePanel7.PanelContainer.Controls.Add(dtHeldFrom);
            RadCollapsiblePanel7.PanelContainer.Controls.Add(MyLabel50);
            RadCollapsiblePanel7.PanelContainer.Controls.Add(dtHeldTo);
            RadCollapsiblePanel7.PanelContainer.Padding = new Padding(2);
            RadCollapsiblePanel7.PanelContainer.Size = new Size(888, 0);
            RadCollapsiblePanel7.ShowHeaderLine = false;
            RadCollapsiblePanel7.Size = new Size(1107, 58);
            RadCollapsiblePanel7.TabIndex = 52;
            RadCollapsiblePanel7.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).IsExpanded = true;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel7.GetChildAt(0)).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.CollapsiblePanelLayoutElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1)).ShowHeaderLine = false;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor2 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor3 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor4 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1).GetChildAt(0)).Image = (Image)resources.GetObject("resource.Image");
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel7.GetChildAt(0).GetChildAt(1).GetChildAt(0)).StretchHorizontally = false;
            // 
            // MyLabel45
            // 
            MyLabel45.AutoSize = false;
            MyLabel45.BorderVisible = true;
            MyLabel45.Calculation_Expression = null;
            MyLabel45.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel45.Calculative = false;
            MyLabel45.Column_Name = null;
            MyLabel45.Control_Name = "MyLabel45";
            MyLabel45.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel45.Cursor = Cursors.Hand;
            MyLabel45.Custom_Data = false;
            MyLabel45.Custom_Default = false;
            MyLabel45.Display_Name = null;
            MyLabel45.Field_Description = null;
            MyLabel45.Field_Name = null;
            MyLabel45.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel45.FieldName = null;
            MyLabel45.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel45.Generated = false;
            MyLabel45.Location = new Point(307, 4);
            MyLabel45.MendatroryField = false;
            MyLabel45.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel45.Name = "MyLabel45";
            MyLabel45.Size = new Size(30, 16);
            MyLabel45.SourceColumn = null;
            MyLabel45.TabIndex = 25;
            MyLabel45.Text = "User";
            MyLabel45.XpertDisplayMember = null;
            MyLabel45.XpertValueMember = null;
            MyLabel45.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtHedlupUsers
            // 
            txtHedlupUsers.arrDispalyMember = null;
            txtHedlupUsers.arrValueMember = null;
            txtHedlupUsers.Calculation_Expression = null;
            txtHedlupUsers.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtHedlupUsers.Calculative = false;
            txtHedlupUsers.Collection_Name = null;
            txtHedlupUsers.Column_Name = null;
            txtHedlupUsers.Control_Name = "XpertMultiSelctFinder";
            txtHedlupUsers.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtHedlupUsers.Cursor = Cursors.Hand;
            txtHedlupUsers.Custom_Data = false;
            txtHedlupUsers.Custom_Datasource_Logic = false;
            txtHedlupUsers.Custom_Default = false;
            txtHedlupUsers.DataSource = null;
            txtHedlupUsers.Datasource_Assembly = null;
            txtHedlupUsers.Datasource_Namespace = null;
            txtHedlupUsers.Datasource_Program = null;
            txtHedlupUsers.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            txtHedlupUsers.Display_Name = null;
            txtHedlupUsers.DisplayMember = null;
            txtHedlupUsers.Enum_Name = null;
            txtHedlupUsers.Field_Description = null;
            txtHedlupUsers.Field_Name = null;
            txtHedlupUsers.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtHedlupUsers.Generated = false;
            txtHedlupUsers.Key = false;
            txtHedlupUsers.Key_Column_Name = null;
            txtHedlupUsers.Key_Property = null;
            txtHedlupUsers.Key_Value = null;
            txtHedlupUsers.Location = new Point(353, 2);
            txtHedlupUsers.Margin = new Padding(4, 3, 4, 3);
            txtHedlupUsers.Max_Size = 0;
            txtHedlupUsers.MendatroryField = false;
            txtHedlupUsers.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtHedlupUsers.Min_Size = 0;
            txtHedlupUsers.MinimumSize = new Size(100, 20);
            txtHedlupUsers.Model_Name = null;
            txtHedlupUsers.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHedlupUsers.MyLinkLable1 = MyLabel45;
            txtHedlupUsers.MyLinkLable2 = null;
            txtHedlupUsers.MyNullText = "All";
            txtHedlupUsers.MyReadOnly = false;
            txtHedlupUsers.MyToolTipText = null;
            txtHedlupUsers.Name = "txtHedlupUsers";
            txtHedlupUsers.Name_Column_Name = null;
            txtHedlupUsers.Name_Property = null;
            txtHedlupUsers.Name_Value = null;
            txtHedlupUsers.Page_Key_Property = null;
            txtHedlupUsers.Page_Name_Property = null;
            txtHedlupUsers.Query_Class_Name = null;
            txtHedlupUsers.Required = false;
            txtHedlupUsers.ShowDataSource = false;
            txtHedlupUsers.Size = new Size(367, 20);
            txtHedlupUsers.SQLMethodName = null;
            txtHedlupUsers.TabIndex = 24;
            txtHedlupUsers.Table_Name = null;
            txtHedlupUsers.Tag_Column_Name = null;
            txtHedlupUsers.Tag_Property = null;
            txtHedlupUsers.ValueMember = null;
            txtHedlupUsers.Web_Page_Name = null;
            txtHedlupUsers.Web_Page_Url = null;
            txtHedlupUsers.XpertDisplayMember = null;
            txtHedlupUsers.XpertValueMember = null;
            txtHedlupUsers.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel49
            // 
            MyLabel49.AutoSize = false;
            MyLabel49.BorderVisible = true;
            MyLabel49.Calculation_Expression = null;
            MyLabel49.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel49.Calculative = false;
            MyLabel49.Column_Name = null;
            MyLabel49.Control_Name = "MyLabel49";
            MyLabel49.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel49.Cursor = Cursors.Hand;
            MyLabel49.Custom_Data = false;
            MyLabel49.Custom_Default = false;
            MyLabel49.Display_Name = null;
            MyLabel49.Field_Description = null;
            MyLabel49.Field_Name = null;
            MyLabel49.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel49.FieldName = null;
            MyLabel49.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel49.Generated = false;
            MyLabel49.Location = new Point(2, 4);
            MyLabel49.MendatroryField = false;
            MyLabel49.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel49.Name = "MyLabel49";
            MyLabel49.Size = new Size(60, 16);
            MyLabel49.SourceColumn = null;
            MyLabel49.TabIndex = 0;
            MyLabel49.Text = "From Date";
            MyLabel49.XpertDisplayMember = null;
            MyLabel49.XpertValueMember = null;
            MyLabel49.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // dtHeldFrom
            // 
            dtHeldFrom.Calculation_Expression = null;
            dtHeldFrom.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            dtHeldFrom.CalculationExpression = null;
            dtHeldFrom.Calculative = false;
            dtHeldFrom.Column_Name = null;
            dtHeldFrom.Control_Name = "dtHeldFrom";
            dtHeldFrom.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            dtHeldFrom.Custom_Data = false;
            dtHeldFrom.Custom_Default = false;
            dtHeldFrom.CustomFormat = "dd/MM/yyyy";
            dtHeldFrom.Display_Name = null;
            dtHeldFrom.Field_Description = null;
            dtHeldFrom.Field_Name = null;
            dtHeldFrom.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            dtHeldFrom.FieldCode = null;
            dtHeldFrom.FieldDesc = null;
            dtHeldFrom.FieldMaxLength = 0;
            dtHeldFrom.FieldName = null;
            dtHeldFrom.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtHeldFrom.Format = DateTimePickerFormat.Short;
            dtHeldFrom.Generated = false;
            dtHeldFrom.isCalculatedField = false;
            dtHeldFrom.IsSourceFromTable = false;
            dtHeldFrom.IsSourceFromValueList = false;
            dtHeldFrom.IsUnique = false;
            dtHeldFrom.Key = false;
            dtHeldFrom.Location = new Point(68, 3);
            dtHeldFrom.Max_Length = 0;
            dtHeldFrom.MendatroryField = false;
            dtHeldFrom.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            dtHeldFrom.Min_Length = 0;
            dtHeldFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtHeldFrom.MyLinkLable1 = MyLabel49;
            dtHeldFrom.MyLinkLable2 = null;
            dtHeldFrom.Name = "dtHeldFrom";
            dtHeldFrom.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtHeldFrom.ReferenceFieldDesc = null;
            dtHeldFrom.ReferenceFieldName = null;
            dtHeldFrom.ReferenceTableName = null;
            dtHeldFrom.Size = new Size(81, 18);
            dtHeldFrom.TabIndex = 1;
            dtHeldFrom.TabStop = false;
            dtHeldFrom.Text = "13-Jun-11";
            dtHeldFrom.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            dtHeldFrom.XpertDisplayMember = null;
            dtHeldFrom.XpertValueMember = null;
            dtHeldFrom.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel50
            // 
            MyLabel50.AutoSize = false;
            MyLabel50.BorderVisible = true;
            MyLabel50.Calculation_Expression = null;
            MyLabel50.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel50.Calculative = false;
            MyLabel50.Column_Name = null;
            MyLabel50.Control_Name = "MyLabel50";
            MyLabel50.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel50.Cursor = Cursors.Hand;
            MyLabel50.Custom_Data = false;
            MyLabel50.Custom_Default = false;
            MyLabel50.Display_Name = null;
            MyLabel50.Field_Description = null;
            MyLabel50.Field_Name = null;
            MyLabel50.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel50.FieldName = null;
            MyLabel50.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel50.Generated = false;
            MyLabel50.Location = new Point(153, 4);
            MyLabel50.MendatroryField = false;
            MyLabel50.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel50.Name = "MyLabel50";
            MyLabel50.Size = new Size(46, 16);
            MyLabel50.SourceColumn = null;
            MyLabel50.TabIndex = 2;
            MyLabel50.Text = "To Date";
            MyLabel50.XpertDisplayMember = null;
            MyLabel50.XpertValueMember = null;
            MyLabel50.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // dtHeldTo
            // 
            dtHeldTo.Calculation_Expression = null;
            dtHeldTo.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            dtHeldTo.CalculationExpression = null;
            dtHeldTo.Calculative = false;
            dtHeldTo.Column_Name = null;
            dtHeldTo.Control_Name = "dtHeldTo";
            dtHeldTo.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            dtHeldTo.Custom_Data = false;
            dtHeldTo.Custom_Default = false;
            dtHeldTo.CustomFormat = "dd/MM/yyyy";
            dtHeldTo.Display_Name = null;
            dtHeldTo.Field_Description = null;
            dtHeldTo.Field_Name = null;
            dtHeldTo.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            dtHeldTo.FieldCode = null;
            dtHeldTo.FieldDesc = null;
            dtHeldTo.FieldMaxLength = 0;
            dtHeldTo.FieldName = null;
            dtHeldTo.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtHeldTo.Format = DateTimePickerFormat.Short;
            dtHeldTo.Generated = false;
            dtHeldTo.isCalculatedField = false;
            dtHeldTo.IsSourceFromTable = false;
            dtHeldTo.IsSourceFromValueList = false;
            dtHeldTo.IsUnique = false;
            dtHeldTo.Key = false;
            dtHeldTo.Location = new Point(205, 3);
            dtHeldTo.Max_Length = 0;
            dtHeldTo.MendatroryField = false;
            dtHeldTo.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            dtHeldTo.Min_Length = 0;
            dtHeldTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtHeldTo.MyLinkLable1 = MyLabel50;
            dtHeldTo.MyLinkLable2 = null;
            dtHeldTo.Name = "dtHeldTo";
            dtHeldTo.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtHeldTo.ReferenceFieldDesc = null;
            dtHeldTo.ReferenceFieldName = null;
            dtHeldTo.ReferenceTableName = null;
            dtHeldTo.Size = new Size(81, 18);
            dtHeldTo.TabIndex = 3;
            dtHeldTo.TabStop = false;
            dtHeldTo.Text = "13-Jun-11";
            dtHeldTo.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            dtHeldTo.XpertDisplayMember = null;
            dtHeldTo.XpertValueMember = null;
            dtHeldTo.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // rdExpire
            // 
            rdExpire.Controls.Add(Panel24);
            rdExpire.Controls.Add(Panel20);
            rdExpire.Controls.Add(RadCollapsiblePanel6);
            rdExpire.Location = new Point(4, 31);
            rdExpire.Name = "rdExpire";
            rdExpire.Size = new Size(773, 271);
            rdExpire.Text = "Expired Work";
            // 
            // Panel24
            // 
            Panel24.Control_Name = "Panel24";
            Panel24.Controls.Add(gvExpired);
            Panel24.Dock = DockStyle.Fill;
            Panel24.Location = new Point(0, 85);
            Panel24.Name = "Panel24";
            Panel24.Size = new Size(773, 186);
            Panel24.TabIndex = 53;
            Panel24.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvExpired
            // 
            gvExpired.BackColor = Color.White;
            gvExpired.Calculation_Expression = null;
            gvExpired.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvExpired.Calculative = false;
            gvExpired.Class_Name = null;
            gvExpired.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvExpired.Column_Name = null;
            gvExpired.Control_Name = "gvExpired";
            gvExpired.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvExpired.Custom_Data = false;
            gvExpired.Custom_Default = false;
            gvExpired.Display_Name = null;
            gvExpired.Dock = DockStyle.Fill;
            gvExpired.Field_Description = null;
            gvExpired.Field_Name = null;
            gvExpired.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvExpired.Generated = false;
            gvExpired.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvExpired.Location = new Point(0, 0);
            // 
            // 
            // 
            gvExpired.MasterTemplate.ShowHeaderCellButtons = true;
            gvExpired.MasterTemplate.ViewDefinition = tableViewDefinition9;
            gvExpired.MendatroryField = false;
            gvExpired.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvExpired.MultiSelection = false;
            gvExpired.Name = "gvExpired";
            gvExpired.Padding = new Padding(0, 10, 0, 0);
            gvExpired.ShowHeaderCellButtons = true;
            gvExpired.Size = new Size(773, 186);
            gvExpired.TabIndex = 51;
            gvExpired.Table_Name = null;
            gvExpired.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvExpired.XpertDisplayMember = null;
            gvExpired.XpertValueMember = null;
            gvExpired.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvExpired.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvExpired.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvExpired.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel20
            // 
            Panel20.BackColor = Color.Transparent;
            Panel20.BorderStyle = BorderStyle.Fixed3D;
            Panel20.Control_Name = "Panel20";
            Panel20.Controls.Add(MyLabel44);
            Panel20.Controls.Add(btExpiryRefresh);
            Panel20.Dock = DockStyle.Top;
            Panel20.Location = new Point(0, 58);
            Panel20.Name = "Panel20";
            Panel20.Size = new Size(773, 27);
            Panel20.TabIndex = 52;
            Panel20.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel44
            // 
            MyLabel44.AutoSize = false;
            MyLabel44.BorderVisible = true;
            MyLabel44.Calculation_Expression = null;
            MyLabel44.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel44.Calculative = false;
            MyLabel44.Column_Name = null;
            MyLabel44.Control_Name = "MyLabel44";
            MyLabel44.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel44.Cursor = Cursors.Hand;
            MyLabel44.Custom_Data = false;
            MyLabel44.Custom_Default = false;
            MyLabel44.Display_Name = null;
            MyLabel44.Field_Description = null;
            MyLabel44.Field_Name = null;
            MyLabel44.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel44.FieldName = null;
            MyLabel44.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel44.Generated = false;
            MyLabel44.Location = new Point(1, 3);
            MyLabel44.MendatroryField = false;
            MyLabel44.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel44.Name = "MyLabel44";
            MyLabel44.Size = new Size(40, 16);
            MyLabel44.SourceColumn = null;
            MyLabel44.TabIndex = 27;
            MyLabel44.Text = "List : 0";
            MyLabel44.XpertDisplayMember = null;
            MyLabel44.XpertValueMember = null;
            MyLabel44.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btExpiryRefresh
            // 
            btExpiryRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btExpiryRefresh.Location = new Point(745, 1);
            btExpiryRefresh.Margin = new Padding(4, 3, 4, 3);
            btExpiryRefresh.MaximumSize = new Size(20, 20);
            btExpiryRefresh.MinimumSize = new Size(20, 20);
            btExpiryRefresh.Name = "btExpiryRefresh";
            // 
            // 
            // 
            btExpiryRefresh.RootElement.MaxSize = new Size(20, 20);
            btExpiryRefresh.RootElement.MinSize = new Size(20, 20);
            btExpiryRefresh.Size = new Size(20, 20);
            btExpiryRefresh.TabIndex = 1;
            // 
            // RadCollapsiblePanel6
            // 
            RadCollapsiblePanel6.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            RadCollapsiblePanel6.BackColor = SystemColors.ControlLight;
            RadCollapsiblePanel6.BorderColor = Color.Black;
            RadCollapsiblePanel6.Control_Name = "RadCollapsiblePanel6";
            RadCollapsiblePanel6.Dock = DockStyle.Top;
            RadCollapsiblePanel6.HeaderText = "Filter";
            RadCollapsiblePanel6.Location = new Point(0, 0);
            RadCollapsiblePanel6.Name = "RadCollapsiblePanel6";
            RadCollapsiblePanel6.OwnerBoundsCache = new Rectangle(0, 0, 900, 75);
            // 
            // RadCollapsiblePanel6.PanelContainer
            // 
            RadCollapsiblePanel6.PanelContainer.Controls.Add(MyLabel46);
            RadCollapsiblePanel6.PanelContainer.Controls.Add(txtExpiredUsers);
            RadCollapsiblePanel6.PanelContainer.Controls.Add(MyLabel47);
            RadCollapsiblePanel6.PanelContainer.Controls.Add(dtExpiredFrom);
            RadCollapsiblePanel6.PanelContainer.Controls.Add(MyLabel48);
            RadCollapsiblePanel6.PanelContainer.Controls.Add(dtExpiredTo);
            RadCollapsiblePanel6.PanelContainer.Padding = new Padding(2);
            RadCollapsiblePanel6.PanelContainer.Size = new Size(769, 33);
            RadCollapsiblePanel6.ShowHeaderLine = false;
            RadCollapsiblePanel6.Size = new Size(773, 58);
            RadCollapsiblePanel6.TabIndex = 51;
            RadCollapsiblePanel6.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).IsExpanded = true;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel6.GetChildAt(0)).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.CollapsiblePanelLayoutElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1)).ShowHeaderLine = false;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor2 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor3 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor4 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1).GetChildAt(0)).Image = (Image)resources.GetObject("resource.Image1");
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel6.GetChildAt(0).GetChildAt(1).GetChildAt(0)).StretchHorizontally = false;
            // 
            // MyLabel46
            // 
            MyLabel46.AutoSize = false;
            MyLabel46.BorderVisible = true;
            MyLabel46.Calculation_Expression = null;
            MyLabel46.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel46.Calculative = false;
            MyLabel46.Column_Name = null;
            MyLabel46.Control_Name = "MyLabel46";
            MyLabel46.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel46.Cursor = Cursors.Hand;
            MyLabel46.Custom_Data = false;
            MyLabel46.Custom_Default = false;
            MyLabel46.Display_Name = null;
            MyLabel46.Field_Description = null;
            MyLabel46.Field_Name = null;
            MyLabel46.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel46.FieldName = null;
            MyLabel46.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel46.Generated = false;
            MyLabel46.Location = new Point(307, 4);
            MyLabel46.MendatroryField = false;
            MyLabel46.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel46.Name = "MyLabel46";
            MyLabel46.Size = new Size(30, 16);
            MyLabel46.SourceColumn = null;
            MyLabel46.TabIndex = 25;
            MyLabel46.Text = "User";
            MyLabel46.XpertDisplayMember = null;
            MyLabel46.XpertValueMember = null;
            MyLabel46.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtExpiredUsers
            // 
            txtExpiredUsers.arrDispalyMember = null;
            txtExpiredUsers.arrValueMember = null;
            txtExpiredUsers.Calculation_Expression = null;
            txtExpiredUsers.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtExpiredUsers.Calculative = false;
            txtExpiredUsers.Collection_Name = null;
            txtExpiredUsers.Column_Name = null;
            txtExpiredUsers.Control_Name = "XpertMultiSelctFinder";
            txtExpiredUsers.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtExpiredUsers.Cursor = Cursors.Hand;
            txtExpiredUsers.Custom_Data = false;
            txtExpiredUsers.Custom_Datasource_Logic = false;
            txtExpiredUsers.Custom_Default = false;
            txtExpiredUsers.DataSource = null;
            txtExpiredUsers.Datasource_Assembly = null;
            txtExpiredUsers.Datasource_Namespace = null;
            txtExpiredUsers.Datasource_Program = null;
            txtExpiredUsers.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            txtExpiredUsers.Display_Name = null;
            txtExpiredUsers.DisplayMember = null;
            txtExpiredUsers.Enum_Name = null;
            txtExpiredUsers.Field_Description = null;
            txtExpiredUsers.Field_Name = null;
            txtExpiredUsers.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtExpiredUsers.Generated = false;
            txtExpiredUsers.Key = false;
            txtExpiredUsers.Key_Column_Name = null;
            txtExpiredUsers.Key_Property = null;
            txtExpiredUsers.Key_Value = null;
            txtExpiredUsers.Location = new Point(353, 2);
            txtExpiredUsers.Margin = new Padding(4, 3, 4, 3);
            txtExpiredUsers.Max_Size = 0;
            txtExpiredUsers.MendatroryField = false;
            txtExpiredUsers.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            txtExpiredUsers.Min_Size = 0;
            txtExpiredUsers.MinimumSize = new Size(100, 20);
            txtExpiredUsers.Model_Name = null;
            txtExpiredUsers.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpiredUsers.MyLinkLable1 = MyLabel46;
            txtExpiredUsers.MyLinkLable2 = null;
            txtExpiredUsers.MyNullText = "All";
            txtExpiredUsers.MyReadOnly = false;
            txtExpiredUsers.MyToolTipText = null;
            txtExpiredUsers.Name = "txtExpiredUsers";
            txtExpiredUsers.Name_Column_Name = null;
            txtExpiredUsers.Name_Property = null;
            txtExpiredUsers.Name_Value = null;
            txtExpiredUsers.Page_Key_Property = null;
            txtExpiredUsers.Page_Name_Property = null;
            txtExpiredUsers.Query_Class_Name = null;
            txtExpiredUsers.Required = false;
            txtExpiredUsers.ShowDataSource = false;
            txtExpiredUsers.Size = new Size(367, 20);
            txtExpiredUsers.SQLMethodName = null;
            txtExpiredUsers.TabIndex = 24;
            txtExpiredUsers.Table_Name = null;
            txtExpiredUsers.Tag_Column_Name = null;
            txtExpiredUsers.Tag_Property = null;
            txtExpiredUsers.ValueMember = null;
            txtExpiredUsers.Web_Page_Name = null;
            txtExpiredUsers.Web_Page_Url = null;
            txtExpiredUsers.XpertDisplayMember = null;
            txtExpiredUsers.XpertValueMember = null;
            txtExpiredUsers.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel47
            // 
            MyLabel47.AutoSize = false;
            MyLabel47.BorderVisible = true;
            MyLabel47.Calculation_Expression = null;
            MyLabel47.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel47.Calculative = false;
            MyLabel47.Column_Name = null;
            MyLabel47.Control_Name = "MyLabel47";
            MyLabel47.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel47.Cursor = Cursors.Hand;
            MyLabel47.Custom_Data = false;
            MyLabel47.Custom_Default = false;
            MyLabel47.Display_Name = null;
            MyLabel47.Field_Description = null;
            MyLabel47.Field_Name = null;
            MyLabel47.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel47.FieldName = null;
            MyLabel47.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel47.Generated = false;
            MyLabel47.Location = new Point(2, 4);
            MyLabel47.MendatroryField = false;
            MyLabel47.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel47.Name = "MyLabel47";
            MyLabel47.Size = new Size(60, 16);
            MyLabel47.SourceColumn = null;
            MyLabel47.TabIndex = 0;
            MyLabel47.Text = "From Date";
            MyLabel47.XpertDisplayMember = null;
            MyLabel47.XpertValueMember = null;
            MyLabel47.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // dtExpiredFrom
            // 
            dtExpiredFrom.Calculation_Expression = null;
            dtExpiredFrom.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            dtExpiredFrom.CalculationExpression = null;
            dtExpiredFrom.Calculative = false;
            dtExpiredFrom.Column_Name = null;
            dtExpiredFrom.Control_Name = "dtExpiredFrom";
            dtExpiredFrom.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            dtExpiredFrom.Custom_Data = false;
            dtExpiredFrom.Custom_Default = false;
            dtExpiredFrom.CustomFormat = "dd/MM/yyyy";
            dtExpiredFrom.Display_Name = null;
            dtExpiredFrom.Field_Description = null;
            dtExpiredFrom.Field_Name = null;
            dtExpiredFrom.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            dtExpiredFrom.FieldCode = null;
            dtExpiredFrom.FieldDesc = null;
            dtExpiredFrom.FieldMaxLength = 0;
            dtExpiredFrom.FieldName = null;
            dtExpiredFrom.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtExpiredFrom.Format = DateTimePickerFormat.Short;
            dtExpiredFrom.Generated = false;
            dtExpiredFrom.isCalculatedField = false;
            dtExpiredFrom.IsSourceFromTable = false;
            dtExpiredFrom.IsSourceFromValueList = false;
            dtExpiredFrom.IsUnique = false;
            dtExpiredFrom.Key = false;
            dtExpiredFrom.Location = new Point(68, 3);
            dtExpiredFrom.Max_Length = 0;
            dtExpiredFrom.MendatroryField = false;
            dtExpiredFrom.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            dtExpiredFrom.Min_Length = 0;
            dtExpiredFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtExpiredFrom.MyLinkLable1 = MyLabel47;
            dtExpiredFrom.MyLinkLable2 = null;
            dtExpiredFrom.Name = "dtExpiredFrom";
            dtExpiredFrom.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtExpiredFrom.ReferenceFieldDesc = null;
            dtExpiredFrom.ReferenceFieldName = null;
            dtExpiredFrom.ReferenceTableName = null;
            dtExpiredFrom.Size = new Size(81, 18);
            dtExpiredFrom.TabIndex = 1;
            dtExpiredFrom.TabStop = false;
            dtExpiredFrom.Text = "13-Jun-11";
            dtExpiredFrom.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            dtExpiredFrom.XpertDisplayMember = null;
            dtExpiredFrom.XpertValueMember = null;
            dtExpiredFrom.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel48
            // 
            MyLabel48.AutoSize = false;
            MyLabel48.BorderVisible = true;
            MyLabel48.Calculation_Expression = null;
            MyLabel48.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel48.Calculative = false;
            MyLabel48.Column_Name = null;
            MyLabel48.Control_Name = "MyLabel48";
            MyLabel48.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel48.Cursor = Cursors.Hand;
            MyLabel48.Custom_Data = false;
            MyLabel48.Custom_Default = false;
            MyLabel48.Display_Name = null;
            MyLabel48.Field_Description = null;
            MyLabel48.Field_Name = null;
            MyLabel48.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel48.FieldName = null;
            MyLabel48.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel48.Generated = false;
            MyLabel48.Location = new Point(153, 4);
            MyLabel48.MendatroryField = false;
            MyLabel48.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel48.Name = "MyLabel48";
            MyLabel48.Size = new Size(46, 16);
            MyLabel48.SourceColumn = null;
            MyLabel48.TabIndex = 2;
            MyLabel48.Text = "To Date";
            MyLabel48.XpertDisplayMember = null;
            MyLabel48.XpertValueMember = null;
            MyLabel48.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // dtExpiredTo
            // 
            dtExpiredTo.Calculation_Expression = null;
            dtExpiredTo.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            dtExpiredTo.CalculationExpression = null;
            dtExpiredTo.Calculative = false;
            dtExpiredTo.Column_Name = null;
            dtExpiredTo.Control_Name = "dtExpiredTo";
            dtExpiredTo.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            dtExpiredTo.Custom_Data = false;
            dtExpiredTo.Custom_Default = false;
            dtExpiredTo.CustomFormat = "dd/MM/yyyy";
            dtExpiredTo.Display_Name = null;
            dtExpiredTo.Field_Description = null;
            dtExpiredTo.Field_Name = null;
            dtExpiredTo.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            dtExpiredTo.FieldCode = null;
            dtExpiredTo.FieldDesc = null;
            dtExpiredTo.FieldMaxLength = 0;
            dtExpiredTo.FieldName = null;
            dtExpiredTo.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtExpiredTo.Format = DateTimePickerFormat.Short;
            dtExpiredTo.Generated = false;
            dtExpiredTo.isCalculatedField = false;
            dtExpiredTo.IsSourceFromTable = false;
            dtExpiredTo.IsSourceFromValueList = false;
            dtExpiredTo.IsUnique = false;
            dtExpiredTo.Key = false;
            dtExpiredTo.Location = new Point(205, 3);
            dtExpiredTo.Max_Length = 0;
            dtExpiredTo.MendatroryField = false;
            dtExpiredTo.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            dtExpiredTo.Min_Length = 0;
            dtExpiredTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtExpiredTo.MyLinkLable1 = MyLabel48;
            dtExpiredTo.MyLinkLable2 = null;
            dtExpiredTo.Name = "dtExpiredTo";
            dtExpiredTo.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtExpiredTo.ReferenceFieldDesc = null;
            dtExpiredTo.ReferenceFieldName = null;
            dtExpiredTo.ReferenceTableName = null;
            dtExpiredTo.Size = new Size(81, 18);
            dtExpiredTo.TabIndex = 3;
            dtExpiredTo.TabStop = false;
            dtExpiredTo.Text = "13-Jun-11";
            dtExpiredTo.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            dtExpiredTo.XpertDisplayMember = null;
            dtExpiredTo.XpertValueMember = null;
            dtExpiredTo.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // rdAwaitedWork
            // 
            rdAwaitedWork.Controls.Add(gvAwaited);
            rdAwaitedWork.Controls.Add(Panel4);
            rdAwaitedWork.Controls.Add(RadCollapsiblePanel2);
            rdAwaitedWork.ItemSize = new SizeF(57F, 28F);
            rdAwaitedWork.Location = new Point(4, 31);
            rdAwaitedWork.Name = "rdAwaitedWork";
            rdAwaitedWork.Size = new Size(1115, 351);
            rdAwaitedWork.Text = "Awaited";
            // 
            // gvAwaited
            // 
            gvAwaited.BackColor = Color.White;
            gvAwaited.Calculation_Expression = null;
            gvAwaited.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvAwaited.Calculative = false;
            gvAwaited.Class_Name = null;
            gvAwaited.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvAwaited.Column_Name = null;
            gvAwaited.Control_Name = "gvAwaited";
            gvAwaited.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvAwaited.Custom_Data = false;
            gvAwaited.Custom_Default = false;
            gvAwaited.Display_Name = null;
            gvAwaited.Dock = DockStyle.Fill;
            gvAwaited.Field_Description = null;
            gvAwaited.Field_Name = null;
            gvAwaited.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvAwaited.Generated = false;
            gvAwaited.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvAwaited.Location = new Point(0, 85);
            // 
            // 
            // 
            gvAwaited.MasterTemplate.ShowHeaderCellButtons = true;
            gvAwaited.MasterTemplate.ViewDefinition = tableViewDefinition10;
            gvAwaited.MendatroryField = false;
            gvAwaited.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvAwaited.MultiSelection = false;
            gvAwaited.Name = "gvAwaited";
            gvAwaited.Padding = new Padding(0, 10, 0, 0);
            gvAwaited.ShowHeaderCellButtons = true;
            gvAwaited.Size = new Size(1115, 266);
            gvAwaited.TabIndex = 53;
            gvAwaited.Table_Name = null;
            gvAwaited.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvAwaited.XpertDisplayMember = null;
            gvAwaited.XpertValueMember = null;
            gvAwaited.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvAwaited.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvAwaited.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvAwaited.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.Transparent;
            Panel4.BorderStyle = BorderStyle.Fixed3D;
            Panel4.Control_Name = "Panel4";
            Panel4.Controls.Add(MyLabel5);
            Panel4.Controls.Add(btnAwited);
            Panel4.Dock = DockStyle.Top;
            Panel4.Location = new Point(0, 58);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(1115, 27);
            Panel4.TabIndex = 52;
            Panel4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel5
            // 
            MyLabel5.AutoSize = false;
            MyLabel5.BorderVisible = true;
            MyLabel5.Calculation_Expression = null;
            MyLabel5.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel5.Calculative = false;
            MyLabel5.Column_Name = null;
            MyLabel5.Control_Name = "MyLabel5";
            MyLabel5.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel5.Cursor = Cursors.Hand;
            MyLabel5.Custom_Data = false;
            MyLabel5.Custom_Default = false;
            MyLabel5.Display_Name = null;
            MyLabel5.Field_Description = null;
            MyLabel5.Field_Name = null;
            MyLabel5.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel5.FieldName = null;
            MyLabel5.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel5.Generated = false;
            MyLabel5.Location = new Point(1, 3);
            MyLabel5.MendatroryField = false;
            MyLabel5.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel5.Name = "MyLabel5";
            MyLabel5.Size = new Size(40, 16);
            MyLabel5.SourceColumn = null;
            MyLabel5.TabIndex = 27;
            MyLabel5.Text = "List : 0";
            MyLabel5.XpertDisplayMember = null;
            MyLabel5.XpertValueMember = null;
            MyLabel5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnAwited
            // 
            btnAwited.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAwited.Location = new Point(1087, 1);
            btnAwited.Margin = new Padding(4, 3, 4, 3);
            btnAwited.MaximumSize = new Size(20, 20);
            btnAwited.MinimumSize = new Size(20, 20);
            btnAwited.Name = "btnAwited";
            // 
            // 
            // 
            btnAwited.RootElement.MaxSize = new Size(20, 20);
            btnAwited.RootElement.MinSize = new Size(20, 20);
            btnAwited.Size = new Size(20, 20);
            btnAwited.TabIndex = 1;
            // 
            // RadCollapsiblePanel2
            // 
            RadCollapsiblePanel2.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            RadCollapsiblePanel2.BackColor = SystemColors.ControlLight;
            RadCollapsiblePanel2.BorderColor = Color.Black;
            RadCollapsiblePanel2.Control_Name = "RadCollapsiblePanel2";
            RadCollapsiblePanel2.Dock = DockStyle.Top;
            RadCollapsiblePanel2.HeaderText = "Filter";
            RadCollapsiblePanel2.Location = new Point(0, 0);
            RadCollapsiblePanel2.Name = "RadCollapsiblePanel2";
            RadCollapsiblePanel2.OwnerBoundsCache = new Rectangle(0, 0, 900, 75);
            // 
            // RadCollapsiblePanel2.PanelContainer
            // 
            RadCollapsiblePanel2.PanelContainer.Controls.Add(MyLabel7);
            RadCollapsiblePanel2.PanelContainer.Controls.Add(AwaitedUsers);
            RadCollapsiblePanel2.PanelContainer.Controls.Add(MyLabel10);
            RadCollapsiblePanel2.PanelContainer.Controls.Add(AwaitedFromDate);
            RadCollapsiblePanel2.PanelContainer.Controls.Add(MyLabel11);
            RadCollapsiblePanel2.PanelContainer.Controls.Add(AwaitedToDate);
            RadCollapsiblePanel2.PanelContainer.Padding = new Padding(2);
            RadCollapsiblePanel2.PanelContainer.Size = new Size(611, 0);
            RadCollapsiblePanel2.ShowHeaderLine = false;
            RadCollapsiblePanel2.Size = new Size(1115, 58);
            RadCollapsiblePanel2.TabIndex = 51;
            RadCollapsiblePanel2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).IsExpanded = true;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel2.GetChildAt(0)).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.CollapsiblePanelLayoutElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1)).ShowHeaderLine = false;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor2 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor3 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor4 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1).GetChildAt(0)).Image = (Image)resources.GetObject("resource.Image2");
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel2.GetChildAt(0).GetChildAt(1).GetChildAt(0)).StretchHorizontally = false;
            // 
            // MyLabel7
            // 
            MyLabel7.AutoSize = false;
            MyLabel7.BorderVisible = true;
            MyLabel7.Calculation_Expression = null;
            MyLabel7.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel7.Calculative = false;
            MyLabel7.Column_Name = null;
            MyLabel7.Control_Name = "MyLabel7";
            MyLabel7.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel7.Cursor = Cursors.Hand;
            MyLabel7.Custom_Data = false;
            MyLabel7.Custom_Default = false;
            MyLabel7.Display_Name = null;
            MyLabel7.Field_Description = null;
            MyLabel7.Field_Name = null;
            MyLabel7.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel7.FieldName = null;
            MyLabel7.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel7.Generated = false;
            MyLabel7.Location = new Point(307, 4);
            MyLabel7.MendatroryField = false;
            MyLabel7.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel7.Name = "MyLabel7";
            MyLabel7.Size = new Size(30, 16);
            MyLabel7.SourceColumn = null;
            MyLabel7.TabIndex = 25;
            MyLabel7.Text = "User";
            MyLabel7.XpertDisplayMember = null;
            MyLabel7.XpertValueMember = null;
            MyLabel7.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // AwaitedUsers
            // 
            AwaitedUsers.arrDispalyMember = null;
            AwaitedUsers.arrValueMember = null;
            AwaitedUsers.Calculation_Expression = null;
            AwaitedUsers.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            AwaitedUsers.Calculative = false;
            AwaitedUsers.Collection_Name = null;
            AwaitedUsers.Column_Name = null;
            AwaitedUsers.Control_Name = "XpertMultiSelctFinder";
            AwaitedUsers.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            AwaitedUsers.Cursor = Cursors.Hand;
            AwaitedUsers.Custom_Data = false;
            AwaitedUsers.Custom_Datasource_Logic = false;
            AwaitedUsers.Custom_Default = false;
            AwaitedUsers.DataSource = null;
            AwaitedUsers.Datasource_Assembly = null;
            AwaitedUsers.Datasource_Namespace = null;
            AwaitedUsers.Datasource_Program = null;
            AwaitedUsers.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            AwaitedUsers.Display_Name = null;
            AwaitedUsers.DisplayMember = null;
            AwaitedUsers.Enum_Name = null;
            AwaitedUsers.Field_Description = null;
            AwaitedUsers.Field_Name = null;
            AwaitedUsers.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            AwaitedUsers.Generated = false;
            AwaitedUsers.Key = false;
            AwaitedUsers.Key_Column_Name = null;
            AwaitedUsers.Key_Property = null;
            AwaitedUsers.Key_Value = null;
            AwaitedUsers.Location = new Point(353, 2);
            AwaitedUsers.Margin = new Padding(4, 3, 4, 3);
            AwaitedUsers.Max_Size = 0;
            AwaitedUsers.MendatroryField = false;
            AwaitedUsers.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            AwaitedUsers.Min_Size = 0;
            AwaitedUsers.MinimumSize = new Size(100, 20);
            AwaitedUsers.Model_Name = null;
            AwaitedUsers.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AwaitedUsers.MyLinkLable1 = MyLabel7;
            AwaitedUsers.MyLinkLable2 = null;
            AwaitedUsers.MyNullText = "All";
            AwaitedUsers.MyReadOnly = false;
            AwaitedUsers.MyToolTipText = null;
            AwaitedUsers.Name = "AwaitedUsers";
            AwaitedUsers.Name_Column_Name = null;
            AwaitedUsers.Name_Property = null;
            AwaitedUsers.Name_Value = null;
            AwaitedUsers.Page_Key_Property = null;
            AwaitedUsers.Page_Name_Property = null;
            AwaitedUsers.Query_Class_Name = null;
            AwaitedUsers.Required = false;
            AwaitedUsers.ShowDataSource = false;
            AwaitedUsers.Size = new Size(367, 20);
            AwaitedUsers.SQLMethodName = null;
            AwaitedUsers.TabIndex = 24;
            AwaitedUsers.Table_Name = null;
            AwaitedUsers.Tag_Column_Name = null;
            AwaitedUsers.Tag_Property = null;
            AwaitedUsers.ValueMember = null;
            AwaitedUsers.Web_Page_Name = null;
            AwaitedUsers.Web_Page_Url = null;
            AwaitedUsers.XpertDisplayMember = null;
            AwaitedUsers.XpertValueMember = null;
            AwaitedUsers.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel10
            // 
            MyLabel10.AutoSize = false;
            MyLabel10.BorderVisible = true;
            MyLabel10.Calculation_Expression = null;
            MyLabel10.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel10.Calculative = false;
            MyLabel10.Column_Name = null;
            MyLabel10.Control_Name = "MyLabel10";
            MyLabel10.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel10.Cursor = Cursors.Hand;
            MyLabel10.Custom_Data = false;
            MyLabel10.Custom_Default = false;
            MyLabel10.Display_Name = null;
            MyLabel10.Field_Description = null;
            MyLabel10.Field_Name = null;
            MyLabel10.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel10.FieldName = null;
            MyLabel10.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel10.Generated = false;
            MyLabel10.Location = new Point(2, 4);
            MyLabel10.MendatroryField = false;
            MyLabel10.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel10.Name = "MyLabel10";
            MyLabel10.Size = new Size(60, 16);
            MyLabel10.SourceColumn = null;
            MyLabel10.TabIndex = 0;
            MyLabel10.Text = "From Date";
            MyLabel10.XpertDisplayMember = null;
            MyLabel10.XpertValueMember = null;
            MyLabel10.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // AwaitedFromDate
            // 
            AwaitedFromDate.Calculation_Expression = null;
            AwaitedFromDate.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            AwaitedFromDate.CalculationExpression = null;
            AwaitedFromDate.Calculative = false;
            AwaitedFromDate.Column_Name = null;
            AwaitedFromDate.Control_Name = "AwaitedFromDate";
            AwaitedFromDate.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            AwaitedFromDate.Custom_Data = false;
            AwaitedFromDate.Custom_Default = false;
            AwaitedFromDate.CustomFormat = "dd/MM/yyyy";
            AwaitedFromDate.Display_Name = null;
            AwaitedFromDate.Field_Description = null;
            AwaitedFromDate.Field_Name = null;
            AwaitedFromDate.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            AwaitedFromDate.FieldCode = null;
            AwaitedFromDate.FieldDesc = null;
            AwaitedFromDate.FieldMaxLength = 0;
            AwaitedFromDate.FieldName = null;
            AwaitedFromDate.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AwaitedFromDate.Format = DateTimePickerFormat.Short;
            AwaitedFromDate.Generated = false;
            AwaitedFromDate.isCalculatedField = false;
            AwaitedFromDate.IsSourceFromTable = false;
            AwaitedFromDate.IsSourceFromValueList = false;
            AwaitedFromDate.IsUnique = false;
            AwaitedFromDate.Key = false;
            AwaitedFromDate.Location = new Point(68, 3);
            AwaitedFromDate.Max_Length = 0;
            AwaitedFromDate.MendatroryField = false;
            AwaitedFromDate.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            AwaitedFromDate.Min_Length = 0;
            AwaitedFromDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            AwaitedFromDate.MyLinkLable1 = MyLabel10;
            AwaitedFromDate.MyLinkLable2 = null;
            AwaitedFromDate.Name = "AwaitedFromDate";
            AwaitedFromDate.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            AwaitedFromDate.ReferenceFieldDesc = null;
            AwaitedFromDate.ReferenceFieldName = null;
            AwaitedFromDate.ReferenceTableName = null;
            AwaitedFromDate.Size = new Size(81, 18);
            AwaitedFromDate.TabIndex = 1;
            AwaitedFromDate.TabStop = false;
            AwaitedFromDate.Text = "13-Jun-11";
            AwaitedFromDate.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            AwaitedFromDate.XpertDisplayMember = null;
            AwaitedFromDate.XpertValueMember = null;
            AwaitedFromDate.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel11
            // 
            MyLabel11.AutoSize = false;
            MyLabel11.BorderVisible = true;
            MyLabel11.Calculation_Expression = null;
            MyLabel11.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel11.Calculative = false;
            MyLabel11.Column_Name = null;
            MyLabel11.Control_Name = "MyLabel11";
            MyLabel11.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel11.Cursor = Cursors.Hand;
            MyLabel11.Custom_Data = false;
            MyLabel11.Custom_Default = false;
            MyLabel11.Display_Name = null;
            MyLabel11.Field_Description = null;
            MyLabel11.Field_Name = null;
            MyLabel11.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel11.FieldName = null;
            MyLabel11.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel11.Generated = false;
            MyLabel11.Location = new Point(153, 4);
            MyLabel11.MendatroryField = false;
            MyLabel11.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel11.Name = "MyLabel11";
            MyLabel11.Size = new Size(46, 16);
            MyLabel11.SourceColumn = null;
            MyLabel11.TabIndex = 2;
            MyLabel11.Text = "To Date";
            MyLabel11.XpertDisplayMember = null;
            MyLabel11.XpertValueMember = null;
            MyLabel11.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // AwaitedToDate
            // 
            AwaitedToDate.Calculation_Expression = null;
            AwaitedToDate.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            AwaitedToDate.CalculationExpression = null;
            AwaitedToDate.Calculative = false;
            AwaitedToDate.Column_Name = null;
            AwaitedToDate.Control_Name = "AwaitedToDate";
            AwaitedToDate.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            AwaitedToDate.Custom_Data = false;
            AwaitedToDate.Custom_Default = false;
            AwaitedToDate.CustomFormat = "dd/MM/yyyy";
            AwaitedToDate.Display_Name = null;
            AwaitedToDate.Field_Description = null;
            AwaitedToDate.Field_Name = null;
            AwaitedToDate.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            AwaitedToDate.FieldCode = null;
            AwaitedToDate.FieldDesc = null;
            AwaitedToDate.FieldMaxLength = 0;
            AwaitedToDate.FieldName = null;
            AwaitedToDate.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AwaitedToDate.Format = DateTimePickerFormat.Short;
            AwaitedToDate.Generated = false;
            AwaitedToDate.isCalculatedField = false;
            AwaitedToDate.IsSourceFromTable = false;
            AwaitedToDate.IsSourceFromValueList = false;
            AwaitedToDate.IsUnique = false;
            AwaitedToDate.Key = false;
            AwaitedToDate.Location = new Point(205, 3);
            AwaitedToDate.Max_Length = 0;
            AwaitedToDate.MendatroryField = false;
            AwaitedToDate.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            AwaitedToDate.Min_Length = 0;
            AwaitedToDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            AwaitedToDate.MyLinkLable1 = MyLabel11;
            AwaitedToDate.MyLinkLable2 = null;
            AwaitedToDate.Name = "AwaitedToDate";
            AwaitedToDate.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            AwaitedToDate.ReferenceFieldDesc = null;
            AwaitedToDate.ReferenceFieldName = null;
            AwaitedToDate.ReferenceTableName = null;
            AwaitedToDate.Size = new Size(81, 18);
            AwaitedToDate.TabIndex = 3;
            AwaitedToDate.TabStop = false;
            AwaitedToDate.Text = "13-Jun-11";
            AwaitedToDate.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            AwaitedToDate.XpertDisplayMember = null;
            AwaitedToDate.XpertValueMember = null;
            AwaitedToDate.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // rdDayToDay
            // 
            rdDayToDay.Controls.Add(SplitContainer8);
            rdDayToDay.ItemSize = new SizeF(121F, 28F);
            rdDayToDay.Location = new Point(4, 31);
            rdDayToDay.Name = "rdDayToDay";
            rdDayToDay.Size = new Size(781, 306);
            rdDayToDay.Text = "Day To Day Activities";
            // 
            // SplitContainer8
            // 
            SplitContainer8.Control_Name = "SplitContainer8";
            SplitContainer8.Dock = DockStyle.Fill;
            SplitContainer8.FixedPanel = FixedPanel.Panel1;
            SplitContainer8.Location = new Point(0, 0);
            SplitContainer8.Name = "SplitContainer8";
            SplitContainer8.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer8.Panel1
            // 
            SplitContainer8.Panel1.Controls.Add(Panel7);
            // 
            // SplitContainer8.Panel2
            // 
            SplitContainer8.Panel2.Controls.Add(gvDayToDay);
            SplitContainer8.Size = new Size(781, 306);
            SplitContainer8.SplitterDistance = 29;
            SplitContainer8.TabIndex = 53;
            SplitContainer8.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Panel7
            // 
            Panel7.BackColor = Color.Transparent;
            Panel7.BorderStyle = BorderStyle.Fixed3D;
            Panel7.Control_Name = "Panel7";
            Panel7.Controls.Add(btnAddNew);
            Panel7.Controls.Add(MyLabel12);
            Panel7.Controls.Add(btnDayRefresh);
            Panel7.Dock = DockStyle.Top;
            Panel7.Location = new Point(0, 0);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(781, 27);
            Panel7.TabIndex = 52;
            Panel7.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(727, 1);
            btnAddNew.Margin = new Padding(4, 3, 4, 3);
            btnAddNew.MaximumSize = new Size(20, 20);
            btnAddNew.MinimumSize = new Size(20, 20);
            btnAddNew.Name = "btnAddNew";
            // 
            // 
            // 
            btnAddNew.RootElement.MaxSize = new Size(20, 20);
            btnAddNew.RootElement.MinSize = new Size(20, 20);
            btnAddNew.Size = new Size(20, 20);
            btnAddNew.TabIndex = 29;
            // 
            // MyLabel12
            // 
            MyLabel12.AutoSize = false;
            MyLabel12.BorderVisible = true;
            MyLabel12.Calculation_Expression = null;
            MyLabel12.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel12.Calculative = false;
            MyLabel12.Column_Name = null;
            MyLabel12.Control_Name = "MyLabel12";
            MyLabel12.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel12.Cursor = Cursors.Hand;
            MyLabel12.Custom_Data = false;
            MyLabel12.Custom_Default = false;
            MyLabel12.Display_Name = null;
            MyLabel12.Field_Description = null;
            MyLabel12.Field_Name = null;
            MyLabel12.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel12.FieldName = null;
            MyLabel12.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel12.Generated = false;
            MyLabel12.Location = new Point(1, 3);
            MyLabel12.MendatroryField = false;
            MyLabel12.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel12.Name = "MyLabel12";
            MyLabel12.Size = new Size(40, 16);
            MyLabel12.SourceColumn = null;
            MyLabel12.TabIndex = 27;
            MyLabel12.Text = "List : 0";
            MyLabel12.XpertDisplayMember = null;
            MyLabel12.XpertValueMember = null;
            MyLabel12.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnDayRefresh
            // 
            btnDayRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDayRefresh.Location = new Point(753, 1);
            btnDayRefresh.Margin = new Padding(4, 3, 4, 3);
            btnDayRefresh.MaximumSize = new Size(20, 20);
            btnDayRefresh.MinimumSize = new Size(20, 20);
            btnDayRefresh.Name = "btnDayRefresh";
            // 
            // 
            // 
            btnDayRefresh.RootElement.MaxSize = new Size(20, 20);
            btnDayRefresh.RootElement.MinSize = new Size(20, 20);
            btnDayRefresh.Size = new Size(20, 20);
            btnDayRefresh.TabIndex = 1;
            // 
            // gvDayToDay
            // 
            gvDayToDay.BackColor = SystemColors.ActiveCaption;
            gvDayToDay.Calculation_Expression = null;
            gvDayToDay.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvDayToDay.Calculative = false;
            gvDayToDay.Class_Name = null;
            gvDayToDay.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvDayToDay.Column_Name = null;
            gvDayToDay.Control_Name = "gvDayToDay";
            gvDayToDay.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvDayToDay.Custom_Data = false;
            gvDayToDay.Custom_Default = false;
            gvDayToDay.Display_Name = null;
            gvDayToDay.Dock = DockStyle.Fill;
            gvDayToDay.Field_Description = null;
            gvDayToDay.Field_Name = null;
            gvDayToDay.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvDayToDay.Generated = false;
            gvDayToDay.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvDayToDay.Location = new Point(0, 0);
            // 
            // 
            // 
            gvDayToDay.MasterTemplate.ShowHeaderCellButtons = true;
            gvDayToDay.MasterTemplate.ViewDefinition = tableViewDefinition11;
            gvDayToDay.MendatroryField = false;
            gvDayToDay.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvDayToDay.MultiSelection = false;
            gvDayToDay.Name = "gvDayToDay";
            gvDayToDay.Padding = new Padding(0, 10, 0, 0);
            gvDayToDay.ShowHeaderCellButtons = true;
            gvDayToDay.Size = new Size(781, 273);
            gvDayToDay.TabIndex = 51;
            gvDayToDay.Table_Name = null;
            gvDayToDay.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvDayToDay.XpertDisplayMember = null;
            gvDayToDay.XpertValueMember = null;
            gvDayToDay.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvDayToDay.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvDayToDay.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvDayToDay.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // rdDone
            // 
            rdDone.Controls.Add(SplitContainer13);
            rdDone.ItemSize = new SizeF(43F, 28F);
            rdDone.Location = new Point(4, 31);
            rdDone.Name = "rdDone";
            rdDone.Size = new Size(1115, 306);
            rdDone.Text = "Done";
            // 
            // SplitContainer13
            // 
            SplitContainer13.Control_Name = "SplitContainer13";
            SplitContainer13.Dock = DockStyle.Fill;
            SplitContainer13.FixedPanel = FixedPanel.Panel2;
            SplitContainer13.Location = new Point(0, 0);
            SplitContainer13.Name = "SplitContainer13";
            SplitContainer13.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer13.Panel1
            // 
            SplitContainer13.Panel1.Controls.Add(gvDone);
            // 
            // SplitContainer13.Panel2
            // 
            SplitContainer13.Panel2.Controls.Add(btnDone);
            SplitContainer13.Size = new Size(1115, 306);
            SplitContainer13.SplitterDistance = 275;
            SplitContainer13.TabIndex = 52;
            SplitContainer13.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvDone
            // 
            gvDone.BackColor = SystemColors.ActiveCaption;
            gvDone.Calculation_Expression = null;
            gvDone.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvDone.Calculative = false;
            gvDone.Class_Name = null;
            gvDone.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvDone.Column_Name = null;
            gvDone.Control_Name = "gvDone";
            gvDone.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvDone.Custom_Data = false;
            gvDone.Custom_Default = false;
            gvDone.Display_Name = null;
            gvDone.Dock = DockStyle.Fill;
            gvDone.Field_Description = null;
            gvDone.Field_Name = null;
            gvDone.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvDone.Generated = false;
            gvDone.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvDone.Location = new Point(0, 0);
            // 
            // 
            // 
            gvDone.MasterTemplate.ShowHeaderCellButtons = true;
            gvDone.MasterTemplate.ViewDefinition = tableViewDefinition12;
            gvDone.MendatroryField = false;
            gvDone.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvDone.MultiSelection = false;
            gvDone.Name = "gvDone";
            gvDone.Padding = new Padding(0, 10, 0, 0);
            gvDone.ShowHeaderCellButtons = true;
            gvDone.Size = new Size(1115, 275);
            gvDone.TabIndex = 51;
            gvDone.Table_Name = null;
            gvDone.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvDone.XpertDisplayMember = null;
            gvDone.XpertValueMember = null;
            gvDone.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvDone.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvDone.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvDone.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // btnDone
            // 
            btnDone.Location = new Point(9, 4);
            btnDone.Margin = new Padding(4, 3, 4, 3);
            btnDone.MaximumSize = new Size(72, 21);
            btnDone.MinimumSize = new Size(72, 21);
            btnDone.Name = "btnDone";
            // 
            // 
            // 
            btnDone.RootElement.MaxSize = new Size(72, 21);
            btnDone.RootElement.MinSize = new Size(72, 21);
            btnDone.Size = new Size(72, 21);
            btnDone.TabIndex = 45;
            // 
            // rdNotDone
            // 
            rdNotDone.Controls.Add(SplitContainer12);
            rdNotDone.ItemSize = new SizeF(65F, 28F);
            rdNotDone.Location = new Point(4, 31);
            rdNotDone.Name = "rdNotDone";
            rdNotDone.Size = new Size(1115, 306);
            rdNotDone.Text = "Not Done";
            // 
            // SplitContainer12
            // 
            SplitContainer12.Control_Name = "SplitContainer12";
            SplitContainer12.Dock = DockStyle.Fill;
            SplitContainer12.FixedPanel = FixedPanel.Panel2;
            SplitContainer12.Location = new Point(0, 0);
            SplitContainer12.Name = "SplitContainer12";
            SplitContainer12.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer12.Panel1
            // 
            SplitContainer12.Panel1.Controls.Add(gvNotDone);
            // 
            // SplitContainer12.Panel2
            // 
            SplitContainer12.Panel2.Controls.Add(btnNotDone);
            SplitContainer12.Size = new Size(1115, 306);
            SplitContainer12.SplitterDistance = 274;
            SplitContainer12.TabIndex = 52;
            SplitContainer12.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvNotDone
            // 
            gvNotDone.BackColor = SystemColors.ActiveCaption;
            gvNotDone.Calculation_Expression = null;
            gvNotDone.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvNotDone.Calculative = false;
            gvNotDone.Class_Name = null;
            gvNotDone.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvNotDone.Column_Name = null;
            gvNotDone.Control_Name = "gvNotDone";
            gvNotDone.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvNotDone.Custom_Data = false;
            gvNotDone.Custom_Default = false;
            gvNotDone.Display_Name = null;
            gvNotDone.Dock = DockStyle.Fill;
            gvNotDone.Field_Description = null;
            gvNotDone.Field_Name = null;
            gvNotDone.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvNotDone.Generated = false;
            gvNotDone.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvNotDone.Location = new Point(0, 0);
            // 
            // 
            // 
            gvNotDone.MasterTemplate.ShowHeaderCellButtons = true;
            gvNotDone.MasterTemplate.ViewDefinition = tableViewDefinition13;
            gvNotDone.MendatroryField = false;
            gvNotDone.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvNotDone.MultiSelection = false;
            gvNotDone.Name = "gvNotDone";
            gvNotDone.Padding = new Padding(0, 10, 0, 0);
            gvNotDone.ShowHeaderCellButtons = true;
            gvNotDone.Size = new Size(1115, 274);
            gvNotDone.TabIndex = 51;
            gvNotDone.Table_Name = null;
            gvNotDone.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvNotDone.XpertDisplayMember = null;
            gvNotDone.XpertValueMember = null;
            gvNotDone.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvNotDone.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvNotDone.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvNotDone.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // btnNotDone
            // 
            btnNotDone.Location = new Point(8, 3);
            btnNotDone.Margin = new Padding(4, 3, 4, 3);
            btnNotDone.MaximumSize = new Size(72, 21);
            btnNotDone.MinimumSize = new Size(72, 21);
            btnNotDone.Name = "btnNotDone";
            // 
            // 
            // 
            btnNotDone.RootElement.MaxSize = new Size(72, 21);
            btnNotDone.RootElement.MinSize = new Size(72, 21);
            btnNotDone.Size = new Size(72, 21);
            btnNotDone.TabIndex = 45;
            // 
            // RadPageViewPage6
            // 
            RadPageViewPage6.Controls.Add(SplitContainer7);
            RadPageViewPage6.ItemSize = new SizeF(85F, 28F);
            RadPageViewPage6.Location = new Point(1, 28);
            RadPageViewPage6.Name = "RadPageViewPage6";
            RadPageViewPage6.Size = new Size(789, 341);
            RadPageViewPage6.Text = "Responsibility";
            // 
            // SplitContainer7
            // 
            SplitContainer7.Control_Name = "SplitContainer7";
            SplitContainer7.Dock = DockStyle.Fill;
            SplitContainer7.FixedPanel = FixedPanel.Panel2;
            SplitContainer7.IsSplitterFixed = true;
            SplitContainer7.Location = new Point(0, 0);
            SplitContainer7.Name = "SplitContainer7";
            SplitContainer7.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer7.Panel1
            // 
            SplitContainer7.Panel1.Controls.Add(SplitContainer11);
            // 
            // SplitContainer7.Panel2
            // 
            SplitContainer7.Panel2.Controls.Add(btnReset);
            SplitContainer7.Panel2.Controls.Add(btnSave);
            SplitContainer7.Panel2Collapsed = true;
            SplitContainer7.Size = new Size(789, 341);
            SplitContainer7.SplitterDistance = 316;
            SplitContainer7.TabIndex = 51;
            SplitContainer7.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // SplitContainer11
            // 
            SplitContainer11.Control_Name = "SplitContainer11";
            SplitContainer11.Dock = DockStyle.Fill;
            SplitContainer11.Location = new Point(0, 0);
            SplitContainer11.Name = "SplitContainer11";
            SplitContainer11.Orientation = Orientation.Horizontal;
            // 
            // SplitContainer11.Panel1
            // 
            SplitContainer11.Panel1.Controls.Add(gvResponsibility);
            // 
            // SplitContainer11.Panel2
            // 
            SplitContainer11.Panel2.Controls.Add(btnResponsibiltySave);
            SplitContainer11.Size = new Size(789, 341);
            SplitContainer11.SplitterDistance = 312;
            SplitContainer11.TabIndex = 51;
            SplitContainer11.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvResponsibility
            // 
            gvResponsibility.BackColor = SystemColors.ActiveCaption;
            gvResponsibility.Calculation_Expression = null;
            gvResponsibility.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            gvResponsibility.Calculative = false;
            gvResponsibility.Class_Name = null;
            gvResponsibility.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            gvResponsibility.Column_Name = null;
            gvResponsibility.Control_Name = "gvResponsibility";
            gvResponsibility.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            gvResponsibility.Custom_Data = false;
            gvResponsibility.Custom_Default = false;
            gvResponsibility.Display_Name = null;
            gvResponsibility.Dock = DockStyle.Fill;
            gvResponsibility.Field_Description = null;
            gvResponsibility.Field_Name = null;
            gvResponsibility.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            gvResponsibility.Generated = false;
            gvResponsibility.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            gvResponsibility.Location = new Point(0, 0);
            // 
            // 
            // 
            gvResponsibility.MasterTemplate.ShowHeaderCellButtons = true;
            gvResponsibility.MasterTemplate.ViewDefinition = tableViewDefinition14;
            gvResponsibility.MendatroryField = false;
            gvResponsibility.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            gvResponsibility.MultiSelection = false;
            gvResponsibility.Name = "gvResponsibility";
            gvResponsibility.Padding = new Padding(0, 10, 0, 0);
            gvResponsibility.ShowHeaderCellButtons = true;
            gvResponsibility.Size = new Size(789, 312);
            gvResponsibility.TabIndex = 50;
            gvResponsibility.Table_Name = null;
            gvResponsibility.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            gvResponsibility.XpertDisplayMember = null;
            gvResponsibility.XpertValueMember = null;
            gvResponsibility.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)gvResponsibility.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvResponsibility.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvResponsibility.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // btnResponsibiltySave
            // 
            btnResponsibiltySave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResponsibiltySave.Location = new Point(8, 0);
            btnResponsibiltySave.Margin = new Padding(4, 3, 4, 3);
            btnResponsibiltySave.MaximumSize = new Size(72, 21);
            btnResponsibiltySave.MinimumSize = new Size(72, 21);
            btnResponsibiltySave.Name = "btnResponsibiltySave";
            // 
            // 
            // 
            btnResponsibiltySave.RootElement.MaxSize = new Size(72, 21);
            btnResponsibiltySave.RootElement.MinSize = new Size(72, 21);
            btnResponsibiltySave.Size = new Size(72, 21);
            btnResponsibiltySave.TabIndex = 281;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.BackColor = SystemColors.ActiveCaption;
            btnReset.Command_Type = XpertStudio.Common.Enums.XpertCommandTypes.None;
            btnReset.Control_Name = "btnReset";
            btnReset.CustomAction = false;
            btnReset.Display_Name = "Reset";
            btnReset.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Generated = false;
            btnReset.Location = new Point(87, 5);
            btnReset.MyPerformClick = false;
            btnReset.MyText = "Button1";
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(69, 22);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.Url = null;
            btnReset.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Command_Type = XpertStudio.Common.Enums.XpertCommandTypes.None;
            btnSave.Control_Name = "btnSave";
            btnSave.CustomAction = false;
            btnSave.Display_Name = "Save";
            btnSave.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Generated = false;
            btnSave.Location = new Point(12, 5);
            btnSave.MyPerformClick = false;
            btnSave.MyText = "Button1";
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(69, 22);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.Url = null;
            btnSave.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageView5
            // 
            RadPageView5.BorderColor = Color.Black;
            RadPageView5.Control_Name = "RadPageView5";
            RadPageView5.Controls.Add(RadPageViewPage7);
            RadPageView5.Controls.Add(RadPageViewPage8);
            RadPageView5.Controls.Add(RadPageViewPage11);
            RadPageView5.Location = new Point(0, 0);
            RadPageView5.Name = "RadPageView5";
            RadPageView5.SelectedPage = RadPageViewPage7;
            RadPageView5.Size = new Size(400, 300);
            RadPageView5.TabIndex = 0;
            RadPageView5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView5.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView5.GetChildAt(0)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView5.GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView5.GetChildAt(0)).Padding = new Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)RadPageView5.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.StripViewItemLayout)RadPageView5.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).BorderTopWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).BorderRightWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView5.GetChildAt(0).GetChildAt(1)).Padding = new Padding(3);
            // 
            // RadPageViewPage7
            // 
            RadPageViewPage7.Controls.Add(MyRadGridView1);
            RadPageViewPage7.Controls.Add(Panel12);
            RadPageViewPage7.Controls.Add(RadCollapsiblePanel4);
            RadPageViewPage7.Description = "KRA(Work) List";
            RadPageViewPage7.Location = new Point(4, 32);
            RadPageViewPage7.Name = "RadPageViewPage7";
            RadPageViewPage7.Size = new Size(392, 264);
            RadPageViewPage7.Text = "KRA(Work) List";
            RadPageViewPage7.Title = "KRA(Work) List";
            // 
            // MyRadGridView1
            // 
            MyRadGridView1.BackColor = SystemColors.ActiveCaption;
            MyRadGridView1.Calculation_Expression = null;
            MyRadGridView1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyRadGridView1.Calculative = false;
            MyRadGridView1.Class_Name = null;
            MyRadGridView1.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            MyRadGridView1.Column_Name = null;
            MyRadGridView1.Control_Name = "MyRadGridView1";
            MyRadGridView1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyRadGridView1.Custom_Data = false;
            MyRadGridView1.Custom_Default = false;
            MyRadGridView1.Display_Name = null;
            MyRadGridView1.Dock = DockStyle.Fill;
            MyRadGridView1.Field_Description = null;
            MyRadGridView1.Field_Name = null;
            MyRadGridView1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyRadGridView1.Generated = false;
            MyRadGridView1.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            MyRadGridView1.Location = new Point(0, 130);
            // 
            // 
            // 
            MyRadGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            MyRadGridView1.MasterTemplate.ViewDefinition = tableViewDefinition15;
            MyRadGridView1.MendatroryField = false;
            MyRadGridView1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyRadGridView1.MultiSelection = false;
            MyRadGridView1.Name = "MyRadGridView1";
            MyRadGridView1.Padding = new Padding(0, 10, 0, 0);
            MyRadGridView1.ShowHeaderCellButtons = true;
            MyRadGridView1.Size = new Size(392, 134);
            MyRadGridView1.TabIndex = 49;
            MyRadGridView1.Table_Name = null;
            MyRadGridView1.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            MyRadGridView1.XpertDisplayMember = null;
            MyRadGridView1.XpertValueMember = null;
            MyRadGridView1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView1.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView1.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView1.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel12
            // 
            Panel12.BackColor = Color.Transparent;
            Panel12.BorderStyle = BorderStyle.Fixed3D;
            Panel12.Control_Name = "Panel12";
            Panel12.Controls.Add(UcRefreshIconButton2);
            Panel12.Dock = DockStyle.Top;
            Panel12.Location = new Point(0, 103);
            Panel12.Name = "Panel12";
            Panel12.Size = new Size(392, 27);
            Panel12.TabIndex = 47;
            Panel12.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcRefreshIconButton2
            // 
            UcRefreshIconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UcRefreshIconButton2.Location = new Point(864, 1);
            UcRefreshIconButton2.Margin = new Padding(4, 3, 4, 3);
            UcRefreshIconButton2.MaximumSize = new Size(20, 20);
            UcRefreshIconButton2.MinimumSize = new Size(20, 20);
            UcRefreshIconButton2.Name = "UcRefreshIconButton2";
            // 
            // 
            // 
            UcRefreshIconButton2.RootElement.MaxSize = new Size(20, 20);
            UcRefreshIconButton2.RootElement.MinSize = new Size(20, 20);
            UcRefreshIconButton2.Size = new Size(20, 20);
            UcRefreshIconButton2.TabIndex = 1;
            // 
            // RadCollapsiblePanel4
            // 
            RadCollapsiblePanel4.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            RadCollapsiblePanel4.BackColor = SystemColors.ControlLight;
            RadCollapsiblePanel4.BorderColor = Color.Black;
            RadCollapsiblePanel4.Control_Name = "RadCollapsiblePanel4";
            RadCollapsiblePanel4.Dock = DockStyle.Top;
            RadCollapsiblePanel4.HeaderText = "Filter";
            RadCollapsiblePanel4.Location = new Point(0, 0);
            RadCollapsiblePanel4.Name = "RadCollapsiblePanel4";
            RadCollapsiblePanel4.OwnerBoundsCache = new Rectangle(0, 0, 900, 75);
            // 
            // RadCollapsiblePanel4.PanelContainer
            // 
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyLabel24);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyComboBox1);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyLabel25);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(TxtMultiSelectFinder1);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyLabel27);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(TxtMultiSelectFinder2);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyLabel28);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(TxtMultiSelectFinder3);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyLabel29);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyDateTimePicker1);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyLabel30);
            RadCollapsiblePanel4.PanelContainer.Controls.Add(MyDateTimePicker2);
            RadCollapsiblePanel4.PanelContainer.Location = new Point(0, 0);
            RadCollapsiblePanel4.PanelContainer.Padding = new Padding(2);
            RadCollapsiblePanel4.PanelContainer.Size = new Size(305, -39);
            RadCollapsiblePanel4.ShowHeaderLine = false;
            RadCollapsiblePanel4.Size = new Size(392, 103);
            RadCollapsiblePanel4.TabIndex = 48;
            RadCollapsiblePanel4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).IsExpanded = true;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel4.GetChildAt(0)).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.CollapsiblePanelLayoutElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1)).ShowHeaderLine = false;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor2 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor3 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor4 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1).GetChildAt(0)).Image = (Image)resources.GetObject("resource.Image3");
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel4.GetChildAt(0).GetChildAt(1).GetChildAt(0)).StretchHorizontally = false;
            // 
            // MyLabel24
            // 
            MyLabel24.AutoSize = false;
            MyLabel24.BorderVisible = true;
            MyLabel24.Calculation_Expression = null;
            MyLabel24.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel24.Calculative = false;
            MyLabel24.Column_Name = null;
            MyLabel24.Control_Name = "MyLabel24";
            MyLabel24.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel24.Cursor = Cursors.Hand;
            MyLabel24.Custom_Data = false;
            MyLabel24.Custom_Default = false;
            MyLabel24.Display_Name = null;
            MyLabel24.Field_Description = null;
            MyLabel24.Field_Name = null;
            MyLabel24.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel24.FieldName = null;
            MyLabel24.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel24.Generated = false;
            MyLabel24.Location = new Point(620, 3);
            MyLabel24.MendatroryField = false;
            MyLabel24.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel24.Name = "MyLabel24";
            MyLabel24.Size = new Size(87, 16);
            MyLabel24.SourceColumn = null;
            MyLabel24.TabIndex = 31;
            MyLabel24.Text = "Timesheet Type";
            MyLabel24.XpertDisplayMember = null;
            MyLabel24.XpertValueMember = null;
            MyLabel24.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyComboBox1
            // 
            MyComboBox1.AutoCompleteDisplayMember = null;
            MyComboBox1.AutoCompleteValueMember = null;
            MyComboBox1.Calculation_Expression = null;
            MyComboBox1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyComboBox1.CalculationExpression = null;
            MyComboBox1.Calculative = false;
            MyComboBox1.Collection_Name = null;
            MyComboBox1.Column_Name = null;
            MyComboBox1.Control_Name = "MyComboBox1";
            MyComboBox1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyComboBox1.Custom_Data = false;
            MyComboBox1.Custom_Datasource_Logic = false;
            MyComboBox1.Custom_Default = false;
            MyComboBox1.Datasource_Assembly = null;
            MyComboBox1.Datasource_Namespace = null;
            MyComboBox1.Datasource_Program = null;
            MyComboBox1.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            MyComboBox1.Display_Name = null;
            MyComboBox1.DropDownAnimationEnabled = true;
            MyComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            MyComboBox1.Enum_Name = null;
            MyComboBox1.Field_Description = null;
            MyComboBox1.Field_Name = null;
            MyComboBox1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyComboBox1.FieldCode = null;
            MyComboBox1.FieldDesc = null;
            MyComboBox1.FieldMaxLength = 0;
            MyComboBox1.FieldName = null;
            MyComboBox1.Generated = false;
            MyComboBox1.isCalculatedField = false;
            MyComboBox1.IsSourceFromTable = false;
            MyComboBox1.IsSourceFromValueList = false;
            MyComboBox1.IsUnique = false;
            MyComboBox1.Key = false;
            MyComboBox1.Key_Column_Name = null;
            MyComboBox1.Key_Property = null;
            MyComboBox1.Key_Value = null;
            MyComboBox1.Location = new Point(714, 1);
            MyComboBox1.Max_Length = 0;
            MyComboBox1.MendatroryField = false;
            MyComboBox1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyComboBox1.Min_Length = 0;
            MyComboBox1.Model_Name = null;
            MyComboBox1.MyLinkLable1 = MyLabel24;
            MyComboBox1.MyLinkLable2 = null;
            MyComboBox1.Name = "MyComboBox1";
            MyComboBox1.Name_Column_Name = null;
            MyComboBox1.Name_Property = null;
            MyComboBox1.Name_Value = null;
            MyComboBox1.Page_Key_Property = null;
            MyComboBox1.Page_Name_Property = null;
            MyComboBox1.Query_Class_Name = null;
            MyComboBox1.ReferenceFieldDesc = null;
            MyComboBox1.ReferenceFieldName = null;
            MyComboBox1.ReferenceTableName = null;
            MyComboBox1.Size = new Size(145, 20);
            MyComboBox1.SQLMethodName = null;
            MyComboBox1.TabIndex = 30;
            MyComboBox1.Table_Name = null;
            MyComboBox1.Tag_Column_Name = null;
            MyComboBox1.Tag_Property = null;
            MyComboBox1.Web_Page_Name = null;
            MyComboBox1.Web_Page_Url = null;
            MyComboBox1.XpertDisplayMember = null;
            MyComboBox1.XpertValueMember = null;
            MyComboBox1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel25
            // 
            MyLabel25.AutoSize = false;
            MyLabel25.BorderVisible = true;
            MyLabel25.Calculation_Expression = null;
            MyLabel25.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel25.Calculative = false;
            MyLabel25.Column_Name = null;
            MyLabel25.Control_Name = "MyLabel25";
            MyLabel25.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel25.Cursor = Cursors.Hand;
            MyLabel25.Custom_Data = false;
            MyLabel25.Custom_Default = false;
            MyLabel25.Display_Name = null;
            MyLabel25.Field_Description = null;
            MyLabel25.Field_Name = null;
            MyLabel25.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel25.FieldName = null;
            MyLabel25.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel25.Generated = false;
            MyLabel25.Location = new Point(303, 26);
            MyLabel25.MendatroryField = false;
            MyLabel25.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel25.Name = "MyLabel25";
            MyLabel25.Size = new Size(41, 16);
            MyLabel25.SourceColumn = null;
            MyLabel25.TabIndex = 29;
            MyLabel25.Text = "Project";
            MyLabel25.XpertDisplayMember = null;
            MyLabel25.XpertValueMember = null;
            MyLabel25.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TxtMultiSelectFinder1
            // 
            TxtMultiSelectFinder1.arrDispalyMember = null;
            TxtMultiSelectFinder1.arrValueMember = null;
            TxtMultiSelectFinder1.Calculation_Expression = null;
            TxtMultiSelectFinder1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            TxtMultiSelectFinder1.Calculative = false;
            TxtMultiSelectFinder1.Collection_Name = null;
            TxtMultiSelectFinder1.Column_Name = null;
            TxtMultiSelectFinder1.Control_Name = "XpertMultiSelctFinder";
            TxtMultiSelectFinder1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            TxtMultiSelectFinder1.Cursor = Cursors.Hand;
            TxtMultiSelectFinder1.Custom_Data = false;
            TxtMultiSelectFinder1.Custom_Datasource_Logic = false;
            TxtMultiSelectFinder1.Custom_Default = false;
            TxtMultiSelectFinder1.DataSource = null;
            TxtMultiSelectFinder1.Datasource_Assembly = null;
            TxtMultiSelectFinder1.Datasource_Namespace = null;
            TxtMultiSelectFinder1.Datasource_Program = null;
            TxtMultiSelectFinder1.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            TxtMultiSelectFinder1.Display_Name = null;
            TxtMultiSelectFinder1.DisplayMember = null;
            TxtMultiSelectFinder1.Enum_Name = null;
            TxtMultiSelectFinder1.Field_Description = null;
            TxtMultiSelectFinder1.Field_Name = null;
            TxtMultiSelectFinder1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            TxtMultiSelectFinder1.Generated = false;
            TxtMultiSelectFinder1.Key = false;
            TxtMultiSelectFinder1.Key_Column_Name = null;
            TxtMultiSelectFinder1.Key_Property = null;
            TxtMultiSelectFinder1.Key_Value = null;
            TxtMultiSelectFinder1.Location = new Point(353, 24);
            TxtMultiSelectFinder1.Margin = new Padding(4, 3, 4, 3);
            TxtMultiSelectFinder1.Max_Size = 0;
            TxtMultiSelectFinder1.MendatroryField = false;
            TxtMultiSelectFinder1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            TxtMultiSelectFinder1.Min_Size = 0;
            TxtMultiSelectFinder1.MinimumSize = new Size(100, 20);
            TxtMultiSelectFinder1.Model_Name = null;
            TxtMultiSelectFinder1.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMultiSelectFinder1.MyLinkLable1 = MyLabel25;
            TxtMultiSelectFinder1.MyLinkLable2 = null;
            TxtMultiSelectFinder1.MyNullText = "All";
            TxtMultiSelectFinder1.MyReadOnly = false;
            TxtMultiSelectFinder1.MyToolTipText = null;
            TxtMultiSelectFinder1.Name = "TxtMultiSelectFinder1";
            TxtMultiSelectFinder1.Name_Column_Name = null;
            TxtMultiSelectFinder1.Name_Property = null;
            TxtMultiSelectFinder1.Name_Value = null;
            TxtMultiSelectFinder1.Page_Key_Property = null;
            TxtMultiSelectFinder1.Page_Name_Property = null;
            TxtMultiSelectFinder1.Query_Class_Name = null;
            TxtMultiSelectFinder1.Required = false;
            TxtMultiSelectFinder1.ShowDataSource = false;
            TxtMultiSelectFinder1.Size = new Size(262, 20);
            TxtMultiSelectFinder1.SQLMethodName = null;
            TxtMultiSelectFinder1.TabIndex = 28;
            TxtMultiSelectFinder1.Table_Name = null;
            TxtMultiSelectFinder1.Tag_Column_Name = null;
            TxtMultiSelectFinder1.Tag_Property = null;
            TxtMultiSelectFinder1.ValueMember = null;
            TxtMultiSelectFinder1.Web_Page_Name = null;
            TxtMultiSelectFinder1.Web_Page_Url = null;
            TxtMultiSelectFinder1.XpertDisplayMember = null;
            TxtMultiSelectFinder1.XpertValueMember = null;
            TxtMultiSelectFinder1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel27
            // 
            MyLabel27.AutoSize = false;
            MyLabel27.BorderVisible = true;
            MyLabel27.Calculation_Expression = null;
            MyLabel27.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel27.Calculative = false;
            MyLabel27.Column_Name = null;
            MyLabel27.Control_Name = "MyLabel27";
            MyLabel27.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel27.Cursor = Cursors.Hand;
            MyLabel27.Custom_Data = false;
            MyLabel27.Custom_Default = false;
            MyLabel27.Display_Name = null;
            MyLabel27.Field_Description = null;
            MyLabel27.Field_Name = null;
            MyLabel27.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel27.FieldName = null;
            MyLabel27.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel27.Generated = false;
            MyLabel27.Location = new Point(2, 26);
            MyLabel27.MendatroryField = false;
            MyLabel27.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel27.Name = "MyLabel27";
            MyLabel27.Size = new Size(35, 16);
            MyLabel27.SourceColumn = null;
            MyLabel27.TabIndex = 27;
            MyLabel27.Text = "Client";
            MyLabel27.XpertDisplayMember = null;
            MyLabel27.XpertValueMember = null;
            MyLabel27.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TxtMultiSelectFinder2
            // 
            TxtMultiSelectFinder2.arrDispalyMember = null;
            TxtMultiSelectFinder2.arrValueMember = null;
            TxtMultiSelectFinder2.Calculation_Expression = null;
            TxtMultiSelectFinder2.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            TxtMultiSelectFinder2.Calculative = false;
            TxtMultiSelectFinder2.Collection_Name = null;
            TxtMultiSelectFinder2.Column_Name = null;
            TxtMultiSelectFinder2.Control_Name = "XpertMultiSelctFinder";
            TxtMultiSelectFinder2.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            TxtMultiSelectFinder2.Cursor = Cursors.Hand;
            TxtMultiSelectFinder2.Custom_Data = false;
            TxtMultiSelectFinder2.Custom_Datasource_Logic = false;
            TxtMultiSelectFinder2.Custom_Default = false;
            TxtMultiSelectFinder2.DataSource = null;
            TxtMultiSelectFinder2.Datasource_Assembly = null;
            TxtMultiSelectFinder2.Datasource_Namespace = null;
            TxtMultiSelectFinder2.Datasource_Program = null;
            TxtMultiSelectFinder2.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            TxtMultiSelectFinder2.Display_Name = null;
            TxtMultiSelectFinder2.DisplayMember = null;
            TxtMultiSelectFinder2.Enum_Name = null;
            TxtMultiSelectFinder2.Field_Description = null;
            TxtMultiSelectFinder2.Field_Name = null;
            TxtMultiSelectFinder2.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            TxtMultiSelectFinder2.Generated = false;
            TxtMultiSelectFinder2.Key = false;
            TxtMultiSelectFinder2.Key_Column_Name = null;
            TxtMultiSelectFinder2.Key_Property = null;
            TxtMultiSelectFinder2.Key_Value = null;
            TxtMultiSelectFinder2.Location = new Point(68, 24);
            TxtMultiSelectFinder2.Margin = new Padding(4, 3, 4, 3);
            TxtMultiSelectFinder2.Max_Size = 0;
            TxtMultiSelectFinder2.MendatroryField = false;
            TxtMultiSelectFinder2.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            TxtMultiSelectFinder2.Min_Size = 0;
            TxtMultiSelectFinder2.MinimumSize = new Size(100, 20);
            TxtMultiSelectFinder2.Model_Name = null;
            TxtMultiSelectFinder2.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMultiSelectFinder2.MyLinkLable1 = MyLabel27;
            TxtMultiSelectFinder2.MyLinkLable2 = null;
            TxtMultiSelectFinder2.MyNullText = "All";
            TxtMultiSelectFinder2.MyReadOnly = false;
            TxtMultiSelectFinder2.MyToolTipText = null;
            TxtMultiSelectFinder2.Name = "TxtMultiSelectFinder2";
            TxtMultiSelectFinder2.Name_Column_Name = null;
            TxtMultiSelectFinder2.Name_Property = null;
            TxtMultiSelectFinder2.Name_Value = null;
            TxtMultiSelectFinder2.Page_Key_Property = null;
            TxtMultiSelectFinder2.Page_Name_Property = null;
            TxtMultiSelectFinder2.Query_Class_Name = null;
            TxtMultiSelectFinder2.Required = false;
            TxtMultiSelectFinder2.ShowDataSource = false;
            TxtMultiSelectFinder2.Size = new Size(218, 20);
            TxtMultiSelectFinder2.SQLMethodName = null;
            TxtMultiSelectFinder2.TabIndex = 26;
            TxtMultiSelectFinder2.Table_Name = null;
            TxtMultiSelectFinder2.Tag_Column_Name = null;
            TxtMultiSelectFinder2.Tag_Property = null;
            TxtMultiSelectFinder2.ValueMember = null;
            TxtMultiSelectFinder2.Web_Page_Name = null;
            TxtMultiSelectFinder2.Web_Page_Url = null;
            TxtMultiSelectFinder2.XpertDisplayMember = null;
            TxtMultiSelectFinder2.XpertValueMember = null;
            TxtMultiSelectFinder2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel28
            // 
            MyLabel28.AutoSize = false;
            MyLabel28.BorderVisible = true;
            MyLabel28.Calculation_Expression = null;
            MyLabel28.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel28.Calculative = false;
            MyLabel28.Column_Name = null;
            MyLabel28.Control_Name = "MyLabel28";
            MyLabel28.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel28.Cursor = Cursors.Hand;
            MyLabel28.Custom_Data = false;
            MyLabel28.Custom_Default = false;
            MyLabel28.Display_Name = null;
            MyLabel28.Field_Description = null;
            MyLabel28.Field_Name = null;
            MyLabel28.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel28.FieldName = null;
            MyLabel28.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel28.Generated = false;
            MyLabel28.Location = new Point(303, 4);
            MyLabel28.MendatroryField = false;
            MyLabel28.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel28.Name = "MyLabel28";
            MyLabel28.Size = new Size(30, 16);
            MyLabel28.SourceColumn = null;
            MyLabel28.TabIndex = 25;
            MyLabel28.Text = "User";
            MyLabel28.XpertDisplayMember = null;
            MyLabel28.XpertValueMember = null;
            MyLabel28.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TxtMultiSelectFinder3
            // 
            TxtMultiSelectFinder3.arrDispalyMember = null;
            TxtMultiSelectFinder3.arrValueMember = null;
            TxtMultiSelectFinder3.Calculation_Expression = null;
            TxtMultiSelectFinder3.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            TxtMultiSelectFinder3.Calculative = false;
            TxtMultiSelectFinder3.Collection_Name = null;
            TxtMultiSelectFinder3.Column_Name = null;
            TxtMultiSelectFinder3.Control_Name = "XpertMultiSelctFinder";
            TxtMultiSelectFinder3.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            TxtMultiSelectFinder3.Cursor = Cursors.Hand;
            TxtMultiSelectFinder3.Custom_Data = false;
            TxtMultiSelectFinder3.Custom_Datasource_Logic = false;
            TxtMultiSelectFinder3.Custom_Default = false;
            TxtMultiSelectFinder3.DataSource = null;
            TxtMultiSelectFinder3.Datasource_Assembly = null;
            TxtMultiSelectFinder3.Datasource_Namespace = null;
            TxtMultiSelectFinder3.Datasource_Program = null;
            TxtMultiSelectFinder3.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            TxtMultiSelectFinder3.Display_Name = null;
            TxtMultiSelectFinder3.DisplayMember = null;
            TxtMultiSelectFinder3.Enum_Name = null;
            TxtMultiSelectFinder3.Field_Description = null;
            TxtMultiSelectFinder3.Field_Name = null;
            TxtMultiSelectFinder3.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            TxtMultiSelectFinder3.Generated = false;
            TxtMultiSelectFinder3.Key = false;
            TxtMultiSelectFinder3.Key_Column_Name = null;
            TxtMultiSelectFinder3.Key_Property = null;
            TxtMultiSelectFinder3.Key_Value = null;
            TxtMultiSelectFinder3.Location = new Point(353, 2);
            TxtMultiSelectFinder3.Margin = new Padding(4, 3, 4, 3);
            TxtMultiSelectFinder3.Max_Size = 0;
            TxtMultiSelectFinder3.MendatroryField = false;
            TxtMultiSelectFinder3.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            TxtMultiSelectFinder3.Min_Size = 0;
            TxtMultiSelectFinder3.MinimumSize = new Size(100, 20);
            TxtMultiSelectFinder3.Model_Name = null;
            TxtMultiSelectFinder3.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMultiSelectFinder3.MyLinkLable1 = MyLabel28;
            TxtMultiSelectFinder3.MyLinkLable2 = null;
            TxtMultiSelectFinder3.MyNullText = "All";
            TxtMultiSelectFinder3.MyReadOnly = false;
            TxtMultiSelectFinder3.MyToolTipText = null;
            TxtMultiSelectFinder3.Name = "TxtMultiSelectFinder3";
            TxtMultiSelectFinder3.Name_Column_Name = null;
            TxtMultiSelectFinder3.Name_Property = null;
            TxtMultiSelectFinder3.Name_Value = null;
            TxtMultiSelectFinder3.Page_Key_Property = null;
            TxtMultiSelectFinder3.Page_Name_Property = null;
            TxtMultiSelectFinder3.Query_Class_Name = null;
            TxtMultiSelectFinder3.Required = false;
            TxtMultiSelectFinder3.ShowDataSource = false;
            TxtMultiSelectFinder3.Size = new Size(262, 20);
            TxtMultiSelectFinder3.SQLMethodName = null;
            TxtMultiSelectFinder3.TabIndex = 24;
            TxtMultiSelectFinder3.Table_Name = null;
            TxtMultiSelectFinder3.Tag_Column_Name = null;
            TxtMultiSelectFinder3.Tag_Property = null;
            TxtMultiSelectFinder3.ValueMember = null;
            TxtMultiSelectFinder3.Web_Page_Name = null;
            TxtMultiSelectFinder3.Web_Page_Url = null;
            TxtMultiSelectFinder3.XpertDisplayMember = null;
            TxtMultiSelectFinder3.XpertValueMember = null;
            TxtMultiSelectFinder3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel29
            // 
            MyLabel29.AutoSize = false;
            MyLabel29.BorderVisible = true;
            MyLabel29.Calculation_Expression = null;
            MyLabel29.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel29.Calculative = false;
            MyLabel29.Column_Name = null;
            MyLabel29.Control_Name = "MyLabel29";
            MyLabel29.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel29.Cursor = Cursors.Hand;
            MyLabel29.Custom_Data = false;
            MyLabel29.Custom_Default = false;
            MyLabel29.Display_Name = null;
            MyLabel29.Field_Description = null;
            MyLabel29.Field_Name = null;
            MyLabel29.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel29.FieldName = null;
            MyLabel29.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel29.Generated = false;
            MyLabel29.Location = new Point(2, 4);
            MyLabel29.MendatroryField = false;
            MyLabel29.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel29.Name = "MyLabel29";
            MyLabel29.Size = new Size(60, 16);
            MyLabel29.SourceColumn = null;
            MyLabel29.TabIndex = 0;
            MyLabel29.Text = "From Date";
            MyLabel29.XpertDisplayMember = null;
            MyLabel29.XpertValueMember = null;
            MyLabel29.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyDateTimePicker1
            // 
            MyDateTimePicker1.Calculation_Expression = null;
            MyDateTimePicker1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyDateTimePicker1.CalculationExpression = null;
            MyDateTimePicker1.Calculative = false;
            MyDateTimePicker1.Column_Name = null;
            MyDateTimePicker1.Control_Name = "MyDateTimePicker1";
            MyDateTimePicker1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyDateTimePicker1.Custom_Data = false;
            MyDateTimePicker1.Custom_Default = false;
            MyDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            MyDateTimePicker1.Display_Name = null;
            MyDateTimePicker1.Field_Description = null;
            MyDateTimePicker1.Field_Name = null;
            MyDateTimePicker1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyDateTimePicker1.FieldCode = null;
            MyDateTimePicker1.FieldDesc = null;
            MyDateTimePicker1.FieldMaxLength = 0;
            MyDateTimePicker1.FieldName = null;
            MyDateTimePicker1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyDateTimePicker1.Format = DateTimePickerFormat.Short;
            MyDateTimePicker1.Generated = false;
            MyDateTimePicker1.isCalculatedField = false;
            MyDateTimePicker1.IsSourceFromTable = false;
            MyDateTimePicker1.IsSourceFromValueList = false;
            MyDateTimePicker1.IsUnique = false;
            MyDateTimePicker1.Key = false;
            MyDateTimePicker1.Location = new Point(68, 3);
            MyDateTimePicker1.Max_Length = 0;
            MyDateTimePicker1.MendatroryField = false;
            MyDateTimePicker1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyDateTimePicker1.Min_Length = 0;
            MyDateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker1.MyLinkLable1 = MyLabel29;
            MyDateTimePicker1.MyLinkLable2 = null;
            MyDateTimePicker1.Name = "MyDateTimePicker1";
            MyDateTimePicker1.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker1.ReferenceFieldDesc = null;
            MyDateTimePicker1.ReferenceFieldName = null;
            MyDateTimePicker1.ReferenceTableName = null;
            MyDateTimePicker1.Size = new Size(81, 18);
            MyDateTimePicker1.TabIndex = 1;
            MyDateTimePicker1.TabStop = false;
            MyDateTimePicker1.Text = "13-Jun-11";
            MyDateTimePicker1.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            MyDateTimePicker1.XpertDisplayMember = null;
            MyDateTimePicker1.XpertValueMember = null;
            MyDateTimePicker1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel30
            // 
            MyLabel30.AutoSize = false;
            MyLabel30.BorderVisible = true;
            MyLabel30.Calculation_Expression = null;
            MyLabel30.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel30.Calculative = false;
            MyLabel30.Column_Name = null;
            MyLabel30.Control_Name = "MyLabel30";
            MyLabel30.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel30.Cursor = Cursors.Hand;
            MyLabel30.Custom_Data = false;
            MyLabel30.Custom_Default = false;
            MyLabel30.Display_Name = null;
            MyLabel30.Field_Description = null;
            MyLabel30.Field_Name = null;
            MyLabel30.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel30.FieldName = null;
            MyLabel30.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel30.Generated = false;
            MyLabel30.Location = new Point(153, 4);
            MyLabel30.MendatroryField = false;
            MyLabel30.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel30.Name = "MyLabel30";
            MyLabel30.Size = new Size(46, 16);
            MyLabel30.SourceColumn = null;
            MyLabel30.TabIndex = 2;
            MyLabel30.Text = "To Date";
            MyLabel30.XpertDisplayMember = null;
            MyLabel30.XpertValueMember = null;
            MyLabel30.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyDateTimePicker2
            // 
            MyDateTimePicker2.Calculation_Expression = null;
            MyDateTimePicker2.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyDateTimePicker2.CalculationExpression = null;
            MyDateTimePicker2.Calculative = false;
            MyDateTimePicker2.Column_Name = null;
            MyDateTimePicker2.Control_Name = "MyDateTimePicker2";
            MyDateTimePicker2.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyDateTimePicker2.Custom_Data = false;
            MyDateTimePicker2.Custom_Default = false;
            MyDateTimePicker2.CustomFormat = "dd/MM/yyyy";
            MyDateTimePicker2.Display_Name = null;
            MyDateTimePicker2.Field_Description = null;
            MyDateTimePicker2.Field_Name = null;
            MyDateTimePicker2.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyDateTimePicker2.FieldCode = null;
            MyDateTimePicker2.FieldDesc = null;
            MyDateTimePicker2.FieldMaxLength = 0;
            MyDateTimePicker2.FieldName = null;
            MyDateTimePicker2.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyDateTimePicker2.Format = DateTimePickerFormat.Short;
            MyDateTimePicker2.Generated = false;
            MyDateTimePicker2.isCalculatedField = false;
            MyDateTimePicker2.IsSourceFromTable = false;
            MyDateTimePicker2.IsSourceFromValueList = false;
            MyDateTimePicker2.IsUnique = false;
            MyDateTimePicker2.Key = false;
            MyDateTimePicker2.Location = new Point(205, 3);
            MyDateTimePicker2.Max_Length = 0;
            MyDateTimePicker2.MendatroryField = false;
            MyDateTimePicker2.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyDateTimePicker2.Min_Length = 0;
            MyDateTimePicker2.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker2.MyLinkLable1 = MyLabel30;
            MyDateTimePicker2.MyLinkLable2 = null;
            MyDateTimePicker2.Name = "MyDateTimePicker2";
            MyDateTimePicker2.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker2.ReferenceFieldDesc = null;
            MyDateTimePicker2.ReferenceFieldName = null;
            MyDateTimePicker2.ReferenceTableName = null;
            MyDateTimePicker2.Size = new Size(81, 18);
            MyDateTimePicker2.TabIndex = 3;
            MyDateTimePicker2.TabStop = false;
            MyDateTimePicker2.Text = "13-Jun-11";
            MyDateTimePicker2.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            MyDateTimePicker2.XpertDisplayMember = null;
            MyDateTimePicker2.XpertValueMember = null;
            MyDateTimePicker2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage8
            // 
            RadPageViewPage8.BackColor = SystemColors.ControlLight;
            RadPageViewPage8.Controls.Add(RadPageView6);
            RadPageViewPage8.Description = "Calender";
            RadPageViewPage8.Location = new Point(4, 31);
            RadPageViewPage8.Name = "RadPageViewPage8";
            RadPageViewPage8.Size = new Size(900, 409);
            RadPageViewPage8.Text = "TimeSheet";
            RadPageViewPage8.Title = "Calender";
            // 
            // RadPageView6
            // 
            RadPageView6.BorderColor = Color.Black;
            RadPageView6.Control_Name = "RadPageView6";
            RadPageView6.Controls.Add(RadPageViewPage9);
            RadPageView6.Controls.Add(RadPageViewPage10);
            RadPageView6.DefaultPage = RadPageViewPage9;
            RadPageView6.Dock = DockStyle.Fill;
            RadPageView6.Location = new Point(0, 0);
            RadPageView6.Name = "RadPageView6";
            RadPageView6.SelectedPage = RadPageViewPage9;
            RadPageView6.Size = new Size(900, 409);
            RadPageView6.TabIndex = 8;
            RadPageView6.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView6.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView6.GetChildAt(0)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView6.GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView6.GetChildAt(0)).Padding = new Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)RadPageView6.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.StripViewItemLayout)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).Title = "Calender";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).Description = "Calender";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BorderColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor2 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor3 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor4 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).Text = "TimeSheet";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).Title = "Leave Type";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).Description = "Leave Type";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).BorderColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).BorderInnerColor = Color.Transparent;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).BackColor2 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).BackColor3 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).BackColor4 = Color.White;
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).Text = "Gap Hours Detail";
            ((Telerik.WinControls.UI.RadPageViewStripItem)RadPageView6.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1)).BackColor = Color.White;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).BorderTopWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).BorderRightWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView6.GetChildAt(0).GetChildAt(1)).Padding = new Padding(3);
            // 
            // RadPageViewPage9
            // 
            RadPageViewPage9.BackColor = SystemColors.ControlLight;
            RadPageViewPage9.Controls.Add(MyRadGridView2);
            RadPageViewPage9.Controls.Add(Panel13);
            RadPageViewPage9.Description = "Calender";
            RadPageViewPage9.Location = new Point(4, 27);
            RadPageViewPage9.Name = "RadPageViewPage9";
            RadPageViewPage9.Size = new Size(892, 378);
            RadPageViewPage9.Text = "TimeSheet";
            RadPageViewPage9.Title = "Calender";
            // 
            // MyRadGridView2
            // 
            MyRadGridView2.BackColor = SystemColors.ActiveCaption;
            MyRadGridView2.Calculation_Expression = null;
            MyRadGridView2.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyRadGridView2.Calculative = false;
            MyRadGridView2.Class_Name = null;
            MyRadGridView2.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            MyRadGridView2.Column_Name = null;
            MyRadGridView2.Control_Name = "MyRadGridView2";
            MyRadGridView2.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyRadGridView2.Custom_Data = false;
            MyRadGridView2.Custom_Default = false;
            MyRadGridView2.Display_Name = null;
            MyRadGridView2.Dock = DockStyle.Fill;
            MyRadGridView2.Field_Description = null;
            MyRadGridView2.Field_Name = null;
            MyRadGridView2.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyRadGridView2.Generated = false;
            MyRadGridView2.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            MyRadGridView2.Location = new Point(0, 26);
            // 
            // 
            // 
            MyRadGridView2.MasterTemplate.ShowHeaderCellButtons = true;
            MyRadGridView2.MasterTemplate.ViewDefinition = tableViewDefinition16;
            MyRadGridView2.MendatroryField = false;
            MyRadGridView2.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyRadGridView2.MultiSelection = false;
            MyRadGridView2.Name = "MyRadGridView2";
            MyRadGridView2.Padding = new Padding(0, 10, 0, 0);
            MyRadGridView2.ShowHeaderCellButtons = true;
            MyRadGridView2.Size = new Size(892, 352);
            MyRadGridView2.TabIndex = 7;
            MyRadGridView2.Table_Name = null;
            MyRadGridView2.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            MyRadGridView2.XpertDisplayMember = null;
            MyRadGridView2.XpertValueMember = null;
            MyRadGridView2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView2.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView2.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView2.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel13
            // 
            Panel13.BackColor = Color.White;
            Panel13.BorderStyle = BorderStyle.Fixed3D;
            Panel13.Control_Name = "Panel13";
            Panel13.Controls.Add(UcSaveButton1);
            Panel13.Controls.Add(MyLabel31);
            Panel13.Controls.Add(Panel14);
            Panel13.Controls.Add(RadSplitButton1);
            Panel13.Controls.Add(MyLabel32);
            Panel13.Dock = DockStyle.Top;
            Panel13.Location = new Point(0, 0);
            Panel13.Name = "Panel13";
            Panel13.Size = new Size(892, 26);
            Panel13.TabIndex = 10;
            Panel13.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcSaveButton1
            // 
            UcSaveButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UcSaveButton1.Location = new Point(794, 1);
            UcSaveButton1.Margin = new Padding(4, 3, 4, 3);
            UcSaveButton1.MaximumSize = new Size(72, 21);
            UcSaveButton1.MinimumSize = new Size(72, 21);
            UcSaveButton1.Name = "UcSaveButton1";
            // 
            // 
            // 
            UcSaveButton1.RootElement.MaxSize = new Size(72, 21);
            UcSaveButton1.RootElement.MinSize = new Size(72, 21);
            UcSaveButton1.Size = new Size(72, 21);
            UcSaveButton1.TabIndex = 34;
            // 
            // MyLabel31
            // 
            MyLabel31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MyLabel31.AutoSize = false;
            MyLabel31.BorderVisible = true;
            MyLabel31.Calculation_Expression = null;
            MyLabel31.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel31.Calculative = false;
            MyLabel31.Column_Name = null;
            MyLabel31.Control_Name = "MyLabel31";
            MyLabel31.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel31.Cursor = Cursors.Hand;
            MyLabel31.Custom_Data = false;
            MyLabel31.Custom_Default = false;
            MyLabel31.Display_Name = null;
            MyLabel31.Field_Description = null;
            MyLabel31.Field_Name = null;
            MyLabel31.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel31.FieldName = null;
            MyLabel31.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel31.ForeColor = Color.Black;
            MyLabel31.Generated = false;
            MyLabel31.Location = new Point(685, 4);
            MyLabel31.MendatroryField = false;
            MyLabel31.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel31.Name = "MyLabel31";
            MyLabel31.Size = new Size(105, 15);
            MyLabel31.SourceColumn = null;
            MyLabel31.TabIndex = 30;
            MyLabel31.Text = "Manual Timesheet Filled";
            MyLabel31.XpertDisplayMember = null;
            MyLabel31.XpertValueMember = null;
            MyLabel31.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Panel14
            // 
            Panel14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel14.BackColor = Color.Silver;
            Panel14.BorderStyle = BorderStyle.Fixed3D;
            Panel14.Control_Name = "Panel14";
            Panel14.Location = new Point(668, 4);
            Panel14.Name = "Panel14";
            Panel14.Size = new Size(16, 16);
            Panel14.TabIndex = 29;
            Panel14.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadSplitButton1
            // 
            RadSplitButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RadSplitButton1.BackColor = SystemColors.ActiveCaption;
            RadSplitButton1.Image = (Image)resources.GetObject("RadSplitButton1.Image");
            RadSplitButton1.ImageAlignment = ContentAlignment.MiddleCenter;
            RadSplitButton1.Items.AddRange(new Telerik.WinControls.RadItem[] { RadMenuItem1, RadMenuItem2, RadMenuItem3, RadMenuItem4 });
            RadSplitButton1.Location = new Point(870, 1);
            RadSplitButton1.Name = "RadSplitButton1";
            RadSplitButton1.ShowArrow = false;
            RadSplitButton1.Size = new Size(20, 20);
            RadSplitButton1.TabIndex = 0;
            // 
            // RadMenuItem1
            // 
            RadMenuItem1.Name = "RadMenuItem1";
            RadMenuItem1.Text = "All";
            RadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // RadMenuItem2
            // 
            RadMenuItem2.Name = "RadMenuItem2";
            RadMenuItem2.Text = "Filled";
            // 
            // RadMenuItem3
            // 
            RadMenuItem3.Name = "RadMenuItem3";
            RadMenuItem3.Text = "Not Filled";
            // 
            // RadMenuItem4
            // 
            RadMenuItem4.Name = "RadMenuItem4";
            RadMenuItem4.Text = "Day-Sheet";
            // 
            // MyLabel32
            // 
            MyLabel32.AutoSize = false;
            MyLabel32.BorderVisible = true;
            MyLabel32.Calculation_Expression = null;
            MyLabel32.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel32.Calculative = false;
            MyLabel32.Column_Name = null;
            MyLabel32.Control_Name = "MyLabel32";
            MyLabel32.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel32.Cursor = Cursors.Hand;
            MyLabel32.Custom_Data = false;
            MyLabel32.Custom_Default = false;
            MyLabel32.Display_Name = null;
            MyLabel32.Field_Description = null;
            MyLabel32.Field_Name = null;
            MyLabel32.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel32.FieldName = null;
            MyLabel32.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel32.Generated = false;
            MyLabel32.Location = new Point(3, 1);
            MyLabel32.MendatroryField = false;
            MyLabel32.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel32.Name = "MyLabel32";
            MyLabel32.Size = new Size(65, 16);
            MyLabel32.SourceColumn = null;
            MyLabel32.TabIndex = 28;
            MyLabel32.Text = "Ticket Type";
            MyLabel32.XpertDisplayMember = null;
            MyLabel32.XpertValueMember = null;
            MyLabel32.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage10
            // 
            RadPageViewPage10.BackColor = SystemColors.ControlLight;
            RadPageViewPage10.Controls.Add(SplitContainer6);
            RadPageViewPage10.Description = "Leave Type";
            RadPageViewPage10.Location = new Point(4, 31);
            RadPageViewPage10.Name = "RadPageViewPage10";
            RadPageViewPage10.Size = new Size(892, 374);
            RadPageViewPage10.Text = "Gap Hours Detail";
            RadPageViewPage10.Title = "Leave Type";
            // 
            // SplitContainer6
            // 
            SplitContainer6.Control_Name = "SplitContainer6";
            SplitContainer6.Dock = DockStyle.Fill;
            SplitContainer6.Location = new Point(0, 0);
            SplitContainer6.Name = "SplitContainer6";
            // 
            // SplitContainer6.Panel1
            // 
            SplitContainer6.Panel1.Controls.Add(MyRadGridView3);
            SplitContainer6.Panel1.Controls.Add(Panel15);
            SplitContainer6.Panel1.Padding = new Padding(1);
            // 
            // SplitContainer6.Panel2
            // 
            SplitContainer6.Panel2.Controls.Add(MyRadGridView4);
            SplitContainer6.Panel2.Controls.Add(Panel16);
            SplitContainer6.Panel2.Padding = new Padding(1);
            SplitContainer6.Size = new Size(892, 374);
            SplitContainer6.SplitterDistance = 425;
            SplitContainer6.TabIndex = 0;
            SplitContainer6.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyRadGridView3
            // 
            MyRadGridView3.BackColor = Color.White;
            MyRadGridView3.Calculation_Expression = null;
            MyRadGridView3.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyRadGridView3.Calculative = false;
            MyRadGridView3.Class_Name = null;
            MyRadGridView3.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            MyRadGridView3.Column_Name = null;
            MyRadGridView3.Control_Name = "MyRadGridView3";
            MyRadGridView3.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyRadGridView3.Custom_Data = false;
            MyRadGridView3.Custom_Default = false;
            MyRadGridView3.Display_Name = null;
            MyRadGridView3.Dock = DockStyle.Fill;
            MyRadGridView3.Field_Description = null;
            MyRadGridView3.Field_Name = null;
            MyRadGridView3.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyRadGridView3.Generated = false;
            MyRadGridView3.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            MyRadGridView3.Location = new Point(1, 25);
            // 
            // 
            // 
            MyRadGridView3.MasterTemplate.ShowHeaderCellButtons = true;
            MyRadGridView3.MasterTemplate.ViewDefinition = tableViewDefinition17;
            MyRadGridView3.MendatroryField = false;
            MyRadGridView3.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyRadGridView3.MultiSelection = false;
            MyRadGridView3.Name = "MyRadGridView3";
            MyRadGridView3.Padding = new Padding(0, 10, 0, 0);
            MyRadGridView3.ShowHeaderCellButtons = true;
            MyRadGridView3.Size = new Size(423, 348);
            MyRadGridView3.TabIndex = 11;
            MyRadGridView3.Table_Name = null;
            MyRadGridView3.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            MyRadGridView3.XpertDisplayMember = null;
            MyRadGridView3.XpertValueMember = null;
            MyRadGridView3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView3.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView3.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView3.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel15
            // 
            Panel15.BackColor = Color.White;
            Panel15.BorderStyle = BorderStyle.Fixed3D;
            Panel15.Control_Name = "Panel15";
            Panel15.Controls.Add(UcRefreshIconButton3);
            Panel15.Controls.Add(MyLabel33);
            Panel15.Dock = DockStyle.Top;
            Panel15.Location = new Point(1, 1);
            Panel15.Name = "Panel15";
            Panel15.Size = new Size(423, 24);
            Panel15.TabIndex = 12;
            Panel15.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcRefreshIconButton3
            // 
            UcRefreshIconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UcRefreshIconButton3.Location = new Point(396, 0);
            UcRefreshIconButton3.Margin = new Padding(4, 3, 4, 3);
            UcRefreshIconButton3.MaximumSize = new Size(20, 20);
            UcRefreshIconButton3.MinimumSize = new Size(20, 20);
            UcRefreshIconButton3.Name = "UcRefreshIconButton3";
            // 
            // 
            // 
            UcRefreshIconButton3.RootElement.MaxSize = new Size(20, 20);
            UcRefreshIconButton3.RootElement.MinSize = new Size(20, 20);
            UcRefreshIconButton3.Size = new Size(20, 20);
            UcRefreshIconButton3.TabIndex = 29;
            // 
            // MyLabel33
            // 
            MyLabel33.AutoSize = false;
            MyLabel33.BorderVisible = true;
            MyLabel33.Calculation_Expression = null;
            MyLabel33.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel33.Calculative = false;
            MyLabel33.Column_Name = null;
            MyLabel33.Control_Name = "MyLabel33";
            MyLabel33.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel33.Cursor = Cursors.Hand;
            MyLabel33.Custom_Data = false;
            MyLabel33.Custom_Default = false;
            MyLabel33.Display_Name = null;
            MyLabel33.Field_Description = null;
            MyLabel33.Field_Name = null;
            MyLabel33.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel33.FieldName = null;
            MyLabel33.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel33.Generated = false;
            MyLabel33.Location = new Point(3, 1);
            MyLabel33.MendatroryField = false;
            MyLabel33.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel33.Name = "MyLabel33";
            MyLabel33.Size = new Size(105, 16);
            MyLabel33.SourceColumn = null;
            MyLabel33.TabIndex = 28;
            MyLabel33.Text = "Manual based gaps";
            MyLabel33.XpertDisplayMember = null;
            MyLabel33.XpertValueMember = null;
            MyLabel33.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyRadGridView4
            // 
            MyRadGridView4.BackColor = Color.White;
            MyRadGridView4.Calculation_Expression = null;
            MyRadGridView4.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyRadGridView4.Calculative = false;
            MyRadGridView4.Class_Name = null;
            MyRadGridView4.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            MyRadGridView4.Column_Name = null;
            MyRadGridView4.Control_Name = "MyRadGridView4";
            MyRadGridView4.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyRadGridView4.Custom_Data = false;
            MyRadGridView4.Custom_Default = false;
            MyRadGridView4.Display_Name = null;
            MyRadGridView4.Dock = DockStyle.Fill;
            MyRadGridView4.Field_Description = null;
            MyRadGridView4.Field_Name = null;
            MyRadGridView4.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyRadGridView4.Generated = false;
            MyRadGridView4.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            MyRadGridView4.Location = new Point(1, 25);
            // 
            // 
            // 
            MyRadGridView4.MasterTemplate.ShowHeaderCellButtons = true;
            MyRadGridView4.MasterTemplate.ViewDefinition = tableViewDefinition18;
            MyRadGridView4.MendatroryField = false;
            MyRadGridView4.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyRadGridView4.MultiSelection = false;
            MyRadGridView4.Name = "MyRadGridView4";
            MyRadGridView4.Padding = new Padding(0, 10, 0, 0);
            MyRadGridView4.ShowHeaderCellButtons = true;
            MyRadGridView4.Size = new Size(461, 348);
            MyRadGridView4.TabIndex = 11;
            MyRadGridView4.Table_Name = null;
            MyRadGridView4.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            MyRadGridView4.XpertDisplayMember = null;
            MyRadGridView4.XpertValueMember = null;
            MyRadGridView4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView4.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView4.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView4.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel16
            // 
            Panel16.BackColor = Color.White;
            Panel16.BorderStyle = BorderStyle.Fixed3D;
            Panel16.Control_Name = "Panel16";
            Panel16.Controls.Add(MyLabel34);
            Panel16.Dock = DockStyle.Top;
            Panel16.Location = new Point(1, 1);
            Panel16.Name = "Panel16";
            Panel16.Size = new Size(461, 24);
            Panel16.TabIndex = 12;
            Panel16.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel34
            // 
            MyLabel34.AutoSize = false;
            MyLabel34.BorderVisible = true;
            MyLabel34.Calculation_Expression = null;
            MyLabel34.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel34.Calculative = false;
            MyLabel34.Column_Name = null;
            MyLabel34.Control_Name = "MyLabel34";
            MyLabel34.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel34.Cursor = Cursors.Hand;
            MyLabel34.Custom_Data = false;
            MyLabel34.Custom_Default = false;
            MyLabel34.Display_Name = null;
            MyLabel34.Field_Description = null;
            MyLabel34.Field_Name = null;
            MyLabel34.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel34.FieldName = null;
            MyLabel34.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel34.Generated = false;
            MyLabel34.Location = new Point(3, 1);
            MyLabel34.MendatroryField = false;
            MyLabel34.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel34.Name = "MyLabel34";
            MyLabel34.Size = new Size(91, 16);
            MyLabel34.SourceColumn = null;
            MyLabel34.TabIndex = 28;
            MyLabel34.Text = "Auto based gaps";
            MyLabel34.XpertDisplayMember = null;
            MyLabel34.XpertValueMember = null;
            MyLabel34.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage11
            // 
            RadPageViewPage11.Controls.Add(RadScrollablePanel2);
            RadPageViewPage11.Controls.Add(Panel17);
            RadPageViewPage11.Controls.Add(RadCollapsiblePanel5);
            RadPageViewPage11.Description = "Pendency";
            RadPageViewPage11.Location = new Point(4, 31);
            RadPageViewPage11.Name = "RadPageViewPage11";
            RadPageViewPage11.Size = new Size(900, 409);
            RadPageViewPage11.Text = "Pendency";
            RadPageViewPage11.Title = "Pendency";
            // 
            // RadScrollablePanel2
            // 
            RadScrollablePanel2.Control_Name = "RadScrollablePanel2";
            RadScrollablePanel2.Dock = DockStyle.Fill;
            RadScrollablePanel2.Location = new Point(0, 102);
            RadScrollablePanel2.Name = "RadScrollablePanel2";
            RadScrollablePanel2.Padding = new Padding(0);
            // 
            // RadScrollablePanel2.PanelContainer
            // 
            RadScrollablePanel2.PanelContainer.Controls.Add(TableLayoutPanel2);
            RadScrollablePanel2.PanelContainer.Location = new Point(0, 0);
            RadScrollablePanel2.PanelContainer.Size = new Size(883, 307);
            RadScrollablePanel2.Size = new Size(900, 307);
            RadScrollablePanel2.TabIndex = 47;
            RadScrollablePanel2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel2.Control_Name = "TableLayoutPanel2";
            TableLayoutPanel2.Location = new Point(3, 3);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            TableLayoutPanel2.Size = new Size(877, 416);
            TableLayoutPanel2.TabIndex = 0;
            TableLayoutPanel2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Panel17
            // 
            Panel17.BackColor = Color.Transparent;
            Panel17.BorderStyle = BorderStyle.Fixed3D;
            Panel17.Control_Name = "Panel17";
            Panel17.Controls.Add(UcRefreshIconButton4);
            Panel17.Dock = DockStyle.Top;
            Panel17.Location = new Point(0, 75);
            Panel17.Name = "Panel17";
            Panel17.Size = new Size(900, 27);
            Panel17.TabIndex = 45;
            Panel17.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcRefreshIconButton4
            // 
            UcRefreshIconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UcRefreshIconButton4.Location = new Point(872, 1);
            UcRefreshIconButton4.Margin = new Padding(4, 3, 4, 3);
            UcRefreshIconButton4.MaximumSize = new Size(20, 20);
            UcRefreshIconButton4.MinimumSize = new Size(20, 20);
            UcRefreshIconButton4.Name = "UcRefreshIconButton4";
            // 
            // 
            // 
            UcRefreshIconButton4.RootElement.MaxSize = new Size(20, 20);
            UcRefreshIconButton4.RootElement.MinSize = new Size(20, 20);
            UcRefreshIconButton4.Size = new Size(20, 20);
            UcRefreshIconButton4.TabIndex = 1;
            // 
            // RadCollapsiblePanel5
            // 
            RadCollapsiblePanel5.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            RadCollapsiblePanel5.BackColor = SystemColors.ControlLight;
            RadCollapsiblePanel5.BorderColor = Color.Black;
            RadCollapsiblePanel5.Control_Name = "RadCollapsiblePanel5";
            RadCollapsiblePanel5.Dock = DockStyle.Top;
            RadCollapsiblePanel5.HeaderText = "Filter";
            RadCollapsiblePanel5.Location = new Point(0, 0);
            RadCollapsiblePanel5.Name = "RadCollapsiblePanel5";
            RadCollapsiblePanel5.OwnerBoundsCache = new Rectangle(0, 0, 900, 75);
            // 
            // RadCollapsiblePanel5.PanelContainer
            // 
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyLabel35);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(TxtMultiSelectFinder4);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyLabel36);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(TxtMultiSelectFinder5);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyLabel37);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(TxtMultiSelectFinder6);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyLabel38);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyDateTimePicker3);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyLabel39);
            RadCollapsiblePanel5.PanelContainer.Controls.Add(MyDateTimePicker4);
            RadCollapsiblePanel5.PanelContainer.Location = new Point(0, 0);
            RadCollapsiblePanel5.PanelContainer.Padding = new Padding(2);
            RadCollapsiblePanel5.PanelContainer.Size = new Size(900, 49);
            RadCollapsiblePanel5.ShowHeaderLine = false;
            RadCollapsiblePanel5.Size = new Size(900, 75);
            RadCollapsiblePanel5.TabIndex = 46;
            RadCollapsiblePanel5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).IsExpanded = true;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).BorderWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).BorderLeftWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).BorderTopWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).BorderRightWidth = 0F;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)RadCollapsiblePanel5.GetChildAt(0)).BorderBottomWidth = 0F;
            ((Telerik.WinControls.UI.CollapsiblePanelLayoutElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(0)).BackColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1)).ShowHeaderLine = false;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor2 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor3 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor4 = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1).GetChildAt(0)).Image = (Image)resources.GetObject("resource.Image4");
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1).GetChildAt(0)).BackColor = SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.CollapsiblePanelButtonElement)RadCollapsiblePanel5.GetChildAt(0).GetChildAt(1).GetChildAt(0)).StretchHorizontally = false;
            // 
            // MyLabel35
            // 
            MyLabel35.AutoSize = false;
            MyLabel35.BorderVisible = true;
            MyLabel35.Calculation_Expression = null;
            MyLabel35.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel35.Calculative = false;
            MyLabel35.Column_Name = null;
            MyLabel35.Control_Name = "MyLabel35";
            MyLabel35.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel35.Cursor = Cursors.Hand;
            MyLabel35.Custom_Data = false;
            MyLabel35.Custom_Default = false;
            MyLabel35.Display_Name = null;
            MyLabel35.Field_Description = null;
            MyLabel35.Field_Name = null;
            MyLabel35.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel35.FieldName = null;
            MyLabel35.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel35.Generated = false;
            MyLabel35.Location = new Point(307, 26);
            MyLabel35.MendatroryField = false;
            MyLabel35.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel35.Name = "MyLabel35";
            MyLabel35.Size = new Size(41, 16);
            MyLabel35.SourceColumn = null;
            MyLabel35.TabIndex = 29;
            MyLabel35.Text = "Project";
            MyLabel35.XpertDisplayMember = null;
            MyLabel35.XpertValueMember = null;
            MyLabel35.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TxtMultiSelectFinder4
            // 
            TxtMultiSelectFinder4.arrDispalyMember = null;
            TxtMultiSelectFinder4.arrValueMember = null;
            TxtMultiSelectFinder4.Calculation_Expression = null;
            TxtMultiSelectFinder4.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            TxtMultiSelectFinder4.Calculative = false;
            TxtMultiSelectFinder4.Collection_Name = null;
            TxtMultiSelectFinder4.Column_Name = null;
            TxtMultiSelectFinder4.Control_Name = "XpertMultiSelctFinder";
            TxtMultiSelectFinder4.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            TxtMultiSelectFinder4.Cursor = Cursors.Hand;
            TxtMultiSelectFinder4.Custom_Data = false;
            TxtMultiSelectFinder4.Custom_Datasource_Logic = false;
            TxtMultiSelectFinder4.Custom_Default = false;
            TxtMultiSelectFinder4.DataSource = null;
            TxtMultiSelectFinder4.Datasource_Assembly = null;
            TxtMultiSelectFinder4.Datasource_Namespace = null;
            TxtMultiSelectFinder4.Datasource_Program = null;
            TxtMultiSelectFinder4.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            TxtMultiSelectFinder4.Display_Name = null;
            TxtMultiSelectFinder4.DisplayMember = null;
            TxtMultiSelectFinder4.Enum_Name = null;
            TxtMultiSelectFinder4.Field_Description = null;
            TxtMultiSelectFinder4.Field_Name = null;
            TxtMultiSelectFinder4.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            TxtMultiSelectFinder4.Generated = false;
            TxtMultiSelectFinder4.Key = false;
            TxtMultiSelectFinder4.Key_Column_Name = null;
            TxtMultiSelectFinder4.Key_Property = null;
            TxtMultiSelectFinder4.Key_Value = null;
            TxtMultiSelectFinder4.Location = new Point(353, 24);
            TxtMultiSelectFinder4.Margin = new Padding(4, 3, 4, 3);
            TxtMultiSelectFinder4.Max_Size = 0;
            TxtMultiSelectFinder4.MendatroryField = false;
            TxtMultiSelectFinder4.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            TxtMultiSelectFinder4.Min_Size = 0;
            TxtMultiSelectFinder4.MinimumSize = new Size(100, 20);
            TxtMultiSelectFinder4.Model_Name = null;
            TxtMultiSelectFinder4.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMultiSelectFinder4.MyLinkLable1 = MyLabel35;
            TxtMultiSelectFinder4.MyLinkLable2 = null;
            TxtMultiSelectFinder4.MyNullText = "All";
            TxtMultiSelectFinder4.MyReadOnly = false;
            TxtMultiSelectFinder4.MyToolTipText = null;
            TxtMultiSelectFinder4.Name = "TxtMultiSelectFinder4";
            TxtMultiSelectFinder4.Name_Column_Name = null;
            TxtMultiSelectFinder4.Name_Property = null;
            TxtMultiSelectFinder4.Name_Value = null;
            TxtMultiSelectFinder4.Page_Key_Property = null;
            TxtMultiSelectFinder4.Page_Name_Property = null;
            TxtMultiSelectFinder4.Query_Class_Name = null;
            TxtMultiSelectFinder4.Required = false;
            TxtMultiSelectFinder4.ShowDataSource = false;
            TxtMultiSelectFinder4.Size = new Size(262, 20);
            TxtMultiSelectFinder4.SQLMethodName = null;
            TxtMultiSelectFinder4.TabIndex = 28;
            TxtMultiSelectFinder4.Table_Name = null;
            TxtMultiSelectFinder4.Tag_Column_Name = null;
            TxtMultiSelectFinder4.Tag_Property = null;
            TxtMultiSelectFinder4.ValueMember = null;
            TxtMultiSelectFinder4.Web_Page_Name = null;
            TxtMultiSelectFinder4.Web_Page_Url = null;
            TxtMultiSelectFinder4.XpertDisplayMember = null;
            TxtMultiSelectFinder4.XpertValueMember = null;
            TxtMultiSelectFinder4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel36
            // 
            MyLabel36.AutoSize = false;
            MyLabel36.BorderVisible = true;
            MyLabel36.Calculation_Expression = null;
            MyLabel36.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel36.Calculative = false;
            MyLabel36.Column_Name = null;
            MyLabel36.Control_Name = "MyLabel36";
            MyLabel36.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel36.Cursor = Cursors.Hand;
            MyLabel36.Custom_Data = false;
            MyLabel36.Custom_Default = false;
            MyLabel36.Display_Name = null;
            MyLabel36.Field_Description = null;
            MyLabel36.Field_Name = null;
            MyLabel36.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel36.FieldName = null;
            MyLabel36.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel36.Generated = false;
            MyLabel36.Location = new Point(2, 26);
            MyLabel36.MendatroryField = false;
            MyLabel36.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel36.Name = "MyLabel36";
            MyLabel36.Size = new Size(35, 16);
            MyLabel36.SourceColumn = null;
            MyLabel36.TabIndex = 27;
            MyLabel36.Text = "Client";
            MyLabel36.XpertDisplayMember = null;
            MyLabel36.XpertValueMember = null;
            MyLabel36.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TxtMultiSelectFinder5
            // 
            TxtMultiSelectFinder5.arrDispalyMember = null;
            TxtMultiSelectFinder5.arrValueMember = null;
            TxtMultiSelectFinder5.Calculation_Expression = null;
            TxtMultiSelectFinder5.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            TxtMultiSelectFinder5.Calculative = false;
            TxtMultiSelectFinder5.Collection_Name = null;
            TxtMultiSelectFinder5.Column_Name = null;
            TxtMultiSelectFinder5.Control_Name = "XpertMultiSelctFinder";
            TxtMultiSelectFinder5.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            TxtMultiSelectFinder5.Cursor = Cursors.Hand;
            TxtMultiSelectFinder5.Custom_Data = false;
            TxtMultiSelectFinder5.Custom_Datasource_Logic = false;
            TxtMultiSelectFinder5.Custom_Default = false;
            TxtMultiSelectFinder5.DataSource = null;
            TxtMultiSelectFinder5.Datasource_Assembly = null;
            TxtMultiSelectFinder5.Datasource_Namespace = null;
            TxtMultiSelectFinder5.Datasource_Program = null;
            TxtMultiSelectFinder5.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            TxtMultiSelectFinder5.Display_Name = null;
            TxtMultiSelectFinder5.DisplayMember = null;
            TxtMultiSelectFinder5.Enum_Name = null;
            TxtMultiSelectFinder5.Field_Description = null;
            TxtMultiSelectFinder5.Field_Name = null;
            TxtMultiSelectFinder5.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            TxtMultiSelectFinder5.Generated = false;
            TxtMultiSelectFinder5.Key = false;
            TxtMultiSelectFinder5.Key_Column_Name = null;
            TxtMultiSelectFinder5.Key_Property = null;
            TxtMultiSelectFinder5.Key_Value = null;
            TxtMultiSelectFinder5.Location = new Point(68, 24);
            TxtMultiSelectFinder5.Margin = new Padding(4, 3, 4, 3);
            TxtMultiSelectFinder5.Max_Size = 0;
            TxtMultiSelectFinder5.MendatroryField = false;
            TxtMultiSelectFinder5.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            TxtMultiSelectFinder5.Min_Size = 0;
            TxtMultiSelectFinder5.MinimumSize = new Size(100, 20);
            TxtMultiSelectFinder5.Model_Name = null;
            TxtMultiSelectFinder5.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMultiSelectFinder5.MyLinkLable1 = MyLabel36;
            TxtMultiSelectFinder5.MyLinkLable2 = null;
            TxtMultiSelectFinder5.MyNullText = "All";
            TxtMultiSelectFinder5.MyReadOnly = false;
            TxtMultiSelectFinder5.MyToolTipText = null;
            TxtMultiSelectFinder5.Name = "TxtMultiSelectFinder5";
            TxtMultiSelectFinder5.Name_Column_Name = null;
            TxtMultiSelectFinder5.Name_Property = null;
            TxtMultiSelectFinder5.Name_Value = null;
            TxtMultiSelectFinder5.Page_Key_Property = null;
            TxtMultiSelectFinder5.Page_Name_Property = null;
            TxtMultiSelectFinder5.Query_Class_Name = null;
            TxtMultiSelectFinder5.Required = false;
            TxtMultiSelectFinder5.ShowDataSource = false;
            TxtMultiSelectFinder5.Size = new Size(218, 20);
            TxtMultiSelectFinder5.SQLMethodName = null;
            TxtMultiSelectFinder5.TabIndex = 26;
            TxtMultiSelectFinder5.Table_Name = null;
            TxtMultiSelectFinder5.Tag_Column_Name = null;
            TxtMultiSelectFinder5.Tag_Property = null;
            TxtMultiSelectFinder5.ValueMember = null;
            TxtMultiSelectFinder5.Web_Page_Name = null;
            TxtMultiSelectFinder5.Web_Page_Url = null;
            TxtMultiSelectFinder5.XpertDisplayMember = null;
            TxtMultiSelectFinder5.XpertValueMember = null;
            TxtMultiSelectFinder5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel37
            // 
            MyLabel37.AutoSize = false;
            MyLabel37.BorderVisible = true;
            MyLabel37.Calculation_Expression = null;
            MyLabel37.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel37.Calculative = false;
            MyLabel37.Column_Name = null;
            MyLabel37.Control_Name = "MyLabel37";
            MyLabel37.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel37.Cursor = Cursors.Hand;
            MyLabel37.Custom_Data = false;
            MyLabel37.Custom_Default = false;
            MyLabel37.Display_Name = null;
            MyLabel37.Field_Description = null;
            MyLabel37.Field_Name = null;
            MyLabel37.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel37.FieldName = null;
            MyLabel37.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel37.Generated = false;
            MyLabel37.Location = new Point(307, 4);
            MyLabel37.MendatroryField = false;
            MyLabel37.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel37.Name = "MyLabel37";
            MyLabel37.Size = new Size(30, 16);
            MyLabel37.SourceColumn = null;
            MyLabel37.TabIndex = 25;
            MyLabel37.Text = "User";
            MyLabel37.XpertDisplayMember = null;
            MyLabel37.XpertValueMember = null;
            MyLabel37.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // TxtMultiSelectFinder6
            // 
            TxtMultiSelectFinder6.arrDispalyMember = null;
            TxtMultiSelectFinder6.arrValueMember = null;
            TxtMultiSelectFinder6.Calculation_Expression = null;
            TxtMultiSelectFinder6.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            TxtMultiSelectFinder6.Calculative = false;
            TxtMultiSelectFinder6.Collection_Name = null;
            TxtMultiSelectFinder6.Column_Name = null;
            TxtMultiSelectFinder6.Control_Name = "XpertMultiSelctFinder";
            TxtMultiSelectFinder6.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            TxtMultiSelectFinder6.Cursor = Cursors.Hand;
            TxtMultiSelectFinder6.Custom_Data = false;
            TxtMultiSelectFinder6.Custom_Datasource_Logic = false;
            TxtMultiSelectFinder6.Custom_Default = false;
            TxtMultiSelectFinder6.DataSource = null;
            TxtMultiSelectFinder6.Datasource_Assembly = null;
            TxtMultiSelectFinder6.Datasource_Namespace = null;
            TxtMultiSelectFinder6.Datasource_Program = null;
            TxtMultiSelectFinder6.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            TxtMultiSelectFinder6.Display_Name = null;
            TxtMultiSelectFinder6.DisplayMember = null;
            TxtMultiSelectFinder6.Enum_Name = null;
            TxtMultiSelectFinder6.Field_Description = null;
            TxtMultiSelectFinder6.Field_Name = null;
            TxtMultiSelectFinder6.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            TxtMultiSelectFinder6.Generated = false;
            TxtMultiSelectFinder6.Key = false;
            TxtMultiSelectFinder6.Key_Column_Name = null;
            TxtMultiSelectFinder6.Key_Property = null;
            TxtMultiSelectFinder6.Key_Value = null;
            TxtMultiSelectFinder6.Location = new Point(353, 2);
            TxtMultiSelectFinder6.Margin = new Padding(4, 3, 4, 3);
            TxtMultiSelectFinder6.Max_Size = 0;
            TxtMultiSelectFinder6.MendatroryField = false;
            TxtMultiSelectFinder6.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            TxtMultiSelectFinder6.Min_Size = 0;
            TxtMultiSelectFinder6.MinimumSize = new Size(100, 20);
            TxtMultiSelectFinder6.Model_Name = null;
            TxtMultiSelectFinder6.MyFont = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMultiSelectFinder6.MyLinkLable1 = MyLabel37;
            TxtMultiSelectFinder6.MyLinkLable2 = null;
            TxtMultiSelectFinder6.MyNullText = "All";
            TxtMultiSelectFinder6.MyReadOnly = false;
            TxtMultiSelectFinder6.MyToolTipText = null;
            TxtMultiSelectFinder6.Name = "TxtMultiSelectFinder6";
            TxtMultiSelectFinder6.Name_Column_Name = null;
            TxtMultiSelectFinder6.Name_Property = null;
            TxtMultiSelectFinder6.Name_Value = null;
            TxtMultiSelectFinder6.Page_Key_Property = null;
            TxtMultiSelectFinder6.Page_Name_Property = null;
            TxtMultiSelectFinder6.Query_Class_Name = null;
            TxtMultiSelectFinder6.Required = false;
            TxtMultiSelectFinder6.ShowDataSource = false;
            TxtMultiSelectFinder6.Size = new Size(262, 20);
            TxtMultiSelectFinder6.SQLMethodName = null;
            TxtMultiSelectFinder6.TabIndex = 24;
            TxtMultiSelectFinder6.Table_Name = null;
            TxtMultiSelectFinder6.Tag_Column_Name = null;
            TxtMultiSelectFinder6.Tag_Property = null;
            TxtMultiSelectFinder6.ValueMember = null;
            TxtMultiSelectFinder6.Web_Page_Name = null;
            TxtMultiSelectFinder6.Web_Page_Url = null;
            TxtMultiSelectFinder6.XpertDisplayMember = null;
            TxtMultiSelectFinder6.XpertValueMember = null;
            TxtMultiSelectFinder6.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel38
            // 
            MyLabel38.AutoSize = false;
            MyLabel38.BorderVisible = true;
            MyLabel38.Calculation_Expression = null;
            MyLabel38.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel38.Calculative = false;
            MyLabel38.Column_Name = null;
            MyLabel38.Control_Name = "MyLabel38";
            MyLabel38.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel38.Cursor = Cursors.Hand;
            MyLabel38.Custom_Data = false;
            MyLabel38.Custom_Default = false;
            MyLabel38.Display_Name = null;
            MyLabel38.Field_Description = null;
            MyLabel38.Field_Name = null;
            MyLabel38.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel38.FieldName = null;
            MyLabel38.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel38.Generated = false;
            MyLabel38.Location = new Point(2, 4);
            MyLabel38.MendatroryField = false;
            MyLabel38.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel38.Name = "MyLabel38";
            MyLabel38.Size = new Size(60, 16);
            MyLabel38.SourceColumn = null;
            MyLabel38.TabIndex = 0;
            MyLabel38.Text = "From Date";
            MyLabel38.XpertDisplayMember = null;
            MyLabel38.XpertValueMember = null;
            MyLabel38.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyDateTimePicker3
            // 
            MyDateTimePicker3.Calculation_Expression = null;
            MyDateTimePicker3.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyDateTimePicker3.CalculationExpression = null;
            MyDateTimePicker3.Calculative = false;
            MyDateTimePicker3.Column_Name = null;
            MyDateTimePicker3.Control_Name = "MyDateTimePicker3";
            MyDateTimePicker3.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyDateTimePicker3.Custom_Data = false;
            MyDateTimePicker3.Custom_Default = false;
            MyDateTimePicker3.CustomFormat = "dd/MM/yyyy";
            MyDateTimePicker3.Display_Name = null;
            MyDateTimePicker3.Field_Description = null;
            MyDateTimePicker3.Field_Name = null;
            MyDateTimePicker3.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyDateTimePicker3.FieldCode = null;
            MyDateTimePicker3.FieldDesc = null;
            MyDateTimePicker3.FieldMaxLength = 0;
            MyDateTimePicker3.FieldName = null;
            MyDateTimePicker3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyDateTimePicker3.Format = DateTimePickerFormat.Short;
            MyDateTimePicker3.Generated = false;
            MyDateTimePicker3.isCalculatedField = false;
            MyDateTimePicker3.IsSourceFromTable = false;
            MyDateTimePicker3.IsSourceFromValueList = false;
            MyDateTimePicker3.IsUnique = false;
            MyDateTimePicker3.Key = false;
            MyDateTimePicker3.Location = new Point(68, 3);
            MyDateTimePicker3.Max_Length = 0;
            MyDateTimePicker3.MendatroryField = false;
            MyDateTimePicker3.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyDateTimePicker3.Min_Length = 0;
            MyDateTimePicker3.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker3.MyLinkLable1 = MyLabel38;
            MyDateTimePicker3.MyLinkLable2 = null;
            MyDateTimePicker3.Name = "MyDateTimePicker3";
            MyDateTimePicker3.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker3.ReferenceFieldDesc = null;
            MyDateTimePicker3.ReferenceFieldName = null;
            MyDateTimePicker3.ReferenceTableName = null;
            MyDateTimePicker3.Size = new Size(81, 18);
            MyDateTimePicker3.TabIndex = 1;
            MyDateTimePicker3.TabStop = false;
            MyDateTimePicker3.Text = "13-Jun-11";
            MyDateTimePicker3.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            MyDateTimePicker3.XpertDisplayMember = null;
            MyDateTimePicker3.XpertValueMember = null;
            MyDateTimePicker3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyLabel39
            // 
            MyLabel39.AutoSize = false;
            MyLabel39.BorderVisible = true;
            MyLabel39.Calculation_Expression = null;
            MyLabel39.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel39.Calculative = false;
            MyLabel39.Column_Name = null;
            MyLabel39.Control_Name = "MyLabel39";
            MyLabel39.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel39.Cursor = Cursors.Hand;
            MyLabel39.Custom_Data = false;
            MyLabel39.Custom_Default = false;
            MyLabel39.Display_Name = null;
            MyLabel39.Field_Description = null;
            MyLabel39.Field_Name = null;
            MyLabel39.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel39.FieldName = null;
            MyLabel39.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel39.Generated = false;
            MyLabel39.Location = new Point(153, 4);
            MyLabel39.MendatroryField = false;
            MyLabel39.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel39.Name = "MyLabel39";
            MyLabel39.Size = new Size(46, 16);
            MyLabel39.SourceColumn = null;
            MyLabel39.TabIndex = 2;
            MyLabel39.Text = "To Date";
            MyLabel39.XpertDisplayMember = null;
            MyLabel39.XpertValueMember = null;
            MyLabel39.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // MyDateTimePicker4
            // 
            MyDateTimePicker4.Calculation_Expression = null;
            MyDateTimePicker4.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyDateTimePicker4.CalculationExpression = null;
            MyDateTimePicker4.Calculative = false;
            MyDateTimePicker4.Column_Name = null;
            MyDateTimePicker4.Control_Name = "MyDateTimePicker4";
            MyDateTimePicker4.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyDateTimePicker4.Custom_Data = false;
            MyDateTimePicker4.Custom_Default = false;
            MyDateTimePicker4.CustomFormat = "dd/MM/yyyy";
            MyDateTimePicker4.Display_Name = null;
            MyDateTimePicker4.Field_Description = null;
            MyDateTimePicker4.Field_Name = null;
            MyDateTimePicker4.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyDateTimePicker4.FieldCode = null;
            MyDateTimePicker4.FieldDesc = null;
            MyDateTimePicker4.FieldMaxLength = 0;
            MyDateTimePicker4.FieldName = null;
            MyDateTimePicker4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyDateTimePicker4.Format = DateTimePickerFormat.Short;
            MyDateTimePicker4.Generated = false;
            MyDateTimePicker4.isCalculatedField = false;
            MyDateTimePicker4.IsSourceFromTable = false;
            MyDateTimePicker4.IsSourceFromValueList = false;
            MyDateTimePicker4.IsUnique = false;
            MyDateTimePicker4.Key = false;
            MyDateTimePicker4.Location = new Point(205, 3);
            MyDateTimePicker4.Max_Length = 0;
            MyDateTimePicker4.MendatroryField = false;
            MyDateTimePicker4.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyDateTimePicker4.Min_Length = 0;
            MyDateTimePicker4.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker4.MyLinkLable1 = MyLabel39;
            MyDateTimePicker4.MyLinkLable2 = null;
            MyDateTimePicker4.Name = "MyDateTimePicker4";
            MyDateTimePicker4.NullDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            MyDateTimePicker4.ReferenceFieldDesc = null;
            MyDateTimePicker4.ReferenceFieldName = null;
            MyDateTimePicker4.ReferenceTableName = null;
            MyDateTimePicker4.Size = new Size(81, 18);
            MyDateTimePicker4.TabIndex = 3;
            MyDateTimePicker4.TabStop = false;
            MyDateTimePicker4.Text = "13-Jun-11";
            MyDateTimePicker4.Value = new DateTime(2011, 6, 13, 11, 29, 49, 421);
            MyDateTimePicker4.XpertDisplayMember = null;
            MyDateTimePicker4.XpertValueMember = null;
            MyDateTimePicker4.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadPageViewPage12
            // 
            RadPageViewPage12.Controls.Add(MyRadGridView5);
            RadPageViewPage12.Controls.Add(Panel18);
            RadPageViewPage12.Description = "TimeSheet Approval";
            RadPageViewPage12.Location = new Point(0, 0);
            RadPageViewPage12.Name = "RadPageViewPage12";
            RadPageViewPage12.Size = new Size(200, 100);
            RadPageViewPage12.Title = "TimeSheet Approval";
            // 
            // MyRadGridView5
            // 
            MyRadGridView5.BackColor = Color.White;
            MyRadGridView5.Calculation_Expression = null;
            MyRadGridView5.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyRadGridView5.Calculative = false;
            MyRadGridView5.Class_Name = null;
            MyRadGridView5.Column_Mode = XpertStudio.Common.Enums.XSGridColumnMode.Design;
            MyRadGridView5.Column_Name = null;
            MyRadGridView5.Control_Name = "MyRadGridView5";
            MyRadGridView5.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyRadGridView5.Custom_Data = false;
            MyRadGridView5.Custom_Default = false;
            MyRadGridView5.Display_Name = null;
            MyRadGridView5.Dock = DockStyle.Fill;
            MyRadGridView5.Field_Description = null;
            MyRadGridView5.Field_Name = null;
            MyRadGridView5.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyRadGridView5.Generated = false;
            MyRadGridView5.GridType = XpertStudio.Common.Enums.XSGridType.Grid;
            MyRadGridView5.Location = new Point(0, 27);
            // 
            // 
            // 
            MyRadGridView5.MasterTemplate.ShowHeaderCellButtons = true;
            MyRadGridView5.MasterTemplate.ViewDefinition = tableViewDefinition19;
            MyRadGridView5.MendatroryField = false;
            MyRadGridView5.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyRadGridView5.MultiSelection = false;
            MyRadGridView5.Name = "MyRadGridView5";
            MyRadGridView5.Padding = new Padding(0, 10, 0, 0);
            MyRadGridView5.ShowHeaderCellButtons = true;
            MyRadGridView5.Size = new Size(200, 73);
            MyRadGridView5.TabIndex = 45;
            MyRadGridView5.Table_Name = null;
            MyRadGridView5.Usage_Type = XpertStudio.Common.Enums.XSGridUsageType.None;
            MyRadGridView5.XpertDisplayMember = null;
            MyRadGridView5.XpertValueMember = null;
            MyRadGridView5.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView5.GetChildAt(0)).BorderColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView5.GetChildAt(0)).BorderBottomColor = SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)MyRadGridView5.GetChildAt(0)).Padding = new Padding(0, 10, 0, 0);
            // 
            // Panel18
            // 
            Panel18.BackColor = Color.Transparent;
            Panel18.BorderStyle = BorderStyle.Fixed3D;
            Panel18.Control_Name = "Panel18";
            Panel18.Controls.Add(UcSaveButton2);
            Panel18.Controls.Add(MyLabel40);
            Panel18.Controls.Add(UcRefreshIconButton5);
            Panel18.Dock = DockStyle.Top;
            Panel18.Location = new Point(0, 0);
            Panel18.Name = "Panel18";
            Panel18.Size = new Size(200, 27);
            Panel18.TabIndex = 43;
            Panel18.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcSaveButton2
            // 
            UcSaveButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UcSaveButton2.Location = new Point(820, 1);
            UcSaveButton2.Margin = new Padding(4, 3, 4, 3);
            UcSaveButton2.MaximumSize = new Size(72, 21);
            UcSaveButton2.MinimumSize = new Size(72, 21);
            UcSaveButton2.Name = "UcSaveButton2";
            // 
            // 
            // 
            UcSaveButton2.RootElement.MaxSize = new Size(72, 21);
            UcSaveButton2.RootElement.MinSize = new Size(72, 21);
            UcSaveButton2.Size = new Size(72, 21);
            UcSaveButton2.TabIndex = 33;
            // 
            // MyLabel40
            // 
            MyLabel40.AutoSize = false;
            MyLabel40.BorderVisible = true;
            MyLabel40.Calculation_Expression = null;
            MyLabel40.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            MyLabel40.Calculative = false;
            MyLabel40.Column_Name = null;
            MyLabel40.Control_Name = "MyLabel40";
            MyLabel40.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            MyLabel40.Cursor = Cursors.Hand;
            MyLabel40.Custom_Data = false;
            MyLabel40.Custom_Default = false;
            MyLabel40.Display_Name = null;
            MyLabel40.Field_Description = null;
            MyLabel40.Field_Name = null;
            MyLabel40.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel40.FieldName = null;
            MyLabel40.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            MyLabel40.Generated = false;
            MyLabel40.Location = new Point(3, 3);
            MyLabel40.MendatroryField = false;
            MyLabel40.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel40.Name = "MyLabel40";
            MyLabel40.Size = new Size(40, 16);
            MyLabel40.SourceColumn = null;
            MyLabel40.TabIndex = 26;
            MyLabel40.Text = "List : 0";
            MyLabel40.XpertDisplayMember = null;
            MyLabel40.XpertValueMember = null;
            MyLabel40.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // UcRefreshIconButton5
            // 
            UcRefreshIconButton5.Location = new Point(796, 1);
            UcRefreshIconButton5.Margin = new Padding(4, 3, 4, 3);
            UcRefreshIconButton5.MaximumSize = new Size(20, 20);
            UcRefreshIconButton5.MinimumSize = new Size(20, 20);
            UcRefreshIconButton5.Name = "UcRefreshIconButton5";
            // 
            // 
            // 
            UcRefreshIconButton5.RootElement.MaxSize = new Size(20, 20);
            UcRefreshIconButton5.RootElement.MinSize = new Size(20, 20);
            UcRefreshIconButton5.Size = new Size(20, 20);
            UcRefreshIconButton5.TabIndex = 1;
            // 
            // frmTimeSheetDashboard
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 538);
            Controls.Add(RadPageView1);
            CurrentEditorType = "frmRuleEditor";
            ExternalAssemblies.Assemblies = (System.Collections.Generic.List<string>)resources.GetObject("resource.Assemblies");
            MaxFieldsListPage = 5;
            Name = "frmTimeSheetDashboard";
            Text = "LMS Dashboard ";
            Controls.SetChildIndex(_RadCollapsiblePanel1, 0);
            Controls.SetChildIndex(RadPageView1, 0);
            ((System.ComponentModel.ISupportInitialize)_RadCollapsiblePanel1).EndInit();
            _RadCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            SplitContainer2.Panel1.ResumeLayout(false);
            SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer2).EndInit();
            SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewFilled).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewGap).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOverviewClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadPageView1).EndInit();
            RadPageView1.ResumeLayout(false);
            RadPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RadPageView2).EndInit();
            RadPageView2.ResumeLayout(false);
            RadPageViewPage2.ResumeLayout(false);
            RadPageViewPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RadPageView3).EndInit();
            RadPageView3.ResumeLayout(false);
            rdAllKRAList_PriorityChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvKRA.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvKRA).EndInit();
            Panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRefresh_KRA).EndInit();
            rdTimeSheet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RadPageView4).EndInit();
            RadPageView4.ResumeLayout(false);
            RadPageViewPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvList.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvList).EndInit();
            Panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSendApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTicketType).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTicketTypeName).EndInit();
            RadPageViewPage5.ResumeLayout(false);
            SplitContainer5.Panel1.ResumeLayout(false);
            SplitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer5).EndInit();
            SplitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvManual.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvManual).EndInit();
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel6).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_Auto.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_Auto).EndInit();
            Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel9).EndInit();
            RadPageViewPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvEducation.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvEducation).EndInit();
            RadPageViewPage13.ResumeLayout(false);
            SplitContainer9.Panel1.ResumeLayout(false);
            SplitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer9).EndInit();
            SplitContainer9.ResumeLayout(false);
            Panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lblCountlistAwited).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefreshAwaited).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvAwaitedCommon.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvAwaitedCommon).EndInit();
            RadPageViewPage15.ResumeLayout(false);
            SplitContainer10.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer10).EndInit();
            SplitContainer10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvSuspended.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvSuspended).EndInit();
            rdHeldup.ResumeLayout(false);
            Panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork).EndInit();
            Panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel51).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHeldupRefresh).EndInit();
            RadCollapsiblePanel7.PanelContainer.ResumeLayout(false);
            RadCollapsiblePanel7.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel7).EndInit();
            RadCollapsiblePanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel45).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel49).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtHeldFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel50).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtHeldTo).EndInit();
            rdExpire.ResumeLayout(false);
            Panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvExpired.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvExpired).EndInit();
            Panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel44).EndInit();
            ((System.ComponentModel.ISupportInitialize)btExpiryRefresh).EndInit();
            RadCollapsiblePanel6.PanelContainer.ResumeLayout(false);
            RadCollapsiblePanel6.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel6).EndInit();
            RadCollapsiblePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel46).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel47).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtExpiredFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel48).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtExpiredTo).EndInit();
            rdAwaitedWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvAwaited.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvAwaited).EndInit();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAwited).EndInit();
            RadCollapsiblePanel2.PanelContainer.ResumeLayout(false);
            RadCollapsiblePanel2.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel2).EndInit();
            RadCollapsiblePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel7).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel10).EndInit();
            ((System.ComponentModel.ISupportInitialize)AwaitedFromDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel11).EndInit();
            ((System.ComponentModel.ISupportInitialize)AwaitedToDate).EndInit();
            rdDayToDay.ResumeLayout(false);
            SplitContainer8.Panel1.ResumeLayout(false);
            SplitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer8).EndInit();
            SplitContainer8.ResumeLayout(false);
            Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAddNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel12).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDayRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDayToDay.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDayToDay).EndInit();
            rdDone.ResumeLayout(false);
            SplitContainer13.Panel1.ResumeLayout(false);
            SplitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer13).EndInit();
            SplitContainer13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvDone.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDone).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDone).EndInit();
            rdNotDone.ResumeLayout(false);
            SplitContainer12.Panel1.ResumeLayout(false);
            SplitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer12).EndInit();
            SplitContainer12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvNotDone.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvNotDone).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNotDone).EndInit();
            RadPageViewPage6.ResumeLayout(false);
            SplitContainer7.Panel1.ResumeLayout(false);
            SplitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer7).EndInit();
            SplitContainer7.ResumeLayout(false);
            SplitContainer11.Panel1.ResumeLayout(false);
            SplitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer11).EndInit();
            SplitContainer11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvResponsibility.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvResponsibility).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnResponsibiltySave).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)ControlsContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadPageView5).EndInit();
            RadPageView5.ResumeLayout(false);
            RadPageViewPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyRadGridView1.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView1).EndInit();
            Panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton2).EndInit();
            RadCollapsiblePanel4.PanelContainer.ResumeLayout(false);
            RadCollapsiblePanel4.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel4).EndInit();
            RadCollapsiblePanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel24).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel25).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel27).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel28).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel29).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel30).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker2).EndInit();
            RadPageViewPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RadPageView6).EndInit();
            RadPageView6.ResumeLayout(false);
            RadPageViewPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyRadGridView2.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView2).EndInit();
            Panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UcSaveButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel31).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadSplitButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel32).EndInit();
            RadPageViewPage10.ResumeLayout(false);
            SplitContainer6.Panel1.ResumeLayout(false);
            SplitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer6).EndInit();
            SplitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyRadGridView3.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView3).EndInit();
            Panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel33).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView4.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView4).EndInit();
            Panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel34).EndInit();
            RadPageViewPage11.ResumeLayout(false);
            RadScrollablePanel2.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RadScrollablePanel2).EndInit();
            RadScrollablePanel2.ResumeLayout(false);
            Panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton4).EndInit();
            RadCollapsiblePanel5.PanelContainer.ResumeLayout(false);
            RadCollapsiblePanel5.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RadCollapsiblePanel5).EndInit();
            RadCollapsiblePanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel35).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel36).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel37).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel38).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker3).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel39).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyDateTimePicker4).EndInit();
            RadPageViewPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyRadGridView5.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyRadGridView5).EndInit();
            Panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UcSaveButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyLabel40).EndInit();
            ((System.ComponentModel.ISupportInitialize)UcRefreshIconButton5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal XS.WinForms.Controls.XpertLabel txtOverviewGap;
        internal XS.WinForms.Controls.XpertLabel txtOverviewFilled;
        internal XS.WinForms.Controls.XpertPictureBox PictureBox1;
        internal XS.WinForms.Controls.XpertLabel MyLabel3;
        internal XS.WinForms.Controls.XpertLabel btnNext;
        internal XS.WinForms.Controls.XpertLabel btnPrevious;
        internal XS.WinForms.Controls.XpertLabel txtOverviewClose;
        internal XS.WinForms.Controls.XpertLabel txtOverviewDelay;
        internal XS.WinForms.Controls.XpertLabel txtOverviewOpen;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer2;
        internal XS.WinForms.Controls.XpertPageView RadPageView1;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage1;
        internal XS.WinForms.Controls.XpertPageView RadPageView2;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage2;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage3;
        internal XS.WinForms.Controls.XSMSPanel Pnl_Type;
        internal XS.WinForms.Controls.XpertDataGridView gvList;
        internal XS.WinForms.Controls.XSMSPanel Panel6;
        internal Telerik.WinControls.UI.RadSplitButton btnTicketType;
        internal XS.WinForms.Controls.XpertLabel lblTicketTypeName;
        internal Telerik.WinControls.UI.RadMenuItem btnAll;
        internal Telerik.WinControls.UI.RadMenuItem btnFilled;
        internal Telerik.WinControls.UI.RadMenuItem btnNotFilled;
        internal XS.WinForms.Controls.XpertLabel MyLabel4;
        internal XS.WinForms.Controls.XpertPageView RadPageView3;
        internal Telerik.WinControls.UI.RadPageViewPage rdTimeSheet;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer5;
        internal XS.WinForms.Controls.XpertDataGridView gvManual;
        internal XS.WinForms.Controls.XSMSPanel Panel3;
        internal XS.WinForms.Controls.XpertLabel MyLabel6;
        internal XS.WinForms.Controls.XpertDataGridView gv_Auto;
        internal XS.WinForms.Controls.XSMSPanel Panel5;
        internal XS.WinForms.Controls.XpertLabel MyLabel9;
        internal Telerik.WinControls.UI.RadButton UcRefreshIconButton1;
        internal Telerik.WinControls.UI.RadButton btnSendApp;
        
        internal XS.WinForms.Controls.XpertPageView RadPageView4;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage4;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage5;
        internal XS.WinForms.Controls.XSMSPanel Panel2;
        internal Telerik.WinControls.UI.RadPageViewPage rdAllKRAList_PriorityChange;
        internal XS.WinForms.Controls.XSMSPanel Panel10;
        internal Telerik.WinControls.UI.RadButton btnRefresh_KRA;
        internal XS.WinForms.Controls.XpertDataGridView gvKRA;
        internal Telerik.WinControls.UI.RadMenuItem btnDaySheet;
        internal XS.WinForms.Controls.XpertPageView RadPageView5;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage7;
        internal XS.WinForms.Controls.XpertDataGridView MyRadGridView1;
        internal XS.WinForms.Controls.XSMSPanel Panel12;
        internal Telerik.WinControls.UI.RadButton UcRefreshIconButton2;
        internal XS.WinForms.Controls.XpertCollapsiblePanel RadCollapsiblePanel4;
        internal XS.WinForms.Controls.XpertLabel MyLabel24;
        internal XS.WinForms.Controls.XpertDropDown MyComboBox1;
        internal XS.WinForms.Controls.XpertLabel MyLabel25;
        internal XS.WinForms.Controls.XpertMultiSelctFinder TxtMultiSelectFinder1;
        internal XS.WinForms.Controls.XpertLabel MyLabel27;
        internal XS.WinForms.Controls.XpertMultiSelctFinder TxtMultiSelectFinder2;
        internal XS.WinForms.Controls.XpertLabel MyLabel28;
        internal XS.WinForms.Controls.XpertMultiSelctFinder TxtMultiSelectFinder3;
        internal XS.WinForms.Controls.XpertLabel MyLabel29;
        internal XS.WinForms.Controls.XpertDateTime MyDateTimePicker1;
        internal XS.WinForms.Controls.XpertLabel MyLabel30;
        internal XS.WinForms.Controls.XpertDateTime MyDateTimePicker2;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage8;
        internal XS.WinForms.Controls.XpertPageView RadPageView6;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage9;
        internal XS.WinForms.Controls.XpertDataGridView MyRadGridView2;
        internal XS.WinForms.Controls.XSMSPanel Panel13;
        internal Telerik.WinControls.UI.RadButton UcSaveButton1;
        internal XS.WinForms.Controls.XpertLabel MyLabel31;
        internal XS.WinForms.Controls.XSMSPanel Panel14;
        internal Telerik.WinControls.UI.RadSplitButton RadSplitButton1;
        internal Telerik.WinControls.UI.RadMenuItem RadMenuItem1;
        internal Telerik.WinControls.UI.RadMenuItem RadMenuItem2;
        internal Telerik.WinControls.UI.RadMenuItem RadMenuItem3;
        internal Telerik.WinControls.UI.RadMenuItem RadMenuItem4;
        internal XS.WinForms.Controls.XpertLabel MyLabel32;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage10;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer6;
        internal XS.WinForms.Controls.XpertDataGridView MyRadGridView3;
        internal XS.WinForms.Controls.XSMSPanel Panel15;
        internal Telerik.WinControls.UI.RadButton UcRefreshIconButton3;
        internal XS.WinForms.Controls.XpertLabel MyLabel33;
        internal XS.WinForms.Controls.XpertDataGridView MyRadGridView4;
        internal XS.WinForms.Controls.XSMSPanel Panel16;
        internal XS.WinForms.Controls.XpertLabel MyLabel34;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage11;
        internal XS.WinForms.Controls.XpertScrollablePanel RadScrollablePanel2;
        internal XS.WinForms.Controls.XpertTableLayoutPanel TableLayoutPanel2;
        internal XS.WinForms.Controls.XSMSPanel Panel17;
        internal Telerik.WinControls.UI.RadButton UcRefreshIconButton4;
        internal XS.WinForms.Controls.XpertCollapsiblePanel RadCollapsiblePanel5;
        internal XS.WinForms.Controls.XpertLabel MyLabel35;
        internal XS.WinForms.Controls.XpertMultiSelctFinder TxtMultiSelectFinder4;
        internal XS.WinForms.Controls.XpertLabel MyLabel36;
        internal XS.WinForms.Controls.XpertMultiSelctFinder TxtMultiSelectFinder5;
        internal XS.WinForms.Controls.XpertLabel MyLabel37;
        internal XS.WinForms.Controls.XpertMultiSelctFinder TxtMultiSelectFinder6;
        internal XS.WinForms.Controls.XpertLabel MyLabel38;
        internal XS.WinForms.Controls.XpertDateTime MyDateTimePicker3;
        internal XS.WinForms.Controls.XpertLabel MyLabel39;
        internal XS.WinForms.Controls.XpertDateTime MyDateTimePicker4;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage12;
        internal XS.WinForms.Controls.XpertDataGridView MyRadGridView5;
        internal XS.WinForms.Controls.XSMSPanel Panel18;
        internal Telerik.WinControls.UI.RadButton UcSaveButton2;
        internal XS.WinForms.Controls.XpertLabel MyLabel40;
        internal Telerik.WinControls.UI.RadButton UcRefreshIconButton5;
        internal XS.WinForms.Controls.XSMSPanel Panel21;
        internal XS.WinForms.Controls.XpertLabel MyLabel51;
        internal Telerik.WinControls.UI.RadButton btnHeldupRefresh;
        internal XS.WinForms.Controls.XpertCollapsiblePanel RadCollapsiblePanel7;
        internal XS.WinForms.Controls.XpertLabel MyLabel45;
        internal XS.WinForms.Controls.XpertMultiSelctFinder txtHedlupUsers;
        internal XS.WinForms.Controls.XpertLabel MyLabel49;
        internal XS.WinForms.Controls.XpertDateTime dtHeldFrom;
        internal XS.WinForms.Controls.XpertLabel MyLabel50;
        internal XS.WinForms.Controls.XpertDateTime dtHeldTo;
        internal Telerik.WinControls.UI.RadPageViewPage rdAwaitedWork;
        internal XS.WinForms.Controls.XpertDataGridView gvAwaited;
        internal XS.WinForms.Controls.XSMSPanel Panel4;
        internal XS.WinForms.Controls.XpertLabel MyLabel5;
        internal Telerik.WinControls.UI.RadButton btnAwited;
        internal XS.WinForms.Controls.XpertCollapsiblePanel RadCollapsiblePanel2;
        internal XS.WinForms.Controls.XpertLabel MyLabel7;
        internal XS.WinForms.Controls.XpertMultiSelctFinder AwaitedUsers;
        internal XS.WinForms.Controls.XpertLabel MyLabel10;
        internal XS.WinForms.Controls.XpertDateTime AwaitedFromDate;
        internal XS.WinForms.Controls.XpertLabel MyLabel11;
        internal XS.WinForms.Controls.XpertDateTime AwaitedToDate;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage6;
        internal XS.WinForms.Controls.XpertDataGridView gvResponsibility;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer7;
        internal XS.WinForms.Controls.XpertButton btnSave;
        internal XS.WinForms.Controls.XpertButton btnReset;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage14;
        internal XS.WinForms.Controls.XpertDataGridView gvEducation;
        internal Telerik.WinControls.UI.RadPageViewPage rdDayToDay;
        internal XS.WinForms.Controls.XpertDataGridView gvDayToDay;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer8;
        internal XS.WinForms.Controls.XSMSPanel Panel7;
        internal XS.WinForms.Controls.XpertLabel MyLabel12;
        internal Telerik.WinControls.UI.RadButton btnDayRefresh;
        internal Telerik.WinControls.UI.RadButton btnAddNew;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage13;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer9;
        internal XS.WinForms.Controls.XSMSPanel Panel19;
        internal XS.WinForms.Controls.XpertLabel lblCountlistAwited;
        internal Telerik.WinControls.UI.RadButton btnRefreshAwaited;
        internal XS.WinForms.Controls.XpertDataGridView gvAwaitedCommon;
        internal Telerik.WinControls.UI.RadPageViewPage RadPageViewPage15;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer10;
        internal XS.WinForms.Controls.XpertDataGridView gvSuspended;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer11;
        internal Telerik.WinControls.UI.RadButton btnResponsibiltySave;
        internal XS.WinForms.Controls.XSMSPanel Panel23;
        internal XS.WinForms.Controls.XSMSPanel Panel22;
        internal Telerik.WinControls.UI.RadPageViewPage rdDone;
        internal XS.WinForms.Controls.XpertDataGridView gvDone;
        internal Telerik.WinControls.UI.RadPageViewPage rdNotDone;
        internal XS.WinForms.Controls.XpertDataGridView gvNotDone;
        internal Telerik.WinControls.UI.RadPageViewPage rdHeldup;
        internal Telerik.WinControls.UI.RadPageViewPage rdExpire;
        internal XS.WinForms.Controls.XpertDataGridView gvHeldUpWork;
        internal XS.WinForms.Controls.XSMSPanel Panel24;
        internal XS.WinForms.Controls.XpertDataGridView gvExpired;
        internal XS.WinForms.Controls.XSMSPanel Panel20;
        internal XS.WinForms.Controls.XpertLabel MyLabel44;
        internal Telerik.WinControls.UI.RadButton btExpiryRefresh;
        internal XS.WinForms.Controls.XpertCollapsiblePanel RadCollapsiblePanel6;
        internal XS.WinForms.Controls.XpertLabel MyLabel46;
        internal XS.WinForms.Controls.XpertMultiSelctFinder txtExpiredUsers;
        internal XS.WinForms.Controls.XpertLabel MyLabel47;
        internal XS.WinForms.Controls.XpertDateTime dtExpiredFrom;
        internal XS.WinForms.Controls.XpertLabel MyLabel48;
        internal XS.WinForms.Controls.XpertDateTime dtExpiredTo;
        internal XS.WinForms.Controls.XSMSPanel Panel25;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer12;
        internal Telerik.WinControls.UI.RadButton btnNotDone;
        internal XS.WinForms.Controls.XpertSplitContainer SplitContainer13;
        internal Telerik.WinControls.UI.RadButton btnDone;
        private Telerik.WinControls.UI.CollapsiblePanelControlsContainer ControlsContainer;
    }
}