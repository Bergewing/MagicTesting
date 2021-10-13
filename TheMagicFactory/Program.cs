using System;
using TheMagicFactory;
using System.Collections.Generic;

var treeTable = new TreeTable();
GlassTable glassTable = new GlassTable();
Material material = new Material();

treeTable.GetTable();
treeTable.GetTable();

glassTable.GetTable();
glassTable.GetTable();
glassTable.GetTable();

List<IGetTable> getTables = new List<IGetTable>() { treeTable };

foreach (var item in getTables)
{
    Console.WriteLine(item.GetTable());
}

Console.WriteLine(material.GlassMaterial);


