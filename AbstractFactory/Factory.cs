﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Factory
{
    public abstract class Factory
    {
        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);

        public static Factory GetFactory(string classname)
        {
            Factory factory = null;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();

                factory = (Factory)assembly.CreateInstance(classname, false, BindingFlags.CreateInstance, null, null, null, null);
            }
            catch (TypeLoadException)
            {
                Console.Error.WriteLine($"クラス{ classname}が見つかりません。");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.StackTrace);
            }
            return factory;
        }
    }
}
