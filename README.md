# How-to-add-the-custom-items-to-the-context-menu-of-the-RibbonControlAdv
The custom items can be added to the ContextMenu of the RibbonControlAdv using the BeforeContextMenuOpen event.

# c#
    this.ribbonControlAdv1.BeforeContextMenuOpen += RibbonControlAdv1_BeforeContextMenuOpen;

    private void RibbonControlAdv1_BeforeContextMenuOpen(object sender, ContextMenuEventArgs e)
    {
        ToolStripItem aboutItem = new ToolStripMenuItem();
        aboutItem.Text = "About";
        aboutItem.Click += AboutItem_Click;
        e.ContextMenuItems.Add(aboutItem);
    }

    private void AboutItem_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("https://help.syncfusion.com/");       
    }

![CustomItem to ContextMenu](Image/Custom%20item.png).
