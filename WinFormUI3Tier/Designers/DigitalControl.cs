using System;
// 'created by Monika
using common.OFM;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Xpert.TMS
{

    public partial class DigitalControl
    {

        #region Variables
        private string qry = string.Empty;
        private DateTime cdt = DateAndTime.TimeOfDay;

        private static string _MyTicketNo = string.Empty;
        private static string _MyTaskNo = string.Empty;
        private static string _MyAllocateTo = string.Empty;
        private static bool _MyTimerStart = false;
        #endregion

        #region Property
        public virtual string MyAllocateTo
        {
            get
            {
                return _MyAllocateTo;
            }
            set
            {
                _MyAllocateTo = value;
            }
        }

        public virtual string MyTaskNo
        {
            get
            {
                return _MyTaskNo;
            }
            set
            {
                _MyTaskNo = value;
            }
        }

        public virtual string MyTicketNo
        {
            get
            {
                return _MyTicketNo;
            }
            set
            {
                _MyTicketNo = value;
            }
        }

        public virtual bool MyTimerStart
        {
            get
            {
                return _MyTimerStart;
            }
            set
            {
                _MyTimerStart = value;
                Timer1.Stop();
                if (_MyTimerStart)
                {
                    Timer1.Start();
                }
            }
        }

        public DigitalControl()
        {
            InitializeComponent();
        }
        #endregion

        private void DigitalControl_Load(object sender, EventArgs e)
        {
            GetTimeFromTable();
            Timer1.Stop();
            if (_MyTimerStart)
            {
                Timer1.Start();
            }
        }

        private void GetTimeFromTable()
        {
            string xstring = null;
            try
            {
                // 'get the start time of last ticket if started any
                qry = "Select convert(time,(convert(datetime,'" + clsCommon.GetPrintDate(clsCommon.GETSERVERDATE(), "dd/MMM/yyyy hh:mm tt") + "') - convert(datetime,actual_start_date))) as xtime from tspl_task_time_sheet_new where Activity_Status='Start' and task_allocation_id in " + " (select max(code) from tspl_task_allocation_new where allocate_to='" + _MyAllocateTo + "' ";
                if (clsCommon.myLen(_MyTicketNo) > 0)
                {
                    qry += " and againt_ticket='" + _MyTicketNo + "' ";
                }
                else if (clsCommon.myLen(_MyTaskNo) > 0)
                {
                    qry += " and Against_Activity_Code='" + _MyTaskNo + "' ";
                }
                qry += " ) ";
                xstring = clsCommon.myCstr(clsDBFuncationality.getSingleValue(qry)); // 'it is in minutes

                if (clsCommon.myLen(xstring) > 0)
                {
                    cdt = Conversions.ToDate(xstring);
                }
                lblDigitalClock.Text = Conversions.ToString(cdt);
            }
            catch (Exception ex)
            {
                clsCommon.MyMessageBoxShow(ex.Message);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            cdt = Conversions.ToDate(cdt).AddSeconds(1d);
            lblDigitalClock.Text = Conversions.ToString(cdt);
        }
    }
}