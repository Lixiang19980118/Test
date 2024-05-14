// See https://aka.ms/new-console-template for more information
using Test;

Console.WriteLine("Hello, World!");


List<Node> nodes = new List<Node>();
nodes.Add(new Node()
{
    Id = "001",
    ParentId=""
});
nodes.Add(new Node()
{
    Id = "002",
    ParentId = ""
});
nodes.Add(new Node()
{
    Id = "001-1",
    ParentId = "001"
});
nodes.Add(new Node()
{
    Id = "001-2",
    ParentId = "001"
});
nodes.Add(new Node()
{
    Id = "001-1-1",
    ParentId = "001-1"
});
nodes.Add(new Node()
{
    Id = "001-1-2",
    ParentId = "001-1"
});

nodes.Add(new Node()
{
    Id = "002-1",
    ParentId = "002"
});
nodes.Add(new Node()
{
    Id = "002-2",
    ParentId = "002"
});


var node = new Node();
var temp = node.BuildTree(nodes);
var dNodes = node.DebuildTree(temp);
Console.WriteLine("============");