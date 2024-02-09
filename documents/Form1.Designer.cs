namespace documents
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_add = new System.Windows.Forms.Button();
            this.but_red = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_sav = new System.Windows.Forms.Button();
            this.but_can = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.txt_vid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.but_search_id = new System.Windows.Forms.Button();
            this.but_ref = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.data,
            this.tip,
            this.vid});
            this.dataGridView.Location = new System.Drawing.Point(16, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(805, 481);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 200F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Заголовок";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // data
            // 
            this.data.HeaderText = "Дата создания";
            this.data.MinimumWidth = 6;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 125;
            // 
            // tip
            // 
            this.tip.HeaderText = "Тип";
            this.tip.MinimumWidth = 6;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Width = 125;
            // 
            // vid
            // 
            this.vid.HeaderText = "Вид";
            this.vid.MinimumWidth = 6;
            this.vid.Name = "vid";
            this.vid.ReadOnly = true;
            this.vid.Width = 125;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(16, 12);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(125, 34);
            this.but_add.TabIndex = 1;
            this.but_add.Text = "Добавить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_red
            // 
            this.but_red.Location = new System.Drawing.Point(167, 12);
            this.but_red.Name = "but_red";
            this.but_red.Size = new System.Drawing.Size(133, 34);
            this.but_red.TabIndex = 2;
            this.but_red.Text = "Редактировать";
            this.but_red.UseVisualStyleBackColor = true;
            this.but_red.Click += new System.EventHandler(this.but_red_Click);
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(331, 12);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(136, 34);
            this.but_del.TabIndex = 3;
            this.but_del.Text = "Удалить";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_sav
            // 
            this.but_sav.Location = new System.Drawing.Point(493, 12);
            this.but_sav.Name = "but_sav";
            this.but_sav.Size = new System.Drawing.Size(105, 34);
            this.but_sav.TabIndex = 4;
            this.but_sav.Text = "Сохранить";
            this.but_sav.UseVisualStyleBackColor = true;
            this.but_sav.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_can
            // 
            this.but_can.Location = new System.Drawing.Point(620, 12);
            this.but_can.Name = "but_can";
            this.but_can.Size = new System.Drawing.Size(75, 34);
            this.but_can.TabIndex = 5;
            this.but_can.Text = "Отмена";
            this.but_can.UseVisualStyleBackColor = true;
            this.but_can.Click += new System.EventHandler(this.but_can_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Содержание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заголовок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата создания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(827, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вид документа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(827, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Тип документа";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(830, 24);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(320, 22);
            this.txt_id.TabIndex = 12;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(830, 92);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(320, 79);
            this.txt_title.TabIndex = 13;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(830, 206);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(320, 22);
            this.txt_date.TabIndex = 14;
            // 
            // txt_tip
            // 
            this.txt_tip.Location = new System.Drawing.Point(830, 278);
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(320, 22);
            this.txt_tip.TabIndex = 15;
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(830, 433);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(320, 105);
            this.txt_content.TabIndex = 16;
            // 
            // txt_vid
            // 
            this.txt_vid.Location = new System.Drawing.Point(830, 352);
            this.txt_vid.Name = "txt_vid";
            this.txt_vid.Size = new System.Drawing.Size(320, 22);
            this.txt_vid.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1305, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Поиск по ID";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1187, 67);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(328, 22);
            this.txt_search.TabIndex = 19;
            // 
            // but_search_id
            // 
            this.but_search_id.Location = new System.Drawing.Point(1440, 95);
            this.but_search_id.Name = "but_search_id";
            this.but_search_id.Size = new System.Drawing.Size(75, 23);
            this.but_search_id.TabIndex = 20;
            this.but_search_id.Text = "Найти";
            this.but_search_id.UseVisualStyleBackColor = true;
            this.but_search_id.Click += new System.EventHandler(this.but_search_id_Click);
            // 
            // but_ref
            // 
            this.but_ref.Location = new System.Drawing.Point(715, 12);
            this.but_ref.Name = "but_ref";
            this.but_ref.Size = new System.Drawing.Size(106, 34);
            this.but_ref.TabIndex = 21;
            this.but_ref.Text = "Обновить";
            this.but_ref.UseVisualStyleBackColor = true;
            this.but_ref.Click += new System.EventHandler(this.but_ref_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 549);
            this.Controls.Add(this.but_ref);
            this.Controls.Add(this.but_search_id);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_vid);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.txt_tip);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_can);
            this.Controls.Add(this.but_sav);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_red);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Документы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_red;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_sav;
        private System.Windows.Forms.Button but_can;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.TextBox txt_vid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button but_search_id;
        private System.Windows.Forms.Button but_ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn vid;
    }
}

