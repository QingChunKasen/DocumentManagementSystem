namespace DocumentManagementSystem
{
    using Domain.Service.Interface;
    using System.IO;
    using System.Windows.Forms;
    using Utilities;

    public class TreeService : ITreeService
    {
        private readonly IFileManager fileManager;

        public TreeService(IFileManager fileManager)
        {
            this.fileManager = fileManager;
        }

        /// <summary>
        /// Initialize the root node and disk
        /// </summary>
        /// <param name="treeNodeCollection"></param>
        public void InitTree(TreeNodeCollection treeNodeCollection)
        {
            var rootNode = treeNodeCollection.Add(Constants.ThisPC);
            rootNode.Name = Constants.ThisPC;
            rootNode.ImageKey = Constants.ThisPCImageKey;
            rootNode.SelectedImageKey = Constants.ThisPCImageKey;
        }

        public void LoadChildren(TreeNode node)
        {
            node.Nodes.Clear();
            if (node.Name == Constants.ThisPC)
            {
                InitDrive(node);
            }
            else
            {
                var fullPath = node.FullPath.Substring(8);
                var folders = this.fileManager.GetFolders(fullPath);
                foreach (var folder in folders)
                {
                    TreeNode folderNode = node.Nodes.Add(folder.Name);
                    folderNode.ImageKey = Constants.FolderImageKey;
                    folderNode.SelectedImageKey = Constants.FolderImageKey;
                }
            }
            node.Expand();
        }

        private void InitDrive(TreeNode node)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                TreeNode childNode = new TreeNode(d.RootDirectory.FullName);
                childNode.Name = d.Name;
                childNode.ImageKey = Constants.DriveImageKey;
                childNode.SelectedImageKey = Constants.DriveImageKey;
                node.Nodes.Add(childNode);
            }
        }
    }
}
