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
    [Table("AS_CARPLACES")]
    public partial class AsCarplaces
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
        [Required]
        [Column("NUMBER")]
        [StringLength(50)]
        public string Number { get; set; }
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

        public static AsCarplaces GetAttributeValue(XmlElement item)
        {
            AsCarplaces asCarplaces = new AsCarplaces();

            asCarplaces.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asCarplaces.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asCarplaces.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asCarplaces.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asCarplaces.Number = item.Attributes.GetNamedItem("NUMBER").Value;
            asCarplaces.Opertypeid = short.Parse(item.Attributes.GetNamedItem("OPERTYPEID").Value);

            if (item.HasAttribute("PREVID"))
                asCarplaces.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asCarplaces.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asCarplaces.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asCarplaces.Nextid = null;

            asCarplaces.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asCarplaces.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asCarplaces.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactualValue = item.Attributes.GetNamedItem("ISACTUAL").Value;
            if (IsactualValue == "1")
                asCarplaces.Isactual = true;
            else
                asCarplaces.Isactual = false;

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asCarplaces.Isactive = true;
            else
                asCarplaces.Isactive = false;

            return asCarplaces;
        }
    }
}
