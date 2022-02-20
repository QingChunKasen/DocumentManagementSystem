namespace DocumentManagementSystem
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    public class ItemModel
    {
        public Image Icon { get { return Image.FromFile($@"{AppDomain.CurrentDomain.BaseDirectory}{CommonUtility.GetFileIcon(Path, IsFolder)}"); }}
        [DisplayName("Name")]
        public String Name { get; set; }
        [DisplayName("Path")]
        public String Path { get; set; }
        [DisplayName("Created By")]
        public String CreatedBy { get; set; }
        [DisplayName("Created Time")]
        public DateTime CreatedTime { get; set; }
        [DisplayName("Size")]
        public String Size { get; set; }
        public bool IsFolder { get; set; }
    }
}
