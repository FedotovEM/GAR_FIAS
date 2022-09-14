using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
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
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string filepath = textBoxFilePath.Text;
            if (File.Exists(filepath))
            {
                textBoxStatus.AppendText("Файл существует.");
                string Table = comboBoxTable.SelectedItem.ToString();

                if (Table == "AsAddrObj" && filepath.Contains("AS_ADDR_OBJ"))
                {
                    var TableContext = ContextDB.AsAddrObj;
                    var reader = XmlReader.Create(filepath);
                    AsAddrObj asAddrObj;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("OBJECT"))
                    {
                        asAddrObj = AsAddrObj.GetAttributeValue(reader);
                        if (!TableContext.Contains(asAddrObj))
                        {
                            TableContext.Add(asAddrObj);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    }
                }
                else if (Table == "AsAddrObjDivision" && filepath.Contains("AS_ADDR_OBJ_DIVISION"))
                {
                    var TableContext = ContextDB.AsAddrObjDivision;
                    var reader = XmlReader.Create(filepath);
                    AsAddrObjDivision asAddrObjDivision;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("ITEM"))
                    {
                        asAddrObjDivision = AsAddrObjDivision.GetAttributeValue(reader);
                        if (!TableContext.Contains(asAddrObjDivision))
                        {
                            TableContext.Add(asAddrObjDivision);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    }
                }
                else if (Table == "AsAddrObjParams" && filepath.Contains("AS_ADDR_OBJ_PARAMS"))
                {
                    var TableContext = ContextDB.AsAddrObjParams;
                    var reader = XmlReader.Create(filepath);
                    AsAddrObjParams asAddrObjParams;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("PARAM"))
                    {
                        asAddrObjParams = AsAddrObjParams.GetAttributeValue(reader);
                        if (!TableContext.Contains(asAddrObjParams))
                        {
                            TableContext.Add(asAddrObjParams);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    }
                }
                else if (Table == "AsAdmHierarchy" && filepath.Contains("AS_ADM_HIERARCHY"))
                {
                    var TableContext = ContextDB.AsAdmHierarchy;
                    var reader = XmlReader.Create(filepath);
                    AsAdmHierarchy asAdmHierarchy;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("ITEM"))
                    {
                        asAdmHierarchy = AsAdmHierarchy.GetAttributeValue(reader);
                        if (!TableContext.Contains(asAdmHierarchy))
                        {
                            TableContext.Add(asAdmHierarchy);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    }
                }
                else if (Table == "AsApartments" && filepath.Contains("AS_APARTMENTS")) 
                {
                    var TableContext = ContextDB.AsApartments;
                    var reader = XmlReader.Create(filepath);
                    AsApartments asApartments;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("APARTMENT"))
                    {
                        asApartments = AsApartments.GetAttributeValue(reader);
                        if (!TableContext.Contains(asApartments))
                        {
                            TableContext.Add(asApartments);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    }
                }
                else if (Table == "AsApartmentsParams" && filepath.Contains("AS_APARTMENTS_PARAMS")) 
                {
                    var TableContext = ContextDB.AsApartmentsParams;
                    var reader = XmlReader.Create(filepath);
                    AsApartmentsParams asApartmentsParams;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("PARAM"))
                    {
                        asApartmentsParams = AsApartmentsParams.GetAttributeValue(reader);
                        if (!TableContext.Contains(asApartmentsParams))
                        {
                            TableContext.Add(asApartmentsParams);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    }
                }
                else if (Table == "AsCarplaces" && filepath.Contains("AS_CARPLACES")) 
                {
                    var TableContext = ContextDB.AsCarplaces;
                    var reader = XmlReader.Create(filepath);
                    AsCarplaces asCarplaces;
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("CARPLACE"))                   
                    {
                        asCarplaces = AsCarplaces.GetAttributeValue(reader);
                        if (!TableContext.Contains(asCarplaces))
                        {
                            TableContext.Add(asCarplaces);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    }
                }
                else if (Table == "AsCarplacesParams" && filepath.Contains("AS_CARPLACES_PARAMS"))
                {
                    var TableContext = ContextDB.AsCarplacesParams;
                    var reader = XmlReader.Create(filepath);
                    AsCarplacesParams asCarplacesParams;                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("PARAM"))
                    {
                        asCarplacesParams = AsCarplacesParams.GetAttributeValue(reader);
                        if (!TableContext.Contains(asCarplacesParams))
                        {
                            TableContext.Add(asCarplacesParams);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    } 
                }
                else if (Table == "AsChangeHistory" && filepath.Contains("AS_CHANGE_HISTORY"))
                {
                    var TableContext = ContextDB.AsChangeHistory;
                    var reader = XmlReader.Create(filepath);
                    AsChangeHistory asChangeHistory;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("ITEM"))
                    {
                        asChangeHistory = AsChangeHistory.GetAttributeValue(reader);
                        if (!TableContext.Contains(asChangeHistory))
                        {
                            TableContext.Add(asChangeHistory);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    }  
                }
                else if (Table == "AsHouses" && filepath.Contains("AS_HOUSES"))
                {
                    var TableContext = ContextDB.AsHouses;
                    var reader = XmlReader.Create(filepath);
                    AsHouses asHouses;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("HOUSE"))
                    {
                        asHouses = AsHouses.GetAttributeValue(reader);
                        if (!TableContext.Contains(asHouses))
                        {
                            TableContext.Add(asHouses);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    } 
                }
                else if (Table == "AsHousesParams" && filepath.Contains("AS_HOUSES_PARAMS"))
                {
                    var TableContext = ContextDB.AsHousesParams;
                    var reader = XmlReader.Create(filepath);
                    AsHousesParams asHousesParams;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("PARAM"))
                    {
                        asHousesParams = AsHousesParams.GetAttributeValue(reader);
                        if (!TableContext.Contains(asHousesParams))
                        {
                            TableContext.Add(asHousesParams);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    } 
                }
                else if (Table == "AsMunHierarchy" && filepath.Contains("AS_MUN_HIERARCHY"))
                {
                    var TableContext = ContextDB.AsMunHierarchy;
                    var reader = XmlReader.Create(filepath);
                    AsMunHierarchy asMunHierarchy;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("ITEM"))
                    {
                        asMunHierarchy = AsMunHierarchy.GetAttributeValue(reader);
                        if (!TableContext.Contains(asMunHierarchy))
                        {
                            TableContext.Add(asMunHierarchy);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    } 
                }
                else if (Table == "AsNormativeDocs" && filepath.Contains("AS_NORMATIVE_DOCS"))
                {
                    var TableContext = ContextDB.AsNormativeDocs;
                    var reader = XmlReader.Create(filepath);
                    AsNormativeDocs asNormativeDocs;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("NORMDOC"))
                    {
                        asNormativeDocs = AsNormativeDocs.GetAttributeValue(reader);
                        if (!TableContext.Contains(asNormativeDocs))
                        {
                            TableContext.Add(asNormativeDocs);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }

                    } 
                }
                else if (Table == "AsReestrObjects" && filepath.Contains("AS_REESTR_OBJECTS"))
                {
                    var TableContext = ContextDB.AsReestrObjects;
                    var reader = XmlReader.Create(filepath);
                    AsReestrObjects asReestrObjects;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("OBJECT"))
                    {
                        asReestrObjects = AsReestrObjects.GetAttributeValue(reader);
                        if (!TableContext.Contains(asReestrObjects))
                        {
                            TableContext.Add(asReestrObjects);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    } 
                }
                else if (Table == "AsRooms" && filepath.Contains("AS_ROOMS")) 
                {
                    var TableContext = ContextDB.AsRooms;
                    var reader = XmlReader.Create(filepath);
                    AsRooms asRooms;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("ROOM"))
                    {
                        asRooms = AsRooms.GetAttributeValue(reader);
                        if (!TableContext.Contains(asRooms))
                        {
                            TableContext.Add(asRooms);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    }

                }
                else if (Table == "AsRoomsParams" && filepath.Contains("AS_ROOMS_PARAMS"))
                {
                    var TableContext = ContextDB.AsRoomsParams;
                    var reader = XmlReader.Create(filepath);
                    AsRoomsParams asRoomsParams;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("PARAM"))
                    {
                        asRoomsParams = AsRoomsParams.GetAttributeValue(reader);
                        if (!TableContext.Contains(asRoomsParams))
                        {
                            TableContext.Add(asRoomsParams);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    } 
                }
                else if (Table == "AsSteads" && filepath.Contains("AS_STEADS"))
                {
                    var TableContext = ContextDB.AsSteads;
                    var reader = XmlReader.Create(filepath);
                    AsSteads asSteads;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("STEAD"))
                    {
                        asSteads = AsSteads.GetAttributeValue(reader);
                        if (!TableContext.Contains(asSteads))
                        {
                            TableContext.Add(asSteads);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    } 
                }
                else if (Table == "AsSteadsParams" && filepath.Contains("AS_STEADS_PARAMS")) 
                {
                    var TableContext = ContextDB.AsSteadsParams;
                    var reader = XmlReader.Create(filepath);
                    AsSteadsParams asSteadsParams;
                    
                    int elementsCount = 0;
                    while (reader.ReadToFollowing("PARAM"))
                    {
                        asSteadsParams = AsSteadsParams.GetAttributeValue(reader);
                        if (!TableContext.Contains(asSteadsParams))
                        {
                            TableContext.Add(asSteadsParams);
                            ContextDB.SaveChanges();
                            elementsCount++;
                            textBoxStatus.AppendText($"\n Строк вставлено: {elementsCount}");
                        }
                    } 

                }
                else
                    textBoxStatus.AppendText($"\n Не удаётся найти соответствие между введённым путём и выбранной таблицей."); 
            }
            else
                textBoxStatus.AppendText($"\n Файл не найден.");
        }

    }
}
