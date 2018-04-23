using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraTab;

namespace Q445945 {
    [UserRepositoryItem("RegisterAnotherColorPickEdit")]
    public class RepositoryItemAnotherColorPickEdit : RepositoryItemColorPickEdit {
        static RepositoryItemAnotherColorPickEdit() {
            RegisterAnotherColorPickEdit();
        }
        public const string CustomEditName = "AnotherColorPickEdit";
        public RepositoryItemAnotherColorPickEdit() { }
        public override string EditorTypeName { get { return CustomEditName; } }
        public static void RegisterAnotherColorPickEdit() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(AnotherColorPickEdit), typeof(RepositoryItemAnotherColorPickEdit), typeof(ColorEditViewInfo), new ColorEditPainter(), true, img));
        }
    }

    [ToolboxItem(true)]
    public class AnotherColorPickEdit : ColorPickEdit {
        static AnotherColorPickEdit() {
            RepositoryItemAnotherColorPickEdit.RegisterAnotherColorPickEdit();
        }

        public AnotherColorPickEdit() { }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemAnotherColorPickEdit Properties {
            get { return base.Properties as RepositoryItemAnotherColorPickEdit; }
        }

        public override string EditorTypeName {
            get { return RepositoryItemAnotherColorPickEdit.CustomEditName; }
        }

        public void RemoveColorsByNames(string pageName, List<string> colorNames) {
            foreach (string name in colorNames)
                RemoveColorByName(pageName, name);
        }

        public void RemoveColorByName(string pageName, string colorName) {
            PopupColorPickEditForm frm = GetPopupForm() as PopupColorPickEditForm;
            XtraTabControl tabs = frm.Controls.OfType<XtraTabControl>().FirstOrDefault();
            if (tabs != null) {
                XtraTabPage page = tabs.TabPages.Where(pg => pg.Text == pageName).FirstOrDefault() as XtraTabPage;
                if (page != null) {
                    InnerColorListControl colorList = page.Controls.OfType<InnerColorListControl>().FirstOrDefault();
                    if (colorList != null) {
                        ColorItem item = colorList.Colors.OfType<ColorItem>().Where(c => c.Color == Color.FromName(colorName)).FirstOrDefault();
                        colorList.Colors.Remove(item);
                    }
                }
            }
        }
    }
}
