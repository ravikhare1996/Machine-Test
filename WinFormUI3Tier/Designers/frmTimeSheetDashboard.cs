using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using common.OFM;
using CommonServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

using Telerik.WinControls;
using Telerik.WinControls.UI; 
using XS.WinForms.Controls;

namespace Xpert.TMS
{


    public partial class frmTimeSheetDashboard : FrmMainTranScreen
    {
        #region variables
        public string strStatus;
        public decimal RescheduleTime;
        private bool is_Form_Loaded = false;
        private DateTime? Default_TS_Date = default;
        private int GridCurrentIndex = 0;
        private int GridCurrentIndex_KRA = 0;
        public string strDoc_Type_List = null;
        public string strUserStatus = "";
        public string strUserReason = "";
        public string strUserRemarks = "";
        private bool IsOk = false;
        //private string strMainFormID = clsUserMgtCode.frmMyTimeSheet;
        private decimal StdDuration = 0m;
        private string qry = string.Empty;
        private DataTable dt = new DataTable();
        private decimal TotalWorkingTime;
        private decimal TotalWorkingDays;
        private DateTime? strFromDate = default;
        private DateTime? strToDate = default;
        private DateTime firstDayOfMonth = default;
        private DateTime lastDayOfMonth = default;

        public string CategoryType = "";
        public string CategoryagainstTicket = "";
        public string Categoryagainststage = "";

        // '================Variables for repeated time while filling timesheet
        private string strRpet_TSCode = string.Empty;
        private string strRpet_AlcCode = string.Empty;
        private string strRpet_TicketNo = string.Empty;
        private string strRpet_ActivityCode = string.Empty;
        private string strRpet_TaskID = string.Empty;
        private bool strRpet_TS = false;
        // '================End Here
        public bool TimeFunctionSetup = false;

        private DataTable cdt1 = new DataTable();
        private DataTable cdt2 = new DataTable();
        private DataTable cdt3 = new DataTable();
        private DataTable cdt4 = new DataTable();


        private bool isInsideLoadData = false;
        private bool isCellValueChanged = false;

        // '================approval grid=========================
        private const string colSendBy = "colSendBy";

        // '==============================================================================
        private const string colSelect = "Select"; // 'use icon
        private const string colType = "colType"; // 'ticket,Gap,Checklist
        private const string colCode = "Code"; // 'timesheetcode
        private const string colTicketCode = "colTicketCode";
        private const string colAllocationID = "colAllocationID";
        private const string colUserPriority = "colUserPriority";
        private const string colPriority = "colPriority";
        private const string colClientPriority = "colClientPriority";
        private const string colClientCode = "ClientCode";
        private const string colClientName = "ClientName";
        private const string colProjectCode = "colProjectCode";
        private const string colHeadKPI = "colHeadKPI";
        private const string colHeadKPIName = "colHeadKPIName";
        private const string colSiteName = "colSiteName";
        private const string colProjectName = "colProjectName";
        private const string colTicketNo = "TicketNo";
        private const string colTaskNo = "TaskNo";
        private const string colTicketDesc = "Descrptn";
        private const string colTask_Id = "colTask_Id";
        private const string colStatus = "Status";
        private const string colAction = "colAction";
        private const string colActionRemarks = "colActionRemarks";
        private const string colActionTicket = "colActionTicket";
        private const string colActionYes = "colActionYes";
        private const string colActioncancel = "colActioncancel";
        private const string colActionNo = "colActionNo";
        private const string colStatusRemark = "colStatusRemark";
        private const string colEstimateHours = "EstimateHours";
        private const string colAcceptHr = "colAcceptHr";
        private const string colTotalTakenHour = "colTotalTakenHour";
        private const string colStartDate = "StartDate";
        private const string colEndDate = "EndDate";
        private const string colHours = "colHours";
        private const string colAutoStartDate = "colAutoStartDate";
        private const string colAutoEndDate = "colAutoEndDate";
        private const string colAutoHours = "ColAutoHours";
        private const string colRemark = "colRemark";
        private const string colTableUsed = "colTableUsed";
        private const string colPendingRemark = "colPendingRemark";
        private const string colDelayReason = "delayreason";
        private const string colShiftReason = "ShiftReason";
        private const string colBugResponsiblePerson = "colBugResponsiblePerson";
        private const string colBugReason = "colBugReason";
        private const string colKPICode = "colKPICode";
        private const string colDepartment = "colDepartment";
        private const string colVersion = "colVersion";
        private const string colTimeSheetFlag = "colTimeSheetFlag"; // 'start,stop,pause,resume,shift
        private const string colTicketType = "colTicketType";

        private const string colPauseType = "colPauseType";
        private const string colPauseStartDate = "colPauseStartDate";
        private const string colPauseEndDate = "colPauseEndDate";
        private const string colPauseAutoStartDate = "colPauseAutoStartDate";
        private const string colPauseAutoEndDate = "colPauseAutoEndDate";
        private const string colPauseStatus = "colPauseStatus";
        private const string colPauseRemark = "colPauseRemark";
        private const string colPauseTTCode = "colPauseTTCode";
        private const string colSendToApp = "colSendToApp";
        private const string colKRAName = "colKRAName";
        private const string colRepeatCode = "colRepeatCode";
        private const string colExtraHours = "colExtraHours";
        private const string colCreateSubTicket = "colCreateSubTicket";
        private const string colSubTicketDesc = "colSubTicketDesc";

        private const string colCreateSubActivity = "colCreateSubActivity";
        private const string colSubActivityDesc = "colSubActivityDesc";

        // ' read only columns
        private const string colSet_Default = "colSet_Default";
        private const string colAttach_Ref_Docs = "colAttach_Ref_Docs";
        private const string colRef_Doc_Saample = "colRef_Doc_Saample";
        private const string colMake_Editable = "colMake_Editable";
        private const string colAgainst_Screen = "colAgainst_Screen";
        private const string colSeq_Name = "colSeq_Name";
        private const string colScreenSeq = "colScreenSeq";
        private const string colScreenName = "colScreenName";
        private const string colPriority_SEQ_Type = "colPriority_SEQ_Type";
        private const string colPriorityName = "colPriorityName";
        private const string colSeq_No = "colSeq_No";
        private const string colKPINature = "colKPINature";
        private const string colKPINatureType = "colKPINatureType";
        private const string colSeverity = "Severity";
        // ' load data Responsibiltity
        private const string colFormatName = "colFormatName";
        private const string colFormat = "colFormat";
        private const string colFormatType = "colFormatType";
        private const string colDocType = "colDocType";
        private const string colDocNo = "colDocNo";
        private const string colDescription = "colDescription";
        private const string colKPIDesignation = "colKPIDesignation";
        private const string colDesign_User_Type = "colDesign_User_Type";
        private const string colFormatUser = "colFormatUser";
        private const string coldepartmentCode = "coldepartmentCode";
        private const string coldepartmentName = "coldepartmentName";
        private const string colDocDate = "colDocDate";
        private const string colDocCount = "colDocCount";

        // ' end

        private const string colSubjectCode = "colSubjectCode";
        private const string colSubjectName = "colSubjectName";

        // '==============================================================================

        // '=======================================================
        private RadContextMenu cntmenu = new RadContextMenu();
        private RadMenuItem menuItem_Start = new RadMenuItem("Start");
        private RadMenuItem menuItem_Pause = new RadMenuItem("Pause");
        private RadMenuItem menuItem_Resume = new RadMenuItem("Resume");
        private RadMenuItem menuItem_Shift = new RadMenuItem("Shift");
        private RadMenuItem menuItem_Stop = new RadMenuItem("Stop");
        private RadMenuItem menuItem_Allc = new RadMenuItem("Activity Detail");
        private RadMenuItem menuItem_Clar = new RadMenuItem("Required Clarification");
        private RadMenuItem menuItem_Meeting = new RadMenuItem("Required Meeting");
        private RadMenuItem menuItem_Discurssion = new RadMenuItem("Required Discurssion");
        private RadMenuItem menuItem_Pending = new RadMenuItem("Pending");
        private RadContextMenu cntmenu_KRA = new RadContextMenu();
        private RadMenuItem menuItem_PriorityChange = new RadMenuItem("Change Priority");
        private RadMenuItem menuItemFillDetails = new RadMenuItem("Fill Details");
        private RadMenuItem menuItemCancel = new RadMenuItem("Cancel");
        private RadMenuItem menuItemReject = new RadMenuItem("Reject");
        private RadMenuItem menuItemOnHold = new RadMenuItem("Self Hold");
        private RadMenuItem menuItemOnHoldtoOther = new RadMenuItem("Hold due to others");
        private RadMenuItem menuItemRevert = new RadMenuItem("Revert");

        // '==============================================================
        #endregion

        public frmTimeSheetDashboard(string FormID)
        {

            // This call is required by the designer.   
            InitializeComponent();
            //strMainFormID = FormID;
            // Add any initialization after the InitializeComponent() call.
        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}