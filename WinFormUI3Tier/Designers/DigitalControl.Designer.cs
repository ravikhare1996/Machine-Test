using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Xpert.TMS
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DigitalControl : UserControl
    {

        // UserControl overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDigitalClock = new XS.WinForms.Controls.XSMSLabel();
            Timer1 = new XS.WinForms.Controls.XpertTimer(components);
            SuspendLayout();
            // 
            // lblDigitalClock
            // 
            lblDigitalClock.AutoSize = true;
            lblDigitalClock.BackColor = Color.Transparent;
            lblDigitalClock.Calculation_Expression = null;
            lblDigitalClock.Calculation_Type = XS.WinForms.Controls.CalculationTypes.None;
            lblDigitalClock.Calculative = false;
            lblDigitalClock.Column_Name = null;
            lblDigitalClock.Control_Name = "lblDigitalClock";
            lblDigitalClock.Create_Option = XpertStudio.Common.Enums.XpertFieldCreateOptions.UIAndModelAndTable;
            lblDigitalClock.Custom_Data = false;
            lblDigitalClock.Custom_Default = false;
            lblDigitalClock.Display_Name = null;
            lblDigitalClock.Dock = DockStyle.Fill;
            lblDigitalClock.Field_Description = null;
            lblDigitalClock.Field_Name = null;
            lblDigitalClock.Field_Type = XpertStudio.Common.Enums.XpertFieldTypes.None;
            lblDigitalClock.FieldName = null;
            lblDigitalClock.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDigitalClock.ForeColor = Color.FromArgb(89, 116, 171);
            lblDigitalClock.Generated = false;
            lblDigitalClock.Location = new Point(0, 0);
            lblDigitalClock.Margin = new Padding(4, 0, 4, 0);
            lblDigitalClock.MendatroryField = false;
            lblDigitalClock.Metadata_Type = XpertStudio.Common.Enums.XpertMetadataTypes.None;
            lblDigitalClock.Name = "lblDigitalClock";
            lblDigitalClock.Size = new Size(207, 37);
            lblDigitalClock.TabIndex = 0;
            lblDigitalClock.Text = "12:12:59 AM";
            lblDigitalClock.XpertDisplayMember = null;
            lblDigitalClock.XpertValueMember = null;
            lblDigitalClock.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            // 
            // Timer1
            // 
            Timer1.Control_Name = null;
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            Timer1.XS_Skip = XpertStudio.Common.Enums.XS_SkipTypes.None;
            Timer1.Tick += Timer1_Tick;
            // 
            // DigitalControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDigitalClock);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(236, 38);
            MinimumSize = new Size(236, 38);
            Name = "DigitalControl";
            Size = new Size(236, 38);
            Load += DigitalControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        internal XS.WinForms.Controls.XSMSLabel lblDigitalClock;
        internal XS.WinForms.Controls.XpertTimer Timer1;

    }
}