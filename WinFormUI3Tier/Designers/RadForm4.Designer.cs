namespace WinFormUI3Tier.Designers
{
    partial class RadForm4
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            RadPageView4 = new Telerik.WinControls.UI.RadPageView();
            rdHeldup = new Telerik.WinControls.UI.RadPageViewPage();
            gvHeldUpWork = new Telerik.WinControls.UI.RadGridView();
            Panel25 = new System.Windows.Forms.Panel();
            Panel21 = new System.Windows.Forms.Panel();
            MyLabel51 = new XS.WinForms.Controls.XpertLabel();
            btnHeldupRefresh = new XS.WinForms.Controls.XpertRefreshIconButton();
            rdExpire = new Telerik.WinControls.UI.RadPageViewPage();
            Panel24 = new XS.WinForms.Controls.XSMSPanel();
            gvExpired = new Telerik.WinControls.UI.RadGridView();
            Panel20 = new XS.WinForms.Controls.XSMSPanel();
            MyLabel44 = new XS.WinForms.Controls.XpertLabel();
            btExpiryRefresh = new XS.WinForms.Controls.XpertRefreshIconButton();
            ((System.ComponentModel.ISupportInitialize)RadPageView4).BeginInit();
            RadPageView4.SuspendLayout();
            rdHeldup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork.MasterTemplate).BeginInit();
            Panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel51).BeginInit();
            rdExpire.SuspendLayout();
            Panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvExpired).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvExpired.MasterTemplate).BeginInit();
            Panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MyLabel44).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RadPageView4
            // 
            RadPageView4.Controls.Add(rdHeldup);
            RadPageView4.Controls.Add(rdExpire);
            RadPageView4.Location = new System.Drawing.Point(15, 138);
            RadPageView4.Name = "RadPageView4";
            RadPageView4.SelectedPage = rdHeldup;
            RadPageView4.Size = new System.Drawing.Size(770, 206);
            RadPageView4.TabIndex = 11;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).BackColor = System.Drawing.SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewStripElement)RadPageView4.GetChildAt(0)).Padding = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.StripViewItemContainer)RadPageView4.GetChildAt(0).GetChildAt(0)).BackColor = System.Drawing.SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.StripViewItemLayout)RadPageView4.GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = System.Drawing.SystemColors.ActiveCaption;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderLeftWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderTopWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderRightWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BorderBottomWidth = 1F;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).BackColor = System.Drawing.SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)RadPageView4.GetChildAt(0).GetChildAt(1)).Padding = new System.Windows.Forms.Padding(3);
            // 
            // rdHeldup
            // 
            rdHeldup.Controls.Add(gvHeldUpWork);
            rdHeldup.Controls.Add(Panel25);
            rdHeldup.Controls.Add(Panel21);
            rdHeldup.ItemSize = new System.Drawing.SizeF(83F, 28F);
            rdHeldup.Location = new System.Drawing.Point(4, 31);
            rdHeldup.Name = "rdHeldup";
            rdHeldup.Size = new System.Drawing.Size(762, 171);
            rdHeldup.Text = "Heldup Work";
            // 
            // gvHeldUpWork
            // 
            gvHeldUpWork.BackColor = System.Drawing.Color.White;
            gvHeldUpWork.Location = new System.Drawing.Point(3, 73);
            // 
            // 
            // 
            gvHeldUpWork.MasterTemplate.ShowHeaderCellButtons = true;
            gvHeldUpWork.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gvHeldUpWork.Name = "gvHeldUpWork";
            gvHeldUpWork.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            gvHeldUpWork.Size = new System.Drawing.Size(729, 95);
            gvHeldUpWork.TabIndex = 52;
            ((Telerik.WinControls.UI.RadGridViewElement)gvHeldUpWork.GetChildAt(0)).BorderColor = System.Drawing.SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvHeldUpWork.GetChildAt(0)).BorderBottomColor = System.Drawing.SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvHeldUpWork.GetChildAt(0)).Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            // 
            // Panel25
            // 
            Panel25.Location = new System.Drawing.Point(0, 27);
            Panel25.Name = "Panel25";
            Panel25.Size = new System.Drawing.Size(759, 40);
            Panel25.TabIndex = 54;
            // 
            // Panel21
            // 
            Panel21.BackColor = System.Drawing.Color.Transparent;
            Panel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Panel21.Controls.Add(MyLabel51);
            Panel21.Controls.Add(btnHeldupRefresh);
            Panel21.Location = new System.Drawing.Point(0, 0);
            Panel21.Name = "Panel21";
            Panel21.Size = new System.Drawing.Size(1107, 27);
            Panel21.TabIndex = 53;
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
            MyLabel51.Cursor = System.Windows.Forms.Cursors.Hand;
            MyLabel51.Custom_Data = false;
            MyLabel51.Custom_Default = false;
            MyLabel51.Display_Name = null;
            MyLabel51.Field_Description = null;
            MyLabel51.Field_Name = null;
            MyLabel51.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel51.FieldName = null;
            MyLabel51.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MyLabel51.Generated = false;
            MyLabel51.Location = new System.Drawing.Point(1, 3);
            MyLabel51.MendatroryField = false;
            MyLabel51.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel51.Name = "MyLabel51";
            MyLabel51.Size = new System.Drawing.Size(40, 16);
            MyLabel51.SourceColumn = null;
            MyLabel51.TabIndex = 27;
            MyLabel51.Text = "List : 0";
            MyLabel51.XpertDisplayMember = null;
            MyLabel51.XpertValueMember = null;
            MyLabel51.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btnHeldupRefresh
            // 
            btnHeldupRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnHeldupRefresh.Command_Type = XpertStudio.Common.Enums.XpertCommandTypes.Refresh;
            btnHeldupRefresh.Control_Name = "ucRefreshIconButton";
            btnHeldupRefresh.CustomAction = false;
            btnHeldupRefresh.Display_Name = "";
            btnHeldupRefresh.Generated = false;
            btnHeldupRefresh.Location = new System.Drawing.Point(4691, 1);
            btnHeldupRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHeldupRefresh.MaximumSize = new System.Drawing.Size(20, 20);
            btnHeldupRefresh.MinimumSize = new System.Drawing.Size(20, 20);
            btnHeldupRefresh.MyPerformClick = false;
            btnHeldupRefresh.Name = "btnHeldupRefresh";
            btnHeldupRefresh.Size = new System.Drawing.Size(20, 20);
            btnHeldupRefresh.TabIndex = 1;
            btnHeldupRefresh.Url = null;
            btnHeldupRefresh.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // rdExpire
            // 
            rdExpire.Controls.Add(Panel24);
            rdExpire.Controls.Add(Panel20);
            rdExpire.ItemSize = new System.Drawing.SizeF(83F, 28F);
            rdExpire.Location = new System.Drawing.Point(4, 31);
            rdExpire.Name = "rdExpire";
            rdExpire.Size = new System.Drawing.Size(762, 171);
            rdExpire.Text = "Expired Work";
            // 
            // Panel24
            // 
            Panel24.Control_Name = "Panel24";
            Panel24.Controls.Add(gvExpired);
            Panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel24.Location = new System.Drawing.Point(0, 27);
            Panel24.Name = "Panel24";
            Panel24.Size = new System.Drawing.Size(762, 144);
            Panel24.TabIndex = 53;
            Panel24.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // gvExpired
            // 
            gvExpired.BackColor = System.Drawing.Color.White;
            gvExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            gvExpired.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            gvExpired.MasterTemplate.ShowHeaderCellButtons = true;
            gvExpired.MasterTemplate.ViewDefinition = tableViewDefinition2;
            gvExpired.Name = "gvExpired";
            gvExpired.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            gvExpired.Size = new System.Drawing.Size(762, 144);
            gvExpired.TabIndex = 51;
            ((Telerik.WinControls.UI.RadGridViewElement)gvExpired.GetChildAt(0)).BorderColor = System.Drawing.SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvExpired.GetChildAt(0)).BorderBottomColor = System.Drawing.SystemColors.ControlLight;
            ((Telerik.WinControls.UI.RadGridViewElement)gvExpired.GetChildAt(0)).Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            // 
            // Panel20
            // 
            Panel20.BackColor = System.Drawing.Color.Transparent;
            Panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Panel20.Control_Name = "Panel20";
            Panel20.Controls.Add(MyLabel44);
            Panel20.Controls.Add(btExpiryRefresh);
            Panel20.Dock = System.Windows.Forms.DockStyle.Top;
            Panel20.Location = new System.Drawing.Point(0, 0);
            Panel20.Name = "Panel20";
            Panel20.Size = new System.Drawing.Size(762, 27);
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
            MyLabel44.Cursor = System.Windows.Forms.Cursors.Hand;
            MyLabel44.Custom_Data = false;
            MyLabel44.Custom_Default = false;
            MyLabel44.Display_Name = null;
            MyLabel44.Field_Description = null;
            MyLabel44.Field_Name = null;
            MyLabel44.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            MyLabel44.FieldName = null;
            MyLabel44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MyLabel44.Generated = false;
            MyLabel44.Location = new System.Drawing.Point(1, 3);
            MyLabel44.MendatroryField = false;
            MyLabel44.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            MyLabel44.Name = "MyLabel44";
            MyLabel44.Size = new System.Drawing.Size(40, 16);
            MyLabel44.SourceColumn = null;
            MyLabel44.TabIndex = 27;
            MyLabel44.Text = "List : 0";
            MyLabel44.XpertDisplayMember = null;
            MyLabel44.XpertValueMember = null;
            MyLabel44.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // btExpiryRefresh
            // 
            btExpiryRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btExpiryRefresh.Command_Type = XpertStudio.Common.Enums.XpertCommandTypes.Refresh;
            btExpiryRefresh.Control_Name = "ucRefreshIconButton";
            btExpiryRefresh.CustomAction = false;
            btExpiryRefresh.Display_Name = "";
            btExpiryRefresh.Generated = false;
            btExpiryRefresh.Location = new System.Drawing.Point(3311, 1);
            btExpiryRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btExpiryRefresh.MaximumSize = new System.Drawing.Size(20, 20);
            btExpiryRefresh.MinimumSize = new System.Drawing.Size(20, 20);
            btExpiryRefresh.MyPerformClick = false;
            btExpiryRefresh.Name = "btExpiryRefresh";
            btExpiryRefresh.Size = new System.Drawing.Size(20, 20);
            btExpiryRefresh.TabIndex = 1;
            btExpiryRefresh.Url = null;
            btExpiryRefresh.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // RadForm4
            // 
            AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(801, 482);
            Controls.Add(RadPageView4);
            Name = "RadForm4";
            Text = "RadForm4";
            ((System.ComponentModel.ISupportInitialize)RadPageView4).EndInit();
            RadPageView4.ResumeLayout(false);
            rdHeldup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvHeldUpWork).EndInit();
            Panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel51).EndInit();
            rdExpire.ResumeLayout(false);
            Panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvExpired.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvExpired).EndInit();
            Panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MyLabel44).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal Telerik.WinControls.UI.RadPageView RadPageView4;
        internal Telerik.WinControls.UI.RadPageViewPage rdHeldup;
        internal Telerik.WinControls.UI.RadGridView gvHeldUpWork;
        internal System.Windows.Forms.Panel Panel25;
        internal System.Windows.Forms.Panel Panel21;
        internal XS.WinForms.Controls.XpertLabel MyLabel51;
        internal XS.WinForms.Controls.XpertRefreshIconButton btnHeldupRefresh;
        internal Telerik.WinControls.UI.RadPageViewPage rdExpire;
        internal XS.WinForms.Controls.XSMSPanel Panel24;
        internal Telerik.WinControls.UI.RadGridView gvExpired;
        internal XS.WinForms.Controls.XSMSPanel Panel20;
        internal XS.WinForms.Controls.XpertLabel MyLabel44;
        internal XS.WinForms.Controls.XpertRefreshIconButton btExpiryRefresh;
    }
}
