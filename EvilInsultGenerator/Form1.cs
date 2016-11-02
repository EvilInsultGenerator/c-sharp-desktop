using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace EvilInsultGenerator
{

    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            // Set the default selection to the 5th entry ('en' at the moment)
            combLang.SelectedIndex = 4;
            rtxtInsult.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Get %TEMP% path of current user
        public string GetTempPath()
        {
            string path = Environment.GetEnvironmentVariable("TEMP");
            if (!path.EndsWith("\\")) path += "\\";
            return path;
        }

        // Logging Setup
        public void LogMessageToFile(string msg)
        {
            StreamWriter sw = File.AppendText(
                GetTempPath() + "EIG_Desktop.log");

            try
            {
                string logLine = String.Format(
                    "{0:G}: {1}.", DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }


        }

        // Send our Request to the server
        private string SendRequest(string url)
        {
            try
            {

                using (WebClient client = new WebClient())
                {
                    // Fixed funky chingchang yellow nigger signs
                    client.Encoding = Encoding.UTF8;
                    // We no need no Proxycation
                    return client.DownloadString(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                rtxtInsult.Text = "Fucking Error " + ex;
                LogMessageToFile("Fucking Exception:" + ex);
                return null;
            }
        }

        // On Form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Check if previous .log is found
            if (File.Exists(GetTempPath() + "EIG_Desktop.log"))
            {
                // and then delete it.
                File.Delete(GetTempPath() + "EIG_Desktop.log");
                LogMessageToFile("Info: Found old log file - Removed");

            }
            LogMessageToFile("Info: EIG started");
        }

        // Generate Insult Button
        // The User wants to generate some insults!
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Convert selection to a string
            string lang = combLang.SelectedItem.ToString();

            //JSON.Net
            // string response = SendRequest("https://evilinsult.com/generate_insult.php?type=json&lang=" + lang);

            // Send Request to server and save the response as a string
            string response = SendRequest("https://evilinsult.com/generate_insult.php?type=xml&lang=" + lang);

            // Something broke the language selection? No worries. Default is english.
            if (string.IsNullOrWhiteSpace(lang))
            {
                lang = "en";
                LogMessageToFile("Error: Language selection failed");

            }
            if (response != null)
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(response);
                string insult = xmlDoc.DocumentElement.SelectSingleNode("/insult_info/insult").InnerText;

                // Who needs JSON when you have XML!
                // JObject ob = JObject.Parse(response);
                // string insult = (string)ob["insult"];

                // Set the Output
                rtxtInsult.Text = insult;

                LogMessageToFile("Info: Insult: --- " + insult + " --- in language: " + lang + " generated");
            }
            else
            {
                rtxtInsult.Text = "The Server did not provide any data";
                LogMessageToFile("Error: The server did not respond with data");
            }
        }

        // Copy to Clipboard Button
        private void btnCopy_Click(object sender, EventArgs e)
        {   
            // Hidden Exception Handling - nothing to copy? Just use it as Easter Egg!
            if (string.IsNullOrWhiteSpace(rtxtInsult.Text))
            {
                Clipboard.SetText("3.141592653589793238462643383279502884197169 39937510582097494459230781640628620899862803 48253421170679821480865132823066470938446095 50582231725359408128481117450284102701938521 10555964462294895493038196442881097566593344 61284756482337867831652712019091456485669234 60348610454326648213393607260249141273724587 00660631558817488152092096282925409171536436 78925903600113305305488204665213841469519415 11609433057270365759591953092186117381932611 79310511854807446237996274956735188575272489 12279381830119491298336733624406566430860213 94946395224737190702179860943702770539217176 29317675238467481846766940513200056812714526 35608277857713427577896091736371787214684409 01224953430146549585371050792279689258923542 01995611212902196086403441815981362977477130 99605187072113499999983729780499510597317328 16096318595024459455346908302642522308253344 68503526193118817101000313783875288658753320 83814206171776691473035982534904287554687311 59562863882353787593751957781857780532171226 806613001927876611195909216420198");
                LogMessageToFile("Info: Easter Egg found");

            }
            else
            {
                Clipboard.SetText(rtxtInsult.Text);
                LogMessageToFile("Info: Insult copied to clipboard");

            }
        }

        // ToolStrip Stuff

        // "Website" clicked
        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://evilinsult.com");
            LogMessageToFile("Info: 'Website' clicked");

        }
        // "About" clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
            LogMessageToFile("Info: 'About' clicked");

        }
        // "GitHub" clicked
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/EvilInsultGenerator");
            LogMessageToFile("Info: 'GitHub' clicked");

        }
        // "Propasal" clicked
        private void proposalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:marvin@evilinsult.com?Subject=Evil%20Insult%20Generator%20Proposal&Body=Hej%20fuckers%2C%0A%0Aplease%20add%20this%20beauty%3A%0A%0Ainsult%3A%20...%0Alanguage%3A%20...%0Acomment%20%28optional%29%3A%20...%0A%0A...%0A");
            LogMessageToFile("Info: 'Proposal' clicked.");

        }
        // "Contact" clicked
        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:marvin@evilinsult.com?Subject=Evil%20Insult%20Generator%20Contact&Body=Marvin%2C%20fuck%20you%21");
            LogMessageToFile("Info: 'Contact' clicked");

        }
        // "Newsletter" clicked
        private void newsletterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://evilinsult.com/newsletter/");
            LogMessageToFile("Info: 'Newsletter' clicked");

        }
        // "Legal" clicked
        private void legalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://evilinsult.com/legal.html");
            LogMessageToFile("Info: 'Legal' clicked");

        }
        // "Facebook" clicked
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/EvilInsultGenerator/");
            LogMessageToFile("Info: 'Facebook' clicked");

        }
        // "Twitter" clicked
        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/__E__I__G__");
            LogMessageToFile("Info: 'Twitter' clicked");

        }

        // "Check Updates" clicked
        // Start Update Routine
        private void updateCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogMessageToFile("Info: 'Check Update' clicked");
            string downloadUrl = "";
            Version newVersion = null;
            string aboutUpdate = "";
            string xmlUrl = "https://evilinsult.com/update.xml";
            XmlTextReader reader = null;
            // Try to parse the XML from the server
            try
            {
                reader = new XmlTextReader(xmlUrl);
                reader.MoveToContent();
                string elementName = "";
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "appinfo"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            elementName = reader.Name;
                        }
                        else
                        {
                            if ((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                                switch (elementName)
                                {
                                    case "version":
                                        newVersion = new Version(reader.Value);
                                        break;
                                    case "url":
                                        downloadUrl = reader.Value;
                                        break;
                                    case "about":
                                        aboutUpdate = reader.Value;
                                        break;
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessageToFile("Error: " + ex);
                MessageBox.Show(ex.Message);
                Environment.Exit(1);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            // Compare Version Numbers
            Version applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (applicationVersion.CompareTo(newVersion) < 0)
            {
                string str = String.Format("New version found!\nYour version: {0}.\nNewest version: {1}. \nAdded in this version: {2}. ", applicationVersion, newVersion, aboutUpdate);
                LogMessageToFile("Info: An Update was found.");
                if (DialogResult.No != MessageBox.Show(str + "\nWould you like to download this update?", "Check for updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        // Launch the Browser for download (simpler)
                        Process.Start(downloadUrl);
                    }
                    catch { }
                    return;
                }
                else
                {
                    ;
                }
            }
            else
            {
                MessageBox.Show("Your version: " + applicationVersion + "  is up to date.", "Check for Updates", MessageBoxButtons.OK, MessageBoxIcon.None);
                LogMessageToFile("Info: No Update was found.");
            }
        }
    }
}