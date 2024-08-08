
namespace WinFormUI
{
    partial class MainForm
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
            this.xpertCollapsiblePanel1 = new XS.WinForms.Controls.XpertCollapsiblePanel();
            ((System.ComponentModel.ISupportInitialize)(this.xpertCollapsiblePanel1)).BeginInit();
            this.xpertCollapsiblePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpertCollapsiblePanel1
            // 
            this.xpertCollapsiblePanel1.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.xpertCollapsiblePanel1.BorderColor = System.Drawing.Color.Black;
            this.xpertCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xpertCollapsiblePanel1.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.xpertCollapsiblePanel1.Location = new System.Drawing.Point(0, 0);
            this.xpertCollapsiblePanel1.Name = "xpertCollapsiblePanel1";
            this.xpertCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 0, 181, 450);
            // 
            // xpertCollapsiblePanel1.PanelContainer
            // 
            this.xpertCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(158, 448);
            this.xpertCollapsiblePanel1.Size = new System.Drawing.Size(181, 450);
            this.xpertCollapsiblePanel1.TabIndex = 4;
            this.xpertCollapsiblePanel1.Text = "xpertCollapsiblePanel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xpertCollapsiblePanel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpertCollapsiblePanel1)).EndInit();
            this.xpertCollapsiblePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XS.WinForms.Controls.XpertCollapsiblePanel xpertCollapsiblePanel1;
    }
}