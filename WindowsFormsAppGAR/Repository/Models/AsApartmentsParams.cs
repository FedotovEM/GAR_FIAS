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
    [Table("AS_APARTMENTS_PARAMS")]
    public partial class AsApartmentsParams
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("CHANGEIDEND")]
        public long Changeidend { get; set; }
        [Column("TYPEID")]
        public int Typeid { get; set; }
        [Required]
        [Column("VALUE")]
        [StringLength(36)]
        public string Value { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }

        public static AsApartmentsParams GetAttributeValue(XmlElement item)
        {
            AsApartmentsParams asApartmentsParams = new AsApartmentsParams();

            asApartmentsParams.Id = long.Parse(item.Attributes.GetNamedItem("ID").Value);
            asApartmentsParams.Objectid = long.Parse(item.Attributes.GetNamedItem("OBJECTID").Value);
            asApartmentsParams.Changeid = long.Parse(item.Attributes.GetNamedItem("CHANGEID").Value);
            asApartmentsParams.Changeidend = long.Parse(item.Attributes.GetNamedItem("CHANGEIDEND").Value);
            asApartmentsParams.Typeid = int.Parse(item.Attributes.GetNamedItem("TYPEID").Value);
            asApartmentsParams.Value = item.Attributes.GetNamedItem("VALUE").Value;
            asApartmentsParams.Updatedate = DateTime.Parse(item.Attributes.GetNamedItem("UPDATEDATE").Value);
            asApartmentsParams.Startdate = DateTime.Parse(item.Attributes.GetNamedItem("STARTDATE").Value);
            asApartmentsParams.Enddate = DateTime.Parse(item.Attributes.GetNamedItem("ENDDATE").Value);

            return asApartmentsParams;
        }
    }
}
