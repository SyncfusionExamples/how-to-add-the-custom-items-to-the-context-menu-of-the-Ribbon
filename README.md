# How-to-add-the-custom-items-to-the-context-menu-of-the-RibbonControlAdv

This repository contains a sample that demonstrates how to add custom items to the context menu of the WinForms RibbonControlAdv. In this sample, a `RibbonForm` hosts a `RibbonControlAdv` with Home, Send, and Folder tabs, and the ribbon context menu is customized before it is displayed.

The custom item is added by handling the `BeforeContextMenuOpen` event of the `RibbonControlAdv`. Inside this event, a new `ToolStripMenuItem` named **About** is created and added to the `ContextMenuItems` collection. When the custom item is clicked, the sample opens the Syncfusion help site.

```C#
private void RibbonControlAdv1_BeforeContextMenuOpen(object sender, ContextMenuEventArgs e)
{
    ToolStripItem aboutItem = new ToolStripMenuItem();
    aboutItem.Text = "About";
    aboutItem.Click += AboutItem_Click;
    e.ContextMenuItems.Add(aboutItem);
}