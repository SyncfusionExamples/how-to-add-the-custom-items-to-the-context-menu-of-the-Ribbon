using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenu_Customization
{
    public partial class Form1 : RibbonForm
    {
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem homeTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem sendTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem folderTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx clipBoardtoolStrip;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        public Form1()
        {
            InitializeComponent();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.homeTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.sendTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.folderTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.clipBoardtoolStrip = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();

            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;

            this.Text = "ContextMenu Customization";
            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1036, 160);
            this.ribbonControlAdv1.ThemeName = "Office2019Colorful";
            this.ribbonControlAdv1.BeforeContextMenuOpen += RibbonControlAdv1_BeforeContextMenuOpen;

            this.homeTabItem.Text = "Home";
            this.sendTabItem.Text = "Send";
            this.folderTabItem.Text = "Folder";

            this.ribbonControlAdv1.Header.AddMainItem(this.homeTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(this.sendTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(this.folderTabItem);

            this.cutButton.Image = Image.FromFile("..//..//Resources/Cut.png");
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(46, 24);
            this.cutButton.Text = "Cut";

            this.copyButton.Image = Image.FromFile("..//..//Resources/Copy.png");
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(55, 24);
            this.copyButton.Text = "Copy";

            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutButton,
            this.copyButton});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.RowCount = 2;
            this.toolStripPanelItem1.Size = new System.Drawing.Size(59, 79);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";

            this.clipBoardtoolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clipBoardtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripPanelItem1});
            this.clipBoardtoolStrip.Size = new System.Drawing.Size(108, 92);
            this.clipBoardtoolStrip.Text = "Clipboard";
            this.clipBoardtoolStrip.CollapsedDropDownButtonText = "Clipboard";
            this.homeTabItem.Panel.Controls.Add(clipBoardtoolStrip);

            this.Controls.Add(this.backStage1);
            this.Controls.Add(ribbonControlAdv1);
        }

        /// <summary>
        /// Occurs when the context menu before opens.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void RibbonControlAdv1_BeforeContextMenuOpen(object sender, ContextMenuEventArgs e)
        {
            ToolStripItem aboutItem = new ToolStripMenuItem();
            aboutItem.Text = "About";
            aboutItem.Click += AboutItem_Click;
            e.ContextMenuItems.Add(aboutItem);
        }

        /// <summary>
        /// Occurs when the item is clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void AboutItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://help.syncfusion.com/");
        }
    }
}
