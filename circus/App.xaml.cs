using circus.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Application = System.Windows.Application;

namespace circus
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User currentUser;
        public static DB.Task selectedTask;
        public static int GoEdit = 0;
        public static ListPerformance selectedPerformance;
        public static DB.Application selectedApplication;
    }
}
