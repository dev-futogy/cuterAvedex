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
        /// <summary>
        /// Выбор пути, где будет храниться проект
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (_pathFolderNewProject.ShowDialog() == DialogResult.OK)
            {
                //Путь к проекту
                ProjectSetting.PathProject = _pathFolderNewProject.SelectedPath;
                _textBoxPathFolderNewProject.Text = ProjectSetting.PathProject;
                _countClassifiers.Enabled = true;
                _numerClassifier.Enabled = true;
                _textBoxNameClass.Enabled = true;
                _btnPathClass.Enabled = true;
                _textBoxPathFileClass.Enabled = true;
                _btnAddClass.Enabled = true;
            }
        }
        /// <summary>
        /// Устанвока коллисества классификаторов в проектке
        /// </summary>
        private void _countClassifiers_ValueChanged(object sender, EventArgs e)
        {
            ///Коллисества классификаторов в проектке
            ProjectSetting.CountClassifiers = (byte)_countClassifiers.Value;
            ///Максимальное колличества классов при добавлении. В форме создания новго проекта.
            _numerClassifier.Maximum = ProjectSetting.CountClassifiers; 
        }
    }
}
