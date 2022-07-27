using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository.Models
{
    [Table("AS_HOUSES")]
    public partial class AsHouses
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Required]
        [Column("OBJECTGUID")]
        [StringLength(36)]
        public string Objectguid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("HOUSENUM")]
        [StringLength(50)]
        public string Housenum { get; set; }
        [Column("ADDNUM1")]
        [StringLength(50)]
        public string Addnum1 { get; set; }
        [Column("ADDNUM2")]
        [StringLength(50)]
        public string Addnum2 { get; set; }
        [Column("HOUSETYPE")]
        public byte? Housetype { get; set; }
        [Column("ADDTYPE1")]
        public byte? Addtype1 { get; set; }
        [Column("ADDTYPE2")]
        public byte? Addtype2 { get; set; }
        [Column("OPERTYPEID")]
        public short Opertypeid { get; set; }
        [Column("PREVID")]
        public long? Previd { get; set; }
        [Column("NEXTID")]
        public long? Nextid { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTUAL")]
        public bool Isactual { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsHouses GetAttributeValue(XmlElement item)
        {
            AsHouses asHouses = new AsHouses();

            asHouses.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asHouses.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asHouses.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asHouses.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asHouses.Housenum = item.Attributes.GetNamedItem("HOUSENUM").Value;
            asHouses.Addnum1 = item.Attributes.GetNamedItem("ADDNUM1").Value;
            asHouses.Addnum2 = item.Attributes.GetNamedItem("ADDNUM2").Value;

            if (item.HasAttribute("HOUSETYPE"))
                asHouses.Housetype = byte.Parse(item.Attributes.GetNamedItem("HOUSETYPE").Value);
            else
                asHouses.Housetype = null;

            if (item.HasAttribute("ADDTYPE1"))
                asHouses.Addtype1 = byte.Parse(item.Attributes.GetNamedItem("ADDTYPE1").Value);
            else
                asHouses.Addtype1 = null;

            if (item.HasAttribute("ADDTYPE2"))
                asHouses.Addtype2 = byte.Parse(item.Attributes.GetNamedItem("ADDTYPE2").Value);
            else
                asHouses.Addtype2 = null;

            asHouses.Opertypeid = short.Parse(item.Attributes.GetNamedItem("OPERTYPEID").Value);

            if (item.HasAttribute("PREVID"))
                asHouses.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asHouses.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asHouses.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asHouses.Nextid = null;

            asHouses.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asHouses.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asHouses.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactualValue = item.Attributes.GetNamedItem("ISACTUAL").Value;
            if (IsactualValue == "1")
                asHouses.Isactual = true;
            else
                asHouses.Isactual = false;

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asHouses.Isactive = true;
            else
                asHouses.Isactive = false;

            return asHouses;
        }
    }
}
