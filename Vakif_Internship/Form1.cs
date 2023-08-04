using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Vakif_Internship
{
    public partial class Form1 : Form
    {
        private List<string> selectedFilePaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Dosya seçmek için OpenFileDialog oluşturuluyor ve çoklu dosya seçimi etkinleştiriliyor.
            //Sadece C# dosyalarını (*.cs) seçilebilecek şekilde filtre ekleniyor.
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "C# Files (*.cs)|*.cs";

            //Kullanıcı bir veya daha birden fazla dosya seçtiyse, seçilen dosya yolları lbFiles ListBox'a ekleniyor.
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePaths = openFileDialog.FileNames.ToList();
                lbFiles.Items.Clear();
                lbFiles.Items.AddRange(selectedFilePaths.ToArray()); //Seçilen dosya yolları inceleniyor.
            }
        }

        //"Tara" butonuna tıklandığında çalışacak olan olay işleyici.
        private void btnScan_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
            foreach(string filePath in selectedFilePaths) //Seçilen her bir dosya yolu için döngü.
            {
                string fileContent = File.ReadAllText(filePath); //Dosya içeriği okunuyor.
                List<int> lineNumbers = FindBaseExceptionLineNumbers(fileContent); //Hatalı satır numaraları bulunuyor.
                
                if(lineNumbers.Count > 0) //Eğer hatalı satır numaraları bulunduysa:
                {

                    string lineNumbersText = string.Join(", ", myCOnverter(lineNumbers));
                    lbResult.Items.Add(filePath + " - Line Numbers: " +lineNumbersText);
                    
                }

            }
        }

        
        private string[] myCOnverter(List<int> myList)
        {
            string[] converted = new string[myList.Count];
            for (int i = 0; i < myList.Count; i++)
            {
                converted[i] = myList[i].ToString();
            }
            return converted;
        }
        

        //BaseException kullanımlarının bulunduğu satır numaralarını döndüren fonksiyon.
        private List<int> FindBaseExceptionLineNumbers(string content)
        {
            List<int> lineNumbers=new List<int>(); //Hatalı satır numaralarını sakalamak için bir liste oluşturuluyor.
            int lineNumber = 1; //Satır numarası başlangıç değeri.
            string pattern = @"throw\s+new\s+BaseException\("; //BaseException kullanımı tanımlayan Regex deseni.

            using (StringReader reader = new StringReader(content)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Eğer satır içinde BaseException kullanımı bulunuyorsa ve ExceptionTypes içermiyorsa
                    if(Regex.IsMatch(line, pattern) && !line.Contains("ExceptionTypes"))
                    {
                        lineNumbers.Add(lineNumber); //Hatalı satır numarası ekleniyor.
                    }
                    lineNumber++; //Sonraki satıra geçiliyor
                }
            }
            return lineNumbers; //Bulunan hatalı satır numaraları döndürülüyor.
        }


        //Temizle butonuna tıklandığında çalışacak olan olay işleyicisi
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear(); //Dosya ListBox'ı temizleniyor.
            lbResult.Items.Clear();
        }
    }
}
