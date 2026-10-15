using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PHONE_BOOK
{
    internal class Storage_Manger
    {
        public enum StorageType
        {
            Array, List, File, Database
        }

        public static StorageType Currentstorage = StorageType.Array;

        public static bool Add(string name, string phone)
        {
            if (Currentstorage == StorageType.Array)
            {
                for (int i = 0; i < Model.names.Length; i++)
                {
                    if (Model.names[i] == null && Model.phoneNumbers[i] == null)
                    {
                        Model.names[i] = name;
                        Model.phoneNumbers[i] = phone;
                        return true;
                    }
                }
            }
            else if (Currentstorage == StorageType.List)
            {
                Model.Contact.Add(name + " - " + phone);
                return true;
            }
            else if (Currentstorage == StorageType.File)
            {
                string filePath = "contacts.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(name + " - " + phone);
                }
                return true;
            }
            else if (Currentstorage == StorageType.Database)
            {
                string connect_server = @"Server= .\ANAS ;Database= PHONE_BOOK ;User Id= sa ;Password= 123;";
                SqlConnection connection = new SqlConnection(connect_server);
                string query = "EXEC INSERT_DATA '" + name + "','" + phone + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }

            return false;
        }

        public static bool Remove(string name)
        {
            if (Currentstorage == StorageType.Array)
            {
                for (int i = 0; i < Model.names.Length; i++)
                {
                    if (Model.names[i] == name)
                    {
                        Model.names[i] = null;
                        Model.phoneNumbers[i] = null;
                        return true;
                    }
                }
            }
            else if (Currentstorage == StorageType.List)
            {
                for (int i = 0; i < Model.Contact.Count; i++)
                {
                    if (Model.Contact[i].StartsWith(name + " - "))
                    {
                        Model.Contact.RemoveAt(i);
                        return true;
                    }
                }
            }

            else if (Currentstorage == StorageType.File)
            {
                string filePath = "contacts.txt";
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        if (!line.StartsWith(name + " - "))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
                return true;
            }
            else if (Currentstorage == StorageType.Database)
            {
                string connect_server = @"Server= .\ANAS ;Database= PHONE_BOOK ;User Id= sa ;Password= 123;";
                SqlConnection connection = new SqlConnection(connect_server);
                string query = "EXEC REMOVE_CONTACT '" + name + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            return false;
        }

        public static bool Edit(string oldName, string newName, string newPhone)
        {
            if (Currentstorage == StorageType.Array)
            {
                for (int i = 0; i < Model.names.Length; i++)
                {
                    if (Model.names[i] == oldName)
                    {
                        Model.names[i] = newName;
                        Model.phoneNumbers[i] = newPhone;
                        return true;
                    }
                }
            }
            else if (Currentstorage == StorageType.List)
            {
                for (int i = 0; i < Model.Contact.Count; i++)
                {
                    if (Model.Contact[i].StartsWith(oldName + " - "))
                    {
                        Model.Contact[i] = newName + " - " + newPhone;
                        return true;
                    }
                }
            }

            else if (Currentstorage == StorageType.File)
            {
                string filePath = "contacts.txt";
                string[] lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        if (line.StartsWith(oldName + " - "))
                        {
                            writer.WriteLine(newName + " - " + newPhone);
                            return true;
                        }
                    }
                }
            }
            else if (Currentstorage == StorageType.Database)
            {
                string connect_server = @"Server= .\ANAS ;Database= PHONE_BOOK ;User Id= sa ;Password= 123;";
                SqlConnection connection = new SqlConnection(connect_server);
                string query = "EXEC EDIT_CONTACT '" + oldName + "','" + newName + "','" + newPhone + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            return false;
        }

        public static void Search(string name)
        {
            if (Currentstorage == StorageType.Array)
            {
                for (int i = 0; i < Model.names.Length; i++)
                {
                    if (Model.names[i] == name)
                    {
                        MessageBox.Show("تم العثور على البيانات بنجاح\nالاسم: " + Model.names[i] + "\nرقم الهاتف: " + Model.phoneNumbers[i], "message", MessageBoxButtons.OKCancel);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على الاسم المدخل", "message", MessageBoxButtons.OKCancel);
                        break;
                    }
                }
            }
            else if (Currentstorage == StorageType.List)
            {
                for (int i = 0; i < Model.Contact.Count; i++)
                {
                    if (Model.Contact[i].StartsWith(name + " - "))
                    {
                        MessageBox.Show("تم العثور على البيانات بنجاح\n" + Model.Contact[i], "message", MessageBoxButtons.OKCancel);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على الاسم المدخل", "message", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                        break;
                    }
                }
            }

            else if (Currentstorage == StorageType.File)
            {
                string filePath = "contacts.txt";
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (line.StartsWith(name + " - "))
                    {
                        MessageBox.Show("تم العثور على البيانات بنجاح\n" + line, "message", MessageBoxButtons.OKCancel);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على الاسم المدخل", "message", MessageBoxButtons.OKCancel);
                        break;
                    }
                }
            }
            else if (Currentstorage == StorageType.Database)
            {
                string connect_server = @"Server= .\ANAS ;Database= PHONE_BOOK ;User Id= sa ;Password= 123;";
                SqlConnection connection = new SqlConnection(connect_server);
                string query = "EXEC SEARCH_CONTACT '" + name + "'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    string foundName = reader.GetString(0);
                    string foundPhone = reader.GetString(1);
                    MessageBox.Show("تم العثور على البيانات بنجاح\nالاسم: " + foundName + "\nرقم الهاتف: " + foundPhone, "message", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على الاسم المدخل", "message", MessageBoxButtons.OKCancel);
                }
                reader.Close();
                connection.Close();
            }

        }

        public static string DisplayAll()
        {
            string allContacts = "";
            if (Currentstorage == StorageType.Array)
            {
                for (int i = 0; i < Model.names.Length; i++)
                {
                    if (Model.names[i] != null)
                    {
                      allContacts += "الاسم: " + Model.names[i] + Environment.NewLine + "رقم الهاتف: " + Model.phoneNumbers[i] + Environment.NewLine + Environment.NewLine;
                    }
                }
                return allContacts;
            }
            else if (Currentstorage == StorageType.List)
            {
                for (int i = 0; i < Model.Contact.Count; i++)
                {
                   allContacts += Model.Contact[i] + Environment.NewLine + Environment.NewLine;
                }
                return allContacts;
            }
            else if (Currentstorage == StorageType.File)
            {
                string filePath = "contacts.txt";
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    allContacts += line + Environment.NewLine + Environment.NewLine;
                }
                return allContacts;
            }
            else if (Currentstorage == StorageType.Database)
            {
                string connect_server = @"Server= .\ANAS ;Database= PHONE_BOOK ;User Id= sa ;Password= 123;";
                SqlConnection conn = new SqlConnection(connect_server);
                string cmd = "EXEC SHOW_ALL";
                SqlCommand command = new SqlCommand(cmd, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    allContacts += reader.GetString(0) + " - " + reader.GetString(1) + Environment.NewLine + Environment.NewLine;
                }
                conn.Close();
                return allContacts;
            }
             return allContacts;
        }
    }
}
