namespace WinFormUI3Tier
{
    partial class frmItemMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemMaster));
            xpertSplitContainer1 = new XS.WinForms.Controls.XpertSplitContainer();
            gbxHeader = new XS.WinForms.Controls.XpertGroupBox();
            txtUom = new XS.WinForms.Controls.XpertTextBox();
            lblUom = new XS.WinForms.Controls.XpertLabel();
            txtRate = new XS.WinForms.Controls.XpertNumberBox();
            lblRate = new XS.WinForms.Controls.XpertLabel();
            txtDescription = new XS.WinForms.Controls.XpertTextBox();
            lblDescription = new XS.WinForms.Controls.XpertLabel();
            lblDocNo = new XS.WinForms.Controls.XpertLabel();
            txtItemCode = new XS.WinForms.Controls.XpertNavigator();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertSplitContainer1).BeginInit();
            xpertSplitContainer1.Panel1.SuspendLayout();
            xpertSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbxHeader).BeginInit();
            gbxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblUom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDocNo).BeginInit();
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
            xpertSplitContainer1.Size = new System.Drawing.Size(727, 332);
            xpertSplitContainer1.SplitterDistance = 117;
            xpertSplitContainer1.TabIndex = 2;
            xpertSplitContainer1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gbxHeader
            // 
            gbxHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            gbxHeader.BorderColor = System.Drawing.Color.Empty;
            gbxHeader.Control_Name = "gbxHeader";
            gbxHeader.Controls.Add(txtUom);
            gbxHeader.Controls.Add(lblUom);
            gbxHeader.Controls.Add(txtRate);
            gbxHeader.Controls.Add(lblRate);
            gbxHeader.Controls.Add(txtDescription);
            gbxHeader.Controls.Add(lblDocNo);
            gbxHeader.Controls.Add(txtItemCode);
            gbxHeader.Controls.Add(lblDescription);
            gbxHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            gbxHeader.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            gbxHeader.HeaderText = "Basic Info";
            gbxHeader.Location = new System.Drawing.Point(0, 0);
            gbxHeader.Name = "gbxHeader";
            gbxHeader.Size = new System.Drawing.Size(727, 332);
            gbxHeader.TabIndex = 0;
            gbxHeader.Text = "Basic Info";
            gbxHeader.Visibility_Criteria = null;
            gbxHeader.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtUom
            // 
            txtUom.Calculation_Expression = null;
            txtUom.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtUom.CalculationExpression = null;
            txtUom.Calculative = false;
            txtUom.Column_Name = "IUom";
            txtUom.Control_Name = "txtUom";
            txtUom.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtUom.Custom_Data = false;
            txtUom.Custom_Default = false;
            txtUom.Display_Name = "UOM";
            txtUom.Field_Description = null;
            txtUom.Field_Name = "Uom";
            txtUom.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtUom.FieldCode = null;
            txtUom.FieldDesc = null;
            txtUom.FieldMaxLength = 0;
            txtUom.FieldName = "Uom";
            txtUom.Generated = false;
            txtUom.isCalculatedField = false;
            txtUom.IsSourceFromTable = false;
            txtUom.IsSourceFromValueList = false;
            txtUom.IsUnique = false;
            txtUom.Key = false;
            txtUom.Location = new System.Drawing.Point(112, 110);
            txtUom.Max_Length = 0;
            txtUom.MendatroryField = false;
            txtUom.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtUom.Min_Length = 0;
            txtUom.MyLinkLable1 = lblUom;
            txtUom.MyLinkLable2 = null;
            txtUom.Name = "txtUom";
            txtUom.ReferenceFieldDesc = null;
            txtUom.ReferenceFieldName = "Uom";
            txtUom.ReferenceTableName = null;
            txtUom.Size = new System.Drawing.Size(178, 20);
            txtUom.TabIndex = 7;
            txtUom.Validation_Criteria = null;
            txtUom.Visibility_Criteria = null;
            txtUom.XpertDisplayMember = null;
            txtUom.XpertValueMember = null;
            txtUom.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblUom
            // 
            lblUom.Calculation_Expression = null;
            lblUom.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblUom.Calculative = false;
            lblUom.Column_Name = null;
            lblUom.Control_Name = "lblUom";
            lblUom.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblUom.Custom_Data = false;
            lblUom.Custom_Default = false;
            lblUom.Display_Name = null;
            lblUom.Field_Description = null;
            lblUom.Field_Name = null;
            lblUom.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblUom.FieldName = null;
            lblUom.Generated = false;
            lblUom.Location = new System.Drawing.Point(20, 108);
            lblUom.MendatroryField = false;
            lblUom.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblUom.Name = "lblUom";
            lblUom.Size = new System.Drawing.Size(33, 18);
            lblUom.SourceColumn = null;
            lblUom.TabIndex = 6;
            lblUom.Text = "UOM";
            lblUom.Validation_Criteria = null;
            lblUom.Visibility_Criteria = null;
            lblUom.XpertDisplayMember = null;
            lblUom.XpertValueMember = null;
            lblUom.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtRate
            // 
            txtRate.Aggregate_Field = null;
            txtRate.Aggregate_Type = null;
            txtRate.Calculation_Expression = null;
            txtRate.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtRate.CalculationExpression = null;
            txtRate.Calculative = false;
            txtRate.Column_Name = "IRate";
            txtRate.Control_Name = "txtRate";
            txtRate.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtRate.Custom_Data = false;
            txtRate.Custom_Default = false;
            txtRate.DecimalPlaces = 0;
            txtRate.Display_Name = "Rate";
            txtRate.ExpressionContainer = null;
            txtRate.ExpressionGrid = null;
            txtRate.Field_Description = null;
            txtRate.Field_Name = "Rate";
            txtRate.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtRate.FieldCode = null;
            txtRate.FieldDesc = null;
            txtRate.FieldMaxLength = 0;
            txtRate.FieldName = "Rate";
            txtRate.Generated = false;
            txtRate.isCalculatedField = false;
            txtRate.IsSourceFromTable = false;
            txtRate.IsSourceFromValueList = false;
            txtRate.IsUnique = false;
            txtRate.Key = false;
            txtRate.Location = new System.Drawing.Point(112, 84);
            txtRate.MandatoryField = false;
            txtRate.Max_Length = 0;
            txtRate.MendatroryField = false;
            txtRate.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtRate.Min_Length = 0;
            txtRate.MyLinkLable1 = lblRate;
            txtRate.MyLinkLable2 = null;
            txtRate.Name = "txtRate";
            txtRate.Number_Type = XpertStudio.Common.Enums.XpertNumberTypes.Decimal;
            txtRate.ReferenceFieldDesc = null;
            txtRate.ReferenceFieldName = "Rate";
            txtRate.ReferenceTableName = null;
            txtRate.Size = new System.Drawing.Size(178, 20);
            txtRate.TabIndex = 5;
            txtRate.Text = "0";
            txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtRate.Validation_Criteria = null;
            txtRate.Value = 0D;
            txtRate.Visibility_Criteria = null;
            txtRate.XpertDisplayMember = null;
            txtRate.XpertValueMember = null;
            txtRate.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblRate
            // 
            lblRate.Calculation_Expression = null;
            lblRate.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblRate.Calculative = false;
            lblRate.Column_Name = null;
            lblRate.Control_Name = "lblRate";
            lblRate.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblRate.Custom_Data = false;
            lblRate.Custom_Default = false;
            lblRate.Display_Name = null;
            lblRate.Field_Description = null;
            lblRate.Field_Name = null;
            lblRate.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblRate.FieldName = null;
            lblRate.Generated = false;
            lblRate.Location = new System.Drawing.Point(20, 84);
            lblRate.MendatroryField = false;
            lblRate.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblRate.Name = "lblRate";
            lblRate.Size = new System.Drawing.Size(28, 18);
            lblRate.SourceColumn = null;
            lblRate.TabIndex = 4;
            lblRate.Text = "Rate";
            lblRate.Validation_Criteria = null;
            lblRate.Visibility_Criteria = null;
            lblRate.XpertDisplayMember = null;
            lblRate.XpertValueMember = null;
            lblRate.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtDescription
            // 
            txtDescription.Calculation_Expression = null;
            txtDescription.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtDescription.CalculationExpression = null;
            txtDescription.Calculative = false;
            txtDescription.Column_Name = "IName";
            txtDescription.Control_Name = "txtDescription";
            txtDescription.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtDescription.Custom_Data = false;
            txtDescription.Custom_Default = false;
            txtDescription.Display_Name = "Item Name";
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
            lblDescription.Size = new System.Drawing.Size(62, 18);
            lblDescription.SourceColumn = null;
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Item Name";
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
            lblDocNo.Size = new System.Drawing.Size(58, 18);
            lblDocNo.SourceColumn = null;
            lblDocNo.TabIndex = 1;
            lblDocNo.Text = "Item Code";
            lblDocNo.Validation_Criteria = null;
            lblDocNo.Visibility_Criteria = null;
            lblDocNo.XpertDisplayMember = null;
            lblDocNo.XpertValueMember = null;
            lblDocNo.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtItemCode
            // 
            txtItemCode.Calculation_Expression = null;
            txtItemCode.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtItemCode.Calculative = false;
            txtItemCode.Column_Name = "ICode";
            txtItemCode.Control_Name = "txtItemCode";
            txtItemCode.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtItemCode.Custom_Data = false;
            txtItemCode.Custom_Default = false;
            txtItemCode.DataSource = null;
            txtItemCode.Display_Name = "Item Code";
            txtItemCode.DisplayMember = null;
            txtItemCode.Field_Description = null;
            txtItemCode.Field_Name = "ID";
            txtItemCode.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.ID;
            txtItemCode.FieldName = "ID";
            txtItemCode.Generated = false;
            txtItemCode.Key = false;
            txtItemCode.Location = new System.Drawing.Point(112, 28);
            txtItemCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtItemCode.Max_Length = 30;
            txtItemCode.Max_Size = 0;
            txtItemCode.MendatroryField = true;
            txtItemCode.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtItemCode.Min_Length = 0;
            txtItemCode.Min_Size = 0;
            txtItemCode.MyCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtItemCode.MyFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtItemCode.MyLinkLable1 = lblDocNo;
            txtItemCode.MyLinkLable2 = null;
            txtItemCode.MyMaxLength = 32767;
            txtItemCode.MyNewEnable = true;
            txtItemCode.MyNewPerformClick = false;
            txtItemCode.MyNewVisible = true;
            txtItemCode.MyReadOnly = false;
            txtItemCode.Name = "txtItemCode";
            txtItemCode.Required = false;
            txtItemCode.Size = new System.Drawing.Size(258, 24);
            txtItemCode.TabIndex = 0;
            txtItemCode.Validation_Criteria = null;
            txtItemCode.Value = "";
            txtItemCode.ValueMember = null;
            txtItemCode.Visibility_Criteria = null;
            txtItemCode.XpertDisplayMember = null;
            txtItemCode.XpertValueMember = null;
            txtItemCode.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // frmItemMaster
            // 
            ApproveCommandVisibility = false;
            AuthPolicy = XpertStudio.Common.Authorization.XsPolicies.AnonymousUser;
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelCommandVisibility = false;
            Class_File_Name = "frmItemMaster.cs";
            Class_File_Path = "D:\\Official\\R$D\\BlazorTest\\MachineTest\\WinFormUI3Tier\\Setup\\frmItemMaster.cs";
            Class_Name = "clsItemMaster";
            ClientSize = new System.Drawing.Size(727, 370);
            Controls.Add(xpertSplitContainer1);
            CreateCommandServiceClass = "clsItemMasterCreateCommand";
            CurrentEditorType = "frmRuleEditor";
            DataProxyLayerClass = "IclsItemMasterDataProxy";
            DeleteCommandServiceClass = "clsItemMasterDeleteCommand";
            Doc_Prefix = "IM";
            DomainLayerClass = "clsItemMaster";
            DomainRulesClass = "clsItemMasterRules";
            EnableAddButton = true;
            ExternalAssemblies.Assemblies = (System.Collections.Generic.List<string>)resources.GetObject("resource.Assemblies");
            File_Path = "D:\\Official\\Testing\\MachineTest\\MachineTest\\WinFormUI3Tier\\Setup\\frmItemMaster.cs";
            Form_Name = "frmItemMaster";
            Form_Type = XpertStudio.Common.Enums.XpertFormTypes.Master;
            Functional_Name = "ItemMaster";
            IServiceLayerClass = "IclsItemMasterService";
            MaxFieldsListPage = 5;
            ModuleName = "MachineTest";
            Name = "frmItemMaster";
            PostCommandVisibility = false;
            PrintCommandVisibility = false;
            Program_Code = "ItemMaster";
            Program_Name = "Item Master";
            QueryClass = "clsItemMasterQueries";
            RepositoryLayerClass = "clsItemMasterRepository";
            ServiceLayerClass = "clsItemMasterService";
            SubModuleName = "Setup";
            Table_Name = "TSPL_ITEM_MASTER";
            Text = "frmItemMaster";
            UpdateCommandServiceClass = "clsItemMasterUpdateCommand";
            WinFormUILayerClass = "clsItemMasterWinFormUI";
            Load += XSMasterSimple_Load;
            Controls.SetChildIndex(xpertSplitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            xpertSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xpertSplitContainer1).EndInit();
            xpertSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gbxHeader).EndInit();
            gbxHeader.ResumeLayout(false);
            gbxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtUom).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblUom).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDocNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private XS.WinForms.Controls.XpertSplitContainer xpertSplitContainer1;
        private XS.WinForms.Controls.XpertGroupBox gbxHeader;
        private XS.WinForms.Controls.XpertLabel lblDocNo;
        private XS.WinForms.Controls.XpertNavigator txtItemCode;
        private XS.WinForms.Controls.XpertTextBox txtDescription;
        private XS.WinForms.Controls.XpertLabel lblDescription;
        private XS.WinForms.Controls.XpertLabel lblRate;
        private XS.WinForms.Controls.XpertNumberBox txtRate;
        private XS.WinForms.Controls.XpertTextBox txtUom;
        private XS.WinForms.Controls.XpertLabel lblUom;
    }
}