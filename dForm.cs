using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;


namespace Deleter
{
    public partial class dForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public Boolean states;
        ArrayList al = new ArrayList();
        ArrayList FocusedItemFolderArrayList = new ArrayList();
        ArrayList FocusedItemFolderArrayList1 = new ArrayList();

        public dForm()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.FindListView.ListViewItemSorter = lvwColumnSorter; 
        }

        public void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            toolStrip1.Enabled = false;
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            Thread myThread = new Thread(InviteFileInListView); //Создаем новый объект потока (Thread)

            myThread.Start(); //запускаем поток
            al.Clear();
        }

        
        #region Методы

        #region Поиск файлов 1 способ
        //static ArrayList GetFile(string pathfolder,string exts)
        //{
        //    string b = "байт";
        //    string Kb = "Кб";
        //    string Mb = "Мб";
        //    string Gb = "Гб";
        //     ArrayList al = new ArrayList() ;

        //    if (pathfolder != "")
        //    {
        //        try
        //        {
        //            DirectoryInfo dir = new DirectoryInfo(pathfolder);
        //            foreach (var item in dir.GetFiles(exts, SearchOption.AllDirectories))
        //            {
        //                if (item.Length < 1024)
        //                {
        //                    //вот такой был сначала способ
        //                    //al.Add("" + ";" + item.Name.ToString() + ";"
        //                    // + item.FullName.ToString() + ";" + item.Length.ToString() + " " + b);
        //                    ListViewItem ivi = new ListViewItem();
        //                    ivi.SubItems.Add(item.Name.ToString());
        //                    ivi.SubItems.Add(item.FullName.ToString());
        //                    ivi.SubItems.Add(item.Length.ToString() + " " + b);
        //                    ivi.BackColor = Color.LightBlue;
        //                    al.Add(ivi);
        //                }

        //                if (item.Length > 1024 && 1048576 > item.Length)
        //                {
        //                    long size3 = (item.Length / (1024));
        //                    ListViewItem ivi = new ListViewItem();
        //                    ivi.SubItems.Add(item.Name.ToString());
        //                    ivi.SubItems.Add(item.FullName.ToString());
        //                    ivi.SubItems.Add(size3.ToString() +" "+Kb);
        //                    ivi.BackColor = Color.LightGray;
        //                    al.Add(ivi);
        //                }
        //                if (1048576 < item.Length && 1073741824 > item.Length)
        //                {
        //                    long size3 = (item.Length / (1024 * 1024));
        //                    ListViewItem ivi = new ListViewItem();
        //                    ivi.SubItems.Add(item.Name.ToString());
        //                    ivi.SubItems.Add(item.FullName.ToString());
        //                    ivi.SubItems.Add(size3.ToString() + " " + Mb);
        //                    ivi.BackColor = Color.LightGray;
        //                    al.Add(ivi);
        //                }
        //                if (1073741824 <= item.Length)
        //                {
        //                    long size3 = (item.Length/(1024*1024*1024));
        //                    ListViewItem ivi = new ListViewItem();
        //                    ivi.SubItems.Add(item.Name.ToString());
        //                    ivi.SubItems.Add(item.FullName.ToString());
        //                    ivi.SubItems.Add(size3.ToString()+" "+ Gb);
        //                    ivi.BackColor = Color.LightGreen;
        //                    al.Add(ivi);
        //                }
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Нельзя выбрать локальный диск", "Ошибка");
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("Введите место для поиска файлов", "Ошибка");
        //    }

        //    return al;
        //}
        #endregion

        #region Поиск файлов 2 способ
        void GetaFile(string pathfolder, string exts)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(pathfolder);
                FileInfo[] files = dir.GetFiles(exts);
                foreach (FileInfo item in files)
                {
                    if (item.Length < 1024)
                    {
                        ListViewItem ivi = new ListViewItem();
                        ivi.SubItems.Add(item.Name.ToString());
                        ivi.SubItems.Add(item.FullName.ToString());
                        ivi.SubItems.Add(GetSizeInString(item.Length));
                        ivi.SubItems.Add(item.Extension.ToString());
                        ivi.BackColor = Color.LightBlue;
                        al.Add(ivi);
                    }

                    if (item.Length > 1024 && 1048576 > item.Length)
                    {
                        //long size3 = (item.Length / (1024));
                        ListViewItem ivi = new ListViewItem();
                        ivi.SubItems.Add(item.Name.ToString());
                        ivi.SubItems.Add(item.FullName.ToString());
                        ivi.SubItems.Add(GetSizeInString(item.Length));
                        ivi.SubItems.Add(item.Extension.ToString());
                        ivi.BackColor = Color.LightGray;
                        al.Add(ivi);
                    }
                    if (1048576 < item.Length && 1073741824 > item.Length)
                    {
                        //long size3 = (item.Length / (1024 * 1024));
                        ListViewItem ivi = new ListViewItem();
                        ivi.SubItems.Add(item.Name.ToString());
                        ivi.SubItems.Add(item.FullName.ToString());
                        ivi.SubItems.Add(GetSizeInString(item.Length));
                        ivi.SubItems.Add(item.Extension.ToString());
                        ivi.BackColor = Color.LightGreen;
                        al.Add(ivi);
                    }
                    if (1073741824 <= item.Length)
                    {
                        //long size3 = (item.Length / (1024 * 1024 * 1024));
                        ListViewItem ivi = new ListViewItem();
                        ivi.SubItems.Add(item.Name.ToString());
                        ivi.SubItems.Add(item.FullName.ToString());
                        ivi.SubItems.Add(GetSizeInString(item.Length));
                        ivi.SubItems.Add(item.Extension.ToString());
                        ivi.BackColor = Color.LightYellow;
                        al.Add(ivi);
                    }

                }
                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    GetaFile(pathfolder + d.Name + @"\", exts);

                }
            }
            catch (Exception ex)
            {
                MainLogTextBox.Items.Add(ex.Message);
            }
        }

        #endregion

        #region Удаление файлов
        void DeleteSelectedFileInFindListView()
        {
            try
            {
                for (int i = 0; i < FindListView.CheckedItems.Count; i++)
                {
                    string path_file1 = FindListView.CheckedItems[i].SubItems[2].Text;
                    path_file1.Remove(0, 17);
                    File.Delete(path_file1);
                    FindListView.CheckedItems[i].Remove();
                    MainLogTextBox.Items.Add(path_file1 + " - Удален");
                }
            }
            catch
            {
                MainLogTextBox.Items.Add("Выберите файлы для удаления");
            }
        }

        #endregion

        #region Получение подпапок
        void GetPathOnSelectedFile()
        {
            try
            {
                string[] FocusedItemFolders;
                string focusedItemS;
                FocusedItemFolderArrayList.Clear();

                string focuseditem = FindListView.FocusedItem.SubItems[2].Text;
                focusedItemS = focuseditem;
                //Добавлем в массив 
                FocusedItemFolders = focusedItemS.Split('\\');
                ContextMenuDataOpenFolder.DropDownItems.Clear();

                //Добавляем в FocusedItemFolderArrayList1
                foreach (var FocusedItemFolder in FocusedItemFolders)
                {
                    FocusedItemFolderArrayList.Add(FocusedItemFolder);
                }

                for (int sdf = 0; sdf < FocusedItemFolderArrayList.Count - 1; sdf++)
                {
                    focusedItemS = focuseditem.Remove(focusedItemS.LastIndexOf('\\'));
                    ContextMenuDataOpenFolder.DropDownItems.Add(focusedItemS + "\\");
                }
            }
            catch
            {
                MainLogTextBox.Items.Add("Не выбрана папка.");
            }
        }
        #endregion

        #region Получение данных о файле

        static ArrayList GetFileInfo(string fFileName)
        {
            ArrayList al = new ArrayList();
            al.Clear();
            try
            {
                FileInfo fi = new FileInfo(fFileName);
                al.Add(fi.Name + ";"
                    + fi.Length.ToString() + ";" + fi.Extension + ";"
                    + fi.LastAccessTime + ";"
                    + fi.LastWriteTime);

                return al;
            }
            catch (Exception ex)
            {
                al.Add(ex.Message);
                return al;
            }

        }
        #endregion

        #region Добавление в findPath
        void InvitePathInFindPath()
        {
            #region OLD
            //if (findPath.Items.Count == 0)
            //    findPath.Items.Add(findPath.Text);

            //    foreach (string val in findPath.Items)
            //    {
            //        // Проверяем наличие в списке и если нет - добавляем
            //        if (findPath.FindString(val)!= -1) 
            //            findPath.Items.Add(val);
            //    }
            #endregion

            if (!findPath.Items.Contains(findPath.Text)) //проверка вхождения строки в листбокс
                findPath.Items.Add(findPath.Text); //добавляем, если отсутствует

        }
        #endregion

        #region Округление размера папки

        string GetSizeInString(long size)
        {
            string[] postfix = { "байт", "Kb", "Mb", "Gb", "Tb" };
            int i = 1;
            double temp = (double)size;
            while ((temp /= 1024) > 1024 && i++ < postfix.Length) ;
            return String.Format("{0:F}", temp) + " " + postfix[i];
        }

        #endregion

        //главнвый метод обратобки данных
        void InviteFileInListView()
        {
            FindListView.Items.Clear();
            GetaFile(findPath.Text, findMask.Text);
            //Массовое добавление из ArrayList
            FindListView.Items.AddRange((ListViewItem[])(al.ToArray(typeof(ListViewItem))));
            tFileCount.Text = al.Count.ToString();
            InvitePathInFindPath();
            progressBar1.Style = ProgressBarStyle.Continuous;
            toolStrip1.Enabled = true;
        }

        #endregion

        //Удаление выбранных файлов
        private void findButDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedFileInFindListView();
        }

        //Чистка переменных
        private void findButClear_Click(object sender, EventArgs e)
        {
            FindListView.Items.Clear();
            findPath.Text = "";
        }

        #region Сортировка по столбцам

        private void sort_contacts(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.FindListView.Sort();
        }
        #endregion

        #region Сохранение в Logs.txt
        private void MainMenuStrip1LogSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream filestream = new FileStream("log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //Очищаем поток 
                filestream.SetLength(0);
                //StreamWriter создаем для потока filestream 
                StreamWriter streamwriter = new StreamWriter(filestream);
                //Записываем текст, из ListBoxBox1 в файл 
                foreach (var st in MainLogTextBox.Items)
                {
                    streamwriter.WriteLine(st);
                }
                streamwriter.Close();
            }
            catch (Exception ex)
            {
                MainLogTextBox.Items.Add(ex.Message);
            }

        }
        #endregion

        #region Выбрать все элементы
        private void findButCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            
            if (findButCheckAll.Checked == true)
            {
                findButCheckAll.Image = Deleter.Properties.Resources.ui_check_box;
                for (int i = 0; i < FindListView.Items.Count; i++)
                {
                    FindListView.Items[i].Checked = true;
                }
            }
            else
            {
                findButCheckAll.Image = Deleter.Properties.Resources.ui_check_box_uncheck;
                for (int i = 0; i < FindListView.Items.Count; i++)
                {
                    FindListView.Items[i].Checked = false;
                }
            }
            
        }
        #endregion

        //Получение данных о файле и вставка их в поля
        private void ContextMenuDataGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string focuseditem = FindListView.FocusedItem.SubItems[2].Text;
                ArrayList ar = GetFileInfo(focuseditem);
                foreach (string strr in ar)
                {
                    string[] parts = strr.Split(';');
                    tFileName.Text = parts[0];
                    tFileSize.Text = parts[1];
                    tFileMask.Text = parts[2];
                    tFileCreate.Text = parts[4];
                    tFileChange.Text = parts[3];
                }
            }
            catch(Exception ex)
            {
                MainLogTextBox.Items.Add(ex.Message);
            }
        }

        //При открытии он получает все папки
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            GetPathOnSelectedFile();
        }
        //Показывать в MessageBox выбранный элемпент
        private void MainLogTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(MainLogTextBox.SelectedItem.ToString());
        }
        //Закрытие программы
        private void MainMenuStrip1FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Очистка Log
        private void MainMenuStrip1LogClear_Click(object sender, EventArgs e)
        {
            MainLogTextBox.Items.Clear();
        }

        private void FindListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //tFileCountSelected.Text = (FindListView.CheckedItems.Count).ToString();
            //findButCheckAll_CheckedChanged(this, null);
        }

        //Добавление пути 
        private void PathForFile_TextChanged(object sender, EventArgs e)
        {
            //findPath.Items.Clear();
            //try
            //{
            //    //findPath.Items.Clear();
            //    string[] folders = Directory.GetDirectories(findPath.Text, "*.*", SearchOption.TopDirectoryOnly);
                
            //    foreach (string folder in folders)
            //    {
            //        findPath.Items.Add(folder);
            //        findPath.Select(findPath.Text.Length,1);
            //    }
            //    //findPath.DroppedDown = true;
            //}
            //catch
            //{
            //    findPath.Items.Clear();
            //}
        }

        private void findButOpenAsFileTextEdit_Click(object sender, EventArgs e)
        {
            dTextEditor _dTextEditor = new dTextEditor();
            _dTextEditor._FullPathNameOnMainWindows = FindListView.FocusedItem.SubItems[2].Text;
            _dTextEditor._StatusStripMainSizeFile = FindListView.FocusedItem.SubItems[3].Text;
            _dTextEditor._StatusStripMainNameFile = FindListView.FocusedItem.SubItems[1].Text;
            _dTextEditor.getS();
            _dTextEditor.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tFileCountSelected.Text = (FindListView.CheckedItems.Count).ToString();
        }
    }
}
