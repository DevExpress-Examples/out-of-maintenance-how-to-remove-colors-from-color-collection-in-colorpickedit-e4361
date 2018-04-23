using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorPick.Popup.Galleries;
using DevExpress.XtraEditors.Popup;
using System.Windows.Forms;
using DevExpress.XtraTab;
using System.Drawing;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon;
using System.Reflection;

namespace Q445945
{
    public class MyColorPickEdit : ColorPickEdit
    {
        protected GalleryControlGallery GetTargetGallery(string _tabPageName)
        {
            XtraTabPage targetPage = GetTabPageByName((this.PopupForm as PopupColorPickEditForm).TabControl, _tabPageName);
            PropertyInfo _ctrl = targetPage.Controls[0].GetType().GetProperty("GalleryControl");
            GalleryControlGallery gallery = (_ctrl.GetValue(targetPage.Controls[0], null) as SystemGalleryControl).Gallery;
            return gallery;

        }

        protected XtraTabPage GetTabPageByName(XtraTabControl _tabControl, string _name)
        {
            int index = -1;
            while (index < _tabControl.TabPages.Count)
            {
                index++;
                if (_tabControl.TabPages[index].Text == _name)
                    return _tabControl.TabPages[index];
            } 
            return null;
        }

        public void RemoveColorByName(string _tabPageName, List<string> _nameList)
        {
            if (PopupForm == null)
                this.GetPopupForm();

            GalleryControlGallery _gallery = GetTargetGallery(_tabPageName);
            for (int i =_gallery.Groups[0].Items.Count -1 ; i >=0; i--)
            {
                int nameIndex = _nameList.IndexOf(_gallery.Groups[0].Items[i].Caption);
                if (nameIndex != -1)
                {
                    _gallery.Groups[0].Items.RemoveAt(i);
                    _nameList.RemoveAt(nameIndex);
                    if (_nameList.Count == 0) return;
                }
            }
        }
        public void RemoveColorByName(string _tabPageName, string _name)
        {
            if (PopupForm == null)
                this.GetPopupForm();

            GalleryControlGallery _gallery = GetTargetGallery(_tabPageName);
            for (int i = 0; i < _gallery.Groups[0].Items.Count; i++)
            {
                if (_gallery.Groups[0].Items[i].Caption == _name)
                {
                    _gallery.Groups[0].Items.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
