using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eassistant.Modules
{
    public partial class Translator : UserControl
    {
        uint isRussian = 0;
        Classes.YandexTranslator yt;
        string lang = "ru_en";

        public Translator()
        {
            InitializeComponent();
            yt = new Classes.YandexTranslator();
        }

        private void pictureBoxChangeLanguage_Click(object sender, EventArgs e)
        {
            if(isRussian % 2 == 0)
            {
                var RusImg = pictureBoxFlagFrom.Image;
                pictureBoxFlagFrom.Image = pictureBoxFlagTo.Image;
                pictureBoxFlagTo.Image = RusImg;
                lang = "en_ru";
                isRussian++;
            }
            else
            {
                var EngImg = pictureBoxFlagTo.Image;
                pictureBoxFlagTo.Image = pictureBoxFlagFrom.Image;
                pictureBoxFlagFrom.Image = EngImg;
                lang = "ru-en";
                isRussian++;
            }
        }
    }
}
