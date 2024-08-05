using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebilTranslate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartTheme();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void Tra(ref string text, char first, char second)
        {
            // richTextBox2.Text = "";
            text = text.Replace(first, second);
        }

        void StartTheme()
        {
            Color back = ColorTranslator.FromHtml("#2e3242");
            Color backText = ColorTranslator.FromHtml("#13151c");
            Color textColor = ColorTranslator.FromHtml("#9398ab");

            this.BackColor = back;
            this.trnbutton.ForeColor = backText;

            this.richTextBox1.BackColor = backText;
            this.richTextBox2.BackColor = backText;

            this.richTextBox1.ForeColor = textColor;
            this.richTextBox2.ForeColor = textColor;

            this.OutputLabel.ForeColor = textColor;
            this.ToTranslate.ForeColor = textColor;
        }

        void Translate()
        {
            string inputText = richTextBox1.Text;

            //upkeys

            Tra(ref inputText, '!', '!');
            Tra(ref inputText, '@', '"');
            Tra(ref inputText, '#', '№');
            Tra(ref inputText, '$', ';');
            Tra(ref inputText, '%', '%');
            Tra(ref inputText, '^', ':');
            Tra(ref inputText, '&', '?');
            Tra(ref inputText, '*', '*');
            Tra(ref inputText, '(', '(');
            Tra(ref inputText, ')', ')');

            //keys
            Tra(ref inputText, 'q', 'й');
            Tra(ref inputText, 'w', 'ц');
            Tra(ref inputText, 'e', 'у');
            Tra(ref inputText, 'r', 'к');
            Tra(ref inputText, 't', 'е');
            Tra(ref inputText, 'y', 'н');
            Tra(ref inputText, 'u', 'г');
            Tra(ref inputText, 'i', 'ш');
            Tra(ref inputText, 'o', 'щ');
            Tra(ref inputText, 'p', 'з');
            Tra(ref inputText, '[', 'х');
            Tra(ref inputText, ']', 'ъ');
            Tra(ref inputText, 'a', 'ф');
            Tra(ref inputText, 's', 'ы');
            Tra(ref inputText, 'd', 'в');
            Tra(ref inputText, 'f', 'а');
            Tra(ref inputText, 'g', 'п');
            Tra(ref inputText, 'h', 'р');
            Tra(ref inputText, 'j', 'о');
            Tra(ref inputText, 'k', 'л');
            Tra(ref inputText, 'l', 'д');
            Tra(ref inputText, ';', 'ж');
            Tra(ref inputText, '\'', 'э');
            Tra(ref inputText, 'z', 'я');
            Tra(ref inputText, 'x', 'ч');
            Tra(ref inputText, 'c', 'с');
            Tra(ref inputText, 'v', 'м');
            Tra(ref inputText, 'b', 'и');
            Tra(ref inputText, 'n', 'т');
            Tra(ref inputText, 'm', 'ь');
            Tra(ref inputText, ',', 'б');
            Tra(ref inputText, '.', 'ю');
            Tra(ref inputText, '/', '.');

            //caps

            Tra(ref inputText, 'Q', 'Й');
            Tra(ref inputText, 'W', 'Ц');
            Tra(ref inputText, 'E', 'У');
            Tra(ref inputText, 'R', 'К');
            Tra(ref inputText, 'T', 'Е');
            Tra(ref inputText, 'Y', 'Н');
            Tra(ref inputText, 'U', 'Г');
            Tra(ref inputText, 'I', 'Ш');
            Tra(ref inputText, 'O', 'Щ');
            Tra(ref inputText, 'P', 'З');
            Tra(ref inputText, '{', 'Х');
            Tra(ref inputText, '}', 'Ъ');
            Tra(ref inputText, 'A', 'Ф');
            Tra(ref inputText, 'S', 'Ы');
            Tra(ref inputText, 'D', 'В');
            Tra(ref inputText, 'F', 'А');
            Tra(ref inputText, 'G', 'П');
            Tra(ref inputText, 'H', 'Р');
            Tra(ref inputText, 'J', 'О');
            Tra(ref inputText, 'K', 'Л');
            Tra(ref inputText, 'L', 'Д');
            Tra(ref inputText, ':', 'Ж');
            Tra(ref inputText, '"', 'Э');
            Tra(ref inputText, 'Z', 'Я');
            Tra(ref inputText, 'X', 'Ч');
            Tra(ref inputText, 'C', 'С');
            Tra(ref inputText, 'V', 'М');
            Tra(ref inputText, 'B', 'И');
            Tra(ref inputText, 'N', 'Т');
            Tra(ref inputText, 'M', 'Ь');
            Tra(ref inputText, '<', 'Б');
            Tra(ref inputText, '>', 'Ю');
            //Tra(ref inputText, '?', ',');

            richTextBox2.Text = inputText;
        }

        private void trnbutton_Click(object sender, EventArgs e)
        {
            Translate();
        }
    }
}
