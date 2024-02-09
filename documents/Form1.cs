using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace documents
{
    public partial class Form1 : Form
    {
        Document[] docs;    // здесь хранятся все файлы ввиде массива созданного класса account
        bool add_flag = false;   // флаг что бы программа понимала что мы добавляем данные
        bool red_flag = false;   // флаг что бы программа понимала что мы редактиреум данные


        public Form1()
        {
            InitializeComponent();
            full_list();
            text_box_read_only(true);
            but_pos(true);
            but_red.Enabled = false;
            but_del.Enabled = false;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        // вспомогательный метод
        public void text_box_read_only(bool flag)
        {
            txt_id.ReadOnly = flag;
            txt_title.ReadOnly = flag;
            txt_tip.ReadOnly = flag;
            txt_vid.ReadOnly = flag;
            txt_date.ReadOnly = flag;
            txt_content.ReadOnly = flag;
        }
        // вспомогательный метод
        public void but_pos(bool b)
        {
            but_add.Enabled = b;
            but_red.Enabled = b;
            but_del.Enabled = b;
            but_can.Enabled = !b;
            but_sav.Enabled = !b;
            but_ref.Enabled = b;
            but_search_id.Enabled = b;
        }

        // метод дя заполнения списка
        public void full_list()
        {
            dataGridView.Rows.Clear(); // очищаем список
                                                    // получаем массив строк с путями файлов в папке accounts
            string[] file = Directory.GetFiles("documents");
            if (file != null) // проверка на пустоту массива
            {
                docs = new Document[file.Length];
                int i = 0;
                // заполняем массив acc данными
                foreach (string path in file)
                {
                    try
                    {
                        // использеум StreamReader для чтения файлов по пути, и аполняем массив acc
                        using (StreamReader reader = new StreamReader(path))
                        {
                            docs[i] = new Document(reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), path);
                        }
                        i++;
                    }
                    // если какой-то файл не смог добавиться он удааляется 
                    catch
                    {
                        File.Delete(path);
                    }
                }
                // заполняем список данными
                foreach (Document doc in docs)
                {
                    dataGridView.Rows.Add(doc.id, doc.title, doc.date, doc.tip, doc.vid, doc.content);
                }
            }
        }

        // метод обрабатывает собитие нажатие на элемент списка
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            select_doc(e.RowIndex);
        }

        public void select_doc(int i)
        {
            if (i > -1)
            {
                but_pos(true);
                txt_id.Text = docs[i].id;
                txt_title.Text = docs[i].title;
                txt_tip.Text = docs[i].tip;
                txt_vid.Text = docs[i].vid;
                txt_date.Text = docs[i].date;
                txt_content.Text = docs[i].content;
            }
        }


        // метод обрабатывает нажатие на кнопку добавить
        private void but_add_Click(object sender, System.EventArgs e)
        {
            add_flag = true;
            txt_id.Text = "";
            txt_title.Text = "";
            txt_tip.Text = "";
            txt_vid.Text = "";
            txt_date.Text = "";
            txt_content.Text = "";
            text_box_read_only(false);
            but_pos(false);
            dataGridView.Enabled = false;
        }

        // метод обрабатывает нажатие на кнопку редактирование
        private void but_red_Click(object sender, System.EventArgs e)
        {
            text_box_read_only(false);
            but_pos(false);
            dataGridView.Enabled = false;
            red_flag = true;
        }

        // метод обрабатывает нажатие на кнопку удалить
        private void but_del_Click(object sender, System.EventArgs e)
        {
            // удаляем файл по эво пути
            File.Delete(docs[dataGridView.CurrentCell.RowIndex].path);
            // обновляем список
            full_list();
        }

        // метод обрабатывает нажатие на кнопку сохранить
        private void but_save_Click(object sender, System.EventArgs e)
        {
            // проверяем поля на пустоту
            if (txt_id.Text == "")
            {
                MessageBox.Show("Пустое поле ID", "Ошибка");
                return;
            }
            if (txt_title.Text == "")
            {
                MessageBox.Show("Пустое поле заголовка", "Ошибка");
                return;
            }
            if (txt_date.Text == "")
            {
                MessageBox.Show("Пустое поле даты", "Ошибка");
                return;
            }
            if (txt_vid.Text == "")
            {
                MessageBox.Show("Пустое поле вида", "Ошибка");
                return;
            }
            if (txt_tip.Text == "")
            {
                MessageBox.Show("Пустое поле типа", "Ошибка");
                return;
            }
            

            // если пользователь добавляет данные
            if (add_flag)
            {
                foreach (Document doc in docs)
                {
                    if (txt_id.Text == doc.id)
                    {
                        MessageBox.Show("ID должно быть уникальным", "Ошибка");
                        return;
                    }
                }
                Random random = new Random();
                // создаём текстовый файл с случайным названием и ложим туда введёные данные
                using (FileStream fs = File.Create("documents/" + random.Next(1000, 9999) + ".txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txt_id.Text);
                    fs.Write(info, 0, info.Length);
                    string text = "\n";
                    foreach (string line in txt_title.Lines)
                    {
                        text += " " + line;
                    }
                    info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes("\n" + txt_date.Text);
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes("\n" + txt_tip.Text);
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes("\n" + txt_vid.Text);
                    text = "\n";
                    foreach (string line in txt_content.Lines)
                    {
                        text += " " + line;
                    }
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length);
                }
                add_flag = false;
                text_box_read_only(true);
                dataGridView.Enabled = true;
                but_pos(true);
                but_red.Enabled = false;
                but_del.Enabled = false;
                full_list();
            }
            // если пользователь редактиреут данные
            if (red_flag)
            {
                foreach (Document doc in docs)
                {
                    if (txt_id.Text == doc.id && doc.id != docs[dataGridView.CurrentCell.RowIndex].id)
                    {
                        MessageBox.Show("ID должно быть уникальным", "Ошибка");
                        return;
                    }
                }
                // удаляем файл с этими данными
                File.Delete(docs[dataGridView.CurrentCell.RowIndex].path);
                // и создаём его заново с новыми данными
                using (FileStream fs = File.Create(docs[dataGridView.CurrentCell.RowIndex].path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txt_id.Text);
                    fs.Write(info, 0, info.Length);
                    string text = "\n";
                    foreach (string line in txt_title.Lines)
                    {
                        text += " " + line;
                    }
                    info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes("\n" + txt_date.Text);
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes("\n" + txt_tip.Text);
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes("\n" + txt_vid.Text);
                    text = "\n";
                    foreach (string line in txt_content.Lines)
                    {
                        text += " " + line;
                    }
                    fs.Write(info, 0, info.Length);
                    info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length);
                }
                txt_id.Text = docs[dataGridView.CurrentCell.RowIndex].id;
                txt_title.Text = docs[dataGridView.CurrentCell.RowIndex].title;
                txt_tip.Text = docs[dataGridView.CurrentCell.RowIndex].tip;
                txt_vid.Text = docs[dataGridView.CurrentCell.RowIndex].vid;
                txt_date.Text = docs[dataGridView.CurrentCell.RowIndex].date;
                txt_content.Text = docs[dataGridView.CurrentCell.RowIndex].content;
                but_pos(true);
                dataGridView.Enabled = true;
                text_box_read_only(true);
                red_flag = false;
                full_list();
            }
        }

        // поиск по id
        private void but_search_id_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i =0;i < docs.Length;i++)
            {
                if(txt_search.Text == docs[i].id)
                {
                    dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Selected = false;
                    dataGridView.Rows[i].Selected = true;
                    select_doc(i);
                    flag = false;
                    break;
                }
            }
            if (flag) MessageBox.Show("Не найдено");
        }

        private void but_ref_Click(object sender, EventArgs e)
        {
            full_list();
        }

        private void but_can_Click(object sender, EventArgs e)
        {
            // переводим элементы в нужное состояния
            but_pos(true);
            dataGridView.Enabled = true;
            text_box_read_only(true);
            // если пользователь хотел добавить данные поля делаются пустыми
            if (add_flag)
            {
                add_flag = false;
                txt_id.Text = "";
                txt_title.Text = "";
                txt_tip.Text = "";
                txt_vid.Text = "";
                txt_date.Text = "";
                txt_content.Text = "";
                but_red.Enabled = false;
                but_del.Enabled = false;
            }
            // если пользователь хотел изменить данные поля возвражаются к начальным значениям
            if (red_flag)
            {
                select_doc(dataGridView.CurrentCell.RowIndex);
                red_flag = false;
            }
        }
    }
}
