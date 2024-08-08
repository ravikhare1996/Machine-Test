using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertStudio.Framework.Domain;
using XpertStudio.Framework;
using XpertStudio.Framework.Attributes;
using Microsoft.EntityFrameworkCore;
using XpertStudio.Common.Attributes;
using XpertStudio.Common.Enums;
using System.Globalization;

namespace MachineTest.Domain.Entities
{
    
    public partial class clsPurchaseOrder : XpertDomainBase
    {
        
        //[GroupName("Photograph")]
        //public byte[]? filePhoto
        //{
        //    get { return  _filePhoto; }
        //    set { _filePhoto=value; }
        //}

        //[Column("filePhoto_FilePath", TypeName ="VARCHAR")]
        //[DisplayName(" File Path")]
        //[GroupName("Photograph")]
        //public string? filePhoto_FilePath
        //{
        //    get { return  _filePhoto_FilePath; }
        //    set { _filePhoto_FilePath=value; }
        //}

        //[Column("filePhoto_FileName", TypeName ="VARCHAR")]
        //[GroupName("Photograph")]
        //public string? filePhoto_FileName
        //{
        //    get { return  _filePhoto_FileName; }
        //    set { _filePhoto_FileName=value; }
        //}

        //[Column("filePhoto_ContentType", TypeName ="VARCHAR")]
        //[DisplayName(" Content Type")]
        //[GroupName("Photograph")]
        //public string? filePhoto_ContentType
        //{
        //    get { return  _filePhoto_ContentType; }
        //    set { _filePhoto_ContentType=value; }
        //}

        
        //[XSCodeType(Type = XSCodeType.Custom)]
        //[GroupName("Photograph")]
        //[Column("File_Content")]
        //public byte[]? Emp_Photo
        //{
        //    get { return  _Emp_Photo; }
        //    set { _Emp_Photo=value; }
        //}



        //[XSCodeType(Type = XSCodeType.Custom)]
        //[Column("Emp_Photo_FilePath", TypeName ="VARCHAR")]
        //[DisplayName("Photo File Path")]
        //[GroupName("Photograph")]
        //[NotMapped]
        //public string? Emp_Photo_FilePath
        //{
        //    get { return  _Emp_Photo_FilePath; }
        //    set { _Emp_Photo_FilePath=value; }
        //}



        //[XSCodeType(Type=XSCodeType.Custom)]
        //[Column("File_Name", TypeName ="VARCHAR")]
        //[GroupName("Photograph")]        
        //public string? Emp_Photo_FileName
        //{
        //    get { return  _Emp_Photo_FileName; }
        //    set { _Emp_Photo_FileName=value; }
        //}



        //[XSCodeType(Type = XSCodeType.Custom)]
        //[Column("Conytent_Type", TypeName ="VARCHAR")]
        //[DisplayName(" Content Type")]
        //[GroupName("Photograph")]
        //public string? Emp_Photo_ContentType
        //{
        //    get { return  _Emp_Photo_ContentType; }
        //    set { _Emp_Photo_ContentType=value; }
        //}


        //[NotMapped]
        //[XSCodeType(Type = XSCodeType.Custom)]
        //public override DateTime? CreatedDatetime 
        //{
        //    get { return _CreateDate; }
        //    set 
        //    { 
        //        base.CreatedDatetime = value;
        //        _CreateDate = value;
        //    }
        //}


        //[NotMapped]        
        //[XSCodeType(Type = XSCodeType.Custom)]
        //public override DateTime? LastModifiedDatetime
        //{
        //    get { return _ModifiyDate; }
        //    set 
        //    { 
        //        base.LastModifiedDatetime = value;
        //        _ModifiyDate = value;
        //    }
        //}


    }
}
