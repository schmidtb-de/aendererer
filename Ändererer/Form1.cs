using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace Ändererer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Quellpfad.Text = Application.StartupPath;
            Zielpfad.Text = Application.StartupPath;
            btnZiel.Enabled = false;

        }

        private string ReplaceWholeWord(string originalText, string wordToReplace, string replacement)
        {
            var pattern = String.Format(@"\b{0}\b", wordToReplace);
            return Regex.Replace(originalText, pattern, replacement, RegexOptions.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gibt mir alle Unterverzeichnisse zurück 

            string[] strFolders = Directory.GetDirectories(Quellpfad.Text);

            string strZielFolder = string.Empty;



            /*DAS IST RICHTIG HIER*/

            Directory.CreateDirectory(Zielpfad.Text);


            //Durch alle Verzeichnisse laufen 

            foreach (string strFolder in strFolders)
            {

                string[] strFiles = System.IO.Directory.GetFiles(strFolder);
                string[] strEndungen = { "mpeg", "mpg", "mkv", "xvid", "mp4", "avi", "mka" };
                string[] strZuEntfernen = {
                    "GERMAN", "German", "DUBBED", "Dubbed", "UNCUT",
                    "BDRip", "720p", "1080p", "HDTV", "XviD",
                    "WebRip", "x264", "DL", "WEBRip", "BluRay" };

                //const int MaxLength = 240;

                
                    if (chBUmbenennen.Checked == true && chBNurVideo.Checked == false)
                    {

                        foreach (string strFile in strFiles)
                        {

                        string Namealt = Path.GetFullPath(strFile);
                        //string DateiNameLaenge = (Path.GetFileName(System.IO.Path.GetDirectoryName(strFile))).Replace('.', ' ');
                        string DateiNameLaenge = (Path.GetFileName(System.IO.Path.GetDirectoryName(strFile)));
                        for (int i=0; i<strZuEntfernen.Length; i++)
                        DateiNameLaenge = ReplaceWholeWord(ReplaceWholeWord(DateiNameLaenge, strZuEntfernen[i], "").Replace('.', ' '), "  ", " ");

                        string Nameneu = Path.GetDirectoryName(strFile) + "\\" + DateiNameLaenge + Path.GetExtension(strFile);


                        File.Move(Namealt, Nameneu);

                    }
                }
                    if (chBUmbenennen.Checked == true && chBNurVideo.Checked == true)
                    {

                        foreach (string strFile in strFiles)
                        {

                            if (strEndungen.Any(Path.GetExtension(strFile).Contains))
                            {
                                string Namealt = Path.GetFullPath(strFile);
                                string Nameneu = Path.GetDirectoryName(strFile) + "\\" + (Path.GetFileName(System.IO.Path.GetDirectoryName(strFile))).Replace('.', ' ') + Path.GetExtension(strFile);

                                File.Move(Namealt, Nameneu);

                            }
                        }
                    }
                    string[] strFilesneu = System.IO.Directory.GetFiles(strFolder);
                foreach (string strFile in strFilesneu)
                {               

                        if (chBNurVideo.Checked == true)
                        {
                            const int anzahl = 100;
                            pb.Minimum = 0;
                            pb.Maximum = anzahl;

                            if (strEndungen.Any(Path.GetExtension(strFile).Contains))
                            {
                                string strZiel = Path.Combine(Zielpfad.Text, Path.GetFileName(strFile));
                                if (File.Exists(strZiel))
                                    File.Delete(strZiel);
                                System.IO.File.Move(strFile, strZiel);

                                for (int i = 1; i <= anzahl; i++) pb.Value = i;
                            }
                        }
                        else
                        {
                            const int anzahl = 100;
                            pb.Minimum = 0;
                            pb.Maximum = anzahl;

                            string strZiel = Path.Combine(Zielpfad.Text, Path.GetFileName(strFile));
                            if (File.Exists(strZiel))
                                File.Delete(strZiel);
                            System.IO.File.Move(strFile, strZiel);

                            for (int i = 1; i <= anzahl; i++) pb.Value = i;

                        }

                    }
                }

                if (chBUnterordnerlöschen.Checked == true)
                {
                    foreach (string strFolder in strFolders)
                    {
                        const int anzahl = 100;
                        pblöschen.Minimum = 0;
                        pblöschen.Maximum = anzahl;

                        System.IO.Directory.Delete(strFolder, true);
                        for (int i = 1; i <= anzahl; i++) pblöschen.Value = i;
                    }
                }

            
        }

        private void btnQuell_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog(); objDialog.Description = "Beschreibung";

            objDialog.SelectedPath = Application.StartupPath;  //@"C:\"; // Vorgabe Pfad (und danach der gewählte Pfad)  

            DialogResult objResult = objDialog.ShowDialog(this);

            if (objResult == DialogResult.OK) 
                Quellpfad.Text = objDialog.SelectedPath;
 
        }

        private void btnZiel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog objDialog = new FolderBrowserDialog(); objDialog.Description = "Beschreibung";

            objDialog.SelectedPath = Application.StartupPath;  //@"C:\"; // Vorgabe Pfad (und danach der gewählte Pfad)  

            DialogResult objResult = objDialog.ShowDialog(this);

            if (objResult == DialogResult.OK)
                Zielpfad.Text = objDialog.SelectedPath;

        }

        private void chB_ZQ_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_ZQ.Checked)
            {
                Zielpfad.Enabled = true;
                btnZiel.Enabled = true;
            }
            else
            {
                Zielpfad.Text = Quellpfad.Text;
                Zielpfad.Enabled = false;
                btnZiel.Enabled = false;
            }
        }

        private void Quellpfad_TextChanged(object sender, EventArgs e)
        {
            if (chB_ZQ.Checked)
            {
                Zielpfad.Enabled = true;
                btnZiel.Enabled = true;
            }
            else
            {
                Zielpfad.Text = Quellpfad.Text;
                Zielpfad.Enabled = false;
                btnZiel.Enabled = false;
            }
            if (Quellpfad.Text == "" || Zielpfad.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
            }

        private void Zielpfad_TextChanged(object sender, EventArgs e)
        {
            if (Quellpfad.Text == "" || Zielpfad.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void Quellpfad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Quellpfad.SelectAll();
        }

        private void Zielpfad_DoubleClick(object sender, EventArgs e)
        {
            this.Quellpfad.SelectAll();
        }

        private void btnStrgV_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                Quellpfad.Text = Clipboard.GetText();
            }
        }
    }
}
