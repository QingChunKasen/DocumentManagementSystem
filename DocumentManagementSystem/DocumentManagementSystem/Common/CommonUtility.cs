namespace DocumentManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CommonUtility
    {
        public static string GetFileIcon(string filePath, bool isFolder)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            if (isFolder)
            {
                return @"Icon\DocumentType\folder.png";
            }

            switch (extension)
            {
                case ".pdf":
                    return @"Icon\DocumentType\pdf.png";
                case ".msg":
                case ".oft":
                    return @"Icon\DocumentType\email.png";
                case ".doc":
                case ".docx":
                    return @"Icon\DocumentType\word.png";
                case ".xls":
                case ".xlsx":
                    return @"Icon\DocumentType\excel.png";
                case ".ppt":
                case ".pptx":
                    return @"Icon\DocumentType\ppt.png";
                case ".txt":
                    return @"Icon\DocumentType\txt.png";
                default:
                    return @"Icon\DocumentType\file.png";
            }
        }

    }
}
