using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WindowsFormsAppGAR.Repository;
using WindowsFormsAppGAR.Repository.Models;

namespace WindowsFormsAppGAR
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static List<T> Deserializer<T>(string filepath)
        {
            List<T> ResultList = new List<T>();
            XmlSerializer xmlser = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
                ResultList = (List<T>)xmlser.Deserialize(fs);
            return ResultList;
        }
       
        string[] TableArray = {
            "AsAddrObj", "AsAddrObjDivision", "AsAddrObjParams",
            "AsAdmHierarchy", "AsApartments", "AsApartmentsParams",
            "AsCarplaces", "AsCarplacesParams", "AsChangeHistory",
            "AsHouses", "AsHousesParams", "AsMunHierarchy",
            "AsNormativeDocs", "AsReestrObjects", "AsRooms",
            "AsRoomsParams", "AsSteads", "AsSteadsParams"
        };
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxTable.Items.AddRange(TableArray);
            ContextDB = new ContextAlpha_FIAS();
        }

        ContextAlpha_FIAS ContextDB;

        private void saveData<Type>(string filepath)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(filepath);
            XmlElement XmlEl = XmlDoc.DocumentElement;

            var TableContext = ContextDB.AsAddrObj;
            AsAddrObj asAddrObj;

            if (XmlEl != null)
            {
                foreach (XmlElement item in XmlEl)
                {
                    asAddrObj = AsAddrObj.GetAttributeValue(item);
                    TableContext.Add(asAddrObj);
                    ContextDB.SaveChanges();
                }
            }
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string filepath = textBoxFilePath.Text;
            if (File.Exists(filepath))
            {
                textBoxStatus.AppendText("Файл существует.");
                string Table = comboBoxTable.SelectedItem.ToString();

                if (Table == "AsAddrObj" && Table.Contains("AS_ADDR_OBJ")) //E:\62\AS_ADDR_OBJ_20220718_8f715f80-fcdf-4ae6-8875-f3dde06d7fdf.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsAddrObj;
                    AsAddrObj asAddrObj;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asAddrObj = AsAddrObj.GetAttributeValue(item);
                            TableContext.Add(asAddrObj);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsAddrObjDivision" && Table.Contains("AS_ADDR_OBJ_DIVISION")) //E:\62\AS_ADDR_OBJ_DIVISION_20220718_6d01dfdc-5a76-4849-bcd8-d421f40812b0.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsAddrObjDivision;
                    AsAddrObjDivision asAddrObjDivision;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asAddrObjDivision = AsAddrObjDivision.GetAttributeValue(item);
                            TableContext.Add(asAddrObjDivision);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsAddrObjParams" && Table.Contains("AS_ADDR_OBJ_PARAMS")) // E:\62\AS_ADDR_OBJ_PARAMS_20220718_682dace2-e359-44bc-a9c6-cca8e5903fa2.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsAddrObjParams;
                    AsAddrObjParams asAddrObjParams;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asAddrObjParams = AsAddrObjParams.GetAttributeValue(item);
                            TableContext.Add(asAddrObjParams);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsAdmHierarchy" && Table.Contains("AS_ADM_HIERARCHY")) // E:\62\AS_ADM_HIERARCHY_20220718_04164ad9-cf24-4e3c-9a60-ac5440fe256f.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsAdmHierarchy;
                    AsAdmHierarchy asAdmHierarchy;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asAdmHierarchy = AsAdmHierarchy.GetAttributeValue(item);
                            TableContext.Add(asAdmHierarchy);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsApartments" && Table.Contains("AS_APARTMENTS")) // E:\62\AS_APARTMENTS_20220718_16ab5577-2908-49bf-84a4-3d7ae996a4e2.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsApartments;
                    AsApartments asApartments;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asApartments = AsApartments.GetAttributeValue(item);
                            TableContext.Add(asApartments);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsApartmentsParams" && Table.Contains("AS_APARTMENTS_PARAMS")) // E:\62\AS_APARTMENTS_PARAMS_20220718_e838441e-b05d-4353-b2f0-9fbb3116ef30.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsApartmentsParams;
                    AsApartmentsParams asApartmentsParams;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asApartmentsParams = AsApartmentsParams.GetAttributeValue(item);
                            TableContext.Add(asApartmentsParams);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsCarplaces" && Table.Contains("AS_CARPLACES")) // E:\62\AS_CARPLACES_20220718_fc2745d4-831a-4b0b-8e12-002737dc8b7f.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsCarplaces;
                    AsCarplaces asCarplaces;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asCarplaces = AsCarplaces.GetAttributeValue(item);
                            TableContext.Add(asCarplaces);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsCarplacesParams" && Table.Contains("AS_CARPLACES_PARAMS")) // E:\62\AS_CARPLACES_PARAMS_20220718_457eddea-b09f-4acf-b3d5-9343a8709945.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsCarplacesParams;
                    AsCarplacesParams asCarplacesParams;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asCarplacesParams = AsCarplacesParams.GetAttributeValue(item);
                            TableContext.Add(asCarplacesParams);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsChangeHistory" && Table.Contains("AS_CHANGE_HISTORY")) // E:\62\AS_CHANGE_HISTORY_20220718_211b2807-a8d7-485d-9569-f65ed2b16f0e.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsChangeHistory;
                    AsChangeHistory asChangeHistory;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asChangeHistory = AsChangeHistory.GetAttributeValue(item);
                            TableContext.Add(asChangeHistory);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsHouses" && Table.Contains("AS_HOUSES")) // E:\62\AS_HOUSES_20220718_ad99dba2-a6ac-4772-8092-c31b283b8eec.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsHouses;
                    AsHouses asHouses;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asHouses = AsHouses.GetAttributeValue(item);
                            TableContext.Add(asHouses);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsHousesParams" && Table.Contains("AS_HOUSES_PARAMS")) // E:\62\AS_HOUSES_PARAMS_20220718_6b934a0b-7ea3-456d-8bc9-7a7d0d0377ed.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsHousesParams;
                    AsHousesParams asHousesParams;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asHousesParams = AsHousesParams.GetAttributeValue(item);
                            TableContext.Add(asHousesParams);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsMunHierarchy" && Table.Contains("AS_MUN_HIERARCHY")) // E:\62\AS_MUN_HIERARCHY_20220718_f124165a-03aa-415d-9f75-ed3315f560a2.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsMunHierarchy;
                    AsMunHierarchy asMunHierarchy;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asMunHierarchy = AsMunHierarchy.GetAttributeValue(item);
                            TableContext.Add(asMunHierarchy);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsNormativeDocs" && Table.Contains("AS_NORMATIVE_DOCS")) // E:\62\AS_NORMATIVE_DOCS_20220718_043022ce-d00f-435f-9ef6-97cfdd123312.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsNormativeDocs;
                    AsNormativeDocs asNormativeDocs;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asNormativeDocs = AsNormativeDocs.GetAttributeValue(item);
                            TableContext.Add(asNormativeDocs);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsReestrObjects" && Table.Contains("AS_REESTR_OBJECTS")) // E:\62\AS_REESTR_OBJECTS_20220718_18ccc35d-49bd-412d-86b9-a4f9642a2f43.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsReestrObjects;
                    AsReestrObjects asReestrObjects;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asReestrObjects = AsReestrObjects.GetAttributeValue(item);
                            TableContext.Add(asReestrObjects);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsRooms" && Table.Contains("AS_ROOMS")) // E:\62\AS_ROOMS_20220718_c8a1b2c3-d72f-4b55-bfd5-34fe751ed575.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsRooms;
                    AsRooms asRooms;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asRooms = AsRooms.GetAttributeValue(item);
                            TableContext.Add(asRooms);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsRoomsParams" && Table.Contains("AS_ROOMS_PARAMS")) // E:\62\AS_ROOMS_PARAMS_20220718_7f320054-6314-447c-992b-7fe5f2f2d5f7.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsRoomsParams;
                    AsRoomsParams asRoomsParams;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asRoomsParams = AsRoomsParams.GetAttributeValue(item);
                            TableContext.Add(asRoomsParams);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsSteads" && Table.Contains("AS_STEADS")) // E:\62\AS_STEADS_20220718_f120732c-2c25-4f57-91cb-e0d945741704.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsSteads;
                    AsSteads asSteads;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asSteads = AsSteads.GetAttributeValue(item);
                            TableContext.Add(asSteads);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else if (Table == "AsSteadsParams" && Table.Contains("AS_STEADS_PARAMS")) // E:\62\AS_STEADS_PARAMS_20220718_c9e22b54-3d1a-483e-8844-8bd9011fbd18.XML
                {
                    XmlDocument XmlDoc = new XmlDocument();
                    XmlDoc.Load(filepath);
                    XmlElement XmlEl = XmlDoc.DocumentElement;

                    var TableContext = ContextDB.AsSteadsParams;
                    AsSteadsParams asSteadsParams;

                    if (XmlEl != null)
                    {
                        foreach (XmlElement item in XmlEl)
                        {
                            asSteadsParams = AsSteadsParams.GetAttributeValue(item);
                            TableContext.Add(asSteadsParams);
                            ContextDB.SaveChanges();
                        }
                    }
                }
                else
                    textBoxStatus.AppendText($"\n Не удаётся найти соответствие между введённым путём и выбраннрй таблицей."); 
            }
            else
                textBoxStatus.AppendText($"\n Файл не найден.");
        }

    }
}
