namespace language_aplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ru_de_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.de_ru_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.checkLabel = new System.Windows.Forms.Label();
            this.temaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "НАЧАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sentenceLabel.Location = new System.Drawing.Point(12, 9);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(776, 63);
            this.sentenceLabel.TabIndex = 1;
            this.sentenceLabel.Text = "DE WORD";
            this.sentenceLabel.Visible = false;
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sentenceTextBox.Location = new System.Drawing.Point(12, 72);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(767, 38);
            this.sentenceTextBox.TabIndex = 2;
            this.sentenceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sentenceTextBox_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ru_de_RadioButton2
            // 
            this.ru_de_RadioButton2.AutoSize = true;
            this.ru_de_RadioButton2.Location = new System.Drawing.Point(8, 14);
            this.ru_de_RadioButton2.Name = "ru_de_RadioButton2";
            this.ru_de_RadioButton2.Size = new System.Drawing.Size(92, 24);
            this.ru_de_RadioButton2.TabIndex = 4;
            this.ru_de_RadioButton2.Text = "RUS/ENG";
            this.ru_de_RadioButton2.UseVisualStyleBackColor = true;
            this.ru_de_RadioButton2.CheckedChanged += new System.EventHandler(this.ru_de_RadioButton2_CheckedChanged);
            // 
            // de_ru_RadioButton2
            // 
            this.de_ru_RadioButton2.AutoSize = true;
            this.de_ru_RadioButton2.Checked = true;
            this.de_ru_RadioButton2.Location = new System.Drawing.Point(8, 44);
            this.de_ru_RadioButton2.Name = "de_ru_RadioButton2";
            this.de_ru_RadioButton2.Size = new System.Drawing.Size(92, 24);
            this.de_ru_RadioButton2.TabIndex = 5;
            this.de_ru_RadioButton2.TabStop = true;
            this.de_ru_RadioButton2.Text = "ENG/RUS";
            this.de_ru_RadioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "ПРОВЕРИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctLabel.Location = new System.Drawing.Point(12, 112);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(767, 55);
            this.correctLabel.TabIndex = 7;
            this.correctLabel.Text = "Correct Sentence";
            this.correctLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoTextBox.Location = new System.Drawing.Point(12, 261);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(674, 143);
            this.infoTextBox.TabIndex = 8;
            this.infoTextBox.Text = "Премечание";
            this.infoTextBox.Visible = false;
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(445, 9);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(48, 20);
            this.checkLabel.TabIndex = 9;
            this.checkLabel.Text = "Check";
            this.checkLabel.Visible = false;
            // 
            // temaComboBox
            // 
            this.temaComboBox.FormattingEnabled = true;
            this.temaComboBox.Items.AddRange(new object[] {
            "1 AM IS ARE, глагол to be в Present Simple ",
            "2 AM IS ARE в вопросах, to be в Present",
            "3 Present Continuous",
            "4_ Present Continuous Вопросы",
            "5_ Present Simple утверждения",
            "6_ Present Simple отрицания",
            "7_ Present Simple Вопросы",
            "8_ Present Simple vs Present Continuous",
            "9_ I have и I have got (сравнение на примерах)",
            "10_ WAS и WERE (глагола to be в прошлом , Past)",
            "11_ Past Simple",
            "12_ Past Simple (отрицания и вопросы)",
            "13_ Past Continuous (I was doing)",
            "14_ Past Simple (I did) и Past Continuous (I was doing)",
            "15_ Present Perfect",
            "16_ Present Perfect и слова JUST, ALREADY, YET",
            "17_ Have you ever ..._ Present Perfect и слово ever",
            "18_ Present Perfect Continuous. Вопрос How long ...",
            "19_ Слова,маячки SINCE, FOR и AGO",
            "22_ Passive , Пассивный залог в английском, урок 2",
            "23_ Глаголы BE, DO, HAVE , итоговый",
            "24_ 3 формы глагола в английском, Irregular verbs",
            "25_ Present в значении будущего в английском",
            "26_ Оборот (BE) GOING TO , Собираюсь",
            "27_ Future Simple (I will) _ OK",
            "28_ WILL, SHALL , модальные глаголы в английском",
            "29 MIGHT, MAY , модальные глаголы, modals",
            "30 CAN, COULD (модальные глаголы английского языка)",
            "31 MUST, MUSTN\'T, NEEDN\'T , Должен, нельзя, не нужно",
            "32 SHOULD , следует (сделать) _ Модальные глаголы английского языка",
            "33 HAVE TO , Должен, необходимо, вынужден _ Модальные глаголы и конструкции",
            "34 Модальный глагол WOULD , _бы_ (сослагательное наклонение)",
            "35 Imperative (Do it. Don\'t do it.) , Повелительное наклонение",
            "36 USED TO  , раньше",
            "37 THERE IS, THERE ARE , _Есть_имеется_находится_",
            "38 There was, there will be, there have been. THERE в разных временах",
            "39 Формальное подлежащее IT _ Практика английского языка",
            "40 Короткие ответы в английском. Сокращение по вспомогательному глаголу.",
            "42 Too, Either, So, Neither , _ТОЖЕ_. Как согласиться на английском",
            "43 Отрицательные предложения в английском_ NOT и отрицательные слова",
            "44 Общие вопросы в английском (YES_NO questions)",
            "45 WHO_WHAT questions , Вопросы с who и what в английском",
            "46 Вопрос с предлогом в английском, English questions",
            "47 WHAT, WHICH, HOW , специальные вопросы в английском",
            "48 How long does it take..._ , Сколько времени на это уходит ..._",
            "49 Вопрос к сложному предложению в английском",
            "50 Reported Speech , Косвенная речь",
            "51 Инфинитив и герундий.",
            "52 Инфинитив и герундий Infinitive and gerund (ing,verb)",
            "53 Глагол + объект + to,infinitive",
            "54 TO,infinitive для указания причины в английском",
            "55 Английский глагол GO , Направляться",
            "56 Английский глагол GET",
            "57 DO или MAKE",
            "58 Английский глагол HAVE. 4 случая использования глагола have",
            "59 Личные местоимения в английском (I , ME)",
            "62 I , me , my , mine (английские местоимения)",
            "63 ,SELF, ,SELVES Возвратные местоимения в английском",
            "64 Possesive case , Притяжательный падеж в английском",
            "65 Неопределенный артикль A _ AN",
            "66 Множественное число в английском , Plural",
            "67 Uncountable , Неисчисляемые существительные",
            "68 Местоимение SOME ",
            "70 Артикль THE, популярные случаи (урок 2)",
            "71 Артикль THE (урок 3) Случаи, когда артикль не нужен.",
            "72 Артикль THE (урок 4), нулевой артикль",
            "73 АртикльTHE (урок 5) , географические названия",
            "74 This, that, these, those , Указательные местоимения в английском",
            "75 One_Ones , особые местоимения в английском",
            "76 SOME и ANY",
            "77 Not ... any, no, none, nobody",
            "78 Nobody или NOT ... anybody , сравнение и разница",
            "79 Somebody, anything, nowhere_ неопределенные местоимения в английском",
            "80 ALL и EVERY , сравнение и типичные ошибки русских",
            "81 Количественные слова ALL, MOST, SOME, ANY, NO, NONE",
            "82 Both, either, neither , Оба, один из , ни один",
            "83 Much, many, a lot of , МНОГО на английском",
            "84 Few _ little , МАЛО на английском",
            "85 Adjectives , Прилагательные в английском",
            "86 Adverbs , НАРЕЧИЯ в английском языке",
            "88 Сравнительные прилагательные и THAN",
            "89 AS ... AS , сравнение прилагательных и наречий",
            "90 Превосходная степень прилагательных (Superlative)",
            "91 ENOUGH , Достаточно",
            "92 TOO , СЛИШКОМ",
            "93 Порядок слов в английском предложении (ВАЖНАЯ ТЕМА!)",
            "94 Наречия частотности (always, never) , место в предложении",
            "95 Наречия STILL, ALREADY, YET , порядок слов в английском предложении",
            "96 Два дополнения после GIVE, LEND, PASS, SEND, SHOW",
            "97 And, but, or, so, because , соединение сложных предложений в английском языке",
            "98 WHEN и IF. Условные предложения в английском, введение",
            "99 Условные предложения 1 типа (First Conditional) , разбор английских примеров",
            "100 If Условные предложения 2 типа_ If I did, I would ... Second Conditional",
            "101 Relative clause 1_ WHO, WHICH, THAT",
            "102 Relative clause 2 Без WHO, WHICH, THAT",
            "103 Предлоги IN, ON, AT (урок 1) _ английские предлоги",
            "104 Предлоги FROM ... TO, DURING, WHILE (урок 2) , ПРАКТИКА",
            "105 Before, After, During, While. Предлоги времени в английском языке (урок 3)",
            "106, часть 1 Предлоги места IN, ON, AT (урок 4)",
            "107 Предлоги IN, ON, AT , особые случаи!",
            "108 Предлоги направления TO, IN, AT",
            "110 Английские предлоги направления. Фразовые глаголы , основы",
            "111  Популярные предлоги английского языка ON, AT, BY, WITH, WITHOUT, ABOUT",
            "112, урок 1 Устойчивые предлоги после прилагательных",
            "112, урок 2 Устойчивые предлоги после прилагательных",
            "113 Глагол с предлогом в английском, фразовые глаголы",
            "114 Phrasal verbs (Фразовые глаголы английского языка), урок 1",
            "115 Phrasal verbs (Фразовые глаголы английского языка), урок 2"});
            this.temaComboBox.Location = new System.Drawing.Point(583, 166);
            this.temaComboBox.Name = "temaComboBox";
            this.temaComboBox.Size = new System.Drawing.Size(205, 28);
            this.temaComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.ru_de_RadioButton2);
            this.groupBox1.Controls.Add(this.de_ru_RadioButton2);
            this.groupBox1.Location = new System.Drawing.Point(692, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "INFO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.temaComboBox);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label sentenceLabel;
        private TextBox sentenceTextBox;
        private Button button2;
        private RadioButton ru_de_RadioButton2;
        private RadioButton de_ru_RadioButton2;
        private Button button3;
        private Label correctLabel;
        private TextBox infoTextBox;
        private Label checkLabel;
        private ComboBox temaComboBox;
        private GroupBox groupBox1;
        private Button button4;
    }
}