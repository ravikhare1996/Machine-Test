namespace WinFormUI3Tier
{
    partial class frmVendorMaster
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendorMaster));
            xpertSplitContainer1 = new XS.WinForms.Controls.XpertSplitContainer();
            gbxHeader = new XS.WinForms.Controls.XpertGroupBox();
            txtDescription = new XS.WinForms.Controls.XpertTextBox();
            lblDescription = new XS.WinForms.Controls.XpertLabel();
            lblDocNo = new XS.WinForms.Controls.XpertLabel();
            txtVendorCode = new XS.WinForms.Controls.XpertNavigator();
            xpertTextEditor1 = new XS.WinForms.Controls.XpertTextEditor();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertSplitContainer1).BeginInit();
            xpertSplitContainer1.Panel1.SuspendLayout();
            xpertSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbxHeader).BeginInit();
            gbxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDocNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertTextEditor1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // xpertSplitContainer1
            // 
            xpertSplitContainer1.Control_Name = "xpertSplitContainer1";
            xpertSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            xpertSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            xpertSplitContainer1.Location = new System.Drawing.Point(0, 0);
            xpertSplitContainer1.Name = "xpertSplitContainer1";
            xpertSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // xpertSplitContainer1.Panel1
            // 
            xpertSplitContainer1.Panel1.Controls.Add(gbxHeader);
            xpertSplitContainer1.Panel2Collapsed = true;
            xpertSplitContainer1.Size = new System.Drawing.Size(663, 235);
            xpertSplitContainer1.SplitterDistance = 117;
            xpertSplitContainer1.TabIndex = 2;
            xpertSplitContainer1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gbxHeader
            // 
            gbxHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            gbxHeader.BorderColor = System.Drawing.Color.Empty;
            gbxHeader.Control_Name = "gbxHeader";
            gbxHeader.Controls.Add(xpertTextEditor1);
            gbxHeader.Controls.Add(txtDescription);
            gbxHeader.Controls.Add(lblDocNo);
            gbxHeader.Controls.Add(txtVendorCode);
            gbxHeader.Controls.Add(lblDescription);
            gbxHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            gbxHeader.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            gbxHeader.HeaderText = "Basic Info";
            gbxHeader.Location = new System.Drawing.Point(0, 0);
            gbxHeader.Name = "gbxHeader";
            gbxHeader.Size = new System.Drawing.Size(663, 235);
            gbxHeader.TabIndex = 0;
            gbxHeader.Text = "Basic Info";
            gbxHeader.Visibility_Criteria = null;
            gbxHeader.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtDescription
            // 
            txtDescription.Calculation_Expression = null;
            txtDescription.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtDescription.CalculationExpression = null;
            txtDescription.Calculative = false;
            txtDescription.Column_Name = "VName";
            txtDescription.Control_Name = "txtDescription";
            txtDescription.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtDescription.Custom_Data = false;
            txtDescription.Custom_Default = false;
            txtDescription.Display_Name = "Vendor Name";
            txtDescription.Field_Description = null;
            txtDescription.Field_Name = "Description";
            txtDescription.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.Description;
            txtDescription.FieldCode = null;
            txtDescription.FieldDesc = null;
            txtDescription.FieldMaxLength = 0;
            txtDescription.FieldName = "Description";
            txtDescription.Generated = false;
            txtDescription.isCalculatedField = false;
            txtDescription.IsSourceFromTable = false;
            txtDescription.IsSourceFromValueList = false;
            txtDescription.IsUnique = false;
            txtDescription.Key = false;
            txtDescription.Location = new System.Drawing.Point(112, 58);
            txtDescription.Max_Length = 0;
            txtDescription.MendatroryField = false;
            txtDescription.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtDescription.Min_Length = 0;
            txtDescription.MyLinkLable1 = lblDescription;
            txtDescription.MyLinkLable2 = null;
            txtDescription.Name = "txtDescription";
            txtDescription.ReferenceFieldDesc = null;
            txtDescription.ReferenceFieldName = "Description";
            txtDescription.ReferenceTableName = null;
            txtDescription.Size = new System.Drawing.Size(412, 20);
            txtDescription.TabIndex = 3;
            txtDescription.Validation_Criteria = null;
            txtDescription.Visibility_Criteria = null;
            txtDescription.XpertDisplayMember = null;
            txtDescription.XpertValueMember = null;
            txtDescription.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblDescription
            // 
            lblDescription.Calculation_Expression = null;
            lblDescription.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblDescription.Calculative = false;
            lblDescription.Column_Name = null;
            lblDescription.Control_Name = "lblDescription";
            lblDescription.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblDescription.Custom_Data = false;
            lblDescription.Custom_Default = false;
            lblDescription.Display_Name = null;
            lblDescription.Field_Description = null;
            lblDescription.Field_Name = null;
            lblDescription.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblDescription.FieldName = null;
            lblDescription.Generated = false;
            lblDescription.Location = new System.Drawing.Point(20, 60);
            lblDescription.MendatroryField = false;
            lblDescription.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(76, 18);
            lblDescription.SourceColumn = null;
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Vendor Name";
            lblDescription.Validation_Criteria = null;
            lblDescription.Visibility_Criteria = null;
            lblDescription.XpertDisplayMember = null;
            lblDescription.XpertValueMember = null;
            lblDescription.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblDocNo
            // 
            lblDocNo.Calculation_Expression = null;
            lblDocNo.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblDocNo.Calculative = false;
            lblDocNo.Column_Name = null;
            lblDocNo.Control_Name = "lblDocNo";
            lblDocNo.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblDocNo.Custom_Data = false;
            lblDocNo.Custom_Default = false;
            lblDocNo.Display_Name = null;
            lblDocNo.Field_Description = null;
            lblDocNo.Field_Name = null;
            lblDocNo.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblDocNo.FieldName = null;
            lblDocNo.Generated = false;
            lblDocNo.Location = new System.Drawing.Point(20, 34);
            lblDocNo.MendatroryField = false;
            lblDocNo.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblDocNo.Name = "lblDocNo";
            lblDocNo.Size = new System.Drawing.Size(72, 18);
            lblDocNo.SourceColumn = null;
            lblDocNo.TabIndex = 1;
            lblDocNo.Text = "Vendor Code";
            lblDocNo.Validation_Criteria = null;
            lblDocNo.Visibility_Criteria = null;
            lblDocNo.XpertDisplayMember = null;
            lblDocNo.XpertValueMember = null;
            lblDocNo.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtVendorCode
            // 
            txtVendorCode.Calculation_Expression = null;
            txtVendorCode.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtVendorCode.Calculative = false;
            txtVendorCode.Column_Name = "VCode";
            txtVendorCode.Control_Name = "txtVendorCode";
            txtVendorCode.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtVendorCode.Custom_Data = false;
            txtVendorCode.Custom_Default = false;
            txtVendorCode.DataSource = null;
            txtVendorCode.Display_Name = "Vendor Code";
            txtVendorCode.DisplayMember = null;
            txtVendorCode.Field_Description = null;
            txtVendorCode.Field_Name = "VCode";
            txtVendorCode.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.ID;
            txtVendorCode.FieldName = "VCode";
            txtVendorCode.Generated = false;
            txtVendorCode.Key = false;
            txtVendorCode.Location = new System.Drawing.Point(112, 28);
            txtVendorCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVendorCode.Max_Length = 30;
            txtVendorCode.Max_Size = 0;
            txtVendorCode.MendatroryField = true;
            txtVendorCode.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtVendorCode.Min_Length = 0;
            txtVendorCode.Min_Size = 0;
            txtVendorCode.MyCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtVendorCode.MyFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtVendorCode.MyLinkLable1 = lblDocNo;
            txtVendorCode.MyLinkLable2 = null;
            txtVendorCode.MyMaxLength = 32767;
            txtVendorCode.MyNewEnable = true;
            txtVendorCode.MyNewPerformClick = false;
            txtVendorCode.MyNewVisible = true;
            txtVendorCode.MyReadOnly = false;
            txtVendorCode.Name = "txtVendorCode";
            txtVendorCode.Required = false;
            txtVendorCode.Size = new System.Drawing.Size(258, 24);
            txtVendorCode.TabIndex = 0;
            txtVendorCode.Validation_Criteria = null;
            txtVendorCode.Value = "";
            txtVendorCode.ValueMember = null;
            txtVendorCode.Visibility_Criteria = null;
            txtVendorCode.XpertDisplayMember = null;
            txtVendorCode.XpertValueMember = null;
            txtVendorCode.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // xpertTextEditor1
            // 
            xpertTextEditor1.Calculation_Expression = null;
            xpertTextEditor1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            xpertTextEditor1.CalculationExpression = null;
            xpertTextEditor1.Calculative = false;
            xpertTextEditor1.Column_Name = null;
            xpertTextEditor1.Control_Name = null;
            xpertTextEditor1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            xpertTextEditor1.Custom_Data = false;
            xpertTextEditor1.Custom_Default = false;
            xpertTextEditor1.Display_Name = null;
            xpertTextEditor1.Field_Description = null;
            xpertTextEditor1.Field_Name = "TextEditor";
            xpertTextEditor1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            xpertTextEditor1.FieldCode = null;
            xpertTextEditor1.FieldDesc = null;
            xpertTextEditor1.FieldMaxLength = 0;
            xpertTextEditor1.FieldName = "TextEditor";
            xpertTextEditor1.Generated = false;
            xpertTextEditor1.isCalculatedField = false;
            xpertTextEditor1.IsSourceFromTable = false;
            xpertTextEditor1.IsSourceFromValueList = false;
            xpertTextEditor1.IsUnique = false;
            xpertTextEditor1.Key = false;
            xpertTextEditor1.Location = new System.Drawing.Point(2, 18);
            xpertTextEditor1.Max_Length = 0;
            xpertTextEditor1.MendatroryField = false;
            xpertTextEditor1.Metadata_Type = null;
            xpertTextEditor1.Min_Length = 0;
            xpertTextEditor1.MyLinkLable1 = null;
            xpertTextEditor1.MyLinkLable2 = null;
            xpertTextEditor1.Name = "xpertTextEditor1";
            xpertTextEditor1.ReferenceFieldDesc = null;
            xpertTextEditor1.ReferenceFieldName = "TextEditor";
            xpertTextEditor1.ReferenceTableName = null;
            xpertTextEditor1.Size = new System.Drawing.Size(659, 176);
            xpertTextEditor1.TabIndex = 4;
            xpertTextEditor1.TabStop = false;
            xpertTextEditor1.Text = "xpertTextEditor1";
            xpertTextEditor1.Validation_Criteria = null;
            xpertTextEditor1.Visibility_Criteria = null;
            xpertTextEditor1.XpertDisplayMember = null;
            xpertTextEditor1.XpertValueMember = null;
            xpertTextEditor1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // frmVendorMaster
            // 
            ApproveCommandVisibility = false;
            AuthPolicy = XpertStudio.Common.Authorization.XsPolicies.AnonymousUser;
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelCommandVisibility = false;
            Class_File_Name = "frmVendorMaster.cs";
            Class_File_Path = "D:\\Official\\R$D\\BlazorTest\\MachineTest\\WinFormUI3Tier\\Setup\\frmVendorMaster.cs";
            Class_Name = "clsVendorMaster";
            ClientSize = new System.Drawing.Size(663, 273);
            Controls.Add(xpertSplitContainer1);
            CreateCommandServiceClass = "clsVendorMasterCreateCommand";
            CurrentEditorType = "frmRuleEditor";
            DataProxyLayerClass = "IclsVendorMasterDataProxy";
            DeleteCommandServiceClass = "clsVendorMasterDeleteCommand";
            Doc_Prefix = "VM";
            DomainLayerClass = "clsVendorMaster";
            DomainRulesClass = "clsVendorMasterRules";
            EnableAddButton = true;
            ExternalAssemblies.Assemblies = (System.Collections.Generic.List<string>)resources.GetObject("resource.Assemblies");
            File_Name = "frmVendorMaster.cs";
            File_Path = "D:\\Official\\XpertGitHubProjects\\MachineTest\\WinFormUI3Tier\\Setup\\frmVendorMaster.cs";
            Form_Name = "frmVendorMaster";
            Form_Type = XpertStudio.Common.Enums.XpertFormTypes.Master;
            Functional_Name = "VendorMaster";
            IServiceLayerClass = "IclsVendorMasterService";
            MaxFieldsListPage = 5;
            ModuleName = "MachineTest";
            Name = "frmVendorMaster";
            PostCommandVisibility = false;
            PrintCommandVisibility = false;
            Program_Code = "VendorMaster";
            Program_Name = "Vendor Master";
            QueryClass = "clsVendorMasterQueries";
            RepositoryLayerClass = "clsVendorMasterRepository";
            ServiceLayerClass = "clsVendorMasterService";
            SubModuleName = "Setup";
            Table_Name = "TSPL_VENDOR_MASTER";
            Text = "frmVendorMaster";
            UpdateCommandServiceClass = "clsVendorMasterUpdateCommand";
            WinFormUILayerClass = "clsVendorMasterWinFormUI";
            Load += XSMasterSimple_Load;
            Controls.SetChildIndex(xpertSplitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            xpertSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xpertSplitContainer1).EndInit();
            xpertSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gbxHeader).EndInit();
            gbxHeader.ResumeLayout(false);
            gbxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDocNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpertTextEditor1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private XS.WinForms.Controls.XpertSplitContainer xpertSplitContainer1;
        private XS.WinForms.Controls.XpertGroupBox gbxHeader;
        private XS.WinForms.Controls.XpertLabel lblDocNo;
        private XS.WinForms.Controls.XpertNavigator txtVendorCode;
        private XS.WinForms.Controls.XpertTextBox txtDescription;
        private XS.WinForms.Controls.XpertLabel lblDescription;
        private XS.WinForms.Controls.XpertTextEditor xpertTextEditor1;
    }
}