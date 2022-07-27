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
    [Table("AS_STEADS")]
    public partial class AsSteads
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
        [StringLength(250)]
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

        public static AsSteads GetAttributeValue(XmlElement item)
        {
            AsSteads asSteads = new AsSteads();

            asSteads.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asSteads.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asSteads.Objectguid = item.Attributes.GetNamedItem("OBJECTGUID").Value;
            asSteads.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asSteads.Number = item.Attributes.GetNamedItem("NUMBER").Value;
            asSteads.Opertypeid = short.Parse(item.Attributes.GetNamedItem("OPERTYPEID").Value);

            if (item.HasAttribute("PREVID"))
                asSteads.Previd = long.Parse(item.Attributes.GetNamedItem("PREVID").Value);
            else
                asSteads.Previd = null;

            if (item.HasAttribute("NEXTID"))
                asSteads.Nextid = long.Parse(item.Attributes.GetNamedItem("NEXTID").Value);
            else
                asSteads.Nextid = null;

            asSteads.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asSteads.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asSteads.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            string IsactualValue = item.Attributes.GetNamedItem("ISACTUAL").Value;
            if (IsactualValue == "1")
                asSteads.Isactual = true;
            else
                asSteads.Isactual = false;

            string IsactiveValue = item.Attributes.GetNamedItem("ISACTIVE").Value;
            if (IsactiveValue == "1")
                asSteads.Isactive = true;
            else
                asSteads.Isactive = false;

            return asSteads;
        }
    }
}
