using System;
using System.Windows.Forms;

namespace JokeTaskDialogCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskDialogIcon dialogIcon;
            switch (comboBox1.SelectedIndex) // もう少しスマートな実装ないのかなあ、ここ……
            {
                case 0: //なし
                    dialogIcon = TaskDialogIcon.None;
                    break;
                case 1:
                    dialogIcon = TaskDialogIcon.Information;
                    break;
                case 2:
                    dialogIcon = TaskDialogIcon.Warning;
                    break;
                case 3:
                    dialogIcon = TaskDialogIcon.Error;
                    break;
                case 4:
                    dialogIcon = TaskDialogIcon.Shield;
                    break;
                case 5:
                    dialogIcon = TaskDialogIcon.ShieldBlueBar;
                    break;
                case 6:
                    dialogIcon = TaskDialogIcon.ShieldGrayBar;
                    break;
                case 7:
                    dialogIcon = TaskDialogIcon.ShieldErrorRedBar;
                    break;
                case 8:
                    dialogIcon = TaskDialogIcon.ShieldWarningYellowBar;
                    break;
                case 9:
                    dialogIcon = TaskDialogIcon.ShieldSuccessGreenBar;
                    break;
                default: //呼ばれることはないと思うけど一応
                    dialogIcon = TaskDialogIcon.None;
                    break;
            }

            TaskDialog.ShowDialog(this, new TaskDialogPage()
            {
                Text = s_messageText.Text == "" ? "Hello, World!" : s_messageText.Text,
                Heading = s_messageHeading.Text == "" ? "Hello, World!" : s_messageHeading.Text,
                Caption = s_messageCaption.Text == "" ? "JokeTaskDialogCreator" : s_messageCaption.Text,
                Buttons = {
                    new TaskDialogCommandLinkButton(s_choice1text.Text == "" ? "選択肢1" : s_choice1text.Text){ ShowShieldIcon = b_1stchoiceUAC.Checked, DescriptionText = s_choice1desc.Text == "" ? s_choice1desc.PlaceholderText : s_choice1desc.Text},
                    new TaskDialogCommandLinkButton(s_choice2text.Text == "" ? "選択肢2" : s_choice2text.Text){ ShowShieldIcon = b_2ndchoiceUAC.Checked, DescriptionText = s_choice2desc.Text == "" ? s_choice2desc.PlaceholderText : s_choice2desc.Text},
                    TaskDialogButton.Cancel
                },

                Icon = dialogIcon,
                Expander = b_expandenable.Checked ? new TaskDialogExpander("詳細が表示されています") : null
            }); ; ;
        }

    }
}
