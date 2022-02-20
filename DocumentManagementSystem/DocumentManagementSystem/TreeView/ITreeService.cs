using Domain.Service.Interface;
using System.Windows.Forms;

namespace DocumentManagementSystem
{
    public interface ITreeService
    {
        void InitTree(TreeNodeCollection treeNodeCollection);
        void LoadChildren(TreeNode node);
    }
}
