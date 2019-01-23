﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KibaCustomControl
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:KibaCustomControl"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:KibaCustomControl;assembly=KibaCustomControl"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class KibaDateTime : TextBox
    {
        private static Regex regex = new Regex("[0-9]+");
        #region 小时
        public static readonly DependencyProperty HourProperty = DependencyProperty.Register(
             "Hour", typeof(int), typeof(KibaDateTime), new FrameworkPropertyMetadata(00));
       
        public int Hour
        {
            get
            {
                return (int)GetValue(HourProperty);
            }
            set
            {
                SetValue(HourProperty, value);
            }
        } 
        #endregion
        #region 分钟
        public static readonly DependencyProperty MinuteProperty = DependencyProperty.Register(
             "Minute", typeof(int), typeof(KibaDateTime), new FrameworkPropertyMetadata(00));
        
        public int Minute
        {
            get
            {
                return (int)GetValue(MinuteProperty);
            }
            set
            {
                SetValue(MinuteProperty, value);
            }
        }
        #endregion
        #region 秒
        public static readonly DependencyProperty SecondProperty = DependencyProperty.Register(
             "Second", typeof(int), typeof(KibaDateTime), new FrameworkPropertyMetadata(00)); 
        public int Second
        {
            get
            {
                return (int)GetValue(SecondProperty);
            }
            set
            {
                SetValue(SecondProperty, value);
            }
        }
        #endregion
        static KibaDateTime()
        {
            //当此依赖项属性位于指定类型的实例上时为其指定替换元数据，以在该依赖项属性继承自基类型时重写该属性已存在的元数据。
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KibaDateTime), new FrameworkPropertyMetadata(typeof(KibaDateTime))); 
        }
    }
}
