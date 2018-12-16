using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace LibraryResource
{
    /// <summary>
    /// Выполните шаги 1a или 1b, а затем 2, чтобы использовать этот настраиваемый элемент управления в файле XAML.
    ///
    /// Шаг 1a. Использование настраиваемого элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace к корневому элементу файла разметки, где он 
    /// должен использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:LibraryResource"
    ///
    ///
    /// Шаг 1b. Использование этого настраиваемого элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace к корневому элементу файла разметки, где он 
    /// должен использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:LibraryResource;assembly=LibraryResource"
    ///
    /// Потребуется также добавить ссылку на проект из проекта, в котором находится файл XAML
    /// в данный проект и пересобрать во избежание ошибок компиляции:
    ///
    ///     Правой кнопкой мыши щелкните проект в обозревателе решений и выберите команду
    ///     "Добавить ссылку"->"Проекты"->[Выберите этот проект]
    ///
    ///
    /// Шаг 2)
    /// Продолжайте дальше и используйте элемент управления в файле XAML.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>
    public class CustomResources : Control
    {
        static CustomResources()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomResources), new FrameworkPropertyMetadata(typeof(CustomResources)));
        }
        // Статические поля (для разнообразия)
        public static readonly ComponentResourceKey Title1Key =
            new ComponentResourceKey(typeof(CustomResources), "Title1");
        public static readonly ComponentResourceKey Title2Key =
            new ComponentResourceKey(typeof(CustomResources), "Title2");

        // Добавили флаг для регулирования извлечения в элементах разметки
        public static bool changeResourceKeyFlag = true;

        // Добавляем статические свойства
        public static ComponentResourceKey ForegroundBrushKey
        {
            get
            {
                if (changeResourceKeyFlag)
                    return new ComponentResourceKey(
                        typeof(CustomResources), "ForegroundBrush1");
                else
                    return new ComponentResourceKey(
                        typeof(CustomResources), "ForegroundBrush2");
            }
        }

        public static ComponentResourceKey BackgroundBrushKey
        {
            get
            {
                if (changeResourceKeyFlag)
                    return new ComponentResourceKey(
                        typeof(CustomResources), "BackgroundBrush1");
                else
                    return new ComponentResourceKey(
                        typeof(CustomResources), "BackgroundBrush2");
            }
        }

    }
}
