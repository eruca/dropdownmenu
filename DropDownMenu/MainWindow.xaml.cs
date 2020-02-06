using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;
using DropDownMenu.ViewModel;
using DropDownMenu.Models;
using System.Linq;

namespace DropDownMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>
            {
                new SubItem("客户", new UserControlCustomers()),
                new SubItem("供应商", new UserControlProviders()),
                new SubItem("员工"),
                new SubItem("产品"),
            };
            var register = new ItemMenu("登记", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>
           {
               new SubItem("服务"),
               new SubItem("会议"),
           };
            var schedule = new ItemMenu("预约", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>
            {
                new SubItem("客户"),
                new SubItem("供应商"),
                new SubItem("产品"),
                new SubItem("库存"),
                new SubItem("销售额"),
            };
            var reports = new ItemMenu("报告", menuReports, PackIconKind.FileReport);

            var menuExpenses = new List<SubItem>
            {
                new SubItem("固定资产"),
                new SubItem("流动资金"),
            };
            var expenses = new ItemMenu("费用", menuExpenses, PackIconKind.ShoppingBasket);

            var menuFinancial = new List<SubItem> { 
                new SubItem("现金流"),
            };
            var financial = new ItemMenu("财务", menuFinancial, PackIconKind.ScaleBalance);

            Menu.Children.Add(new UserControlMenuItem(register, this));
            Menu.Children.Add(new UserControlMenuItem(schedule, this));
            Menu.Children.Add(new UserControlMenuItem(expenses, this));
            Menu.Children.Add(new UserControlMenuItem(reports, this));
            Menu.Children.Add(new UserControlMenuItem(financial, this));


            using(var db = new Db())
            {
                //var human = new Human()
                //{
                //    IsMale = true,
                //    Name = "Name",
                //    Addresses = "浙江温州",
                //    Phones="10086",
                //    Ethnic="汉族"
                //};

                //db.Humen.Add(human);
                //var result = db.SaveChanges();
                var result = db.Humen.OrderBy(b => b.ID).First();
                MessageBox.Show(result.Name + result.Addresses);
            }
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);
            if (screen == null)
            {
                return;
            }
            
            StackPanelMain.Children.Clear();
            StackPanelMain.Children.Add(screen);
        }
    }
}
