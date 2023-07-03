using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;
using Microsoft.SqlServer.Management.Smo.Agent;

namespace BetechBackup
{
    public partial class BetechBackup_Form : Form
    {
        public BetechBackup_Form()
        {
            InitializeComponent();
        }

        string secilen_veritabani;
        string path = "D:\\Backupyedek";

        string[] database_array;

        private void BetechBackup_Form_Load(object sender, EventArgs e)
        {
            /*

            var server = new Microsoft.SqlServer.Management.Smo.Server(".\\YUZGUL");
            var database_num = 0;

            foreach (Database db in server.Databases)
            {
                comboBox_veritabani.Items.Add(db.Name);
                listBox_veritabanlari.Items.Add(db.Name);
                database_num++;
            }
            database_array = new string[database_num];

            int i = 0;
            foreach (Database db in server.Databases)
            {
                database_array[i] = db.Name;
                Console.WriteLine(database_array[i]);
                i++;
            }
            textBox_path.Text = path;
            */

            string ServerName = Environment.MachineName;
            Microsoft.Win32.RegistryView registryView = Environment.Is64BitOperatingSystem ? Microsoft.Win32.RegistryView.Registry64 : Microsoft.Win32.RegistryView.Registry32;
            using (Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, registryView))
            {
                Microsoft.Win32.RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        if (instanceName == "MSSQLSERVER")
                        {
                            cmbServerName.Items.Add(ServerName);
                        }
                        else
                        {
                            cmbServerName.Items.Add(ServerName + " \\" + instanceName);
                        }
                    }
                }
            }
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedeklenecek yolu seçiniz.";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak) | *.bak |Tüm Dosyalar(*.*) |*.*";

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = fbd.SelectedPath;
            }

            /*
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = saveFileDialog1.FileName;
            }
            */
        }

        //string temp_adres = "C:\\backupyedek";

        private void btn_yedekle_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\backupyedek";

                bool exists = Directory.Exists(path);
                if (exists)
                {
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
                SqlConnection dbcon = new SqlConnection("Data Source=" + cmbServerName.Text + ";Initial Catalog=" + cmbDBName.Text + ";" + "Integrated Security=True;");
                string database = dbcon.Database.ToString();
                string cmd = @"BACKUP DATABASE [" + cmbDBName.Text + "] TO DISK= '" + path + "\\" + "database-" + cmbDBName.Text +"-"+ DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                dbcon.Open();
                SqlCommand command = new SqlCommand(cmd, dbcon);
                command.ExecuteNonQuery();
                dbcon.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Yedek alınırken bir sorun oluştu");
            }
            /*            
            for (int i = 0; i < database_array.Length; i++)
            {
                try
                {
                    SqlConnection dbcon = new SqlConnection("Data Source=.\\YUZGUL;Initial Catalog=" +   database_array[i] + ";" + "Integrated Security=True;");
                    string database = dbcon.Database.ToString();

                    string temp_adres = "C:\\backupyedek";
                    string cmd = @"BACKUP DATABASE [" +   database_array[i] + "] TO DISK= '" + temp_adres + "\\" + "database-" +   database_array[i] + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    dbcon.Open();
                    SqlCommand command = new SqlCommand(cmd, dbcon);
                    command.ExecuteNonQuery();
                    dbcon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Backup işleminde bir hata var : " + ex.Message);
                }
            }

            */
            /* Benim yaptığım 
            SqlConnection dbcon = new SqlConnection("Data Source=.\\YUZGUL;Initial Catalog=tarikyuzgul;Integrated Security=True;");
            try
            {
            dbcon.Open();
                MessageBox.Show("Bağlantı hazır");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı hazır değil");
            }
            Server dbservercon = new Server(new ServerConnection());
*/
            /* İnternette yapılan uygulama 
            //string connectionString = @"Data Source=YUZGUL/YUZGUL;Integrated Security=True;";
            Server dbServer = new Server(new ServerConnection(textBox_server.Text));
            MessageBox.Show(dbServer.Name);
            Backup dbBackup = new Backup();
            dbBackup.Action = BackupActionType.Database;
            dbBackup.Database = textBox_database.Text;
            dbBackup.Devices.AddDevice(textBox_path.Text, DeviceType.File);
            dbBackup.Initialize = false;
            //dbBackup.Complete += DbBackup_Complete;
            dbBackup.SqlBackup(dbServer);
*/
        }
        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Yedekleme işlemi başarılı bir şekilde tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_veritabani_SelectedIndexChanged(object sender, EventArgs e)
        {
            //secilen_veritabani = cmbDBName.Text;
            textBox_database.Text = cmbDBName.Text;
        }

        private void button_klasor_optimizasyon_Click(object sender, EventArgs e)
        {
            string dizin = "C:\\backupyedek";
            var tumDosyalar = Directory.GetFiles(dizin, "*.*", SearchOption.AllDirectories);

            int min_dosya_sayisi = 0;
            var en_eski_temp = DateTime.Now;

            foreach (var dosya in tumDosyalar)
            {
                min_dosya_sayisi++;
                Console.WriteLine(dosya);
                var dateTime = File.GetCreationTime(dosya) /*.ToString("yyyy-MM-dd--HH-mm-ss")*/;
                //dateTime.AddDays(10);
                Console.WriteLine(dateTime.Second.ToString());
                var tarih_farki = (DateTime.Now - dateTime)/*.ToString("yyyy-MM-dd--HH-mm-ss")*/;
                Console.WriteLine("Tarih farki " + tarih_farki.Minutes.ToString());

                if (tarih_farki.Minutes >= 1)
                {
                    File.Delete(dosya);
                }
                var yil_farki = DateTime.Now.Year - dateTime.Year;
                var ay_farki = DateTime.Now.Month - dateTime.Month;
                var gun_farki = DateTime.Now.Day - dateTime.Day;
                var saat_farki = DateTime.Now.Hour - dateTime.Hour;
                var dakika_farki = DateTime.Now.Minute - dateTime.Minute;
                var saniye_farki = DateTime.Now.Second - dateTime.Second;

                Console.WriteLine(yil_farki + "yıl" + ay_farki + "ay_farki" + gun_farki + "gun_farki" + saat_farki + "saat_farki" + dakika_farki + "dakika_farki" + saniye_farki + "saniye_farki");

            }
            Console.ReadLine();
            // 
            Console.WriteLine(min_dosya_sayisi);

            if (min_dosya_sayisi > 3)
            {
                var en_eski = DateTime.Now;
            }

        }

        private void cmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            Server dbServer = new Server(new ServerConnection(cmbServerName.Text));
            //MessageBox.Show(dbServer.Name);
            string conString = "Data Source ="+ dbServer.Name.ToString() + "; Integrated Security=True";
            //DESKTOP - IL6RP3E\SQLEXPRESS
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            var command = new System.Data.SqlClient.SqlCommand();   
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select name from master.sys.databases";

            var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            var dataset = new DataSet();
            adapter.Fill(dataset);
            DataTable dtDatabases = dataset.Tables[0];


            cmbDBName.Items.Clear();
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                cmbDBName.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                connection.Close();
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz bir sunucu seçtiniz!!!");
            }
        }
    }
}
