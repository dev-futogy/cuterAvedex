using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuterAvedex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OnStartSettings();
        }
        /// <summary>
        ///  Функция устанавливает видимость компонетов при запуске программы 
        /// </summary>
        private void OnStartSettings()
        {
            
            openProjectToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            projectToolStripMenuItem.Enabled = false;

            ProjectSetting.IsOpenFileProject = false;

        }
        /// <summary>
        /// Создать новый проект
        /// </summary>
        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если файл проекта не открыт
            if (!ProjectSetting.IsOpenFileProject)
            {
                var createNewProjectWindows = new FormCreateProject();
                createNewProjectWindows.Show();
            }
        }
    }
}
