using EnvDTE;
using Microsoft.AspNet.Scaffolding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSIX
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dte = EnvDTEHelper.GetActiveInstance();

            //SelectedItem s = null;
            //foreach (var item in dte.SelectedItems)
            //{
            //    s = (SelectedItem)item;
            //}
            //var projectItem = s.ProjectItem;
            //var project = projectItem.ContainingProject;
            //string rootProjectDir = project.GetFullPath();
            //string fullPath = projectItem.GetFullPath();
            //Console.WriteLine(rootProjectDir);
            //Console.WriteLine(fullPath);
            //Console.WriteLine("------------------------------");
            //Console.WriteLine(project.Name);
            //Console.WriteLine(project.FullName);
            //Console.WriteLine(project.FileName);
            //Console.WriteLine(projectItem.Name);

            // var solu = dte.Solution;
            //Console.WriteLine(solu.FileName);
            //Console.WriteLine(solu.Projects.Count);
            //foreach (var item in solu.Projects)
            //{
            //    var pro = ((Project)item);
            //    //Console.WriteLine(((Project)item).Name);
            //    Console.WriteLine(((Project)item).FileName);
            //    //Console.WriteLine(pro.GetFullPath());
            //     Console.WriteLine(pro.Kind);
            //}

            //var dll = solu.Projects.Cast<Project>().Single(p => p.Name == "ClassLibrary1");
            // solu.Remove(dll);
            //var dll = solu.Projects.Cast<Project>().Single(p => p.Name == "new.cs"); 
            //dll.Save("VSIX");

            //solu.AddFromFile("OOOO");


            //var templatePath = Path.Combine("MvcControllerWithContext", "Controller");
            //Console.WriteLine(templatePath);

            var dte = EnvDTEHelper.GetActiveInstance();
            var solu = dte.Solution;
            var bll = solu.Projects.Cast<Project>().SingleOrDefault(p => p.Name == "BLL");
            var main = solu.Projects.Cast<Project>().SingleOrDefault(p => p.Name == "VSIX");

            Console.WriteLine("解决方案proj");
            var ps = solu.Projects.Cast<Project>().ToList();    
            foreach (var item in ps)
            {
                Console.WriteLine(item.Name);
            }
            //var item = main.ProjectItems.Cast<ProjectItem>().Single(p => p.Name == "MM.cs");
            //bll.ProjectItems.AddFromFileCopy(item.GetFullPath());
            //item.Remove();

            Console.WriteLine("main下的proj");
            foreach (var item in main.Collection.Cast<Project>())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("main-BLL下的item");
            var mb = main.Collection.Cast<Project>().Single(p => p.Name == "BLL");
            //mb.ProjectItems.AddFolder("DTO");
            //var file = mb.ProjectItems.Cast<ProjectItem>().Single(p => p.Name == "MM.cs");
            //var fold = mb.ProjectItems.Cast<ProjectItem>().Single(p => p.Name == "DTO");
            //fold.ProjectItems.AddFromFileCopy(file.GetFullPath());
            //file.Remove();
            foreach (var item in mb.ProjectItems.Cast<ProjectItem>())
            {
                Console.WriteLine(item.Name);
            }

            var f233 = solu.Projects.Cast<Project>().SingleOrDefault(p => p.Name == "23333");
            Console.WriteLine("f233下的proj");
            if (f233.Collection != null)
            {
                foreach (var item in f233.Collection.Cast<Project>())
                {
                    Console.WriteLine(item.Name);
                } 
            }



            Console.WriteLine("f233下的item");
            foreach (var item in f233.ProjectItems.Cast<ProjectItem>())
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("-----------------main下的code--------------------");

            var code = mb.CodeModel.CodeElements;
            foreach (var item in code.OfType<CodeElement>())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
