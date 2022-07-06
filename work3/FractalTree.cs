using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    public class FractalTree
    {
        public struct TreeNode
        {
            public TreeNode[] children;
            public Point[] vertexes;
            public Point centerCoordinates;

            public TreeNode(Point coordinates)
            {
                this.centerCoordinates = coordinates;
                children = new TreeNode[6];
                vertexes = new Point[6];
            }
        }

        public TreeNode root;

        public FractalTree(Point initialCoordinates)
        {
            root = new TreeNode(initialCoordinates);
        }
    }
}
