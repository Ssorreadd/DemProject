using System.Windows.Media;
using System.Windows.Controls;

namespace Project
{
    internal static class BoxesManager
    {
        internal static void CheckForDefaultBoxes(object sender, object grid, TextBoxInfo[] boxes)
        {
            //string boxesNames = "EmailBox PasswordBox FirstNameBox SecondNameBox";

            foreach (object item in ((Grid)grid).Children)
            {
                if (sender is ComboBox && item is TextBox || sender is PasswordBox && item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)item).Text))
                    {
                        SetDefaultBoxesNames(boxes, item);
                    }

                }
                else if (item is TextBox && ((TextBox)item).Name != ((TextBox)sender).Name && string.IsNullOrWhiteSpace(((TextBox)item).Text))
                {
                    SetDefaultBoxesNames(boxes, item);
                }
            }
        }

        private static void SetDefaultBoxesNames(TextBoxInfo[] boxes, object item)
        {
            foreach (TextBoxInfo box in boxes)
            {
                if (((TextBox)item).Name.Equals(box.Name))
                {
                    ((TextBox)item).Text = box.DefaultValue;
                    ((TextBox)item).Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#60AA4030"));

                    break;
                }
            }
        }

    }
}
