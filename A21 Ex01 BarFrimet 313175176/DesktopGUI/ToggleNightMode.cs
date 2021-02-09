
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Ex02.DesktopGUI
{
    public class ToggleNightMode
    {
        private static bool m_ToggleNightModeIsOn = false;

        public static bool ToggleNightModeIsOn
        {
            get => m_ToggleNightModeIsOn;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void invokeModePropertyChanged()
        {
            if (PropertyChanged != null)
            {
                m_ToggleNightModeIsOn = !m_ToggleNightModeIsOn;
                PropertyChanged.Invoke(this, null);
            }
        }

        public static void ChangeObjectColor(object i_Object, Color i_RegularColor)
        {
            ChangeObjectColor(i_Object, i_RegularColor, Color.Black);
        }

        public static void ChangeObjectColor(object i_Object, Color i_RegularColor, Color i_NightColor)
        {
            Panel panel = i_Object as Panel;
            Button button = i_Object as Button;
            Form form = i_Object as Form;
            Color colorToChange = m_ToggleNightModeIsOn ? i_NightColor : i_RegularColor;

            if (panel != null)
            {
                panel.BackColor = colorToChange;
            }
            else if (button != null)
            {
                button.BackColor = colorToChange;
            }
            else if(form != null)
            {
                form.BackColor = colorToChange;
            }
        }
    }
}