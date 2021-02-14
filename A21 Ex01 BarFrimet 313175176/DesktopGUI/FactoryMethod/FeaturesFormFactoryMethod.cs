using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex03.DesktopGUI
{
    public class FeaturesFormFactoryMethod
    {
        private const int k_HeightOfButton = 60;
        private static readonly Color sr_ButtonRegularColor = System.Drawing.SystemColors.ActiveCaption;
        private static readonly Color sr_DarkButtonColor = Color.DarkGray;
        private static readonly List<Button> sr_ListButton = new List<Button>();
        private static readonly HashSet<string> sr_FeatureFormSet = new HashSet<string>() { "The Mirror", "The Best Fan" };

        public static HashSet<string> FeatureFormSet => sr_FeatureFormSet;

        public static Form CreateFeatureForm(string i_FeatureFormToCreate, ToggleNightMode i_ToggleNightMode)
        {
            Form formToCreate = new Form();

            if (sr_FeatureFormSet.Contains(i_FeatureFormToCreate))
            {
                switch (i_FeatureFormToCreate)
                {
                    case "The Best Fan":
                        formToCreate = new BestFanForm(i_ToggleNightMode);
                        break;
                    case "The Mirror":
                        formToCreate = new MirrorForm(i_ToggleNightMode);
                        break;
                }
            }
            else
            {
                throw new Exception("There is no feature form in this name");
            }

            return formToCreate;
        }

        public static void CreateFeaturesButtonsOnPanel(IFeaturesControls i_FeaturesControls, Panel i_DisplaySubPanel, ToggleNightMode i_ToggleNightMode)
        {
            int counter = 1;

            i_DisplaySubPanel.Size = new System.Drawing.Size(250, sr_FeatureFormSet.Count * k_HeightOfButton);
            foreach (string formName in sr_FeatureFormSet)
            {
                Button newButton = new Button();
                // Details button start
                newButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                newButton.Dock = System.Windows.Forms.DockStyle.Top;
                newButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
                newButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
                newButton.Location = new System.Drawing.Point(0, counter * k_HeightOfButton);
                newButton.Name = formName;
                newButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
                newButton.Size = new System.Drawing.Size(250, 60);
                newButton.TabIndex = 8;
                newButton.Text = formName;
                newButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                newButton.UseVisualStyleBackColor = true;
                i_DisplaySubPanel.Controls.Add(newButton);
                // Details button end
                // Add new event on click
                newButton.Click += new EventHandler(i_FeaturesControls.SomeFeaturesButton_Click);
                sr_ListButton.Add(newButton);
            }

            i_ToggleNightMode.PropertyChanged += changeViewMode;
        }

        private static void changeViewMode(object sender, PropertyChangedEventArgs e)
        {
            foreach (Button button in sr_ListButton)
            {
                ToggleNightMode.ChangeObjectColor(button, sr_ButtonRegularColor, sr_DarkButtonColor);
            }
        }
    }
}
