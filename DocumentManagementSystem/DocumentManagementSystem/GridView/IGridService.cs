namespace DocumentManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    public interface IGridService
    {
        void InitGrid(DataGridView grid);
        void GridShow(DataGridView grid, string fullPath);
        List<ItemModel> GetSelectedFiles(DataGridView grid);
        List<ItemModel> GridSearch(string location, string key);
        List<ItemModel> Sort(string location, String key, int columnIndex, SortOrder order);
    }
}
