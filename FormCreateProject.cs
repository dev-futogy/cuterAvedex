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
    public partial class FormCreateProject : Form
    {
        public FormCreateProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (_pathFolderNewProject.ShowDialog() == DialogResult.OK)
            {
                ProjectSetting.PathProject = _pathFolderNewProject.SelectedPath;
                _textBoxPathFolderNewProject.Text = ProjectSetting.PathProject;
            }
        }
    }
}
