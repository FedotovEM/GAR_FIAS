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
    [Table("AS_APARTMENTS")]
    public partial class AsApartments
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
        [Column("APARTTYPE")]
        public short Aparttype { get; set; }
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

        public static AsApartments GetAttributeValue(XmlElement item)
        {
            AsApartments asApartments = new AsApartments();

            asApartments.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asApartments.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asApartments.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asApartments.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asApartments.Number = item.Attributes.GetNamedItem("NUMBER").Value;
            asApartments.Aparttype = short.Parse(item.Attributes.GetNamedItem("APARTTYPE").Value);
            asApartments.Opertypeid = short.Parse(item.Attributes.GetNamedItem("OPERTYPEID").Value); 
           
            if (item.HasAttribute("PREVID"))
                asApartments.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asApartments.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asApartments.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asApartments.Nextid = null;

            asApartments.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asApartments.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asApartments.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactualValue = item.Attributes.GetNamedItem("ISACTUAL").Value;
            if (IsactualValue == "1")
                asApartments.Isactual = true;
            else
                asApartments.Isactual = false;

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asApartments.Isactive = true;
            else
                asApartments.Isactive = false;

            return asApartments;
        }
    }
}
