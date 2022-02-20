namespace DocumentManagementSystem
{
    using Domain.Service.Interface;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Utilities;

    internal class GridService : IGridService
    {
        private readonly IFileManager fileManager;
        private static readonly Logger logger = new Logger(typeof(GridService));

        public GridService(IFileManager fileManager)
        {
            this.fileManager = fileManager;
        }

        public void InitGrid(DataGridView grid)
        {
            var fileList = new List<ItemModel>();
            grid.DataSource = fileList;
            grid.Columns["Path"].Visible = false;
            grid.Columns["Name"].Width = 150; //RowHeaderMouseClick
            grid.Columns["CreatedBy"].Width = 150;
            grid.Columns["CreatedTime"].Width = 130;
            grid.Columns["IsFolder"].Visible = false;
        }

        public void GridShow(DataGridView grid, string fullPath)
        {
            var fileList = new List<ItemModel>();
            if (fullPath != Constants.ThisPC)
            {
                var folders = this.fileManager.GetFolders(fullPath);
                foreach (var folder in folders)
                {
                    fileList.Add(new ItemModel
                    {
                        Name = folder.Name,
                        Path = folder.Path,
                        CreatedTime = folder.CreatedTime,
                        IsFolder = true
                    });
                }

                var files = this.fileManager.GetFiles(fullPath);
                foreach (var file in files)
                {
                    fileList.Add(new ItemModel
                    {
                        Name = file.Name,
                        Path = file.Path,
                        CreatedBy = file.CreatedBy,
                        CreatedTime = file.CreatedTime,
                        Size = $"{Math.Ceiling(file.Size / 1024.0)} KB"
                    });
                }
            }
            grid.DataSource = fileList;
        }

        public List<ItemModel> GetSelectedFiles(DataGridView grid)
        {
            var result = new List<ItemModel>();
            try
            {
                logger.Info("Begin to get selected files from grid.");
                var dataSource = grid.DataSource as List<ItemModel>;
                foreach(DataGridViewRow row  in grid.SelectedRows)
                {
                    var selectedItem = dataSource[row.Index];
                    if(!selectedItem.IsFolder)
                    {
                        result.Add(selectedItem);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when gettting selected files from grid. Reason: {ex}.");
            }
            return result;
        }

        public List<ItemModel> GridSearch(string location, string key)
        {
            var result = new List<ItemModel>();
            try
            {
                logger.Info($"Begin to filter items from grid, Key: {key}.");
                if (location != Constants.ThisPC)
                {
                    var folders = this.fileManager.GetFolders(location);
                    foreach (var folder in folders)
                    {
                        if (MatchKey(folder.Name, key))
                        {
                            result.Add(new ItemModel
                            {
                                Name = folder.Name,
                                Path = folder.Path,
                                IsFolder = true
                            });
                        }
                    }

                    var files = this.fileManager.GetFiles(location);
                    foreach (var file in files)
                    {
                        if (MatchKey(file.Name, key))
                        {
                            result.Add(new ItemModel
                            {
                                Name = file.Name,
                                Path = file.Path,
                                CreatedBy = file.CreatedBy,
                                CreatedTime = file.CreatedTime,
                                Size = $"{Math.Ceiling(file.Size / 1024.0)} KB"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when gettting selected files from grid. Reason: {ex}.");
            }
            return result;
        }

        private bool MatchKey(String name, String key)
        {
            try
            {
                if (String.IsNullOrEmpty(key))
                {
                    return true;
                }
                var index = name.LastIndexOf('.');
                var prename = name.Substring(0, index);
                if (prename.Contains(key)
                    || name.Contains(key)
                    || Regex.IsMatch(prename, key)
                    || Regex.IsMatch(name, key))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when filter file: {name}. Reason: {ex}.");
            }
            return false;
        }

        public List<ItemModel> Sort(string location, String key, int columnIndex, SortOrder order)
        {
            var result = new List<ItemModel>();
            try
            {
                logger.Info($"Begin to sort items from grid.");
                result = this.GridSearch(location, key);
                if (columnIndex == 1)
                {
                    result.Sort((o1, o2) =>
                    {
                        if (order == SortOrder.Ascending)
                        {
                            return o1.Name.CompareTo(o2.Name);
                        }
                        else
                        {
                            return o2.Name.CompareTo(o1.Name);
                        }
                    });
                }
                else if(columnIndex == 4)
                {
                    result.Sort((o1, o2) =>
                    {
                        if (order == SortOrder.Ascending)
                        {
                            return o1.CreatedTime.CompareTo(o2.CreatedTime);
                        }
                        else
                        {
                            return o2.CreatedTime.CompareTo(o1.CreatedTime);
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when gettting selected files from grid. Reason: {ex}.");
            }
            return result;
        }
    }
}
