using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Xml;
using GAR_FIAS_WorkerService.Helpers;
using GAR_FIAS_WorkerService.Repository;
using GAR_FIAS_WorkerService.Repository.Models;

namespace GAR_FIAS_WorkerService
{
    class WorkWithData
    {
        static ContextAlpha_FIAS ContextDB;
        private static HttpClient GetClient() => new HttpClient(new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        });

        public static void Insert()
        {
            ContextDB = new ContextAlpha_FIAS();            

            string dirName = ConfigurationHelper.GetSectionValue("dirName");

            string[] filePaths = Directory.GetFiles(dirName);

            foreach (string filepath in filePaths)
            {
                if (File.Exists(filepath))
                {
                    if (filepath.Contains("AS_ADDR_OBJ") && !filepath.Contains("AS_ADDR_OBJ_TYPES"))
                    {
                        var TableContext = ContextDB.AsAddrObjs;
                        var reader = XmlReader.Create(filepath);
                        AsAddrObj asAddrObj;

                        while (reader.ReadToFollowing("OBJECT"))
                        {
                            asAddrObj = AsAddrObj.GetAttributeValue(reader);
                            if (!TableContext.Contains(asAddrObj))
                            {
                                TableContext.Add(asAddrObj);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_ADDR_OBJ_DIVISION"))
                    {
                        var TableContext = ContextDB.AsAddrObjDivisions;
                        var reader = XmlReader.Create(filepath);
                        AsAddrObjDivision asAddrObjDivision;

                        while (reader.ReadToFollowing("ITEM"))
                        {
                            asAddrObjDivision = AsAddrObjDivision.GetAttributeValue(reader);
                            if (!TableContext.Contains(asAddrObjDivision))
                            {
                                TableContext.Add(asAddrObjDivision);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_ADDR_OBJ_PARAMS"))
                    {
                        var TableContext = ContextDB.AsAddrObjParams;
                        var reader = XmlReader.Create(filepath);
                        AsAddrObjParam asAddrObjParams;

                        while (reader.ReadToFollowing("PARAM"))
                        {
                            asAddrObjParams = AsAddrObjParam.GetAttributeValue(reader);
                            if (!TableContext.Contains(asAddrObjParams))
                            {
                                TableContext.Add(asAddrObjParams);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_ADM_HIERARCHY"))
                    {
                        var TableContext = ContextDB.AsAdmHierarchies;
                        var reader = XmlReader.Create(filepath);
                        AsAdmHierarchy asAdmHierarchy;

                        while (reader.ReadToFollowing("ITEM"))
                        {
                            asAdmHierarchy = AsAdmHierarchy.GetAttributeValue(reader);
                            if (!TableContext.Contains(asAdmHierarchy))
                            {
                                TableContext.Add(asAdmHierarchy);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_APARTMENTS"))
                    {
                        var TableContext = ContextDB.AsApartments;
                        var reader = XmlReader.Create(filepath);
                        AsApartment asApartments;

                        while (reader.ReadToFollowing("APARTMENT"))
                        {
                            asApartments = AsApartment.GetAttributeValue(reader);
                            if (!TableContext.Contains(asApartments))
                            {
                                TableContext.Add(asApartments);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_APARTMENTS_PARAMS"))
                    {
                        var TableContext = ContextDB.AsApartmentsParams;
                        var reader = XmlReader.Create(filepath);
                        AsApartmentsParam asApartmentsParams;

                        while (reader.ReadToFollowing("PARAM"))
                        {
                            asApartmentsParams = AsApartmentsParam.GetAttributeValue(reader);
                            if (!TableContext.Contains(asApartmentsParams))
                            {
                                TableContext.Add(asApartmentsParams);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_CARPLACES"))
                    {
                        var TableContext = ContextDB.AsCarplaces;
                        var reader = XmlReader.Create(filepath);
                        AsCarplace asCarplaces;

                        while (reader.ReadToFollowing("CARPLACE"))
                        {
                            asCarplaces = AsCarplace.GetAttributeValue(reader);
                            if (!TableContext.Contains(asCarplaces))
                            {
                                TableContext.Add(asCarplaces);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_CARPLACES_PARAMS"))
                    {
                        var TableContext = ContextDB.AsCarplacesParams;
                        var reader = XmlReader.Create(filepath);
                        AsCarplacesParam asCarplacesParams;

                        while (reader.ReadToFollowing("PARAM"))
                        {
                            asCarplacesParams = AsCarplacesParam.GetAttributeValue(reader);
                            if (!TableContext.Contains(asCarplacesParams))
                            {
                                TableContext.Add(asCarplacesParams);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_CHANGE_HISTORY"))
                    {
                        var TableContext = ContextDB.AsChangeHistories;
                        var reader = XmlReader.Create(filepath);
                        AsChangeHistory asChangeHistory;

                        while (reader.ReadToFollowing("ITEM"))
                        {
                            asChangeHistory = AsChangeHistory.GetAttributeValue(reader);
                            if (!TableContext.Contains(asChangeHistory))
                            {
                                TableContext.Add(asChangeHistory);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_HOUSES"))
                    {
                        var TableContext = ContextDB.AsHouses;
                        var reader = XmlReader.Create(filepath);
                        AsHouse asHouses;

                        while (reader.ReadToFollowing("HOUSE"))
                        {
                            asHouses = AsHouse.GetAttributeValue(reader);
                            if (!TableContext.Contains(asHouses))
                            {
                                TableContext.Add(asHouses);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_HOUSES_PARAMS"))
                    {
                        var TableContext = ContextDB.AsHousesParams;
                        var reader = XmlReader.Create(filepath);
                        AsHousesParam asHousesParams;

                        while (reader.ReadToFollowing("PARAM"))
                        {
                            asHousesParams = AsHousesParam.GetAttributeValue(reader);
                            if (!TableContext.Contains(asHousesParams))
                            {
                                TableContext.Add(asHousesParams);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_MUN_HIERARCHY"))
                    {
                        var TableContext = ContextDB.AsMunHierarchies;
                        var reader = XmlReader.Create(filepath);
                        AsMunHierarchy asMunHierarchy;

                        while (reader.ReadToFollowing("ITEM"))
                        {
                            asMunHierarchy = AsMunHierarchy.GetAttributeValue(reader);
                            if (!TableContext.Contains(asMunHierarchy))
                            {
                                TableContext.Add(asMunHierarchy);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_NORMATIVE_DOCS") && !(filepath.Contains("AS_NORMATIVE_DOCS_KINDS") || filepath.Contains("AS_NORMATIVE_DOCS_TYPES")))
                    {
                        var TableContext = ContextDB.AsNormativeDocs;
                        var reader = XmlReader.Create(filepath);
                        AsNormativeDoc asNormativeDocs;

                        while (reader.ReadToFollowing("NORMDOC"))
                        {
                            asNormativeDocs = AsNormativeDoc.GetAttributeValue(reader);
                            if (!TableContext.Contains(asNormativeDocs))
                            {
                                TableContext.Add(asNormativeDocs);
                                ContextDB.SaveChanges();
                            }

                        }
                    }
                    else if (filepath.Contains("AS_REESTR_OBJECTS"))
                    {
                        var TableContext = ContextDB.AsReestrObjects;
                        var reader = XmlReader.Create(filepath);
                        AsReestrObject asReestrObjects;

                        while (reader.ReadToFollowing("OBJECT"))
                        {
                            asReestrObjects = AsReestrObject.GetAttributeValue(reader);
                            if (!TableContext.Contains(asReestrObjects))
                            {
                                TableContext.Add(asReestrObjects);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_ROOMS"))
                    {
                        var TableContext = ContextDB.AsRooms;
                        var reader = XmlReader.Create(filepath);
                        AsRoom asRooms;

                        while (reader.ReadToFollowing("ROOM"))
                        {
                            asRooms = AsRoom.GetAttributeValue(reader);
                            if (!TableContext.Contains(asRooms))
                            {
                                TableContext.Add(asRooms);
                                ContextDB.SaveChanges();
                            }
                        }

                    }
                    else if (filepath.Contains("AS_ROOMS_PARAMS"))
                    {
                        var TableContext = ContextDB.AsRoomsParams;
                        var reader = XmlReader.Create(filepath);
                        AsRoomsParam asRoomsParams;

                        while (reader.ReadToFollowing("PARAM"))
                        {
                            asRoomsParams = AsRoomsParam.GetAttributeValue(reader);
                            if (!TableContext.Contains(asRoomsParams))
                            {
                                TableContext.Add(asRoomsParams);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_STEADS"))
                    {
                        var TableContext = ContextDB.AsSteads;
                        var reader = XmlReader.Create(filepath);
                        AsStead asSteads;

                        while (reader.ReadToFollowing("STEAD"))
                        {
                            asSteads = AsStead.GetAttributeValue(reader);
                            if (!TableContext.Contains(asSteads))
                            {
                                TableContext.Add(asSteads);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_STEADS_PARAMS"))
                    {
                        var TableContext = ContextDB.AsSteadsParams;
                        var reader = XmlReader.Create(filepath);
                        AsSteadsParam asSteadsParams;

                        while (reader.ReadToFollowing("PARAM"))
                        {
                            asSteadsParams = AsSteadsParam.GetAttributeValue(reader);
                            if (!TableContext.Contains(asSteadsParams))
                            {
                                TableContext.Add(asSteadsParams);
                                ContextDB.SaveChanges();
                            }
                        }
                    }//.................................................................................................
                    else if (filepath.Contains("AS_ADDHOUSE_TYPES"))
                    {
                        var TableContext = ContextDB.AsAddhouseTypes;
                        var reader = XmlReader.Create(filepath);
                        AsAddhouseType asAddhouseType;

                        while (reader.ReadToFollowing("HOUSETYPE"))
                        {
                            asAddhouseType = AsAddhouseType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asAddhouseType))
                            {
                                TableContext.Add(asAddhouseType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_ADDR_OBJ_TYPES"))
                    {
                        var TableContext = ContextDB.AsAddrObjTypes;
                        var reader = XmlReader.Create(filepath);
                        AsAddrObjType asAddrObjType;

                        while (reader.ReadToFollowing("ADDRESSOBJECTTYPE"))
                        {
                            asAddrObjType = AsAddrObjType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asAddrObjType))
                            {
                                TableContext.Add(asAddrObjType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_APARTMENT_TYPES"))
                    {
                        var TableContext = ContextDB.AsApartmentTypes;
                        var reader = XmlReader.Create(filepath);
                        AsApartmentType asApartmentType;

                        while (reader.ReadToFollowing("APARTMENTTYPE"))
                        {
                            asApartmentType = AsApartmentType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asApartmentType))
                            {
                                TableContext.Add(asApartmentType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_HOUSE_TYPES"))
                    {
                        var TableContext = ContextDB.AsHouseTypes;
                        var reader = XmlReader.Create(filepath);
                        AsHouseType asHouseType;

                        while (reader.ReadToFollowing("HOUSETYPE"))
                        {
                            asHouseType = AsHouseType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asHouseType))
                            {
                                TableContext.Add(asHouseType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_NORMATIVE_DOCS_KINDS"))
                    {
                        var TableContext = ContextDB.AsNormativeDocsKinds;
                        var reader = XmlReader.Create(filepath);
                        AsNormativeDocsKind asNormativeDocsKind;

                        while (reader.ReadToFollowing("NDOCKIND"))
                        {
                            asNormativeDocsKind = AsNormativeDocsKind.GetAttributeValue(reader);
                            if (!TableContext.Contains(asNormativeDocsKind))
                            {
                                TableContext.Add(asNormativeDocsKind);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_NORMATIVE_DOCS_TYPES"))
                    {
                        var TableContext = ContextDB.AsNormativeDocsTypes;
                        var reader = XmlReader.Create(filepath);
                        AsNormativeDocsType asNormativeDocsType;

                        while (reader.ReadToFollowing("NDOCTYPE"))
                        {
                            asNormativeDocsType = AsNormativeDocsType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asNormativeDocsType))
                            {
                                TableContext.Add(asNormativeDocsType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_OBJECT_LEVELS"))
                    {
                        var TableContext = ContextDB.AsObjectLevels;
                        var reader = XmlReader.Create(filepath);
                        AsObjectLevel asObjectLevel;

                        while (reader.ReadToFollowing("OBJECTLEVEL"))
                        {
                            asObjectLevel = AsObjectLevel.GetAttributeValue(reader);
                            if (!TableContext.Contains(asObjectLevel))
                            {
                                TableContext.Add(asObjectLevel);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_OPERATION_TYPES"))
                    {
                        var TableContext = ContextDB.AsOperationTypes;
                        var reader = XmlReader.Create(filepath);
                        AsOperationType asOperationType;

                        while (reader.ReadToFollowing("OPERATIONTYPE"))
                        {
                            asOperationType = AsOperationType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asOperationType))
                            {
                                TableContext.Add(asOperationType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_PARAM_TYPES"))
                    {
                        var TableContext = ContextDB.AsParamTypes;
                        var reader = XmlReader.Create(filepath);
                        AsParamType asParamType;

                        while (reader.ReadToFollowing("PARAMTYPE"))
                        {
                            asParamType = AsParamType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asParamType))
                            {
                                TableContext.Add(asParamType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                    else if (filepath.Contains("AS_ROOM_TYPES"))
                    {
                        var TableContext = ContextDB.AsRoomTypes;
                        var reader = XmlReader.Create(filepath);
                        AsRoomType asRoomType;

                        while (reader.ReadToFollowing("ROOMTYPE"))
                        {
                            asRoomType = AsRoomType.GetAttributeValue(reader);
                            if (!TableContext.Contains(asRoomType))
                            {
                                TableContext.Add(asRoomType);
                                ContextDB.SaveChanges();
                            }
                        }
                    }
                }
            }
        }
    }
}
