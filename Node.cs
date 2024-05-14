using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Node
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public List<Node> Children { get; set; } = new List<Node>();


        public List<Node> BuildTree(List<Node> list)
        {
            var result = new List<Node>();
            if (list == null || list.Count == 0)
            {
                return list;
            }

            Queue<Node> queue = new Queue<Node>(list);
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node.ParentId != "")//非根节点
                {
                    var parent = list.First(t => t.Id == node.ParentId);
                    parent.Children.Add(node);
                }
                else//根节点
                {
                    result.Add(node);
                }
            }
            return result;
        }

        public List<Node> DebuildTree(List<Node> tree)
        {
            var result = new List<Node>();
            if (tree==null || !tree.Any())
            {
                return result;
            }
            Stack<Node> stack = new Stack<Node>(tree);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.Children.Any())
                {
                    foreach (var item in node.Children)
                    {
                        stack.Push(item);
                    }
                }
                node.Children = new List<Node>();
                result.Add(node);
            }
            return result;
        }
    }


    
}



