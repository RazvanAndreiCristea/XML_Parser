using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FirmaCurierat
{
    public partial class MainForm : Form
    {
        private string strXmlPath = string.Empty;
        private string strHtmlPath = string.Empty;
        private string strJsonPath = string.Empty;

        public MainForm()
        {
            InitializeComponent();

            cbFilterOptions.SelectedIndex = 0;
        }

        private List<Livrare> parseXmlFile(string strXmlFilePath)
        {
            if (!File.Exists(strXmlFilePath))
            {
                throw new FileNotFoundException("The specified XML file was not found.");
            }

            XDocument xmlDocument = XDocument.Load(strXmlFilePath);

            List<Livrare> livrari = xmlDocument.Descendants("livrare")
                                          .Select(livrare => new Livrare(livrare))
                                          .ToList();

            return livrari;
        }

        private List<Livrare> parseJsonFile(string strJsonFilePath)
        {
            if (!File.Exists(strJsonFilePath))
            {
                throw new FileNotFoundException("The specified JSON file was not found.");
            }

            dynamic jsonDocument = JObject.Parse(File.ReadAllText(strJsonFilePath));

            List<Livrare> livrari = new List<Livrare>();

            foreach (var livrareJson in jsonDocument.livrari)
            {
                Livrare livrare = new Livrare(livrareJson);
                livrari.Add(livrare);
            }

            if (cbFilterOptions.SelectedIndex != 0)
            {
                livrari = livrari.Where(livrare => livrare.TipLivrare.Equals(cbFilterOptions.Text)).ToList();
                return livrari;
            }

            if (tbFilterKeyword.Text != string.Empty)
            {
                livrari = livrari.Where(livrare => livrare.Destinatar.Nume.Contains(tbFilterKeyword.Text) ||
                                                    livrare.Colet.TipAmbalaj.Contains(tbFilterKeyword.Text)).ToList();

                return livrari;
            }

            return livrari;
        }

        private void populateListView(List<Livrare> livrari)
        {
            this.lvFileContent.Items.Clear();

            foreach (Livrare livrare in livrari)
            {
                ListViewItem item = new ListViewItem(livrare.Id.ToString());

                item.SubItems.Add(livrare.TipLivrare);
                item.SubItems.Add(livrare.Destinatar.Nume);
                item.SubItems.Add(livrare.Destinatar.Telefon);
                item.SubItems.Add(livrare.Destinatar.Email);
                item.SubItems.Add(livrare.Destinatar.Adresa);
                item.SubItems.Add(livrare.Expeditor);
                item.SubItems.Add(livrare.Colet.Destinatie);
                item.SubItems.Add(livrare.DataProgramata.ToString("dd-MM-yyyy"));
                item.SubItems.Add(livrare.StareLivrare);
                item.SubItems.Add(livrare.LocatieCurenta);
                item.SubItems.Add($"{livrare.Colet.Lungime}x{livrare.Colet.Latime}x{livrare.Colet.Inaltime} {livrare.Colet.UnitateMasuraDimensiuni}");
                item.SubItems.Add(livrare.Colet.Greutate.ToString());
                item.SubItems.Add(livrare.Colet.Valoare.ToString());
                item.SubItems.Add(livrare.Colet.TipAmbalaj);
                item.SubItems.Add(livrare.Colet.Continut);

                this.lvFileContent.Items.Add(item);
            }
        }

        private void btnBrowseXmlFile_Click(object sender, EventArgs e)
        {
            if (tbXmlFilePath.Text != string.Empty)
            {
                strXmlPath = string.Empty;
                tbXmlFilePath.Text = string.Empty;
            }

            if (btnParseXml.Enabled == true)
            {
                btnParseXml.Enabled = false;
            }

            OpenFileDialog browseXmlFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml",
                Title = "Select the XML file",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (browseXmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                strXmlPath = browseXmlFileDialog.FileName;
                tbXmlFilePath.Text = browseXmlFileDialog.FileName;
                btnParseXml.Enabled = true;
            }
        }

        private void btnBrowseJsonFile_Click(object sender, EventArgs e)
        {
            if (tbJsonFilePath.Text != string.Empty)
            {
                strJsonPath = string.Empty;
                tbJsonFilePath.Text = string.Empty;
            }

            if (btnParseJson.Enabled == true)
            {
                btnParseJson.Enabled = false;
            }

            OpenFileDialog browseJsonFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Select the JSON file",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (browseJsonFileDialog.ShowDialog() == DialogResult.OK)
            {
                strJsonPath = browseJsonFileDialog.FileName;
                tbJsonFilePath.Text = browseJsonFileDialog.FileName;
                btnParseJson.Enabled = true;
            }
        }

        private void btnParseXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Livrare> livrari = parseXmlFile(strXmlPath);

                populateListView(livrari);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnParseJson_Click(object sender, EventArgs e)
        {
            if (cbFilterOptions.SelectedIndex == 0 && tbFilterKeyword.Text == string.Empty)
            {
                MessageBox.Show("Please select a filter option or enter a keyword!", "Invalid filter option or keyword", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Livrare> livrari = parseJsonFile(strJsonPath);

                if (livrari.Count == 0)
                {
                    MessageBox.Show("No results found!", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                populateListView(livrari);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnShowXsl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(strXmlPath))
            {
                MessageBox.Show("Please select the XML file first!", "Nonexistent XML file path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            strHtmlPath = strXmlPath.Replace(".xml", ".html");

            try
            {
                webXslStyle.Navigate(strHtmlPath);
            }
            catch { }
        }
    }
}