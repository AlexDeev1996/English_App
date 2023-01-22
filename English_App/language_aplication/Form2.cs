using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace language_aplication
{ 
    public partial class Form2 : Form
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
        string deSentence = "";
        string ruSentence = "";
        string infoSentence = "";
        static (int, int) numberFunc(int index)
        {
            return index switch
            {
                0 => (2, 21),
                1 => (23, 42),
                2 => (44, 63),
                3 => (65, 84),
                4 => (86, 105),
                5 => (107, 126),
                6 => (128, 147),
                7 => (149, 168),
                8 => (170, 189),
                9 => (191, 21),
                10 => (212, 231),
                11 => (233, 252),
                12 => (254, 273),
                13 => (275, 294),
                14 => (296, 315),
                15 => (317, 336),
                16 => (338, 357),
                17 => (359, 378),
                18 => (380, 399),
                19 => (401, 42),
                20 => (422, 441),
                21 => (443, 462),
                22 => (464, 483),
                23 => (485, 504),
                24 => (506, 522),
                25 => (524, 538),
                26 => (540, 559),
                27 => (561, 57),
                28 => (572, 586),
                29 => (588, 602),
                30 => (604, 623),
                31 => (625, 639),
                32 => (641, 66),
                33 => (662, 676),
                34 => (678, 692),
                35 => (694, 711),
                36 => (713, 722),
                37 => (724, 733),
                38 => (735, 754),
                39 => (756, 775),
                40 => (777, 796),
                41 => (798, 817),
                42 => (819, 838),
                43 => (840, 859),
                44 => (861, 87),
                45 => (872, 891),
                46 => (893, 912),
                47 => (914, 933),
                48 => (935, 954),
                49 => (956, 975),
                50 => (977, 996),
                51 => (998, 1017),
                52 => (1019, 1033),
                53 => (1035, 1954),
                54 => (1056, 1075),
                55 => (1077, 1091),
                56 => (1093, 1117),
                57 => (1119, 1138),
                58 => (1140, 1158),
                59 => (1160, 1179),
                60 => (1181, 12),
                61 => (1202, 1221),
                62 => (1223, 1237),
                63 => (1239, 1258),
                64 => (1260, 1279),
                65 => (1281, 13),
                66 => (1302, 1325),
                67 => (1327, 1336),
                68 => (1338, 1357),
                69 => (1359, 1378),
                70 => (1380, 1399),
                71 => (1401, 142),
                72 => (1422, 1441),
                73 => (1443, 1462),
                74 => (1464, 1483),
                75 => (1485, 1505),
                76 => (1507, 1526),
                77 => (1528, 1547),
                78 => (1549, 1568),
                79 => (1570, 1584),
                80 => (1586, 1605),
                81 => (1607, 1626),
                82 => (1628, 1647),
                83 => (1649, 1668),
                84 => (1670, 1689),
                85 => (1691, 171),
                86 => (1712, 1731),
                87 => (1733, 1752),
                88 => (1754, 1773),
                89 => (1775, 1794),
                90 => (1796, 1815),
                91 => (1817, 1836),
                92 => (1838, 1857),
                93 => (1859, 1878),
                94 => (1880, 1899),
                95 => (1901, 192),
                96 => (1922, 1941),
                97 => (1943, 1962),
                98 => (1964, 1987),
                99 => (1989, 2008),
                100 => (2010, 2029),
                101 => (2031, 205),
                102 => (2052, 2071),
                103 => (2073, 2096),
                104 => (2098, 2117),
                105 => (2119, 2139),
                106 => (2141, 216),
                107 => (2162, 2181),
                _ => (-1, -1)
            };
        }

        Random rand = new Random();
        bool ru_de = false;
        bool de_ru = true;

        private Form1 _form1;

        public void funcSwitch(int index)
        {
            int random;

            if (de_ru)
            {
                var number = numberFunc(index);

                random = rand.Next(number.Item1, number.Item2);
                cell1 = worksheet.Cells[random, 1]; //de
                cell2 = worksheet.Cells[random, 2]; //ru

                deSentence = Convert.ToString(cell1.Value2);
                ruSentence = Convert.ToString(cell2.Value2);

                sentenceLabel.Text = deSentence;
                checkLabel.Text = ruSentence;

            }
            if (ru_de)
            {
                var number = numberFunc(index);

                random = rand.Next(number.Item1, number.Item2);
                cell1 = worksheet.Cells[random, 1]; //de
                cell2 = worksheet.Cells[random, 2]; //ru

                deSentence = Convert.ToString(cell1.Value2);
                ruSentence = Convert.ToString(cell2.Value2);

                sentenceLabel.Text = ruSentence;
                checkLabel.Text = deSentence;
            }
        }

            
        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
            //создаем объект Application
            application = new Excel.Application();
            //получаем ссылку на коллекцию рабочих книг
            workbooks = application.Workbooks;
            workbook = application.Workbooks.Open(path_word,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

            //добавляем новую рабочую книгу в коллекцию
            //workbook = workbooks.Add(Type.Missing);
            worksheets = workbook.Worksheets; //получаем доступ к коллекции рабочих листов
            worksheet = (Excel.Worksheet)worksheets.get_Item(1);//получаем доступ к первому листу
            button1.Text = "НАЧАТЬ";

            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
         
        }
        private void Form2_KeyUp(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                this.KeyUp -= this.Form2_KeyUp;
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp_two);
            }
        }
        private void Form2_KeyUp_two(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                this.KeyUp += this.Form2_KeyUp;
                this.KeyUp -= this.Form2_KeyUp_two;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _form1.Visible = true;

        }

        private void ru_de_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ru_de_RadioButton2.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("deu-DEU"));
                ru_de = true;
                de_ru = false;
            }

            if (de_ru_RadioButton2.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
                de_ru = true;
                ru_de = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correctLabel.Text = "";
            sentenceTextBox.Text = "";
            infoTextBox.Text = "";
            sentenceLabel.Visible = true;
            correctLabel.Visible = true;

            button1.Text = "Далее";

            funcSwitch(temaComboBox.SelectedIndex);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (de_ru)
            {
                correctLabel.Text = checkLabel.Text;
            }

            if (ru_de)
            {
                correctLabel.Text = checkLabel.Text;
            }
        }

        private void sentenceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            else base.OnKeyPress(e);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!infoTextBox.Visible) infoTextBox.Visible = true;
            else infoTextBox.Visible = false;
        }
    }
}
