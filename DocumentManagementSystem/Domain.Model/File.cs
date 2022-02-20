namespace Domain.Model
{
    using System;
    public class LocalFile
    {
        public String Name { get; set; }
        public String Path { get; set; }
        public String CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public long Size { get; set; }
        public String Extention { get; set; }
        public String NewFileName { get; set; }
    }
}
