using System.Threading.Tasks;

namespace WinFormUI3Tier
{
    partial class XpertSampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private async void InitializeComponent()
        {
            xpertFinder1 = new XS.WinForms.Controls.XpertFinder();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // xpertFinder1
            // 
            xpertFinder1.Calculation_Expression = null;
            xpertFinder1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            xpertFinder1.CalculationExpression = null;
            xpertFinder1.Calculative = false;
            xpertFinder1.Collection_Name = null;
            xpertFinder1.Column_Name = null;
            xpertFinder1.Control_Name = "";
            xpertFinder1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            xpertFinder1.Custom_Data = false;
            xpertFinder1.Custom_Datasource_Logic = false;
            xpertFinder1.Custom_Default = false;
            xpertFinder1.DataSource = null;
            xpertFinder1.Datasource_Assembly = null;
            xpertFinder1.Datasource_Namespace = null;
            xpertFinder1.Datasource_Program = null;
            xpertFinder1.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.None;
            xpertFinder1.DescriptionLabel1 = null;
            xpertFinder1.DescriptionLabel2 = null;
            xpertFinder1.Display_Name = null;
            xpertFinder1.DisplayMember = null;
            xpertFinder1.Enum_Name = null;
            xpertFinder1.Field_Description = null;
            xpertFinder1.Field_Name = null;
            xpertFinder1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            xpertFinder1.FieldCode = null;
            xpertFinder1.FieldDesc = null;
            xpertFinder1.FieldMaxLength = 0;
            xpertFinder1.FieldName = null;
            xpertFinder1.Generated = false;
            xpertFinder1.Is_Grouping = false;
            xpertFinder1.isCalculatedField = false;
            xpertFinder1.IsSourceFromTable = false;
            xpertFinder1.IsSourceFromValueList = false;
            xpertFinder1.IsUnique = false;
            xpertFinder1.Key = false;
            xpertFinder1.Key_Column_Name = null;
            xpertFinder1.Key_Property = null;
            xpertFinder1.Key_Value = null;
            xpertFinder1.Location = new System.Drawing.Point(502, 97);
            xpertFinder1.Mandatory = false;
            xpertFinder1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            xpertFinder1.Max_Length = 0;
            xpertFinder1.Max_Size = 0;
            xpertFinder1.MendatroryField = false;
            xpertFinder1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            xpertFinder1.Min_Length = 0;
            xpertFinder1.Min_Size = 0;
            xpertFinder1.Model_Name = null;
            xpertFinder1.MyFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            xpertFinder1.MyLinkLable1 = null;
            xpertFinder1.MyLinkLable2 = null;
            xpertFinder1.MyReadOnly = false;
            xpertFinder1.MyShowMasterFormButton = true;
            xpertFinder1.MyShowWriteUpButton = true;
            xpertFinder1.Name = "xpertFinder1";
            xpertFinder1.Name_Column_Name = null;
            xpertFinder1.Name_Property = null;
            xpertFinder1.Name_Value = null;
            xpertFinder1.Page_Key_Property = null;
            xpertFinder1.Page_Name_Property = null;
            xpertFinder1.Query_Class_Name = null;
            xpertFinder1.ReferenceFieldDesc = null;
            xpertFinder1.ReferenceFieldName = null;
            xpertFinder1.ReferenceTableName = null;
            xpertFinder1.Required = false;
            xpertFinder1.ShowDataSource = false;
            xpertFinder1.Size = new System.Drawing.Size(227, 22);
            xpertFinder1.SQLMethodName = null;
            xpertFinder1.TabIndex = 0;
            xpertFinder1.Table_Name = null;
            xpertFinder1.Tag_Column_Name = null;
            xpertFinder1.Tag_Property = null;
            xpertFinder1.Validation_Criteria = null;
            xpertFinder1.Value = "";
            xpertFinder1.ValueMember = null;
            xpertFinder1.Visibility_Criteria = null;
            xpertFinder1.Web_Page_Name = null;
            xpertFinder1.Web_Page_Url = null;
            xpertFinder1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            xpertFinder1._MYValidating += xpertFinder1__MYValidating;
            // 
            // XpertSampleForm
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(xpertFinder1);
            CurrentEditorType = "frmRuleEditor";
            ExternalAssemblies.Assemblies = null;
            MaxFieldsListPage = 5;
            Name = "XpertSampleForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private XS.WinForms.Controls.XpertFinder xpertFinder1;
    }
}

