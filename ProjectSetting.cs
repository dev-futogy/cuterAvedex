using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuterAvedex
{
    static class ProjectSetting
    {
		/// <summary>
		/// Открыт ли файл
		/// </summary>
        static public bool IsOpenFileProject
        {
            get;
            set;
        }
		/// <summary>
		/// Путь к папке с проектом
		/// </summary>
        static public string PathProject
        {
            get;
            set;
        }
		/// <summary>
		/// Колличество возможных классификаторов
		/// </summary>
		static public byte CountClassifiers
        {
            get;
            set;
        }
		/// <summary>
		/// Выбранный пусть к файлу-классификатору
		/// </summary>
		static public string SellectedPathFileClass
		{
			get;
			set;
		}
		/// <summary>
		/// Выбраное имя для классификатора
		/// </summary>
		static public string SellectedNameClass
		{
			get;
			set;
		}
		/// <summary>
		/// Лист со всеми классификаторами
		/// </summary>
		static public List<classifier> ClassList = new List<classifier>();
    }
}
