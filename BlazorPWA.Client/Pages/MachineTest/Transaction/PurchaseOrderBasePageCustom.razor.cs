using BlazorPWA.Shared.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Functions;
using System.Data;
using BlazorPWA.Shared.VMs;
using Microsoft.JSInterop;
using System.Globalization;

namespace BlazorPWA.Client.Pages.MachineTest.Transaction
{
    //Test
    public partial class PurchaseOrderBasePage
    {
        private async Task GetCreateDateAsync(EventArgs e)
        {
            try
            {
                string sql = "select CreateDate from TSPL_PO where POCode='" + Model.ID + "'";
                var strDate = XpertCommonFunctions.myCDate((await (Manager as PurchaseOrderManager).getSingleValue<DateTime?>(sql)));
                // Now parse the string to DateTime
                //strDate = strDate.Trim('"', ' ');

                //// Define the expected date formats
                //string[] formats = { "yyyy-MM-ddTHH:mm:ss.fff", "yyyy-MM-dd" };
                ////string format = "yyyy-MM-dd HH:mm:ss.fff";

                //if (DateTime.TryParseExact(strDate, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTimeValue))
                //{
                //    Model.CreateDate = dateTimeValue;
                //}
                //else
                //{
                //    throw new Exception("Invalid date format received.");
                //}
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
