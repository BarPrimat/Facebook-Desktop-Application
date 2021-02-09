using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DesktopGUI;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Ex02.DesktopGUI
{
    public sealed partial class MainMenuForm : Form, IFeaturesControls
    {
        private static readonly Size sr_SizeOfSelectSubPanel = new Size(7, 60);
        private static readonly Color sr_LeftPanelColor = Color.Aquamarine;
        private static readonly Color sr_LeftSubPanelColor = Color.DodgerBlue;
        private static readonly Color sr_PanelAndButtonRegularColor = Color.FromArgb(105, 128, 168);
        private Form m_ActionForm;
        private readonly Panel r_LeftBorderPanelForButton;
        private Button m_CurrentButton;
        private readonly Panel r_LeftBorderPanelForSubButton;
        private bool m_IsFirstOpenForm = true;
        private ToggleNightMode r_ToggleNightMode;

        public MainMenuForm()
        {
            InitializeComponent();
            r_LeftBorderPanelForButton = new Panel();
            r_LeftBorderPanelForSubButton = new Panel();
            r_ToggleNightMode = new ToggleNightMode();
            r_LeftBorderPanelForButton.Size = sr_SizeOfSelectSubPanel;
            r_LeftBorderPanelForSubButton.Size = sr_SizeOfSelectSubPanel;
            panelSideMenu.Controls.Add(r_LeftBorderPanelForButton);
            displaySubPanel.Controls.Add(r_LeftBorderPanelForSubButton);
            // Create all features buttons on the panel (The number of buttons depends on the number of features that exist)
            FeaturesFormFactoryMethod.CreateFeaturesButtonsOnPanel(this, displaySubPanel, r_ToggleNightMode);
            initFirstMenu();
            r_ToggleNightMode.PropertyChanged += toggleToNightMode;
        }

        private void activateButton(object i_Sender, Color i_Color)
        {
            Button newCurrentButton = i_Sender as Button;

            if (newCurrentButton != null && newCurrentButton != m_CurrentButton)
            {
                disableButton();
                m_CurrentButton = newCurrentButton;
                // Button change
                m_CurrentButton.ForeColor = i_Color;
                m_CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                // Left border
                if (displaySubPanel.Visible)
                {
                    ToggleNightMode.ChangeObjectColor(r_LeftBorderPanelForSubButton, i_Color);
                    r_LeftBorderPanelForSubButton.Location = new Point(0, m_CurrentButton.Location.Y);
                    r_LeftBorderPanelForSubButton.Visible = true;
                    r_LeftBorderPanelForSubButton.BringToFront();
                }
                else
                {
                    r_LeftBorderPanelForButton.BackColor = i_Color;
                    r_LeftBorderPanelForButton.Location = new Point(0, m_CurrentButton.Location.Y);
                    r_LeftBorderPanelForButton.Visible = true;
                    r_LeftBorderPanelForButton.BringToFront();
                }
            }
        }

        private void disableButton()
        {
            if(m_CurrentButton != null)
            {
                m_CurrentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
                m_CurrentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
        }

        private void initFirstMenu()
        { 
            displaySubPanel.Visible = false;
            activateButton(homeButton, sr_LeftPanelColor);
            homeButton_Click(null, EventArgs.Empty);
        }

        private void openChildForm(Form i_ChildForm)
        {
            if(m_IsFirstOpenForm || i_ChildForm.Name != m_ActionForm.Name)
            {
                m_ActionForm?.Close();
                m_ActionForm = i_ChildForm;
                i_ChildForm.TopLevel = false;
                i_ChildForm.FormBorderStyle = FormBorderStyle.None;
                i_ChildForm.Dock = DockStyle.Fill;
                mainFillPanel.Controls.Add(i_ChildForm);
                mainFillPanel.Tag = i_ChildForm;
                i_ChildForm.BringToFront();
                i_ChildForm.Show();
                m_IsFirstOpenForm = false;
            }
        }

        private void hideSubMenu()
        {
            if (displaySubPanel.Visible)
            {
                displaySubPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel i_SubMenu)
        {
            if(!i_SubMenu.Visible)
            {
                hideSubMenu();
                i_SubMenu.Visible = true;
            }
            else
            {
                i_SubMenu.Visible = false;
            }

            r_LeftBorderPanelForSubButton.Visible = false;
        }

        private void activeButtonAndHideSubMenu(object i_Sender, Color i_Color)
        {
            hideSubMenu();
            activateButton(i_Sender, i_Color);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, sr_LeftPanelColor);
            openChildForm(new HomeForm(this, r_ToggleNightMode));
        }


        private void facebookPictureBox_Click(object sender, EventArgs e)
        {
            homeButton_Click(homeButton, EventArgs.Empty);
        }

        private void albumButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, sr_LeftPanelColor);
            openChildForm(new AlbumForm(r_ToggleNightMode));
        }

        private void featuresButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, sr_LeftPanelColor);
            showSubMenu(displaySubPanel);
        }

        // Start sub menu of Features button
        public void SomeFeaturesButton_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            Form newForm = FeaturesFormFactoryMethod.CreateFeatureForm(currentButton.Name, r_ToggleNightMode);

            activateButton(sender, sr_LeftSubPanelColor);
            openChildForm(newForm);
        }

        // End sub menu of Features button

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toggleToNightMode(object sender, PropertyChangedEventArgs e)
        {
            ToggleNightMode.ChangeObjectColor(panelSideMenu, sr_PanelAndButtonRegularColor);
            ToggleNightMode.ChangeObjectColor(homeButton, sr_PanelAndButtonRegularColor);
            ToggleNightMode.ChangeObjectColor(albumButton, sr_PanelAndButtonRegularColor);
            ToggleNightMode.ChangeObjectColor(featuresButton, sr_PanelAndButtonRegularColor);
            ToggleNightMode.ChangeObjectColor(exitButton, sr_PanelAndButtonRegularColor);
            ToggleNightMode.ChangeObjectColor(mainDownPanel, SystemColors.GradientActiveCaption, Color.DarkCyan);
            ToggleNightMode.ChangeObjectColor(logoPanel, SystemColors.GradientActiveCaption);
        }

        private void NightModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            r_ToggleNightMode.invokeModePropertyChanged();
        }
    }
}