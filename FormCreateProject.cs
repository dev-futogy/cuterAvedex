using System;
using System.Collections.Generic;
using System.IO;
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
		
		/// <summary>
		/// Функция для проверки фалйа-классификатора на пригодность.
		/// </summary>
		/// <param name="path">Путь к файлу-классификатору.</param>
		/// <returns>True - пригден для работы, а иначе False.</returns>
		private bool checkFileClass(string path)
		{
			int count = -1;
			string line;
			try
			{
				using (var OpenFileClassForRead = new StreamReader(path))
				{
					while ((line = OpenFileClassForRead.ReadLine()) != null)
					{
						count++;
					}
					if (count != -1) return true;
					else return false;
				}
			}
			catch (Exception e)
			{
				return false;
				//ТУТ МОЖНО ОТПРАВИТЬ СООБЩЕНИЕ В ЛОГ
			}

		}

		private string MyTestList(int id)
		{
			string s = "";
			foreach( string i in  ProjectSetting.ClassList[id].GetList)
			{
				s += i + " ";
			}
			return s ;
		}

		/// <summary>
		/// Создаем или меняем список доступных для выбора классификаторов.
		/// </summary>
		private void CreateListCBoxClassifiers()
		{
			_cmbBoxClassifier.Items.Clear();
			foreach (var classifierL in ProjectSetting.ClassList)
			{
				_cmbBoxClassifier.Items.Add(classifierL.Name);
			}
			_cmbBoxClassifier.SelectedIndex = 0;
		}
		/// <summary>
		/// Создаем или меняем список доступных для выбора классов в выбраном классификаторе
		/// </summary>
		private void CreateListCBoxClass(int idclasifier)
		{
			_cmbBoxNameClass.Items.Clear();
			foreach (var nameclass in ProjectSetting.ClassList[idclasifier].GetList)
			{
				_cmbBoxNameClass.Items.Add(nameclass);
			}
			_cmbBoxNameClass.SelectedIndex = 0;
		}
		/// <summary>
		/// Создание Класса Классификатора и добавление его в лист со всеми классификаторами
		/// </summary>
		/// <param name="path">Путь к файлу</param>
		private void createClassifier(int IdClassForList)
		{
			string line;
			try
			{
				using (var OpenFileClassForRead = new StreamReader(ProjectSetting.ClassList[IdClassForList].PathClassFile))
				{
					ProjectSetting.ClassList[IdClassForList].GetList = new List<string>();
					while ((line = OpenFileClassForRead.ReadLine()) != null)
					{
						ProjectSetting.ClassList[IdClassForList].GetList.Add(line);
					}
					MessageBox.Show(MyTestList(IdClassForList), ProjectSetting.ClassList[IdClassForList].Name);
					if (ProjectSetting.ClassList.Count == 1)
					{
						_cmbBoxClassifier.Enabled = true;
						_cmbBoxNameClass.Enabled = true;
						_btnWhatISColor.Enabled = true;
						_btnSetColor.Enabled = true;
						CreateListCBoxClass(0);
					}
				}
				CreateListCBoxClassifiers();
			}
			catch (Exception e)
			{
				//ТУТ МОЖНО ОТПРАВИТЬ СООБЩЕНИЕ В ЛОГ
			}
		}

		/// <summary>
		/// Выбор пути к файлу-калссификатору.
		/// </summary>
		private void _btnPathClass_Click(object sender, EventArgs e)
		{
			if (_openClassFileDialog.ShowDialog() == DialogResult.OK)
			{
				ProjectSetting.SellectedPathFileClass = _openClassFileDialog.FileName;
				ProjectSetting.SellectedNameClass = _textBoxNameClass.Text;
				_textBoxPathFileClass.Text = ProjectSetting.SellectedPathFileClass;
			}
		}
		/// <summary>
		/// Изминение выбраного номера классификатора.
		/// </summary>
		private void _numerClassifier_ValueChanged(object sender, EventArgs e)
		{
			if (_numerClassifier.Value > ProjectSetting.ClassList.Count)
			{
				_textBoxNameClass.Text = $"class{_numerClassifier.Value}";
				_textBoxPathFileClass.Text = "PATH";
			}
			else
			{
				_textBoxNameClass.Text = ProjectSetting.ClassList[(int)_numerClassifier.Value-1].Name;
				_textBoxPathFileClass.Text = ProjectSetting.ClassList[(int)_numerClassifier.Value-1].PathClassFile;
			}
		}

		/// <summary>
		/// Добавление классификатора в Список
		/// </summary>
		private void _btnAddClass_Click(object sender, EventArgs e)
		{
			///Добавляем новый обьект в лист
			if ((_numerClassifier.Value - ProjectSetting.ClassList.Count) == 1)
			{
				ProjectSetting.ClassList.Add(new classifier(ProjectSetting.SellectedPathFileClass, ProjectSetting.SellectedNameClass));
			}
			else if((_numerClassifier.Value - ProjectSetting.ClassList.Count) > 1)
			{
				///Когда выбраный номер классификатора не соответствует порядку
				_numerClassifier.Value = ProjectSetting.ClassList.Count + 1;
				ProjectSetting.ClassList.Add(new classifier(ProjectSetting.SellectedPathFileClass, ProjectSetting.SellectedNameClass));
			}
			else
			{
				ProjectSetting.ClassList[(int)_numerClassifier.Value-1] = new classifier(ProjectSetting.SellectedPathFileClass, ProjectSetting.SellectedNameClass);
			}


			///Проверяем файл на пригодность и создаем все дополнитьные параметры в классе листа
			if (checkFileClass(ProjectSetting.ClassList[(int)_numerClassifier.Value-1].PathClassFile))
			{
				createClassifier((int)_numerClassifier.Value-1);
			}
			else
			{
				MessageBox.Show("Ошибка", "Заголовок");
				//ТУТ МОЖЕТ БЫТЬ ЗАПИСЬ В ЛОГ
			}
			  
		}

		/// <summary>
		/// Вызывается при изменении названия классификатора.
		/// </summary>
		private void _textBoxNameClass_TextChanged(object sender, EventArgs e)
		{
			ProjectSetting.SellectedNameClass = _textBoxNameClass.Text;
		}

		/// <summary>
		/// Вызывается при изменении выбора классификатора в блоке о цвете.
		/// </summary>
		private void _cmbBoxClassifier_SelectedIndexChanged(object sender, EventArgs e)
		{
			CreateListCBoxClass(_cmbBoxClassifier.SelectedIndex);
		}
	}
}
