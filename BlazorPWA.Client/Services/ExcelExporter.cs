using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using XpertStudio.Common.Data;
using XpertStudio.Framework.Domain;

namespace BlazorPWA.Client.Services
{
    public static class ExcelService
    {
        //private List<XpertDomainBase> _objList=new List<XpertDomainBase>();
        //public  ExcelService(List<XpertDomainBase> objList)
        //{
        //    _objList=objList;
        //}
        public static byte[] GenerateExcelWorkbook(IEnumerable<XpertDomainBase> objList)
        {

            var stream = new MemoryStream();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");

                // simple way
                workSheet.Cells.LoadFromCollection(objList, true);


                return package.GetAsByteArray();
            }
        }
        public static byte[] GenerateExcelWorkbook(IEnumerable<IFinderData> objList)
        {

            var stream = new MemoryStream();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");

                // simple way
                workSheet.Cells.LoadFromCollection(objList, true);


                return package.GetAsByteArray();
            }
        }
    }
}