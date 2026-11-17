using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
        }

        bool capchaFlag = false;

        private void refrashKaphaButton_Click(object sender, EventArgs e)
        {
            capchaFlag = !capchaFlag;

            var picter = LeftTopPictureBox.Image;
            LeftTopPictureBox.Image = RightTopPictureBox.Image;
            RightTopPictureBox.Image = picter;

            picter = LeftButtonPictureBox.Image;
            LeftButtonPictureBox.Image = RightButtonPictureBox.Image;
            RightButtonPictureBox.Image = picter;
        }

        string loginUser = "";
        int valueError = 0;

        private void loginButton_Click(object sender, EventArgs e)
        {
            var user = NikitaDBEntities.GetContext().Users
                .FirstOrDefault(us => us.Login == loginTextBox.Text);

            if (user == null)
            {
                MessageBox.Show("Логин или пароль неправильный!",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (user.IsBlocked == true)
            {
                MessageBox.Show("Ваша учетная запись заблокирована, обратитесь к администратору",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (user.Login == loginUser && valueError >= 3)
            {
                user.IsBlocked = true;
                NikitaDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Ваша учетная запись заблокирована, обратитесь к администратору",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (user.Login != loginUser)
            {
                loginUser = user.Login;
                valueError = 0;
            }

            if (capchaFlag == false)
            {
                valueError++;
                MessageBox.Show("Неправильно собрана капча!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (user.Password != passwordTextBox.Text)
            {
                valueError++;
                MessageBox.Show("Вы ввели неправильный пароль!",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (user.Role_Id == 1)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                return;
            }

            if (user.Role_Id == 2)
            {
                MessageBox.Show(user.Login + ", вы вошли!",
                    "Успешная авторизация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
