namespace WinFormUI3Tier
{
    partial class frmUserMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMaster));
            xpertSplitContainer1 = new XS.WinForms.Controls.XpertSplitContainer();
            gbxHeader = new XS.WinForms.Controls.XpertGroupBox();
            gbxAttachPan = new XS.WinForms.Controls.XpertGroupBox();
            filePanCard = new XS.WinForms.Controls.XpertFileUpload();
            xpertGroupBox2 = new XS.WinForms.Controls.XpertGroupBox();
            txtEmail = new XS.WinForms.Controls.XpertTextBox();
            xpertLabel1 = new XS.WinForms.Controls.XpertLabel();
            txtPhone = new XS.WinForms.Controls.XpertTextBox();
            xpertLabel2 = new XS.WinForms.Controls.XpertLabel();
            lblLevel = new XS.WinForms.Controls.XpertLabel();
            ddlLevel = new XS.WinForms.Controls.XpertDropDown();
            Password = new XS.WinForms.Controls.XpertLabel();
            txtPassword = new XS.WinForms.Controls.XpertTextBox();
            xpertLabel3 = new XS.WinForms.Controls.XpertLabel();
            fndClient = new XS.WinForms.Controls.XpertFinder();
            txtUserName = new XS.WinForms.Controls.XpertTextBox();
            lblUserName = new XS.WinForms.Controls.XpertLabel();
            lblDocNo = new XS.WinForms.Controls.XpertLabel();
            fndUserCode = new XS.WinForms.Controls.XpertNavigator();
            xpertPageView1 = new XS.WinForms.Controls.XpertPageView();
            Page1 = new Telerik.WinControls.UI.RadPageViewPage();
            Page2 = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertSplitContainer1).BeginInit();
            xpertSplitContainer1.Panel1.SuspendLayout();
            xpertSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbxHeader).BeginInit();
            gbxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gbxAttachPan).BeginInit();
            gbxAttachPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xpertGroupBox2).BeginInit();
            xpertGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblUserName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblDocNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpertPageView1).BeginInit();
            xpertPageView1.SuspendLayout();
            Page1.SuspendLayout();
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
            xpertSplitContainer1.Size = new System.Drawing.Size(884, 365);
            xpertSplitContainer1.SplitterDistance = 117;
            xpertSplitContainer1.TabIndex = 2;
            xpertSplitContainer1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gbxHeader
            // 
            gbxHeader.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            gbxHeader.BackColor = System.Drawing.Color.FromArgb(191, 219, 255);
            gbxHeader.BorderColor = System.Drawing.Color.Empty;
            gbxHeader.Control_Name = "gbxHeader";
            gbxHeader.Controls.Add(gbxAttachPan);
            gbxHeader.Controls.Add(xpertGroupBox2);
            gbxHeader.Controls.Add(lblLevel);
            gbxHeader.Controls.Add(ddlLevel);
            gbxHeader.Controls.Add(Password);
            gbxHeader.Controls.Add(txtPassword);
            gbxHeader.Controls.Add(xpertLabel3);
            gbxHeader.Controls.Add(fndClient);
            gbxHeader.Controls.Add(txtUserName);
            gbxHeader.Controls.Add(lblDocNo);
            gbxHeader.Controls.Add(fndUserCode);
            gbxHeader.Controls.Add(lblUserName);
            gbxHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            gbxHeader.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            gbxHeader.HeaderText = "Basic Info";
            gbxHeader.Location = new System.Drawing.Point(0, 0);
            gbxHeader.Name = "gbxHeader";
            gbxHeader.Size = new System.Drawing.Size(884, 365);
            gbxHeader.TabIndex = 0;
            gbxHeader.Text = "Basic Info";
            gbxHeader.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gbxAttachPan
            // 
            gbxAttachPan.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            gbxAttachPan.BorderColor = System.Drawing.Color.Empty;
            gbxAttachPan.Control_Name = "gbxAttachPan";
            gbxAttachPan.Controls.Add(filePanCard);
            gbxAttachPan.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            gbxAttachPan.HeaderText = "Attach PanCard";
            gbxAttachPan.Location = new System.Drawing.Point(29, 293);
            gbxAttachPan.Name = "gbxAttachPan";
            gbxAttachPan.Size = new System.Drawing.Size(206, 66);
            gbxAttachPan.TabIndex = 2;
            gbxAttachPan.Text = "Attach PanCard";
            gbxAttachPan.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // filePanCard
            // 
            filePanCard.Calculation_Expression = null;
            filePanCard.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            filePanCard.Calculative = false;
            filePanCard.Column_Name = null;
            filePanCard.Command_Type = XpertStudio.Common.Enums.XpertCommandTypes.Upload;
            filePanCard.Control_Name = "filePanCard";
            filePanCard.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            filePanCard.Custom_Data = false;
            filePanCard.Custom_Default = false;
            filePanCard.CustomAction = false;
            filePanCard.Display_Name = "Pancard";
            filePanCard.Field_Description = "PanCard";
            filePanCard.Field_Name = "PanCard";
            filePanCard.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            filePanCard.Generated = false;
            filePanCard.Location = new System.Drawing.Point(28, 30);
            filePanCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            filePanCard.MaximumSize = new System.Drawing.Size(23, 23);
            filePanCard.MaxSize = 10;
            filePanCard.MendatroryField = false;
            filePanCard.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            filePanCard.MinimumSize = new System.Drawing.Size(23, 23);
            filePanCard.MyPerformClick = false;
            filePanCard.Name = "filePanCard";
            filePanCard.Size = new System.Drawing.Size(23, 23);
            filePanCard.TabIndex = 18;
            filePanCard.Url = null;
            filePanCard.XpertDisplayMember = null;
            filePanCard.XpertValueMember = null;
            filePanCard.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // xpertGroupBox2
            // 
            xpertGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            xpertGroupBox2.BorderColor = System.Drawing.Color.Empty;
            xpertGroupBox2.Control_Name = "xpertGroupBox2";
            xpertGroupBox2.Controls.Add(txtEmail);
            xpertGroupBox2.Controls.Add(xpertLabel1);
            xpertGroupBox2.Controls.Add(txtPhone);
            xpertGroupBox2.Controls.Add(xpertLabel2);
            xpertGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            xpertGroupBox2.HeaderText = "Contacts";
            xpertGroupBox2.Location = new System.Drawing.Point(29, 142);
            xpertGroupBox2.Name = "xpertGroupBox2";
            xpertGroupBox2.Size = new System.Drawing.Size(485, 145);
            xpertGroupBox2.TabIndex = 2;
            xpertGroupBox2.Text = "Contacts";
            xpertGroupBox2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtEmail
            // 
            txtEmail.Calculation_Expression = null;
            txtEmail.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtEmail.CalculationExpression = null;
            txtEmail.Calculative = false;
            txtEmail.Column_Name = "E_mail";
            txtEmail.Control_Name = "txtEmail";
            txtEmail.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtEmail.Custom_Data = false;
            txtEmail.Custom_Default = false;
            txtEmail.Display_Name = "Email";
            txtEmail.Field_Description = null;
            txtEmail.Field_Name = "E_mail";
            txtEmail.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtEmail.FieldCode = null;
            txtEmail.FieldDesc = null;
            txtEmail.FieldMaxLength = 0;
            txtEmail.FieldName = "E_mail";
            txtEmail.Generated = false;
            txtEmail.isCalculatedField = false;
            txtEmail.IsSourceFromTable = false;
            txtEmail.IsSourceFromValueList = false;
            txtEmail.IsUnique = false;
            txtEmail.Key = false;
            txtEmail.Location = new System.Drawing.Point(61, 36);
            txtEmail.Max_Length = 0;
            txtEmail.MendatroryField = false;
            txtEmail.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtEmail.Min_Length = 0;
            txtEmail.MyLinkLable1 = xpertLabel1;
            txtEmail.MyLinkLable2 = null;
            txtEmail.Name = "txtEmail";
            txtEmail.ReferenceFieldDesc = null;
            txtEmail.ReferenceFieldName = "E_mail";
            txtEmail.ReferenceTableName = null;
            txtEmail.Size = new System.Drawing.Size(412, 20);
            txtEmail.TabIndex = 13;
            txtEmail.XpertDisplayMember = null;
            txtEmail.XpertValueMember = null;
            txtEmail.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // xpertLabel1
            // 
            xpertLabel1.Calculation_Expression = null;
            xpertLabel1.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            xpertLabel1.Calculative = false;
            xpertLabel1.Column_Name = null;
            xpertLabel1.Control_Name = "xpertLabel1";
            xpertLabel1.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            xpertLabel1.Custom_Data = false;
            xpertLabel1.Custom_Default = false;
            xpertLabel1.Display_Name = null;
            xpertLabel1.Field_Description = null;
            xpertLabel1.Field_Name = null;
            xpertLabel1.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            xpertLabel1.FieldName = null;
            xpertLabel1.Generated = false;
            xpertLabel1.Location = new System.Drawing.Point(11, 38);
            xpertLabel1.MendatroryField = false;
            xpertLabel1.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            xpertLabel1.Name = "xpertLabel1";
            xpertLabel1.Size = new System.Drawing.Size(33, 18);
            xpertLabel1.SourceColumn = null;
            xpertLabel1.TabIndex = 9;
            xpertLabel1.Text = "Email";
            xpertLabel1.XpertDisplayMember = null;
            xpertLabel1.XpertValueMember = null;
            xpertLabel1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            xpertLabel1.Click += xpertLabel1_Click;
            // 
            // txtPhone
            // 
            txtPhone.Calculation_Expression = null;
            txtPhone.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtPhone.CalculationExpression = null;
            txtPhone.Calculative = false;
            txtPhone.Column_Name = "Phone";
            txtPhone.Control_Name = "txtPhone";
            txtPhone.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtPhone.Custom_Data = false;
            txtPhone.Custom_Default = false;
            txtPhone.Display_Name = "Email";
            txtPhone.Field_Description = null;
            txtPhone.Field_Name = "Phone";
            txtPhone.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtPhone.FieldCode = null;
            txtPhone.FieldDesc = null;
            txtPhone.FieldMaxLength = 0;
            txtPhone.FieldName = "Phone";
            txtPhone.Generated = false;
            txtPhone.isCalculatedField = false;
            txtPhone.IsSourceFromTable = false;
            txtPhone.IsSourceFromValueList = false;
            txtPhone.IsUnique = false;
            txtPhone.Key = false;
            txtPhone.Location = new System.Drawing.Point(61, 61);
            txtPhone.Max_Length = 0;
            txtPhone.MendatroryField = false;
            txtPhone.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtPhone.Min_Length = 0;
            txtPhone.MyLinkLable1 = xpertLabel1;
            txtPhone.MyLinkLable2 = null;
            txtPhone.Name = "txtPhone";
            txtPhone.ReferenceFieldDesc = null;
            txtPhone.ReferenceFieldName = "Phone";
            txtPhone.ReferenceTableName = null;
            txtPhone.Size = new System.Drawing.Size(412, 20);
            txtPhone.TabIndex = 9;
            txtPhone.XpertDisplayMember = null;
            txtPhone.XpertValueMember = null;
            txtPhone.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // xpertLabel2
            // 
            xpertLabel2.Calculation_Expression = null;
            xpertLabel2.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            xpertLabel2.Calculative = false;
            xpertLabel2.Column_Name = null;
            xpertLabel2.Control_Name = "xpertLabel2";
            xpertLabel2.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            xpertLabel2.Custom_Data = false;
            xpertLabel2.Custom_Default = false;
            xpertLabel2.Display_Name = null;
            xpertLabel2.Field_Description = null;
            xpertLabel2.Field_Name = null;
            xpertLabel2.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            xpertLabel2.FieldName = null;
            xpertLabel2.Generated = false;
            xpertLabel2.Location = new System.Drawing.Point(11, 65);
            xpertLabel2.MendatroryField = false;
            xpertLabel2.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            xpertLabel2.Name = "xpertLabel2";
            xpertLabel2.Size = new System.Drawing.Size(38, 18);
            xpertLabel2.SourceColumn = null;
            xpertLabel2.TabIndex = 10;
            xpertLabel2.Text = "Phone";
            xpertLabel2.XpertDisplayMember = null;
            xpertLabel2.XpertValueMember = null;
            xpertLabel2.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblLevel
            // 
            lblLevel.Calculation_Expression = null;
            lblLevel.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblLevel.Calculative = false;
            lblLevel.Column_Name = null;
            lblLevel.Control_Name = "lblLevel";
            lblLevel.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblLevel.Custom_Data = false;
            lblLevel.Custom_Default = false;
            lblLevel.Display_Name = null;
            lblLevel.Field_Description = null;
            lblLevel.Field_Name = null;
            lblLevel.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblLevel.FieldName = null;
            lblLevel.Generated = false;
            lblLevel.Location = new System.Drawing.Point(460, 34);
            lblLevel.MendatroryField = false;
            lblLevel.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new System.Drawing.Size(32, 18);
            lblLevel.SourceColumn = null;
            lblLevel.TabIndex = 17;
            lblLevel.Text = "Level";
            lblLevel.XpertDisplayMember = null;
            lblLevel.XpertValueMember = null;
            lblLevel.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // ddlLevel
            // 
            ddlLevel.Calculation_Expression = null;
            ddlLevel.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            ddlLevel.CalculationExpression = null;
            ddlLevel.Calculative = false;
            ddlLevel.Collection_Name = null;
            ddlLevel.Column_Name = "User_Type";
            ddlLevel.Control_Name = "ddlLevel";
            ddlLevel.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            ddlLevel.Custom_Data = false;
            ddlLevel.Custom_Datasource_Logic = false;
            ddlLevel.Custom_Default = false;
            ddlLevel.Custom_List.Add("Level 1");
            ddlLevel.Custom_List.Add("Level 2");
            ddlLevel.Custom_List.Add("Level 3");
            ddlLevel.Custom_List.Add("Level 4");
            ddlLevel.Datasource_Assembly = "";
            ddlLevel.Datasource_Namespace = null;
            ddlLevel.Datasource_Program = null;
            ddlLevel.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.Custom;
            ddlLevel.Display_Name = "Level";
            ddlLevel.DropDownAnimationEnabled = true;
            ddlLevel.Enum_Name = null;
            ddlLevel.Field_Description = "Level";
            ddlLevel.Field_Name = "User_Type";
            ddlLevel.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            ddlLevel.FieldCode = null;
            ddlLevel.FieldDesc = "Level";
            ddlLevel.FieldMaxLength = 0;
            ddlLevel.FieldName = "User_Type";
            ddlLevel.Generated = false;
            ddlLevel.isCalculatedField = false;
            ddlLevel.IsSourceFromTable = false;
            ddlLevel.IsSourceFromValueList = false;
            ddlLevel.IsUnique = false;
            ddlLevel.Key = false;
            ddlLevel.Key_Column_Name = null;
            ddlLevel.Key_Property = null;
            ddlLevel.Key_Value = null;
            ddlLevel.Location = new System.Drawing.Point(500, 36);
            ddlLevel.Max_Length = 0;
            ddlLevel.MendatroryField = false;
            ddlLevel.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            ddlLevel.Min_Length = 0;
            ddlLevel.Model_Name = null;
            ddlLevel.MyLinkLable1 = null;
            ddlLevel.MyLinkLable2 = null;
            ddlLevel.Name = "ddlLevel";
            ddlLevel.Name_Column_Name = null;
            ddlLevel.Name_Property = null;
            ddlLevel.Name_Value = null;
            ddlLevel.Page_Key_Property = null;
            ddlLevel.Page_Name_Property = null;
            ddlLevel.Query_Class_Name = null;
            ddlLevel.ReferenceFieldDesc = null;
            ddlLevel.ReferenceFieldName = "User_Type";
            ddlLevel.ReferenceTableName = null;
            ddlLevel.Size = new System.Drawing.Size(125, 20);
            ddlLevel.SQLMethodName = null;
            ddlLevel.TabIndex = 16;
            ddlLevel.Table_Name = null;
            ddlLevel.Tag_Column_Name = null;
            ddlLevel.Tag_Property = null;
            ddlLevel.Web_Page_Name = null;
            ddlLevel.Web_Page_Url = null;
            ddlLevel.XpertDisplayMember = null;
            ddlLevel.XpertValueMember = null;
            ddlLevel.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Password
            // 
            Password.Calculation_Expression = null;
            Password.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            Password.Calculative = false;
            Password.Column_Name = null;
            Password.Control_Name = "Password";
            Password.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            Password.Custom_Data = false;
            Password.Custom_Default = false;
            Password.Display_Name = null;
            Password.Field_Description = null;
            Password.Field_Name = null;
            Password.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            Password.FieldName = null;
            Password.Generated = false;
            Password.Location = new System.Drawing.Point(29, 86);
            Password.MendatroryField = false;
            Password.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            Password.Name = "Password";
            Password.Size = new System.Drawing.Size(53, 18);
            Password.SourceColumn = null;
            Password.TabIndex = 15;
            Password.Text = "Password";
            Password.XpertDisplayMember = null;
            Password.XpertValueMember = null;
            Password.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtPassword
            // 
            txtPassword.Calculation_Expression = null;
            txtPassword.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtPassword.CalculationExpression = null;
            txtPassword.Calculative = false;
            txtPassword.Column_Name = "Password";
            txtPassword.Control_Name = "txtPassword";
            txtPassword.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtPassword.Custom_Data = false;
            txtPassword.Custom_Default = false;
            txtPassword.Display_Name = "Password";
            txtPassword.Field_Description = "Password";
            txtPassword.Field_Name = "Password";
            txtPassword.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            txtPassword.FieldCode = null;
            txtPassword.FieldDesc = "Password";
            txtPassword.FieldMaxLength = 0;
            txtPassword.FieldName = "Password";
            txtPassword.Generated = false;
            txtPassword.isCalculatedField = false;
            txtPassword.IsSourceFromTable = false;
            txtPassword.IsSourceFromValueList = false;
            txtPassword.IsUnique = false;
            txtPassword.Key = false;
            txtPassword.Location = new System.Drawing.Point(138, 86);
            txtPassword.Max_Length = 0;
            txtPassword.MendatroryField = false;
            txtPassword.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtPassword.Min_Length = 0;
            txtPassword.MyLinkLable1 = null;
            txtPassword.MyLinkLable2 = null;
            txtPassword.Name = "txtPassword";
            txtPassword.ReferenceFieldDesc = null;
            txtPassword.ReferenceFieldName = "Password";
            txtPassword.ReferenceTableName = null;
            txtPassword.Size = new System.Drawing.Size(412, 20);
            txtPassword.TabIndex = 14;
            txtPassword.Text = "Password";
            txtPassword.XpertDisplayMember = null;
            txtPassword.XpertValueMember = null;
            txtPassword.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // xpertLabel3
            // 
            xpertLabel3.Calculation_Expression = null;
            xpertLabel3.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            xpertLabel3.Calculative = false;
            xpertLabel3.Column_Name = null;
            xpertLabel3.Control_Name = "xpertLabel3";
            xpertLabel3.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            xpertLabel3.Custom_Data = false;
            xpertLabel3.Custom_Default = false;
            xpertLabel3.Display_Name = null;
            xpertLabel3.Field_Description = null;
            xpertLabel3.Field_Name = null;
            xpertLabel3.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            xpertLabel3.FieldName = null;
            xpertLabel3.Generated = false;
            xpertLabel3.Location = new System.Drawing.Point(33, 115);
            xpertLabel3.MendatroryField = false;
            xpertLabel3.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            xpertLabel3.Name = "xpertLabel3";
            xpertLabel3.Size = new System.Drawing.Size(35, 18);
            xpertLabel3.SourceColumn = null;
            xpertLabel3.TabIndex = 12;
            xpertLabel3.Text = "Client";
            xpertLabel3.XpertDisplayMember = null;
            xpertLabel3.XpertValueMember = null;
            xpertLabel3.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            xpertLabel3.Click += xpertLabel3_Click;
            // 
            // fndClient
            // 
            fndClient.Calculation_Expression = null;
            fndClient.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            fndClient.CalculationExpression = null;
            fndClient.Calculative = false;
            fndClient.Collection_Name = null;
            fndClient.Column_Name = "Client";
            fndClient.Control_Name = "fndClient";
            fndClient.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            fndClient.Custom_Data = false;
            fndClient.Custom_Datasource_Logic = false;
            fndClient.Custom_Default = false;
            fndClient.DataSource = null;
            fndClient.Datasource_Assembly = null;
            fndClient.Datasource_Namespace = null;
            fndClient.Datasource_Program = null;
            fndClient.Datasource_Type = XpertStudio.Common.Enums.XpertFinderConfigType.Database;
            fndClient.DescriptionLabel1 = null;
            fndClient.DescriptionLabel2 = null;
            fndClient.Display_Name = "Client";
            fndClient.DisplayMember = null;
            fndClient.Enum_Name = null;
            fndClient.Field_Description = null;
            fndClient.Field_Name = "Client";
            fndClient.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.Finder;
            fndClient.FieldCode = null;
            fndClient.FieldDesc = null;
            fndClient.FieldMaxLength = 0;
            fndClient.FieldName = null;
            fndClient.Generated = false;
            fndClient.Is_Grouping = false;
            fndClient.isCalculatedField = false;
            fndClient.IsSourceFromTable = false;
            fndClient.IsSourceFromValueList = false;
            fndClient.IsUnique = false;
            fndClient.Key = false;
            fndClient.Key_Column_Name = "Client_Id";
            fndClient.Key_Property = null;
            fndClient.Key_Value = null;
            fndClient.Location = new System.Drawing.Point(136, 113);
            fndClient.Mandatory = false;
            fndClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fndClient.Max_Length = 0;
            fndClient.Max_Size = 0;
            fndClient.MendatroryField = false;
            fndClient.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            fndClient.Min_Length = 0;
            fndClient.Min_Size = 0;
            fndClient.Model_Name = null;
            fndClient.MyFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fndClient.MyLinkLable1 = null;
            fndClient.MyLinkLable2 = null;
            fndClient.MyReadOnly = false;
            fndClient.MyShowMasterFormButton = true;
            fndClient.MyShowWriteUpButton = true;
            fndClient.Name = "fndClient";
            fndClient.Name_Column_Name = "Client_Name";
            fndClient.Name_Property = null;
            fndClient.Name_Value = null;
            fndClient.Page_Key_Property = null;
            fndClient.Page_Name_Property = null;
            fndClient.Query_Class_Name = null;
            fndClient.ReferenceFieldDesc = null;
            fndClient.ReferenceFieldName = null;
            fndClient.ReferenceTableName = null;
            fndClient.Required = false;
            fndClient.ShowDataSource = false;
            fndClient.Size = new System.Drawing.Size(409, 22);
            fndClient.SQLMethodName = null;
            fndClient.TabIndex = 11;
            fndClient.Table_Name = "CLIENT_MASTER";
            fndClient.Tag_Column_Name = null;
            fndClient.Tag_Property = null;
            fndClient.Value = "";
            fndClient.ValueMember = null;
            fndClient.Web_Page_Name = null;
            fndClient.Web_Page_Url = null;
            fndClient.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // txtUserName
            // 
            txtUserName.Calculation_Expression = null;
            txtUserName.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            txtUserName.CalculationExpression = null;
            txtUserName.Calculative = false;
            txtUserName.Column_Name = "User_Name";
            txtUserName.Control_Name = "txtUserName";
            txtUserName.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            txtUserName.Custom_Data = false;
            txtUserName.Custom_Default = false;
            txtUserName.Display_Name = "User Name";
            txtUserName.Field_Description = null;
            txtUserName.Field_Name = "Description";
            txtUserName.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.Description;
            txtUserName.FieldCode = null;
            txtUserName.FieldDesc = null;
            txtUserName.FieldMaxLength = 0;
            txtUserName.FieldName = "Description";
            txtUserName.Generated = false;
            txtUserName.isCalculatedField = false;
            txtUserName.IsSourceFromTable = false;
            txtUserName.IsSourceFromValueList = false;
            txtUserName.IsUnique = false;
            txtUserName.Key = false;
            txtUserName.Location = new System.Drawing.Point(136, 60);
            txtUserName.Max_Length = 0;
            txtUserName.MendatroryField = false;
            txtUserName.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            txtUserName.Min_Length = 0;
            txtUserName.MyLinkLable1 = lblUserName;
            txtUserName.MyLinkLable2 = null;
            txtUserName.Name = "txtUserName";
            txtUserName.ReferenceFieldDesc = null;
            txtUserName.ReferenceFieldName = "Description";
            txtUserName.ReferenceTableName = null;
            txtUserName.Size = new System.Drawing.Size(489, 20);
            txtUserName.TabIndex = 7;
            txtUserName.XpertDisplayMember = null;
            txtUserName.XpertValueMember = null;
            txtUserName.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // lblUserName
            // 
            lblUserName.Calculation_Expression = null;
            lblUserName.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblUserName.Calculative = false;
            lblUserName.Column_Name = null;
            lblUserName.Control_Name = "lblUserName";
            lblUserName.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblUserName.Custom_Data = false;
            lblUserName.Custom_Default = false;
            lblUserName.Display_Name = null;
            lblUserName.Field_Description = null;
            lblUserName.Field_Name = null;
            lblUserName.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblUserName.FieldName = null;
            lblUserName.Generated = false;
            lblUserName.Location = new System.Drawing.Point(27, 62);
            lblUserName.MendatroryField = false;
            lblUserName.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(62, 18);
            lblUserName.SourceColumn = null;
            lblUserName.TabIndex = 6;
            lblUserName.Text = "User Name";
            lblUserName.XpertDisplayMember = null;
            lblUserName.XpertValueMember = null;
            lblUserName.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
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
            lblDocNo.Location = new System.Drawing.Point(27, 36);
            lblDocNo.MendatroryField = false;
            lblDocNo.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblDocNo.Name = "lblDocNo";
            lblDocNo.Size = new System.Drawing.Size(58, 18);
            lblDocNo.SourceColumn = null;
            lblDocNo.TabIndex = 5;
            lblDocNo.Text = "User Code";
            lblDocNo.XpertDisplayMember = null;
            lblDocNo.XpertValueMember = null;
            lblDocNo.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // fndUserCode
            // 
            fndUserCode.Calculation_Expression = null;
            fndUserCode.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            fndUserCode.Calculative = false;
            fndUserCode.Column_Name = "User_Code";
            fndUserCode.Control_Name = "XpertNavigator";
            fndUserCode.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            fndUserCode.Custom_Data = false;
            fndUserCode.Custom_Default = false;
            fndUserCode.DataSource = null;
            fndUserCode.Display_Name = "User Code";
            fndUserCode.DisplayMember = null;
            fndUserCode.Field_Description = null;
            fndUserCode.Field_Name = "ID";
            fndUserCode.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.ID;
            fndUserCode.FieldName = "ID";
            fndUserCode.Generated = false;
            fndUserCode.Key = false;
            fndUserCode.Location = new System.Drawing.Point(136, 34);
            fndUserCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            fndUserCode.Max_Length = 30;
            fndUserCode.Max_Size = 0;
            fndUserCode.MendatroryField = true;
            fndUserCode.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.Auto;
            fndUserCode.Min_Length = 0;
            fndUserCode.Min_Size = 0;
            fndUserCode.MyCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            fndUserCode.MyFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fndUserCode.MyLinkLable1 = lblDocNo;
            fndUserCode.MyLinkLable2 = null;
            fndUserCode.MyMaxLength = 32767;
            fndUserCode.MyNewEnable = true;
            fndUserCode.MyNewPerformClick = false;
            fndUserCode.MyNewVisible = true;
            fndUserCode.MyReadOnly = false;
            fndUserCode.Name = "fndUserCode";
            fndUserCode.Required = false;
            fndUserCode.Size = new System.Drawing.Size(310, 24);
            fndUserCode.TabIndex = 4;
            fndUserCode.Value = "";
            fndUserCode.ValueMember = null;
            fndUserCode.XpertDisplayMember = null;
            fndUserCode.XpertValueMember = null;
            fndUserCode.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // xpertPageView1
            // 
            xpertPageView1.BorderColor = System.Drawing.Color.Black;
            xpertPageView1.Control_Name = "xpertPageView1";
            xpertPageView1.Controls.Add(Page1);
            xpertPageView1.Controls.Add(Page2);
            xpertPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            xpertPageView1.Location = new System.Drawing.Point(0, 0);
            xpertPageView1.Name = "xpertPageView1";
            xpertPageView1.SelectedPage = Page1;
            xpertPageView1.Size = new System.Drawing.Size(905, 413);
            xpertPageView1.TabIndex = 0;
            xpertPageView1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Page1
            // 
            Page1.Controls.Add(xpertSplitContainer1);
            Page1.ItemSize = new System.Drawing.SizeF(55F, 28F);
            Page1.Location = new System.Drawing.Point(10, 37);
            Page1.Name = "Page1";
            Page1.Size = new System.Drawing.Size(884, 365);
            Page1.Text = "General";
            // 
            // Page2
            // 
            Page2.ItemSize = new System.Drawing.SizeF(50F, 28F);
            Page2.Location = new System.Drawing.Point(10, 37);
            Page2.Name = "Page2";
            Page2.Size = new System.Drawing.Size(810, 384);
            Page2.Text = "Others";
            // 
            // frmUserMaster
            // 
            ApproveCommandVisibility = false;
            AuthPolicy = XpertStudio.Common.Authorization.XsPolicies.AnonymousUser;
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelCommandVisibility = false;
            Class_Name = "clsUser_Master";
            ClientSize = new System.Drawing.Size(905, 451);
            Controls.Add(xpertPageView1);
            CreateCommandServiceClass = "clsUser_MasterCreateCommand";
            CurrentEditorType = "frmRuleEditor";
            DataProxyLayerClass = "IclsUser_MasterDataProxy";
            DeleteCommandServiceClass = "clsUser_MasterDeleteCommand";
            Doc_Prefix = "UM";
            DomainLayerClass = "clsUser_Master";
            DomainRulesClass = "clsUser_MasterRules";
            EnableAddButton = true;
            ExternalAssemblies.Assemblies = (System.Collections.Generic.List<string>)resources.GetObject("resource.Assemblies");
            File_Path = "D:\\Official\\Testing\\MachineTest\\MachineTest\\WinFormUI3Tier\\Setup\\frmUserMaster.cs";
            Form_Name = "frmUserMaster";
            Form_Type = XpertStudio.Common.Enums.XpertFormTypes.Master;
            Functional_Name = "User_Master";
            IServiceLayerClass = "IclsUser_MasterService";
            MaxFieldsListPage = 5;
            ModuleName = "MachineTest";
            Name = "frmUserMaster";
            PostCommandVisibility = false;
            PrintCommandVisibility = false;
            Program_Code = "User_Master";
            Program_Name = "User Master";
            QueryClass = "clsUser_MasterQueries";
            RepositoryLayerClass = "clsUser_MasterRepository";
            ServiceLayerClass = "clsUser_MasterService";
            SubModuleName = "Setup";
            Table_Name = "User_Master";
            Text = "User Master";
            UpdateCommandServiceClass = "clsUser_MasterUpdateCommand";
            WinFormUILayerClass = "clsUser_MasterWinFormUI";
            Load += XSMasterTypical_Load;
            Controls.SetChildIndex(xpertPageView1, 0);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            xpertSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xpertSplitContainer1).EndInit();
            xpertSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gbxHeader).EndInit();
            gbxHeader.ResumeLayout(false);
            gbxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gbxAttachPan).EndInit();
            gbxAttachPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xpertGroupBox2).EndInit();
            xpertGroupBox2.ResumeLayout(false);
            xpertGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpertLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpertLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Password).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpertLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblUserName).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblDocNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpertPageView1).EndInit();
            xpertPageView1.ResumeLayout(false);
            Page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private XS.WinForms.Controls.XpertSplitContainer xpertSplitContainer1;
        private XS.WinForms.Controls.XpertPageView xpertPageView1;
        private Telerik.WinControls.UI.RadPageViewPage Page1;
        private Telerik.WinControls.UI.RadPageViewPage Page2;
        private XS.WinForms.Controls.XpertGroupBox gbxHeader;
        private XS.WinForms.Controls.XpertGroupBox gbxAttachPan;
        private XS.WinForms.Controls.XpertFileUpload filePanCard;
        private XS.WinForms.Controls.XpertGroupBox xpertGroupBox2;
        private XS.WinForms.Controls.XpertTextBox txtEmail;
        private XS.WinForms.Controls.XpertLabel xpertLabel1;
        private XS.WinForms.Controls.XpertTextBox txtPhone;
        private XS.WinForms.Controls.XpertLabel xpertLabel2;
        private XS.WinForms.Controls.XpertLabel lblLevel;
        private XS.WinForms.Controls.XpertDropDown ddlLevel;
        private XS.WinForms.Controls.XpertLabel Password;
        private XS.WinForms.Controls.XpertTextBox txtPassword;
        private XS.WinForms.Controls.XpertLabel xpertLabel3;
        private XS.WinForms.Controls.XpertFinder fndClient;
        private XS.WinForms.Controls.XpertTextBox txtUserName;
        private XS.WinForms.Controls.XpertLabel lblUserName;
        private XS.WinForms.Controls.XpertLabel lblDocNo;
        private XS.WinForms.Controls.XpertNavigator fndUserCode;
    }
}