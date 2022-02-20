namespace DocumentManagementSystem
{
    using Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using Utilities;

    public class FileChangeModel
    {
        [DisplayName("Name")]
        public String Name { get; set; }
        public String Path { get; set; }
        public FileOperationType operationType { get; set; }
        public String Input1 { get; set; }
        public String Input2 { get; set; }
        private String changeto;
        [DisplayName("Change To")]
        public String Changeto 
        { 
            get
            {
                if (String.IsNullOrEmpty(this.changeto))
                {
                    this.changeto = this.GetNewFileName();
                }
                return this.changeto;
            }
            set { this.changeto = value; }
        }

        private String GetNewFileName()
        {
            switch (this.operationType)
            {
                case FileOperationType.ExtentionChange:
                    return this.ExtentionChange();
                case FileOperationType.AddPrefix:
                    return this.AddPrefix();
                case FileOperationType.AddSubfix:
                    return this.AddSubfix();
                case FileOperationType.Removecharactersbeginning:
                    return this.Removecharactersbeginning();
                case FileOperationType.RemoveCharactersEnd:
                    return this.RemoveCharactersEnd();
                case FileOperationType.RemoveMatchingBeginning:
                    return this.RemoveMatchingBeginning();
                case FileOperationType.RemoveMatchingEnd:
                    return this.RemoveMatchingEnd();
                case FileOperationType.RemoveDoubleSpaces:
                    return this.RemoveDoubleSpaces();
                case FileOperationType.RemoveSpecifiedCharacters:
                    return this.RemoveSpecifiedCharacters();
                case FileOperationType.ReplaceWith:
                    return this.ReplaceWith();
                case FileOperationType.ConvertToLowercase:
                    return this.ConvertToLowercase();
                case FileOperationType.ConvertToUpercase:
                    return this.ConvertToUpercase();
                case FileOperationType.AppendFolderName:
                    return this.AppendFolderName();
                case FileOperationType.AppendDate:
                    return this.AppendDateToday();
                default:
                    break;
            }
            return this.Name;
        }

        /// <summary>
        /// Change file extension
        /// </summary>
        /// <returns>New file name</returns>
        private String ExtentionChange()
        {
            var index = this.Name.LastIndexOf('.');
            return this.Name.Substring(0, index + 1) + this.Input1;
        }

        /// <summary>
        /// Add Prefix
        /// </summary>
        /// <returns>New file name</returns>
        private String AddPrefix()
        {
            return $"{this.Input1}_{this.Name}";
        }

        /// <summary>
        /// Add Subfix
        /// </summary>
        /// <returns>New file name</returns>
        private String AddSubfix()
        {
            var index = this.Name.LastIndexOf('.');
            if (this.Input1.StartsWith("_"))
            {
                return this.Name.Insert(index, this.Input1);
            }
            return this.Name.Insert(index, $"_{this.Input1}");
        }

        /// <summary>
        /// Remove n characters from beginning of filename
        /// </summary>
        /// <returns>New file name</returns>
        private String Removecharactersbeginning()
        {
            Int32 n = 0;
            if (Int32.TryParse(this.Input1, out n))
            {
                var lastIndex = this.Name.IndexOf('.');
                if (n < lastIndex)
                {
                    return this.Name.Substring(n);
                }
            }
            return this.Name;
        }

        /// <summary>
        /// Remove n characters from end of filename
        /// </summary>
        /// <returns>New file name</returns>
        private String RemoveCharactersEnd()
        {
            Int32 n = 0;
            if (Int32.TryParse(this.Input1, out n))
            {
                var lastIndex = this.Name.IndexOf('.');
                if (n < lastIndex)
                {
                    return this.Name.Substring(0, lastIndex - n) + this.Name.Substring(lastIndex);
                }
            }
            return this.Name;
        }

        /// <summary>
        /// Remove matching string from beginning of filename
        /// </summary>
        /// <returns>New file name</returns>
        private String RemoveMatchingBeginning()
        {
            var index = this.Name.IndexOf(this.Input1);
            var lastIndex = this.Name.IndexOf('.');
            if (index != -1 && index < lastIndex)
            {
                return this.Name.Substring(0, index) + this.Name.Substring(index + this.Input1.Length);
            }
            return this.Name;
        }

        /// <summary>
        /// Remove matching string from end of filename
        /// </summary>
        /// <returns>New file name</returns>
        private String RemoveMatchingEnd()
        {
            var lastIndex = this.Name.IndexOf('.');
            var index = this.Name.LastIndexOf(this.Input1, lastIndex);
            if (index != -1)
            {
                return this.Name.Substring(0, index) + this.Name.Substring(index + this.Input1.Length);
            }
            return this.Name;
        }

        /// <summary>
        /// Remove double-spaces
        /// </summary>
        /// <returns>New file name</returns>
        private String RemoveDoubleSpaces()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.Name.Length; i++)
            {
                stringBuilder.Append(this.Name[i]);
                if (this.Name[i] == ' ')
                {
                    while (i < this.Name.Length - 1 && this.Name[i + 1] == ' ')
                    {
                        i++;
                    }
                }
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Remove characters belonging to a list
        /// </summary>
        /// <returns>New file name</returns>
        private String RemoveSpecifiedCharacters()
        {
            Dictionary<char, bool> dic = new Dictionary<char, bool>();
            for (int i = 0; i < this.Input1.Length; i++)
            {
                if (!dic.ContainsKey(this.Input1[i]))
                {
                    dic.Add(this.Input1[i], true);
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            var end = this.Name.LastIndexOf('.');
            for (int i = 0; i <= end; i++)
            {
                if (!dic.ContainsKey(this.Name[i]))
                {
                    stringBuilder.Append(this.Name[i]);
                }
            }
            while (end < this.Name.Length)
            {
                stringBuilder.Append(this.Name[end]);
                end++;
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Replace text in filename with other text
        /// </summary>
        /// <returns>New file name</returns>
        private String ReplaceWith()
        {
            var index = this.Name.LastIndexOf('.');
            if (index > this.Input1.Length)
            {
                var name = this.Name.Substring(0, index);
                var extention = this.Name.Substring(index);
                return name.Replace(this.Input1, this.Input2) + extention;
            }
            return this.Name;
        }

        /// <summary>
        /// Convert name to lower case
        /// </summary>
        /// <returns>New file name</returns>
        private String ConvertToLowercase()
        {
            var index = this.Name.LastIndexOf('.');
            return this.Name.Substring(0, index).ToLower() + this.Name.Substring(index);
        }

        /// <summary>
        /// Convert name to upper case
        /// </summary>
        /// <returns>New file name</returns>
        private String ConvertToUpercase()
        {
            var index = this.Name.LastIndexOf('.');
            return this.Name.Substring(0, index).ToUpper() + this.Name.Substring(index);
        }

        /// <summary>
        /// Append folder name to the file name
        /// </summary>
        /// <returns>New file name</returns>
        private String AppendFolderName()
        {
            FileInfo file = new FileInfo(this.Path);
            if (file.Exists)
            {
                var index = this.Name.LastIndexOf('.');
                return this.Name.Substring(0, index) + file.Directory.Name + this.Name.Substring(index);
            }
            return this.Name;
        }

        /// <summary>
        /// Append today's date to the file name
        /// </summary>
        /// <returns>New file name</returns>
        private String AppendDateToday()
        {
            FileInfo file = new FileInfo(this.Path);
            if (file.Exists)
            {
                var index = this.Name.LastIndexOf('.');
                return this.Name.Substring(0, index) + DateTime.Now.ToString(Constants.DATEPATERN) + this.Name.Substring(index);
            }
            return this.Name;
        }
    }
}
