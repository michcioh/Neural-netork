using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Neural
{
    public static class Tools
    {
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            FileInfo fi = new FileInfo(fileName);
            if (fi.Exists) fi.Delete();

            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, serializableObject);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(fileName);
                stream.Close();
            }
        }

        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return objectOut;
        }

        public static String DoubleToString(double value, int dotPlaces)
        {
            String ret = Math.Round(value, dotPlaces).ToString().Replace(",", ".");
            int howManyZerosAdd = 0;
            int dotIdx = ret.IndexOf(".");
            if (dotIdx == -1)
            {
                ret += ".";
                howManyZerosAdd = dotPlaces;
            } else
            {
                howManyZerosAdd = dotPlaces - (ret.Length - dotIdx - 1);
            }

            for (int place = 0; place < howManyZerosAdd; place++)
            {
                ret += "0";
            }

            return ret;
        }

        public static DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            if (dgv_copy.Columns.Count == 0)
            {
                foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                {
                    dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                }
            }

            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < dgv_org.Rows.Count; i++)
            {
                row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                int intColIndex = 0;
                foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                {
                    row.Cells[intColIndex].Value = cell.Value;
                    intColIndex++;
                }
                dgv_copy.Rows.Add(row);
            }

            dgv_copy.Refresh();

            return dgv_copy;
        }

        public static void DoubleBuffered(this ProgressBar pb, bool setting)
        {
            var dgvType = pb.GetType();
            var pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(pb, setting, null);
        }
    }
}
