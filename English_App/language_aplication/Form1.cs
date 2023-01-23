using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace language_aplication
{
    public partial class Form1 : Form
    {
        Excel.Application application = null;
        Excel.Workbooks workbooks = null;
        Excel.Workbook workbook = null;
        Excel.Sheets worksheets = null;
        Excel.Worksheet worksheet = null;

        Excel.Range cell1 = null;
        Excel.Range cell2 = null;
        Excel.Range cell3 = null;
        Excel.Range cell4 = null;
        int count = 1;
        int count_button = 0;
        string path_word = @"C:\Users\Alex\source\repos\English_App\appDATA.xlsx";
        string check_word = "";
        string deWord = "";
        string ruWord = "";
        string translateWord = "";
        string transkriotionsWord = "";

        int[] index_exel_verbs = new int[3] { 10, 12 , 14 };
        int[] index_exel_verbs_transkript = new int[3] { 11, 13, 15 };

        Random rand = new Random();
        bool ru_eng = false;
        bool eng_ru = true;
        bool button_visible = false;
        static int count_ListView = 0;
        static int count_progress_true = 0;
        static int count_progress_false = 0;
        private Form2 form2;
        private static int progress = 0;
        public static int Progress
        { 
            get { return progress; }
            set 
            {
                if (value <= 0)
                    progress = 0;
                else 
                if (value >= 100)
                    progress = 100;
                else progress = value;
                
            }  
        }

        private void CompareWord(string word1, string word2)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();
            if (word1 == word2)
            {
                Progress += 10;
                toolStripProgressBar1.Value = Progress;
                correctWordLabel.ForeColor = Color.Green;
                correctWordLabel.Text = "TRUE";
                
                resultListView.Items.Add("TRUE");
             
                resultListView.Items[count_ListView].SubItems.Add(word1);
                resultListView.Items[count_ListView].SubItems.Add(word2);
                count_progress_true++;
            }
            else
            {
                Progress -= 10;
                toolStripProgressBar1.Value = Progress;
                correctWordLabel.ForeColor = Color.Red;
                correctWordLabel.Text = "FALSE";
                
                resultListView.Items.Add("FALSE");
                trueWordLabel.Text = translateLabel.Text;
        
                resultListView.Items[count_ListView].SubItems.Add(word1);
                resultListView.Items[count_ListView].SubItems.Add(word2);
                count_progress_false++;
            }
            count_ListView++;
            toolStripStatusLabel1.Text = $"TRUE = {count_progress_true} FALSE = {count_progress_false}";
        }
        private static void CloseExcel(Excel.Application ExcelApplication = null)
        {
            if (ExcelApplication != null)
            {
                ExcelApplication.Workbooks.Close();
                ExcelApplication.Quit();
            }

            System.Diagnostics.Process[] PROC = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process PK in PROC)
            {
                if (PK.MainWindowTitle.Length == 0) { PK.Kill(); }
            }
        }
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this) { Visible = false};
            //создаем объект Application
            application = new Excel.Application();
            //получаем ссылку на коллекцию рабочих книг
            workbooks = application.Workbooks;
            workbook = application.Workbooks.Open(path_word,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);
            groupBox2.Height = 55;

            //добавляем новую рабочую книгу в коллекцию
            //workbook = workbooks.Add(Type.Missing);
            worksheets = workbook.Worksheets; //получаем доступ к коллекции рабочих листов
            worksheet = (Excel.Worksheet)worksheets.get_Item(1);//получаем доступ к первому листу
            button1.Text = "НАЧАТЬ";
            correctWordLabel.Text = "";

            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);   

        }

        private void Form1_KeyUp_two(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                this.KeyUp += this.Form1_KeyUp;
                this.KeyUp -= this.Form1_KeyUp_two;

            }

        }
        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                this.KeyUp -= this.Form1_KeyUp;
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_two);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordLabel.Visible = true;
            transcriptionLebel.Visible = false;
            int random = rand.Next(1, 1999);
            int random_for_verbs = rand.Next(1, 138);
            int random_3 = rand.Next(0,2);
            button1.Text = "Далее";
            if (eng_ru)
            {

                transriptionsLabel.Visible = true;
                if (first_form_radioButton1.Visible)
                {
                    if (first_form_radioButton1.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, 10]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, 11]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell2.Value2);
                        wordLabel.Text = Convert.ToString(cell1.Value2);
                        transriptionsLabel.Text = Convert.ToString(cell4.Value2);
                    }
                    if (second_form_radioButton2.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, 12]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, 13]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell2.Value2);
                        wordLabel.Text = Convert.ToString(cell1.Value2);
                        transriptionsLabel.Text = Convert.ToString(cell4.Value2);
                    }
                    if (third_form_radioButton3.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, 14]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, 15]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell2.Value2);
                        wordLabel.Text = Convert.ToString(cell1.Value2);
                        transriptionsLabel.Text = Convert.ToString(cell4.Value2);
                    }
                    if (all_forms_radioButton4.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, index_exel_verbs[random_3]]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, index_exel_verbs_transkript[random_3]]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell2.Value2);
                        wordLabel.Text = Convert.ToString(cell1.Value2);
                        transriptionsLabel.Text = Convert.ToString(cell4.Value2);
                    }
                }
                else
                {
                    cell1 = (Excel.Range)worksheet.Cells[random, 5]; //eng
                    cell2 = (Excel.Range)worksheet.Cells[random, 7]; //ru
                    cell4 = (Excel.Range)worksheet.Cells[random, 6]; //транскрипция

                    translateLabel.Text = Convert.ToString(cell2.Value2);
                    wordLabel.Text = Convert.ToString(cell1.Value2);
                    transriptionsLabel.Text = Convert.ToString(cell4.Value2);
                }

            }

           if(ru_eng)
           {
                transriptionsLabel.Visible = false;

                if (first_form_radioButton1.Visible)
                {
                    if (first_form_radioButton1.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, 10]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, 11]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell1.Value2);
                        transcriptionLebel.Text = Convert.ToString(cell4.Value2);
                        wordLabel.Text = Convert.ToString(cell2.Value2);
                    }
                    if (second_form_radioButton2.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, 12]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, 13]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell1.Value2);
                        transcriptionLebel.Text = Convert.ToString(cell4.Value2);
                        wordLabel.Text = Convert.ToString(cell2.Value2);
                    }
                    if (third_form_radioButton3.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, 14]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, 15]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell1.Value2);
                        transcriptionLebel.Text = Convert.ToString(cell4.Value2);
                        wordLabel.Text = Convert.ToString(cell2.Value2);

                    }
                    if (all_forms_radioButton4.Checked)
                    {
                        cell1 = (Excel.Range)worksheet.Cells[random_for_verbs, index_exel_verbs[random_3]]; //eng
                        cell2 = (Excel.Range)worksheet.Cells[random_for_verbs, 16]; //ru
                        cell4 = (Excel.Range)worksheet.Cells[random_for_verbs, index_exel_verbs_transkript[random_3]]; //транскрипция

                        translateLabel.Text = Convert.ToString(cell1.Value2);
                        transcriptionLebel.Text = Convert.ToString(cell4.Value2);
                        wordLabel.Text = Convert.ToString(cell2.Value2);
                    }
                }
                else
                {
                    cell1 = (Excel.Range)worksheet.Cells[random, 5]; //eng
                    cell2 = (Excel.Range)worksheet.Cells[random, 7]; //ru
                    cell4 = (Excel.Range)worksheet.Cells[random, 6]; //транскрипция

                    translateLabel.Text = Convert.ToString(cell1.Value2);
                    transcriptionLebel.Text = Convert.ToString(cell4.Value2);
                    wordLabel.Text = Convert.ToString(cell2.Value2);
                }
            }


            wordTextBox.Text = "";
            correctWordLabel.Text = "";
            trueWordLabel.Text = "";

        }

       

        private void button3_Click(object sender, EventArgs e) //Button compare
        {
           
            if (ru_eng) transcriptionLebel.Visible = true;
            if (eng_ru)  transcriptionLebel.Visible = false;
            correctWordLabel.Visible = true;
            trueWordLabel.Visible = true;
            CompareWord(translateLabel.Text, wordTextBox.Text);
        }

        private void ru_de_RadioButton_CheckedChanged(object sender, EventArgs e)  
        {
            if (ru_de_RadioButton.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
                ru_eng = true;
                eng_ru = false;
            }

            if (de_ru_RadioButton.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
                eng_ru = true;
                ru_eng = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseExcel(application);

        }

        private void totalResultButton_Click(object sender, EventArgs e)
        {
            if (!resultListView.Visible) resultListView.Visible = true;
            else resultListView.Visible = false;
            

        }

        private void wordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            else base.OnKeyPress(e);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (!first_form_radioButton1.Visible)
            {
                groupBox2.Height = 160;
                first_form_radioButton1.Visible = true;
                second_form_radioButton2.Visible = true;
                third_form_radioButton3.Visible = true;
                all_forms_radioButton4.Visible = true;
            }   
            else
                {
                    groupBox2.Height = 55;
                    first_form_radioButton1.Visible = false;
                second_form_radioButton2.Visible = false;
                third_form_radioButton3.Visible = false;
                all_forms_radioButton4.Visible = false;
                first_form_radioButton1.Checked = false;
                second_form_radioButton2.Checked = false;
                third_form_radioButton3.Checked = false;
                all_forms_radioButton4.Checked = false;
            }
        }
    }
}