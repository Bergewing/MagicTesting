using System;
using TheMagicFactory;
using System.Collections.Generic;

TreeTable treeTable = new TreeTable();
GlassTable glassTable = new GlassTable();
Material material = new Material();

List<IGetTable> getTables = new List<IGetTable>();    

treeTable.GetTable();
treeTable.GetTable();

glassTable.GetTable();
glassTable.GetTable();
glassTable.GetTable();


Console.WriteLine(getTables);


Console.WriteLine(material.GlassMaterial);


